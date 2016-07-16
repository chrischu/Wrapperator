//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.IO.Compression
{
  
  
  /// <summary>Provides methods and properties for compressing and decompressing streams by using the Deflate algorithm.</summary>
  public partial interface IDeflateStream : System.IDisposable
  {
    
    /// <summary>Begins an asynchronous read operation. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
    /// <returns>An  object that represents the asynchronous read operation, which could still be pending.</returns>
    /// <param name="array">The byte array to read the data into.</param>
    /// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading data from the stream.</param>
    /// <param name="count">The maximum number of bytes to read.</param>
    /// <param name="asyncCallback">An optional asynchronous callback, to be called when the read operation is complete.</param>
    /// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
    /// <exception cref="T:System.IO.IOException">The method tried to read asynchronously past the end of the stream, or a disk error occurred.</exception>
    /// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the read operation.</exception>
    /// <exception cref="T:System.InvalidOperationException">This call cannot be completed. </exception>
    System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
    
    /// <summary>Begins an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
    /// <returns>An  object that represents the asynchronous write operation, which could still be pending.</returns>
    /// <param name="array">The buffer to write data from.</param>
    /// <param name="offset">The byte offset in <paramref name="buffer" /> to begin writing from.</param>
    /// <param name="count">The maximum number of bytes to write.</param>
    /// <param name="asyncCallback">An optional asynchronous callback, to be called when the write operation is complete.</param>
    /// <param name="asyncState">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
    /// <exception cref="T:System.IO.IOException">The method tried to write asynchronously past the end of the stream, or a disk error occurred.</exception>
    /// <exception cref="T:System.ArgumentException">One or more of the arguments is invalid.</exception>
    /// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
    /// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.IO.Compression.DeflateStream" /> implementation does not support the write operation.</exception>
    /// <exception cref="T:System.InvalidOperationException">The write operation cannot be performed because the stream is closed.</exception>
    System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
    
    /// <summary>Waits for the pending asynchronous read to complete. (Consider using the <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
    /// <returns>The number of bytes read from the stream, between 0 (zero) and the number of bytes you requested. <see cref="T:System.IO.Compression.DeflateStream" /> returns 0 only at the end of the stream; otherwise, it blocks until at least one byte is available.</returns>
    /// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
    /// <exception cref="T:System.SystemException">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
    /// <exception cref="T:System.InvalidOperationException">The end call is invalid because asynchronous read operations for this stream are not yet complete.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is null.</exception>
    int EndRead(System.IAsyncResult asyncResult);
    
    /// <summary>Ends an asynchronous write operation. (Consider using the <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)" /> method instead; see the Remarks section.)</summary>
    /// <param name="asyncResult">A reference to the outstanding asynchronous I/O request.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="asyncResult" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="asyncResult" /> did not originate from a <see cref="M:System.IO.Compression.DeflateStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> method on the current stream.</exception>
    /// <exception cref="T:System.Exception">An exception was thrown during a call to <see cref="M:System.Threading.WaitHandle.WaitOne" />.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">The end write call is invalid.</exception>
    void EndWrite(System.IAsyncResult asyncResult);
    
    /// <summary>The current implementation of this method has no functionality.</summary>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
    void Flush();
    
    /// <summary>Reads a number of decompressed bytes into the specified byte array.</summary>
    /// <returns>The number of bytes that were read into the byte array.</returns>
    /// <param name="array">The array to store decompressed bytes.</param>
    /// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
    /// <param name="count">The maximum number of decompressed bytes to read.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="array" /> is null.</exception>
    /// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.IO.Compression.CompressionMode" /> value was Compress when the object was created.- or - The underlying stream does not support reading.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="offset" /> or <paramref name="count" /> is less than zero.-or-<paramref name="array" /> length minus the index starting point is less than <paramref name="count" />.</exception>
    /// <exception cref="T:System.IO.InvalidDataException">The data is in an invalid format.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
    int Read(byte[] array, int offset, int count);
    
    /// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
    /// <returns>A long value.</returns>
    /// <param name="offset">The location in the stream.</param>
    /// <param name="origin">One of the <see cref="T:System.IO.SeekOrigin" /> values.</param>
    /// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
    long Seek(long offset, System.IO.SeekOrigin origin);
    
    /// <summary>This operation is not supported and always throws a <see cref="T:System.NotSupportedException" />.</summary>
    /// <param name="value">The length of the stream.</param>
    /// <exception cref="T:System.NotSupportedException">This property is not supported on this stream.</exception>
    void SetLength(long value);
    
    /// <summary>Writes compressed bytes to the underlying stream from the specified byte array.</summary>
    /// <param name="array">The buffer that contains the data to compress.</param>
    /// <param name="offset">The byte offset in <paramref name="array" /> from which the bytes will be read.</param>
    /// <param name="count">The maximum number of bytes to write.</param>
    void Write(byte[] array, int offset, int count);
  }
}
