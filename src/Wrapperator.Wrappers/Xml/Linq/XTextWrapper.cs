//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Xml.Linq
{
  
  
  /// <summary>Represents a text node. </summary>
  /// <filterpriority>2</filterpriority>
  public partial class XTextWrapper : XNodeWrapper, Wrapperator.Interfaces.Xml.Linq.IXText
  {
    
    private System.Xml.Linq.XText _xText;
    
    public XTextWrapper(System.Xml.Linq.XText xText) : 
        base(xText)
    {
      _xText = xText;
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _xText.NodeType;
      }
    }
    
    public string Value
    {
      get
      {
        return _xText.Value;
      }
      set
      {
        _xText.Value = value;
      }
    }
    
    /// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(System.Xml.XmlWriter writer)
    {
      _xText.WriteTo(writer);
    }
  }
}
