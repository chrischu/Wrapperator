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
    private readonly Excluded _excluded;

    public WrapperatorHelper (WrapperatorOptions options)
    {
      _options = options;
      _typesToWrap = new HashSet<Type>(options.TypesToWrap);
      _excluded = new Excluded(options.ExcludedMethods, options.ExcludedProperties);
      Models = _typesToWrap.Select(t => new WrapperatorModel(t, GetMethodsToWrap(t), GetPropertiesToWrap(t))).ToList();
    }

    public IReadOnlyCollection<WrapperatorModel> Models { get; }

    public void WriteToInterfaceFile (Type toWrap, Action<StreamWriter> write)
    {
      WriteToFile(o => o.Interface, toWrap, write);
    }

    public void WriteToWrapperFile (Type toWrap, Action<StreamWriter> write)
    {
      WriteToFile(o => o.Wrapper, toWrap, write);
    }

    private void WriteToFile (Func<WrapperatorOptions, WrapperatorOptionsBase> optionsSelector, Type toWrap, Action<StreamWriter> write)
    {
      var options = optionsSelector(_options);

      var namespaceDirectory = GetWrapperatorNamespace(options, toWrap).Replace(options.ProjectName, "").Trim('.').Replace('.', '\\');
      var projectDirectory = Path.Combine(_options.SolutionDirectory, options.ProjectName, namespaceDirectory);
      Directory.CreateDirectory(projectDirectory);

      var path = Path.Combine(projectDirectory, $"{GetWrapperatorName(options, toWrap)}.cs");

      using (var sw = new StreamWriter(path, false))
        write(sw);
    }

    private string GetWrapperatorName (WrapperatorOptionsBase options, Type toWrap)
    {
      return $"{options.ClassPrefix}{toWrap.Name}{options.ClassSuffix}";
    }

    private string GetWrapperatorNamespace (WrapperatorOptionsBase options, Type toWrap)
    {
      return toWrap.Namespace.AssertNotNull().Replace("System", options.ProjectName);
    }

    public string GetInterfaceName (Type typeToWrap) => $"{_options.Interface.ClassPrefix}{typeToWrap.Name}{_options.Interface.ClassSuffix}";
    public string GetWrapperName (Type typeToWrap) => $"{_options.Wrapper.ClassPrefix}{typeToWrap.Name}{_options.Wrapper.ClassSuffix}";

    public string GetInterfaceNamespace (Type typeToWrap) => typeToWrap.Namespace.AssertNotNull().Replace("System", _options.Interface.ProjectName);
    public string GetWrapperNamespace (Type typeToWrap) => typeToWrap.Namespace.AssertNotNull().Replace("System", _options.Wrapper.ProjectName);

    public bool ShouldTypeBeWrapped (Type type) => _typesToWrap.Contains(type);

    private IReadOnlyCollection<MethodInfo> GetMethodsToWrap (Type typeToWrap)
    {
      return typeToWrap
          .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly)
          .Where(m => !m.IsSpecialName)
          .Where(m => m.DeclaringType == typeToWrap)
          .Where(m => m.GetCustomAttribute<ObsoleteAttribute>() == null)
          .Where(m => !_excluded.IsMethodExcluded(typeToWrap.Name, m.Name))
          .ToList();
    }

    private IReadOnlyCollection<PropertyInfo> GetPropertiesToWrap (Type typeToWrap)
    {
      return typeToWrap.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
          .Where(p => !p.IsSpecialName)
          .Where(p => p.DeclaringType == typeToWrap)
          .Where(p => p.GetCustomAttribute<ObsoleteAttribute>() == null)
          .Where(p => !_excluded.IsPropertyExcluded(typeToWrap.Name, p.Name))
          .ToList();
    }

    private class Excluded
    {
      private readonly HashSet<ExclusionKey> _excludedMethods;
      private readonly HashSet<ExclusionKey> _excludedProperties;

      public Excluded (IReadOnlyCollection<string> excludedMethods, IReadOnlyCollection<string> excludedProperties)
      {
        _excludedMethods = new HashSet<ExclusionKey>(excludedMethods.Select(s => new ExclusionKey(s)));
        _excludedProperties = new HashSet<ExclusionKey>(excludedProperties.Select(s => new ExclusionKey(s)));
      }

      public bool IsMethodExcluded(string typeName, string methodName)
      {
        return _excludedMethods.Contains(new ExclusionKey(typeName, methodName));
      }

      public bool IsPropertyExcluded(string typeName, string propertyName)
      {
        return _excludedProperties.Contains(new ExclusionKey(typeName, propertyName));
      }

      private class ExclusionKey : IEquatable<ExclusionKey>
      {
        private readonly string _type;
        private readonly string _member;

        public ExclusionKey (string typeAndMember)
        {
          var split = typeAndMember.Split('.');
          _type = split[0];
          _member = split[1];
        }

        public ExclusionKey (string type, string member)
        {
          _type = type;
          _member = member;
        }

        public bool Equals (ExclusionKey other)
        {
          if (ReferenceEquals(null, other))
            return false;
          if (ReferenceEquals(this, other))
            return true;

          return (_type == "*" || other._type == "*" || string.Equals(_type, other._type)) && string.Equals(_member, other._member);
        }

        public override bool Equals (object obj)
        {
          if (ReferenceEquals(null, obj))
            return false;
          if (ReferenceEquals(this, obj))
            return true;
          if (obj.GetType() != typeof(ExclusionKey))
            return false;
          return Equals((ExclusionKey) obj);
        }

        public override int GetHashCode ()
        {
          return _member.GetHashCode();
        }

        public static bool operator == (ExclusionKey left, ExclusionKey right)
        {
          return Equals(left, right);
        }

        public static bool operator != (ExclusionKey left, ExclusionKey right)
        {
          return !Equals(left, right);
        }
      }
    }
  }
}