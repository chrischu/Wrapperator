using System;
using JetBrains.Annotations;

namespace Wrapperator.Options
{
  [PublicAPI]
  internal class WrapperatorOptionsBase
  {
    protected WrapperatorOptionsBase (string projectName)
    {
      ProjectName = projectName;
    }

    public string ProjectName { get; }
    public string ClassPrefix { get; set; } = string.Empty;
    public string ClassSuffix { get; set; } = string.Empty;

    public string GetName (string wrappedName)
    {
      return ClassPrefix + wrappedName + ClassSuffix;
    }
  }
}