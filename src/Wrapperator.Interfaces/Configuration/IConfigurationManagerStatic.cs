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
  
  
  /// <summary>Provides access to configuration files for client applications. This class cannot be inherited.</summary>
  public interface IConfigurationManagerStatic
  {
    
    Wrapperator.Interfaces.Collections.Specialized.INameValueCollection AppSettings
    {
      get;
    }
    
    System.Configuration.ConnectionStringSettingsCollection ConnectionStrings
    {
      get;
    }
    
    /// <summary>Retrieves a specified configuration section for the current application's default configuration.</summary>
    /// <returns>The specified <see cref="T:System.Configuration.ConfigurationSection" /> object, or null if the section does not exist.</returns>
    /// <param name="sectionName">The configuration section path and name.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    object GetSection(string sectionName);
    
    /// <summary>Refreshes the named section so the next time that it is retrieved it will be re-read from disk.</summary>
    /// <param name="sectionName">The configuration section name or the configuration path and section name of the section to refresh.</param>
    void RefreshSection(string sectionName);
    
    /// <summary>Opens the machine configuration file on the current computer as a <see cref="T:System.Configuration.Configuration" /> object.</summary>
    /// <returns>A <see cref="T:System.Configuration.Configuration" /> object.</returns>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenMachineConfiguration();
    
    /// <summary>Opens the machine configuration file as a <see cref="T:System.Configuration.Configuration" /> object that uses the specified file mapping.</summary>
    /// <returns>A <see cref="T:System.Configuration.Configuration" /> object.</returns>
    /// <param name="fileMap">An <see cref="T:System.Configuration.ExeConfigurationFileMap" /> object that references configuration file to use instead of the application default configuration file.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenMappedMachineConfiguration(System.Configuration.ConfigurationFileMap fileMap);
    
    /// <summary>Opens the configuration file for the current application as a <see cref="T:System.Configuration.Configuration" /> object.</summary>
    /// <returns>A <see cref="T:System.Configuration.Configuration" /> object.</returns>
    /// <param name="userLevel">The <see cref="T:System.Configuration.ConfigurationUserLevel" /> for which you are opening the configuration.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenExeConfiguration(System.Configuration.ConfigurationUserLevel userLevel);
    
    /// <summary>Opens the specified client configuration file as a <see cref="T:System.Configuration.Configuration" /> object.</summary>
    /// <returns>A <see cref="T:System.Configuration.Configuration" /> object.</returns>
    /// <param name="exePath">The path of the executable (exe) file.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenExeConfiguration(string exePath);
    
    /// <summary>Opens the specified client configuration file as a <see cref="T:System.Configuration.Configuration" /> object that uses the specified file mapping and user level.</summary>
    /// <returns>The configuration object.</returns>
    /// <param name="fileMap">An <see cref="T:System.Configuration.ExeConfigurationFileMap" /> object that references configuration file to use instead of the application default configuration file.</param>
    /// <param name="userLevel">The <see cref="T:System.Configuration.ConfigurationUserLevel" /> object for which you are opening the configuration.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenMappedExeConfiguration(System.Configuration.ExeConfigurationFileMap fileMap, System.Configuration.ConfigurationUserLevel userLevel);
    
    /// <summary>Opens the specified client configuration file as a <see cref="T:System.Configuration.Configuration" /> object that uses the specified file mapping, user level, and preload option.</summary>
    /// <returns>The configuration object.</returns>
    /// <param name="fileMap">An <see cref="T:System.Configuration.ExeConfigurationFileMap" /> object that references the configuration file to use instead of the default application configuration file.</param>
    /// <param name="userLevel">The <see cref="T:System.Configuration.ConfigurationUserLevel" /> object for which you are opening the configuration.</param>
    /// <param name="preLoad">true to preload all section groups and sections; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">A configuration file could not be loaded.</exception>
    Wrapperator.Interfaces.Configuration.IConfiguration OpenMappedExeConfiguration(System.Configuration.ExeConfigurationFileMap fileMap, System.Configuration.ConfigurationUserLevel userLevel, bool preLoad);
  }
}
