using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal class InstanceInterfaceGenerator : InterfaceGenerator
  {
    public InstanceInterfaceGenerator (
      Type wrappedType,
      IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
      IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
      WrapperatorHelper helper)
      : base(wrappedType, methods, properties, helper, new InstanceMemberGenerator(helper, wrappedType), WrapMode.Instance)
    {
    }

    protected override IEnumerable<CodeTypeReference> GetBaseTypes ()
    {
      if (Helper.ShouldTypeBeWrapped(WrappedType.BaseType))
        yield return new CodeTypeReference(Helper.GetFullInterfaceName(WrappedType.BaseType, WrapMode));

      if (typeof(IDisposable).IsAssignableFrom(WrappedType) && !typeof(IDisposable).IsAssignableFrom(WrappedType.BaseType))
        yield return new CodeTypeReference(typeof(IDisposable));
    }

    protected override IEnumerable<CodeTypeMember> GetMembers ()
    {
      yield return GetWrappedProperty();

      foreach (var member in base.GetMembers())
        yield return member;
    }

    private CodeTypeMember GetWrappedProperty ()
    {
      var wrappedProperty = new CodeMemberProperty
                            {
                              Name = Helper.GetPropertyName(WrappedType),
                              // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                              Attributes = MemberAttributes.Public | MemberAttributes.Final,
                              Type = new CodeTypeReference(WrappedType),
                              HasSet = false,
                              HasGet = true
                            };

      wrappedProperty.Comments.Add(
        new CodeCommentStatement("<summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>", true));

      return wrappedProperty;
    }
  }
}