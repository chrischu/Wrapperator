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
  
  
  /// <summary>Represents a name of an XML element or attribute. </summary>
  public class XNameWrapper : Wrapperator.Interfaces.Xml.Linq.IXName
  {
    
    public System.Xml.Linq.XName _XName { get; private set; }

    
    internal XNameWrapper(System.Xml.Linq.XName xName)
    {
      _XName = xName;
    }
    
    public string LocalName
    {
      get
      {
        return _XName.LocalName;
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXNamespace Namespace
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper(_XName.Namespace);
      }
    }
    
    public string NamespaceName
    {
      get
      {
        return _XName.NamespaceName;
      }
    }
  }
}
