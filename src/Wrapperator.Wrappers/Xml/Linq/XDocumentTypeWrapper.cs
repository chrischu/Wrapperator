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
  
  
  /// <summary>Represents an XML Document Type Definition (DTD). </summary>
  /// <filterpriority>2</filterpriority>
  public partial class XDocumentTypeWrapper : XNodeWrapper, Wrapperator.Interfaces.Xml.Linq.IXDocumentType
  {
    
    private System.Xml.Linq.XDocumentType _xDocumentType;
    
    public static implicit operator System.Xml.Linq.XDocumentType (XDocumentTypeWrapper wrapper)
    {
      if (wrapper == null) return default(System.Xml.Linq.XDocumentType);
      return wrapper._xDocumentType;
    }
    
    public XDocumentTypeWrapper(System.Xml.Linq.XDocumentType xDocumentType) : 
        base(xDocumentType)
    {
      _xDocumentType = xDocumentType;
    }
    
    public new string BaseUri
    {
      get
      {
        return _xDocumentType.BaseUri;
      }
    }
    
    public new System.Xml.Linq.XDocument Document
    {
      get
      {
        return _xDocumentType.Document;
      }
    }
    
    public string InternalSubset
    {
      get
      {
        return _xDocumentType.InternalSubset;
      }
      set
      {
        _xDocumentType.InternalSubset = value;
      }
    }
    
    public string Name
    {
      get
      {
        return _xDocumentType.Name;
      }
      set
      {
        _xDocumentType.Name = value;
      }
    }
    
    public new System.Xml.Linq.XNode NextNode
    {
      get
      {
        return _xDocumentType.NextNode;
      }
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _xDocumentType.NodeType;
      }
    }
    
    public new System.Xml.Linq.XElement Parent
    {
      get
      {
        return _xDocumentType.Parent;
      }
    }
    
    public new System.Xml.Linq.XNode PreviousNode
    {
      get
      {
        return _xDocumentType.PreviousNode;
      }
    }
    
    public string PublicId
    {
      get
      {
        return _xDocumentType.PublicId;
      }
      set
      {
        _xDocumentType.PublicId = value;
      }
    }
    
    public string SystemId
    {
      get
      {
        return _xDocumentType.SystemId;
      }
      set
      {
        _xDocumentType.SystemId = value;
      }
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added after this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object content)
    {
      _xDocumentType.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object[] content)
    {
      _xDocumentType.AddAfterSelf(content);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      _xDocumentType.AddAnnotation(annotation);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added before this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object content)
    {
      _xDocumentType.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object[] content)
    {
      _xDocumentType.AddBeforeSelf(content);
    }
    
    /// <summary>Returns a collection of the ancestor elements of this node.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors()
    {
      return _xDocumentType.Ancestors();
    }
    
    /// <summary>Returns a filtered collection of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.The nodes in the returned collection are in reverse document order.This method uses deferred execution.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(System.Xml.Linq.XName name)
    {
      return _xDocumentType.Ancestors(name);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(System.Type type)
    {
      return _xDocumentType.Annotation(type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return _xDocumentType.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(System.Type type)
    {
      return _xDocumentType.Annotations(type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return _xDocumentType.Annotations<T>();
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> for this node.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> that can be used to read this node and its descendants.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader()
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_xDocumentType.CreateReader());
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> with the options specified by the <paramref name="readerOptions" /> parameter.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="readerOptions">A <see cref="T:System.Xml.Linq.ReaderOptions" /> object that specifies whether to omit duplicate namespaces.</param>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_xDocumentType.CreateReader(readerOptions));
    }
    
    /// <summary>Returns a collection of the sibling elements after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf()
    {
      return _xDocumentType.ElementsAfterSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(System.Xml.Linq.XName name)
    {
      return _xDocumentType.ElementsAfterSelf(name);
    }
    
    /// <summary>Returns a collection of the sibling elements before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf()
    {
      return _xDocumentType.ElementsBeforeSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(System.Xml.Linq.XName name)
    {
      return _xDocumentType.ElementsBeforeSelf(name);
    }
    
    /// <summary>Determines if the current node appears after a specified node in terms of document order.</summary>
    /// <returns>true if this node appears after the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsAfter(System.Xml.Linq.XNode node)
    {
      return _xDocumentType.IsAfter(node);
    }
    
    /// <summary>Determines if the current node appears before a specified node in terms of document order.</summary>
    /// <returns>true if this node appears before the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsBefore(System.Xml.Linq.XNode node)
    {
      return _xDocumentType.IsBefore(node);
    }
    
    /// <summary>Returns a collection of the sibling nodes after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf()
    {
      return _xDocumentType.NodesAfterSelf();
    }
    
    /// <summary>Returns a collection of the sibling nodes before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf()
    {
      return _xDocumentType.NodesBeforeSelf();
    }
    
    /// <summary>Removes this node from its parent.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void Remove()
    {
      _xDocumentType.Remove();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(System.Type type)
    {
      _xDocumentType.RemoveAnnotations(type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      _xDocumentType.RemoveAnnotations<T>();
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">Content that replaces this node.</param>
    public new void ReplaceWith(object content)
    {
      _xDocumentType.ReplaceWith(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">A parameter list of the new content.</param>
    public new void ReplaceWith(object[] content)
    {
      _xDocumentType.ReplaceWith(content);
    }
    
    /// <summary>Write this <see cref="T:System.Xml.Linq.XDocumentType" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(System.Xml.XmlWriter writer)
    {
      _xDocumentType.WriteTo(writer);
    }
  }
}
