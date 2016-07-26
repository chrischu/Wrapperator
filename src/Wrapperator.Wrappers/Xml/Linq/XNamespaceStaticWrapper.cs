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
  
  
  /// <summary>Represents an XML namespace. This class cannot be inherited. </summary>
  public class XNamespaceStaticWrapper : Wrapperator.Interfaces.Xml.Linq.IXNamespaceStatic
  {
    
    public System.Xml.Linq.XNamespace None
    {
      get
      {
        return System.Xml.Linq.XNamespace.None;
      }
    }
    
    public System.Xml.Linq.XNamespace Xml
    {
      get
      {
        return System.Xml.Linq.XNamespace.Xml;
      }
    }
    
    public System.Xml.Linq.XNamespace Xmlns
    {
      get
      {
        return System.Xml.Linq.XNamespace.Xmlns;
      }
    }
    
    /// <summary>Gets an <see cref="T:System.Xml.Linq.XNamespace" /> for the specified Uniform Resource Identifier (URI).</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> created from the specified URI.</returns>
    /// <param name="namespaceName">A <see cref="T:System.String" /> that contains a namespace URI.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXNamespace Get(string namespaceName)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper(System.Xml.Linq.XNamespace.Get(namespaceName));
    }
  }
}