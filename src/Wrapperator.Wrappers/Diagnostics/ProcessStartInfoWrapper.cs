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
  
  
  /// <summary>Specifies a set of values that are used when you start a process.</summary>
  /// <filterpriority>2</filterpriority>
  public class ProcessStartInfoWrapper : Wrapperator.Interfaces.Diagnostics.IProcessStartInfo
  {
    
    public System.Diagnostics.ProcessStartInfo _ProcessStartInfo { get; private set; }

    
    internal ProcessStartInfoWrapper(System.Diagnostics.ProcessStartInfo processStartInfo)
    {
      _ProcessStartInfo = processStartInfo;
    }
    
    public string Verb
    {
      get
      {
        return _ProcessStartInfo.Verb;
      }
      set
      {
        _ProcessStartInfo.Verb = value;
      }
    }
    
    public string Arguments
    {
      get
      {
        return _ProcessStartInfo.Arguments;
      }
      set
      {
        _ProcessStartInfo.Arguments = value;
      }
    }
    
    public bool CreateNoWindow
    {
      get
      {
        return _ProcessStartInfo.CreateNoWindow;
      }
      set
      {
        _ProcessStartInfo.CreateNoWindow = value;
      }
    }
    
    public System.Collections.Specialized.StringDictionary EnvironmentVariables
    {
      get
      {
        return _ProcessStartInfo.EnvironmentVariables;
      }
    }
    
    public bool RedirectStandardInput
    {
      get
      {
        return _ProcessStartInfo.RedirectStandardInput;
      }
      set
      {
        _ProcessStartInfo.RedirectStandardInput = value;
      }
    }
    
    public bool RedirectStandardOutput
    {
      get
      {
        return _ProcessStartInfo.RedirectStandardOutput;
      }
      set
      {
        _ProcessStartInfo.RedirectStandardOutput = value;
      }
    }
    
    public bool RedirectStandardError
    {
      get
      {
        return _ProcessStartInfo.RedirectStandardError;
      }
      set
      {
        _ProcessStartInfo.RedirectStandardError = value;
      }
    }
    
    public System.Text.Encoding StandardErrorEncoding
    {
      get
      {
        return _ProcessStartInfo.StandardErrorEncoding;
      }
      set
      {
        _ProcessStartInfo.StandardErrorEncoding = value;
      }
    }
    
    public System.Text.Encoding StandardOutputEncoding
    {
      get
      {
        return _ProcessStartInfo.StandardOutputEncoding;
      }
      set
      {
        _ProcessStartInfo.StandardOutputEncoding = value;
      }
    }
    
    public bool UseShellExecute
    {
      get
      {
        return _ProcessStartInfo.UseShellExecute;
      }
      set
      {
        _ProcessStartInfo.UseShellExecute = value;
      }
    }
    
    public string[] Verbs
    {
      get
      {
        return _ProcessStartInfo.Verbs;
      }
    }
    
    public string UserName
    {
      get
      {
        return _ProcessStartInfo.UserName;
      }
      set
      {
        _ProcessStartInfo.UserName = value;
      }
    }
    
    public System.Security.SecureString Password
    {
      get
      {
        return _ProcessStartInfo.Password;
      }
      set
      {
        _ProcessStartInfo.Password = value;
      }
    }
    
    public string Domain
    {
      get
      {
        return _ProcessStartInfo.Domain;
      }
      set
      {
        _ProcessStartInfo.Domain = value;
      }
    }
    
    public bool LoadUserProfile
    {
      get
      {
        return _ProcessStartInfo.LoadUserProfile;
      }
      set
      {
        _ProcessStartInfo.LoadUserProfile = value;
      }
    }
    
    public string FileName
    {
      get
      {
        return _ProcessStartInfo.FileName;
      }
      set
      {
        _ProcessStartInfo.FileName = value;
      }
    }
    
    public string WorkingDirectory
    {
      get
      {
        return _ProcessStartInfo.WorkingDirectory;
      }
      set
      {
        _ProcessStartInfo.WorkingDirectory = value;
      }
    }
    
    public bool ErrorDialog
    {
      get
      {
        return _ProcessStartInfo.ErrorDialog;
      }
      set
      {
        _ProcessStartInfo.ErrorDialog = value;
      }
    }
    
    public System.IntPtr ErrorDialogParentHandle
    {
      get
      {
        return _ProcessStartInfo.ErrorDialogParentHandle;
      }
      set
      {
        _ProcessStartInfo.ErrorDialogParentHandle = value;
      }
    }
    
    public System.Diagnostics.ProcessWindowStyle WindowStyle
    {
      get
      {
        return _ProcessStartInfo.WindowStyle;
      }
      set
      {
        _ProcessStartInfo.WindowStyle = value;
      }
    }
  }
}
