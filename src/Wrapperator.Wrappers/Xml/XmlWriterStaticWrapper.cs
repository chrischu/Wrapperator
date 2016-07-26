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
  
  
  /// <summary>Represents a writer that provides a fast, non-cached, forward-only way to generate streams or files that contain XML data.</summary>
  public class XmlWriterStaticWrapper : Wrapperator.Interfaces.Xml.IXmlWriterStatic
  {
    
    internal XmlWriterStaticWrapper()
    {
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified filename.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="outputFileName">The file to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> creates a file at the specified path and writes to it in XML 1.0 text syntax. The <paramref name="outputFileName" /> must be a file system path.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="url" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(string outputFileName)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(outputFileName));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the filename and <see cref="T:System.Xml.XmlWriterSettings" /> object.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="outputFileName">The file to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> creates a file at the specified path and writes to it in XML 1.0 text syntax. The <paramref name="outputFileName" /> must be a file system path.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is null, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="url" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(string outputFileName, System.Xml.XmlWriterSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(outputFileName, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified stream.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The stream to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified stream.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.IO.IStream output)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)output).Stream));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the stream and <see cref="T:System.Xml.XmlWriterSettings" /> object.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The stream to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified stream.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is null, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.IO.IStream output, System.Xml.XmlWriterSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)output).Stream, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified <see cref="T:System.IO.TextWriter" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.IO.TextWriter" /> to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified <see cref="T:System.IO.TextWriter" />.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="text" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.IO.ITextWriter output)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)output).TextWriter));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the <see cref="T:System.IO.TextWriter" /> and <see cref="T:System.Xml.XmlWriterSettings" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.IO.TextWriter" /> to which you want to write. The <see cref="T:System.Xml.XmlWriter" /> writes XML 1.0 text syntax and appends it to the specified <see cref="T:System.IO.TextWriter" />.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is null, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="text" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.IO.ITextWriter output, System.Xml.XmlWriterSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.IO.TextWriter) : ((Wrapperator.Wrappers.IO.TextWriterWrapper)output).TextWriter, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified <see cref="T:System.Text.StringBuilder" />.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.Text.StringBuilder" /> to which to write to. Content written by the <see cref="T:System.Xml.XmlWriter" /> is appended to the <see cref="T:System.Text.StringBuilder" />.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="builder" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(System.Text.StringBuilder output)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the <see cref="T:System.Text.StringBuilder" /> and <see cref="T:System.Xml.XmlWriterSettings" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.Text.StringBuilder" /> to which to write to. Content written by the <see cref="T:System.Xml.XmlWriter" /> is appended to the <see cref="T:System.Text.StringBuilder" />.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is null, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="builder" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(System.Text.StringBuilder output, System.Xml.XmlWriterSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output, settings));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified <see cref="T:System.Xml.XmlWriter" /> object.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object that is wrapped around the specified <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.Xml.XmlWriter" /> object that you want to use as the underlying writer.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="writer" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.Xml.IXmlWriter output)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)output).XmlWriter));
    }
    
    /// <summary>Creates a new <see cref="T:System.Xml.XmlWriter" /> instance using the specified <see cref="T:System.Xml.XmlWriter" /> and <see cref="T:System.Xml.XmlWriterSettings" /> objects.</summary>
    /// <returns>An <see cref="T:System.Xml.XmlWriter" /> object that is wrapped around the specified <see cref="T:System.Xml.XmlWriter" /> object.</returns>
    /// <param name="output">The <see cref="T:System.Xml.XmlWriter" /> object that you want to use as the underlying writer.</param>
    /// <param name="settings">The <see cref="T:System.Xml.XmlWriterSettings" /> object used to configure the new <see cref="T:System.Xml.XmlWriter" /> instance. If this is null, a <see cref="T:System.Xml.XmlWriterSettings" /> with default settings is used.If the <see cref="T:System.Xml.XmlWriter" /> is being used with the <see cref="M:System.Xml.Xsl.XslCompiledTransform.Transform(System.String,System.Xml.XmlWriter)" /> method, you should use the <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> property to obtain an <see cref="T:System.Xml.XmlWriterSettings" /> object with the correct settings. This ensures that the created <see cref="T:System.Xml.XmlWriter" /> object has the correct output settings.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="writer" /> value is null.</exception>
    public Wrapperator.Interfaces.Xml.IXmlWriter Create(Wrapperator.Interfaces.Xml.IXmlWriter output, System.Xml.XmlWriterSettings settings)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(System.Xml.XmlWriter.Create(output == null ? default(System.Xml.XmlWriter) : ((Wrapperator.Wrappers.Xml.XmlWriterWrapper)output).XmlWriter, settings));
    }
  }
}
