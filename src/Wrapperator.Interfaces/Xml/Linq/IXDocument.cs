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
  
  
  /// <summary>Represents an XML document. For the components and usage of an <see cref="T:System.Xml.Linq.XDocument" /> object, see XDocument Class Overview.</summary>
  public interface IXDocument : Wrapperator.Interfaces.Xml.Linq.IXContainer
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Xml.Linq.XDocument _XDocument
    {
      get;
    }
    
    Wrapperator.Interfaces.Xml.Linq.IXDeclaration Declaration
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.Xml.Linq.IXDocumentType DocumentType
    {
      get;
    }
    
    Wrapperator.Interfaces.Xml.Linq.IXElement Root
    {
      get;
    }
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, overwriting an existing file, if it exists.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    void Save(string fileName);
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a file, optionally disabling formatting.</summary>
    /// <param name="fileName">A string that contains the name of the file.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(string fileName, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    void Save(Wrapperator.Interfaces.IO.IStream stream);
    
    /// <summary>Outputs this <see cref="T:System.Xml.Linq.XDocument" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
    /// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XDocument" /> to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(Wrapperator.Interfaces.IO.IStream stream, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />.</summary>
    /// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter);
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
    /// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
    /// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
    void Save(Wrapperator.Interfaces.IO.ITextWriter textWriter, System.Xml.Linq.SaveOptions options);
    
    /// <summary>Serialize this <see cref="T:System.Xml.Linq.XDocument" /> to an <see cref="T:System.Xml.XmlWriter" />.</summary>
    /// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XDocument" /> will be written to.</param>
    void Save(Wrapperator.Interfaces.Xml.IXmlWriter writer);
  }
}
