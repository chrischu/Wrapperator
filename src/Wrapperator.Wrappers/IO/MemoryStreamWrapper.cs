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
  
  
  /// <summary>Creates a stream whose backing store is memory.</summary>
  /// <filterpriority>2</filterpriority>
  public class MemoryStreamWrapper : StreamWrapper, Wrapperator.Interfaces.IO.IMemoryStream
  {
    
    internal System.IO.MemoryStream MemoryStream { get; private set; }

    
    public MemoryStreamWrapper(System.IO.MemoryStream memoryStream) : 
        base(memoryStream)
    {
      MemoryStream = memoryStream;
    }
    
    public new bool CanRead
    {
      get
      {
        return MemoryStream.CanRead;
      }
    }
    
    public new bool CanSeek
    {
      get
      {
        return MemoryStream.CanSeek;
      }
    }
    
    public new bool CanWrite
    {
      get
      {
        return MemoryStream.CanWrite;
      }
    }
    
    public int Capacity
    {
      get
      {
        return MemoryStream.Capacity;
      }
      set
      {
        MemoryStream.Capacity = value;
      }
    }
    
    public new long Length
    {
      get
      {
        return MemoryStream.Length;
      }
    }
    
    public new long Position
    {
      get
      {
        return MemoryStream.Position;
      }
      set
      {
        MemoryStream.Position = value;
      }
    }
    
    public new bool CanTimeout
    {
      get
      {
        return MemoryStream.CanTimeout;
      }
    }
    
    public new int ReadTimeout
    {
      get
      {
        return MemoryStream.ReadTimeout;
      }
      set
      {
        MemoryStream.ReadTimeout = value;
      }
    }
    
    public new int WriteTimeout
    {
      get
      {
        return MemoryStream.WriteTimeout;
      }
      set
      {
        MemoryStream.WriteTimeout = value;
      }
    }
    
    /// <summary>Overrides the <see cref="M:System.IO.Stream.Flush" /> method so that no action is performed.</summary>
    /// <filterpriority>2</filterpriority>
    public new void Flush()
    {
      MemoryStream.Flush();
    }
    
    /// <summary>Asynchronously clears all buffers for this stream, and monitors cancellation requests.</summary>
    /// <returns>A task that represents the asynchronous flush operation.</returns>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public new System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
    {
      return MemoryStream.FlushAsync(cancellationToken);
    }
    
    /// <summary>Returns the array of unsigned bytes from which this stream was created.</summary>
    /// <returns>The byte array from which this stream was created, or the underlying array if a byte array was not provided to the <see cref="T:System.IO.MemoryStream" /> constructor during construction of the current instance.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The MemoryStream instance was not created with a publicly visible buffer. </exception>
    /// <filterpriority>2</filterpriority>
    public byte[] GetBuffer()
    {
      return MemoryStream.GetBuffer();
    }
    
    /// <summary>Reads a block of bytes from the current stream and writes the data to a buffer.</summary>
    /// <returns>The total number of bytes written into the buffer. This can be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached before any bytes are read.</returns>
    /// <param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the characters read from the current stream. </param>
    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin storing data from the current stream.</param>
    /// <param name="count">The maximum number of bytes to read. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public new int Read(byte[] buffer, int offset, int count)
    {
      return MemoryStream.Read(buffer, offset, count);
    }
    
    /// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached. </returns>
    /// <param name="buffer">The buffer to write the data into.</param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
    /// <param name="count">The maximum number of bytes to read.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
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
      return MemoryStream.ReadAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Reads a byte from the current stream.</summary>
    /// <returns>The byte cast to a <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public new int ReadByte()
    {
      return MemoryStream.ReadByte();
    }
    
    /// <summary>Asynchronously reads all the bytes from the current stream and writes them to another stream, using a specified buffer size and cancellation token.</summary>
    /// <returns>A task that represents the asynchronous copy operation.</returns>
    /// <param name="destination">The stream to which the contents of the current stream will be copied.</param>
    /// <param name="bufferSize">The size, in bytes, of the buffer. This value must be greater than zero.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="destination" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="buffersize" /> is negative or zero.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Either the current stream or the destination stream is disposed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current stream does not support reading, or the destination stream does not support writing.</exception>
    public new System.Threading.Tasks.Task CopyToAsync(Wrapperator.Interfaces.IO.IStream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
    {
      return MemoryStream.CopyToAsync(destination == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)destination).Stream, bufferSize, cancellationToken);
    }
    
    /// <summary>Sets the position within the current stream to the specified value.</summary>
    /// <returns>The new position within the stream, calculated by combining the initial reference point and the offset.</returns>
    /// <param name="offset">The new position within the stream. This is relative to the <paramref name="loc" /> parameter, and can be positive or negative. </param>
    /// <param name="loc">A value of type <see cref="T:System.IO.SeekOrigin" />, which acts as the seek reference point. </param>
    /// <exception cref="T:System.IO.IOException">Seeking is attempted before the beginning of the stream. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
    /// <exception cref="T:System.ArgumentException">There is an invalid <see cref="T:System.IO.SeekOrigin" />. -or-<paramref name="offset" /> caused an arithmetic overflow.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public new long Seek(long offset, System.IO.SeekOrigin loc)
    {
      return MemoryStream.Seek(offset, loc);
    }
    
    /// <summary>Sets the length of the current stream to the specified value.</summary>
    /// <param name="value">The value at which to set the length. </param>
    /// <exception cref="T:System.NotSupportedException">The current stream is not resizable and <paramref name="value" /> is larger than the current capacity.-or- The current stream does not support writing. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="value" /> is negative or is greater than the maximum length of the <see cref="T:System.IO.MemoryStream" />, where the maximum length is(<see cref="F:System.Int32.MaxValue" /> - origin), and origin is the index into the underlying buffer at which the stream starts. </exception>
    /// <filterpriority>2</filterpriority>
    public new void SetLength(long value)
    {
      MemoryStream.SetLength(value);
    }
    
    /// <summary>Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position" /> property.</summary>
    /// <returns>A new byte array.</returns>
    /// <filterpriority>2</filterpriority>
    public byte[] ToArray()
    {
      return MemoryStream.ToArray();
    }
    
    /// <summary>Writes a block of bytes to the current stream using data read from a buffer.</summary>
    /// <param name="buffer">The buffer to write data from. </param>
    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> at which to begin copying bytes to the current stream.</param>
    /// <param name="count">The maximum number of bytes to write. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite" />.-or- The current position is closer than <paramref name="count" /> bytes to the end of the stream, and the capacity cannot be modified. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="offset" /> subtracted from the buffer length is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> are negative. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public new void Write(byte[] buffer, int offset, int count)
    {
      MemoryStream.Write(buffer, offset, count);
    }
    
    /// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="buffer">The buffer to write data from.</param>
    /// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
    /// <param name="count">The maximum number of bytes to write.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
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
      return MemoryStream.WriteAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Writes a byte to the current stream at the current position.</summary>
    /// <param name="value">The byte to write. </param>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite" />.-or- The current position is at the end of the stream, and the capacity cannot be modified. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public new void WriteByte(byte value)
    {
      MemoryStream.WriteByte(value);
    }
    
    /// <summary>Writes the entire contents of this memory stream to another stream.</summary>
    /// <param name="stream">The stream to write this memory stream to. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="stream" /> is null. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public void WriteTo(Wrapperator.Interfaces.IO.IStream stream)
    {
      MemoryStream.WriteTo(stream == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)stream).Stream);
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
      return MemoryStream.CopyToAsync(destination == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)destination).Stream);
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
      return MemoryStream.CopyToAsync(destination == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)destination).Stream, bufferSize);
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
      MemoryStream.CopyTo(destination == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)destination).Stream);
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
      MemoryStream.CopyTo(destination == null ? default(System.IO.Stream) : ((Wrapperator.Wrappers.IO.StreamWrapper)destination).Stream, bufferSize);
    }
    
    /// <summary>Closes the current stream and releases any resources (such as sockets and file handles) associated with the current stream. Instead of calling this method, ensure that the stream is properly disposed.</summary>
    /// <filterpriority>1</filterpriority>
    public new void Close()
    {
      MemoryStream.Close();
    }
    
    /// <summary>Asynchronously clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
    /// <returns>A task that represents the asynchronous flush operation.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public new System.Threading.Tasks.Task FlushAsync()
    {
      return MemoryStream.FlushAsync();
    }
    
    /// <summary>Begins an asynchronous read operation. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
    /// <returns>An <see cref="T:System.IAsyncResult" /> that represents the asynchronous read, which could still be pending.</returns>
    /// <param name="buffer">The buffer to read the data into. </param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data read from the stream. </param>
    /// <param name="count">The maximum number of bytes to read. </param>
    /// <param name="callback">An optional asynchronous callback, to be called when the read is complete. </param>
    /// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests. </param>
    /// <exception cref="T:System.IO.IOException">Attempted an asynchronous read past the end of the stream, or a disk error occurs. </exception>
    /// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
    /// <exception cref="T:System.NotSupportedException">The current Stream implementation does not support the read operation. </exception>
    /// <filterpriority>2</filterpriority>
    public new System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
    {
      return MemoryStream.BeginRead(buffer, offset, count, callback, state);
    }
    
    /// <summary>Waits for the pending asynchronous read to complete. (Consider using <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
    /// <returns>The number of bytes read from the stream, between zero (0) and the number of bytes you requested. Streams return zero (0) only at the end of the stream, otherwise, they should block until at least one byte is available.</returns>
    /// <param name="asyncResult">The reference to the pending asynchronous request to finish. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">A handle to the pending read operation is not available.-or-The pending operation does not support reading.</exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///  <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
    /// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
    /// <filterpriority>2</filterpriority>
    public new int EndRead(System.IAsyncResult asyncResult)
    {
      return MemoryStream.EndRead(asyncResult);
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
      return MemoryStream.ReadAsync(buffer, offset, count);
    }
    
    /// <summary>Begins an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
    /// <returns>An IAsyncResult that represents the asynchronous write, which could still be pending.</returns>
    /// <param name="buffer">The buffer to write data from. </param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> from which to begin writing. </param>
    /// <param name="count">The maximum number of bytes to write. </param>
    /// <param name="callback">An optional asynchronous callback, to be called when the write is complete. </param>
    /// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests. </param>
    /// <exception cref="T:System.IO.IOException">Attempted an asynchronous write past the end of the stream, or a disk error occurs. </exception>
    /// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid. </exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed. </exception>
    /// <exception cref="T:System.NotSupportedException">The current Stream implementation does not support the write operation. </exception>
    /// <filterpriority>2</filterpriority>
    public new System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
    {
      return MemoryStream.BeginWrite(buffer, offset, count, callback, state);
    }
    
    /// <summary>Ends an asynchronous write operation. (Consider using <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> instead; see the Remarks section.)</summary>
    /// <param name="asyncResult">A reference to the outstanding asynchronous I/O request. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">A handle to the pending write operation is not available.-or-The pending operation does not support writing.</exception>
    /// <exception cref="T:System.InvalidOperationException">
    ///  <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
    /// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
    /// <filterpriority>2</filterpriority>
    public new void EndWrite(System.IAsyncResult asyncResult)
    {
      MemoryStream.EndWrite(asyncResult);
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
      return MemoryStream.WriteAsync(buffer, offset, count);
    }
    
    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
      if (disposing)
      {
        MemoryStream.Dispose();
      }
    }
  }
}
