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
  
  
  /// <summary>Represents an XML processing instruction. </summary>
  public interface IXProcessingInstruction : Wrapperator.Interfaces.Xml.Linq.IXNode
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Xml.Linq.XProcessingInstruction _XProcessingInstruction
    {
      get;
    }
    
    string Data
    {
      get;
      set;
    }
    
    string Target
    {
      get;
      set;
    }
  }
}
