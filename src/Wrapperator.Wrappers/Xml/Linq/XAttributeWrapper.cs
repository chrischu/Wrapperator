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
  
  
  /// <summary>Represents an XML attribute.</summary>
  public class XAttributeWrapper : XObjectWrapper, Wrapperator.Interfaces.Xml.Linq.IXAttribute
  {
    
    public System.Xml.Linq.XAttribute _XAttribute { get; private set; }

    
    internal XAttributeWrapper(System.Xml.Linq.XAttribute xAttribute) : 
        base(xAttribute)
    {
      _XAttribute = xAttribute;
    }
    
    public bool IsNamespaceDeclaration
    {
      get
      {
        return _XAttribute.IsNamespaceDeclaration;
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXName Name
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNameWrapper(_XAttribute.Name);
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXAttribute NextAttribute
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XAttributeWrapper(_XAttribute.NextAttribute);
      }
    }
    
    public new System.Xml.XmlNodeType NodeType
    {
      get
      {
        return _XAttribute.NodeType;
      }
    }
    
    public Wrapperator.Interfaces.Xml.Linq.IXAttribute PreviousAttribute
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XAttributeWrapper(_XAttribute.PreviousAttribute);
      }
    }
    
    public string Value
    {
      get
      {
        return _XAttribute.Value;
      }
      set
      {
        _XAttribute.Value = value;
      }
    }
    
    public new string BaseUri
    {
      get
      {
        return _XAttribute.BaseUri;
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXDocument Document
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(_XAttribute.Document);
      }
    }
    
    public new Wrapperator.Interfaces.Xml.Linq.IXElement Parent
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(_XAttribute.Parent);
      }
    }
    
    /// <summary>Removes this attribute from its parent element.</summary>
    /// <exception cref="T:System.InvalidOperationException">The parent element is null.</exception>
    public void Remove()
    {
      _XAttribute.Remove();
    }
    
    /// <summary>Sets the value of this attribute.</summary>
    /// <param name="value">The value to assign to this attribute.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an <see cref="T:System.Xml.Linq.XObject" />.</exception>
    public void SetValue(object value)
    {
      _XAttribute.SetValue(value);
    }
    
    /// <summary>Adds an object to the annotation list of this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="annotation">An <see cref="T:System.Object" /> that contains the annotation to add.</param>
    public new void AddAnnotation(object annotation)
    {
      _XAttribute.AddAnnotation(annotation);
    }
    
    /// <summary>Gets the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>The <see cref="T:System.Object" /> that contains the first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotation to retrieve.</param>
    public new object Annotation(Wrapperator.Interfaces.IType type)
    {
      return _XAttribute.Annotation(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Get the first annotation object of the specified type from this <see cref="T:System.Xml.Linq.XObject" />. </summary>
    /// <returns>The first annotation object that matches the specified type, or null if no annotation is of the specified type.</returns>
    /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
    public new T Annotation<T>()
      where T :  class
    {
      return _XAttribute.Annotation<T>();
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Object" /> that contains the annotations that match the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> of the annotations to retrieve.</param>
    public new System.Collections.Generic.IEnumerable<object> Annotations(Wrapperator.Interfaces.IType type)
    {
      return _XAttribute.Annotations(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Gets a collection of annotations of the specified type for this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the annotations for this <see cref="T:System.Xml.Linq.XObject" />.</returns>
    /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
    public new System.Collections.Generic.IEnumerable<T> Annotations<T>()
      where T :  class
    {
      return _XAttribute.Annotations<T>();
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <param name="type">The <see cref="T:System.Type" /> of annotations to remove.</param>
    public new void RemoveAnnotations(Wrapperator.Interfaces.IType type)
    {
      _XAttribute.RemoveAnnotations(type == null ? default(System.Type) : type._Type);
    }
    
    /// <summary>Removes the annotations of the specified type from this <see cref="T:System.Xml.Linq.XObject" />.</summary>
    /// <typeparam name="T">The type of annotations to remove.</typeparam>
    public new void RemoveAnnotations<T>()
      where T :  class
    {
      _XAttribute.RemoveAnnotations<T>();
    }
  }
}
