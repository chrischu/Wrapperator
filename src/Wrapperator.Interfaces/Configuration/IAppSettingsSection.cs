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
  
  
  /// <summary>Provides configuration system support for the appSettings configuration section. This class cannot be inherited.</summary>
  public interface IAppSettingsSection : Wrapperator.Interfaces.Configuration.IConfigurationSection
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Configuration.AppSettingsSection _AppSettingsSection
    {
      get;
    }
    
    Wrapperator.Interfaces.Configuration.IKeyValueConfigurationCollection Settings
    {
      get;
    }
    
    string File
    {
      get;
      set;
    }
  }
}