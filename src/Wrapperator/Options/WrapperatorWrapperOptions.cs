using System;

namespace Wrapperator.Options
{
  internal class WrapperatorWrapperOptions : WrapperatorOptionsBase
  {
    public WrapperatorWrapperOptions (string projectName)
        : base(projectName)
    {
      ClassPrefix = string.Empty;
      ClassSuffix = "Wrapper";
    }
  }
}