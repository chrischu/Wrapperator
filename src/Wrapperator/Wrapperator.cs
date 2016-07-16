using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Reflection;
using Wrapperator.Extensions;

namespace Wrapperator
{
  internal static class Wrapperator
  {
    public static void Wrap (WrapperatorOptions options)
    {
      ValidateOptions(options);
      var helper = new WrapperatorHelper(options);

      foreach (var model in helper.Models)
      {
        GenerateInterface(helper, model);
        GenerateWrapper(helper, model);
      }
    }

    private static void GenerateInterface (WrapperatorHelper helper, WrapperatorModel model)
    {
      var compileUnit = new CodeCompileUnit();

      var ns = new CodeNamespace(helper.GetInterfaceNamespace(model.Type));
      compileUnit.Namespaces.Add(ns);

      var wrapperInterface = new CodeTypeDeclaration(helper.GetInterfaceName(model.Type))
                             {
                                 TypeAttributes = TypeAttributes.Public | TypeAttributes.Interface,
                                 IsPartial = true
                             };

      if (typeof(IDisposable).IsAssignableFrom(model.Type))
        wrapperInterface.BaseTypes.Add(new CodeTypeReference(typeof(IDisposable)));

      wrapperInterface.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(model.Type));

      ns.Types.Add(wrapperInterface);

      foreach (var methodInfo in model.Methods.OrderBy(x => x.Name).ThenBy(x => x.IsStatic))
        wrapperInterface.Members.Add(ConvertMethodInfoToCodeDomMethod(helper, methodInfo));

      helper.WriteToInterfaceFile(model.Type, sw => ConvertCompileUnitToCode(compileUnit, sw));
    }

    private static void GenerateWrapper (WrapperatorHelper helper, WrapperatorModel model)
    {
      var compileUnit = new CodeCompileUnit();

      var ns = new CodeNamespace(helper.GetWrapperNamespace(model.Type));
      compileUnit.Namespaces.Add(ns);

      var wrapperClass = new CodeTypeDeclaration(helper.GetWrapperName(model.Type))
                         {
                             TypeAttributes = TypeAttributes.Public | TypeAttributes.Class,
                             IsPartial = true
                         };
      wrapperClass.BaseTypes.Add(new CodeTypeReference($"{helper.GetInterfaceNamespace(model.Type)}.{helper.GetInterfaceName(model.Type)}"));
      wrapperClass.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(model.Type));

      ns.Types.Add(wrapperClass);

      if (!model.Type.IsStatic())
        AddWrappedFieldToWrapper(helper, model, wrapperClass);

      AddMethodsToWrapper(helper, model, wrapperClass);

      if (typeof(IDisposable).IsAssignableFrom(model.Type))
        AddDisposeMethodToWrapper(model, wrapperClass);

      helper.WriteToWrapperFile(model.Type, sw => ConvertCompileUnitToCode(compileUnit, sw));
    }

    private static void AddDisposeMethodToWrapper (WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      var protectedDisposeMethod = new CodeMemberMethod
                                   {
                                       Name = "Dispose",
                                       Attributes = MemberAttributes.Family,
                                       Parameters = { new CodeParameterDeclarationExpression(typeof(bool), "disposing") }
                                   };

      var @if = new CodeConditionStatement(new CodeArgumentReferenceExpression("disposing"));
      @if.TrueStatements.Add(
          new CodeMethodInvokeExpression(
              new CodeMethodReferenceExpression(new CodeFieldReferenceExpression { FieldName = model.FieldName }, "Dispose")));

      protectedDisposeMethod.Statements.Add(@if);
      wrapperClass.Members.Add(protectedDisposeMethod);

      var publicDisposeMethod = new CodeMemberMethod
                                {
                                    Name = "Dispose",
                                    // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                                    Attributes = MemberAttributes.Public | MemberAttributes.Final
                                };

      publicDisposeMethod.Statements.Add(new CodeMethodInvokeExpression(
          new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "Dispose"),
          new CodePrimitiveExpression(true)));

      publicDisposeMethod.Statements.Add(
          new CodeMethodInvokeExpression(
              new CodeMethodReferenceExpression(new CodeTypeReferenceExpression(typeof(GC)), "SuppressFinalize"),
              new CodeThisReferenceExpression()));

      wrapperClass.Members.Add(publicDisposeMethod);
    }

    private static void AddMethodsToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      foreach (var methodInfo in model.Methods.OrderBy(x => x.Name).ThenBy(x => x.IsStatic))
      {
        var method = ConvertMethodInfoToCodeDomMethod(helper, methodInfo);

        var invokeTarget = methodInfo.IsStatic
            ? (CodeExpression) new CodeTypeReferenceExpression(ConvertTypeToTypeReference(model.Type))
            : new CodeFieldReferenceExpression { FieldName = model.FieldName };

        var parameters = methodInfo.GetParameters().Select(
            p =>
            {
              CodeExpression result = new CodeArgumentReferenceExpression(p.Name);

              if (p.IsOut && !p.ParameterType.IsArray)
                result = new CodeDirectionExpression(FieldDirection.Out, result);
              else if (p.ParameterType.IsByRef)
                result = new CodeDirectionExpression(FieldDirection.Ref, result);

              return result;
            }).ToArray();

        CodeExpression invoke = new CodeMethodInvokeExpression(
            new CodeMethodReferenceExpression(
                invokeTarget,
                methodInfo.Name,
                method.TypeParameters.OfType<CodeTypeParameter>()
                    .Select(p => new CodeTypeReference(p.Name, CodeTypeReferenceOptions.GenericTypeParameter))
                    .ToArray()),
            parameters);

        if (helper.ShouldTypeBeWrapped(methodInfo.ReturnType))
          invoke =
              new CodeObjectCreateExpression(
                  $"{helper.GetWrapperNamespace(methodInfo.ReturnType)}.{helper.GetWrapperName(methodInfo.ReturnType)}",
                  invoke);

        if (methodInfo.ReturnType == typeof(void))
          method.Statements.Add(invoke);
        else
          method.Statements.Add(new CodeMethodReturnStatement(invoke));

        wrapperClass.Members.Add(method);
      }
    }

    private static void AddWrappedFieldToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      var wrappedField = new CodeMemberField(ConvertTypeToTypeReference(model.Type), model.FieldName);
      wrapperClass.Members.Add(wrappedField);

      var constructor = new CodeConstructor
                        {
                            Name = helper.GetWrapperName(model.Type),
                            Attributes = MemberAttributes.Public
                        };
      constructor.Statements.Add(
          new CodeAssignStatement(
              new CodeFieldReferenceExpression { FieldName = model.FieldName },
              new CodeArgumentReferenceExpression(model.ParameterName)));

      constructor.Parameters.Add(new CodeParameterDeclarationExpression(ConvertTypeToTypeReference(model.Type), model.ParameterName));

      wrapperClass.Members.Add(constructor);
    }

    private static void ConvertCompileUnitToCode (CodeCompileUnit compileUnit, StreamWriter @out)
    {
      using (var provider = CodeDomProvider.CreateProvider("CSharp"))
      {
        var codeGenOptions = new CodeGeneratorOptions { BracingStyle = "C", IndentString = "  ", BlankLinesBetweenMembers = true };
        provider.GenerateCodeFromCompileUnit(compileUnit, @out, codeGenOptions);
      }
    }

    private static CodeMemberMethod ConvertMethodInfoToCodeDomMethod (WrapperatorHelper helper, MethodInfo methodInfo)
    {
      var method = new CodeMemberMethod
                   {
                       Name = methodInfo.Name,
                       // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                       Attributes = MemberAttributes.Public | MemberAttributes.Final,
                       ReturnType = helper.ShouldTypeBeWrapped(methodInfo.ReturnType)
                           ? new CodeTypeReference(
                           $"{helper.GetInterfaceNamespace(methodInfo.ReturnType)}.{helper.GetInterfaceName(methodInfo.ReturnType)}")
                           : ConvertTypeToTypeReference(methodInfo.ReturnType)
                   };

      if (methodInfo.ContainsGenericParameters)
        foreach (var genericArgument in methodInfo.GetGenericArguments())
          method.TypeParameters.Add(ConvertGenericArgument(genericArgument));

      foreach (var parameterInfo in methodInfo.GetParameters())
      {
        var codeTypeReference = ConvertTypeToTypeReference(parameterInfo.ParameterType);
        var parameter = new CodeParameterDeclarationExpression(codeTypeReference, parameterInfo.Name);

        if (parameterInfo.IsOut && !parameterInfo.ParameterType.IsArray)
          parameter.Direction = FieldDirection.Out;

        if (parameterInfo.ParameterType.IsByRef)
          parameter.Direction = FieldDirection.Ref;

        method.Parameters.Add(parameter);
      }

      method.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(methodInfo));

      return method;
    }

    private static CodeTypeParameter ConvertGenericArgument (Type genericArgument)
    {
      var codeTypeParameter = new CodeTypeParameter(genericArgument.Name);

      var constraintAttributes = genericArgument.GenericParameterAttributes;

      if (constraintAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint))
        codeTypeParameter.HasConstructorConstraint = true;

      if (constraintAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
        codeTypeParameter.Constraints.Add(" class");

      if (constraintAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
        codeTypeParameter.Constraints.Add(" struct");

      return codeTypeParameter;
    }

    private static CodeTypeReference ConvertTypeToTypeReference (Type type)
    {
      if (type.IsByRef)
        type = type.GetElementType();

      return type.ContainsGenericParameters
          ? new CodeTypeReference(type.ToString(), type.GetGenericArguments().Select(ConvertTypeToTypeReference).ToArray())
          : new CodeTypeReference(type);
    }

    private static void ValidateOptions (WrapperatorOptions options)
    {
      foreach (var type in options.TypesToWrap)
      {
        if (!type.Namespace.AssertNotNull().StartsWith("System", StringComparison.InvariantCulture))
          throw new InvalidOperationException($"Wrapping '{type.FullName}' is not supported since it is not a type from the System library.");
      }

      if (!Directory.Exists(options.SolutionDirectory))
        throw new InvalidOperationException($"Solution directory '{options.SolutionDirectory}' does not exist.");
    }
  }
}