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
  public class ConfigurationWrapper : Wrapperator.Interfaces.Configuration.IConfiguration
  {
    
    public System.Configuration.Configuration _Configuration { get; private set; }

    
    internal ConfigurationWrapper(System.Configuration.Configuration configuration)
    {
      _Configuration = configuration;
    }
    
    public Wrapperator.Interfaces.Configuration.IAppSettingsSection AppSettings
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.AppSettingsSectionWrapper(_Configuration.AppSettings);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConnectionStringsSection ConnectionStrings
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConnectionStringsSectionWrapper(_Configuration.ConnectionStrings);
      }
    }
    
    public string FilePath
    {
      get
      {
        return _Configuration.FilePath;
      }
    }
    
    public bool HasFile
    {
      get
      {
        return _Configuration.HasFile;
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationLocationCollection Locations
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationLocationCollectionWrapper(_Configuration.Locations);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IContextInformation EvaluationContext
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ContextInformationWrapper(_Configuration.EvaluationContext);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup RootSectionGroup
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_Configuration.RootSectionGroup);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionCollection Sections
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationSectionCollectionWrapper(_Configuration.Sections);
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroupCollection SectionGroups
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupCollectionWrapper(_Configuration.SectionGroups);
      }
    }
    
    public bool NamespaceDeclared
    {
      get
      {
        return _Configuration.NamespaceDeclared;
      }
      set
      {
        _Configuration.NamespaceDeclared = value;
      }
    }
    
    public System.Func<string, string> TypeStringTransformer
    {
      get
      {
        return _Configuration.TypeStringTransformer;
      }
      set
      {
        _Configuration.TypeStringTransformer = value;
      }
    }
    
    public System.Func<string, string> AssemblyStringTransformer
    {
      get
      {
        return _Configuration.AssemblyStringTransformer;
      }
      set
      {
        _Configuration.AssemblyStringTransformer = value;
      }
    }
    
    public System.Runtime.Versioning.FrameworkName TargetFramework
    {
      get
      {
        return _Configuration.TargetFramework;
      }
      set
      {
        _Configuration.TargetFramework = value;
      }
    }
    
    /// <summary>Returns the specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</summary>
    /// <returns>The specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</returns>
    /// <param name="sectionName">The path to the section to be returned.</param>
    public Wrapperator.Interfaces.Configuration.IConfigurationSection GetSection(string sectionName)
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationSectionWrapper(_Configuration.GetSection(sectionName));
    }
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> specified.</returns>
    /// <param name="sectionGroupName">The path name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> to return.</param>
    public Wrapperator.Interfaces.Configuration.IConfigurationSectionGroup GetSectionGroup(string sectionGroupName)
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationSectionGroupWrapper(_Configuration.GetSectionGroup(sectionGroupName));
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save()
    {
      _Configuration.Save();
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode)
    {
      _Configuration.Save(saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      _Configuration.Save(saveMode, forceSaveAll);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename)
    {
      _Configuration.SaveAs(filename);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode)
    {
      _Configuration.SaveAs(filename, saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="filename" /> is null or an empty string ("").</exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      _Configuration.SaveAs(filename, saveMode, forceSaveAll);
    }
  }
}
