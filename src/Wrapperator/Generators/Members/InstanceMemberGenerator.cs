using System;
using System.CodeDom;
using System.Reflection;
using Wrapperator.Extensions;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Members
{
  internal class InstanceMemberGenerator : MemberGenerator
  {
    public InstanceMemberGenerator (WrapperatorHelper helper, Type wrappedType)
        : base(helper, wrappedType)
    {
    }

    protected override CodeExpression InvokeTarget => new CodePropertyReferenceExpression { PropertyName = Helper.GetPropertyName(WrappedType) };

    public override bool ShouldMethodBeWrapped (WrapperatorMemberModel<MethodInfo> memberModel)
    {
      return !memberModel.Member.IsStatic;
    }

    public override bool ShouldPropertyBeWrapped (WrapperatorMemberModel<PropertyInfo> memberModel)
    {
      return !memberModel.Member.IsStatic();
    }
  }
}