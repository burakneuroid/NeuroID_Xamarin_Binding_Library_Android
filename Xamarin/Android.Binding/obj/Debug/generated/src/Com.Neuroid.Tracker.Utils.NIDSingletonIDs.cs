using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDSingletonIDs']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/utils/NIDSingletonIDs", DoNotGenerateAcw=true)]
	public sealed partial class NIDSingletonIDs : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDSingletonIDs']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Neuroid.Tracker.Utils.NIDSingletonIDs Instance {
			get {
				const string __id = "INSTANCE.Lcom/neuroid/tracker/utils/NIDSingletonIDs;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Utils.NIDSingletonIDs> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/utils/NIDSingletonIDs", typeof (NIDSingletonIDs));

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

		internal NIDSingletonIDs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Salt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDSingletonIDs']/method[@name='getSalt' and count(parameter)=0]"
			[Register ("getSalt", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSalt.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDSingletonIDs']/method[@name='updateSalt' and count(parameter)=0]"
		[Register ("updateSalt", "()V", "")]
		public unsafe void UpdateSalt ()
		{
			const string __id = "updateSalt.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
