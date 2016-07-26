//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Xml.Serialization
{
  
  
  /// <summary>Serializes and deserializes objects into and from XML documents. The <see cref="T:System.Xml.Serialization.XmlSerializer" /> enables you to control how objects are encoded into XML.</summary>
  public interface IXmlSerializerStatic
  {
    
    /// <summary>Returns an array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects created from an array of <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> objects.</summary>
    /// <returns>An array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects.</returns>
    /// <param name="mappings">An array of <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> that maps one type to another. </param>
    System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings);
    
    /// <summary>Returns an instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class from the specified mappings.</summary>
    /// <returns>An instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</returns>
    /// <param name="mappings">An array of <see cref="T:System.Xml.Serialization.XmlMapping" /> objects.</param>
    /// <param name="type">The <see cref="T:System.Type" /> of the deserialized object.</param>
    System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings, Wrapperator.Interfaces.IType type);
    
    /// <summary>Returns an assembly that contains custom-made serializers used to serialize or deserialize the specified type or types, using the specified mappings.</summary>
    /// <returns>An <see cref="T:System.Reflection.Assembly" /> object that contains serializers for the supplied types and mappings.</returns>
    /// <param name="types">A collection of types.</param>
    /// <param name="mappings">A collection of <see cref="T:System.Xml.Serialization.XmlMapping" /> objects used to convert one type to another.</param>
    Wrapperator.Interfaces.Reflection.IAssembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings);
    
    /// <summary>Returns an assembly that contains custom-made serializers used to serialize or deserialize the specified type or types, using the specified mappings and compiler settings and options. </summary>
    /// <returns>An <see cref="T:System.Reflection.Assembly" /> that contains special versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
    /// <param name="types">An array of type <see cref="T:System.Type" /> that contains objects used to serialize and deserialize data.</param>
    /// <param name="mappings">An array of type <see cref="T:System.Xml.Serialization.XmlMapping" /> that maps the XML data to the type data.</param>
    /// <param name="parameters">An instance of the <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> class that represents the parameters used to invoke a compiler.</param>
    Wrapperator.Interfaces.Reflection.IAssembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings, System.CodeDom.Compiler.CompilerParameters parameters);
    
    /// <summary>Returns an array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects created from an array of types.</summary>
    /// <returns>An array of <see cref="T:System.Xml.Serialization.XmlSerializer" /> objects.</returns>
    /// <param name="types">An array of <see cref="T:System.Type" /> objects. </param>
    System.Xml.Serialization.XmlSerializer[] FromTypes(System.Type[] types);
    
    /// <summary>Returns the name of the assembly that contains one or more versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> especially created to serialize or deserialize the specified type.</summary>
    /// <returns>The name of the assembly that contains an <see cref="T:System.Xml.Serialization.XmlSerializer" /> for the type.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> you are deserializing.</param>
    string GetXmlSerializerAssemblyName(Wrapperator.Interfaces.IType type);
    
    /// <summary>Returns the name of the assembly that contains the serializer for the specified type in the specified namespace.</summary>
    /// <returns>The name of the assembly that contains specially built serializers.</returns>
    /// <param name="type">The <see cref="T:System.Type" /> you are interested in.</param>
    /// <param name="defaultNamespace">The namespace of the type.</param>
    string GetXmlSerializerAssemblyName(Wrapperator.Interfaces.IType type, string defaultNamespace);
  }
}
