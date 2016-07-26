using System;
using System.CodeDom;
using System.Reflection;
using Wrapperator.Helpers;

namespace Wrapperator.Generators
{
  internal class WrapperatorFactoryGenerator
  {
    private readonly WrapperatorHelper _helper;
    private readonly CodeTypeDeclaration _wrapperator;

    public WrapperatorFactoryGenerator (WrapperatorHelper helper)
    {
      _helper = helper;

      _wrapperator = new CodeTypeDeclaration
                     {
                         Name = "Wrapper",
                         // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                         TypeAttributes = TypeAttributes.Public | TypeAttributes.Class
                     };

      // Unfortunately CodeDOM cannot create static classes therefore we make a sealed class that has a private ctor and only static methods.
      _wrapperator.TypeAttributes |= TypeAttributes.Sealed;
      _wrapperator.Members.Add(new CodeConstructor { Attributes = MemberAttributes.Private });

      _wrapperator.Comments.Add(new CodeCommentStatement("<summary>Factory for Wrapperator wrappers.</summary>", true));
    }

    public CodeCompileUnit Generate ()
    {
      var compileUnit = new CodeCompileUnit();

      var ns = new CodeNamespace("Wrapperator.Wrappers");
      ns.Types.Add(_wrapperator);

      compileUnit.Namespaces.Add(ns);

      return compileUnit;
    }

    public void AddInstanceWrapperFactoryMethod (Type wrappedType)
    {
      var factoryMethod = new CodeMemberMethod
                          {
                              Name = "Wrap",
                              // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                              Attributes = MemberAttributes.Public | MemberAttributes.Static,
                              ReturnType = new CodeTypeReference(_helper.GetFullInterfaceName(wrappedType, WrapMode.Instance))
                          };

      var parameterName = _helper.GetParameterName(wrappedType);
      factoryMethod.Parameters.Add(new CodeParameterDeclarationExpression(wrappedType, parameterName));

      factoryMethod.Statements.Add(
          new CodeMethodReturnStatement(
              new CodeObjectCreateExpression(
                  new CodeTypeReference(_helper.GetFullWrapperName(wrappedType, WrapMode.Instance)),
                  new CodeArgumentReferenceExpression(parameterName))));

      _wrapperator.Members.Add(factoryMethod);
    }

    public void AddStaticWrapperFactoryProperty (Type wrappedType)
    {
      var factoryProperty = new CodeMemberProperty
                            {
                                Name = wrappedType.Name,
                                // ReSharper disable once BitwiseOperatorOnEnumWithoutFlags
                                Attributes = MemberAttributes.Public | MemberAttributes.Static,
                                Type = new CodeTypeReference(_helper.GetFullInterfaceName(wrappedType, WrapMode.Static))
                            };

      factoryProperty.GetStatements.Add(
          new CodeMethodReturnStatement(new CodeObjectCreateExpression(_helper.GetFullWrapperName(wrappedType, WrapMode.Static))));

      _wrapperator.Members.Add(factoryProperty);
    }
  }
}