using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal class StaticWrapperGenerator : WrapperGenerator
  {
    public StaticWrapperGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper)
        : base(wrappedType, methods, properties, helper, new StaticMemberGenerator(helper, wrappedType), WrapMode.Static)
    {
    }

    protected override IEnumerable<CodeTypeMember> GetConstructorMembers ()
    {
      yield break;
    }

    protected override IEnumerable<CodeTypeMember> GetDisposeMembers ()
    {
      yield break;
    }
  }
}