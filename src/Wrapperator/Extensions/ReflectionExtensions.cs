using System;
using System.Reflection;

namespace Wrapperator.Extensions
{
  internal static class ReflectionExtensions
  {
    public static bool IsStatic (this Type type)
    {
      return type.IsAbstract && type.IsSealed;
    }

    public static bool IsStatic (this PropertyInfo propertyInfo)
    {
      return propertyInfo.GetMethod?.IsStatic == true || propertyInfo.SetMethod?.IsStatic == true;
    }

    public static bool IsOverriding (this PropertyInfo propertyInfo, Func<MethodInfo, bool> additionalPredicate = null)
    {
      return (propertyInfo.GetMethod?.IsOverriding(additionalPredicate) ?? false)
             || (propertyInfo.SetMethod?.IsOverriding(additionalPredicate) ?? false);
    }

    public static bool IsOverriding (this MethodInfo methodInfo, Func<MethodInfo, bool> additionalPredicate = null)
    {
      if (methodInfo == null)
        return false;

      var baseDefinition = methodInfo.GetBaseDefinition();
      return baseDefinition != methodInfo && (additionalPredicate?.Invoke(baseDefinition) ?? true);
    }
  }
}