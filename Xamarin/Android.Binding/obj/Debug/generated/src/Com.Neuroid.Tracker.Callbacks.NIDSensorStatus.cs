using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorStatus']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDSensorStatus", DoNotGenerateAcw=true)]
	public sealed partial class NIDSensorStatus : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorStatus']/field[@name='AVAILABLE']"
		[Register ("AVAILABLE")]
		public static global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus Available {
			get {
				const string __id = "AVAILABLE.Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorStatus']/field[@name='UNAVAILABLE']"
		[Register ("UNAVAILABLE")]
		public static global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus Unavailable {
			get {
				const string __id = "UNAVAILABLE.Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDSensorStatus", typeof (NIDSensorStatus));

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

		internal NIDSensorStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/neuroid/tracker/callbacks/NIDSensorStatus;", "")]
		public static unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/neuroid/tracker/callbacks/NIDSensorStatus;", "")]
		public static unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus[] Values ()
		{
			const string __id = "values.()[Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus));
			} finally {
			}
		}

	}
}
