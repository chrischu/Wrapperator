//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces
{
  
  
  /// <summary>Provides information about, and means to manipulate, the current environment and platform. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public partial interface IEnvironment
  {
    
    string CommandLine
    {
      get;
    }
    
    string CurrentDirectory
    {
      get;
      set;
    }
    
    int CurrentManagedThreadId
    {
      get;
    }
    
    int ExitCode
    {
      get;
      set;
    }
    
    bool HasShutdownStarted
    {
      get;
    }
    
    bool Is64BitOperatingSystem
    {
      get;
    }
    
    bool Is64BitProcess
    {
      get;
    }
    
    string MachineName
    {
      get;
    }
    
    string NewLine
    {
      get;
    }
    
    System.OperatingSystem OSVersion
    {
      get;
    }
    
    int ProcessorCount
    {
      get;
    }
    
    string StackTrace
    {
      get;
    }
    
    string SystemDirectory
    {
      get;
    }
    
    int SystemPageSize
    {
      get;
    }
    
    int TickCount
    {
      get;
    }
    
    string UserDomainName
    {
      get;
    }
    
    bool UserInteractive
    {
      get;
    }
    
    string UserName
    {
      get;
    }
    
    System.Version Version
    {
      get;
    }
    
    long WorkingSet
    {
      get;
    }
    
    /// <summary>Terminates this process and gives the underlying operating system the specified exit code.</summary>
    /// <param name="exitCode">Exit code to be given to the operating system. Use 0 (zero) to indicate that the process completed successfully.</param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have sufficient security permission to perform this function.</exception>
    /// <filterpriority>1</filterpriority>
    void Exit(int exitCode);
    
    /// <summary>Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string.</summary>
    /// <returns>A string with each environment variable replaced by its value.</returns>
    /// <param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%).</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="name" /> is null.</exception>
    /// <filterpriority>1</filterpriority>
    string ExpandEnvironmentVariables(string name);
    
    /// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message in error reporting to Microsoft.</summary>
    /// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
    void FailFast(string message);
    
    /// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary>
    /// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
    /// <param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a catch block.</param>
    void FailFast(string message, System.Exception exception);
    
    /// <summary>Returns a string array containing the command-line arguments for the current process.</summary>
    /// <returns>An array of string where each element contains a command-line argument. The first element is the executable file name, and the following zero or more elements contain the remaining command-line arguments.</returns>
    /// <exception cref="T:System.NotSupportedException">The system does not support command-line arguments.</exception>
    /// <filterpriority>1</filterpriority>
    string[] GetCommandLineArgs();
    
    /// <summary>Retrieves the value of an environment variable from the current process.</summary>
    /// <returns>The value of the environment variable specified by <paramref name="variable" />, or null if the environment variable is not found.</returns>
    /// <param name="variable">The name of the environment variable.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="variable" /> is null.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
    /// <filterpriority>1</filterpriority>
    string GetEnvironmentVariable(string variable);
    
    /// <summary>Retrieves the value of an environment variable from the current process or from the Windows operating system registry key for the current user or local machine.</summary>
    /// <returns>The value of the environment variable specified by the <paramref name="variable" /> and <paramref name="target" /> parameters, or null if the environment variable is not found.</returns>
    /// <param name="variable">The name of an environment variable.</param>
    /// <param name="target">One of the <see cref="T:System.EnvironmentVariableTarget" /> values.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="variable" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="target" /> is not a valid <see cref="T:System.EnvironmentVariableTarget" /> value.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
    /// <filterpriority>1</filterpriority>
    string GetEnvironmentVariable(string variable, System.EnvironmentVariableTarget target);
    
    /// <summary>Retrieves all environment variable names and their values from the current process.</summary>
    /// <returns>A dictionary that contains all environment variable names and their values; otherwise, an empty dictionary if no environment variables are found.</returns>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
    /// <exception cref="T:System.OutOfMemoryException">The buffer is out of memory.</exception>
    /// <filterpriority>1</filterpriority>
    System.Collections.IDictionary GetEnvironmentVariables();
    
    /// <summary>Retrieves all environment variable names and their values from the current process, or from the Windows operating system registry key for the current user or local machine.</summary>
    /// <returns>A dictionary that contains all environment variable names and their values from the source specified by the <paramref name="target" /> parameter; otherwise, an empty dictionary if no environment variables are found.</returns>
    /// <param name="target">One of the <see cref="T:System.EnvironmentVariableTarget" /> values.</param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation for the specified value of <paramref name="target" />.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="target" /> contains an illegal value.</exception>
    /// <filterpriority>1</filterpriority>
    System.Collections.IDictionary GetEnvironmentVariables(System.EnvironmentVariableTarget target);
    
    /// <summary>Gets the path to the system special folder that is identified by the specified enumeration.</summary>
    /// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
    /// <param name="folder">An enumerated constant that identifies a system special folder.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" />.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current platform is not supported.</exception>
    /// <filterpriority>1</filterpriority>
    string GetFolderPath(System.Environment.SpecialFolder folder);
    
    /// <summary>Gets the path to the system special folder that is identified by the specified enumeration, and uses a specified option for accessing special folders.</summary>
    /// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, an empty string ("").A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
    /// <param name="folder">An enumerated constant that identifies a system special folder.</param>
    /// <param name="option">Specifies options to use for accessing a special folder.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" /></exception>
    /// <exception cref="T:System.PlatformNotSupportedException">
    ///  <see cref="T:System.PlatformNotSupportedException" />
    ///</exception>
    string GetFolderPath(System.Environment.SpecialFolder folder, System.Environment.SpecialFolderOption option);
    
    /// <summary>Returns an array of string containing the names of the logical drives on the current computer.</summary>
    /// <returns>An array of strings where each element contains the name of a logical drive. For example, if the computer's hard drive is the first logical drive, the first element returned is "C:\".</returns>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions.</exception>
    /// <filterpriority>1</filterpriority>
    string[] GetLogicalDrives();
    
    /// <summary>Creates, modifies, or deletes an environment variable stored in the current process.</summary>
    /// <param name="variable">The name of an environment variable.</param>
    /// <param name="value">A value to assign to <paramref name="variable" />.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="variable" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="variable" /> contains a zero-length string, an initial hexadecimal zero character (0x00), or an equal sign ("="). -or-The length of <paramref name="variable" /> or <paramref name="value" /> is greater than or equal to 32,767 characters.-or-An error occurred during the execution of this operation.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
    /// <filterpriority>1</filterpriority>
    void SetEnvironmentVariable(string variable, string value);
    
    /// <summary>Creates, modifies, or deletes an environment variable stored in the current process or in the Windows operating system registry key reserved for the current user or local machine.</summary>
    /// <param name="variable">The name of an environment variable.</param>
    /// <param name="value">A value to assign to <paramref name="variable" />.</param>
    /// <param name="target">One of the enumeration values that specifies the location of the environment variable.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="variable" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="variable" /> contains a zero-length string, an initial hexadecimal zero character (0x00), or an equal sign ("="). -or-The length of <paramref name="variable" /> is greater than or equal to 32,767 characters.-or-<paramref name="target" /> is not a member of the <see cref="T:System.EnvironmentVariableTarget" /> enumeration. -or-<paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.Machine" /> or <see cref="F:System.EnvironmentVariableTarget.User" />, and the length of <paramref name="variable" /> is greater than or equal to 255.-or-<paramref name="target" /> is <see cref="F:System.EnvironmentVariableTarget.Process" /> and the length of <paramref name="value" /> is greater than or equal to 32,767 characters. -or-An error occurred during the execution of this operation.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
    /// <filterpriority>1</filterpriority>
    void SetEnvironmentVariable(string variable, string value, System.EnvironmentVariableTarget target);
  }
}
