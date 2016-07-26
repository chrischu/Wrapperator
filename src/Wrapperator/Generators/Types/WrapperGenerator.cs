using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal abstract class WrapperGenerator : TypeGenerator
  {
    protected WrapperGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper,
        MemberGenerator memberGenerator,
        WrapMode wrapMode)
        : base(wrappedType, methods, properties, helper, memberGenerator, helper.GetWrapperName(wrappedType, wrapMode), TypeType.Class, wrapMode)
    {
    }

    protected override IEnumerable<CodeTypeReference> GetBaseTypes ()
    {
      yield return new CodeTypeReference(Helper.GetFullInterfaceName(WrappedType, WrapMode));
    }

    protected sealed override IEnumerable<CodeTypeMember> GetMembers ()
    {
      foreach (var member in GetConstructorMembers())
        yield return member;

      foreach (var member in base.GetMembers())
        yield return member;

      foreach (var member in GetDisposeMembers())
        yield return member;
    }

    protected abstract IEnumerable<CodeTypeMember> GetConstructorMembers ();

    protected abstract IEnumerable<CodeTypeMember> GetDisposeMembers ();
  }
}