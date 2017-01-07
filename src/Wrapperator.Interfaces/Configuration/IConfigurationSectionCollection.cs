//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Configuration
{
  
  
  /// <summary>Represents a collection of related sections within a configuration file.</summary>
  public interface IConfigurationSectionCollection
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Configuration.ConfigurationSectionCollection _ConfigurationSectionCollection
    {
      get;
    }
    
    Wrapperator.Interfaces.Configuration.IConfigurationSection this[string name]
    {
      get;
    }
    
    Wrapperator.Interfaces.Configuration.IConfigurationSection this[int index]
    {
      get;
    }
    
    int Count
    {
      get;
    }
    
    System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys
    {
      get;
    }
    
    /// <summary>Used by the system during serialization.</summary>
    /// <param name="info">The applicable <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
    /// <param name="context">The applicable <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    
    /// <summary>Adds a <see cref="T:System.Configuration.ConfigurationSection" /> object to the <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <param name="name">The name of the section to be added.</param>
    /// <param name="section">The section to be added.</param>
    void Add(string name, Wrapperator.Interfaces.Configuration.IConfigurationSection section);
    
    /// <summary>Clears this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    void Clear();
    
    /// <summary>Copies this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object to an array.</summary>
    /// <param name="array">The array to copy the <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object to.</param>
    /// <param name="index">The index location at which to begin copying.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="array" /> is less than the value of <see cref="P:System.Configuration.ConfigurationSectionCollection.Count" /> plus <paramref name="index" />.</exception>
    void CopyTo(System.Configuration.ConfigurationSection[] array, int index);
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSection" /> object contained in this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSection" /> object at the specified index.</returns>
    /// <param name="index">The index of the <see cref="T:System.Configuration.ConfigurationSection" /> object to be returned.</param>
    Wrapperator.Interfaces.Configuration.IConfigurationSection Get(int index);
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSection" /> object contained in this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSection" /> object with the specified name.</returns>
    /// <param name="name">The name of the <see cref="T:System.Configuration.ConfigurationSection" /> object to be returned.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="name" /> is null or an empty string ("").</exception>
    Wrapperator.Interfaces.Configuration.IConfigurationSection Get(string name);
    
    /// <summary>Gets an enumerator that can iterate through this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</returns>
    System.Collections.IEnumerator GetEnumerator();
    
    /// <summary>Gets the key of the specified <see cref="T:System.Configuration.ConfigurationSection" /> object contained in this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <returns>The key of the <see cref="T:System.Configuration.ConfigurationSection" /> object at the specified index.</returns>
    /// <param name="index">The index of the <see cref="T:System.Configuration.ConfigurationSection" /> object whose key is to be returned. </param>
    string GetKey(int index);
    
    /// <summary>Removes the specified <see cref="T:System.Configuration.ConfigurationSection" /> object from this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <param name="name">The name of the section to be removed. </param>
    void Remove(string name);
    
    /// <summary>Removes the specified <see cref="T:System.Configuration.ConfigurationSection" /> object from this <see cref="T:System.Configuration.ConfigurationSectionCollection" /> object.</summary>
    /// <param name="index">The index of the section to be removed. </param>
    void RemoveAt(int index);
    
    /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
    /// <param name="sender">The source of the deserialization event.</param>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is invalid.</exception>
    void OnDeserialization(object sender);
  }
}
