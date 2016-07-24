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
  public partial class XNamespaceWrapper : Wrapperator.Interfaces.Xml.Linq.IXNamespace
  {
    
    private System.Xml.Linq.XNamespace _xNamespace;
    
    public static implicit operator System.Xml.Linq.XNamespace (XNamespaceWrapper wrapper)
    {
      if (wrapper == null) return default(System.Xml.Linq.XNamespace);
      return wrapper._xNamespace;
    }
    
    public XNamespaceWrapper(System.Xml.Linq.XNamespace xNamespace)
    {
      _xNamespace = xNamespace;
    }
    
    public string NamespaceName
    {
      get
      {
        return _xNamespace.NamespaceName;
      }
    }
    
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
    
    /// <summary>Returns an <see cref="T:System.Xml.Linq.XName" /> object created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XName" /> created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</returns>
    /// <param name="localName">A <see cref="T:System.String" /> that contains a local name.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXName GetName(string localName)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNameWrapper(_xNamespace.GetName(localName));
    }
  }
}
