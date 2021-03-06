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
  
  
  /// <summary>Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public interface IFileInfo
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.IO.FileInfo _FileInfo
    {
      get;
    }
    
    string Name
    {
      get;
    }
    
    long Length
    {
      get;
    }
    
    string DirectoryName
    {
      get;
    }
    
    Wrapperator.Interfaces.IO.IDirectoryInfo Directory
    {
      get;
    }
    
    bool IsReadOnly
    {
      get;
      set;
    }
    
    bool Exists
    {
      get;
    }
    
    string FullName
    {
      get;
    }
    
    string Extension
    {
      get;
    }
    
    Wrapperator.Interfaces.IDateTime CreationTime
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IDateTime CreationTimeUtc
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IDateTime LastAccessTime
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IDateTime LastAccessTimeUtc
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IDateTime LastWriteTime
    {
      get;
      set;
    }
    
    Wrapperator.Interfaces.IDateTime LastWriteTimeUtc
    {
      get;
      set;
    }
    
    System.IO.FileAttributes Attributes
    {
      get;
      set;
    }
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control rules for the current file.</returns>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    System.Security.AccessControl.FileSecurity GetAccessControl();
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the specified type of access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control rules for the current file.     </returns>
    /// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies which group of access control entries to retrieve. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections);
    
    /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.FileSecurity" /> object to the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <param name="fileSecurity">A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that describes an access control list (ACL) entry to apply to the current file.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="fileSecurity" /> parameter is null.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found or modified.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <filterpriority>1</filterpriority>
    void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity);
    
    /// <summary>Creates a <see cref="T:System.IO.StreamReader" /> with UTF8 encoding that reads from an existing text file.</summary>
    /// <returns>A new StreamReader with UTF8 encoding.</returns>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IStreamReader OpenText();
    
    /// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that writes a new text file.</summary>
    /// <returns>A new StreamWriter.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory. </exception>
    /// <exception cref="T:System.IO.IOException">The disk is read-only. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IStreamWriter CreateText();
    
    /// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo" />.</summary>
    /// <returns>A new StreamWriter.</returns>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IStreamWriter AppendText();
    
    /// <summary>Copies an existing file to a new file, disallowing the overwriting of an existing file.</summary>
    /// <returns>A new file with a fully qualified path.</returns>
    /// <param name="destFileName">The name of the new file to copy to. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
    /// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destFileName" /> is null. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <paramref name="destFileName" /> contains a colon (:) within the string but does not specify the volume. </exception>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IFileInfo CopyTo(string destFileName);
    
    /// <summary>Copies an existing file to a new file, allowing the overwriting of an existing file.</summary>
    /// <returns>A new file, or an overwrite of an existing file if <paramref name="overwrite" /> is true. If the file exists and <paramref name="overwrite" /> is false, an <see cref="T:System.IO.IOException" /> is thrown.</returns>
    /// <param name="destFileName">The name of the new file to copy to. </param>
    /// <param name="overwrite">true to allow an existing file to be overwritten; otherwise, false. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
    /// <exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists and <paramref name="overwrite" /> is false. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destFileName" /> is null. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IFileInfo CopyTo(string destFileName, bool overwrite);
    
    /// <summary>Creates a file.</summary>
    /// <returns>A new file.</returns>
    /// <filterpriority>1</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream Create();
    
    /// <summary>Permanently deletes a file.</summary>
    /// <exception cref="T:System.IO.IOException">The target file is open or memory-mapped on a computer running Microsoft Windows NT.-or-There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The path is a directory. </exception>
    /// <filterpriority>1</filterpriority>
    void Delete();
    
    /// <summary>Decrypts a file that was encrypted by the current account using the <see cref="M:System.IO.FileInfo.Encrypt" /> method.</summary>
    /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="T:System.IO.FileInfo" /> object is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>2</filterpriority>
    void Decrypt();
    
    /// <summary>Encrypts a file so that only the account used to encrypt the file can decrypt it.</summary>
    /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="T:System.IO.FileInfo" /> object is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    void Encrypt();
    
    /// <summary>Opens a file in the specified mode.</summary>
    /// <returns>A file opened in the specified mode, with read/write access and unshared.</returns>
    /// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode);
    
    /// <summary>Opens a file in the specified mode with read, write, or read/write access.</summary>
    /// <returns>A <see cref="T:System.IO.FileStream" /> object opened in the specified mode and access, and unshared.</returns>
    /// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
    /// <param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode, System.IO.FileAccess access);
    
    /// <summary>Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.</summary>
    /// <returns>A <see cref="T:System.IO.FileStream" /> object opened with the specified mode, access, and sharing options.</returns>
    /// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
    /// <param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param>
    /// <param name="share">A <see cref="T:System.IO.FileShare" /> constant specifying the type of access other FileStream objects have to this file. </param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share);
    
    /// <summary>Creates a read-only <see cref="T:System.IO.FileStream" />.</summary>
    /// <returns>A new read-only <see cref="T:System.IO.FileStream" /> object.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream OpenRead();
    
    /// <summary>Creates a write-only <see cref="T:System.IO.FileStream" />.</summary>
    /// <returns>A write-only unshared <see cref="T:System.IO.FileStream" /> object for a new or existing file.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is read-only or is a directory.  </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is invalid, such as being on an unmapped drive. </exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileStream OpenWrite();
    
    /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary>
    /// <param name="destFileName">The path to move the file to, which can specify a different file name. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs, such as the destination file already exists or the destination device is not ready. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destFileName" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="destFileName" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception>
    /// <filterpriority>1</filterpriority>
    void MoveTo(string destFileName);
    
    /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo" /> object, deleting the original file, and creating a backup of the replaced file.</summary>
    /// <returns>A <see cref="T:System.IO.FileInfo" /> object that encapsulates information about the file described by the <paramref name="destFileName" /> parameter.</returns>
    /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
    /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the <paramref name="destFileName" /> parameter.</param>
    /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destBackupFileName" /> parameter was not of a legal form.</exception>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="destFileName" /> parameter is null.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationFileName" /> parameter could not be found. </exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileInfo Replace(string destinationFileName, string destinationBackupFileName);
    
    /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo" /> object, deleting the original file, and creating a backup of the replaced file.  Also specifies whether to ignore merge errors. </summary>
    /// <returns>A <see cref="T:System.IO.FileInfo" /> object that encapsulates information about the file described by the <paramref name="destFileName" /> parameter.</returns>
    /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
    /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the <paramref name="destFileName" /> parameter.</param>
    /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and ACLs) from the replaced file to the replacement file; otherwise false. </param>
    /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destBackupFileName" /> parameter was not of a legal form.</exception>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="destFileName" /> parameter is null.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationFileName" /> parameter could not be found. </exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <filterpriority>2</filterpriority>
    Wrapperator.Interfaces.IO.IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
    
    /// <summary>Refreshes the state of the object.</summary>
    /// <exception cref="T:System.IO.IOException">A device such as a disk drive is not ready. </exception>
    /// <filterpriority>1</filterpriority>
    void Refresh();
    
    /// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and additional exception information.</summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
    /// <filterpriority>2</filterpriority>
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    
    /// <summary>Retrieves the current lifetime service object that controls the lifetime policy for this instance.</summary>
    /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance.</returns>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    object GetLifetimeService();
    
    /// <summary>Obtains a lifetime service object to control the lifetime policy for this instance.</summary>
    /// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" /> property.</returns>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    object InitializeLifetimeService();
    
    /// <summary>Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.</summary>
    /// <returns>Information required to generate a proxy.</returns>
    /// <param name="requestedType">The <see cref="T:System.Type" /> of the object that the new <see cref="T:System.Runtime.Remoting.ObjRef" /> will reference. </param>
    /// <exception cref="T:System.Runtime.Remoting.RemotingException">This instance is not a valid remoting object. </exception>
    /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
    /// <filterpriority>2</filterpriority>
    System.Runtime.Remoting.ObjRef CreateObjRef(Wrapperator.Interfaces.IType requestedType);
  }
}
