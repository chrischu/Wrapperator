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
  
  
  /// <summary>Represents an XML comment. </summary>
  public class XCommentWrapper : XNodeWrapper, Wrapperator.Interfaces.Xml.Linq.IXComment
  {
    
    public System.Xml.Linq.XComment _XComment { get; private set; }

    
    internal XCommentWrapper(System.Xml.Linq.XComment xComment) : 
        base(xComment)
    {
      _XComment = xComment;
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _XComment.NodeType;
      }
    }
    
    public string Value
    {
      get
      {
        return _XComment.Value;
      }
      set
      {
        _XComment.Value = value;
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode NextNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XComment.NextNode);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXNode PreviousNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(_XComment.PreviousNode);
      }
    }
    
    public new string BaseUri
    {
      get
      {
        return _XComment.BaseUri;
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXDocument Document
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(_XComment.Document);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Parent
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(_XComment.Parent);
      }
    }
    
    /// <summary>Write this comment to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    public new void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter writer)
    {
      _XComment.WriteTo(writer == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)writer)._XmlWriter);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added after this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object content)
    {
      _XComment.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately after this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddAfterSelf(object[] content)
    {
      _XComment.AddAfterSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A content object that contains simple content or a collection of content objects to be added before this node.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object content)
    {
      _XComment.AddBeforeSelf(content);
    }
    
    /// <summary>Adds the specified content immediately before this node.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void AddBeforeSelf(object[] content)
    {
      _XComment.AddBeforeSelf(content);
    }
    
    /// <summary>Returns a collection of the ancestor elements of this node.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors()
    {
      return _XComment.Ancestors();
    }
    
    /// <summary>Returns a filtered collection of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the ancestor elements of this node. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.The nodes in the returned collection are in reverse document order.This method uses deferred execution.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XComment.Ancestors(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name)._XName);
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> for this node.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> that can be used to read this node and its descendants.</returns>
    /// <filterpriority>2</filterpriority>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader()
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_XComment.CreateReader());
    }
    
    /// <summary>Creates an <see cref="T:System.Xml.XmlReader" /> with the options specified by the <paramref name="readerOptions" /> parameter.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="readerOptions">A <see cref="T:System.Xml.Linq.ReaderOptions" /> object that specifies whether to omit duplicate namespaces.</param>
    public new Wrapperator.Interfaces.Xml.IXmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(_XComment.CreateReader(readerOptions));
    }
    
    /// <summary>Returns a collection of the sibling nodes after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf()
    {
      return _XComment.NodesAfterSelf();
    }
    
    /// <summary>Returns a collection of the sibling nodes before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> of the sibling nodes before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf()
    {
      return _XComment.NodesBeforeSelf();
    }
    
    /// <summary>Returns a collection of the sibling elements after this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf()
    {
      return _XComment.ElementsAfterSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements after this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XComment.ElementsAfterSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name)._XName);
    }
    
    /// <summary>Returns a collection of the sibling elements before this node, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order.</returns>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf()
    {
      return _XComment.ElementsBeforeSelf();
    }
    
    /// <summary>Returns a filtered collection of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of the sibling elements before this node, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    public new System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(Wrapperator.Interfaces.Xml.Linq.IXName name)
    {
      return _XComment.ElementsBeforeSelf(name == null ? default(System.Xml.Linq.XName) : ((Wrapperator.Wrappers.Xml.Linq.XNameWrapper)name)._XName);
    }
    
    /// <summary>Determines if the current node appears after a specified node in terms of document order.</summary>
    /// <returns>true if this node appears after the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsAfter(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return _XComment.IsAfter(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node)._XNode);
    }
    
    /// <summary>Determines if the current node appears before a specified node in terms of document order.</summary>
    /// <returns>true if this node appears before the specified node; otherwise false.</returns>
    /// <param name="node">The <see cref="T:System.Xml.Linq.XNode" /> to compare for document order.</param>
    public new bool IsBefore(Wrapperator.Interfaces.Xml.Linq.IXNode node)
    {
      return _XComment.IsBefore(node == null ? default(System.Xml.Linq.XNode) : ((Wrapperator.Wrappers.Xml.Linq.XNodeWrapper)node)._XNode);
    }
    
    /// <summary>Removes this node from its parent.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent is null.</exception>
    public new void Remove()
    {
      _XComment.Remove();
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">Content that replaces this node.</param>
    public new void ReplaceWith(object content)
    {
      _XComment.ReplaceWith(content);
    }
    
    /// <summary>Replaces this node with the specified content.</summary>
    /// <param name="content">A parameter list of the new content.</param>
    public new void ReplaceWith(object[] content)
    {
      _XComment.ReplaceWith(content);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      _XComment.AddAnnotation(annotation);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(Wrapperator.Interfaces.IType type)
    {
      return _XComment.Annotation(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type)._Type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return _XComment.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(Wrapperator.Interfaces.IType type)
    {
      return _XComment.Annotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type)._Type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return _XComment.Annotations<T>();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(Wrapperator.Interfaces.IType type)
    {
      _XComment.RemoveAnnotations(type == null ? default(System.Type) : ((Wrapperator.Wrappers.TypeWrapper)type)._Type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      _XComment.RemoveAnnotations<T>();
    }
  }
}
