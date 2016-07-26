//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers
{
  
  
  /// <summary>Factory for Wrapperator wrappers.</summary>
  public sealed class Wrapper
  {
    
    private Wrapper()
    {
    }
    
    public static Wrapperator.Interfaces.IConsoleStatic Console
    {
      get
      {
        return new Wrapperator.Wrappers.ConsoleStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IEnvironmentStatic Environment
    {
      get
      {
        return new Wrapperator.Wrappers.EnvironmentStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IVersionStatic Version
    {
      get
      {
        return new Wrapperator.Wrappers.VersionStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Configuration.IConfigurationManagerStatic ConfigurationManager
    {
      get
      {
        return new Wrapperator.Wrappers.Configuration.ConfigurationManagerStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.IDirectoryStatic Directory
    {
      get
      {
        return new Wrapperator.Wrappers.IO.DirectoryStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.IFileStatic File
    {
      get
      {
        return new Wrapperator.Wrappers.IO.FileStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.IPathStatic Path
    {
      get
      {
        return new Wrapperator.Wrappers.IO.PathStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Reflection.IAssemblyStatic Assembly
    {
      get
      {
        return new Wrapperator.Wrappers.Reflection.AssemblyStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Reflection.IAssemblyNameStatic AssemblyName
    {
      get
      {
        return new Wrapperator.Wrappers.Reflection.AssemblyNameStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXNameStatic XName
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNameStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXNamespaceStatic XNamespace
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNamespaceStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Serialization.IXmlSerializerStatic XmlSerializer
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Serialization.XmlSerializerStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlWriterStatic XmlWriter
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.XmlWriterStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlReaderStatic XmlReader
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.XmlReaderStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IAppDomainStatic AppDomain
    {
      get
      {
        return new Wrapperator.Wrappers.AppDomainStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IDateTimeStatic DateTime
    {
      get
      {
        return new Wrapperator.Wrappers.DateTimeStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.IStreamStatic Stream
    {
      get
      {
        return new Wrapperator.Wrappers.IO.StreamStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.ITextReaderStatic TextReader
    {
      get
      {
        return new Wrapperator.Wrappers.IO.TextReaderStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IO.ITextWriterStatic TextWriter
    {
      get
      {
        return new Wrapperator.Wrappers.IO.TextWriterStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.ITypeStatic Type
    {
      get
      {
        return new Wrapperator.Wrappers.TypeStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Threading.IThreadStatic Thread
    {
      get
      {
        return new Wrapperator.Wrappers.Threading.ThreadStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXNodeStatic XNode
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XNodeStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXDocumentStatic XDocument
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XDocumentStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXElementStatic XElement
    {
      get
      {
        return new Wrapperator.Wrappers.Xml.Linq.XElementStaticWrapper();
      }
    }
    
    public static Wrapperator.Interfaces.IVersion Wrap(System.Version version)
    {
      return new Wrapperator.Wrappers.VersionWrapper(version);
    }
    
    public static Wrapperator.Interfaces.Configuration.IConfiguration Wrap(System.Configuration.Configuration configuration)
    {
      return new Wrapperator.Wrappers.Configuration.ConfigurationWrapper(configuration);
    }
    
    public static Wrapperator.Interfaces.IO.IBinaryReader Wrap(System.IO.BinaryReader binaryReader)
    {
      return new Wrapperator.Wrappers.IO.BinaryReaderWrapper(binaryReader);
    }
    
    public static Wrapperator.Interfaces.IO.IBinaryWriter Wrap(System.IO.BinaryWriter binaryWriter)
    {
      return new Wrapperator.Wrappers.IO.BinaryWriterWrapper(binaryWriter);
    }
    
    public static Wrapperator.Interfaces.Reflection.IAssembly Wrap(System.Reflection.Assembly assembly)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyWrapper(assembly);
    }
    
    public static Wrapperator.Interfaces.Reflection.IAssemblyName Wrap(System.Reflection.AssemblyName assemblyName)
    {
      return new Wrapperator.Wrappers.Reflection.AssemblyNameWrapper(assemblyName);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXDeclaration Wrap(System.Xml.Linq.XDeclaration xDeclaration)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDeclarationWrapper(xDeclaration);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXName Wrap(System.Xml.Linq.XName xName)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNameWrapper(xName);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXNamespace Wrap(System.Xml.Linq.XNamespace xNamespace)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNamespaceWrapper(xNamespace);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXObject Wrap(System.Xml.Linq.XObject xObject)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XObjectWrapper(xObject);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXStreamingElement Wrap(System.Xml.Linq.XStreamingElement xStreamingElement)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XStreamingElementWrapper(xStreamingElement);
    }
    
    public static Wrapperator.Interfaces.Xml.Serialization.IXmlSerializer Wrap(System.Xml.Serialization.XmlSerializer xmlSerializer)
    {
      return new Wrapperator.Wrappers.Xml.Serialization.XmlSerializerWrapper(xmlSerializer);
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlWriter Wrap(System.Xml.XmlWriter xmlWriter)
    {
      return new Wrapperator.Wrappers.Xml.XmlWriterWrapper(xmlWriter);
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlReader Wrap(System.Xml.XmlReader xmlReader)
    {
      return new Wrapperator.Wrappers.Xml.XmlReaderWrapper(xmlReader);
    }
    
    public static Wrapperator.Interfaces.IAppDomain Wrap(System.AppDomain appDomain)
    {
      return new Wrapperator.Wrappers.AppDomainWrapper(appDomain);
    }
    
    public static Wrapperator.Interfaces.IDateTime Wrap(System.DateTime dateTime)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(dateTime);
    }
    
    public static Wrapperator.Interfaces.Collections.Specialized.INameValueCollection Wrap(System.Collections.Specialized.NameValueCollection nameValueCollection)
    {
      return new Wrapperator.Wrappers.Collections.Specialized.NameValueCollectionWrapper(nameValueCollection);
    }
    
    public static Wrapperator.Interfaces.IO.IStream Wrap(System.IO.Stream stream)
    {
      return new Wrapperator.Wrappers.IO.StreamWrapper(stream);
    }
    
    public static Wrapperator.Interfaces.IO.ITextReader Wrap(System.IO.TextReader textReader)
    {
      return new Wrapperator.Wrappers.IO.TextReaderWrapper(textReader);
    }
    
    public static Wrapperator.Interfaces.IO.ITextWriter Wrap(System.IO.TextWriter textWriter)
    {
      return new Wrapperator.Wrappers.IO.TextWriterWrapper(textWriter);
    }
    
    public static Wrapperator.Interfaces.IType Wrap(System.Type type)
    {
      return new Wrapperator.Wrappers.TypeWrapper(type);
    }
    
    public static Wrapperator.Interfaces.Threading.IThread Wrap(System.Threading.Thread thread)
    {
      return new Wrapperator.Wrappers.Threading.ThreadWrapper(thread);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXAttribute Wrap(System.Xml.Linq.XAttribute xAttribute)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XAttributeWrapper(xAttribute);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXNode Wrap(System.Xml.Linq.XNode xNode)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XNodeWrapper(xNode);
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlDocument Wrap(System.Xml.XmlDocument xmlDocument)
    {
      return new Wrapperator.Wrappers.Xml.XmlDocumentWrapper(xmlDocument);
    }
    
    public static Wrapperator.Interfaces.Xml.IXmlDocumentFragment Wrap(System.Xml.XmlDocumentFragment xmlDocumentFragment)
    {
      return new Wrapperator.Wrappers.Xml.XmlDocumentFragmentWrapper(xmlDocumentFragment);
    }
    
    public static Wrapperator.Interfaces.IO.IDirectoryInfo Wrap(System.IO.DirectoryInfo directoryInfo)
    {
      return new Wrapperator.Wrappers.IO.DirectoryInfoWrapper(directoryInfo);
    }
    
    public static Wrapperator.Interfaces.IO.IFileInfo Wrap(System.IO.FileInfo fileInfo)
    {
      return new Wrapperator.Wrappers.IO.FileInfoWrapper(fileInfo);
    }
    
    public static Wrapperator.Interfaces.IO.IFileStream Wrap(System.IO.FileStream fileStream)
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(fileStream);
    }
    
    public static Wrapperator.Interfaces.IO.IFileSystemWatcher Wrap(System.IO.FileSystemWatcher fileSystemWatcher)
    {
      return new Wrapperator.Wrappers.IO.FileSystemWatcherWrapper(fileSystemWatcher);
    }
    
    public static Wrapperator.Interfaces.IO.IMemoryStream Wrap(System.IO.MemoryStream memoryStream)
    {
      return new Wrapperator.Wrappers.IO.MemoryStreamWrapper(memoryStream);
    }
    
    public static Wrapperator.Interfaces.IO.IStreamReader Wrap(System.IO.StreamReader streamReader)
    {
      return new Wrapperator.Wrappers.IO.StreamReaderWrapper(streamReader);
    }
    
    public static Wrapperator.Interfaces.IO.IStreamWriter Wrap(System.IO.StreamWriter streamWriter)
    {
      return new Wrapperator.Wrappers.IO.StreamWriterWrapper(streamWriter);
    }
    
    public static Wrapperator.Interfaces.IO.Compression.IDeflateStream Wrap(System.IO.Compression.DeflateStream deflateStream)
    {
      return new Wrapperator.Wrappers.IO.Compression.DeflateStreamWrapper(deflateStream);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXContainer Wrap(System.Xml.Linq.XContainer xContainer)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XContainerWrapper(xContainer);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXComment Wrap(System.Xml.Linq.XComment xComment)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XCommentWrapper(xComment);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXDocumentType Wrap(System.Xml.Linq.XDocumentType xDocumentType)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentTypeWrapper(xDocumentType);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXProcessingInstruction Wrap(System.Xml.Linq.XProcessingInstruction xProcessingInstruction)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XProcessingInstructionWrapper(xProcessingInstruction);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXText Wrap(System.Xml.Linq.XText xText)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XTextWrapper(xText);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXCData Wrap(System.Xml.Linq.XCData xCData)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XCDataWrapper(xCData);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXDocument Wrap(System.Xml.Linq.XDocument xDocument)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XDocumentWrapper(xDocument);
    }
    
    public static Wrapperator.Interfaces.Xml.Linq.IXElement Wrap(System.Xml.Linq.XElement xElement)
    {
      return new Wrapperator.Wrappers.Xml.Linq.XElementWrapper(xElement);
    }
  }
}
