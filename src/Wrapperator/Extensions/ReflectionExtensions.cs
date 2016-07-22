using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Wrapperator.Extensions
{
  internal static class ReflectionExtensions
  {
    public static int HierarchyDepth(this Type type)
    {
      return type.GetBaseTypes().Count();
    }

    public static IEnumerable<Type> GetBaseTypes(this Type type)
    {
      type = type.BaseType;
      while (type != null)
      {
        yield return type;
        type = type.BaseType;
      }
    }

    public static bool HasMatchingMember(this Type type, MemberInfo memberInfo)
    {
      var methodInfo = memberInfo as MethodInfo;
      if (methodInfo != null)
        return type.HasMatchingMethod(methodInfo);

      var propertyInfo = memberInfo as PropertyInfo;
      if (propertyInfo != null)
        return type.HasMatchingProperty(propertyInfo);

      throw new InvalidOperationException("Invalid member type!");
    }

    private static bool HasMatchingProperty(this Type type, PropertyInfo propertyInfo)
    {
      var matchingProperty = type.GetProperty(propertyInfo.Name);
      return matchingProperty != null && matchingProperty.DeclaringType == type;
    }

    private static bool HasMatchingMethod(this Type type, MethodInfo methodInfo)
    {
      var matchingMethod = type.GetMethod(methodInfo.Name, methodInfo.GetParameters().Select(p => p.ParameterType).ToArray());
      return matchingMethod != null && matchingMethod.DeclaringType == type;
    }

    public static bool IsStatic (this Type type)
    {
      return type.IsAbstract && type.IsSealed;
    }

    public static bool IsStatic (this PropertyInfo propertyInfo)
    {
      return propertyInfo.GetMethod?.IsStatic == true || propertyInfo.SetMethod?.IsStatic == true;
    }

    private static MethodInfo GetRepresentingMethodInfo(this MemberInfo memberInfo)
    {
      var methodInfo = memberInfo as MethodInfo;
      if (methodInfo != null)
        return methodInfo;

      var propertyInfo = memberInfo as PropertyInfo;
      if (propertyInfo != null)
        return propertyInfo.GetMethod ?? propertyInfo.SetMethod;

      throw new InvalidOperationException("Invalid member type!");
    }

    public static Type GetBaseDeclaringType(this MemberInfo memberInfo)
    {
      return memberInfo.GetRepresentingMethodInfo().GetBaseDefinition().DeclaringType;
    }
  }
}