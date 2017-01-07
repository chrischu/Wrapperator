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
  
  
  /// <summary>Represents a location element within a configuration file.</summary>
  public class ConfigurationLocationWrapper : Wrapperator.Interfaces.Configuration.IConfigurationLocation
  {
    
    public System.Configuration.ConfigurationLocation _ConfigurationLocation { get; private set; }

    
    internal ConfigurationLocationWrapper(System.Configuration.ConfigurationLocation configurationLocation)
    {
      _ConfigurationLocation = configurationLocation;
    }
    
    public string Path
    {
      get
      {
        return _ConfigurationLocation.Path;
      }
    }
    
    /// <summary>Creates an instance of a Configuration object.</summary>
    /// <returns>A Configuration object.</returns>
    public Wrapperator.Interfaces.Configuration.IConfiguration OpenConfiguration()
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationWrapper(_ConfigurationLocation.OpenConfiguration());
    }
  }
}