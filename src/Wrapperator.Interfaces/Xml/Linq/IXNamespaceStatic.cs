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
  
  
  /// <summary>Represents an XML namespace. This class cannot be inherited. </summary>
  public interface IXNamespaceStatic
  {
    
    System.Xml.Linq.XNamespace None
    {
      get;
    }
    
    System.Xml.Linq.XNamespace Xml
    {
      get;
    }
    
    System.Xml.Linq.XNamespace Xmlns
    {
      get;
    }
    
    /// <summary>Gets an <see cref="T:System.Xml.Linq.XNamespace" /> for the specified Uniform Resource Identifier (URI).</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> created from the specified URI.</returns>
    /// <param name="namespaceName">A <see cref="T:System.String" /> that contains a namespace URI.</param>
    Wrapperator.Interfaces.Xml.Linq.IXNamespace Get(string namespaceName);
  }
}
