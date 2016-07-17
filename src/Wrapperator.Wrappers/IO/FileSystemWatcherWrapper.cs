//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.IO
{
  
  
  /// <summary>Listens to the file system change notifications and raises events when a directory, or file in a directory, changes.</summary>
  /// <filterpriority>2</filterpriority>
  public partial class FileSystemWatcherWrapper : Wrapperator.Interfaces.IO.IFileSystemWatcher
  {
    
    private System.IO.FileSystemWatcher _fileSystemWatcher;
    
    public FileSystemWatcherWrapper(System.IO.FileSystemWatcher fileSystemWatcher)
    {
      _fileSystemWatcher = fileSystemWatcher;
    }
    
    public bool EnableRaisingEvents
    {
      get
      {
        return _fileSystemWatcher.EnableRaisingEvents;
      }
      set
      {
        _fileSystemWatcher.EnableRaisingEvents = value;
      }
    }
    
    public string Filter
    {
      get
      {
        return _fileSystemWatcher.Filter;
      }
      set
      {
        _fileSystemWatcher.Filter = value;
      }
    }
    
    public bool IncludeSubdirectories
    {
      get
      {
        return _fileSystemWatcher.IncludeSubdirectories;
      }
      set
      {
        _fileSystemWatcher.IncludeSubdirectories = value;
      }
    }
    
    public int InternalBufferSize
    {
      get
      {
        return _fileSystemWatcher.InternalBufferSize;
      }
      set
      {
        _fileSystemWatcher.InternalBufferSize = value;
      }
    }
    
    public System.IO.NotifyFilters NotifyFilter
    {
      get
      {
        return _fileSystemWatcher.NotifyFilter;
      }
      set
      {
        _fileSystemWatcher.NotifyFilter = value;
      }
    }
    
    public string Path
    {
      get
      {
        return _fileSystemWatcher.Path;
      }
      set
      {
        _fileSystemWatcher.Path = value;
      }
    }
    
    public System.ComponentModel.ISite Site
    {
      get
      {
        return _fileSystemWatcher.Site;
      }
      set
      {
        _fileSystemWatcher.Site = value;
      }
    }
    
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject
    {
      get
      {
        return _fileSystemWatcher.SynchronizingObject;
      }
      set
      {
        _fileSystemWatcher.SynchronizingObject = value;
      }
    }
    
    /// <summary>Begins the initialization of a <see cref="T:System.IO.FileSystemWatcher" /> used on a form or used by another component. The initialization occurs at run time.</summary>
    /// <filterpriority>2</filterpriority>
    public void BeginInit()
    {
      _fileSystemWatcher.BeginInit();
    }
    
    /// <summary>Ends the initialization of a <see cref="T:System.IO.FileSystemWatcher" /> used on a form or used by another component. The initialization occurs at run time.</summary>
    /// <filterpriority>2</filterpriority>
    public void EndInit()
    {
      _fileSystemWatcher.EndInit();
    }
    
    /// <summary>A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor.</summary>
    /// <returns>A <see cref="T:System.IO.WaitForChangedResult" /> that contains specific information on the change that occurred.</returns>
    /// <param name="changeType">The <see cref="T:System.IO.WatcherChangeTypes" /> to watch for. </param>
    /// <filterpriority>2</filterpriority>
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType)
    {
      return _fileSystemWatcher.WaitForChanged(changeType);
    }
    
    /// <summary>A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor and the time (in milliseconds) to wait before timing out.</summary>
    /// <returns>A <see cref="T:System.IO.WaitForChangedResult" /> that contains specific information on the change that occurred.</returns>
    /// <param name="changeType">The <see cref="T:System.IO.WatcherChangeTypes" /> to watch for. </param>
    /// <param name="timeout">The time (in milliseconds) to wait before timing out. </param>
    /// <filterpriority>2</filterpriority>
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType, int timeout)
    {
      return _fileSystemWatcher.WaitForChanged(changeType, timeout);
    }
    
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _fileSystemWatcher.Dispose();
      }
    }
    
    public void Dispose()
    {
      this.Dispose(true);
      System.GC.SuppressFinalize(this);
    }
  }
}
