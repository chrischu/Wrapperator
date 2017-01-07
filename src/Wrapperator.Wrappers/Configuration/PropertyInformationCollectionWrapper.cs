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
  
  
  /// <summary>Contains a collection of <see cref="T:System.Configuration.PropertyInformation" /> objects. This class cannot be inherited.</summary>
  public class PropertyInformationCollectionWrapper : Wrapperator.Interfaces.Configuration.IPropertyInformationCollection
  {
    
    public System.Configuration.PropertyInformationCollection _PropertyInformationCollection { get; private set; }

    
    internal PropertyInformationCollectionWrapper(System.Configuration.PropertyInformationCollection propertyInformationCollection)
    {
      _PropertyInformationCollection = propertyInformationCollection;
    }
    
    public Wrapperator.Interfaces.Configuration.IPropertyInformation this[string propertyName]
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.PropertyInformationWrapper(_PropertyInformationCollection[propertyName]);
      }
    }
    
    public int Count
    {
      get
      {
        return _PropertyInformationCollection.Count;
      }
    }
    
    public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys
    {
      get
      {
        return _PropertyInformationCollection.Keys;
      }
    }
    
    /// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the <see cref="T:System.Configuration.PropertyInformationCollection" /> instance.</summary>
    /// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the information required to serialize the <see cref="T:System.Configuration.PropertyInformationCollection" /> instance.</param>
    /// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains the source and destination of the serialized stream associated with the <see cref="T:System.Configuration.PropertyInformationCollection" /> instance.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="info" /> is null.</exception>
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
      _PropertyInformationCollection.GetObjectData(info, context);
    }
    
    /// <summary>Copies the entire <see cref="T:System.Configuration.PropertyInformationCollection" /> collection to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
    /// <param name="array">A one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the <see cref="T:System.Configuration.PropertyInformationCollection" /> collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
    /// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="P:System.Array.Length" /> property of <paramref name="array" /> is less than <see cref="P:System.Collections.Specialized.NameObjectCollectionBase.Count" /> + <paramref name="index" />.</exception>
    public void CopyTo(System.Configuration.PropertyInformation[] array, int index)
    {
      _PropertyInformationCollection.CopyTo(array, index);
    }
    
    /// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> object, which is used to iterate through this <see cref="T:System.Configuration.PropertyInformationCollection" /> collection.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object, which is used to iterate through this <see cref="T:System.Configuration.PropertyInformationCollection" />.</returns>
    public System.Collections.IEnumerator GetEnumerator()
    {
      return _PropertyInformationCollection.GetEnumerator();
    }
    
    /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
    /// <param name="sender">The source of the deserialization event.</param>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance is invalid.</exception>
    public void OnDeserialization(object sender)
    {
      _PropertyInformationCollection.OnDeserialization(sender);
    }
  }
}
