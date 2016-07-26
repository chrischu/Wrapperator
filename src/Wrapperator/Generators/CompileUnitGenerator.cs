using System;
using System.CodeDom;
using Wrapperator.Generators.Types;

namespace Wrapperator.Generators
{
  internal class CompileUnitGenerator : CodeDomGenerator
  {
    private readonly string _namespace;
    private readonly TypeGenerator _typeGenerator;

    public CompileUnitGenerator (string @namespace, TypeGenerator typeGenerator)
    {
      _namespace = @namespace;
      _typeGenerator = typeGenerator;
    }

    public CodeCompileUnit Generate ()
    {
      var compileUnit = new CodeCompileUnit();

      var @namespace = new CodeNamespace(_namespace);
      var wrapperatorType = _typeGenerator.Generate();
      @namespace.Types.Add(wrapperatorType);

      compileUnit.Namespaces.Add(@namespace);

      return compileUnit;
    }
  }
}