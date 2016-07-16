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
  
  
  /// <summary>Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.</summary>
  /// <filterpriority>1</filterpriority>
  public partial class FileInfoWrapper : Wrapperator.Interfaces.IO.IFileInfo
  {
    
    private System.IO.FileInfo _fileInfo;
    
    public FileInfoWrapper(System.IO.FileInfo fileInfo)
    {
      _fileInfo = fileInfo;
    }
    
    /// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo" />.</summary>
    /// <returns>A new StreamWriter.</returns>
    /// <filterpriority>1</filterpriority>
    public Wrapperator.Interfaces.IO.IStreamWriter AppendText()
    {
      return new Wrapperator.Wrappers.IO.StreamWriterWrapper(_fileInfo.AppendText());
    }
    
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
    public Wrapperator.Interfaces.IO.IFileInfo CopyTo(string destFileName)
    {
      return new Wrapperator.Wrappers.IO.FileInfoWrapper(_fileInfo.CopyTo(destFileName));
    }
    
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
    public Wrapperator.Interfaces.IO.IFileInfo CopyTo(string destFileName, bool overwrite)
    {
      return new Wrapperator.Wrappers.IO.FileInfoWrapper(_fileInfo.CopyTo(destFileName, overwrite));
    }
    
    /// <summary>Creates a file.</summary>
    /// <returns>A new file.</returns>
    /// <filterpriority>1</filterpriority>
    public Wrapperator.Interfaces.IO.IFileStream Create()
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.Create());
    }
    
    /// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that writes a new text file.</summary>
    /// <returns>A new StreamWriter.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory. </exception>
    /// <exception cref="T:System.IO.IOException">The disk is read-only. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>1</filterpriority>
    public Wrapperator.Interfaces.IO.IStreamWriter CreateText()
    {
      return new Wrapperator.Wrappers.IO.StreamWriterWrapper(_fileInfo.CreateText());
    }
    
    /// <summary>Decrypts a file that was encrypted by the current account using the <see cref="M:System.IO.FileInfo.Encrypt" /> method.</summary>
    /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="T:System.IO.FileInfo" /> object is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>2</filterpriority>
    public void Decrypt()
    {
      _fileInfo.Decrypt();
    }
    
    /// <summary>Permanently deletes a file.</summary>
    /// <exception cref="T:System.IO.IOException">The target file is open or memory-mapped on a computer running Microsoft Windows NT.-or-There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The path is a directory. </exception>
    /// <filterpriority>1</filterpriority>
    public void Delete()
    {
      _fileInfo.Delete();
    }
    
    /// <summary>Encrypts a file so that only the account used to encrypt the file can decrypt it.</summary>
    /// <exception cref="T:System.IO.DriveNotFoundException">An invalid drive was specified. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.NotSupportedException">The file system is not NTFS.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file described by the current <see cref="T:System.IO.FileInfo" /> object is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    public void Encrypt()
    {
      _fileInfo.Encrypt();
    }
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control rules for the current file.</returns>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    public System.Security.AccessControl.FileSecurity GetAccessControl()
    {
      return _fileInfo.GetAccessControl();
    }
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the specified type of access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <returns>A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control rules for the current file.     </returns>
    /// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies which group of access control entries to retrieve. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    public System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections)
    {
      return _fileInfo.GetAccessControl(includeSections);
    }
    
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
    public void MoveTo(string destFileName)
    {
      _fileInfo.MoveTo(destFileName);
    }
    
    /// <summary>Opens a file in the specified mode.</summary>
    /// <returns>A file opened in the specified mode, with read/write access and unshared.</returns>
    /// <param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The file is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode)
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.Open(mode));
    }
    
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
    public Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode, System.IO.FileAccess access)
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.Open(mode, access));
    }
    
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
    public Wrapperator.Interfaces.IO.IFileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share)
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.Open(mode, access, share));
    }
    
    /// <summary>Creates a read-only <see cref="T:System.IO.FileStream" />.</summary>
    /// <returns>A new read-only <see cref="T:System.IO.FileStream" /> object.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <exception cref="T:System.IO.IOException">The file is already open. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.IFileStream OpenRead()
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.OpenRead());
    }
    
    /// <summary>Creates a <see cref="T:System.IO.StreamReader" /> with UTF8 encoding that reads from an existing text file.</summary>
    /// <returns>A new StreamReader with UTF8 encoding.</returns>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception>
    /// <exception cref="T:System.UnauthorizedAccessException">
    ///  <paramref name="path" /> is read-only or is a directory. </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.IStreamReader OpenText()
    {
      return new Wrapperator.Wrappers.IO.StreamReaderWrapper(_fileInfo.OpenText());
    }
    
    /// <summary>Creates a write-only <see cref="T:System.IO.FileStream" />.</summary>
    /// <returns>A write-only unshared <see cref="T:System.IO.FileStream" /> object for a new or existing file.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is read-only or is a directory.  </exception>
    /// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified when creating an instance of the <see cref="T:System.IO.FileInfo" /> object is invalid, such as being on an unmapped drive. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.IFileStream OpenWrite()
    {
      return new Wrapperator.Wrappers.IO.FileStreamWrapper(_fileInfo.OpenWrite());
    }
    
    /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo" /> object, deleting the original file, and creating a backup of the replaced file.</summary>
    /// <returns>A <see cref="T:System.IO.FileInfo" /> object that encapsulates information about the file described by the <paramref name="destFileName" /> parameter.</returns>
    /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
    /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the <paramref name="destFileName" /> parameter.</param>
    /// <exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destBackupFileName" /> parameter was not of a legal form.</exception>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="destFileName" /> parameter is null.</exception>
    /// <exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationFileName" /> parameter could not be found. </exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
    {
      return new Wrapperator.Wrappers.IO.FileInfoWrapper(_fileInfo.Replace(destinationFileName, destinationBackupFileName));
    }
    
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
    public Wrapperator.Interfaces.IO.IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
    {
      return new Wrapperator.Wrappers.IO.FileInfoWrapper(_fileInfo.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
    }
    
    /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.FileSecurity" /> object to the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary>
    /// <param name="fileSecurity">A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that describes an access control list (ACL) entry to apply to the current file.</param>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="fileSecurity" /> parameter is null.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found or modified.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception>
    /// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception>
    /// <filterpriority>1</filterpriority>
    public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity)
    {
      _fileInfo.SetAccessControl(fileSecurity);
    }
  }
}
