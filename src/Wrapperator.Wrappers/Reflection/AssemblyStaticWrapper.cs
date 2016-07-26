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
  
  
  /// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
  public class AssemblyStaticWrapper : Wrapperator.Interfaces.Reflection.IAssemblyStatic
  {
    
    /// <summary>Creates the name of a type qualified by the display name of its assembly.</summary>
    /// <returns>The full name of the type qualified by the display name of the assembly.</returns>
    /// <param name="assemblyName">The display name of an assembly. </param>
    /// <param name="typeName">The full name of a type. </param>
    public string CreateQualifiedName(string assemblyName, string typeName)
    {
      return System.Reflection.Assembly.CreateQualifiedName(assemblyName, typeName);
    }
    
    /// <summary>Gets the currently loaded assembly in which the specified class is defined.</summary>
    /// <returns>The assembly in which the specified class is defined.</returns>
    /// <param name="type">An object representing a class in the assembly that will be returned. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="type" /> is null. </exception>
    public Wrapperator.Interfaces.Reflection.IAssembly GetAssembly(Wrapperator.Interfaces.IType type)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.GetAssembly(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type));
    }
    
    /// <summary>Loads an assembly given its file name or path.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyFile" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a filename extension. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyFile" /> is not a valid assembly; for example, a 32-bit assembly in a 64-bit process. See the exception topic for more information. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception>
    /// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="assemblyFile" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly LoadFrom(string assemblyFile)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.LoadFrom(assemblyFile));
    }
    
    /// <summary>Loads an assembly into the reflection-only context, given its path.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyFile">The path of the file that contains the manifest of the assembly.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyFile" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a file name extension. </exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="assemblyFile" /> is found, but could not be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyFile" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyFile" /> was compiled with a later version.</exception>
    /// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="assemblyFile" /> is an empty string (""). </exception>
    public Wrapperator.Interfaces.Reflection.IAssembly ReflectionOnlyLoadFrom(string assemblyFile)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFile));
    }
    
    /// <summary>Loads an assembly given its file name or path, hash value, and hash algorithm.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly. </param>
    /// <param name="hashValue">The value of the computed hash code. </param>
    /// <param name="hashAlgorithm">The hash algorithm used for hashing files and for generating the strong name. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyFile" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a file name extension. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded.</exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyFile" /> is not a valid assembly; for example, a 32-bit assembly in a 64-bit process. See the exception topic for more information. -or-<paramref name="assemblyFile" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
    /// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="assemblyFile" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly LoadFrom(string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm));
    }
    
    /// <summary>Loads an assembly into the load-from context, bypassing some security checks.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyFile" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyFile" /> is not found, or the module you are trying to load does not specify a filename extension. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyFile" /> is not a valid assembly. -or-<paramref name="assemblyFile" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
    /// <exception cref="T:System.Security.SecurityException">A codebase that does not start with "file://" was specified without the required <see cref="T:System.Net.WebPermission" />. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="assemblyFile" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The assembly name is longer than MAX_PATH characters.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly UnsafeLoadFrom(string assemblyFile)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.UnsafeLoadFrom(assemblyFile));
    }
    
    /// <summary>Loads an assembly given the long form of its name.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyString">The long form of the assembly name. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyString" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="assemblyString" /> is a zero-length string. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyString" /> is not found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly Load(string assemblyString)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.Load(assemblyString));
    }
    
    /// <summary>Loads an assembly into the reflection-only context, given its display name.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyString">The display name of the assembly, as returned by the <see cref="P:System.Reflection.AssemblyName.FullName" /> property.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyString" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="assemblyString" /> is an empty string (""). </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyString" /> is not found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="assemblyString" /> is found, but cannot be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly ReflectionOnlyLoad(string assemblyString)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.ReflectionOnlyLoad(assemblyString));
    }
    
    /// <summary>Loads an assembly given its <see cref="T:System.Reflection.AssemblyName" />.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="assemblyRef">The object that describes the assembly to be loaded. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="assemblyRef" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="assemblyRef" /> is not found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="assemblyRef" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyRef" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly Load(Wrapperator.Interfaces.Reflection.IAssemblyName assemblyRef)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.Load(assemblyRef == null ? default(System.Reflection.AssemblyName) : ((Wrapperator.Wrappers.Reflection.AssemblyNameWrapper)assemblyRef).AssemblyName));
    }
    
    /// <summary>Loads the assembly with a common object file format (COFF)-based image containing an emitted assembly. The assembly is loaded into the application domain of the caller.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="rawAssembly">A byte array that is a COFF-based image containing an emitted assembly. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="rawAssembly" /> is null. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly Load(byte[] rawAssembly)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.Load(rawAssembly));
    }
    
    /// <summary>Loads the assembly from a common object file format (COFF)-based image containing an emitted assembly. The assembly is loaded into the reflection-only context of the caller's application domain.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="rawAssembly">A byte array that is a COFF-based image containing an emitted assembly.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="rawAssembly" /> is null. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="rawAssembly" /> cannot be loaded. </exception>
    public Wrapperator.Interfaces.Reflection.IAssembly ReflectionOnlyLoad(byte[] rawAssembly)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.ReflectionOnlyLoad(rawAssembly));
    }
    
    /// <summary>Loads the assembly with a common object file format (COFF)-based image containing an emitted assembly, optionally including symbols for the assembly. The assembly is loaded into the application domain of the caller.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="rawAssembly">A byte array that is a COFF-based image containing an emitted assembly. </param>
    /// <param name="rawSymbolStore">A byte array that contains the raw bytes representing the symbols for the assembly. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="rawAssembly" /> is null. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawAssembly" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="rawAssembly" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.Load(rawAssembly, rawSymbolStore));
    }
    
    /// <summary>Loads the assembly with a common object file format (COFF)-based image containing an emitted assembly, optionally including symbols and specifying the source for the security context. The assembly is loaded into the application domain of the caller.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="rawAssembly">A byte array that is a COFF-based image containing an emitted assembly. </param>
    /// <param name="rawSymbolStore">A byte array that contains the raw bytes representing the symbols for the assembly. </param>
    /// <param name="securityContextSource">The source of the security context. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="rawAssembly" /> is null. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawAssembly" /> is not a valid assembly. -or-<paramref name="rawAssembly" /> was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="securityContextSource" /> is not one of the enumeration values.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.SecurityContextSource securityContextSource)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.Load(rawAssembly, rawSymbolStore, securityContextSource));
    }
    
    /// <summary>Loads the contents of an assembly file on the specified path.</summary>
    /// <returns>The loaded assembly.</returns>
    /// <param name="path">The path of the file to load. </param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The <paramref name="path" /> parameter is an empty string ("") or does not exist. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="path" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="path" /> was compiled with a later version.</exception>
    public Wrapperator.Interfaces.Reflection.IAssembly LoadFile(string path)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.LoadFile(path));
    }
    
    /// <summary>Gets the assembly that contains the code that is currently executing.</summary>
    /// <returns>The assembly that contains the code that is currently executing. </returns>
    public Wrapperator.Interfaces.Reflection.IAssembly GetExecutingAssembly()
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.GetExecutingAssembly());
    }
    
    /// <summary>Returns the <see cref="T:System.Reflection.Assembly" /> of the method that invoked the currently executing method.</summary>
    /// <returns>The Assembly object of the method that invoked the currently executing method.</returns>
    public Wrapperator.Interfaces.Reflection.IAssembly GetCallingAssembly()
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.GetCallingAssembly());
    }
    
    /// <summary>Gets the process executable in the default application domain. In other application domains, this is the first executable that was executed by <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />.</summary>
    /// <returns>The assembly that is the process executable in the default application domain, or the first executable that was executed by <see cref="M:System.AppDomain.ExecuteAssembly(System.String)" />. Can return null when called from unmanaged code.</returns>
    public Wrapperator.Interfaces.Reflection.IAssembly GetEntryAssembly()
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(System.Reflection.Assembly.GetEntryAssembly());
    }
  }
}