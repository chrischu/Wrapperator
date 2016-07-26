using System;
using System.Collections.Generic;
using System.Reflection;

namespace Wrapperator.Model
{
  internal class WrapperatorModel
  {
    public WrapperatorModel (
        Type type,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> interfaceMethods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> interfaceProperties,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> wrapperMethods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> wrapperProperties)
    {
      Type = type;
      InterfaceMethods = interfaceMethods;
      InterfaceProperties = interfaceProperties;
      WrapperMethods = wrapperMethods;
      WrapperProperties = wrapperProperties;
    }

    public Type Type { get; }

    public IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> InterfaceMethods { get; }
    public IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> InterfaceProperties { get; }

    public IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> WrapperMethods { get; }
    public IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> WrapperProperties { get; }
  }
}