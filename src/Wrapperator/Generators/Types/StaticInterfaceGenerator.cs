using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal class StaticInterfaceGenerator : InterfaceGenerator
  {
    public StaticInterfaceGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper)
        : base(wrappedType, methods, properties, helper, new StaticMemberGenerator(helper, wrappedType), WrapMode.Static)
    {
    }

    protected override IEnumerable<CodeTypeReference> GetBaseTypes ()
    {
      yield break;
    }
  }
}