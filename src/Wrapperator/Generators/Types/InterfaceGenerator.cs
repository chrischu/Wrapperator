using System;
using System.Collections.Generic;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal abstract class InterfaceGenerator : TypeGenerator
  {
    protected InterfaceGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper,
        MemberGenerator memberGenerator,
        WrapMode wrapMode)
        : base(wrappedType, methods, properties, helper, memberGenerator, helper.GetInterfaceName(wrappedType, wrapMode), TypeType.Interface, wrapMode
            )
    {
    }
  }
}