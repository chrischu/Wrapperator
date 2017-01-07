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
  
  
  /// <summary>Encapsulates the context information that is associated with a <see cref="T:System.Configuration.ConfigurationElement" /> object. This class cannot be inherited.</summary>
  public interface IContextInformation
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Configuration.ContextInformation _ContextInformation
    {
      get;
    }
    
    object HostingContext
    {
      get;
    }
    
    bool IsMachineLevel
    {
      get;
    }
    
    /// <summary>Provides an object containing configuration-section information based on the specified section name.</summary>
    /// <returns>An object containing the specified section within the configuration.</returns>
    /// <param name="sectionName">The name of the configuration section.</param>
    object GetSection(string sectionName);
  }
}