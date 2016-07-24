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
  public partial class XDocumentWrapper : XContainerWrapper, Wrapperator.Interfaces.Xml.Linq.IXDocument
  {
    
    internal System.Xml.Linq.XDocument XDocument { get; private set; }

    
    public XDocumentWrapper(System.Xml.Linq.XDocument xDocument) : 
        base(xDocument)
    {
      XDocument = xDocument;
    }
    
    public new string BaseUri
    {
      get
      {
        return XDocument.BaseUri;
      }
    }
    
    public System.Xml.Linq.XDeclaration Declaration
    {
      get
      {
        return XDocument.Declaration;
      }
      set
      {
        XDocument.Declaration = value;
      }
    }
    
    public new System.Xml.Linq.XDocument Document
    {
      get
      {
        return XDocument.Document;
      }
    }
    
    public System.Xml.Linq.XDocumentType DocumentType
    {
      get
      {
        return XDocument.DocumentType;
      }
    }
    
    public new System.Xml.Linq.XNode FirstNode
    {
      get
      {
        return XDocument.FirstNode;
      }
    }
    
    public new System.Xml.Linq.XNode LastNode
    {
      get
      {
        return XDocument.LastNode;
      }
    }
    
    public new System.Xml.Linq.XNode NextNode
    {
      get
      {
        return XDocument.NextNode;
      }
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return XDocument.NodeType;
      }
    }
    
    public new System.Xml.Linq.XElement Parent
    {
      get
      {
        return XDocument.Parent;
      }
    }
    
    public new System.Xml.Linq.XNode PreviousNode
    {
      get
      {
        return XDocument.PreviousNode;
      }
    }
    
    public System.Xml.Linq.XElement Root
    {
      get
      {
        return XDocument.Root;
      }
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void Add(object content)
    {
      XDocument.Add(content);
    }
    
    /// <summary>Adds the specified content as children of this <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void Add(object[] content)
    {
      XDocument.Add(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added after this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object content)
    {
      XDocument.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object[] content)
    {
      XDocument.AddAfterSelf(content);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      XDocument.AddAnnotation(annotation);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added before this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object content)
    {
      XDocument.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object[] content)
    {
      XDocument.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects to be added.</param>
    public new void AddFirst(object content)
    {
      XDocument.AddFirst(content);
    }
    
    /// <summary>Adds the specified content as the first children of this document or element.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddFirst(object[] content)
    {
      XDocument.AddFirst(content);
    }
    
    /// <summary>Returns a collection of the ancestor elements of this node.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors()
    {
      return XDocument.Ancestors();
    }
    
    /// <summary>Returns a filtered collection of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.The nodes in the returned collection are in reverse document order.This method uses deferred execution.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XDocument.Ancestors(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(Wrapperator.Interfaces.IType type)
    {
      return XDocument.Annotation(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return XDocument.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(Wrapperator.Interfaces.IType type)
    {
      return XDocument.Annotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return XDocument.Annotations<T>();
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> for this node.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> that can be used to read this node and its descendants.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader()
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(XDocument.CreateReader());
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> with the options specified by the <paramref name="readerOptions" /> parameter.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="readerOptions">A <see cref="T:System.Xml.Linq.ReaderOptions" /> object that specifies whether to omit duplicate namespaces.</param>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(XDocument.CreateReader(readerOptions));
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlWriter" /> that can be used to add nodes to the <see cref="T:System.Xml.Linq.XContainer" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> that is ready to have content written to it.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlWriter CreateWriter()
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(XDocument.CreateWriter());
    }
    
    /// <summary>Returns a collection of the descendant nodes for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the descendant nodes of the <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes()
    {
      return XDocument.DescendantNodes();
    }
    
    /// <summary>Returns a collection of the descendant elements for this document or element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" />.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants()
    {
      return XDocument.Descendants();
    }
    
    /// <summary>Returns a filtered collection of the descendant elements for this document or element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the descendant elements of the <see cref="T:System.Xml.Linq.XContainer" /> that match the specified <see cref="T:System.Xml.Linq.XName" />.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XDocument.Descendants(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Gets the first (in document order) child element with the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>A <see cref="T:System.Xml.Linq.XElement" /> that matches the specified <see cref="T:System.Xml.Linq.XName" />, or null.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Element(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(XDocument.Element(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName));
    }
    
    /// <summary>Returns a collection of the child elements of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the child elements of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements()
    {
      return XDocument.Elements();
    }
    
    /// <summary>Returns a filtered collection of the child elements of this element or document, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> containing the children of the <see cref="T:System.Xml.Linq.XContainer" /> that have a matching <see cref="T:System.Xml.Linq.XName" />, in document order.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XDocument.Elements(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns a collection of the sibling elements after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf()
    {
      return XDocument.ElementsAfterSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XDocument.ElementsAfterSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Returns a collection of the sibling elements before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf()
    {
      return XDocument.ElementsBeforeSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return XDocument.ElementsBeforeSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name).XName);
    }
    
    /// <summary>Determines if the current node appears after a specified node in terms of document order.</summary>
    /// <returns>true if this node appears after the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsAfter(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return XDocument.IsAfter(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node).XNode);
    }
    
    /// <summary>Determines if the current node appears before a specified node in terms of document order.</summary>
    /// <returns>true if this node appears before the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsBefore(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return XDocument.IsBefore(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node).XNode);
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a file. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string that references the file to load into a new <see cref="T:System.Xml.Linq.XDocument" />.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(string uri)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(uri));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a file, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string that references the file to load into a new <see cref="T:System.Xml.Linq.XDocument" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(string uri, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(uri, options));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> instance by using the specified stream.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> object that reads the data that is contained in the stream. </returns>
    /// <param name="stream">The stream that contains the XML data.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.IO.IStream stream)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> instance by using the specified stream, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> object that reads the data that is contained in the stream.</returns>
    /// <param name="stream">The stream containing the XML data.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream, options));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a <see cref="T:System.IO.TextReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the contents of the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that contains the content for the <see cref="T:System.Xml.Linq.XDocument" />.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.IO.ITextReader textReader)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(textReader == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)textReader).TextReader));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a <see cref="T:System.IO.TextReader" />, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that contains the content for the <see cref="T:System.Xml.Linq.XDocument" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.IO.ITextReader textReader, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(textReader == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)textReader).TextReader, options));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from an <see cref="T:System.Xml.XmlReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the contents of the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that contains the content for the <see cref="T:System.Xml.Linq.XDocument" />.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.Xml.IXmlReader reader)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(reader == null ? default(System.Xml.XmlReader) : ((Wrapperator.Wrappers.Xml.XmlReaderWrapper)reader).XmlReader));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XDocument" /> from an <see cref="T:System.Xml.XmlReader" />, optionally setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XDocument" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Load(Wrapperator.Interfaces.Xml.IXmlReader reader, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Load(reader == null ? default(System.Xml.XmlReader) : ((Wrapperator.Wrappers.Xml.XmlReaderWrapper)reader).XmlReader, options));
    }
    
    /// <summary>Returns a collection of the child nodes of this element or document, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> containing the contents of this <see cref="T:System.Xml.Linq.XContainer" />, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes()
    {
      return XDocument.Nodes();
    }
    
    /// <summary>Returns a collection of the sibling nodes after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf()
    {
      return XDocument.NodesAfterSelf();
    }
    
    /// <summary>Returns a collection of the sibling nodes before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf()
    {
      return XDocument.NodesBeforeSelf();
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a string.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> populated from the string that contains XML.</returns>
    /// <param name="text">A string that contains XML.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Parse(string text)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Parse(text));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XDocument" /> from a string, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XDocument" /> populated from the string that contains XML.</returns>
    /// <param name="text">A string that contains XML.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXDocument Parse(string text, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(System.Xml.Linq.XDocument.Parse(text, options));
    }
    
    /// <summary>Removes this node from its parent.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void Remove()
    {
      XDocument.Remove();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(Wrapperator.Interfaces.IType type)
    {
      XDocument.RemoveAnnotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type).Type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      XDocument.RemoveAnnotations<T>();
    }
    
    /// <summary>Removes the child nodes from this document or element.</summary>
    public new void RemoveNodes()
    {
      XDocument.RemoveNodes();
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A content object containing simple content or a collection of content objects that replace the children nodes.</param>
    public new void ReplaceNodes(object content)
    {
      XDocument.ReplaceNodes(content);
    }
    
    /// <summary>Replaces the children nodes of this document or element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    public new void ReplaceNodes(object[] content)
    {
      XDocument.ReplaceNodes(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">Content that replaces this node.</param>
    public new void ReplaceWith(object content)
    {
      XDocument.ReplaceWith(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">A parameter list of the new content.</param>
    public new void ReplaceWith(object[] content)
    {
      XDocument.ReplaceWith(content);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, overwriting an existing file, if it exists.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    public void Save(string fileName)
    {
      XDocument.Save(fileName);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(string fileName, System.Xml.Linq.SaveOptions options)
    {
      XDocument.Save(fileName, options);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream)
    {
      XDocument.Save(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream);
    }
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.SaveOptions options)
    {
      XDocument.Save(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream, options);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter)
    {
      XDocument.Save(textWriter == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)textWriter).TextWriter);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    public void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter, System.Xml.Linq.SaveOptions options)
    {
      XDocument.Save(textWriter == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)textWriter).TextWriter, options);
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    public void Save(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      XDocument.Save(writer == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)writer).XmlWriter);
    }
    
    /// <summary>Write this document to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      XDocument.WriteTo(writer == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)writer).XmlWriter);
    }
  }
}
