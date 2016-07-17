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
  
  
  /// <summary>Represents a configuration file that is applicable to a particular computer, application, or resource. This class cannot be inherited.</summary>
  public partial class ConfigurationWrapper : Wrapperator.Interfaces.Configuration.IConfiguration
  {
    
    private System.Configuration.Configuration _configuration;
    
    public ConfigurationWrapper(System.Configuration.Configuration configuration)
    {
      _configuration = configuration;
    }
    
    public System.Configuration.AppSettingsSection AppSettings
    {
      get
      {
        return _configuration.AppSettings;
      }
    }
    
    public System.Func<string, string> AssemblyStringTransformer
    {
      get
      {
        return _configuration.AssemblyStringTransformer;
      }
      set
      {
        _configuration.AssemblyStringTransformer = value;
      }
    }
    
    public System.Configuration.ConnectionStringsSection ConnectionStrings
    {
      get
      {
        return _configuration.ConnectionStrings;
      }
    }
    
    public System.Configuration.ContextInformation EvaluationContext
    {
      get
      {
        return _configuration.EvaluationContext;
      }
    }
    
    public string FilePath
    {
      get
      {
        return _configuration.FilePath;
      }
    }
    
    public bool HasFile
    {
      get
      {
        return _configuration.HasFile;
      }
    }
    
    public System.Configuration.ConfigurationLocationCollection Locations
    {
      get
      {
        return _configuration.Locations;
      }
    }
    
    public bool NamespaceDeclared
    {
      get
      {
        return _configuration.NamespaceDeclared;
      }
      set
      {
        _configuration.NamespaceDeclared = value;
      }
    }
    
    public System.Configuration.ConfigurationSectionGroup RootSectionGroup
    {
      get
      {
        return _configuration.RootSectionGroup;
      }
    }
    
    public System.Configuration.ConfigurationSectionGroupCollection SectionGroups
    {
      get
      {
        return _configuration.SectionGroups;
      }
    }
    
    public System.Configuration.ConfigurationSectionCollection Sections
    {
      get
      {
        return _configuration.Sections;
      }
    }
    
    public System.Runtime.Versioning.FrameworkName TargetFramework
    {
      get
      {
        return _configuration.TargetFramework;
      }
      set
      {
        _configuration.TargetFramework = value;
      }
    }
    
    public System.Func<string, string> TypeStringTransformer
    {
      get
      {
        return _configuration.TypeStringTransformer;
      }
      set
      {
        _configuration.TypeStringTransformer = value;
      }
    }
    
    /// <summary>Returns the specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</summary>
    /// <returns>The specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</returns>
    /// <param name="sectionName">The path to the section to be returned.</param>
    public System.Configuration.ConfigurationSection GetSection(string sectionName)
    {
      return _configuration.GetSection(sectionName);
    }
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> specified.</returns>
    /// <param name="sectionGroupName">The path name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> to return.</param>
    public System.Configuration.ConfigurationSectionGroup GetSectionGroup(string sectionGroupName)
    {
      return _configuration.GetSectionGroup(sectionGroupName);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save()
    {
      _configuration.Save();
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode)
    {
      _configuration.Save(saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      _configuration.Save(saveMode, forceSaveAll);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename)
    {
      _configuration.SaveAs(filename);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode)
    {
      _configuration.SaveAs(filename, saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="filename" /> is null or an empty string ("").</exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      _configuration.SaveAs(filename, saveMode, forceSaveAll);
    }
  }
}
