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
  
  
  /// <summary>Represents a node that can contain other nodes.</summary>
  /// <filterpriority>2</filterpriority>
  public partial interface IXContainer
  {
    
    string BaseUri
    {
      get;
    }
    
    System.Xml.Linq.XDocument Document
    {
      get;
    }
    
    System.Xml.Linq.XNode FirstNode
    {
      get;
    }
    
    System.Xml.Linq.XNode LastNode
    {
      get;
    }
    
    System.Xml.Linq.XNode NextNode
    {
      get;
    }
    
    System.Xml.XmlNodeType NodeType
    {
      get;
    }
    
    System.Xml.Linq.XElement Parent
    {
      get;
    }
    
    System.Xml.Linq.XNode PreviousNode
    {
      get;
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    void Add(object content);
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    void Add(object[] content);
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    void AddFirst(object content);
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    void AddFirst(object[] content);
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlWriter" /> that can be used to add nodes to the <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> that is ready to have content written to it.</returns>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.Xml.IXmlWriter CreateWriter();
    
    /// <summary>Returns a collection of the descendant nodes for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the descendant nodes of the <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes();
    
    /// <summary>Returns a collection of the descendant elements for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" />.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants();
    
    /// <summary>Returns a filtered collection of the descendant elements for this document or element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" /> that match the specified <see cref="T:System.Xml.Linq.XName" />.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(System.Xml.Linq.XName name);
    
    /// <summary>Gets the first (in document order) child element with the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>A <see cref="T:System.Xml.Linq.XElement" /> that matches the specified <see cref="T:System.Xml.Linq.XName" />, or null.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Element(System.Xml.Linq.XName name);
    
    /// <summary>Returns a collection of the child elements of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the child elements of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements();
    
    /// <summary>Returns a filtered collection of the child elements of this element or document, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the children of the <see cref="T:System.Xml.Linq.XContainer" /> that have a matching <see cref="T:System.Xml.Linq.XName" />, in document order.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(System.Xml.Linq.XName name);
    
    /// <summary>Returns a collection of the child nodes of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the contents of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes();
    
    /// <summary>Removes the child nodes from this document or element.</summary>
    void RemoveNodes();
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects that replace the children nodes.</param>
    void ReplaceNodes(object content);
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    void ReplaceNodes(object[] content);
  }
}
