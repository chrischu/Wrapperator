using System;
using System.Reflection;

namespace Wrapperator.Model
{
  internal class WrapperatorMemberModel<T>
      where T : MemberInfo
  {
    public WrapperatorMemberModel (T member, bool overrides)
    {
      Member = member;
      Overrides = overrides;
    }

    public T Member { get; }
    public bool Overrides { get; }
  }
}