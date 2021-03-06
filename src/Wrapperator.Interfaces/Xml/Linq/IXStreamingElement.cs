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
  
  
  /// <summary>Represents elements in an XML tree that supports deferred streaming output.</summary>
  public interface IXStreamingElement
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Xml.Linq.XStreamingElement _XStreamingElement
    {
      get;
    }
    
    Wrapperator.Interfaces.Xml.Linq.IXName Name
    {
      get;
      set;
    }
    
    /// <summary>Adds the specified content as children to this <see cref="T:System.Xml.Linq.XStreamingElement" />.</summary>
    /// <param name="content">Content to be added to the streaming element.</param>
    void Add(object content);
    
    /// <summary>Adds the specified content as children to this <see cref="T:System.Xml.Linq.XStreamingElement" />.</summary>
    /// <param name="content">Content to be added to the streaming element.</param>
    void Add(object[] content);
    
    /// <summary>Serialize this streaming element to a file.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    void Save(string fileName);
    
    /// <summary>Serialize this streaming element to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> object that specifies formatting behavior.</param>
    void Save(string fileName, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XStreamingElement" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    void Save(Wrapperator.Interfaces.IO.IStream stream);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XStreamingElement" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> object that specifies formatting behavior.</param>
    void Save(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this streaming element to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XStreamingElement" /> will be written to.</param>
    void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter);
    
    /// <summary>Serialize this streaming element to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this streaming element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
    void Save(Wrapperator.Interfaces.Xml.IXmlWriter writer);
    
    /// <summary>Writes this streaming element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
    /// <filterpriority>2</filterpriority>
    void WriteTo(Wrapperator.Interfaces.Xml.IXmlWriter writer);
  }
}
