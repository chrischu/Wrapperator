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
    
    internal System.Xml.Linq.XName XName { get; private set; }

    
    internal XNameWrapper(System.Xml.Linq.XName xName)
    {
      XName = xName;
    }
    
    public string LocalName
    {
      get
      {
        return XName.LocalName;
      }
    }
    
    public System.Xml.Linq.XNamespace Namespace
    {
      get
      {
        return XName.Namespace;
      }
    }
    
    public string NamespaceName
    {
      get
      {
        return XName.NamespaceName;
      }
    }
  }
}
