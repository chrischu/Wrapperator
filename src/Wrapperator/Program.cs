using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Wrapperator
{
  internal static class Program
  {
    private static void Main ()
    {
      var executableDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
      Trace.Assert(executableDirectory != null);
      var solutionDirectory = Path.GetFullPath(Path.Combine(executableDirectory, "..\\..\\.."));

      Wrapperator.Wrap(
          new WrapperatorOptions(
              solutionDirectory,
              new WrapperatorInterfaceOptions("Wrapperator.Interfaces"),
              new WrapperatorWrapperOptions("Wrapperator.Wrappers"),
              new[]
              {
                  typeof(AppDomain),
                  typeof(Console),
                  typeof(DateTime),
                  typeof(Environment),
                  typeof(Version),
                  typeof(NameValueCollection),
                  typeof(Configuration),
                  typeof(ConfigurationManager),
                  typeof(BinaryReader),
                  typeof(BinaryWriter),
                  typeof(Directory),
                  typeof(DirectoryInfo),
                  typeof(File),
                  typeof(FileInfo),
                  typeof(FileStream),
                  typeof(FileSystemWatcher),
                  typeof(MemoryStream),
                  typeof(Path),
                  typeof(Stream),
                  typeof(StreamReader),
                  typeof(StreamWriter),
                  typeof(TextReader),
                  typeof(TextWriter),
                  typeof(DeflateStream),
                  typeof(Assembly),
                  typeof(AssemblyName),
                  typeof(Type),
                  typeof(Thread),
                  typeof(XAttribute),
                  typeof(XCData),
                  typeof(XContainer),
                  typeof(XComment),
                  typeof(XDeclaration),
                  typeof(XDocument),
                  typeof(XDocumentType),
                  typeof(XElement),
                  typeof(XName),
                  typeof(XNamespace),
                  typeof(XNode),
                  typeof(XObject),
                  typeof(XProcessingInstruction),
                  typeof(XStreamingElement),
                  typeof(XText),
                  typeof(XmlDocument),
                  typeof(XmlDocumentFragment),
                  typeof(XmlSerializer),
                  typeof(XmlWriter),
                  typeof(XmlReader)
              })
          {
            WrapParameterTypes = true
          }
          );
    }
  }
}