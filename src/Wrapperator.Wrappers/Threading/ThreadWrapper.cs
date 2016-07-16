//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wrapperator.Wrappers.Threading
{
  
  
  /// <summary>Creates and controls a thread, sets its priority, and gets its status. </summary>
  /// <filterpriority>1</filterpriority>
  public partial class ThreadWrapper : Wrapperator.Interfaces.Threading.IThread
  {
    
    private System.Threading.Thread _thread;
    
    public ThreadWrapper(System.Threading.Thread thread)
    {
      _thread = thread;
    }
    
    /// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread while also providing exception information about the thread termination. Calling this method usually terminates the thread.</summary>
    /// <param name="stateInfo">An object that contains application-specific information, such as state, which can be used by the thread being aborted. </param>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
    /// <filterpriority>1</filterpriority>
    public void Abort(object stateInfo)
    {
      _thread.Abort(stateInfo);
    }
    
    /// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
    /// <filterpriority>1</filterpriority>
    public void Abort()
    {
      _thread.Abort();
    }
    
    /// <summary>Allocates an unnamed data slot on all the threads. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <returns>The allocated named data slot on all threads.</returns>
    /// <filterpriority>2</filterpriority>
    public System.LocalDataStoreSlot AllocateDataSlot()
    {
      return System.Threading.Thread.AllocateDataSlot();
    }
    
    /// <summary>Allocates a named data slot on all threads. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <returns>The allocated named data slot on all threads.</returns>
    /// <param name="name">The name of the data slot to be allocated. </param>
    /// <exception cref="T:System.ArgumentException">A named data slot with the specified name already exists.</exception>
    /// <filterpriority>2</filterpriority>
    public System.LocalDataStoreSlot AllocateNamedDataSlot(string name)
    {
      return System.Threading.Thread.AllocateNamedDataSlot(name);
    }
    
    /// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.</summary>
    /// <filterpriority>2</filterpriority>
    public void BeginCriticalRegion()
    {
      System.Threading.Thread.BeginCriticalRegion();
    }
    
    /// <summary>Notifies a host that managed code is about to execute instructions that depend on the identity of the current physical operating system thread.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>2</filterpriority>
    public void BeginThreadAffinity()
    {
      System.Threading.Thread.BeginThreadAffinity();
    }
    
    /// <summary>Turns off automatic cleanup of runtime callable wrappers (RCW) for the current thread. </summary>
    public void DisableComObjectEagerCleanup()
    {
      _thread.DisableComObjectEagerCleanup();
    }
    
    /// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.</summary>
    /// <filterpriority>2</filterpriority>
    public void EndCriticalRegion()
    {
      System.Threading.Thread.EndCriticalRegion();
    }
    
    /// <summary>Notifies a host that managed code has finished executing instructions that depend on the identity of the current physical operating system thread.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
    /// <filterpriority>2</filterpriority>
    public void EndThreadAffinity()
    {
      System.Threading.Thread.EndThreadAffinity();
    }
    
    /// <summary>Eliminates the association between a name and a slot, for all threads in the process. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <param name="name">The name of the data slot to be freed. </param>
    /// <filterpriority>2</filterpriority>
    public void FreeNamedDataSlot(string name)
    {
      System.Threading.Thread.FreeNamedDataSlot(name);
    }
    
    /// <summary>Returns an <see cref="T:System.Threading.ApartmentState" /> value indicating the apartment state.</summary>
    /// <returns>One of the <see cref="T:System.Threading.ApartmentState" /> values indicating the apartment state of the managed thread. The default is <see cref="F:System.Threading.ApartmentState.Unknown" />.</returns>
    /// <filterpriority>1</filterpriority>
    public System.Threading.ApartmentState GetApartmentState()
    {
      return _thread.GetApartmentState();
    }
    
    /// <summary>Retrieves the value from the specified slot on the current thread, within the current thread's current domain. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <returns>The retrieved value.</returns>
    /// <param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> from which to get the value. </param>
    /// <filterpriority>2</filterpriority>
    public object GetData(System.LocalDataStoreSlot slot)
    {
      return System.Threading.Thread.GetData(slot);
    }
    
    /// <summary>Returns the current domain in which the current thread is running.</summary>
    /// <returns>An <see cref="T:System.AppDomain" /> representing the current application domain of the running thread.</returns>
    /// <filterpriority>2</filterpriority>
    public Wrapperator.Interfaces.IAppDomain GetDomain()
    {
      return new Wrapperator.Wrappers.AppDomainWrapper(System.Threading.Thread.GetDomain());
    }
    
    /// <summary>Returns a unique application domain identifier.</summary>
    /// <returns>A 32-bit signed integer uniquely identifying the application domain.</returns>
    /// <filterpriority>2</filterpriority>
    public int GetDomainID()
    {
      return System.Threading.Thread.GetDomainID();
    }
    
    /// <summary>Looks up a named data slot. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <returns>A <see cref="T:System.LocalDataStoreSlot" /> allocated for this thread.</returns>
    /// <param name="name">The name of the local data slot. </param>
    /// <filterpriority>2</filterpriority>
    public System.LocalDataStoreSlot GetNamedDataSlot(string name)
    {
      return System.Threading.Thread.GetNamedDataSlot(name);
    }
    
    /// <summary>Interrupts a thread that is in the WaitSleepJoin thread state.</summary>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the appropriate <see cref="T:System.Security.Permissions.SecurityPermission" />. </exception>
    /// <filterpriority>2</filterpriority>
    public void Interrupt()
    {
      _thread.Interrupt();
    }
    
    /// <summary>Blocks the calling thread until a thread terminates, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception>
    /// <exception cref="T:System.Threading.ThreadInterruptedException">The thread is interrupted while waiting. </exception>
    /// <filterpriority>1</filterpriority>
    public void Join()
    {
      _thread.Join();
    }
    
    /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <returns>true if the thread has terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="millisecondsTimeout" /> parameter has elapsed.</returns>
    /// <param name="millisecondsTimeout">The number of milliseconds to wait for the thread to terminate. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has not been started. </exception>
    /// <filterpriority>1</filterpriority>
    public bool Join(int millisecondsTimeout)
    {
      return _thread.Join(millisecondsTimeout);
    }
    
    /// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
    /// <returns>true if the thread terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="timeout" /> parameter has elapsed.</returns>
    /// <param name="timeout">A <see cref="T:System.TimeSpan" /> set to the amount of time to wait for the thread to terminate. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception>
    /// <filterpriority>1</filterpriority>
    public bool Join(System.TimeSpan timeout)
    {
      return _thread.Join(timeout);
    }
    
    /// <summary>Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that memory accesses prior to the call to <see cref="M:System.Threading.Thread.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Thread.MemoryBarrier" />.</summary>
    /// <filterpriority>2</filterpriority>
    public void MemoryBarrier()
    {
      System.Threading.Thread.MemoryBarrier();
    }
    
    /// <summary>Cancels an <see cref="M:System.Threading.Thread.Abort(System.Object)" /> requested for the current thread.</summary>
    /// <exception cref="T:System.Threading.ThreadStateException">Abort was not invoked on the current thread. </exception>
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required security permission for the current thread. </exception>
    /// <filterpriority>2</filterpriority>
    public void ResetAbort()
    {
      System.Threading.Thread.ResetAbort();
    }
    
    /// <summary>Sets the apartment state of a thread before it is started.</summary>
    /// <param name="state">The new apartment state.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="state" /> is not a valid apartment state.</exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
    /// <exception cref="T:System.InvalidOperationException">The apartment state has already been initialized.</exception>
    /// <filterpriority>1</filterpriority>
    public void SetApartmentState(System.Threading.ApartmentState state)
    {
      _thread.SetApartmentState(state);
    }
    
    /// <summary>Sets the data in the specified slot on the currently running thread, for that thread's current domain. For better performance, use fields marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
    /// <param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> in which to set the value. </param>
    /// <param name="data">The value to be set. </param>
    /// <filterpriority>1</filterpriority>
    public void SetData(System.LocalDataStoreSlot slot, object data)
    {
      System.Threading.Thread.SetData(slot, data);
    }
    
    /// <summary>Suspends the current thread for the specified number of milliseconds.</summary>
    /// <param name="millisecondsTimeout">The number of milliseconds for which the thread is suspended. If the value of the <paramref name="millisecondsTimeout" /> argument is zero, the thread relinquishes the remainder of its time slice to any thread of equal priority that is ready to run. If there are no other threads of equal priority that are ready to run, execution of the current thread is not suspended. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The time-out value is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
    /// <filterpriority>1</filterpriority>
    public void Sleep(int millisecondsTimeout)
    {
      System.Threading.Thread.Sleep(millisecondsTimeout);
    }
    
    /// <summary>Suspends the current thread for the specified amount of time.</summary>
    /// <param name="timeout">The amount of time for which the thread is suspended. If the value of the <paramref name="millisecondsTimeout" /> argument is <see cref="F:System.TimeSpan.Zero" />, the thread relinquishes the remainder of its time slice to any thread of equal priority that is ready to run. If there are no other threads of equal priority that are ready to run, execution of the current thread is not suspended. </param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception>
    /// <filterpriority>1</filterpriority>
    public void Sleep(System.TimeSpan timeout)
    {
      System.Threading.Thread.Sleep(timeout);
    }
    
    /// <summary>Causes a thread to wait the number of times defined by the <paramref name="iterations" /> parameter.</summary>
    /// <param name="iterations">A 32-bit signed integer that defines how long a thread is to wait. </param>
    /// <filterpriority>1</filterpriority>
    public void SpinWait(int iterations)
    {
      System.Threading.Thread.SpinWait(iterations);
    }
    
    /// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />.</summary>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
    /// <filterpriority>1</filterpriority>
    public void Start()
    {
      _thread.Start();
    }
    
    /// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary>
    /// <param name="parameter">An object that contains data to be used by the method the thread executes.</param>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
    /// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
    /// <exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception>
    /// <filterpriority>1</filterpriority>
    public void Start(object parameter)
    {
      _thread.Start(parameter);
    }
    
    /// <summary>Sets the apartment state of a thread before it is started.</summary>
    /// <returns>true if the apartment state is set; otherwise, false.</returns>
    /// <param name="state">The new apartment state.</param>
    /// <exception cref="T:System.ArgumentException">
    ///  <paramref name="state" /> is not a valid apartment state.</exception>
    /// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
    /// <filterpriority>1</filterpriority>
    public bool TrySetApartmentState(System.Threading.ApartmentState state)
    {
      return _thread.TrySetApartmentState(state);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public byte VolatileRead(ref byte address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public short VolatileRead(ref short address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public int VolatileRead(ref int address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public long VolatileRead(ref long address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public sbyte VolatileRead(ref sbyte address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public ushort VolatileRead(ref ushort address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public uint VolatileRead(ref uint address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public System.IntPtr VolatileRead(ref System.IntPtr address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public System.UIntPtr VolatileRead(ref System.UIntPtr address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public ulong VolatileRead(ref ulong address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public float VolatileRead(ref float address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public double VolatileRead(ref double address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Reads the value of a field. The value is the latest written by any processor in a computer, regardless of the number of processors or the state of processor cache.</summary>
    /// <returns>The latest value written to the field by any processor.</returns>
    /// <param name="address">The field to be read. </param>
    /// <filterpriority>1</filterpriority>
    public object VolatileRead(ref object address)
    {
      return System.Threading.Thread.VolatileRead(ref address);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref byte address, byte value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref short address, short value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref int address, int value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref long address, long value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref sbyte address, sbyte value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref ushort address, ushort value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref uint address, uint value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref System.IntPtr address, System.IntPtr value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref System.UIntPtr address, System.UIntPtr value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref ulong address, ulong value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref float address, float value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref double address, double value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Writes a value to a field immediately, so that the value is visible to all processors in the computer.</summary>
    /// <param name="address">The field to which the value is to be written. </param>
    /// <param name="value">The value to be written. </param>
    /// <filterpriority>1</filterpriority>
    public void VolatileWrite(ref object address, object value)
    {
      System.Threading.Thread.VolatileWrite(ref address, value);
    }
    
    /// <summary>Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the thread to yield to.</summary>
    /// <returns>true if the operating system switched execution to another thread; otherwise, false.</returns>
    public bool Yield()
    {
      return System.Threading.Thread.Yield();
    }
  }
}
