using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTextWatcher']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/utils/NIDTextWatcher", DoNotGenerateAcw=true)]
	public sealed partial class NIDTextWatcher : global::Java.Lang.Object, global::Android.Text.ITextWatcher {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/utils/NIDTextWatcher", typeof (NIDTextWatcher));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal NIDTextWatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTextWatcher']/constructor[@name='NIDTextWatcher' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe NIDTextWatcher (string idName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_idName = JNIEnv.NewString (idName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_idName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_idName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTextWatcher']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "")]
		public unsafe void AfterTextChanged (global::Android.Text.IEditable sequence)
		{
			const string __id = "afterTextChanged.(Landroid/text/Editable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sequence == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sequence).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sequence);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTextWatcher']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "")]
		public unsafe void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			const string __id = "beforeTextChanged.(Ljava/lang/CharSequence;III)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		public void BeforeTextChanged (string p0, int p1, int p2, int p3)
		{
			var jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			BeforeTextChanged (jls_p0, p1, p2, p3);
			jls_p0?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTextWatcher']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "")]
		public unsafe void OnTextChanged (global::Java.Lang.ICharSequence sequence, int start, int before, int count)
		{
			const string __id = "onTextChanged.(Ljava/lang/CharSequence;III)V";
			IntPtr native_sequence = CharSequence.ToLocalJniHandle (sequence);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_sequence);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (before);
				__args [3] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sequence);
				global::System.GC.KeepAlive (sequence);
			}
		}

		public void OnTextChanged (string sequence, int start, int before, int count)
		{
			var jls_sequence = sequence == null ? null : new global::Java.Lang.String (sequence);
			OnTextChanged (jls_sequence, start, before, count);
			jls_sequence?.Dispose ();
		}

	}
}
