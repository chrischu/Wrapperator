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
  public class XElementStaticWrapper : Wrapperator.Interfaces.Xml.Linq.IXElementStatic
  {
    
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> EmptySequence
    {
      get
      {
        return System.Xml.Linq.XElement.EmptySequence;
      }
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string referencing the file to load into a new <see cref="T:System.Xml.Linq.XElement" />.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(string uri)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(uri));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
    /// <param name="uri">A URI string referencing the file to load into an <see cref="T:System.Xml.Linq.XElement" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(string uri, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(uri, options));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that is contained in the stream.</returns>
    /// <param name="stream">The stream that contains the XML data.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.IO.IStream stream)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that the stream contains.</returns>
    /// <param name="stream">The stream containing the XML data.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> object that specifies whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream, options));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.IO.ITextReader textReader)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(textReader == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)textReader).TextReader));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />, optionally preserving white space and retaining line information. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.IO.ITextReader textReader, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(textReader == null ? default(System.IO.TextReader) : ((Wrapperator.Wrappers.IO.TextReaderWrapper)textReader).TextReader, options));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />. </summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.Xml.IXmlReader reader)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(reader == null ? default(System.Xml.XmlReader) : ((Wrapperator.Wrappers.Xml.XmlReaderWrapper)reader).XmlReader));
    }
    
    /// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />, optionally preserving white space, setting the base URI, and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
    /// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Load(Wrapperator.Interfaces.Xml.IXmlReader reader, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Load(reader == null ? default(System.Xml.XmlReader) : ((Wrapperator.Wrappers.Xml.XmlReaderWrapper)reader).XmlReader, options));
    }
    
    /// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
    /// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Parse(string text)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Parse(text));
    }
    
    /// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML, optionally preserving white space and retaining line information.</summary>
    /// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
    /// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
    public Wrapperator.Interfaces.Xml.Linq.IXElement Parse(string text, System.Xml.Linq.LoadOptions options)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(System.Xml.Linq.XElement.Parse(text, options));
    }
  }
}
