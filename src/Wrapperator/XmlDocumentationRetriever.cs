using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;
using Wrapperator.Extensions;

namespace Wrapperator
{
  internal static class XmlDocumentationRetriever
  {
    private static readonly Dictionary<Assembly, XDocument> s_assemblyDocuments = new Dictionary<Assembly, XDocument>();

    private static XDocument GetDocumentation(Assembly assembly)
    {
      XDocument xdoc;
      if (s_assemblyDocuments.TryGetValue(assembly, out xdoc))
        return xdoc;

      var basePath = $"C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\{GetFrameworkVersionDirectoryName()}";
      var fileName = Path.ChangeExtension(Path.GetFileName(assembly.CodeBase), "xml");
      var path = Path.Combine(basePath, fileName);

      return s_assemblyDocuments[assembly] = XDocument.Load(path);
    }

    private static string GetFrameworkVersionDirectoryName()
    {
      var targetFrameworkAttribute = Assembly.GetExecutingAssembly().GetCustomAttribute<TargetFrameworkAttribute>();
      return targetFrameworkAttribute.FrameworkName.Split('=')[1];
    }

    private static CodeCommentStatement[] GetDocumentationComments(XElement documentationElement)
    {
      return documentationElement.Elements()
          .Where(e => e.Name.LocalName != "PermissionSet")
          .Select(elem => new CodeCommentStatement(elem.ToString(), true))
          .ToArray();
    }

    public static CodeCommentStatement[] GetDocumentation(Type type)
    {
      var xdoc = GetDocumentation(type.Assembly);

      var elem = xdoc.XPathSelectElement($"//member[@name='T:{GetTypeFullNameForXmlDoc(type)}']");

      return GetDocumentationComments(elem);
    }

    public static CodeCommentStatement[] GetDocumentation(MethodInfo method)
    {
      var type = method.DeclaringType;
      Trace.Assert(type != null);
      var xdoc = GetDocumentation(type.Assembly);

      var xpath =
          $"//member[@name='M:{GetTypeFullNameForXmlDoc(type)}.{GetMemberSignature(method)}']";
      var elem =xdoc.XPathSelectElement(xpath);

      if(elem == null)
      {
        Console.WriteLine();
      }

      return GetDocumentationComments(elem);
    }

    private static string GetTypeFullNameForXmlDoc(Type type, bool isMethodParameter = false)
    {
      if (type.IsByRef)
        return GetTypeFullNameForXmlDoc(type.GetElementType(), isMethodParameter) + "@";

      if (type.MemberType == MemberTypes.TypeInfo && type.IsGenericType && (!type.IsClass || isMethodParameter))
        return
            $"{type.Namespace}.{Regex.Replace(type.Name, "`[0-9]+", "")}{{{string.Join(",", type.GetGenericArguments().Select(t => GetTypeFullNameForXmlDoc(t)))}}}";

      if (type.IsNested)
        return $"{type.Namespace}.{type.DeclaringType.AssertNotNull().Name}.{type.Name}";

      return $"{type.Namespace}.{type.Name.Replace('&', '@')}";
    }

    private static string GetMemberSignature(MethodBase method)
    {
      var sb = new StringBuilder(method.Name);

      var parameters = method.GetParameters();

      if(parameters.Length > 0)
      {
        sb.Append('(');
        sb.Append(string.Join(",", parameters.Select(p => GetTypeFullNameForXmlDoc(p.ParameterType, true))));
        sb.Append(')');
      }

      var genericArguments = method.GetGenericArguments();
      if (genericArguments.Length > 0)
        sb.Append($"``{genericArguments.Length}");

      return sb.ToString();
    }
  }
}