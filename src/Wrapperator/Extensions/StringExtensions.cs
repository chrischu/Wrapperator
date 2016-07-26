using System;

namespace Wrapperator.Extensions
{
  internal static class StringExtensions
  {
    public static string ToLowerCamelCase (this string s)
    {
      var first = char.ToLower(s[0]);
      return first + s.Substring(1);
    }
  }
}