using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Wrapperator.Options
{
  [PublicAPI]
  internal class WrapperatorOptions
  {
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
                                                                              "XmlDocument.PreviousText",
                                                                              "Process.SafeHandle",
                                                                              "ProcessStartInfo.Environment",
                                                                              "ProcessStartInfo.PasswordInClearText"
                                                                          };

    public bool WrapParameterTypes { get; set; }
    public bool GenerateImplicitConversionOperators { get; set; }
  }
}