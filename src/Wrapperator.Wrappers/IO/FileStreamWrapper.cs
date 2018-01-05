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
  
  
  /// <summary>Exposes a <see cref="T:System.IO.Stream" /> around a file, supporting both synchronous and asynchronous read and write operations.</summary>
  /// <filterpriority>1</filterpriority>
  public class FileStreamWrapper : StreamWrapper, Wrapperator.Interfaces.IO.IFileStream
  {
    
    public System.IO.FileStream _FileStream { get; private set; }

    
    internal FileStreamWrapper(System.IO.FileStream fileStream) : 
        base(fileStream)
    {
      _FileStream = fileStream;
    }
    
    public new bool CanRead
    {
      get
      {
        return _FileStream.CanRead;
      }
    }
    
    public new bool CanWrite
    {
      get
      {
        return _FileStream.CanWrite;
      }
    }
    
    public new bool CanSeek
    {
      get
      {
        return _FileStream.CanSeek;
      }
    }
    
    public bool IsAsync
    {
      get
      {
        return _FileStream.IsAsync;
      }
    }
    
    public new long Length
    {
      get
      {
        return _FileStream.Length;
      }
    }
    
    public string Name
    {
      get
      {
        return _FileStream.Name;
      }
    }
    
    public new long Position
    {
      get
      {
        return _FileStream.Position;
      }
      set
      {
        _FileStream.Position = value;
      }
    }
    
    public Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle
    {
      get
      {
        return _FileStream.SafeFileHandle;
      }
    }
    
    public new bool CanTimeout
    {
      get
      {
        return _FileStream.CanTimeout;
      }
    }
    
    public new int ReadTimeout
    {
      get
      {
        return _FileStream.ReadTimeout;
      }
      set
      {
        _FileStream.ReadTimeout = value;
      }
    }
    
    public new int WriteTimeout
    {
      get
      {
        return _FileStream.WriteTimeout;
      }
      set
      {
        _FileStream.WriteTimeout = value;
      }
    }
    
    /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileStream" /> object.</summary>
    /// <returns>An object that encapsulates the access control settings for the file described by the current <see cref="T:System.IO.FileStream" /> object.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The file is closed.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
    /// <filterpriority>1</filterpriority>
    public System.Security.AccessControl.FileSecurity GetAccessControl()
    {
      return _FileStream.GetAccessControl();
    }
    
    /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.FileSecurity" /> object to the file described by the current <see cref="T:System.IO.FileStream" /> object.</summary>
    /// <param name="fileSecurity">An object that describes an ACL entry to apply to the current file.</param>
    /// <exception cref="T:System.ObjectDisposedException">The file is closed.</exception>
    /// <exception cref="T:System.ArgumentNullException">The <paramref name="fileSecurity" /> parameter is null.</exception>
    /// <exception cref="T:System.SystemException">The file could not be found or modified.</exception>
    /// <exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception>
    /// <filterpriority>1</filterpriority>
    public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity)
    {
      _FileStream.SetAccessControl(fileSecurity);
    }
    
    /// <summary>Clears buffers for this stream and causes any buffered data to be written to the file.</summary>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    public new void Flush()
    {
      _FileStream.Flush();
    }
    
    /// <summary>Clears buffers for this stream and causes any buffered data to be written to the file, and also clears all intermediate file buffers.</summary>
    /// <param name="flushToDisk">true to flush all intermediate file buffers; otherwise, false. </param>
    public void Flush(bool flushToDisk)
    {
      _FileStream.Flush(flushToDisk);
    }
    
    /// <summary>Sets the length of this stream to the given value.</summary>
    /// <param name="value">The new length of the stream. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error has occurred. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">Attempted to set the <paramref name="value" /> parameter to less than 0. </exception>
    /// <filterpriority>2</filterpriority>
    public new void SetLength(long value)
    {
      _FileStream.SetLength(value);
    }
    
    /// <summary>Reads a block of bytes from the stream and writes the data in a given buffer.</summary>
    /// <returns>The total number of bytes read into the buffer. This might be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached.</returns>
    /// <param name="array">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1<paramref name=")" /> replaced by the bytes read from the current source. </param>
    /// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed. </param>
    /// <param name="count">The maximum number of bytes to read. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support reading. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />. </exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
    /// <filterpriority>1</filterpriority>
    public new int Read(byte[] array, int offset, int count)
    {
      return _FileStream.Read(array, offset, count);
    }
    
    /// <summary>Sets the current position of this stream to the given value.</summary>
    /// <returns>The new position in the stream.</returns>
    /// <param name="offset">The point relative to <paramref name="origin" /> from which to begin seeking. </param>
    /// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for <paramref name="offset" />, using a value of type <see cref="T:System.IO.SeekOrigin" />. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the FileStream is constructed from a pipe or console output. </exception>
    /// <exception cref="T:System.ArgumentException">Seeking is attempted before the beginning of the stream. </exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
    /// <filterpriority>1</filterpriority>
    public new long Seek(long offset, System.IO.SeekOrigin origin)
    {
      return _FileStream.Seek(offset, origin);
    }
    
    /// <summary>Writes a block of bytes to the file stream.</summary>
    /// <param name="array">The buffer containing data to write to the stream.</param>
    /// <param name="offset">The zero-based byte offset in <paramref name="array" /> from which to begin copying bytes to the stream. </param>
    /// <param name="count">The maximum number of bytes to write. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred. - or -Another thread may have caused an unexpected change in the position of the operating system's file handle. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">The current stream instance does not support writing. </exception>
    /// <filterpriority>1</filterpriority>
    public new void Write(byte[] array, int offset, int count)
    {
      _FileStream.Write(array, offset, count);
    }
    
    /// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary>
    /// <returns>An object that references the asynchronous read.</returns>
    /// <param name="array">The buffer to read data into. </param>
    /// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading. </param>
    /// <param name="numBytes">The maximum number of bytes to read. </param>
    /// <param name="userCallback">The method to be called when the asynchronous read operation is completed. </param>
    /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests. </param>
    /// <exception cref="T:System.ArgumentException">The array length minus <paramref name="offset" /> is less than <paramref name="numBytes" />. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="numBytes" /> is negative. </exception>
    /// <exception cref="T:System.IO.IOException">An asynchronous read was attempted past the end of the file. </exception>
    /// <filterpriority>2</filterpriority>
    public new System.IAsyncResult BeginRead(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject)
    {
      return _FileStream.BeginRead(array, offset, numBytes, userCallback, stateObject);
    }
    
    /// <summary>Waits for the pending asynchronous read operation to complete. (Consider using <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary>
    /// <returns>The number of bytes read from the stream, between 0 and the number of bytes you requested. Streams only return 0 at the end of the stream, otherwise, they should block until at least 1 byte is available.</returns>
    /// <param name="asyncResult">The reference to the pending asynchronous request to wait for. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class. </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///  <see cref="M:System.IO.FileStream.EndRead(System.IAsyncResult)" /> is called multiple times. </exception>
    /// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
    /// <filterpriority>2</filterpriority>
    public new int EndRead(System.IAsyncResult asyncResult)
    {
      return _FileStream.EndRead(asyncResult);
    }
    
    /// <summary>Reads a byte from the file and advances the read position one byte.</summary>
    /// <returns>The byte, cast to an <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    public new int ReadByte()
    {
      return _FileStream.ReadByte();
    }
    
    /// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary>
    /// <returns>An object that references the asynchronous write.</returns>
    /// <param name="array">The buffer containing data to write to the current stream.</param>
    /// <param name="offset">The zero-based byte offset in <paramref name="array" /> at which to begin copying bytes to the current stream.</param>
    /// <param name="numBytes">The maximum number of bytes to write. </param>
    /// <param name="userCallback">The method to be called when the asynchronous write operation is completed. </param>
    /// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous write request from other requests. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="array" /> length minus <paramref name="offset" /> is less than <paramref name="numBytes" />. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="numBytes" /> is negative. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
    /// <filterpriority>2</filterpriority>
    public new System.IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject)
    {
      return _FileStream.BeginWrite(array, offset, numBytes, userCallback, stateObject);
    }
    
    /// <summary>Ends an asynchronous write operation and blocks until the I/O operation is complete. (Consider using <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead; see the Remarks section.)</summary>
    /// <param name="asyncResult">The pending asynchronous I/O request. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class. </exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///  <see cref="M:System.IO.FileStream.EndWrite(System.IAsyncResult)" /> is called multiple times. </exception>
    /// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
    /// <filterpriority>2</filterpriority>
    public new void EndWrite(System.IAsyncResult asyncResult)
    {
      _FileStream.EndWrite(asyncResult);
    }
    
    /// <summary>Writes a byte to the current position in the file stream.</summary>
    /// <param name="value">A byte to write to the stream. </param>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. </exception>
    /// <filterpriority>1</filterpriority>
    public new void WriteByte(byte value)
    {
      _FileStream.WriteByte(value);
    }
    
    /// <summary>Prevents other processes from reading from or writing to the <see cref="T:System.IO.FileStream" />.</summary>
    /// <param name="position">The beginning of the range to lock. The value of this parameter must be equal to or greater than zero (0). </param>
    /// <param name="length">The range to be locked. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="position" /> or <paramref name="length" /> is negative. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The file is closed. </exception>
    /// <exception cref="T:System.IO.IOException">The process cannot access the file because another process has locked a portion of the file.</exception>
    /// <filterpriority>2</filterpriority>
    public void Lock(long position, long length)
    {
      _FileStream.Lock(position, length);
    }
    
    /// <summary>Allows access by other processes to all or part of a file that was previously locked.</summary>
    /// <param name="position">The beginning of the range to unlock. </param>
    /// <param name="length">The range to be unlocked. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="position" /> or <paramref name="length" /> is negative. </exception>
    /// <filterpriority>2</filterpriority>
    public void Unlock(long position, long length)
    {
      _FileStream.Unlock(position, length);
    }
    
    /// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
    /// <param name="buffer">The buffer to write the data into.</param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
    /// <param name="count">The maximum number of bytes to read.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
    public new System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
    {
      return _FileStream.ReadAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests. </summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="buffer">The buffer to write data from. </param>
    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
    /// <param name="count">The maximum number of bytes to write.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
    public new System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
    {
      return _FileStream.WriteAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests. </summary>
    /// <returns>A task that represents the asynchronous flush operation. </returns>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public new System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
    {
      return _FileStream.FlushAsync(cancellationToken);
    }
    
    /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream.</summary>
    /// <returns>A task that represents the asynchronous copy operation.</returns>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
    public new System.Threading.Tasks.Task CopyToAsync(Wrapperator.Interfaces.IO.IStream destination)
    {
      return _FileStream.CopyToAsync(destination == null ? default(System.IO.Stream) : destination._Stream);
    }
    
    /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary>
    /// <returns>A task that represents the asynchronous copy operation.</returns>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 81920.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="buffersize" /> is negative or zero.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
    public new System.Threading.Tasks.Task CopyToAsync(Wrapperator.Interfaces.IO.IStream destination, int bufferSize)
    {
      return _FileStream.CopyToAsync(destination == null ? default(System.IO.Stream) : destination._Stream, bufferSize);
    }
    
    /// <summary>Asynchronously reads the bytes from the current stream and writes them to another stream, using a specified buffer size and cancellation token.</summary>
    /// <returns>A task that represents the asynchronous copy operation.</returns>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero. The default size is 81920.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="buffersize" /> is negative or zero.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
    public new System.Threading.Tasks.Task CopyToAsync(Wrapperator.Interfaces.IO.IStream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
    {
      return _FileStream.CopyToAsync(destination == null ? default(System.IO.Stream) : destination._Stream, bufferSize, cancellationToken);
    }
    
    /// <summary>Reads the bytes from the current stream and writes them to another stream.</summary>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-<paramref name="destination" /> does not support writing.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
    public new void CopyTo(Wrapperator.Interfaces.IO.IStream destination)
    {
      _FileStream.CopyTo(destination == null ? default(System.IO.Stream) : destination._Stream);
    }
    
    /// <summary>Reads the bytes from the current stream and writes them to another stream, using a specified buffer size.</summary>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <param name="bufferSize">The size of the buffer. This value must be greater than zero. The default size is 81920.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="bufferSize" /> is negative or zero.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading.-or-<paramref name="destination" /> does not support writing.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
    public new void CopyTo(Wrapperator.Interfaces.IO.IStream destination, int bufferSize)
    {
      _FileStream.CopyTo(destination == null ? default(System.IO.Stream) : destination._Stream, bufferSize);
    }
    
    /// <summary>Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream. Instead of calling this method, ensure that the stream is properly disposed.</summary>
    /// <filterpriority>1</filterpriority>
    public new void Close()
    {
      _FileStream.Close();
    }
    
    /// <summary>Asynchronously clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
    /// <returns>A task that represents the asynchronous flush operation.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public new System.Threading.Tasks.Task FlushAsync()
    {
      return _FileStream.FlushAsync();
    }
    
    /// <summary>Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
    /// <param name="buffer">The buffer to write the data into.</param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
    /// <param name="count">The maximum number of bytes to read.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation. </exception>
    public new System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count)
    {
      return _FileStream.ReadAsync(buffer, offset, count);
    }
    
    /// <summary>Asynchronously writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="buffer">The buffer to write data from.</param>
    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
    /// <param name="count">The maximum number of bytes to write.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation. </exception>
    public new System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count)
    {
      return _FileStream.WriteAsync(buffer, offset, count);
    }
    
    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
      if (disposing)
      {
        _FileStream.Dispose();
      }
    }
  }
}
