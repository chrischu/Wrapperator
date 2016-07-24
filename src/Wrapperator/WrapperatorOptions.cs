﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Wrapperator
{
  [PublicAPI]
  internal class WrapperatorOptionsBase
  {
    public string ProjectName { get; }
    public string ClassPrefix { get; set; } = string.Empty;
    public string ClassSuffix { get; set; } = string.Empty;

    protected WrapperatorOptionsBase (string projectName)
    {
      ProjectName = projectName;
    }

    public string GetName (string wrappedName)
    {
      return ClassPrefix + wrappedName + ClassSuffix;
    }
  }

  internal class WrapperatorWrapperOptions : WrapperatorOptionsBase
  {
    public WrapperatorWrapperOptions (string projectName)
        : base(projectName)
    {
      ClassPrefix = string.Empty;
      ClassSuffix = "Wrapper";
    }
  }

  internal class WrapperatorInterfaceOptions : WrapperatorOptionsBase
  {
    public WrapperatorInterfaceOptions (string projectName)
        : base(projectName)
    {
      ClassPrefix = "I";
      ClassSuffix = string.Empty;
    }
  }

  [PublicAPI]
  internal class WrapperatorOptions
  {
    public string SolutionDirectory { get; }
    public WrapperatorInterfaceOptions Interface { get; }
    public WrapperatorWrapperOptions Wrapper { get; }

    public IReadOnlyCollection<Type> TypesToWrap { get; }

    public IReadOnlyCollection<string> ExcludedMethods { get; set; } = new[]
                                                                       {
                                                                           "*.Equals",
                                                                           "*.GetHashCode",
                                                                           "*.ToString",
                                                                           "*.GetType",
                                                                           "*.Dispose",
                                                                           "MemoryStream.TryGetBuffer"
                                                                       };

    public IReadOnlyCollection<string> ExcludedProperties { get; set; } = new[]
                                                                          {
                                                                              "AssemblyName.CultureName",
                                                                              "XmlDocumentFragment.PreviousText",
                                                                              "XmlDocument.PreviousText"
                                                                          };

    public bool WrapParameterTypes { get; set; }
    public bool GenerateImplicitConversionOperators { get; set; }

    public WrapperatorOptions (
        string solutionDirectory,
        WrapperatorInterfaceOptions interfaceOptions,
        WrapperatorWrapperOptions wrapperOptions,
        IReadOnlyCollection<Type> typesToWrap)
    {
      SolutionDirectory = solutionDirectory;
      Interface = interfaceOptions;
      Wrapper = wrapperOptions;
      TypesToWrap = typesToWrap;
    }
  }
}