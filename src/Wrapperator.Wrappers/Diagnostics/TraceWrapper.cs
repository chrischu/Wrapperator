//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Diagnostics
{
  
  
  /// <summary>Provides a set of methods and properties that help you trace the execution of your code. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public class TraceWrapper : Wrapperator.Interfaces.Diagnostics.ITrace
  {
    
    internal System.Diagnostics.Trace Trace { get; private set; }

    
    internal TraceWrapper(System.Diagnostics.Trace trace)
    {
      Trace = trace;
    }
  }
}
