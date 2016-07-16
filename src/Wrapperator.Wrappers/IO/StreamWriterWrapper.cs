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
  
  
  /// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing characters to a stream in a particular encoding.</summary>
  /// <filterpriority>1</filterpriority>
  public partial class StreamWriterWrapper : Wrapperator.Interfaces.IO.IStreamWriter
  {
    
    private System.IO.StreamWriter _streamWriter;
    
    public StreamWriterWrapper(System.IO.StreamWriter streamWriter)
    {
      _streamWriter = streamWriter;
    }
    
    /// <summary>Closes the current StreamWriter object and the underlying stream.</summary>
    /// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair.</exception>
    /// <filterpriority>1</filterpriority>
    public void Close()
    {
      _streamWriter.Close();
    }
    
    /// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.</summary>
    /// <exception cref="T:System.ObjectDisposedException">The current writer is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error has occurred. </exception>
    /// <exception cref="T:System.Text.EncoderFallbackException">The current encoding does not support displaying half of a Unicode surrogate pair. </exception>
    /// <filterpriority>1</filterpriority>
    public void Flush()
    {
      _streamWriter.Flush();
    }
    
    /// <summary>Clears all buffers for this stream asynchronously and causes any buffered data to be written to the underlying device.</summary>
    /// <returns>A task that represents the asynchronous flush operation.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
    public System.Threading.Tasks.Task FlushAsync()
    {
      return _streamWriter.FlushAsync();
    }
    
    /// <summary>Writes a character to the stream.</summary>
    /// <param name="value">The character to write to the stream. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
    /// <filterpriority>1</filterpriority>
    public void Write(char value)
    {
      _streamWriter.Write(value);
    }
    
    /// <summary>Writes a character array to the stream.</summary>
    /// <param name="buffer">A character array containing the data to write. If <paramref name="buffer" /> is null, nothing is written. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
    /// <filterpriority>1</filterpriority>
    public void Write(char[] buffer)
    {
      _streamWriter.Write(buffer);
    }
    
    /// <summary>Writes a subarray of characters to the stream.</summary>
    /// <param name="buffer">A character array that contains the data to write. </param>
    /// <param name="index">The character position in the buffer at which to start reading data. </param>
    /// <param name="count">The maximum number of characters to write. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
    /// <filterpriority>1</filterpriority>
    public void Write(char[] buffer, int index, int count)
    {
      _streamWriter.Write(buffer, index, count);
    }
    
    /// <summary>Writes a string to the stream.</summary>
    /// <param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written. </param>
    /// <exception cref="T:System.ObjectDisposedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and current writer is closed. </exception>
    /// <exception cref="T:System.NotSupportedException">
    ///  <see cref="P:System.IO.StreamWriter.AutoFlush" /> is true or the <see cref="T:System.IO.StreamWriter" /> buffer is full, and the contents of the buffer cannot be written to the underlying fixed size stream because the <see cref="T:System.IO.StreamWriter" /> is at the end the stream. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>1</filterpriority>
    public void Write(string value)
    {
      _streamWriter.Write(value);
    }
    
    /// <summary>Writes a character to the stream asynchronously.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="value">The character to write to the stream.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
    public System.Threading.Tasks.Task WriteAsync(char value)
    {
      return _streamWriter.WriteAsync(value);
    }
    
    /// <summary>Writes a string to the stream asynchronously.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="value">The string to write to the stream. If <paramref name="value" /> is null, nothing is written.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
    public System.Threading.Tasks.Task WriteAsync(string value)
    {
      return _streamWriter.WriteAsync(value);
    }
    
    /// <summary>Writes a subarray of characters to the stream asynchronously.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="buffer">A character array that contains the data to write.</param>
    /// <param name="index">The character position in the buffer at which to begin reading data.</param>
    /// <param name="count">The maximum number of characters to write.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation. </exception>
    public System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count)
    {
      return _streamWriter.WriteAsync(buffer, index, count);
    }
    
    /// <summary>Writes a line terminator asynchronously to the stream.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
    public System.Threading.Tasks.Task WriteLineAsync()
    {
      return _streamWriter.WriteLineAsync();
    }
    
    /// <summary>Writes a character followed by a line terminator asynchronously to the stream.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="value">The character to write to the stream.</param>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
    public System.Threading.Tasks.Task WriteLineAsync(char value)
    {
      return _streamWriter.WriteLineAsync(value);
    }
    
    /// <summary>Writes a string followed by a line terminator asynchronously to the stream.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="value">The string to write. If the value is null, only a line terminator is written. </param>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation.</exception>
    public System.Threading.Tasks.Task WriteLineAsync(string value)
    {
      return _streamWriter.WriteLineAsync(value);
    }
    
    /// <summary>Writes a subarray of characters followed by a line terminator asynchronously to the stream.</summary>
    /// <returns>A task that represents the asynchronous write operation.</returns>
    /// <param name="buffer">The character array to write data from.</param>
    /// <param name="index">The character position in the buffer at which to start reading data.</param>
    /// <param name="count">The maximum number of characters to write.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream writer is disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The stream writer is currently in use by a previous write operation. </exception>
    public System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count)
    {
      return _streamWriter.WriteLineAsync(buffer, index, count);
    }
    
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _streamWriter.Dispose();
      }
    }
    
    public void Dispose()
    {
      this.Dispose(true);
      System.GC.SuppressFinalize(this);
    }
  }
}
