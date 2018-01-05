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
  
  
  /// <summary>Provides access to local and remote processes and enables you to start and stop local system processes.</summary>
  /// <filterpriority>1</filterpriority>
  public class ProcessWrapper : Wrapperator.Interfaces.Diagnostics.IProcess
  {
    
    public System.Diagnostics.Process _Process { get; private set; }

    
    internal ProcessWrapper(System.Diagnostics.Process process)
    {
      _Process = process;
    }
    
    public int BasePriority
    {
      get
      {
        return _Process.BasePriority;
      }
    }
    
    public int ExitCode
    {
      get
      {
        return _Process.ExitCode;
      }
    }
    
    public bool HasExited
    {
      get
      {
        return _Process.HasExited;
      }
    }
    
    public Wrapperator.Interfaces.IDateTime ExitTime
    {
      get
      {
        return new Wrapperator.Wrappers.DateTimeWrapper(_Process.ExitTime);
      }
    }
    
    public System.IntPtr Handle
    {
      get
      {
        return _Process.Handle;
      }
    }
    
    public int HandleCount
    {
      get
      {
        return _Process.HandleCount;
      }
    }
    
    public int Id
    {
      get
      {
        return _Process.Id;
      }
    }
    
    public string MachineName
    {
      get
      {
        return _Process.MachineName;
      }
    }
    
    public System.IntPtr MainWindowHandle
    {
      get
      {
        return _Process.MainWindowHandle;
      }
    }
    
    public string MainWindowTitle
    {
      get
      {
        return _Process.MainWindowTitle;
      }
    }
    
    public System.Diagnostics.ProcessModule MainModule
    {
      get
      {
        return _Process.MainModule;
      }
    }
    
    public System.IntPtr MaxWorkingSet
    {
      get
      {
        return _Process.MaxWorkingSet;
      }
      set
      {
        _Process.MaxWorkingSet = value;
      }
    }
    
    public System.IntPtr MinWorkingSet
    {
      get
      {
        return _Process.MinWorkingSet;
      }
      set
      {
        _Process.MinWorkingSet = value;
      }
    }
    
    public System.Diagnostics.ProcessModuleCollection Modules
    {
      get
      {
        return _Process.Modules;
      }
    }
    
    public long NonpagedSystemMemorySize64
    {
      get
      {
        return _Process.NonpagedSystemMemorySize64;
      }
    }
    
    public long PagedMemorySize64
    {
      get
      {
        return _Process.PagedMemorySize64;
      }
    }
    
    public long PagedSystemMemorySize64
    {
      get
      {
        return _Process.PagedSystemMemorySize64;
      }
    }
    
    public long PeakPagedMemorySize64
    {
      get
      {
        return _Process.PeakPagedMemorySize64;
      }
    }
    
    public long PeakWorkingSet64
    {
      get
      {
        return _Process.PeakWorkingSet64;
      }
    }
    
    public long PeakVirtualMemorySize64
    {
      get
      {
        return _Process.PeakVirtualMemorySize64;
      }
    }
    
    public bool PriorityBoostEnabled
    {
      get
      {
        return _Process.PriorityBoostEnabled;
      }
      set
      {
        _Process.PriorityBoostEnabled = value;
      }
    }
    
    public System.Diagnostics.ProcessPriorityClass PriorityClass
    {
      get
      {
        return _Process.PriorityClass;
      }
      set
      {
        _Process.PriorityClass = value;
      }
    }
    
    public long PrivateMemorySize64
    {
      get
      {
        return _Process.PrivateMemorySize64;
      }
    }
    
    public System.TimeSpan PrivilegedProcessorTime
    {
      get
      {
        return _Process.PrivilegedProcessorTime;
      }
    }
    
    public string ProcessName
    {
      get
      {
        return _Process.ProcessName;
      }
    }
    
    public System.IntPtr ProcessorAffinity
    {
      get
      {
        return _Process.ProcessorAffinity;
      }
      set
      {
        _Process.ProcessorAffinity = value;
      }
    }
    
    public bool Responding
    {
      get
      {
        return _Process.Responding;
      }
    }
    
    public int SessionId
    {
      get
      {
        return _Process.SessionId;
      }
    }
    
    public Wrapperator.Interfaces.Diagnostics.IProcessStartInfo StartInfo
    {
      get
      {
        return new Wrapperator.Wrappers.Diagnostics.ProcessStartInfoWrapper(_Process.StartInfo);
      }
      set
      {
        _Process.StartInfo = value._ProcessStartInfo;
      }
    }
    
    public Wrapperator.Interfaces.IDateTime StartTime
    {
      get
      {
        return new Wrapperator.Wrappers.DateTimeWrapper(_Process.StartTime);
      }
    }
    
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject
    {
      get
      {
        return _Process.SynchronizingObject;
      }
      set
      {
        _Process.SynchronizingObject = value;
      }
    }
    
    public System.Diagnostics.ProcessThreadCollection Threads
    {
      get
      {
        return _Process.Threads;
      }
    }
    
    public System.TimeSpan TotalProcessorTime
    {
      get
      {
        return _Process.TotalProcessorTime;
      }
    }
    
    public System.TimeSpan UserProcessorTime
    {
      get
      {
        return _Process.UserProcessorTime;
      }
    }
    
    public long VirtualMemorySize64
    {
      get
      {
        return _Process.VirtualMemorySize64;
      }
    }
    
    public bool EnableRaisingEvents
    {
      get
      {
        return _Process.EnableRaisingEvents;
      }
      set
      {
        _Process.EnableRaisingEvents = value;
      }
    }
    
    public Wrapperator.Interfaces.IO.IStreamWriter StandardInput
    {
      get
      {
        return new Wrapperator.Wrappers.IO.StreamWriterWrapper(_Process.StandardInput);
      }
    }
    
    public Wrapperator.Interfaces.IO.IStreamReader StandardOutput
    {
      get
      {
        return new Wrapperator.Wrappers.IO.StreamReaderWrapper(_Process.StandardOutput);
      }
    }
    
    public Wrapperator.Interfaces.IO.IStreamReader StandardError
    {
      get
      {
        return new Wrapperator.Wrappers.IO.StreamReaderWrapper(_Process.StandardError);
      }
    }
    
    public long WorkingSet64
    {
      get
      {
        return _Process.WorkingSet64;
      }
    }
    
    public System.ComponentModel.ISite Site
    {
      get
      {
        return _Process.Site;
      }
      set
      {
        _Process.Site = value;
      }
    }
    
    public System.ComponentModel.IContainer Container
    {
      get
      {
        return _Process.Container;
      }
    }
    
    /// <summary>Closes a process that has a user interface by sending a close message to its main window.</summary>
    /// <returns>true if the close message was successfully sent; false if the associated process does not have a main window or if the main window is disabled (for example if a modal dialog is being shown).</returns>
    /// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property to false to access this property on Windows 98 and Windows Me.</exception>
    /// <exception cref="T:System.InvalidOperationException">The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process" /> object.</exception>
    /// <filterpriority>1</filterpriority>
    public bool CloseMainWindow()
    {
      return _Process.CloseMainWindow();
    }
    
    /// <summary>Frees all the resources that are associated with this component.</summary>
    /// <filterpriority>2</filterpriority>
    public void Close()
    {
      _Process.Close();
    }
    
    /// <summary>Discards any information about the associated process that has been cached inside the process component.</summary>
    /// <filterpriority>1</filterpriority>
    public void Refresh()
    {
      _Process.Refresh();
    }
    
    /// <summary>Starts (or reuses) the process resource that is specified by the <see cref="P:System.Diagnostics.Process.StartInfo" /> property of this <see cref="T:System.Diagnostics.Process" /> component and associates it with the component.</summary>
    /// <returns>true if a process resource is started; false if no new process resource is started (for example, if an existing process is reused).</returns>
    /// <exception cref="T:System.InvalidOperationException">No file name was specified in the <see cref="T:System.Diagnostics.Process" /> component's <see cref="P:System.Diagnostics.Process.StartInfo" />.-or- The <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> member of the <see cref="P:System.Diagnostics.Process.StartInfo" /> property is true while <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" />, or <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> is true. </exception>
    /// <exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed. </exception>
    /// <filterpriority>1</filterpriority>
    public bool Start()
    {
      return _Process.Start();
    }
    
    /// <summary>Immediately stops the associated process.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">The associated process could not be terminated. -or-The process is terminating.-or- The associated process is a Win16 executable.</exception>
    /// <exception cref="T:System.NotSupportedException">You are attempting to call <see cref="M:System.Diagnostics.Process.Kill" /> for a process that is running on a remote computer. The method is available only for processes running on the local computer.</exception>
    /// <exception cref="T:System.InvalidOperationException">The process has already exited. -or-There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object.</exception>
    /// <filterpriority>1</filterpriority>
    public void Kill()
    {
      _Process.Kill();
    }
    
    /// <summary>Instructs the <see cref="T:System.Diagnostics.Process" /> component to wait the specified number of milliseconds for the associated process to exit.</summary>
    /// <returns>true if the associated process has exited; otherwise, false.</returns>
    /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to exit. The maximum is the largest possible value of a 32-bit integer, which represents infinity to the operating system. </param>
    /// <exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed. </exception>
    /// <exception cref="T:System.SystemException">No process <see cref="P:System.Diagnostics.Process.Id" /> has been set, and a <see cref="P:System.Diagnostics.Process.Handle" /> from which the <see cref="P:System.Diagnostics.Process.Id" /> property can be determined does not exist.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object.-or- You are attempting to call <see cref="M:System.Diagnostics.Process.WaitForExit(System.Int32)" /> for a process that is running on a remote computer. This method is available only for processes that are running on the local computer. </exception>
    /// <filterpriority>1</filterpriority>
    public bool WaitForExit(int milliseconds)
    {
      return _Process.WaitForExit(milliseconds);
    }
    
    /// <summary>Instructs the <see cref="T:System.Diagnostics.Process" /> component to wait indefinitely for the associated process to exit.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed. </exception>
    /// <exception cref="T:System.SystemException">No process <see cref="P:System.Diagnostics.Process.Id" /> has been set, and a <see cref="P:System.Diagnostics.Process.Handle" /> from which the <see cref="P:System.Diagnostics.Process.Id" /> property can be determined does not exist.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object.-or- You are attempting to call <see cref="M:System.Diagnostics.Process.WaitForExit" /> for a process that is running on a remote computer. This method is available only for processes that are running on the local computer. </exception>
    /// <filterpriority>1</filterpriority>
    public void WaitForExit()
    {
      _Process.WaitForExit();
    }
    
    /// <summary>Causes the <see cref="T:System.Diagnostics.Process" /> component to wait the specified number of milliseconds for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.</summary>
    /// <returns>true if the associated process has reached an idle state; otherwise, false.</returns>
    /// <param name="milliseconds">A value of 1 to <see cref="F:System.Int32.MaxValue" /> that specifies the amount of time, in milliseconds, to wait for the associated process to become idle. A value of 0 specifies an immediate return, and a value of -1 specifies an infinite wait. </param>
    /// <exception cref="T:System.InvalidOperationException">The process does not have a graphical interface.-or-An unknown error occurred. The process failed to enter an idle state.-or-The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process" /> object.</exception>
    /// <filterpriority>1</filterpriority>
    public bool WaitForInputIdle(int milliseconds)
    {
      return _Process.WaitForInputIdle(milliseconds);
    }
    
    /// <summary>Causes the <see cref="T:System.Diagnostics.Process" /> component to wait indefinitely for the associated process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a message loop.</summary>
    /// <returns>true if the associated process has reached an idle state.</returns>
    /// <exception cref="T:System.InvalidOperationException">The process does not have a graphical interface.-or-An unknown error occurred. The process failed to enter an idle state.-or-The process has already exited. -or-No process is associated with this <see cref="T:System.Diagnostics.Process" /> object.</exception>
    /// <filterpriority>1</filterpriority>
    public bool WaitForInputIdle()
    {
      return _Process.WaitForInputIdle();
    }
    
    /// <summary>Begins asynchronous read operations on the redirected <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream of the application.</summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> property is false.- or - An asynchronous read operation is already in progress on the <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream.- or - The <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream has been used by a synchronous read operation. </exception>
    /// <filterpriority>2</filterpriority>
    public void BeginOutputReadLine()
    {
      _Process.BeginOutputReadLine();
    }
    
    /// <summary>Begins asynchronous read operations on the redirected <see cref="P:System.Diagnostics.Process.StandardError" /> stream of the application.</summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> property is false.- or - An asynchronous read operation is already in progress on the <see cref="P:System.Diagnostics.Process.StandardError" /> stream.- or - The <see cref="P:System.Diagnostics.Process.StandardError" /> stream has been used by a synchronous read operation. </exception>
    /// <filterpriority>2</filterpriority>
    public void BeginErrorReadLine()
    {
      _Process.BeginErrorReadLine();
    }
    
    /// <summary>Cancels the asynchronous read operation on the redirected <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream of an application.</summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardOutput" /> stream is not enabled for asynchronous read operations. </exception>
    /// <filterpriority>2</filterpriority>
    public void CancelOutputRead()
    {
      _Process.CancelOutputRead();
    }
    
    /// <summary>Cancels the asynchronous read operation on the redirected <see cref="P:System.Diagnostics.Process.StandardError" /> stream of an application.</summary>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.Process.StandardError" /> stream is not enabled for asynchronous read operations. </exception>
    /// <filterpriority>2</filterpriority>
    public void CancelErrorRead()
    {
      _Process.CancelErrorRead();
    }
    
    /// <summary>Retrieves the current lifetime service object that controls the lifetime policy for this instance.</summary>
    /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance.</returns>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    public object GetLifetimeService()
    {
      return _Process.GetLifetimeService();
    }
    
    /// <summary>Obtains a lifetime service object to control the lifetime policy for this instance.</summary>
    /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" /> property.</returns>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    public object InitializeLifetimeService()
    {
      return _Process.InitializeLifetimeService();
    }
    
    /// <summary>Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.</summary>
    /// <returns>Information required to generate a proxy.</returns>
    /// <param name="requestedType">The <see cref="T:System.Type" /> of the object that the new <see cref="T:System.Runtime.Remoting.ObjRef" /> will reference. </param>
    /// <exception cref="T:System.Runtime.Remoting.RemotingException">This instance is not a valid remoting object. </exception>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    public System.Runtime.Remoting.ObjRef CreateObjRef(Wrapperator.Interfaces.IType requestedType)
    {
      return _Process.CreateObjRef(requestedType == null ? default(System.Type) : requestedType._Type);
    }
    
    public void Dispose()
    {
      this.Dispose(true);
      System.GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _Process.Dispose();
      }
    }
  }
}
