using System;
using System.Collections.Generic;
using System.Reflection;

namespace Wrapperator
{
  internal class WrapperatorModel
  {
    public Type Type { get; }

    public IReadOnlyCollection<MethodInfo> InterfaceMethods { get; }
    public IReadOnlyCollection<PropertyInfo> InterfaceProperties { get; }

    public IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> WrapperMethods { get; }
    public IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> WrapperProperties { get; }

    public WrapperatorModel (Type type, IReadOnlyCollection<MethodInfo> interfaceMethods, IReadOnlyCollection<PropertyInfo> interfaceProperties, IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> wrapperMethods, IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> wrapperProperties)
    {
      Type = type;
      InterfaceMethods = interfaceMethods;
      InterfaceProperties = interfaceProperties;
      WrapperMethods = wrapperMethods;
      WrapperProperties = wrapperProperties;
    }
  }

  internal class WrapperatorMemberModel<T>
    where T : MemberInfo
  {
    public T Member { get; }
    public bool Overrides { get; }

    public WrapperatorMemberModel (T member, bool overrides)
    {
      Member = member;
      Overrides = overrides;
    }
  }
}