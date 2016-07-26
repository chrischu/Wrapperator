//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers
{
  
  
  /// <summary>Represents the version number of an assembly, operating system, or the common language runtime. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public class VersionStaticWrapper : Wrapperator.Interfaces.IVersionStatic
  {
    
    /// <summary>Converts the string representation of a version number to an equivalent <see cref="T:System.Version" /> object.</summary>
    /// <returns>An object that is equivalent to the version number specified in the <paramref name="input" /> parameter.</returns>
    /// <param name="input">A string that contains a version number to convert.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="input" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="input" /> has fewer than two or more than four version components.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">At least one component in <paramref name="input" /> is less than zero.</exception>
    /// <exception cref="T:System.FormatException">At least one component in <paramref name="input" /> is not an integer.</exception>
    /// <exception cref="T:System.OverflowException">At least one component in <paramref name="input" /> represents a number that is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
    public Wrapperator.Interfaces.IVersion Parse(string input)
    {
      return new Wrapperator.Wrappers.VersionWrapper(System.Version.Parse(input));
    }
    
    /// <summary>Tries to convert the string representation of a version number to an equivalent <see cref="T:System.Version" /> object, and returns a value that indicates whether the conversion succeeded.</summary>
    /// <returns>true if the <paramref name="input" /> parameter was converted successfully; otherwise, false.</returns>
    /// <param name="input">A string that contains a version number to convert.</param>
    /// <param name="result">When this method returns, contains the <see cref="T:System.Version" /> equivalent of the number that is contained in <paramref name="input" />, if the conversion succeeded, or a <see cref="T:System.Version" /> object whose major and minor version numbers are 0 if the conversion failed. If <paramref name="input" /> is null or <see cref="F:System.String.Empty" />, <paramref name="result" /> is null when the method returns. </param>
    public bool TryParse(string input, ref System.Version result)
    {
      return System.Version.TryParse(input, out result);
    }
  }
}