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
  
  
  /// <summary>Represents a reader that can read a sequential series of characters.</summary>
  /// <filterpriority>2</filterpriority>
  public partial class TextReaderWrapper : Wrapperator.Interfaces.IO.ITextReader
  {
    
    private System.IO.TextReader _textReader;
    
    public TextReaderWrapper(System.IO.TextReader textReader)
    {
      _textReader = textReader;
    }
    
    /// <summary>Closes the <see cref="T:System.IO.TextReader" /> and releases any system resources associated with the TextReader.</summary>
    /// <filterpriority>1</filterpriority>
    public void Close()
    {
      _textReader.Close();
    }
    
    /// <summary>Reads the next character without changing the state of the reader or the character source. Returns the next available character without actually reading it from the reader.</summary>
    /// <returns>An integer representing the next character to be read, or -1 if no more characters are available or the reader does not support seeking.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>1</filterpriority>
    public int Peek()
    {
      return _textReader.Peek();
    }
    
    /// <summary>Reads the next character from the text reader and advances the character position by one character.</summary>
    /// <returns>The next character from the text reader, or -1 if no more characters are available. The default implementation returns -1.</returns>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>1</filterpriority>
    public int Read()
    {
      return _textReader.Read();
    }
    
    /// <summary>Reads a specified maximum number of characters from the current reader and writes the data to a buffer, beginning at the specified index.</summary>
    /// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether the data is available within the reader. This method returns 0 (zero) if it is called when no more characters are left to read.</returns>
    /// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source. </param>
    /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing. </param>
    /// <param name="count">The maximum number of characters to read. If the end of the reader is reached before the specified number of characters is read into the buffer, the method returns. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>1</filterpriority>
    public int Read(char[] buffer, int index, int count)
    {
      return _textReader.Read(buffer, index, count);
    }
    
    /// <summary>Reads a specified maximum number of characters from the current text reader asynchronously and writes the data to a buffer, beginning at the specified index. </summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the text has been reached.</returns>
    /// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
    /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
    /// <param name="count">The maximum number of characters to read. If the end of the text is reached before the specified number of characters is read into the buffer, the current method returns.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
    public System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count)
    {
      return _textReader.ReadAsync(buffer, index, count);
    }
    
    /// <summary>Reads a specified maximum number of characters from the current text reader and writes the data to a buffer, beginning at the specified index.</summary>
    /// <returns>The number of characters that have been read. The number will be less than or equal to <paramref name="count" />, depending on whether all input characters have been read.</returns>
    /// <param name="buffer">When this method returns, this parameter contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> -1) replaced by the characters read from the current source. </param>
    /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
    /// <param name="count">The maximum number of characters to read. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>2</filterpriority>
    public int ReadBlock(char[] buffer, int index, int count)
    {
      return _textReader.ReadBlock(buffer, index, count);
    }
    
    /// <summary>Reads a specified maximum number of characters from the current text reader asynchronously and writes the data to a buffer, beginning at the specified index.</summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the text has been reached.</returns>
    /// <param name="buffer">When this method returns, contains the specified character array with the values between <paramref name="index" /> and (<paramref name="index" /> + <paramref name="count" /> - 1) replaced by the characters read from the current source.</param>
    /// <param name="index">The position in <paramref name="buffer" /> at which to begin writing.</param>
    /// <param name="count">The maximum number of characters to read. If the end of the text is reached before the specified number of characters is read into the buffer, the current method returns.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null.</exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
    /// <exception cref="T:System.ArgumentException">The sum of <paramref name="index" /> and <paramref name="count" /> is larger than the buffer length.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
    public System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count)
    {
      return _textReader.ReadBlockAsync(buffer, index, count);
    }
    
    /// <summary>Reads a line of characters from the text reader and returns the data as a string.</summary>
    /// <returns>The next line from the reader, or null if all characters have been read.</returns>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
    /// <filterpriority>1</filterpriority>
    public string ReadLine()
    {
      return _textReader.ReadLine();
    }
    
    /// <summary>Reads a line of characters asynchronously and returns the data as a string. </summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the next line from the text reader, or is null if all of the characters have been read. </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
    public System.Threading.Tasks.Task<string> ReadLineAsync()
    {
      return _textReader.ReadLineAsync();
    }
    
    /// <summary>Reads all characters from the current position to the end of the text reader and returns them as one string.</summary>
    /// <returns>A string that contains all characters from the current position to the end of the text reader.</returns>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextReader" /> is closed. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line is larger than <see cref="F:System.Int32.MaxValue" /></exception>
    /// <filterpriority>1</filterpriority>
    public string ReadToEnd()
    {
      return _textReader.ReadToEnd();
    }
    
    /// <summary>Reads all characters from the current position to the end of the text reader asynchronously and returns them as one string.</summary>
    /// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains a string with the characters from the current position to the end of the text reader. </returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
    /// <exception cref="T:System.ObjectDisposedException">The text reader has been disposed.</exception>
    /// <exception cref="T:System.InvalidOperationException">The reader is currently in use by a previous read operation. </exception>
    public System.Threading.Tasks.Task<string> ReadToEndAsync()
    {
      return _textReader.ReadToEndAsync();
    }
    
    /// <summary>Creates a thread-safe wrapper around the specified TextReader.</summary>
    /// <returns>A thread-safe <see cref="T:System.IO.TextReader" />.</returns>
    /// <param name="reader">The TextReader to synchronize. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="reader" /> is null. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IO.ITextReader Synchronized(System.IO.TextReader reader)
    {
      return new Wrapperator.Wrappers.IO.TextReaderWrapper(System.IO.TextReader.Synchronized(reader));
    }
    
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        _textReader.Dispose();
      }
    }
    
    public void Dispose()
    {
      this.Dispose(true);
      System.GC.SuppressFinalize(this);
    }
  }
}