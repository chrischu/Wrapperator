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
  
  
  /// <summary>Represents an XML element.</summary>
  public partial interface IXElement
  {
    
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> EmptySequence
    {
      get;
    }
    
    System.Xml.Linq.XAttribute FirstAttribute
    {
      get;
    }
    
    bool HasAttributes
    {
      get;
    }
    
    bool HasElements
    {
      get;
    }
    
    bool IsEmpty
    {
      get;
    }
    
    System.Xml.Linq.XAttribute LastAttribute
    {
      get;
    }
    
    System.Xml.Linq.XName Name
    {
      get;
      set;
    }
    
    System.Xml.XmlNodeType NodeType
    {
      get;
    }
    
    string Value
    {
      get;
      set;
    }
    
    /// <summary>Returns a collection of elements that contain this element, and the ancestors of this element. </summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and the ancestors of this element. </returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf();
    
    /// <summary>Returns a filtered collection of elements that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf(System.Xml.Linq.XName name);
    
    /// <summary>Returns the <see cref="T:System.Xml.Linq.XAttribute" /> of this <see cref="T:System.Xml.Linq.XElement" /> that has the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that has the specified <see cref="T:System.Xml.Linq.XName" />; null if there is no attribute with the specified name.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the <see cref="T:System.Xml.Linq.XAttribute" /> to get.</param>
    Wrapperator.Interfaces.Xml.Linq.IXAttribute Attribute(System.Xml.Linq.XName name);
    
    /// <summary>Returns a collection of attributes of this element.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> of attributes of this element.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes();
    
    /// <summary>Returns a filtered collection of attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> that contains the attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes(System.Xml.Linq.XName name);
    
    /// <summary>Returns a collection of nodes that contain this element, and all descendant nodes of this element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> that contain this element, and all descendant nodes of this element, in document order.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodesAndSelf();
    
    /// <summary>Returns a collection of elements that contain this element, and all descendant elements of this element, in document order.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and all descendant elements of this element, in document order.</returns>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf();
    
    /// <summary>Returns a filtered collection of elements that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
    /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
    /// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
    System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf(System.Xml.Linq.XName name);
    
    /// <summary>Gets the default <see cref="T:System.Xml.Linq.XNamespace" /> of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> that contains the default namespace of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.Xml.Linq.IXNamespace GetDefaultNamespace();
    
    /// <summary>Gets the namespace associated with a particular prefix for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> for the namespace associated with the prefix for this <see cref="T:System.Xml.Linq.XElement" />.</returns>
    /// <param name="prefix">A string that contains the namespace prefix to look up.</param>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.Xml.Linq.IXNamespace GetNamespaceOfPrefix(string prefix);
    
    /// <summary>Gets the prefix associated with a namespace for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    /// <returns>A <see cref="T:System.String" /> that contains the namespace prefix.</returns>
    /// <param name="ns">An <see cref="T:System.Xml.Linq.XNamespace" /> to look up.</param>
    /// <filterpriority>2</filterpriority>
    string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string referencing the file to load into a new <see cref="T:System.Xml.Linq.XElement" />.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(string uri);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string referencing the file to load into an <see cref="T:System.Xml.Linq.XElement" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(string uri, System.Xml.Linq.LoadOptions options);
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that is contained in the stream.</returns>
    /// <param name="stream">The stream that contains the XML data.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.IO.Stream stream);
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that the stream contains.</returns>
    /// <param name="stream">The stream containing the XML data.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> object that specifies whether to load base URI and line information.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.IO.Stream stream, System.Xml.Linq.LoadOptions options);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.IO.TextReader textReader);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />, optionally preserving white space and retaining line information. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.IO.TextReader textReader, System.Xml.Linq.LoadOptions options);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.Xml.XmlReader reader);
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Load(System.Xml.XmlReader reader, System.Xml.Linq.LoadOptions options);
    
    /// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
    /// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Parse(string text);
    
    /// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML, optionally preserving white space and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
    /// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    Wrapperator.Interfaces.Xml.Linq.IXElement Parse(string text, System.Xml.Linq.LoadOptions options);
    
    /// <summary>Removes nodes and attributes from this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    void RemoveAll();
    
    /// <summary>Removes the attributes of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
    void RemoveAttributes();
    
    /// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
    /// <param name="content">The content that will replace the child nodes and attributes of this element.</param>
    void ReplaceAll(object content);
    
    /// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    void ReplaceAll(object[] content);
    
    /// <summary>Replaces the attributes of this element with the specified content.</summary>
    /// <param name="content">The content that will replace the attributes of this element.</param>
    void ReplaceAttributes(object content);
    
    /// <summary>Replaces the attributes of this element with the specified content.</summary>
    /// <param name="content">A parameter list of content objects.</param>
    void ReplaceAttributes(object[] content);
    
    /// <summary>Serialize this element to a file.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    void Save(string fileName);
    
    /// <summary>Serialize this element to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(string fileName, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
    void Save(System.IO.Stream stream);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> object that specifies formatting behavior.</param>
    void Save(System.IO.Stream stream, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
    void Save(System.IO.TextWriter textWriter);
    
    /// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(System.IO.TextWriter textWriter, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
    void Save(System.Xml.XmlWriter writer);
    
    /// <summary>Sets the value of an attribute, adds an attribute, or removes an attribute. </summary>
    /// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the attribute to change.</param>
    /// <param name="value">The value to assign to the attribute. The attribute is removed if the value is null. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XAttribute.Value" /> property of the attribute.</param>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
    void SetAttributeValue(System.Xml.Linq.XName name, object value);
    
    /// <summary>Sets the value of a child element, adds a child element, or removes a child element.</summary>
    /// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the child element to change.</param>
    /// <param name="value">The value to assign to the child element. The child element is removed if the value is null. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property of the child element.</param>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
    void SetElementValue(System.Xml.Linq.XName name, object value);
    
    /// <summary>Sets the value of this element.</summary>
    /// <param name="value">The value to assign to this element. The value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an <see cref="T:System.Xml.Linq.XObject" />.</exception>
    void SetValue(object value);
    
    /// <summary>Write this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    void WriteTo(System.Xml.XmlWriter writer);
  }
}
