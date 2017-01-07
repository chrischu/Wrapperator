//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Xml
{
  
  
  /// <summary>Represents a reader that provides fast, noncached, forward-only access to XML data.</summary>
  public class XmlReaderStaticWrapper : Wrapperator.Interfaces.Xml.IXmlReaderStatic
  {
    
    internal XmlReaderStaticWrapper()
    {
    }
    
    /// <summary>Returns a value indicating whether the string argument is a valid XML name.</summary>
    /// <returns>true if the name is valid; otherwise, false.</returns>
    /// <param name="str">The name to validate.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="str" /> value is null.</exception>
    public bool IsName(string str)
    {
      return System.Xml.XmlReader.IsName(str);
    }
    
    /// <summary>Returns a value indicating whether or not the string argument is a valid XML name token.</summary>
    /// <returns>true if it is a valid name token; otherwise false.</returns>
    /// <param name="str">The name token to validate.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="str" /> value is null.</exception>
    public bool IsNameToken(string str)
    {
      return System.Xml.XmlReader.IsNameToken(str);
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance with specified URI.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read the XML data.</returns>
    /// <param name="inputUri">The URI for the file containing the XML data. The <see cref="T:System.Xml.XmlUrlResolver" /> class is used to convert the path to a canonical data representation.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="inputUri" /> value is null.</exception>
    /// <exception cref="T:System.Security.SecurityException">The <see cref="T:System.Xml.XmlReader" /> does not have sufficient permissions to access the location of the XML data.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file identified by the URI does not exist.</exception>
    /// <exception cref="T:System.UriFormatException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The URI format is not correct.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(string inputUri)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(inputUri));
    }
    
    /// <summary>Creates a new instance with the specified URI and <see cref="T:System.Xml.XmlReaderSettings" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="inputUri">The URI for the file containing the XML data. The <see cref="T:System.Xml.XmlResolver" /> object on the <see cref="T:System.Xml.XmlReaderSettings" /> object is used to convert the path to a canonical data representation. If <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> is null, a new <see cref="T:System.Xml.XmlUrlResolver" /> object is used.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="inputUri" /> value is null.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file specified by the URI cannot be found.</exception>
    /// <exception cref="T:System.UriFormatException">NoteIn the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The URI format is not correct.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(inputUri, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified URI, <see cref="T:System.Xml.XmlReaderSettings" />, and <see cref="T:System.Xml.XmlParserContext" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="inputUri">The URI for the file containing the XML data. The <see cref="T:System.Xml.XmlResolver" /> object on the <see cref="T:System.Xml.XmlReaderSettings" /> object is used to convert the path to a canonical data representation. If <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> is null, a new <see cref="T:System.Xml.XmlUrlResolver" /> object is used.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <param name="inputContext">The <see cref="T:System.Xml.XmlParserContext" /> object that provides the context information required to parse the XML fragment. The context information can include the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang and xml:space scope, base URI, and document type definition. This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The inputUri value is null.</exception>
    /// <exception cref="T:System.Security.SecurityException">The <see cref="T:System.Xml.XmlReader" /> does not have sufficient permissions to access the location of the XML data.</exception>
    /// <exception cref="T:System.ArgumentException">The <see cref="P:System.Xml.XmlReaderSettings.NameTable" />  and <see cref="P:System.Xml.XmlParserContext.NameTable" /> properties both contain values. (Only one of these NameTable properties can be set and used).</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file specified by the URI cannot be found.</exception>
    /// <exception cref="T:System.UriFormatException">The URI format is not correct.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(inputUri, settings, inputContext));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified stream.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object used to read the data contained in the stream.</returns>
    /// <param name="input">The stream containing the XML data.The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    /// <exception cref="T:System.Security.SecurityException">The <see cref="T:System.Xml.XmlReader" /> does not have sufficient permissions to access the location of the XML data.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.IStream input)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)input)._Stream));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance with the specified stream and <see cref="T:System.Xml.XmlReaderSettings" /> object.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read the XML data.</returns>
    /// <param name="input">The stream containing the XML data.The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.IStream input, System.Xml.XmlReaderSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)input)._Stream, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified stream, base URI, and <see cref="T:System.Xml.XmlReaderSettings" /> object.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="input">The stream containing the XML data. The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <param name="baseUri">The base URI for the entity or document being read. This value can be null.Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.IStream input, System.Xml.XmlReaderSettings settings, string baseUri)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)input)._Stream, settings, baseUri));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified stream, <see cref="T:System.Xml.XmlReaderSettings" />, and <see cref="T:System.Xml.XmlParserContext" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="input">The stream containing the XML data. The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <param name="inputContext">The <see cref="T:System.Xml.XmlParserContext" /> object that provides the context information required to parse the XML fragment. The context information can include the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang and xml:space scope, base URI, and document type definition. This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.IStream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)input)._Stream, settings, inputContext));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance with the specified <see cref="T:System.IO.TextReader" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read the XML data.</returns>
    /// <param name="input">The <see cref="T:System.IO.TextReader" /> from which to read the XML data. Because a <see cref="T:System.IO.TextReader" /> returns a stream of Unicode characters, the encoding specified in the XML declaration is not used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.ITextReader input)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)input)._TextReader));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified <see cref="T:System.IO.TextReader" /> and <see cref="T:System.Xml.XmlReaderSettings" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="input">The <see cref="T:System.IO.TextReader" /> from which to read the XML data. Because a <see cref="T:System.IO.TextReader" /> returns a stream of Unicode characters, the encoding specified in the XML declaration is not used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" />. This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.ITextReader input, System.Xml.XmlReaderSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)input)._TextReader, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified <see cref="T:System.IO.TextReader" />, <see cref="T:System.Xml.XmlReaderSettings" />, and base URI.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="input">The <see cref="T:System.IO.TextReader" /> from which to read the XML data. Because a <see cref="T:System.IO.TextReader" /> returns a stream of Unicode characters, the encoding specified in the XML declaration is not used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <param name="baseUri">The base URI for the entity or document being read. This value can be null.Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.ITextReader input, System.Xml.XmlReaderSettings settings, string baseUri)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)input)._TextReader, settings, baseUri));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified <see cref="T:System.IO.TextReader" />, <see cref="T:System.Xml.XmlReaderSettings" />, and <see cref="T:System.Xml.XmlParserContext" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object to read XML data.</returns>
    /// <param name="input">The <see cref="T:System.IO.TextReader" /> from which to read the XML data. Because a <see cref="T:System.IO.TextReader" /> returns a stream of Unicode characters, the encoding specified in the XML declaration is not used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be null.</param>
    /// <param name="inputContext">The <see cref="T:System.Xml.XmlParserContext" /> object that provides the context information required to parse the XML fragment. The context information can include the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang and xml:space scope, base URI, and document type definition.This value can be null.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <see cref="P:System.Xml.XmlReaderSettings.NameTable" />  and <see cref="P:System.Xml.XmlParserContext.NameTable" /> properties both contain values. (Only one of these NameTable properties can be set and used).</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.IO.ITextReader input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(input == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)input)._TextReader, settings, inputContext));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance with the specified <see cref="T:System.Xml.XmlReader" /> and <see cref="T:System.Xml.XmlReaderSettings" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlReader" /> object that is wrapped around the specified <see cref="T:System.Xml.XmlReader" /> object.</returns>
    /// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> object that you wish to use as the underlying reader.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlReaderSettings" /> object used to configure the new <see cref="T:System.Xml.XmlReader" /> instance.The conformance level of the <see cref="T:System.Xml.XmlReaderSettings" /> object must either match the conformance level of the underlying reader, or it must be set to <see cref="F:System.Xml.ConformanceLevel.Auto" />.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="reader" /> value is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">If the <see cref="T:System.Xml.XmlReaderSettings" /> object specifies a conformance level that is not consistent with conformance level of the underlying reader.-or-The underlying <see cref="T:System.Xml.XmlReader" /> is in an <see cref="F:System.Xml.ReadState.Error" /> or <see cref="F:System.Xml.ReadState.Closed" /> state.</exception>
    public Wrapperator.Interfaces.Xml.IXmlReader Create(Wrapperator.Interfaces.Xml.IXmlReader reader, System.Xml.XmlReaderSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(System.Xml.XmlReader.Create(reader == null ? default(System.Xml.XmlReader) : ((Wrapperator.Wrappers.Xml.XmlReaderWrapper)reader)._XmlReader, settings));
    }
  }
}
