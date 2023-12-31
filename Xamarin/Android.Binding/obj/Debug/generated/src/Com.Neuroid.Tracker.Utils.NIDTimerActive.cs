using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTimerActive']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/utils/NIDTimerActive", DoNotGenerateAcw=true)]
	public sealed partial class NIDTimerActive : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTimerActive']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Neuroid.Tracker.Utils.NIDTimerActive Instance {
			get {
				const string __id = "INSTANCE.Lcom/neuroid/tracker/utils/NIDTimerActive;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Utils.NIDTimerActive> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/utils/NIDTimerActive", typeof (NIDTimerActive));

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

		internal NIDTimerActive (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTimerActive']/method[@name='initTimer' and count(parameter)=0]"
		[Register ("initTimer", "()V", "")]
		public unsafe void InitTimer ()
		{
			const string __id = "initTimer.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDTimerActive']/method[@name='restartTimerActive' and count(parameter)=0]"
		[Register ("restartTimerActive", "()V", "")]
		public unsafe void RestartTimerActive ()
		{
			const string __id = "restartTimerActive.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
