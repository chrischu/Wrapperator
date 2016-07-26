using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal class InstanceWrapperGenerator : WrapperGenerator
  {
    public InstanceWrapperGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper)
        : base(wrappedType, methods, properties, helper, new InstanceMemberGenerator(helper, wrappedType), WrapMode.Instance)
    {
    }

    protected override IEnumerable<CodeTypeReference> GetBaseTypes ()
    {
      var baseTypes = base.GetBaseTypes();

      if (Helper.ShouldTypeBeWrapped(WrappedType.BaseType))
        baseTypes = new[] { new CodeTypeReference(Helper.GetWrapperName(WrappedType.BaseType, WrapMode)) }.Concat(baseTypes);

      return baseTypes;
    }

    protected override IEnumerable<CodeTypeMember> GetConstructorMembers ()
    {
      var propertyName = Helper.GetPropertyName(WrappedType);
      var parameterName = Helper.GetParameterName(WrappedType);

      var wrappedProperty =
          new CodeSnippetTypeMember($"    internal {WrappedType.FullName} {propertyName} {{ get; private set; }}" + Environment.NewLine);
      yield return wrappedProperty;

      var constructor = new CodeConstructor { Attributes = MemberAttributes.Public };

      if (Helper.ShouldTypeBeWrapped(WrappedType.BaseType))
        constructor.BaseConstructorArgs.Add(new CodeArgumentReferenceExpression(parameterName));

      constructor.Statements.Add(
          new CodeAssignStatement(
              new CodePropertyReferenceExpression { PropertyName = propertyName },
              new CodeArgumentReferenceExpression(parameterName)));

      constructor.Parameters.Add(new CodeParameterDeclarationExpression(ConvertTypeToTypeReference(WrappedType), parameterName));
      yield return constructor;
    }

    protected override IEnumerable<CodeTypeMember> GetDisposeMembers ()
    {
      if (!typeof(IDisposable).IsAssignableFrom(WrappedType))
        yield break;

      var protectedDisposeMethod = new CodeMemberMethod
                                   {
                                       Name = "Dispose",
                                       Attributes = MemberAttributes.Family,
                                       Parameters = { new CodeParameterDeclarationExpression(typeof(bool), "disposing") }
                                   };

      var @if = new CodeConditionStatement(new CodeArgumentReferenceExpression("disposing"));
      @if.TrueStatements.Add(
          new CodeMethodInvokeExpression(
              new CodeMethodReferenceExpression(new CodeFieldReferenceExpression { FieldName = Helper.GetPropertyName(WrappedType) }, "Dispose")));

      protectedDisposeMethod.Statements.Add(@if);

      if (Helper.ShouldTypeBeWrapped(WrappedType.BaseType) && typeof(IDisposable).IsAssignableFrom(WrappedType.BaseType))
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

        yield return publicDisposeMethod;
      }

      yield return protectedDisposeMethod;
    }
  }
}