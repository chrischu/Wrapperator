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
    
    internal System.Configuration.Configuration Configuration { get; private set; }

    
    public ConfigurationWrapper(System.Configuration.Configuration configuration)
    {
      Configuration = configuration;
    }
    
    public System.Configuration.AppSettingsSection AppSettings
    {
      get
      {
        return Configuration.AppSettings;
      }
    }
    
    public System.Func<string, string> AssemblyStringTransformer
    {
      get
      {
        return Configuration.AssemblyStringTransformer;
      }
      set
      {
        Configuration.AssemblyStringTransformer = value;
      }
    }
    
    public System.Configuration.ConnectionStringsSection ConnectionStrings
    {
      get
      {
        return Configuration.ConnectionStrings;
      }
    }
    
    public System.Configuration.ContextInformation EvaluationContext
    {
      get
      {
        return Configuration.EvaluationContext;
      }
    }
    
    public string FilePath
    {
      get
      {
        return Configuration.FilePath;
      }
    }
    
    public bool HasFile
    {
      get
      {
        return Configuration.HasFile;
      }
    }
    
    public System.Configuration.ConfigurationLocationCollection Locations
    {
      get
      {
        return Configuration.Locations;
      }
    }
    
    public bool NamespaceDeclared
    {
      get
      {
        return Configuration.NamespaceDeclared;
      }
      set
      {
        Configuration.NamespaceDeclared = value;
      }
    }
    
    public System.Configuration.ConfigurationSectionGroup RootSectionGroup
    {
      get
      {
        return Configuration.RootSectionGroup;
      }
    }
    
    public System.Configuration.ConfigurationSectionGroupCollection SectionGroups
    {
      get
      {
        return Configuration.SectionGroups;
      }
    }
    
    public System.Configuration.ConfigurationSectionCollection Sections
    {
      get
      {
        return Configuration.Sections;
      }
    }
    
    public System.Runtime.Versioning.FrameworkName TargetFramework
    {
      get
      {
        return Configuration.TargetFramework;
      }
      set
      {
        Configuration.TargetFramework = value;
      }
    }
    
    public System.Func<string, string> TypeStringTransformer
    {
      get
      {
        return Configuration.TypeStringTransformer;
      }
      set
      {
        Configuration.TypeStringTransformer = value;
      }
    }
    
    /// <summary>Returns the specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</summary>
    /// <returns>The specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</returns>
    /// <param name="sectionName">The path to the section to be returned.</param>
    public System.Configuration.ConfigurationSection GetSection(string sectionName)
    {
      return Configuration.GetSection(sectionName);
    }
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> specified.</returns>
    /// <param name="sectionGroupName">The path name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> to return.</param>
    public System.Configuration.ConfigurationSectionGroup GetSectionGroup(string sectionGroupName)
    {
      return Configuration.GetSectionGroup(sectionGroupName);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save()
    {
      Configuration.Save();
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode)
    {
      Configuration.Save(saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void Save(System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      Configuration.Save(saveMode, forceSaveAll);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename)
    {
      Configuration.SaveAs(filename);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode)
    {
      Configuration.SaveAs(filename, saveMode);
    }
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="filename" /> is null or an empty string ("").</exception>
    public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll)
    {
      Configuration.SaveAs(filename, saveMode, forceSaveAll);
    }
  }
}
