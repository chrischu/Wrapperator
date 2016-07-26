//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Reflection
{
  
  
  /// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
  public interface IAssembly
  {
    
    string CodeBase
    {
      get;
    }
    
    string EscapedCodeBase
    {
      get;
    }
    
    string FullName
    {
      get;
    }
    
    System.Reflection.MethodInfo EntryPoint
    {
      get;
    }
    
    System.Collections.Generic.IEnumerable<System.Type> ExportedTypes
    {
      get;
    }
    
    System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DefinedTypes
    {
      get;
    }
    
    System.Security.Policy.Evidence Evidence
    {
      get;
    }
    
    System.Security.PermissionSet PermissionSet
    {
      get;
    }
    
    bool IsFullyTrusted
    {
      get;
    }
    
    System.Security.SecurityRuleSet SecurityRuleSet
    {
      get;
    }
    
    System.Reflection.Module ManifestModule
    {
      get;
    }
    
    System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes
    {
      get;
    }
    
    bool ReflectionOnly
    {
      get;
    }
    
    System.Collections.Generic.IEnumerable<System.Reflection.Module> Modules
    {
      get;
    }
    
    string Location
    {
      get;
    }
    
    string ImageRuntimeVersion
    {
      get;
    }
    
    bool GlobalAssemblyCache
    {
      get;
    }
    
    long HostContext
    {
      get;
    }
    
    bool IsDynamic
    {
      get;
    }
    
    /// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</summary>
    /// <returns>An object that contains the fully parsed display name for this assembly.</returns>
    Wrapperator.Interfaces.Reflection.IAssemblyName GetName();
    
    /// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly, setting the codebase as specified by <paramref name="copiedName" />.</summary>
    /// <returns>An object that contains the fully parsed display name for this assembly.</returns>
    /// <param name="copiedName">true to set the <see cref="P:System.Reflection.Assembly.CodeBase" /> to the location of the assembly after it was shadow copied; false to set <see cref="P:System.Reflection.Assembly.CodeBase" /> to the original location. </param>
    Wrapperator.Interfaces.Reflection.IAssemblyName GetName(bool copiedName);
    
    /// <summary>Gets the public types defined in this assembly that are visible outside the assembly.</summary>
    /// <returns>An array that represents the types defined in this assembly that are visible outside the assembly.</returns>
    /// <exception cref="T:System.NotSupportedException">The assembly is a dynamic assembly.</exception>
    System.Type[] GetExportedTypes();
    
    /// <summary>Gets the types defined in this assembly.</summary>
    /// <returns>An array that contains all the types that are defined in this assembly.</returns>
    /// <exception cref="T:System.Reflection.ReflectionTypeLoadException">The assembly contains one or more types that cannot be loaded. The array returned by the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> property of this exception contains a <see cref="T:System.Type" /> object for each type that was loaded and null for each type that could not be loaded, while the <see cref="P:System.Reflection.ReflectionTypeLoadException.LoaderExceptions" /> property contains an exception for each type that could not be loaded.</exception>
    System.Type[] GetTypes();
    
    /// <summary>Loads the specified manifest resource, scoped by the namespace of the specified type, from this assembly.</summary>
    /// <returns>The manifest resource; or null if no resources were specified during compilation or if the resource is not visible to the caller.</returns>
    /// <param name="type">The type whose namespace is used to scope the manifest resource name. </param>
    /// <param name="name">The case-sensitive name of the manifest resource being requested. </param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="name" /> was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="name" /> is not a valid assembly. </exception>
    /// <exception cref="T:System.NotImplementedException">Resource length is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
    Wrapperator.Interfaces.IO.IStream GetManifestResourceStream(Wrapperator.Interfaces.IType type, string name);
    
    /// <summary>Loads the specified manifest resource from this assembly.</summary>
    /// <returns>The manifest resource; or null if no resources were specified during compilation or if the resource is not visible to the caller.</returns>
    /// <param name="name">The case-sensitive name of the manifest resource being requested. </param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.FileLoadException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="name" /> was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="name" /> is not a valid assembly. </exception>
    /// <exception cref="T:System.NotImplementedException">Resource length is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
    Wrapperator.Interfaces.IO.IStream GetManifestResourceStream(string name);
    
    /// <summary>Gets the satellite assembly for the specified culture.</summary>
    /// <returns>The specified satellite assembly.</returns>
    /// <param name="culture">The specified culture. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="culture" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The assembly cannot be found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">The satellite assembly with a matching file name was found, but the CultureInfo did not match the one specified. </exception>
    /// <exception cref="T:System.BadImageFormatException">The satellite assembly is not a valid assembly. </exception>
    Wrapperator.Interfaces.Reflection.IAssembly GetSatelliteAssembly(System.Globalization.CultureInfo culture);
    
    /// <summary>Gets the specified version of the satellite assembly for the specified culture.</summary>
    /// <returns>The specified satellite assembly.</returns>
    /// <param name="culture">The specified culture. </param>
    /// <param name="version">The version of the satellite assembly. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="culture" /> is null. </exception>
    /// <exception cref="T:System.IO.FileLoadException">The satellite assembly with a matching file name was found, but the CultureInfo or the version did not match the one specified. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The assembly cannot be found. </exception>
    /// <exception cref="T:System.BadImageFormatException">The satellite assembly is not a valid assembly. </exception>
    Wrapperator.Interfaces.Reflection.IAssembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, Wrapperator.Interfaces.IVersion version);
    
    /// <summary>Gets serialization information with all of the data needed to reinstantiate this assembly.</summary>
    /// <param name="info">The object to be populated with serialization information. </param>
    /// <param name="context">The destination context of the serialization. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="info" /> is null. </exception>
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    
    /// <summary>Gets all the custom attributes for this assembly.</summary>
    /// <returns>An array that contains the custom attributes for this assembly.</returns>
    /// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
    object[] GetCustomAttributes(bool inherit);
    
    /// <summary>Gets the custom attributes for this assembly as specified by type.</summary>
    /// <returns>An array that contains the custom attributes for this assembly as specified by <paramref name="attributeType" />.</returns>
    /// <param name="attributeType">The type for which the custom attributes are to be returned. </param>
    /// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="attributeType" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="attributeType" /> is not a runtime type. </exception>
    object[] GetCustomAttributes(Wrapperator.Interfaces.IType attributeType, bool inherit);
    
    /// <summary>Indicates whether or not a specified attribute has been applied to the assembly.</summary>
    /// <returns>true if the attribute has been applied to the assembly; otherwise, false.</returns>
    /// <param name="attributeType">The type of the attribute to be checked for this assembly. </param>
    /// <param name="inherit">This argument is ignored for objects of this type. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="attributeType" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="attributeType" /> uses an invalid type.</exception>
    bool IsDefined(Wrapperator.Interfaces.IType attributeType, bool inherit);
    
    /// <summary>Returns information about the attributes that have been applied to the current <see cref="T:System.Reflection.Assembly" />, expressed as <see cref="T:System.Reflection.CustomAttributeData" /> objects.</summary>
    /// <returns>A generic list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the current assembly.</returns>
    System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData();
    
    /// <summary>Loads the module, internal to this assembly, with a common object file format (COFF)-based image containing an emitted module, or a resource file.</summary>
    /// <returns>The loaded module.</returns>
    /// <param name="moduleName">The name of the module. This string must correspond to a file name in this assembly's manifest. </param>
    /// <param name="rawModule">A byte array that is a COFF-based image containing an emitted module, or a resource. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="moduleName" /> or <paramref name="rawModule" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="moduleName" /> does not match a file entry in this assembly's manifest. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawModule" /> is not a valid module. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    System.Reflection.Module LoadModule(string moduleName, byte[] rawModule);
    
    /// <summary>Loads the module, internal to this assembly, with a common object file format (COFF)-based image containing an emitted module, or a resource file. The raw bytes representing the symbols for the module are also loaded.</summary>
    /// <returns>The loaded module.</returns>
    /// <param name="moduleName">The name of the module. This string must correspond to a file name in this assembly's manifest. </param>
    /// <param name="rawModule">A byte array that is a COFF-based image containing an emitted module, or a resource. </param>
    /// <param name="rawSymbolStore">A byte array containing the raw bytes representing the symbols for the module. Must be null if this is a resource file. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="moduleName" /> or <paramref name="rawModule" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="moduleName" /> does not match a file entry in this assembly's manifest. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="rawModule" /> is not a valid module. </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    System.Reflection.Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
    
    /// <summary>Locates the specified type from this assembly and creates an instance of it using the system activator, using case-sensitive search.</summary>
    /// <returns>An instance of the specified type created with the default constructor; or null if <paramref name="typeName" /> is not found. The type is resolved using the default binder, without specifying culture or activation attributes, and with <see cref="T:System.Reflection.BindingFlags" /> set to Public or Instance. </returns>
    /// <param name="typeName">The <see cref="P:System.Type.FullName" /> of the type to locate. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="typeName" /> is an empty string ("") or a string beginning with a null character.-or-The current assembly was loaded into the reflection-only context.</exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="typeName" /> is null. </exception>
    /// <exception cref="T:System.MissingMethodException">No matching constructor was found. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="typeName" /> requires a dependent assembly that could not be found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="typeName" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="typeName" /> requires a dependent assembly that was not preloaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="typeName" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="typeName" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
    object CreateInstance(string typeName);
    
    /// <summary>Locates the specified type from this assembly and creates an instance of it using the system activator, with optional case-sensitive search.</summary>
    /// <returns>An instance of the specified type created with the default constructor; or null if <paramref name="typeName" /> is not found. The type is resolved using the default binder, without specifying culture or activation attributes, and with <see cref="T:System.Reflection.BindingFlags" /> set to Public or Instance.</returns>
    /// <param name="typeName">The <see cref="P:System.Type.FullName" /> of the type to locate. </param>
    /// <param name="ignoreCase">true to ignore the case of the type name; otherwise, false. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="typeName" /> is an empty string ("") or a string beginning with a null character. -or-The current assembly was loaded into the reflection-only context.</exception>
    /// <exception cref="T:System.MissingMethodException">No matching constructor was found. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="typeName" /> is null. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="typeName" /> requires a dependent assembly that could not be found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="typeName" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="typeName" /> requires a dependent assembly that was not preloaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="typeName" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="typeName" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
    object CreateInstance(string typeName, bool ignoreCase);
    
    /// <summary>Locates the specified type from this assembly and creates an instance of it using the system activator, with optional case-sensitive search and having the specified culture, arguments, and binding and activation attributes.</summary>
    /// <returns>An instance of the specified type, or null if <paramref name="typeName" /> is not found. The supplied arguments are used to resolve the type, and to bind the constructor that is used to create the instance.</returns>
    /// <param name="typeName">The <see cref="P:System.Type.FullName" /> of the type to locate. </param>
    /// <param name="ignoreCase">true to ignore the case of the type name; otherwise, false. </param>
    /// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
    /// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
    /// <param name="args">An array that contains the arguments to be passed to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to be invoked. If the default constructor is desired, <paramref name="args" /> must be an empty array or null. </param>
    /// <param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (This is necessary to convert a String that represents 1000 to a Double value, for example, since 1000 is represented differently by different cultures.) </param>
    /// <param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> object. The <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> specifies the URL that is required to activate a remote object.  </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="typeName" /> is an empty string ("") or a string beginning with a null character. -or-The current assembly was loaded into the reflection-only context.</exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="typeName" /> is null. </exception>
    /// <exception cref="T:System.MissingMethodException">No matching constructor was found. </exception>
    /// <exception cref="T:System.NotSupportedException">A non-empty activation attributes array is passed to a type that does not inherit from <see cref="T:System.MarshalByRefObject" />. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="typeName" /> requires a dependent assembly that could not be found. </exception>
    /// <exception cref="T:System.IO.FileLoadException">
    ///  <paramref name="typeName" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="typeName" /> requires a dependent assembly that was not preloaded. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="typeName" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="typeName" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
    object CreateInstance(string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes);
    
    /// <summary>Gets all the loaded modules that are part of this assembly.</summary>
    /// <returns>An array of modules.</returns>
    System.Reflection.Module[] GetLoadedModules();
    
    /// <summary>Gets all the loaded modules that are part of this assembly, specifying whether to include resource modules.</summary>
    /// <returns>An array of modules.</returns>
    /// <param name="getResourceModules">true to include resource modules; otherwise, false. </param>
    System.Reflection.Module[] GetLoadedModules(bool getResourceModules);
    
    /// <summary>Gets all the modules that are part of this assembly.</summary>
    /// <returns>An array of modules.</returns>
    /// <exception cref="T:System.IO.FileNotFoundException">The module to be loaded does not specify a file name extension. </exception>
    System.Reflection.Module[] GetModules();
    
    /// <summary>Gets all the modules that are part of this assembly, specifying whether to include resource modules.</summary>
    /// <returns>An array of modules.</returns>
    /// <param name="getResourceModules">true to include resource modules; otherwise, false. </param>
    System.Reflection.Module[] GetModules(bool getResourceModules);
    
    /// <summary>Gets the specified module in this assembly.</summary>
    /// <returns>The module being requested, or null if the module is not found.</returns>
    /// <param name="name">The name of the module being requested. </param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="name" /> was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="name" /> is not a valid assembly. </exception>
    System.Reflection.Module GetModule(string name);
    
    /// <summary>Gets a <see cref="T:System.IO.FileStream" /> for the specified file in the file table of the manifest of this assembly.</summary>
    /// <returns>A stream that contains the specified file, or null if the file is not found.</returns>
    /// <param name="name">The name of the specified file. Do not include the path to the file.</param>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">
    ///  <paramref name="name" /> was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">
    ///  <paramref name="name" /> is not a valid assembly. </exception>
    Wrapperator.Interfaces.IO.IFileStream GetFile(string name);
    
    /// <summary>Gets the files in the file table of an assembly manifest.</summary>
    /// <returns>An array of streams that contain the files.</returns>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">A file was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">A file was not a valid assembly. </exception>
    System.IO.FileStream[] GetFiles();
    
    /// <summary>Gets the files in the file table of an assembly manifest, specifying whether to include resource modules.</summary>
    /// <returns>An array of streams that contain the files.</returns>
    /// <param name="getResourceModules">true to include resource modules; otherwise, false. </param>
    /// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">A file was not found. </exception>
    /// <exception cref="T:System.BadImageFormatException">A file was not a valid assembly. </exception>
    System.IO.FileStream[] GetFiles(bool getResourceModules);
    
    /// <summary>Returns the names of all the resources in this assembly.</summary>
    /// <returns>An array that contains the names of all the resources.</returns>
    string[] GetManifestResourceNames();
    
    /// <summary>Gets the <see cref="T:System.Reflection.AssemblyName" /> objects for all the assemblies referenced by this assembly.</summary>
    /// <returns>An array that contains the fully parsed display names of all the assemblies referenced by this assembly.</returns>
    System.Reflection.AssemblyName[] GetReferencedAssemblies();
    
    /// <summary>Returns information about how the given resource has been persisted.</summary>
    /// <returns>An object that is populated with information about the resource's topology, or null if the resource is not found.</returns>
    /// <param name="resourceName">The case-sensitive name of the resource. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="resourceName" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="resourceName" /> parameter is an empty string (""). </exception>
    System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName);
  }
}
