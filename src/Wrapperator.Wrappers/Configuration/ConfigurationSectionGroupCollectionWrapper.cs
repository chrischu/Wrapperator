//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Configuration
{
  
  
  /// <summary>Represents a collection of <see cref="T:System.Configuration.ConfigurationSectionGroup" /> objects.</summary>
  public class ConfigurationSectionGroupCollectionWrapper : Wrapperator.Interfaces.Configuration.IConfigurationSectionGroupCollection
  {
    
    public System.Configuration.ConfigurationSectionGroupCollection _ConfigurationSectionGroupCollection { get; private set; }

    
    internal ConfigurationSectionGroupCollectionWrapper(System.Configuration.ConfigurationSectionGroupCollection configurationSectionGroupCollection)
    {
      _ConfigurationSectionGroupCollection = configurationSectionGroupCollection;
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup this[string name]
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_ConfigurationSectionGroupCollection[name]);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup this[int index]
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_ConfigurationSectionGroupCollection[index]);
      }
    }
    
    public int Count
    {
      get
      {
        return _ConfigurationSectionGroupCollection.Count;
      }
    }
    
    public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys
    {
      get
      {
        return _ConfigurationSectionGroupCollection.Keys;
      }
    }
    
    /// <summary>Used by the system during serialization.</summary>
    /// <param name="info">The applicable <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
    /// <param name="context">The applicable <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
      _ConfigurationSectionGroupCollection.GetObjectData(info, context);
    }
    
    /// <summary>Adds a <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object to this <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</summary>
    /// <param name="name">The name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object to be added.</param>
    /// <param name="sectionGroup">The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object to be added.</param>
    public void Add(string name, Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup sectionGroup)
    {
      _ConfigurationSectionGroupCollection.Add(name, sectionGroup == null ? default(System.Configuration.ConfigurationSectionGroup) : sectionGroup._ConfigurationSectionGroup);
    }
    
    /// <summary>Clears the collection.</summary>
    public void Clear()
    {
      _ConfigurationSectionGroupCollection.Clear();
    }
    
    /// <summary>Copies this <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object to an array.</summary>
    /// <param name="array">The array to copy the object to.</param>
    /// <param name="index">The index location at which to begin copying.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="array" /> is less than the value of <see cref="P:System.Configuration.ConfigurationSectionGroupCollection.Count" /> plus <paramref name="index" />.</exception>
    public void CopyTo(System.Configuration.ConfigurationSectionGroup[] array, int index)
    {
      _ConfigurationSectionGroupCollection.CopyTo(array, index);
    }
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object contained in the collection.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object at the specified index.</returns>
    /// <param name="index">The index of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object to be returned. </param>
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup Get(int index)
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_ConfigurationSectionGroupCollection.Get(index));
    }
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object from the collection.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object with the specified name.</returns>
    /// <param name="name">The name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object to be returned. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="name" /> is null or an empty string ("").</exception>
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup Get(string name)
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_ConfigurationSectionGroupCollection.Get(name));
    }
    
    /// <summary>Gets an enumerator that can iterate through the <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</returns>
    public System.Collections.IEnumerator GetEnumerator()
    {
      return _ConfigurationSectionGroupCollection.GetEnumerator();
    }
    
    /// <summary>Gets the key of the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object contained in this <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</summary>
    /// <returns>The key of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object at the specified index.</returns>
    /// <param name="index">The index of the section group whose key is to be returned. </param>
    public string GetKey(int index)
    {
      return _ConfigurationSectionGroupCollection.GetKey(index);
    }
    
    /// <summary>Removes the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object whose name is specified from this <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</summary>
    /// <param name="name">The name of the section group to be removed. </param>
    public void Remove(string name)
    {
      _ConfigurationSectionGroupCollection.Remove(name);
    }
    
    /// <summary>Removes the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object whose index is specified from this <see cref="T:System.Configuration.ConfigurationSectionGroupCollection" /> object.</summary>
    /// <param name="index">The index of the section group to be removed. </param>
    public void RemoveAt(int index)
    {
      _ConfigurationSectionGroupCollection.RemoveAt(index);
    }
    
    /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
    /// <param name="sender">The source of the deserialization event.</param>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is invalid.</exception>
    public void OnDeserialization(object sender)
    {
      _ConfigurationSectionGroupCollection.OnDeserialization(sender);
    }
  }
}
