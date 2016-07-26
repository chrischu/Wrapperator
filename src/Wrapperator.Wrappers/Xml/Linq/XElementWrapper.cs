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
  
  
  /// <summary>Represents an XML element.</summary>
  public class XElementWrapper : XContainerWrapper, Wrapperator.Interfaces.Xml.Linq.IXElement
  {
    
    internal System.Xml.Linq.XElement XElement { get; private set; }

    
    public XElementWrapper(System.Xml.Linq.XElement xElement) : 
        base(xElement)
    {
      XElement = xElement;
    }
    
    public System.Xml.Linq.XAttribute FirstAttribute
    {
      get
      {
        return XElement.FirstAttribute;
      }
    }
    
    public bool HasAttributes
    {
      get
      {
        return XElement.HasAttributes;
      }
    }
    
    public bool HasElements
    {
      get
      {
        return XElement.HasElements;
      }
    }
    
    public bool IsEmpty
    {
      get
      {
        return XElement.IsEmpty;
      }
    }
    
    public System.Xml.Linq.XAttribute LastAttribute
    {
      get
      {
        return XElement.LastAttribute;
      }
    }
    
    public System.Xml.Linq.XName Name
    {
      get
      {
        return XElement.Name;
      }
      set
      {
        XElement.Name = value;
      }
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return XElement.NodeType;
      }
    }
    
    public string Value
    {
      get
      {
        return XElement.Value;
      }
      set
      {
        XElement.Value = value;
      }
    }
    
    public new System.Xml.Linq.XNode FirstNode
    {
      get
      {
        return XElement.FirstNode;
      }
    }
    
    public new System.Xml.Linq.XNode LastNode
    {
      get
      {
        return XElement.LastNode;
      }
    }
    
    public new System.Xml.Linq.XNode NextNode
    {
      get
      {
        return XElement.NextNode;
      }
    }
    
    public new System.Xml.Linq.XNode PreviousNode
    {
      get
      {
        return XElement.PreviousNode;
      }
    }
    
    public new string BaseUri
    {
      get
      {
        return XElement.BaseUri;
      }
    }
    
    public new System.Xml.Linq.XDocument Document
    {
      get
      {
        return XElement.Document;
      }
    }
    
    public new System.Xml.Linq.XElement Parent
    {
      get
      {
        return XElement.Parent;
      }
    }
    
    /// <summary>Returns a collection of elements that contain this element, and the ancestors of this element. </summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and the ancestors of this element. </returns>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf()
    {
      return XElement.AncestorsAndSelf();
    }
    
    /// <summary>Returns a filtered collection of elements that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.AncestorsAndSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns the <see cref="T:System.Xml.Linq.XAttribute" /> of this <see cref="T:System.Xml.Linq.XElement" /> that has the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that has the specified <see cref="T:System.Xml.Linq.XName" />; null if there is no attribute with the specified name.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the <see cref="T:System.Xml.Linq.XAttribute" /> to get.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXAttribute Attribute(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XAttributeWrapper(XElement.Attribute(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName));
    }
    
    /// <summary>Returns a collection of attributes of this element.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> of attributes of this element.</returns>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes()
    {
      return XElement.Attributes();
    }
    
    /// <summary>Returns a filtered collection of attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> that contains the attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.Attributes(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns a collection of nodes that contain this element, and all descendant nodes of this element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> that contain this element, and all descendant nodes of this element, in document order.</returns>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodesAndSelf()
    {
      return XElement.DescendantNodesAndSelf();
    }
    
    /// <summary>Returns a collection of elements that contain this element, and all descendant elements of this element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and all descendant elements of this element, in document order.</returns>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf()
    {
      return XElement.DescendantsAndSelf();
    }
    
    /// <summary>Returns a filtered collection of elements that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.DescendantsAndSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Gets the default <see cref="T:System.Xml.Linq.XNamespace" /> of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> that contains the default namespace of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.Xml.Linq.IXNamespace GetDefaultNamespace()
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper(XElement.GetDefaultNamespace());
    }
    
    /// <summary>Gets the namespace associated with a particular prefix for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> for the namespace associated with the prefix for this <see cref="T:System.Xml.Linq.XElement" />.</returns>
    /// <param name="prefix">A string that contains the namespace prefix to look up.</param>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.Xml.Linq.IXNamespace GetNamespaceOfPrefix(string prefix)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper(XElement.GetNamespaceOfPrefix(prefix));
    }
    
    /// <summary>Gets the prefix associated with a namespace for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>A <see cref="T:System.String" /> that contains the namespace prefix.</returns>
    /// <param name="ns">An <see cref="T:System.Xml.Linq.XNamespace" /> to look up.</param>
    /// <filterpriority>2</filterpriority>
    public string GetPrefixOfNamespace(Wrapperator.Interfaces.Xml.Linq.IXNamespace ns)
    {
      return XElement.GetPrefixOfNamespace(ns == null ? default(System.Xml.Linq.XNamespace) : ((Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper)ns).XNamespace);
    }
    
    /// <summary>Removes nodes and attributes from this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    public void RemoveAll()
    {
      XElement.RemoveAll();
    }
    
    /// <summary>Removes the attributes of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    public void RemoveAttributes()
    {
      XElement.RemoveAttributes();
    }
    
    /// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
    /// <param name="content">The content that will replace the child nodes and attributes of this element.</param>
    public void ReplaceAll(object content)
    {
      XElement.ReplaceAll(content);
    }
    
    /// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public void ReplaceAll(object[] content)
    {
      XElement.ReplaceAll(content);
    }
    
    /// <summary>Replaces the attributes of this element with the specified content.</summary>
    /// <param name="content">The content that will replace the attributes of this element.</param>
    public void ReplaceAttributes(object content)
    {
      XElement.ReplaceAttributes(content);
    }
    
    /// <summary>Replaces the attributes of this element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public void ReplaceAttributes(object[] content)
    {
      XElement.ReplaceAttributes(content);
    }
    
    /// <summary>Serialize this element to a file.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    public void Save(string fileName)
    {
      XElement.Save(fileName);
    }
    
    /// <summary>Serialize this element to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(string fileName, System.Xml.Linq.SaveOptions options)
    {
      XElement.Save(fileName, options);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream)
    {
      XElement.Save(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> object that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.SaveOptions options)
    {
      XElement.Save(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream, options);
    }
    
    /// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter)
    {
      XElement.Save(textWriter == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)textWriter).TextWriter);
    }
    
    /// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter, System.Xml.Linq.SaveOptions options)
    {
      XElement.Save(textWriter == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)textWriter).TextWriter, options);
    }
    
    /// <summary>Serialize this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      XElement.Save(writer == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)writer).XmlWriter);
    }
    
    /// <summary>Sets the value of an attribute, adds an attribute, or removes an attribute. </summary>
    /// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the attribute to change.</param>
    /// <param name="value">The value to assign to the attribute. The attribute is removed if the value is null. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XAttribute.Value" /> property of the attribute.</param>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
    public void SetAttributeValue(Wrapperator.Interfaces.Xml.Linq.IXName name, object value)
    {
      XElement.SetAttributeValue(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName, value);
    }
    
    /// <summary>Sets the value of a child element, adds a child element, or removes a child element.</summary>
    /// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the child element to change.</param>
    /// <param name="value">The value to assign to the child element. The child element is removed if the value is null. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property of the child element.</param>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
    public void SetElementValue(Wrapperator.Interfaces.Xml.Linq.IXName name, object value)
    {
      XElement.SetElementValue(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName, value);
    }
    
    /// <summary>Sets the value of this element.</summary>
    /// <param name="value">The value to assign to this element. The value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an <see cref="T:System.Xml.Linq.XObject" />.</exception>
    public void SetValue(object value)
    {
      XElement.SetValue(value);
    }
    
    /// <summary>Write this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      XElement.WriteTo(writer == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)writer).XmlWriter);
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void Add(object content)
    {
      XElement.Add(content);
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void Add(object[] content)
    {
      XElement.Add(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void AddFirst(object content)
    {
      XElement.AddFirst(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddFirst(object[] content)
    {
      XElement.AddFirst(content);
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlWriter" /> that can be used to add nodes to the <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> that is ready to have content written to it.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlWriter CreateWriter()
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(XElement.CreateWriter());
    }
    
    /// <summary>Returns a collection of the descendant nodes for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the descendant nodes of the <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes()
    {
      return XElement.DescendantNodes();
    }
    
    /// <summary>Returns a collection of the descendant elements for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" />.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants()
    {
      return XElement.Descendants();
    }
    
    /// <summary>Returns a filtered collection of the descendant elements for this document or element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" /> that match the specified <see cref="T:System.Xml.Linq.XName" />.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.Descendants(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Gets the first (in document order) child element with the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>A <see cref="T:System.Xml.Linq.XElement" /> that matches the specified <see cref="T:System.Xml.Linq.XName" />, or null.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Element(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(XElement.Element(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName));
    }
    
    /// <summary>Returns a collection of the child elements of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the child elements of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements()
    {
      return XElement.Elements();
    }
    
    /// <summary>Returns a filtered collection of the child elements of this element or document, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the children of the <see cref="T:System.Xml.Linq.XContainer" /> that have a matching <see cref="T:System.Xml.Linq.XName" />, in document order.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.Elements(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns a collection of the child nodes of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the contents of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes()
    {
      return XElement.Nodes();
    }
    
    /// <summary>Removes the child nodes from this document or element.</summary>
    public new void RemoveNodes()
    {
      XElement.RemoveNodes();
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects that replace the children nodes.</param>
    public new void ReplaceNodes(object content)
    {
      XElement.ReplaceNodes(content);
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void ReplaceNodes(object[] content)
    {
      XElement.ReplaceNodes(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added after this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object content)
    {
      XElement.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object[] content)
    {
      XElement.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added before this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object content)
    {
      XElement.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object[] content)
    {
      XElement.AddBeforeSelf(content);
    }
    
    /// <summary>Returns a collection of the ancestor elements of this node.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors()
    {
      return XElement.Ancestors();
    }
    
    /// <summary>Returns a filtered collection of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.The nodes in the returned collection are in reverse document order.This method uses deferred execution.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.Ancestors(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> for this node.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> that can be used to read this node and its descendants.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader()
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(XElement.CreateReader());
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> with the options specified by the <paramref name="readerOptions" /> parameter.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="readerOptions">A <see cref="T:System.Xml.Linq.ReaderOptions" /> object that specifies whether to omit duplicate namespaces.</param>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(XElement.CreateReader(readerOptions));
    }
    
    /// <summary>Returns a collection of the sibling nodes after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf()
    {
      return XElement.NodesAfterSelf();
    }
    
    /// <summary>Returns a collection of the sibling nodes before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf()
    {
      return XElement.NodesBeforeSelf();
    }
    
    /// <summary>Returns a collection of the sibling elements after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf()
    {
      return XElement.ElementsAfterSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.ElementsAfterSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns a collection of the sibling elements before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf()
    {
      return XElement.ElementsBeforeSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XElement.ElementsBeforeSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Determines if the current node appears after a specified node in terms of document order.</summary>
    /// <returns>true if this node appears after the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsAfter(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return XElement.IsAfter(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node).XNode);
    }
    
    /// <summary>Determines if the current node appears before a specified node in terms of document order.</summary>
    /// <returns>true if this node appears before the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsBefore(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return XElement.IsBefore(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node).XNode);
    }
    
    /// <summary>Removes this node from its parent.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void Remove()
    {
      XElement.Remove();
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">Content that replaces this node.</param>
    public new void ReplaceWith(object content)
    {
      XElement.ReplaceWith(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">A parameter list of the new content.</param>
    public new void ReplaceWith(object[] content)
    {
      XElement.ReplaceWith(content);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      XElement.AddAnnotation(annotation);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(Wrapperator.Interfaces.IType type)
    {
      return XElement.Annotation(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return XElement.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(Wrapperator.Interfaces.IType type)
    {
      return XElement.Annotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return XElement.Annotations<T>();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(Wrapperator.Interfaces.IType type)
    {
      XElement.RemoveAnnotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      XElement.RemoveAnnotations<T>();
    }
  }
}
