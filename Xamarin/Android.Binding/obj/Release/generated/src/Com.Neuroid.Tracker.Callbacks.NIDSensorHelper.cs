using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDSensorHelper", DoNotGenerateAcw=true)]
	public sealed partial class NIDSensorHelper : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Neuroid.Tracker.Callbacks.NIDSensorHelper Instance {
			get {
				const string __id = "INSTANCE.Lcom/neuroid/tracker/callbacks/NIDSensorHelper;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorHelper> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDSensorHelper", typeof (NIDSensorHelper));

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

		internal NIDSensorHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData ValuesAccel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/method[@name='getValuesAccel' and count(parameter)=0]"
			[Register ("getValuesAccel", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
			get {
				const string __id = "getValuesAccel.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData ValuesGyro {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/method[@name='getValuesGyro' and count(parameter)=0]"
			[Register ("getValuesGyro", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
			get {
				const string __id = "getValuesGyro.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/method[@name='initSensorHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initSensorHelper", "(Landroid/content/Context;)V", "")]
		public unsafe void InitSensorHelper (global::Android.Content.Context context)
		{
			const string __id = "initSensorHelper.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/method[@name='restartSensors' and count(parameter)=0]"
		[Register ("restartSensors", "()V", "")]
		public unsafe void RestartSensors ()
		{
			const string __id = "restartSensors.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorHelper']/method[@name='stopSensors' and count(parameter)=0]"
		[Register ("stopSensors", "()V", "")]
		public unsafe void StopSensors ()
		{
			const string __id = "stopSensors.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
