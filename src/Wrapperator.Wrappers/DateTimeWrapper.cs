//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers
{
  
  
  /// <summary>Represents an instant in time, typically expressed as a date and time of day. To browse the .NET Framework source code for this type, see the Reference Source.</summary>
  /// <filterpriority>1</filterpriority>
  public class DateTimeWrapper : Wrapperator.Interfaces.IDateTime
  {
    
    public System.DateTime _DateTime { get; private set; }

    
    internal DateTimeWrapper(System.DateTime dateTime)
    {
      _DateTime = dateTime;
    }
    
    public Wrapperator.Interfaces.IDateTime Date
    {
      get
      {
        return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.Date);
      }
    }
    
    public int Day
    {
      get
      {
        return _DateTime.Day;
      }
    }
    
    public System.DayOfWeek DayOfWeek
    {
      get
      {
        return _DateTime.DayOfWeek;
      }
    }
    
    public int DayOfYear
    {
      get
      {
        return _DateTime.DayOfYear;
      }
    }
    
    public int Hour
    {
      get
      {
        return _DateTime.Hour;
      }
    }
    
    public System.DateTimeKind Kind
    {
      get
      {
        return _DateTime.Kind;
      }
    }
    
    public int Millisecond
    {
      get
      {
        return _DateTime.Millisecond;
      }
    }
    
    public int Minute
    {
      get
      {
        return _DateTime.Minute;
      }
    }
    
    public int Month
    {
      get
      {
        return _DateTime.Month;
      }
    }
    
    public int Second
    {
      get
      {
        return _DateTime.Second;
      }
    }
    
    public long Ticks
    {
      get
      {
        return _DateTime.Ticks;
      }
    }
    
    public System.TimeSpan TimeOfDay
    {
      get
      {
        return _DateTime.TimeOfDay;
      }
    }
    
    public int Year
    {
      get
      {
        return _DateTime.Year;
      }
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the value of the specified <see cref="T:System.TimeSpan" /> to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the time interval represented by <paramref name="value" />.</returns>
    /// <param name="value">A positive or negative time interval. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime Add(System.TimeSpan value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.Add(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of days to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of days represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of whole and fractional days. The <paramref name="value" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddDays(double value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddDays(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of hours to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of hours represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of whole and fractional hours. The <paramref name="value" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddHours(double value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddHours(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of milliseconds to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of milliseconds represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of whole and fractional milliseconds. The <paramref name="value" /> parameter can be negative or positive. Note that this value is rounded to the nearest integer.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddMilliseconds(double value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddMilliseconds(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of minutes to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of minutes represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of whole and fractional minutes. The <paramref name="value" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddMinutes(double value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddMinutes(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of months to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and <paramref name="months" />.</returns>
    /// <param name="months">A number of months. The <paramref name="months" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.-or- <paramref name="months" /> is less than -120,000 or greater than 120,000. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddMonths(int months)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddMonths(months));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of seconds to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of seconds represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of whole and fractional seconds. The <paramref name="value" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddSeconds(double value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddSeconds(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of ticks to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the time represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of 100-nanosecond ticks. The <paramref name="value" /> parameter can be positive or negative. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddTicks(long value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddTicks(value));
    }
    
    /// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of years to the value of this instance.</summary>
    /// <returns>An object whose value is the sum of the date and time represented by this instance and the number of years represented by <paramref name="value" />.</returns>
    /// <param name="value">A number of years. The <paramref name="value" /> parameter can be negative or positive. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///  <paramref name="value" /> or the resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime AddYears(int value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.AddYears(value));
    }
    
    /// <summary>Compares the value of this instance to a specified object that contains a specified <see cref="T:System.DateTime" /> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
    /// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />, or <paramref name="value" /> is null. </returns>
    /// <param name="value">A boxed object to compare, or null. </param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="value" /> is not a <see cref="T:System.DateTime" />. </exception>
    /// <filterpriority>2</filterpriority>
    public int CompareTo(object value)
    {
      return _DateTime.CompareTo(value);
    }
    
    /// <summary>Compares the value of this instance to a specified <see cref="T:System.DateTime" /> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
    /// <returns>A signed number indicating the relative values of this instance and the <paramref name="value" /> parameter.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />. </returns>
    /// <param name="value">The object to compare to the current instance. </param>
    /// <filterpriority>2</filterpriority>
    public int CompareTo(Wrapperator.Interfaces.IDateTime value)
    {
      return _DateTime.CompareTo(value == null ? default(System.DateTime) : ((Wrapperator.Wrappers.DateTimeWrapper)value)._DateTime);
    }
    
    /// <summary>Indicates whether this instance of <see cref="T:System.DateTime" /> is within the daylight saving time range for the current time zone.</summary>
    /// <returns>true if the value of the <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" /> or <see cref="F:System.DateTimeKind.Unspecified" /> and the value of this instance of <see cref="T:System.DateTime" /> is within the daylight saving time range for the local time zone; false if <see cref="P:System.DateTime.Kind" /> is <see cref="F:System.DateTimeKind.Utc" />.</returns>
    /// <filterpriority>2</filterpriority>
    public bool IsDaylightSavingTime()
    {
      return _DateTime.IsDaylightSavingTime();
    }
    
    /// <summary>Serializes the current <see cref="T:System.DateTime" /> object to a 64-bit binary value that subsequently can be used to recreate the <see cref="T:System.DateTime" /> object.</summary>
    /// <returns>A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> and <see cref="P:System.DateTime.Ticks" /> properties. </returns>
    /// <filterpriority>2</filterpriority>
    public long ToBinary()
    {
      return _DateTime.ToBinary();
    }
    
    /// <summary>Subtracts the specified date and time from this instance.</summary>
    /// <returns>A time interval that is equal to the date and time represented by this instance minus the date and time represented by <paramref name="value" />.</returns>
    /// <param name="value">The date and time value to subtract. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public System.TimeSpan Subtract(Wrapperator.Interfaces.IDateTime value)
    {
      return _DateTime.Subtract(value == null ? default(System.DateTime) : ((Wrapperator.Wrappers.DateTimeWrapper)value)._DateTime);
    }
    
    /// <summary>Subtracts the specified duration from this instance.</summary>
    /// <returns>An object that is equal to the date and time represented by this instance minus the time interval represented by <paramref name="value" />.</returns>
    /// <param name="value">The time interval to subtract. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime Subtract(System.TimeSpan value)
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.Subtract(value));
    }
    
    /// <summary>Converts the value of this instance to the equivalent OLE Automation date.</summary>
    /// <returns>A double-precision floating-point number that contains an OLE Automation date equivalent to the value of this instance.</returns>
    /// <exception cref="T:System.OverflowException">The value of this instance cannot be represented as an OLE Automation Date. </exception>
    /// <filterpriority>2</filterpriority>
    public double ToOADate()
    {
      return _DateTime.ToOADate();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to a Windows file time.</summary>
    /// <returns>The value of the current <see cref="T:System.DateTime" /> object expressed as a Windows file time.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC. </exception>
    /// <filterpriority>2</filterpriority>
    public long ToFileTime()
    {
      return _DateTime.ToFileTime();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to a Windows file time.</summary>
    /// <returns>The value of the current <see cref="T:System.DateTime" /> object expressed as a Windows file time.</returns>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC. </exception>
    /// <filterpriority>2</filterpriority>
    public long ToFileTimeUtc()
    {
      return _DateTime.ToFileTimeUtc();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to local time.</summary>
    /// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" />, and whose value is the local time equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented as a <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime ToLocalTime()
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.ToLocalTime());
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent long date string representation.</summary>
    /// <returns>A string that contains the long date string representation of the current <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public string ToLongDateString()
    {
      return _DateTime.ToLongDateString();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent long time string representation.</summary>
    /// <returns>A string that contains the long time string representation of the current <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public string ToLongTimeString()
    {
      return _DateTime.ToLongTimeString();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent short date string representation.</summary>
    /// <returns>A string that contains the short date string representation of the current <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public string ToShortDateString()
    {
      return _DateTime.ToShortDateString();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent short time string representation.</summary>
    /// <returns>A string that contains the short time string representation of the current <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public string ToShortTimeString()
    {
      return _DateTime.ToShortTimeString();
    }
    
    /// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to Coordinated Universal Time (UTC).</summary>
    /// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" />, and whose value is the UTC equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented by a <see cref="T:System.DateTime" /> object.</returns>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IDateTime ToUniversalTime()
    {
      return new Wrapperator.Wrappers.DateTimeWrapper(_DateTime.ToUniversalTime());
    }
    
    /// <summary>Converts the value of this instance to all the string representations supported by the standard date and time format specifiers.</summary>
    /// <returns>A string array where each element is the representation of the value of this instance formatted with one of the standard date and time format specifiers.</returns>
    /// <filterpriority>2</filterpriority>
    public string[] GetDateTimeFormats()
    {
      return _DateTime.GetDateTimeFormats();
    }
    
    /// <summary>Converts the value of this instance to all the string representations supported by the standard date and time format specifiers and the specified culture-specific formatting information.</summary>
    /// <returns>A string array where each element is the representation of the value of this instance formatted with one of the standard date and time format specifiers.</returns>
    /// <param name="provider">An object that supplies culture-specific formatting information about this instance. </param>
    /// <filterpriority>2</filterpriority>
    public string[] GetDateTimeFormats(System.IFormatProvider provider)
    {
      return _DateTime.GetDateTimeFormats(provider);
    }
    
    /// <summary>Converts the value of this instance to all the string representations supported by the specified standard date and time format specifier.</summary>
    /// <returns>A string array where each element is the representation of the value of this instance formatted with the <paramref name="format" /> standard date and time format specifier.</returns>
    /// <param name="format">A standard date and time format string (see Remarks). </param>
    /// <exception cref="T:System.FormatException">
    ///  <paramref name="format" /> is not a valid standard date and time format specifier character.</exception>
    /// <filterpriority>2</filterpriority>
    public string[] GetDateTimeFormats(char format)
    {
      return _DateTime.GetDateTimeFormats(format);
    }
    
    /// <summary>Converts the value of this instance to all the string representations supported by the specified standard date and time format specifier and culture-specific formatting information.</summary>
    /// <returns>A string array where each element is the representation of the value of this instance formatted with one of the standard date and time format specifiers.</returns>
    /// <param name="format">A date and time format string (see Remarks). </param>
    /// <param name="provider">An object that supplies culture-specific formatting information about this instance. </param>
    /// <exception cref="T:System.FormatException">
    ///  <paramref name="format" /> is not a valid standard date and time format specifier character.</exception>
    /// <filterpriority>2</filterpriority>
    public string[] GetDateTimeFormats(char format, System.IFormatProvider provider)
    {
      return _DateTime.GetDateTimeFormats(format, provider);
    }
    
    /// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.DateTime" />.</summary>
    /// <returns>The enumerated constant, <see cref="F:System.TypeCode.DateTime" />.</returns>
    /// <filterpriority>2</filterpriority>
    public System.TypeCode GetTypeCode()
    {
      return _DateTime.GetTypeCode();
    }
  }
}
