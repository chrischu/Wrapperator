//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Reflection
{
  
  
  /// <summary>Describes an assembly's unique identity in full.</summary>
  public class AssemblyNameStaticWrapper : Wrapperator.Interfaces.Reflection.IAssemblyNameStatic
  {
    
    internal AssemblyNameStaticWrapper()
    {
    }
    
    /// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> for a given file.</summary>
    /// <returns>An object that represents the given assembly file.</returns>
    /// <param name="assemblyFile">The path for the assembly whose <see cref="T:System.Reflection.AssemblyName" /> is to be returned. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyFile" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="assemblyFile" /> is invalid, such as an assembly with an invalid culture. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyFile" /> is not found. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have path discovery permission. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyFile" /> is not a valid assembly. </exception>
    /// <exception cref="T:System.IO.FileLoadException">An assembly or module was loaded twice with two different sets of evidence. </exception>
    public Wrapperator.Interfaces.Reflection.IAssemblyName GetAssemblyName(string assemblyFile)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyNameWrapper(System.Reflection.AssemblyName.GetAssemblyName(assemblyFile));
    }
    
    /// <summary>Returns a value indicating whether two assembly names are the same. The comparison is based on the simple assembly names.</summary>
    /// <returns>true if the simple assembly names are the same; otherwise, false.</returns>
    /// <param name="reference">The reference assembly name.</param>
    /// <param name="definition">The assembly name that is compared to the reference assembly.</param>
    public bool ReferenceMatchesDefinition(Wrapperator.Interfaces.Reflection.IAssemblyName reference, Wrapperator.Interfaces.Reflection.IAssemblyName definition)
    {
      return System.Reflection.AssemblyName.ReferenceMatchesDefinition(reference == null ? default(System.Reflection.AssemblyName) : ((Wrapperator.Wrappers.Reflection.AssemblyNameWrapper)reference).AssemblyName, definition == null ? default(System.Reflection.AssemblyName) : ((Wrapperator.Wrappers.Reflection.AssemblyNameWrapper)definition).AssemblyName);
    }
  }
}
