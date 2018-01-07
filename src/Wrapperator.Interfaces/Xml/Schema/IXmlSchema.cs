//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Xml.Schema
{
  
  
  /// <summary>An in-memory representation of an XML Schema as specified in the World Wide Web Consortium (W3C) XML Schema Part 1: Structures and XML Schema Part 2: Datatypes specifications.</summary>
  public interface IXmlSchema
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Xml.Schema.XmlSchema _XmlSchema
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaForm AttributeFormDefault
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaDerivationMethod BlockDefault
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaDerivationMethod FinalDefault
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaForm ElementFormDefault
    {
      get;
      set;
    }
    
    string TargetNamespace
    {
      get;
      set;
    }
    
    string Version
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaObjectCollection Includes
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectCollection Items
    {
      get;
    }
    
    bool IsCompiled
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable Attributes
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable AttributeGroups
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable SchemaTypes
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable Elements
    {
      get;
    }
    
    string Id
    {
      get;
      set;
    }
    
    System.Xml.XmlAttribute[] UnhandledAttributes
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable Groups
    {
      get;
    }
    
    System.Xml.Schema.XmlSchemaObjectTable Notations
    {
      get;
    }
    
    int LineNumber
    {
      get;
      set;
    }
    
    int LinePosition
    {
      get;
      set;
    }
    
    string SourceUri
    {
      get;
      set;
    }
    
    System.Xml.Schema.XmlSchemaObject Parent
    {
      get;
      set;
    }
    
    System.Xml.Serialization.XmlSerializerNamespaces Namespaces
    {
      get;
      set;
    }
    
    /// <summary>Writes the XML Schema to the supplied data stream.</summary>
    /// <param name="stream">The supplied data stream. </param>
    void Write(Wrapperator.Interfaces.IO.IStream stream);
    
    /// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.Stream" /> using the <see cref="T:System.Xml.XmlNamespaceManager" /> specified.</summary>
    /// <param name="stream">The supplied data stream. </param>
    /// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />.</param>
    void Write(Wrapperator.Interfaces.IO.IStream stream, System.Xml.XmlNamespaceManager namespaceManager);
    
    /// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to write to.</param>
    void Write(Wrapperator.Interfaces.IO.ITextWriter writer);
    
    /// <summary>Writes the XML Schema to the supplied <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to write to.</param>
    /// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />. </param>
    void Write(Wrapperator.Interfaces.IO.ITextWriter writer, System.Xml.XmlNamespaceManager namespaceManager);
    
    /// <summary>Writes the XML Schema to the supplied <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write to. </param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="writer" /> parameter is null.</exception>
    void Write(Wrapperator.Interfaces.Xml.IXmlWriter writer);
    
    /// <summary>Writes the XML Schema to the supplied <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to write to.</param>
    /// <param name="namespaceManager">The <see cref="T:System.Xml.XmlNamespaceManager" />. </param>
    void Write(Wrapperator.Interfaces.Xml.IXmlWriter writer, System.Xml.XmlNamespaceManager namespaceManager);
  }
}
