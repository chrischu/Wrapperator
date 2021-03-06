//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Interfaces.Threading
{
  
  
  /// <summary>Creates and controls a thread, sets its priority, and gets its status. </summary>
  /// <filterpriority>1</filterpriority>
  public interface IThread
  {
    
    /// <summary>Provides access to the wrapped instance. Should not be used most of the time.</summary>
    System.Threading.Thread _Thread
    {
      get;
    }
    
    int ManagedThreadId
    {
      get;
    }
    
    System.Threading.ExecutionContext ExecutionContext
    {
      get;
    }
    
    System.Threading.ThreadPriority Priority
    {
      get;
      set;
    }
    
    bool IsAlive
    {
      get;
    }
    
    bool IsThreadPoolThread
    {
      get;
    }
    
    bool IsBackground
    {
      get;
      set;
    }
    
    System.Threading.ThreadState ThreadState
    {
      get;
    }
    
    System.Globalization.CultureInfo CurrentUICulture
    {
      get;
      set;
    }
    
    System.Globalization.CultureInfo CurrentCulture
    {
      get;
      set;
    }
    
    string Name
    {
      get;
      set;
    }
    
    /// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />.</summary>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
    /// <filterpriority>1</filterpriority>
    void Start();
    
    /// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary>
    /// <param name="parameter">An object that contains data to be used by the method the thread executes.</param>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
    /// <exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception>
    /// <filterpriority>1</filterpriority>
    void Start(object parameter);
    
    /// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread while also providing exception information about the thread termination. Calling this method usually terminates the thread.</summary>
    /// <param name="stateInfo">An object that contains application-specific information, such as state, which can be used by the thread being aborted. </param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
    /// <filterpriority>1</filterpriority>
    void Abort(object stateInfo);
    
    /// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
    /// <filterpriority>1</filterpriority>
    void Abort();
    
    /// <summary>Interrupts a thread that is in the WaitSleepJoin thread state.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the appropriate <see cref="T:System.Security.Permissions.SecurityPermission" />. </exception>
    /// <filterpriority>2</filterpriority>
    void Interrupt();
    
    /// <summary>Blocks the calling thread until a thread terminates, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception>
    /// <exception cref="T:System.Threading.ThreadInterruptedException">The thread is interrupted while waiting. </exception>
    /// <filterpriority>1</filterpriority>
    void Join();
    
    /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <returns>true if the thread has terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="millisecondsTimeout" /> parameter has elapsed.</returns>
    /// <param name="millisecondsTimeout">The number of milliseconds to wait for the thread to terminate. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has not been started. </exception>
    /// <filterpriority>1</filterpriority>
    bool Join(int millisecondsTimeout);
    
    /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <returns>true if the thread terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="timeout" /> parameter has elapsed.</returns>
    /// <param name="timeout">A <see cref="T:System.TimeSpan" /> set to the amount of time to wait for the thread to terminate. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception>
    /// <filterpriority>1</filterpriority>
    bool Join(System.TimeSpan timeout);
    
    /// <summary>Turns off automatic cleanup of runtime callable wrappers (RCW) for the current thread. </summary>
    void DisableComObjectEagerCleanup();
    
    /// <summary>Returns an <see cref="T:System.Threading.ApartmentState" /> value indicating the apartment state.</summary>
    /// <returns>One of the <see cref="T:System.Threading.ApartmentState" /> values indicating the apartment state of the managed thread. The default is <see cref="F:System.Threading.ApartmentState.Unknown" />.</returns>
    /// <filterpriority>1</filterpriority>
    System.Threading.ApartmentState GetApartmentState();
    
    /// <summary>Sets the apartment state of a thread before it is started.</summary>
    /// <returns>true if the apartment state is set; otherwise, false.</returns>
    /// <param name="state">The new apartment state.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="state" /> is not a valid apartment state.</exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
    /// <filterpriority>1</filterpriority>
    bool TrySetApartmentState(System.Threading.ApartmentState state);
    
    /// <summary>Sets the apartment state of a thread before it is started.</summary>
    /// <param name="state">The new apartment state.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="state" /> is not a valid apartment state.</exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
    /// <exception cref="T:System.InvalidOperationException">The apartment state has already been initialized.</exception>
    /// <filterpriority>1</filterpriority>
    void SetApartmentState(System.Threading.ApartmentState state);
  }
}
