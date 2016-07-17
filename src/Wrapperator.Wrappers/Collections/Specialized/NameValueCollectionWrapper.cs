//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Collections.Specialized
{
  
  
  /// <summary>Represents a collection of associated <see cref="T:System.String" /> keys and <see cref="T:System.String" /> values that can be accessed either with the key or with the index.</summary>
  public partial class NameValueCollectionWrapper : Wrapperator.Interfaces.Collections.Specialized.INameValueCollection
  {
    
    private System.Collections.Specialized.NameValueCollection _nameValueCollection;
    
    public NameValueCollectionWrapper(System.Collections.Specialized.NameValueCollection nameValueCollection)
    {
      _nameValueCollection = nameValueCollection;
    }
    
    public string[] AllKeys
    {
      get
      {
        return _nameValueCollection.AllKeys;
      }
    }
    
    public int Count
    {
      get
      {
        return _nameValueCollection.Count;
      }
    }
    
    public string this[string name]
    {
      get
      {
        return _nameValueCollection[name];
      }
      set
      {
        _nameValueCollection[name] = value;
      }
    }
    
    public string this[int index]
    {
      get
      {
        return _nameValueCollection[index];
      }
    }
    
    public System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys
    {
      get
      {
        return _nameValueCollection.Keys;
      }
    }
    
    /// <summary>Copies the entries in the specified <see cref="T:System.Collections.Specialized.NameValueCollection" /> to the current <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <param name="c">The <see cref="T:System.Collections.Specialized.NameValueCollection" /> to copy to the current <see cref="T:System.Collections.Specialized.NameValueCollection" />.</param>
    /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="c" /> is null.</exception>
    public void Add(System.Collections.Specialized.NameValueCollection c)
    {
      _nameValueCollection.Add(c);
    }
    
    /// <summary>Adds an entry with the specified name and value to the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <param name="name">The <see cref="T:System.String" /> key of the entry to add. The key can be null.</param>
    /// <param name="value">The <see cref="T:System.String" /> value of the entry to add. The value can be null.</param>
    /// <exception cref="T:System.NotSupportedException">The collection is read-only. </exception>
    public void Add(string name, string value)
    {
      _nameValueCollection.Add(name, value);
    }
    
    /// <summary>Invalidates the cached arrays and removes all entries from the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
    public void Clear()
    {
      _nameValueCollection.Clear();
    }
    
    /// <summary>Copies the entire <see cref="T:System.Collections.Specialized.NameValueCollection" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
    /// <param name="dest">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Specialized.NameValueCollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
    /// <param name="index">The zero-based index in <paramref name="dest" /> at which copying begins.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="dest" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> is less than zero.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="dest" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Specialized.NameValueCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="dest" />.</exception>
    /// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Specialized.NameValueCollection" /> cannot be cast automatically to the type of the destination <paramref name="dest" />.</exception>
    public void CopyTo(System.Array dest, int index)
    {
      _nameValueCollection.CopyTo(dest, index);
    }
    
    /// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
    /// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, null.</returns>
    /// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be null.</param>
    public string Get(string name)
    {
      return _nameValueCollection.Get(name);
    }
    
    /// <summary>Gets the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" /> combined into one comma-separated list.</summary>
    /// <returns>A <see cref="T:System.String" /> that contains a comma-separated list of the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, null.</returns>
    /// <param name="index">The zero-based index of the entry that contains the values to get from the collection.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> is outside the valid range of indexes for the collection.</exception>
    public string Get(int index)
    {
      return _nameValueCollection.Get(index);
    }
    
    /// <summary>Gets the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <returns>A <see cref="T:System.String" /> that contains the key at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, null.</returns>
    /// <param name="index">The zero-based index of the key to get from the collection.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
    public string GetKey(int index)
    {
      return _nameValueCollection.GetKey(index);
    }
    
    /// <summary>Gets the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <returns>A <see cref="T:System.String" /> array that contains the values associated with the specified key from the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, null.</returns>
    /// <param name="name">The <see cref="T:System.String" /> key of the entry that contains the values to get. The key can be null.</param>
    public string[] GetValues(string name)
    {
      return _nameValueCollection.GetValues(name);
    }
    
    /// <summary>Gets the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <returns>A <see cref="T:System.String" /> array that contains the values at the specified index of the <see cref="T:System.Collections.Specialized.NameValueCollection" />, if found; otherwise, null.</returns>
    /// <param name="index">The zero-based index of the entry that contains the values to get from the collection.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> is outside the valid range of indexes for the collection. </exception>
    public string[] GetValues(int index)
    {
      return _nameValueCollection.GetValues(index);
    }
    
    /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Specialized.NameValueCollection" /> contains keys that are not null.</summary>
    /// <returns>true if the <see cref="T:System.Collections.Specialized.NameValueCollection" /> contains keys that are not null; otherwise, false.</returns>
    public bool HasKeys()
    {
      return _nameValueCollection.HasKeys();
    }
    
    /// <summary>Removes the entries with the specified key from the <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> instance.</summary>
    /// <param name="name">The <see cref="T:System.String" /> key of the entry to remove. The key can be null.</param>
    /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
    public void Remove(string name)
    {
      _nameValueCollection.Remove(name);
    }
    
    /// <summary>Sets the value of an entry in the <see cref="T:System.Collections.Specialized.NameValueCollection" />.</summary>
    /// <param name="name">The <see cref="T:System.String" /> key of the entry to add the new value to. The key can be null.</param>
    /// <param name="value">The <see cref="T:System.Object" /> that represents the new value to add to the specified entry. The value can be null.</param>
    /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
    public void Set(string name, string value)
    {
      _nameValueCollection.Set(name, value);
    }
  }
}
