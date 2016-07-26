using System;

namespace Wrapperator.Options
{
  internal class WrapperatorInterfaceOptions : WrapperatorOptionsBase
  {
    public WrapperatorInterfaceOptions (string projectName)
        : base(projectName)
    {
      ClassPrefix = "I";
      ClassSuffix = string.Empty;
    }
  }
}