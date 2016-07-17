using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Wrapperator.Extensions;

namespace Wrapperator
{
  internal class WrapperatorHelper
  {
    private readonly WrapperatorOptions _options;
    private readonly HashSet<Type> _typesToWrap;
    private readonly HashSet<string> _excludedMethods;

    public WrapperatorHelper(WrapperatorOptions options)
    {
      _options = options;
      _typesToWrap = new HashSet<Type>(options.TypesToWrap);
      _excludedMethods = new HashSet<string>(options.ExcludedMethods);
      Models = _typesToWrap.Select(t => new WrapperatorModel(t, GetMethodsToWrap(t), GetPropertiesToWrap(t))).ToList();
    }

    public IReadOnlyCollection<WrapperatorModel> Models { get; }

    public void WriteToInterfaceFile(Type toWrap, Action<StreamWriter> write)
    {
      WriteToFile(o => o.Interface, toWrap, write);
    }

    public void WriteToWrapperFile(Type toWrap, Action<StreamWriter> write)
    {
      WriteToFile(o => o.Wrapper, toWrap, write);
    }

    private void WriteToFile(Func<WrapperatorOptions, WrapperatorOptionsBase> optionsSelector, Type toWrap, Action<StreamWriter> write)
    {
      var options = optionsSelector(_options);

      var namespaceDirectory = GetWrapperatorNamespace(options, toWrap).Replace(options.ProjectName, "").Trim('.').Replace('.', '\\');
      var projectDirectory = Path.Combine(_options.SolutionDirectory, options.ProjectName, namespaceDirectory);
      Directory.CreateDirectory(projectDirectory);

      var path = Path.Combine(projectDirectory, $"{GetWrapperatorName(options, toWrap)}.cs");

      using (var sw = new StreamWriter(path, false))
        write(sw);
    }

    private string GetWrapperatorName(WrapperatorOptionsBase options, Type toWrap)
    {
      return $"{options.ClassPrefix}{toWrap.Name}{options.ClassSuffix}";
    }

    private string GetWrapperatorNamespace(WrapperatorOptionsBase options, Type toWrap)
    {
      return toWrap.Namespace.AssertNotNull().Replace("System", options.ProjectName);
    }

    public string GetInterfaceName(Type typeToWrap) => $"{_options.Interface.ClassPrefix}{typeToWrap.Name}{_options.Interface.ClassSuffix}";
    public string GetWrapperName(Type typeToWrap) => $"{_options.Wrapper.ClassPrefix}{typeToWrap.Name}{_options.Wrapper.ClassSuffix}";

    public string GetInterfaceNamespace(Type typeToWrap) => typeToWrap.Namespace.AssertNotNull().Replace("System", _options.Interface.ProjectName);
    public string GetWrapperNamespace(Type typeToWrap) => typeToWrap.Namespace.AssertNotNull().Replace("System", _options.Wrapper.ProjectName);

    public bool ShouldTypeBeWrapped(Type type) => _typesToWrap.Contains(type);

    private IReadOnlyCollection<MethodInfo> GetMethodsToWrap(Type typeToWrap)
    {
      return typeToWrap
          .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
          .Where(m => !m.IsSpecialName)
          .Where(m => m.GetCustomAttribute<ObsoleteAttribute>() == null)
          .Where(m => !_excludedMethods.Contains(m.Name))
          .ToList();
    }

    private IReadOnlyCollection<PropertyInfo> GetPropertiesToWrap(Type typeToWrap)
    {
      return typeToWrap.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
          .Where(p => !p.IsSpecialName)
          .Where(p => p.GetCustomAttribute<ObsoleteAttribute>() == null)
          .ToList();
    }
  }
}