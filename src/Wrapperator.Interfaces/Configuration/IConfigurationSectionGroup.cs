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
  
  
  /// <summary>Represents a group of related sections within a configuration file.</summary>
  public interface IConfigurationSectionGroup
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Configuration.ConfigurationSectionGroup _ConfigurationSectionGroup
    {
      get;
    }
    
    bool IsDeclared
    {
      get;
    }
    
    bool IsDeclarationRequired
    {
      get;
    }
    
    string SectionGroupName
    {
      get;
    }
    
    string Name
    {
      get;
    }
    
    string Type
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.Configuration.IConfigurationSectionCollection Sections
    {
      get;
    }
    
    Wrapperator.Interfaces.Configuration.IConfigurationSectionGroupCollection SectionGroups
    {
      get;
    }
    
    /// <summary>Forces the declaration for this <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    void ForceDeclaration();
    
    /// <summary>Forces the declaration for this <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object.</summary>
    /// <param name="force">true if the <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object must be written to the file; otherwise, false.</param>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object is the root section group.- or -The <see cref="T:System.Configuration.ConfigurationSectionGroup" /> object has a location.</exception>
    void ForceDeclaration(bool force);
  }
}