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
  
  
  /// <summary>Represents an XML document. For the components and usage of an <see cref="T:System.Xml.Linq.XDocument" /> object, see XDocument Class Overview.</summary>
  public class XDocumentWrapper : XContainerWrapper, Wrapperator.Interfaces.Xml.Linq.IXDocument
  {
    
    public System.Xml.Linq.XDocument _XDocument { get; private set; }

    
    internal XDocumentWrapper(System.Xml.Linq.XDocument xDocument) : 
        base(xDocument)
    {
      _XDocument = xDocument;
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXDeclaration Declaration
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDeclarationWrapper(_XDocument.Declaration);
      }
      set
      {
        _XDocument.Declaration = value._XDeclaration;
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXDocumentType DocumentType
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDocumentTypeWrapper(_XDocument.DocumentType);
      }
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _XDocument.NodeType;
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXElement Root
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(_XDocument.Root);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode FirstNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XDocument.FirstNode);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode LastNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XDocument.LastNode);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode NextNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XDocument.NextNode);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode PreviousNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XDocument.PreviousNode);
      }
    }
    
    public new string BaseUri
    {
      get
      {
        return _XDocument.BaseUri;
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXDocument Document
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(_XDocument.Document);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Parent
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(_XDocument.Parent);
      }
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, overwriting an existing file, if it exists.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    public void Save(string fileName)
    {
      _XDocument.Save(fileName);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(string fileName, System.Xml.Linq.SaveOptions options)
    {
      _XDocument.Save(fileName, options);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream)
    {
      _XDocument.Save(stream == null ? default(System.IO.Stream) : stream._Stream);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.SaveOptions options)
    {
      _XDocument.Save(stream == null ? default(System.IO.Stream) : stream._Stream, options);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter)
    {
      _XDocument.Save(textWriter == null ? default(System.IO.TextWriter) : textWriter._TextWriter);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter, System.Xml.Linq.SaveOptions options)
    {
      _XDocument.Save(textWriter == null ? default(System.IO.TextWriter) : textWriter._TextWriter, options);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      _XDocument.Save(writer == null ? default(System.Xml.XmlWriter) : writer._XmlWriter);
    }
    
    /// <summary>Write this document to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      _XDocument.WriteTo(writer == null ? default(System.Xml.XmlWriter) : writer._XmlWriter);
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void Add(object content)
    {
      _XDocument.Add(content);
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void Add(object[] content)
    {
      _XDocument.Add(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void AddFirst(object content)
    {
      _XDocument.AddFirst(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddFirst(object[] content)
    {
      _XDocument.AddFirst(content);
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlWriter" /> that can be used to add nodes to the <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> that is ready to have content written to it.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlWriter CreateWriter()
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(_XDocument.CreateWriter());
    }
    
    /// <summary>Returns a collection of the descendant nodes for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the descendant nodes of the <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes()
    {
      return _XDocument.DescendantNodes();
    }
    
    /// <summary>Returns a collection of the descendant elements for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" />.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants()
    {
      return _XDocument.Descendants();
    }
    
    /// <summary>Returns a filtered collection of the descendant elements for this document or element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" /> that match the specified <see cref="T:System.Xml.Linq.XName" />.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XDocument.Descendants(name == null ? default(System.Xml.Linq.XName) : name._XName);
    }
    
    /// <summary>Gets the first (in document order) child element with the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>A <see cref="T:System.Xml.Linq.XElement" /> that matches the specified <see cref="T:System.Xml.Linq.XName" />, or null.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Element(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(_XDocument.Element(name == null ? default(System.Xml.Linq.XName) : name._XName));
    }
    
    /// <summary>Returns a collection of the child elements of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the child elements of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements()
    {
      return _XDocument.Elements();
    }
    
    /// <summary>Returns a filtered collection of the child elements of this element or document, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the children of the <see cref="T:System.Xml.Linq.XContainer" /> that have a matching <see cref="T:System.Xml.Linq.XName" />, in document order.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XDocument.Elements(name == null ? default(System.Xml.Linq.XName) : name._XName);
    }
    
    /// <summary>Returns a collection of the child nodes of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the contents of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes()
    {
      return _XDocument.Nodes();
    }
    
    /// <summary>Removes the child nodes from this document or element.</summary>
    public new void RemoveNodes()
    {
      _XDocument.RemoveNodes();
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects that replace the children nodes.</param>
    public new void ReplaceNodes(object content)
    {
      _XDocument.ReplaceNodes(content);
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void ReplaceNodes(object[] content)
    {
      _XDocument.ReplaceNodes(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added after this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object content)
    {
      _XDocument.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object[] content)
    {
      _XDocument.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added before this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object content)
    {
      _XDocument.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object[] content)
    {
      _XDocument.AddBeforeSelf(content);
    }
    
    /// <summary>Returns a collection of the ancestor elements of this node.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors()
    {
      return _XDocument.Ancestors();
    }
    
    /// <summary>Returns a filtered collection of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.The nodes in the returned collection are in reverse document order.This method uses deferred execution.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XDocument.Ancestors(name == null ? default(System.Xml.Linq.XName) : name._XName);
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> for this node.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> that can be used to read this node and its descendants.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader()
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_XDocument.CreateReader());
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> with the options specified by the <paramref name="readerOptions" /> parameter.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="readerOptions">A <see cref="T:System.Xml.Linq.ReaderOptions" /> object that specifies whether to omit duplicate namespaces.</param>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_XDocument.CreateReader(readerOptions));
    }
    
    /// <summary>Returns a collection of the sibling nodes after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf()
    {
      return _XDocument.NodesAfterSelf();
    }
    
    /// <summary>Returns a collection of the sibling nodes before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf()
    {
      return _XDocument.NodesBeforeSelf();
    }
    
    /// <summary>Returns a collection of the sibling elements after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf()
    {
      return _XDocument.ElementsAfterSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XDocument.ElementsAfterSelf(name == null ? default(System.Xml.Linq.XName) : name._XName);
    }
    
    /// <summary>Returns a collection of the sibling elements before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf()
    {
      return _XDocument.ElementsBeforeSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XDocument.ElementsBeforeSelf(name == null ? default(System.Xml.Linq.XName) : name._XName);
    }
    
    /// <summary>Determines if the current node appears after a specified node in terms of document order.</summary>
    /// <returns>true if this node appears after the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsAfter(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return _XDocument.IsAfter(node == null ? default(System.Xml.Linq.XNode) : node._XNode);
    }
    
    /// <summary>Determines if the current node appears before a specified node in terms of document order.</summary>
    /// <returns>true if this node appears before the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsBefore(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return _XDocument.IsBefore(node == null ? default(System.Xml.Linq.XNode) : node._XNode);
    }
    
    /// <summary>Removes this node from its parent.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void Remove()
    {
      _XDocument.Remove();
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">Content that replaces this node.</param>
    public new void ReplaceWith(object content)
    {
      _XDocument.ReplaceWith(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">A parameter list of the new content.</param>
    public new void ReplaceWith(object[] content)
    {
      _XDocument.ReplaceWith(content);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      _XDocument.AddAnnotation(annotation);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(Wrapperator.Interfaces.IType type)
    {
      return _XDocument.Annotation(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return _XDocument.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(Wrapperator.Interfaces.IType type)
    {
      return _XDocument.Annotations(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return _XDocument.Annotations<T>();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(Wrapperator.Interfaces.IType type)
    {
      _XDocument.RemoveAnnotations(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      _XDocument.RemoveAnnotations<T>();
    }
  }
}
