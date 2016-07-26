using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Wrapperator.Generators.Members;
using Wrapperator.Helpers;
using Wrapperator.Model;

namespace Wrapperator.Generators.Types
{
  internal abstract class TypeGenerator : CodeDomGenerator
  {
    private readonly MemberGenerator _memberGenerator;
    private readonly IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> _methods;
    private readonly string _name;
    private readonly IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> _properties;
    private readonly TypeType _typeType;

    protected TypeGenerator (
        Type wrappedType,
        IReadOnlyCollection<WrapperatorMemberModel<MethodInfo>> methods,
        IReadOnlyCollection<WrapperatorMemberModel<PropertyInfo>> properties,
        WrapperatorHelper helper,
        MemberGenerator memberGenerator,
        string name,
        TypeType typeType,
        WrapMode wrapMode)
    {
      _memberGenerator = memberGenerator;
      _methods = methods.Where(memberGenerator.ShouldMethodBeWrapped).ToArray();
      _properties = properties.Where(memberGenerator.ShouldPropertyBeWrapped).ToArray();
      WrappedType = wrappedType;
      Helper = helper;
      _name = name;
      _typeType = typeType;
      WrapMode = wrapMode;
    }

    protected WrapperatorHelper Helper { get; }

    protected Type WrappedType { get; }

    protected WrapMode WrapMode { get; }

    public CodeTypeDeclaration Generate ()
    {
      var type = new CodeTypeDeclaration(_name)
                 {
                     TypeAttributes = TypeAttributes.Public | (_typeType == TypeType.Class ? TypeAttributes.Class : TypeAttributes.Interface)
                 };

      type.Comments.AddRange(XmlDocumentationRetriever.GetDocumentation(WrappedType));

      foreach (var baseType in GetBaseTypes())
        type.BaseTypes.Add(baseType);

      foreach (var member in GetMembers())
        type.Members.Add(member);

      return type;
    }

    protected abstract IEnumerable<CodeTypeReference> GetBaseTypes ();

    protected virtual IEnumerable<CodeTypeMember> GetMembers ()
    {
      foreach (var member in _methods)
        yield return _memberGenerator.GenerateMethod(member);

      foreach (var member in _properties)
        yield return _memberGenerator.GenerateProperty(member);
    }
  }
}