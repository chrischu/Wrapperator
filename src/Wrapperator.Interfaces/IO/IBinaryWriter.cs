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
  
  
  /// <summary>Writes primitive types in binary to a stream and supports writing strings in a specific encoding.</summary>
  /// <filterpriority>2</filterpriority>
  public interface IBinaryWriter : System.IDisposable
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.IO.BinaryWriter _BinaryWriter
    {
      get;
    }
    
    Wrapperator.Interfaces.IO.IStream BaseStream
    {
      get;
    }
    
    /// <summary>Closes the current <see cref="T:System.IO.BinaryWriter" /> and the underlying stream.</summary>
    /// <filterpriority>1</filterpriority>
    void Close();
    
    /// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
    /// <filterpriority>1</filterpriority>
    void Flush();
    
    /// <summary>Sets the position within the current stream.</summary>
    /// <returns>The position with the current stream.</returns>
    /// <param name="offset">A byte offset relative to <paramref name="origin" />. </param>
    /// <param name="origin">A field of <see cref="T:System.IO.SeekOrigin" /> indicating the reference point from which the new position is to be obtained. </param>
    /// <exception cref="T:System.IO.IOException">The file pointer was moved to an invalid location. </exception>
    /// <exception cref="T:System.ArgumentException">The <see cref="T:System.IO.SeekOrigin" /> value is invalid. </exception>
    /// <filterpriority>1</filterpriority>
    long Seek(int offset, System.IO.SeekOrigin origin);
    
    /// <summary>Writes a one-byte Boolean value to the current stream, with 0 representing false and 1 representing true.</summary>
    /// <param name="value">The Boolean value to write (0 or 1). </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(bool value);
    
    /// <summary>Writes an unsigned byte to the current stream and advances the stream position by one byte.</summary>
    /// <param name="value">The unsigned byte to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(byte value);
    
    /// <summary>Writes a signed byte to the current stream and advances the stream position by one byte.</summary>
    /// <param name="value">The signed byte to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(sbyte value);
    
    /// <summary>Writes a byte array to the underlying stream.</summary>
    /// <param name="buffer">A byte array containing the data to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(byte[] buffer);
    
    /// <summary>Writes a region of a byte array to the current stream.</summary>
    /// <param name="buffer">A byte array containing the data to write. </param>
    /// <param name="index">The starting point in <paramref name="buffer" /> at which to begin writing. </param>
    /// <param name="count">The number of bytes to write. </param>
    /// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="buffer" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(byte[] buffer, int index, int count);
    
    /// <summary>Writes a Unicode character to the current stream and advances the current position of the stream in accordance with the Encoding used and the specific characters being written to the stream.</summary>
    /// <param name="ch">The non-surrogate, Unicode character to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="ch" /> is a single surrogate character.</exception>
    /// <filterpriority>1</filterpriority>
    void Write(char ch);
    
    /// <summary>Writes a character array to the current stream and advances the current position of the stream in accordance with the Encoding used and the specific characters being written to the stream.</summary>
    /// <param name="chars">A character array containing the data to write. </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="chars" /> is null. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(char[] chars);
    
    /// <summary>Writes a section of a character array to the current stream, and advances the current position of the stream in accordance with the Encoding used and perhaps the specific characters being written to the stream.</summary>
    /// <param name="chars">A character array containing the data to write. </param>
    /// <param name="index">The starting point in <paramref name="chars" /> from which to begin writing. </param>
    /// <param name="count">The number of characters to write. </param>
    /// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="chars" /> is null. </exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(char[] chars, int index, int count);
    
    /// <summary>Writes an eight-byte floating-point value to the current stream and advances the stream position by eight bytes.</summary>
    /// <param name="value">The eight-byte floating-point value to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(double value);
    
    /// <summary>Writes a decimal value to the current stream and advances the stream position by sixteen bytes.</summary>
    /// <param name="value">The decimal value to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(decimal value);
    
    /// <summary>Writes a two-byte signed integer to the current stream and advances the stream position by two bytes.</summary>
    /// <param name="value">The two-byte signed integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(short value);
    
    /// <summary>Writes a two-byte unsigned integer to the current stream and advances the stream position by two bytes.</summary>
    /// <param name="value">The two-byte unsigned integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(ushort value);
    
    /// <summary>Writes a four-byte signed integer to the current stream and advances the stream position by four bytes.</summary>
    /// <param name="value">The four-byte signed integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(int value);
    
    /// <summary>Writes a four-byte unsigned integer to the current stream and advances the stream position by four bytes.</summary>
    /// <param name="value">The four-byte unsigned integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(uint value);
    
    /// <summary>Writes an eight-byte signed integer to the current stream and advances the stream position by eight bytes.</summary>
    /// <param name="value">The eight-byte signed integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(long value);
    
    /// <summary>Writes an eight-byte unsigned integer to the current stream and advances the stream position by eight bytes.</summary>
    /// <param name="value">The eight-byte unsigned integer to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(ulong value);
    
    /// <summary>Writes a four-byte floating-point value to the current stream and advances the stream position by four bytes.</summary>
    /// <param name="value">The four-byte floating-point value to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(float value);
    
    /// <summary>Writes a length-prefixed string to this stream in the current encoding of the <see cref="T:System.IO.BinaryWriter" />, and advances the current position of the stream in accordance with the encoding used and the specific characters being written to the stream.</summary>
    /// <param name="value">The value to write. </param>
    /// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
    /// <exception cref="T:System.ArgumentNullException">
    ///  <paramref name="value" /> is null. </exception>
    /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception>
    /// <filterpriority>1</filterpriority>
    void Write(string value);
  }
}
