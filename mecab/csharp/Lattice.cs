//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace MeCab {

public class Lattice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Lattice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Lattice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Lattice() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          MeCabPINVOKE.delete_Lattice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void clear() {
    MeCabPINVOKE.Lattice_clear(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool is_available() {
    bool ret = MeCabPINVOKE.Lattice_is_available(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node bos_node() {
    global::System.IntPtr cPtr = MeCabPINVOKE.Lattice_bos_node(swigCPtr);
    Node ret = (cPtr == global::System.IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node eos_node() {
    global::System.IntPtr cPtr = MeCabPINVOKE.Lattice_eos_node(swigCPtr);
    Node ret = (cPtr == global::System.IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node end_nodes(uint pos) {
    global::System.IntPtr cPtr = MeCabPINVOKE.Lattice_end_nodes(swigCPtr, pos);
    Node ret = (cPtr == global::System.IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node begin_nodes(uint pos) {
    global::System.IntPtr cPtr = MeCabPINVOKE.Lattice_begin_nodes(swigCPtr, pos);
    Node ret = (cPtr == global::System.IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string sentence() {
    string ret = MeCabPINVOKE.Lattice_sentence(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint size() {
    uint ret = MeCabPINVOKE.Lattice_size(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_Z(double Z) {
    MeCabPINVOKE.Lattice_set_Z(swigCPtr, Z);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double Z() {
    double ret = MeCabPINVOKE.Lattice_Z(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_theta(float theta) {
    MeCabPINVOKE.Lattice_set_theta(swigCPtr, theta);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float theta() {
    float ret = MeCabPINVOKE.Lattice_theta(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool next() {
    bool ret = MeCabPINVOKE.Lattice_next(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int request_type() {
    int ret = MeCabPINVOKE.Lattice_request_type(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool has_request_type(int request_type) {
    bool ret = MeCabPINVOKE.Lattice_has_request_type(swigCPtr, request_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_request_type(int request_type) {
    MeCabPINVOKE.Lattice_set_request_type(swigCPtr, request_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void add_request_type(int request_type) {
    MeCabPINVOKE.Lattice_add_request_type(swigCPtr, request_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void remove_request_type(int request_type) {
    MeCabPINVOKE.Lattice_remove_request_type(swigCPtr, request_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Node newNode() {
    global::System.IntPtr cPtr = MeCabPINVOKE.Lattice_newNode(swigCPtr);
    Node ret = (cPtr == global::System.IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string toString() {
    string ret = MeCabPINVOKE.Lattice_toString__SWIG_0(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string toString(Node node) {
    string ret = MeCabPINVOKE.Lattice_toString__SWIG_1(swigCPtr, Node.getCPtr(node));
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string enumNBestAsString(uint N) {
    string ret = MeCabPINVOKE.Lattice_enumNBestAsString(swigCPtr, N);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool has_constraint() {
    bool ret = MeCabPINVOKE.Lattice_has_constraint(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int boundary_constraint(uint pos) {
    int ret = MeCabPINVOKE.Lattice_boundary_constraint(swigCPtr, pos);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string feature_constraint(uint pos) {
    string ret = MeCabPINVOKE.Lattice_feature_constraint(swigCPtr, pos);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_boundary_constraint(uint pos, int boundary_constraint_type) {
    MeCabPINVOKE.Lattice_set_boundary_constraint(swigCPtr, pos, boundary_constraint_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_feature_constraint(uint begin_pos, uint end_pos, string feature) {
    MeCabPINVOKE.Lattice_set_feature_constraint(swigCPtr, begin_pos, end_pos, feature);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_result(string result) {
    MeCabPINVOKE.Lattice_set_result(swigCPtr, result);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string what() {
    string ret = MeCabPINVOKE.Lattice_what(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_what(string str) {
    MeCabPINVOKE.Lattice_set_what(swigCPtr, str);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Lattice() : this(MeCabPINVOKE.new_Lattice(), true) {
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_sentence(string sentence) {
    MeCabPINVOKE.Lattice_set_sentence(swigCPtr, sentence);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
