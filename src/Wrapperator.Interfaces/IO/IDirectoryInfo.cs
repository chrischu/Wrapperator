//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.IO
{
  
  
  /// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public partial interface IDirectoryInfo
  {
    
    bool Exists
    {
      get;
    }
    
    string Name
    {
      get;
    }
    
    System.IO.DirectoryInfo Parent
    {
      get;
    }
    
    System.IO.DirectoryInfo Root
    {
      get;
    }
    
    /// <summary>Creates a directory.</summary>
    /// <exception cref="T:System.IO.IOException">The directory cannot be created. </exception>
    /// <filterpriority>1</filterpriority>
    void Create();
    
    /// <summary>Creates a directory using a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object.</summary>
    /// <param name="directorySecurity">The access control to apply to the directory.</param>
    /// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is read-only or is not empty. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="path" /> is null. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.NotSupportedException">Creating a directory with only the colon (:) character was attempted. </exception>
    /// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is read-only or is not empty. </exception>
    /// <filterpriority>1</filterpriority>
    void Create(System.Security.AccessControl.DirectorySecurity directorySecurity);
    
    /// <summary>Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo" /> class.</summary>
    /// <returns>The last directory specified in <paramref name="path" />.</returns>
    /// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="path" /> does not specify a valid file path or contains invalid DirectoryInfo characters. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="path" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The subdirectory cannot be created.-or- A file or directory already has the name specified by <paramref name="path" />. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.-or-The caller does not have code access permission to read the directory described by the returned <see cref="T:System.IO.DirectoryInfo" /> object.  This can occur when the <paramref name="path" /> parameter describes an existing directory.</exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IDirectoryInfo CreateSubdirectory(string path);
    
    /// <summary>Creates a subdirectory or subdirectories on the specified path with the specified security. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo" /> class.</summary>
    /// <returns>The last directory specified in <paramref name="path" />.</returns>
    /// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.</param>
    /// <param name="directorySecurity">The security to apply.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="path" /> does not specify a valid file path or contains invalid DirectoryInfo characters. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="path" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The subdirectory cannot be created.-or- A file or directory already has the name specified by <paramref name="path" />. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.-or-The caller does not have code access permission to read the directory described by the returned <see cref="T:System.IO.DirectoryInfo" /> object.  This can occur when the <paramref name="path" /> parameter describes an existing directory.</exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IDirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity);
    
    /// <summary>Deletes this <see cref="T:System.IO.DirectoryInfo" /> if it is empty.</summary>
    /// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">The directory is not empty. -or-The directory is the application's current working directory.-or-There is an open handle on the directory, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories. For more information, see How to: Enumerate Directories and Files.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    void Delete();
    
    /// <summary>Deletes this instance of a <see cref="T:System.IO.DirectoryInfo" />, specifying whether to delete subdirectories and files.</summary>
    /// <param name="recursive">true to delete this directory, its subdirectories, and all files; otherwise, false. </param>
    /// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">The directory is read-only.-or- The directory contains one or more files or subdirectories and <paramref name="recursive" /> is false.-or-The directory is the application's current working directory. -or-There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    void Delete(bool recursive);
    
    /// <summary>Returns an enumerable collection of directory information in the current directory.</summary>
    /// <returns>An enumerable collection of directories in the current directory.</returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories();
    
    /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern.</summary>
    /// <returns>An enumerable collection of directories that matches <paramref name="searchPattern" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern);
    
    /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern and search subdirectory option. </summary>
    /// <returns>An enumerable collection of directories that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Returns an enumerable collection of file information in the current directory.</summary>
    /// <returns>An enumerable collection of the files in the current directory.</returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles();
    
    /// <summary>Returns an enumerable collection of file information that matches a search pattern.</summary>
    /// <returns>An enumerable collection of files that matches <paramref name="searchPattern" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid, (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern);
    
    /// <summary>Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.</summary>
    /// <returns>An enumerable collection of files that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Returns an enumerable collection of file system information in the current directory.</summary>
    /// <returns>An enumerable collection of file system information in the current directory. </returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos();
    
    /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern.</summary>
    /// <returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
    
    /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern and search subdirectory option.</summary>
    /// <returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the access control list (ACL) entries for the directory described by the current <see cref="T:System.IO.DirectoryInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the access control rules for the directory.</returns>
    /// <exception cref="T:System.SystemException">The directory could not be found or modified.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the directory.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the directory.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The directory is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    System.Security.AccessControl.DirectorySecurity GetAccessControl();
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the specified type of access control list (ACL) entries for the directory described by the current <see cref="T:System.IO.DirectoryInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the access control rules for the file described by the <paramref name="path" /> parameter.ExceptionsException typeCondition<see cref="T:System.SystemException" />The directory could not be found or modified.<see cref="T:System.UnauthorizedAccessException" />The current process does not have access to open the directory.<see cref="T:System.IO.IOException" />An I/O error occurred while opening the directory.<see cref="T:System.PlatformNotSupportedException" />The current operating system is not Microsoft Windows 2000 or later.<see cref="T:System.UnauthorizedAccessException" />The directory is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</returns>
    /// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies the type of access control list (ACL) information to receive.</param>
    /// <filterpriority>1</filterpriority>
    System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections);
    
    /// <summary>Returns the subdirectories of the current directory.</summary>
    /// <returns>An array of <see cref="T:System.IO.DirectoryInfo" /> objects.</returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    System.IO.DirectoryInfo[] GetDirectories();
    
    /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo" /> matching the given search criteria.</summary>
    /// <returns>An array of type DirectoryInfo matching <paramref name="searchPattern" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    System.IO.DirectoryInfo[] GetDirectories(string searchPattern);
    
    /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo" /> matching the given search criteria and using a value to determine whether to search subdirectories.</summary>
    /// <returns>An array of type DirectoryInfo matching <paramref name="searchPattern" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
    System.IO.DirectoryInfo[] GetDirectories(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Returns a file list from the current directory matching the given search pattern.</summary>
    /// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    System.IO.FileInfo[] GetFiles(string searchPattern);
    
    /// <summary>Returns a file list from the current directory matching the given search pattern and using a value to determine whether to search subdirectories.</summary>
    /// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
    /// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.IO.FileInfo[] GetFiles(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Returns a file list from the current directory.</summary>
    /// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid, such as being on an unmapped drive. </exception>
    /// <filterpriority>1</filterpriority>
    System.IO.FileInfo[] GetFiles();
    
    /// <summary>Retrieves an array of strongly typed <see cref="T:System.IO.FileSystemInfo" /> objects representing the files and subdirectories that match the specified search criteria.</summary>
    /// <returns>An array of strongly typed FileSystemInfo objects matching the search criteria.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories and files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>2</filterpriority>
    System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern);
    
    /// <summary>Retrieves an array of <see cref="T:System.IO.FileSystemInfo" /> objects that represent the files and subdirectories matching the specified search criteria.</summary>
    /// <returns>An array of file system entries that match the search criteria.</returns>
    /// <param name="searchPattern">The search string to match against the names of directories and filesa.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
    /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="searchPattern" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption);
    
    /// <summary>Returns an array of strongly typed <see cref="T:System.IO.FileSystemInfo" /> entries representing all the files and subdirectories in a directory.</summary>
    /// <returns>An array of strongly typed <see cref="T:System.IO.FileSystemInfo" /> entries.</returns>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception>
    /// <filterpriority>2</filterpriority>
    System.IO.FileSystemInfo[] GetFileSystemInfos();
    
    /// <summary>Moves a <see cref="T:System.IO.DirectoryInfo" /> instance and its contents to a new path.</summary>
    /// <param name="destDirName">The name and path to which to move this directory. The destination cannot be another disk volume or a directory with the identical name. It can be an existing directory to which you want to add this directory as a subdirectory. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destDirName" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="destDirName" /> is an empty string (''"). </exception>
    /// <exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume. -or-<paramref name="destDirName" /> already exists.-or-You are not authorized to access this path.-or- The directory being moved and the destination directory have the same name.</exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The destination directory cannot be found.</exception>
    /// <filterpriority>1</filterpriority>
    void MoveTo(string destDirName);
    
    /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object to the directory described by the current <see cref="T:System.IO.DirectoryInfo" /> object.</summary>
    /// <param name="directorySecurity">An object that describes an ACL entry to apply to the directory described by the <paramref name="path" /> parameter.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="directorySecurity" /> parameter is null.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found or modified.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <filterpriority>1</filterpriority>
    void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity);
  }
}
