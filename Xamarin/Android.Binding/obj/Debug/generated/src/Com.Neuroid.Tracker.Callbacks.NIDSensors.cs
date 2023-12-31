using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDSensors", DoNotGenerateAcw=true)]
	public sealed partial class NIDSensors : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDSensors", typeof (NIDSensors));

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

		internal NIDSensors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/constructor[@name='NIDSensors' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NIDSensors () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/constructor[@name='NIDSensors' and count(parameter)=2 and parameter[1][@type='com.neuroid.tracker.callbacks.NIDSensorData'] and parameter[2][@type='com.neuroid.tracker.callbacks.NIDSensorData']]"
		[Register (".ctor", "(Lcom/neuroid/tracker/callbacks/NIDSensorData;Lcom/neuroid/tracker/callbacks/NIDSensorData;)V", "")]
		public unsafe NIDSensors (global::Com.Neuroid.Tracker.Callbacks.NIDSensorData gyroscopeData, global::Com.Neuroid.Tracker.Callbacks.NIDSensorData accelerometer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/neuroid/tracker/callbacks/NIDSensorData;Lcom/neuroid/tracker/callbacks/NIDSensorData;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gyroscopeData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gyroscopeData).Handle);
				__args [1] = new JniArgumentValue ((accelerometer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accelerometer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gyroscopeData);
				global::System.GC.KeepAlive (accelerometer);
			}
		}

		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData Accelerometer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='getAccelerometer' and count(parameter)=0]"
			[Register ("getAccelerometer", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
			get {
				const string __id = "getAccelerometer.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='setAccelerometer' and count(parameter)=1 and parameter[1][@type='com.neuroid.tracker.callbacks.NIDSensorData']]"
			[Register ("setAccelerometer", "(Lcom/neuroid/tracker/callbacks/NIDSensorData;)V", "")]
			set {
				const string __id = "setAccelerometer.(Lcom/neuroid/tracker/callbacks/NIDSensorData;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData GyroscopeData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='getGyroscopeData' and count(parameter)=0]"
			[Register ("getGyroscopeData", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
			get {
				const string __id = "getGyroscopeData.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='setGyroscopeData' and count(parameter)=1 and parameter[1][@type='com.neuroid.tracker.callbacks.NIDSensorData']]"
			[Register ("setGyroscopeData", "(Lcom/neuroid/tracker/callbacks/NIDSensorData;)V", "")]
			set {
				const string __id = "setGyroscopeData.(Lcom/neuroid/tracker/callbacks/NIDSensorData;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData Component1 ()
		{
			const string __id = "component1.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData Component2 ()
		{
			const string __id = "component2.()Lcom/neuroid/tracker/callbacks/NIDSensorData;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensors']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='com.neuroid.tracker.callbacks.NIDSensorData'] and parameter[2][@type='com.neuroid.tracker.callbacks.NIDSensorData']]"
		[Register ("copy", "(Lcom/neuroid/tracker/callbacks/NIDSensorData;Lcom/neuroid/tracker/callbacks/NIDSensorData;)Lcom/neuroid/tracker/callbacks/NIDSensors;", "")]
		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensors Copy (global::Com.Neuroid.Tracker.Callbacks.NIDSensorData gyroscopeData, global::Com.Neuroid.Tracker.Callbacks.NIDSensorData accelerometer)
		{
			const string __id = "copy.(Lcom/neuroid/tracker/callbacks/NIDSensorData;Lcom/neuroid/tracker/callbacks/NIDSensorData;)Lcom/neuroid/tracker/callbacks/NIDSensors;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((gyroscopeData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gyroscopeData).Handle);
				__args [1] = new JniArgumentValue ((accelerometer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accelerometer).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensors> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (gyroscopeData);
				global::System.GC.KeepAlive (accelerometer);
			}
		}

	}
}
