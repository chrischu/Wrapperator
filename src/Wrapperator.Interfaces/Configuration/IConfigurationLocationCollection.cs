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
  
  
  /// <summary>Contains a collection of <see cref="T:System.Configuration.ConfigurationLocationCollection" /> objects.</summary>
  public interface IConfigurationLocationCollection
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Configuration.ConfigurationLocationCollection _ConfigurationLocationCollection
    {
      get;
    }
    
    Wrapperator.Interfaces.Configuration.IConfigurationLocation this[int index]
    {
      get;
    }
    
    int Count
    {
      get;
    }
    
    /// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.ReadOnlyCollectionBase" /> instance.</returns>
    /// <filterpriority>2</filterpriority>
    System.Collections.IEnumerator GetEnumerator();
  }
}
