using System;

namespace Wrapperator.Extensions
{
  internal static class TypeExtensions
  {
    public static bool IsStatic(this Type type)
    {
      return type.IsAbstract && type.IsSealed;
    }
  }
}
