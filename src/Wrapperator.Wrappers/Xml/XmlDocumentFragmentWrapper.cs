//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Xml
{
  
  
  /// <summary>Represents a lightweight object that is useful for tree insert operations.</summary>
  public partial class XmlDocumentFragmentWrapper : Wrapperator.Interfaces.Xml.IXmlDocumentFragment
  {
    
    private System.Xml.XmlDocumentFragment _xmlDocumentFragment;
    
    public XmlDocumentFragmentWrapper(System.Xml.XmlDocumentFragment xmlDocumentFragment)
    {
      _xmlDocumentFragment = xmlDocumentFragment;
    }
    
    public string InnerXml
    {
      get
      {
        return _xmlDocumentFragment.InnerXml;
      }
      set
      {
        _xmlDocumentFragment.InnerXml = value;
      }
    }
    
    public string LocalName
    {
      get
      {
        return _xmlDocumentFragment.LocalName;
      }
    }
    
    public string Name
    {
      get
      {
        return _xmlDocumentFragment.Name;
      }
    }
    
    public System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _xmlDocumentFragment.NodeType;
      }
    }
    
    public System.Xml.XmlDocument OwnerDocument
    {
      get
      {
        return _xmlDocumentFragment.OwnerDocument;
      }
    }
    
    public System.Xml.XmlNode ParentNode
    {
      get
      {
        return _xmlDocumentFragment.ParentNode;
      }
    }
    
    /// <summary>Creates a duplicate of this node.</summary>
    /// <returns>The cloned node.</returns>
    /// <param name="deep">true to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    public System.Xml.XmlNode CloneNode(bool deep)
    {
      return _xmlDocumentFragment.CloneNode(deep);
    }
    
    /// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="w">The XmlWriter to which you want to save. </param>
    public void WriteContentTo(System.Xml.XmlWriter w)
    {
      _xmlDocumentFragment.WriteContentTo(w);
    }
    
    /// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="w">The XmlWriter to which you want to save. </param>
    public void WriteTo(System.Xml.XmlWriter w)
    {
      _xmlDocumentFragment.WriteTo(w);
    }
  }
}
