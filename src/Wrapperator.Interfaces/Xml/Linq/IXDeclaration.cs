//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Xml.Linq
{
  
  
  /// <summary>Represents an XML declaration.</summary>
  /// <filterpriority>2</filterpriority>
  public interface IXDeclaration
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Xml.Linq.XDeclaration _XDeclaration
    {
      get;
    }
    
    string Encoding
    {
      get;
      set;
    }
    
    string Standalone
    {
      get;
      set;
    }
    
    string Version
    {
      get;
      set;
    }
  }
}
