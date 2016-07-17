using System;
using System.Reflection;

namespace Wrapperator.Extensions
{
  internal static class PropertyInfoExtensions
  {
    public static bool IsStatic(this PropertyInfo propertyInfo)
    {
      return propertyInfo.GetMethod?.IsStatic == true || propertyInfo.SetMethod?.IsStatic == true;
    }
  }
}