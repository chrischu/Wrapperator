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
  
  
  /// <summary>Represents a configuration file that is applicable to a particular computer, application, or resource. This class cannot be inherited.</summary>
  public partial interface IConfiguration
  {
    
    System.Configuration.AppSettingsSection AppSettings
    {
      get;
    }
    
    System.Func<string, string> AssemblyStringTransformer
    {
      get;
      set;
    }
    
    System.Configuration.ConnectionStringsSection ConnectionStrings
    {
      get;
    }
    
    System.Configuration.ContextInformation EvaluationContext
    {
      get;
    }
    
    string FilePath
    {
      get;
    }
    
    bool HasFile
    {
      get;
    }
    
    System.Configuration.ConfigurationLocationCollection Locations
    {
      get;
    }
    
    bool NamespaceDeclared
    {
      get;
      set;
    }
    
    System.Configuration.ConfigurationSectionGroup RootSectionGroup
    {
      get;
    }
    
    System.Configuration.ConfigurationSectionGroupCollection SectionGroups
    {
      get;
    }
    
    System.Configuration.ConfigurationSectionCollection Sections
    {
      get;
    }
    
    System.Runtime.Versioning.FrameworkName TargetFramework
    {
      get;
      set;
    }
    
    System.Func<string, string> TypeStringTransformer
    {
      get;
      set;
    }
    
    /// <summary>Returns the specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</summary>
    /// <returns>The specified <see cref="T:System.Configuration.ConfigurationSection" /> object.</returns>
    /// <param name="sectionName">The path to the section to be returned.</param>
    System.Configuration.ConfigurationSection GetSection(string sectionName);
    
    /// <summary>Gets the specified <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    /// <returns>The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> specified.</returns>
    /// <param name="sectionGroupName">The path name of the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> to return.</param>
    System.Configuration.ConfigurationSectionGroup GetSectionGroup(string sectionGroupName);
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    void Save();
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    void Save(System.Configuration.ConfigurationSaveMode saveMode);
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the current XML configuration file.</summary>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    void Save(System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll);
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    void SaveAs(string filename);
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">The configuration file could not be written to.- or -The configuration file has changed. </exception>
    void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode);
    
    /// <summary>Writes the configuration settings contained within this <see cref="T:System.Configuration.Configuration" /> object to the specified XML configuration file.</summary>
    /// <param name="filename">The path and file name to save the configuration file to.</param>
    /// <param name="saveMode">A <see cref="T:System.Configuration.ConfigurationSaveMode" /> value that determines which property values to save.</param>
    /// <param name="forceSaveAll">true to save even if the configuration was not modified; otherwise, false.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="filename" /> is null or an empty string ("").</exception>
    void SaveAs(string filename, System.Configuration.ConfigurationSaveMode saveMode, bool forceSaveAll);
  }
}
