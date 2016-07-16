using System;
using System.Collections.Generic;
using System.Reflection;

namespace Wrapperator
{
  internal class WrapperatorModel
  {
    public Type Type { get; }
    public IReadOnlyCollection<MethodInfo> Methods { get; }

    public string ParameterName => Type.Name.ToLowerCamelCase();
    public string FieldName => $"_{ParameterName}";

    public WrapperatorModel(Type type, IReadOnlyCollection<MethodInfo> methods)
    {
      Type = type;
      Methods = methods;
    }
  }

  internal static class StringExtensions
  {
    public static string ToLowerCamelCase(this string s)
    {
      var first = char.ToLower(s[0]);
      return first + s.Substring(1);
    }
  }
}