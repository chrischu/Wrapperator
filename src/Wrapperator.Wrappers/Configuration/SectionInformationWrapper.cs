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
  
  
  /// <summary>Contains metadata about an individual section within the configuration hierarchy. This class cannot be inherited.</summary>
  public class SectionInformationWrapper : Wrapperator.Interfaces.Configuration.ISectionInformation
  {
    
    public System.Configuration.SectionInformation _SectionInformation { get; private set; }

    
    internal SectionInformationWrapper(System.Configuration.SectionInformation sectionInformation)
    {
      _SectionInformation = sectionInformation;
    }
    
    public string SectionName
    {
      get
      {
        return _SectionInformation.SectionName;
      }
    }
    
    public string Name
    {
      get
      {
        return _SectionInformation.Name;
      }
    }
    
    public System.Configuration.ConfigurationAllowDefinition AllowDefinition
    {
      get
      {
        return _SectionInformation.AllowDefinition;
      }
      set
      {
        _SectionInformation.AllowDefinition = value;
      }
    }
    
    public System.Configuration.ConfigurationAllowExeDefinition AllowExeDefinition
    {
      get
      {
        return _SectionInformation.AllowExeDefinition;
      }
      set
      {
        _SectionInformation.AllowExeDefinition = value;
      }
    }
    
    public System.Configuration.OverrideMode OverrideModeDefault
    {
      get
      {
        return _SectionInformation.OverrideModeDefault;
      }
      set
      {
        _SectionInformation.OverrideModeDefault = value;
      }
    }
    
    public bool AllowLocation
    {
      get
      {
        return _SectionInformation.AllowLocation;
      }
      set
      {
        _SectionInformation.AllowLocation = value;
      }
    }
    
    public bool AllowOverride
    {
      get
      {
        return _SectionInformation.AllowOverride;
      }
      set
      {
        _SectionInformation.AllowOverride = value;
      }
    }
    
    public System.Configuration.OverrideMode OverrideMode
    {
      get
      {
        return _SectionInformation.OverrideMode;
      }
      set
      {
        _SectionInformation.OverrideMode = value;
      }
    }
    
    public System.Configuration.OverrideMode OverrideModeEffective
    {
      get
      {
        return _SectionInformation.OverrideModeEffective;
      }
    }
    
    public string ConfigSource
    {
      get
      {
        return _SectionInformation.ConfigSource;
      }
      set
      {
        _SectionInformation.ConfigSource = value;
      }
    }
    
    public bool InheritInChildApplications
    {
      get
      {
        return _SectionInformation.InheritInChildApplications;
      }
      set
      {
        _SectionInformation.InheritInChildApplications = value;
      }
    }
    
    public bool IsDeclared
    {
      get
      {
        return _SectionInformation.IsDeclared;
      }
    }
    
    public bool IsDeclarationRequired
    {
      get
      {
        return _SectionInformation.IsDeclarationRequired;
      }
    }
    
    public bool IsLocked
    {
      get
      {
        return _SectionInformation.IsLocked;
      }
    }
    
    public bool IsProtected
    {
      get
      {
        return _SectionInformation.IsProtected;
      }
    }
    
    public Wrapperator.Interfaces.Configuration.IProtectedConfigurationProvider ProtectionProvider
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ProtectedConfigurationProviderWrapper(_SectionInformation.ProtectionProvider);
      }
    }
    
    public bool RestartOnExternalChanges
    {
      get
      {
        return _SectionInformation.RestartOnExternalChanges;
      }
      set
      {
        _SectionInformation.RestartOnExternalChanges = value;
      }
    }
    
    public bool RequirePermission
    {
      get
      {
        return _SectionInformation.RequirePermission;
      }
      set
      {
        _SectionInformation.RequirePermission = value;
      }
    }
    
    public string Type
    {
      get
      {
        return _SectionInformation.Type;
      }
      set
      {
        _SectionInformation.Type = value;
      }
    }
    
    public bool ForceSave
    {
      get
      {
        return _SectionInformation.ForceSave;
      }
      set
      {
        _SectionInformation.ForceSave = value;
      }
    }
    
    /// <summary>Forces the associated configuration section to appear in the configuration file.</summary>
    public void ForceDeclaration()
    {
      _SectionInformation.ForceDeclaration();
    }
    
    /// <summary>Forces the associated configuration section to appear in the configuration file, or removes an existing section from the configuration file.</summary>
    /// <param name="force">true if the associated section should be written in the configuration file; otherwise, false.</param>
    /// <exception cref="T:System.Configuration.ConfigurationErrorsException">
    ///  <paramref name="force" /> is true and the associated section cannot be exported to the child configuration file, or it is undeclared.</exception>
    public void ForceDeclaration(bool force)
    {
      _SectionInformation.ForceDeclaration(force);
    }
    
    /// <summary>Marks a configuration section for protection. </summary>
    /// <param name="protectionProvider">The name of the protection provider to use.</param>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Configuration.SectionInformation.AllowLocation" /> property is set to false.- or -The target section is already a protected data section.</exception>
    public void ProtectSection(string protectionProvider)
    {
      _SectionInformation.ProtectSection(protectionProvider);
    }
    
    /// <summary>Removes the protected configuration encryption from the associated configuration section.</summary>
    public void UnprotectSection()
    {
      _SectionInformation.UnprotectSection();
    }
    
    /// <summary>Gets the configuration section that contains the configuration section associated with this object.</summary>
    /// <returns>The configuration section that contains the <see cref="T:System.Configuration.ConfigurationSection" /> that is associated with this <see cref="T:System.Configuration.SectionInformation" /> object.</returns>
    /// <exception cref="T:System.InvalidOperationException">The method is invoked from a parent section.</exception>
    public Wrapperator.Interfaces.Configuration.IConfigurationSection GetParentSection()
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationSectionWrapper(_SectionInformation.GetParentSection());
    }
    
    /// <summary>Returns an XML node object that represents the associated configuration-section object.</summary>
    /// <returns>The XML representation for this configuration section.</returns>
    /// <exception cref="T:System.InvalidOperationException">This configuration object is locked and cannot be edited.</exception>
    public string GetRawXml()
    {
      return _SectionInformation.GetRawXml();
    }
    
    /// <summary>Sets the object to an XML representation of the associated configuration section within the configuration file.</summary>
    /// <param name="rawXml">The XML to use.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="rawXml" /> is null.</exception>
    public void SetRawXml(string rawXml)
    {
      _SectionInformation.SetRawXml(rawXml);
    }
    
    /// <summary>Causes the associated configuration section to inherit all its values from the parent section.</summary>
    /// <exception cref="T:System.InvalidOperationException">This method cannot be called outside editing mode.</exception>
    public void RevertToParent()
    {
      _SectionInformation.RevertToParent();
    }
  }
}
