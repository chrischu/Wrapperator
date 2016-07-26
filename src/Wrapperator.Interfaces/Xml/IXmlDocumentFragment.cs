//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Xml
{
  
  
  /// <summary>Represents a lightweight object that is useful for tree insert operations.</summary>
  public interface IXmlDocumentFragment
  {
    
    string Name
    {
      get;
    }
    
    string LocalName
    {
      get;
    }
    
    System.Xml.XmlNodeType NodeType
    {
      get;
    }
    
    System.Xml.XmlNode ParentNode
    {
      get;
    }
    
    System.Xml.XmlDocument OwnerDocument
    {
      get;
    }
    
    string InnerXml
    {
      get;
      set;
    }
    
    string Value
    {
      get;
      set;
    }
    
    System.Xml.XmlNodeList ChildNodes
    {
      get;
    }
    
    System.Xml.XmlNode PreviousSibling
    {
      get;
    }
    
    System.Xml.XmlNode NextSibling
    {
      get;
    }
    
    System.Xml.XmlAttributeCollection Attributes
    {
      get;
    }
    
    System.Xml.XmlNode FirstChild
    {
      get;
    }
    
    System.Xml.XmlNode LastChild
    {
      get;
    }
    
    bool HasChildNodes
    {
      get;
    }
    
    string NamespaceURI
    {
      get;
    }
    
    string Prefix
    {
      get;
      set;
    }
    
    bool IsReadOnly
    {
      get;
    }
    
    string InnerText
    {
      get;
      set;
    }
    
    string OuterXml
    {
      get;
    }
    
    System.Xml.Schema.IXmlSchemaInfo SchemaInfo
    {
      get;
    }
    
    string BaseURI
    {
      get;
    }
    
    System.Xml.XmlElement this[string name]
    {
      get;
    }
    
    System.Xml.XmlElement this[string localname, string ns]
    {
      get;
    }
    
    /// <summary>Creates a duplicate of this node.</summary>
    /// <returns>The cloned node.</returns>
    /// <param name="deep">true to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    System.Xml.XmlNode CloneNode(bool deep);
    
    /// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="w">The XmlWriter to which you want to save. </param>
    void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter w);
    
    /// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="w">The XmlWriter to which you want to save. </param>
    void WriteContentTo(Wrapperator.Interfaces.Xml.IXmlWriter w);
    
    /// <summary>Creates an <see cref="T:System.Xml.XPath.XPathNavigator" /> for navigating this object.</summary>
    /// <returns>An XPathNavigator object used to navigate the node. The XPathNavigator is positioned on the node from which the method was called. It is not positioned on the root of the document.</returns>
    System.Xml.XPath.XPathNavigator CreateNavigator();
    
    /// <summary>Selects the first XmlNode that matches the XPath expression.</summary>
    /// <returns>The first XmlNode that matches the XPath query or null if no matching node is found. The XmlNode should not be expected to be connected "live" to the XML document. That is, changes that appear in the XML document may not appear in the XmlNode, and vice versa.</returns>
    /// <param name="xpath">The XPath expression. </param>
    /// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix. </exception>
    System.Xml.XmlNode SelectSingleNode(string xpath);
    
    /// <summary>Selects the first XmlNode that matches the XPath expression. Any prefixes found in the XPath expression are resolved using the supplied <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
    /// <returns>The first XmlNode that matches the XPath query or null if no matching node is found. The XmlNode should not be expected to be connected "live" to the XML document. That is, changes that appear in the XML document may not appear in the XmlNode, and vice versa.</returns>
    /// <param name="xpath">The XPath expression. </param>
    /// <param name="nsmgr">An <see cref="T:System.Xml.XmlNamespaceManager" /> to use for resolving namespaces for prefixes in the XPath expression. </param>
    /// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix which is not defined in the XmlNamespaceManager. </exception>
    System.Xml.XmlNode SelectSingleNode(string xpath, System.Xml.XmlNamespaceManager nsmgr);
    
    /// <summary>Selects a list of nodes matching the XPath expression.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlNodeList" /> containing a collection of nodes matching the XPath query.</returns>
    /// <param name="xpath">The XPath expression. </param>
    /// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix. </exception>
    System.Xml.XmlNodeList SelectNodes(string xpath);
    
    /// <summary>Selects a list of nodes matching the XPath expression. Any prefixes found in the XPath expression are resolved using the supplied <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlNodeList" /> containing a collection of nodes matching the XPath query.</returns>
    /// <param name="xpath">The XPath expression. </param>
    /// <param name="nsmgr">An <see cref="T:System.Xml.XmlNamespaceManager" /> to use for resolving namespaces for prefixes in the XPath expression. </param>
    /// <exception cref="T:System.Xml.XPath.XPathException">The XPath expression contains a prefix which is not defined in the XmlNamespaceManager. </exception>
    System.Xml.XmlNodeList SelectNodes(string xpath, System.Xml.XmlNamespaceManager nsmgr);
    
    /// <summary>Inserts the specified node immediately before the specified reference node.</summary>
    /// <returns>The node being inserted.</returns>
    /// <param name="newChild">The XmlNode to insert. </param>
    /// <param name="refChild">The XmlNode that is the reference node. The <paramref name="newChild" /> is placed before this node. </param>
    /// <exception cref="T:System.InvalidOperationException">The current node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
    System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
    
    /// <summary>Inserts the specified node immediately after the specified reference node.</summary>
    /// <returns>The node being inserted.</returns>
    /// <param name="newChild">The XmlNode to insert. </param>
    /// <param name="refChild">The XmlNode that is the reference node. The <paramref name="newNode" /> is placed after the <paramref name="refNode" />. </param>
    /// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.The <paramref name="refChild" /> is not a child of this node.This node is read-only. </exception>
    System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
    
    /// <summary>Replaces the child node <paramref name="oldChild" /> with <paramref name="newChild" /> node.</summary>
    /// <returns>The node replaced.</returns>
    /// <param name="newChild">The new node to put in the child list. </param>
    /// <param name="oldChild">The node being replaced in the list. </param>
    /// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only.The <paramref name="oldChild" /> is not a child of this node. </exception>
    System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild);
    
    /// <summary>Removes specified child node.</summary>
    /// <returns>The node removed.</returns>
    /// <param name="oldChild">The node being removed. </param>
    /// <exception cref="T:System.ArgumentException">The <paramref name="oldChild" /> is not a child of this node. Or this node is read-only. </exception>
    System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
    
    /// <summary>Adds the specified node to the beginning of the list of child nodes for this node.</summary>
    /// <returns>The node added.</returns>
    /// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location.</param>
    /// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
    System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
    
    /// <summary>Adds the specified node to the end of the list of child nodes, of this node.</summary>
    /// <returns>The node added.</returns>
    /// <param name="newChild">The node to add. All the contents of the node to be added are moved into the specified location. </param>
    /// <exception cref="T:System.InvalidOperationException">This node is of a type that does not allow child nodes of the type of the <paramref name="newChild" /> node.The <paramref name="newChild" /> is an ancestor of this node. </exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="newChild" /> was created from a different document than the one that created this node.This node is read-only. </exception>
    System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
    
    /// <summary>Puts all XmlText nodes in the full depth of the sub-tree underneath this XmlNode into a "normal" form where only markup (that is, tags, comments, processing instructions, CDATA sections, and entity references) separates XmlText nodes, that is, there are no adjacent XmlText nodes.</summary>
    void Normalize();
    
    /// <summary>Tests if the DOM implementation implements a specific feature.</summary>
    /// <returns>true if the feature is implemented in the specified version; otherwise, false. The following table describes the combinations that return true.Feature Version XML 1.0 XML 2.0 </returns>
    /// <param name="feature">The package name of the feature to test. This name is not case-sensitive. </param>
    /// <param name="version">The version number of the package name to test. If the version is not specified (null), supporting any version of the feature causes the method to return true. </param>
    bool Supports(string feature, string version);
    
    /// <summary>Creates a duplicate of this node.</summary>
    /// <returns>The cloned node.</returns>
    System.Xml.XmlNode Clone();
    
    /// <summary>Get an enumerator that iterates through the child nodes in the current node.</summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the child nodes in the current node.</returns>
    System.Collections.IEnumerator GetEnumerator();
    
    /// <summary>Removes all the child nodes and/or attributes of the current node.</summary>
    void RemoveAll();
    
    /// <summary>Looks up the closest xmlns declaration for the given prefix that is in scope for the current node and returns the namespace URI in the declaration.</summary>
    /// <returns>The namespace URI of the specified prefix.</returns>
    /// <param name="prefix">The prefix whose namespace URI you want to find. </param>
    string GetNamespaceOfPrefix(string prefix);
    
    /// <summary>Looks up the closest xmlns declaration for the given namespace URI that is in scope for the current node and returns the prefix defined in that declaration.</summary>
    /// <returns>The prefix for the specified namespace URI.</returns>
    /// <param name="namespaceURI">The namespace URI whose prefix you want to find. </param>
    string GetPrefixOfNamespace(string namespaceURI);
  }
}
