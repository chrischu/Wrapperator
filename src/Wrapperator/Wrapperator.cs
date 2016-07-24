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

      if (helper.ShouldTypeBeWrapped(model.Type.BaseType))
        wrapperInterface.BaseTypes.Add(helper.GetInterfaceName(model.Type.BaseType));

      wrapperInterface.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(model.Type));

      ns.Types.Add(wrapperInterface);

      foreach (var propertyInfo in model.InterfaceProperties.OrderBy(x => x.Name).ThenBy(x => x.IsStatic()))
        wrapperInterface.Members.Add(ConvertPropertyInfoToCodeDomProperty(propertyInfo));

      foreach (var methodInfo in model.InterfaceMethods.OrderBy(x => x.Name).ThenBy(x => x.IsStatic))
        wrapperInterface.Members.Add(ConvertMethodInfoToCodeDomMethod(helper, methodInfo));

      helper.WriteToInterfaceFile(model.Type, sw => ConvertCompileUnitToCode(compileUnit, sw));
    }

    private static CodeMemberProperty ConvertPropertyInfoToCodeDomProperty (PropertyInfo propertyInfo)
    {
      var property = new CodeMemberProperty
                     {
                         Name = propertyInfo.Name,
                         Type = ConvertTypeToTypeReference(propertyInfo.PropertyType),
                         HasGet = propertyInfo.CanRead,
                         HasSet = propertyInfo.CanWrite,
                         // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                         Attributes = MemberAttributes.Public | MemberAttributes.Final
                     };

      var parameters = propertyInfo.GetIndexParameters();
      if (parameters.Length > 0)
        foreach (var parameter in parameters)
          property.Parameters.Add(new CodeParameterDeclarationExpression(ConvertTypeToTypeReference(parameter.ParameterType), parameter.Name));

      return property;
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

      if (helper.ShouldTypeBeWrapped(model.Type.BaseType))
        wrapperClass.BaseTypes.Add(helper.GetWrapperName(model.Type.BaseType));

      wrapperClass.BaseTypes.Add(new CodeTypeReference($"{helper.GetFullInterfaceName(model.Type)}"));
      wrapperClass.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(model.Type));

      ns.Types.Add(wrapperClass);

      if (!model.Type.IsStatic())
        AddWrappedPropertyAndCtorToWrapper(helper, model, wrapperClass);

      AddMethodsToWrapper(helper, model, wrapperClass);
      AddPropertiesToWrapper(helper, model, wrapperClass);

      if (typeof(IDisposable).IsAssignableFrom(model.Type))
        AddDisposeMethodToWrapper(helper, model, wrapperClass);

      if (helper.ShouldImplicitConversionOperatorsBeGenerated && !model.Type.IsStatic())
        AddImplicitConversionOperatorToWrappedType(helper, model, wrapperClass);

      helper.WriteToWrapperFile(model.Type, sw => ConvertCompileUnitToCode(compileUnit, sw));
    }

    private static void AddImplicitConversionOperatorToWrappedType (
        WrapperatorHelper helper,
        WrapperatorModel model,
        CodeTypeDeclaration wrapperClass)
    {
      var implicitConversionOperator =
          new CodeSnippetTypeMember(
              $"    public static implicit operator {model.Type.FullName} ({helper.GetWrapperName(model.Type)} wrapper)" + Environment.NewLine +
              "    {" + Environment.NewLine +
              $"      if (wrapper == null) return default({model.Type.FullName});" + Environment.NewLine +
              $"      return wrapper.{helper.GetPropertyName(model.Type)};" + Environment.NewLine +
              "    }");

      wrapperClass.Members.Add(implicitConversionOperator);
    }

    private static void AddDisposeMethodToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
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
              new CodeMethodReferenceExpression(new CodeFieldReferenceExpression { FieldName = helper.GetPropertyName(model.Type) }, "Dispose")));

      protectedDisposeMethod.Statements.Add(@if);
      wrapperClass.Members.Add(protectedDisposeMethod);

      if (helper.ShouldTypeBeWrapped(model.Type.BaseType) && typeof(IDisposable).IsAssignableFrom(model.Type.BaseType))
      {
        // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
        protectedDisposeMethod.Attributes |= MemberAttributes.Override;

        protectedDisposeMethod.Statements.Insert(
            0,
            new CodeExpressionStatement(
                new CodeMethodInvokeExpression(new CodeBaseReferenceExpression(), "Dispose", new CodeArgumentReferenceExpression("disposing"))));
      }
      else
      {
        var publicDisposeMethod = new CodeMemberMethod
                                  {
                                      Name = "Dispose",
                                      // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                                      Attributes = MemberAttributes.Public | MemberAttributes.Final
                                  };

        publicDisposeMethod.Statements.Add(
            new CodeMethodInvokeExpression(
                new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "Dispose"),
                new CodePrimitiveExpression(true)));

        publicDisposeMethod.Statements.Add(
            new CodeMethodInvokeExpression(
                new CodeMethodReferenceExpression(new CodeTypeReferenceExpression(typeof(GC)), "SuppressFinalize"),
                new CodeThisReferenceExpression()));

        wrapperClass.Members.Add(publicDisposeMethod);
      }
    }

    private static void AddMethodsToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      foreach (var memberModel in model.WrapperMethods.OrderBy(x => x.Member.Name).ThenBy(x => x.Member.IsStatic))
      {
        var methodInfo = memberModel.Member;
        var method = ConvertMethodInfoToCodeDomMethod(helper, methodInfo);

        var invokeTarget = methodInfo.IsStatic
            ? (CodeExpression) new CodeTypeReferenceExpression(ConvertTypeToTypeReference(model.Type))
            : new CodePropertyReferenceExpression { PropertyName = helper.GetPropertyName(model.Type) };

        if (memberModel.Overrides)
            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
          method.Attributes |= MemberAttributes.New;

        var parameters = methodInfo.GetParameters().Select(
            p =>
            {
              CodeExpression result;

              if (helper.ShouldParameterTypesGetWrapped && helper.ShouldTypeBeWrapped(p.ParameterType))
              {
                var getWrapped = $"(({helper.GetFullWrapperName(p.ParameterType)}){p.Name}).{helper.GetPropertyName(p.ParameterType)}";
                var nullHandling = $"{p.Name} == null ? default({p.ParameterType.FullName}) : {getWrapped}";

                result = new CodeSnippetExpression(nullHandling);
              }
              else
              {
                result = new CodeArgumentReferenceExpression(p.Name);
              }

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
          invoke = new CodeObjectCreateExpression($"{helper.GetFullWrapperName(methodInfo.ReturnType)}", invoke);

        if (methodInfo.ReturnType == typeof(void))
          method.Statements.Add(invoke);
        else
          method.Statements.Add(new CodeMethodReturnStatement(invoke));

        wrapperClass.Members.Add(method);
      }
    }

    private static void AddPropertiesToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      foreach (var memberModel in model.WrapperProperties.OrderBy(x => x.Member.Name).ThenBy(x => x.Member.IsStatic()))
      {
        var propertyInfo = memberModel.Member;

        var property = ConvertPropertyInfoToCodeDomProperty(propertyInfo);

        if (memberModel.Overrides)
            // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
          property.Attributes |= MemberAttributes.New;

        var invokeTarget = propertyInfo.IsStatic()
            ? (CodeExpression) new CodeTypeReferenceExpression(ConvertTypeToTypeReference(model.Type))
            : new CodePropertyReferenceExpression { PropertyName = helper.GetPropertyName(model.Type) };

        CodeExpression propertyReference = new CodePropertyReferenceExpression(invokeTarget, propertyInfo.Name);

        var parameters = propertyInfo.GetIndexParameters();
        if (parameters.Length > 0)
          propertyReference = new CodeIndexerExpression(
              invokeTarget,
              parameters.Select(p => new CodeArgumentReferenceExpression(p.Name)).ToArray<CodeExpression>());

        if (property.HasGet)
        {
          property.GetStatements.Add(new CodeMethodReturnStatement(propertyReference));
        }

        if (property.HasSet)
        {
          property.SetStatements.Add(
              new CodeAssignStatement(
                  propertyReference,
                  new CodePropertySetValueReferenceExpression()));
        }

        wrapperClass.Members.Add(property);
      }
    }

    private static void AddWrappedPropertyAndCtorToWrapper (WrapperatorHelper helper, WrapperatorModel model, CodeTypeDeclaration wrapperClass)
    {
      var propertyName = helper.GetPropertyName(model.Type);
      var parameterName = helper.GetParameterName(model.Type);

      var wrappedProperty =
          new CodeSnippetTypeMember($"    internal {model.Type.FullName} {propertyName} {{ get; private set; }}" + Environment.NewLine);
      wrapperClass.Members.Add(wrappedProperty);

      var constructor = new CodeConstructor
                        {
                            Name = helper.GetWrapperName(model.Type),
                            Attributes = MemberAttributes.Public
                        };

      if (helper.ShouldTypeBeWrapped(model.Type.BaseType))
        constructor.BaseConstructorArgs.Add(new CodeArgumentReferenceExpression(parameterName));

      constructor.Statements.Add(
          new CodeAssignStatement(
              new CodePropertyReferenceExpression { PropertyName = propertyName },
              new CodeArgumentReferenceExpression(parameterName)));

      constructor.Parameters.Add(new CodeParameterDeclarationExpression(ConvertTypeToTypeReference(model.Type), parameterName));

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
                           $"{helper.GetFullInterfaceName(methodInfo.ReturnType)}")
                           : ConvertTypeToTypeReference(methodInfo.ReturnType)
                   };

      if (methodInfo.ContainsGenericParameters)
        foreach (var genericArgument in methodInfo.GetGenericArguments())
          method.TypeParameters.Add(ConvertGenericArgument(genericArgument));

      foreach (var parameterInfo in methodInfo.GetParameters())
      {
        CodeParameterDeclarationExpression parameter;

        if (helper.ShouldParameterTypesGetWrapped && helper.ShouldTypeBeWrapped(parameterInfo.ParameterType))
        {
          var codeTypeReference = new CodeTypeReference(helper.GetFullInterfaceName(parameterInfo.ParameterType));
          parameter = new CodeParameterDeclarationExpression(codeTypeReference, parameterInfo.Name);
        }
        else
        {
          var codeTypeReference = ConvertTypeToTypeReference(parameterInfo.ParameterType);
          parameter = new CodeParameterDeclarationExpression(codeTypeReference, parameterInfo.Name);
        }

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