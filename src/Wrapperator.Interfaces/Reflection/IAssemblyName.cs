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
  
  
  /// <summary>Describes an assembly's unique identity in full.</summary>
  public interface IAssemblyName
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Reflection.AssemblyName _AssemblyName
    {
      get;
    }
    
    string Name
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IVersion Version
    {
      get;
      set;
    }
    
    System.Globalization.CultureInfo CultureInfo
    {
      get;
      set;
    }
    
    string CodeBase
    {
      get;
      set;
    }
    
    string EscapedCodeBase
    {
      get;
    }
    
    System.Reflection.ProcessorArchitecture ProcessorArchitecture
    {
      get;
      set;
    }
    
    System.Reflection.AssemblyContentType ContentType
    {
      get;
      set;
    }
    
    System.Reflection.AssemblyNameFlags Flags
    {
      get;
      set;
    }
    
    System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm
    {
      get;
      set;
    }
    
    System.Configuration.Assemblies.AssemblyVersionCompatibility VersionCompatibility
    {
      get;
      set;
    }
    
    System.Reflection.StrongNameKeyPair KeyPair
    {
      get;
      set;
    }
    
    string FullName
    {
      get;
    }
    
    /// <summary>Makes a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</summary>
    /// <returns>An object that is a copy of this <see cref="T:System.Reflection.AssemblyName" /> object.</returns>
    object Clone();
    
    /// <summary>Gets the public key of the assembly.</summary>
    /// <returns>A byte array that contains the public key of the assembly.</returns>
    /// <exception cref="T:System.Security.SecurityException">A public key was provided (for example, by using the <see cref="M:System.Reflection.AssemblyName.SetPublicKey(System.Byte[])" /> method), but no public key token was provided. </exception>
    byte[] GetPublicKey();
    
    /// <summary>Sets the public key identifying the assembly.</summary>
    /// <param name="publicKey">A byte array containing the public key of the assembly. </param>
    void SetPublicKey(byte[] publicKey);
    
    /// <summary>Gets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
    /// <returns>A byte array that contains the public key token.</returns>
    byte[] GetPublicKeyToken();
    
    /// <summary>Sets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
    /// <param name="publicKeyToken">A byte array containing the public key token of the assembly. </param>
    void SetPublicKeyToken(byte[] publicKeyToken);
    
    /// <summary>Gets serialization information with all the data needed to recreate an instance of this AssemblyName.</summary>
    /// <param name="info">The object to be populated with serialization information. </param>
    /// <param name="context">The destination context of the serialization. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="info" /> is null. </exception>
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    
    /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
    /// <param name="sender">The source of the deserialization event. </param>
    void OnDeserialization(object sender);
  }
}
