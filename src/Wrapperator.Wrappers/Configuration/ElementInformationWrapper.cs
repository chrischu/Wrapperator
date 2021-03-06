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
  
  
  /// <summary>Contains meta-information about an individual element within the configuration. This class cannot be inherited.</summary>
  public class ElementInformationWrapper : Wrapperator.Interfaces.Configuration.IElementInformation
  {
    
    public System.Configuration.ElementInformation _ElementInformation { get; private set; }

    
    internal ElementInformationWrapper(System.Configuration.ElementInformation elementInformation)
    {
      _ElementInformation = elementInformation;
    }
    
    public Wrapperator.Interfaces.Configuration.IPropertyInformationCollection Properties
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.PropertyInformationCollectionWrapper(_ElementInformation.Properties);
      }
    }
    
    public bool IsPresent
    {
      get
      {
        return _ElementInformation.IsPresent;
      }
    }
    
    public bool IsLocked
    {
      get
      {
        return _ElementInformation.IsLocked;
      }
    }
    
    public bool IsCollection
    {
      get
      {
        return _ElementInformation.IsCollection;
      }
    }
    
    public string Source
    {
      get
      {
        return _ElementInformation.Source;
      }
    }
    
    public int LineNumber
    {
      get
      {
        return _ElementInformation.LineNumber;
      }
    }
    
    public Wrapperator.Interfaces.IType Type
    {
      get
      {
        return new Wrapperator.Wrappers.TypeWrapper(_ElementInformation.Type);
      }
    }
    
    public System.Configuration.ConfigurationValidatorBase Validator
    {
      get
      {
        return _ElementInformation.Validator;
      }
    }
    
    public System.Collections.ICollection Errors
    {
      get
      {
        return _ElementInformation.Errors;
      }
    }
  }
}
