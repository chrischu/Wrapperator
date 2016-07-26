using System;
using System.CodeDom;
using System.Linq;
using System.Reflection;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Members
{
  internal abstract class MemberGenerator : CodeDomGenerator
  {
    protected MemberGenerator (WrapperatorHelper helper, Type wrappedType)
    {
      Helper = helper;
      WrappedType = wrappedType;
    }

    protected WrapperatorHelper Helper { get; }
    protected Type WrappedType { get; }

    protected abstract CodeExpression InvokeTarget { get; }

    public abstract bool ShouldMethodBeWrapped (WrapperatorMemberModel<MethodInfo> memberModel);
    public abstract bool ShouldPropertyBeWrapped (WrapperatorMemberModel<PropertyInfo> memberModel);

    public CodeMemberMethod GenerateMethod (WrapperatorMemberModel<MethodInfo> memberModel)
    {
      var methodInfo = memberModel.Member;
      var method = ConvertMethodInfoToCodeDomMethod(methodInfo);

      if (memberModel.Overrides)
          // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
        method.Attributes |= MemberAttributes.New;

      var parameters = GenerateMethodParameters(methodInfo);
      var statements = GenerateMethodStatements(method, parameters, memberModel, InvokeTarget);
      method.Statements.AddRange(statements);

      return method;
    }

    private CodeMemberMethod ConvertMethodInfoToCodeDomMethod (MethodInfo methodInfo)
    {
      var method = new CodeMemberMethod
                   {
                       Name = methodInfo.Name,
                       // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                       Attributes = MemberAttributes.Public | MemberAttributes.Final,
                       ReturnType = Helper.ShouldTypeBeWrapped(methodInfo.ReturnType)
                           ? new CodeTypeReference(
                           $"{Helper.GetFullInterfaceName(methodInfo.ReturnType, WrapMode.Instance)}")
                           : ConvertTypeToTypeReference(methodInfo.ReturnType)
                   };

      if (methodInfo.ContainsGenericParameters)
        foreach (var genericArgument in methodInfo.GetGenericArguments())
          method.TypeParameters.Add(ConvertGenericArgument(genericArgument));

      foreach (var parameterInfo in methodInfo.GetParameters())
      {
        CodeParameterDeclarationExpression parameter;

        if (Helper.ShouldParameterTypesGetWrapped && Helper.ShouldTypeBeWrapped(parameterInfo.ParameterType))
        {
          var codeTypeReference = new CodeTypeReference(Helper.GetFullInterfaceName(parameterInfo.ParameterType, WrapMode.Instance));
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

    private CodeExpression[] GenerateMethodParameters (MethodInfo methodInfo)
    {
      var parameters = methodInfo.GetParameters().Select(
          p =>
          {
            CodeExpression result;

            if (Helper.ShouldParameterTypesGetWrapped && Helper.ShouldTypeBeWrapped(p.ParameterType))
            {
              var getWrapped =
                  $"(({Helper.GetFullWrapperName(p.ParameterType, WrapMode.Instance)}){p.Name}).{Helper.GetPropertyName(p.ParameterType)}";
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
      return parameters;
    }

    private CodeStatement[] GenerateMethodStatements (
        CodeMemberMethod method,
        CodeExpression[] parameters,
        WrapperatorMemberModel<MethodInfo> methodModel,
        CodeExpression invokeTarget)
    {
      var methodInfo = methodModel.Member;

      CodeExpression invoke = new CodeMethodInvokeExpression(
          new CodeMethodReferenceExpression(
              invokeTarget,
              methodInfo.Name,
              method.TypeParameters.OfType<CodeTypeParameter>()
                  .Select(p => new CodeTypeReference(p.Name, CodeTypeReferenceOptions.GenericTypeParameter))
                  .ToArray()),
          parameters);

      if (Helper.ShouldTypeBeWrapped(methodInfo.ReturnType))
        invoke = new CodeObjectCreateExpression($"{Helper.GetFullWrapperName(methodInfo.ReturnType, WrapMode.Instance)}", invoke);

      return methodInfo.ReturnType == typeof(void)
          ? new CodeStatement[] { new CodeExpressionStatement(invoke) }
          : new CodeStatement[] { new CodeMethodReturnStatement(invoke) };
    }

    private CodeTypeParameter ConvertGenericArgument (Type genericArgument)
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

    public CodeMemberProperty GenerateProperty (WrapperatorMemberModel<PropertyInfo> memberModel)
    {
      var propertyInfo = memberModel.Member;
      var property = ConvertPropertyInfoToCodeDomProperty(propertyInfo);

      if (memberModel.Overrides)
          // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
        property.Attributes |= MemberAttributes.New;

      CodeExpression propertyReference = new CodePropertyReferenceExpression(InvokeTarget, propertyInfo.Name);

      var parameters = propertyInfo.GetIndexParameters();
      if (parameters.Length > 0)
        propertyReference = new CodeIndexerExpression(
            InvokeTarget,
            parameters.Select(p => new CodeArgumentReferenceExpression(p.Name)).ToArray<CodeExpression>());

      if (property.HasGet)
        property.GetStatements.AddRange(GeneratePropertyGetStatements(propertyReference));

      if (property.HasSet)
        property.SetStatements.AddRange(GeneratePropertySetStatements(propertyReference));

      return property;
    }

    private CodeMemberProperty ConvertPropertyInfoToCodeDomProperty (PropertyInfo propertyInfo)
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

    private CodeStatement[] GeneratePropertyGetStatements (CodeExpression propertyReference)
    {
      return new CodeStatement[] { new CodeMethodReturnStatement(propertyReference) };
    }

    private CodeStatement[] GeneratePropertySetStatements (CodeExpression propertyReference)
    {
      return new CodeStatement[]
             {
                 new CodeAssignStatement(
                     propertyReference,
                     new CodePropertySetValueReferenceExpression())
             };
    }
  }
}