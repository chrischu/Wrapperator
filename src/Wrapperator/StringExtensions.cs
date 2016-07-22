using System;

namespace Wrapperator
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