using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using Wrapperator.Extensions;
using Wrapperator.Generators;
using Wrapperator.Generators.Types;
using Wrapperator.Helpers;
using Wrapperator.Model;
using Wrapperator.Options;

namespace Wrapperator
{
  internal static class Wrapperator
  {
    public static void Wrap (WrapperatorOptions options)
    {
      ValidateOptions(options);
      var helper = new WrapperatorHelper(options);

      var wrapperatorFactoryGenerator = new WrapperatorFactoryGenerator(helper);

      foreach (var model in helper.Models)
      {
        var wrapMode = helper.GetWrapMode(model);
        GenerateInterfaces(helper, model, wrapMode);
        GenerateWrappers(helper, model, wrapMode, wrapperatorFactoryGenerator);
      }

      helper.WriteWrapFactory(sw => ConvertCompileUnitToCode(wrapperatorFactoryGenerator.Generate(), sw));
    }

    private static void GenerateInterfaces (WrapperatorHelper helper, WrapperatorModel model, WrapMode wrapMode)
    {
      if (wrapMode.HasFlag(WrapMode.Instance))
      {
        var generator = new CompileUnitGenerator(
            helper.GetInterfaceNamespace(model.Type),
            new InstanceInterfaceGenerator(model.Type, model.InterfaceMethods, model.InterfaceProperties, helper));

        var @interface = generator.Generate();
        helper.WriteToInterfaceFile(WrapMode.Instance, model.Type, sw => ConvertCompileUnitToCode(@interface, sw));
      }

      if (wrapMode.HasFlag(WrapMode.Static))
      {
        var generator = new CompileUnitGenerator(
            helper.GetInterfaceNamespace(model.Type),
            new StaticInterfaceGenerator(model.Type, model.InterfaceMethods, model.InterfaceProperties, helper));

        var @interface = generator.Generate();
        helper.WriteToInterfaceFile(WrapMode.Static, model.Type, sw => ConvertCompileUnitToCode(@interface, sw));
      }
    }

    private static void GenerateWrappers (
        WrapperatorHelper helper,
        WrapperatorModel model,
        WrapMode wrapMode,
        WrapperatorFactoryGenerator wrapperatorFactory)
    {
      if (wrapMode.HasFlag(WrapMode.Instance))
      {
        var generator = new CompileUnitGenerator(
            helper.GetWrapperNamespace(model.Type),
            new InstanceWrapperGenerator(model.Type, model.WrapperMethods, model.WrapperProperties, helper));

        var wrapper = generator.Generate();
        helper.WriteToWrapperFile(WrapMode.Instance, model.Type, sw => ConvertCompileUnitToCode(wrapper, sw));
        wrapperatorFactory.AddInstanceWrapperFactoryMethod(model.Type);
      }

      if (wrapMode.HasFlag(WrapMode.Static))
      {
        var generator = new CompileUnitGenerator(
            helper.GetWrapperNamespace(model.Type),
            new StaticWrapperGenerator(model.Type, model.WrapperMethods, model.WrapperProperties, helper));

        var wrapper = generator.Generate();
        helper.WriteToWrapperFile(WrapMode.Static, model.Type, sw => ConvertCompileUnitToCode(wrapper, sw));
        wrapperatorFactory.AddStaticWrapperFactoryProperty(model.Type);
      }
    }

    private static void ConvertCompileUnitToCode (CodeCompileUnit compileUnit, StreamWriter @out)
    {
      using (var provider = CodeDomProvider.CreateProvider("CSharp"))
      {
        var codeGenOptions = new CodeGeneratorOptions { BracingStyle = "C", IndentString = "  ", BlankLinesBetweenMembers = true };
        provider.GenerateCodeFromCompileUnit(compileUnit, @out, codeGenOptions);
      }
    }

    private static void ValidateOptions (WrapperatorOptions options)
    {
      foreach (var type in options.TypesToWrap)
      {
        if (!type.Namespace.AssertNotNull().StartsWith("System", StringComparison.InvariantCulture))
          throw new InvalidOperationException($"Wrapping '{type.FullName}' is not supported since it is not a type from the System library.");
      }

      if (!Directory.Exists(options.SolutionDirectory))
        throw new InvalidOperationException($"Solution directory '{options.SolutionDirectory}' does not exist.");
    }
  }
}