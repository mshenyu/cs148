/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiVector3DVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<aiVector3D>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiVector3DVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiVector3DVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiVector3DVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiVector3DVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiVector3DVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (aiVector3D element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public aiVector3D this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(aiVector3D[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(aiVector3D[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, aiVector3D[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<aiVector3D> System.Collections.Generic.IEnumerable<aiVector3D>.GetEnumerator() {
    return new aiVector3DVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new aiVector3DVectorEnumerator(this);
  }

  public aiVector3DVectorEnumerator GetEnumerator() {
    return new aiVector3DVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class aiVector3DVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<aiVector3D>
#endif
  {
    private aiVector3DVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public aiVector3DVectorEnumerator(aiVector3DVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public aiVector3D Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (aiVector3D)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    AssimpPINVOKE.aiVector3DVector_Clear(swigCPtr);
  }

  public void Add(aiVector3D x) {
    AssimpPINVOKE.aiVector3DVector_Add(swigCPtr, aiVector3D.getCPtr(x));
  }

  private uint size() {
    uint ret = AssimpPINVOKE.aiVector3DVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = AssimpPINVOKE.aiVector3DVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    AssimpPINVOKE.aiVector3DVector_reserve(swigCPtr, n);
  }

  public aiVector3DVector() : this(AssimpPINVOKE.new_aiVector3DVector__SWIG_0(), true) {
  }

  public aiVector3DVector(aiVector3DVector other) : this(AssimpPINVOKE.new_aiVector3DVector__SWIG_1(aiVector3DVector.getCPtr(other)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiVector3DVector(int capacity) : this(AssimpPINVOKE.new_aiVector3DVector__SWIG_2(capacity), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  private aiVector3D getitemcopy(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiVector3DVector_getitemcopy(swigCPtr, index);
    aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private aiVector3D getitem(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiVector3DVector_getitem(swigCPtr, index);
    aiVector3D ret = (cPtr == IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, aiVector3D val) {
    AssimpPINVOKE.aiVector3DVector_setitem(swigCPtr, index, aiVector3D.getCPtr(val));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(aiVector3DVector values) {
    AssimpPINVOKE.aiVector3DVector_AddRange(swigCPtr, aiVector3DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiVector3DVector GetRange(int index, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiVector3DVector_GetRange(swigCPtr, index, count);
    aiVector3DVector ret = (cPtr == IntPtr.Zero) ? null : new aiVector3DVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, aiVector3D x) {
    AssimpPINVOKE.aiVector3DVector_Insert(swigCPtr, index, aiVector3D.getCPtr(x));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, aiVector3DVector values) {
    AssimpPINVOKE.aiVector3DVector_InsertRange(swigCPtr, index, aiVector3DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    AssimpPINVOKE.aiVector3DVector_RemoveAt(swigCPtr, index);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    AssimpPINVOKE.aiVector3DVector_RemoveRange(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static aiVector3DVector Repeat(aiVector3D value, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiVector3DVector_Repeat(aiVector3D.getCPtr(value), count);
    aiVector3DVector ret = (cPtr == IntPtr.Zero) ? null : new aiVector3DVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    AssimpPINVOKE.aiVector3DVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    AssimpPINVOKE.aiVector3DVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, aiVector3DVector values) {
    AssimpPINVOKE.aiVector3DVector_SetRange(swigCPtr, index, aiVector3DVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(aiVector3D value) {
    bool ret = AssimpPINVOKE.aiVector3DVector_Contains(swigCPtr, aiVector3D.getCPtr(value));
    return ret;
  }

  public int IndexOf(aiVector3D value) {
    int ret = AssimpPINVOKE.aiVector3DVector_IndexOf(swigCPtr, aiVector3D.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(aiVector3D value) {
    int ret = AssimpPINVOKE.aiVector3DVector_LastIndexOf(swigCPtr, aiVector3D.getCPtr(value));
    return ret;
  }

  public bool Remove(aiVector3D value) {
    bool ret = AssimpPINVOKE.aiVector3DVector_Remove(swigCPtr, aiVector3D.getCPtr(value));
    return ret;
  }

}
