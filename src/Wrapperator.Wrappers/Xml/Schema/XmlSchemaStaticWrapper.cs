//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Xml.Schema
{
  
  
  /// <summary>An in-memory representation of an XML Schema as specified in the World Wide Web Consortium (W3C) XML Schema Part 1: Structures and XML Schema Part 2: Datatypes specifications.</summary>
  public class XmlSchemaStaticWrapper : Wrapperator.Interfaces.Xml.Schema.IXmlSchemaStatic
  {
    
    internal XmlSchemaStaticWrapper()
    {
    }
    
    /// <summary>Reads an XML Schema from the supplied <see cref="T:System.IO.TextReader" />.</summary>
    /// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
    /// <param name="reader">The TextReader containing the XML Schema to read. </param>
    /// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema syntax errors. </param>
    /// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
    public Wrapperator.Interfaces.Xml.Schema.IXmlSchema Read(Wrapperator.Interfaces.IO.ITextReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler)
    {
      return new Wrapperator.Wrappers.Xml.Schema.XmlSchemaWrapper(System.Xml.Schema.XmlSchema.Read(reader == null ? default(System.IO.TextReader) : reader._TextReader, validationEventHandler));
    }
    
    /// <summary>Reads an XML Schema  from the supplied stream.</summary>
    /// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
    /// <param name="stream">The supplied data stream. </param>
    /// <param name="validationEventHandler">The validation event handler that receives information about XML Schema syntax errors. </param>
    /// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
    public Wrapperator.Interfaces.Xml.Schema.IXmlSchema Read(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Schema.ValidationEventHandler validationEventHandler)
    {
      return new Wrapperator.Wrappers.Xml.Schema.XmlSchemaWrapper(System.Xml.Schema.XmlSchema.Read(stream == null ? default(System.IO.Stream) : stream._Stream, validationEventHandler));
    }
    
    /// <summary>Reads an XML Schema from the supplied <see cref="T:System.Xml.XmlReader" />.</summary>
    /// <returns>The <see cref="T:System.Xml.Schema.XmlSchema" /> object representing the XML Schema.</returns>
    /// <param name="reader">The XmlReader containing the XML Schema to read. </param>
    /// <param name="validationEventHandler">The validation event handler that receives information about the XML Schema syntax errors. </param>
    /// <exception cref="T:System.Xml.Schema.XmlSchemaException">An <see cref="T:System.Xml.Schema.XmlSchemaException" /> is raised if no <see cref="T:System.Xml.Schema.ValidationEventHandler" /> is specified.</exception>
    public Wrapperator.Interfaces.Xml.Schema.IXmlSchema Read(Wrapperator.Interfaces.Xml.IXmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler)
    {
      return new Wrapperator.Wrappers.Xml.Schema.XmlSchemaWrapper(System.Xml.Schema.XmlSchema.Read(reader == null ? default(System.Xml.XmlReader) : reader._XmlReader, validationEventHandler));
    }
  }
}