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
  public partial class MemoryStreamWrapper : Wrapperator.Interfaces.IO.IMemoryStream
  {
    
    private System.IO.MemoryStream _memoryStream;
    
    public MemoryStreamWrapper(System.IO.MemoryStream memoryStream)
    {
      _memoryStream = memoryStream;
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
    public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
    {
      return _memoryStream.CopyToAsync(destination, bufferSize, cancellationToken);
    }
    
    /// <summary>Overrides the <see cref="M:System.IO.Stream.Flush" /> method so that no action is performed.</summary>
    /// <filterpriority>2</filterpriority>
    public void Flush()
    {
      _memoryStream.Flush();
    }
    
    /// <summary>Asynchronously clears all buffers for this stream, and monitors cancellation requests.</summary>
    /// <returns>A task that represents the asynchronous flush operation.</returns>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
    {
      return _memoryStream.FlushAsync(cancellationToken);
    }
    
    /// <summary>Returns the array of unsigned bytes from which this stream was created.</summary>
    /// <returns>The byte array from which this stream was created, or the underlying array if a byte array was not provided to the <see cref="T:System.IO.MemoryStream" /> constructor during construction of the current instance.</returns>
    /// <exception cref="T:System.UnauthorizedAccessException">The MemoryStream instance was not created with a publicly visible buffer. </exception>
    /// <filterpriority>2</filterpriority>
    public byte[] GetBuffer()
    {
      return _memoryStream.GetBuffer();
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
    public int Read(byte[] buffer, int offset, int count)
    {
      return _memoryStream.Read(buffer, offset, count);
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
    public System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
    {
      return _memoryStream.ReadAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Reads a byte from the current stream.</summary>
    /// <returns>The byte cast to a <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public int ReadByte()
    {
      return _memoryStream.ReadByte();
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
    public long Seek(long offset, System.IO.SeekOrigin loc)
    {
      return _memoryStream.Seek(offset, loc);
    }
    
    /// <summary>Sets the length of the current stream to the specified value.</summary>
    /// <param name="value">The value at which to set the length. </param>
    /// <exception cref="T:System.NotSupportedException">The current stream is not resizable and <paramref name="value" /> is larger than the current capacity.-or- The current stream does not support writing. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="value" /> is negative or is greater than the maximum length of the <see cref="T:System.IO.MemoryStream" />, where the maximum length is(<see cref="F:System.Int32.MaxValue" /> - origin), and origin is the index into the underlying buffer at which the stream starts. </exception>
    /// <filterpriority>2</filterpriority>
    public void SetLength(long value)
    {
      _memoryStream.SetLength(value);
    }
    
    /// <summary>Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position" /> property.</summary>
    /// <returns>A new byte array.</returns>
    /// <filterpriority>2</filterpriority>
    public byte[] ToArray()
    {
      return _memoryStream.ToArray();
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
    public void Write(byte[] buffer, int offset, int count)
    {
      _memoryStream.Write(buffer, offset, count);
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
    public System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
    {
      return _memoryStream.WriteAsync(buffer, offset, count, cancellationToken);
    }
    
    /// <summary>Writes a byte to the current stream at the current position.</summary>
    /// <param name="value">The byte to write. </param>
    /// <exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite" />.-or- The current position is at the end of the stream, and the capacity cannot be modified. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public void WriteByte(byte value)
    {
      _memoryStream.WriteByte(value);
    }
    
    /// <summary>Writes the entire contents of this memory stream to another stream.</summary>
    /// <param name="stream">The stream to write this memory stream to. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="stream" /> is null. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception>
    /// <filterpriority>2</filterpriority>
    public void WriteTo(System.IO.Stream stream)
    {
      _memoryStream.WriteTo(stream);
    }
    
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _memoryStream.Dispose();
      }
    }
    
    public void Dispose()
    {
      this.Dispose(true);
      System.GC.SuppressFinalize(this);
    }
  }
}
