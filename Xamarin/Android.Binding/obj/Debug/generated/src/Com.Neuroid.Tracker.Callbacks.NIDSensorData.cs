using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDSensorData", DoNotGenerateAcw=true)]
	public sealed partial class NIDSensorData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDSensorData", typeof (NIDSensorData));

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

		internal NIDSensorData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/constructor[@name='NIDSensorData' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.neuroid.tracker.callbacks.NIDSensorStatus'] and parameter[3][@type='java.lang.Float'] and parameter[4][@type='java.lang.Float'] and parameter[5][@type='java.lang.Float']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/neuroid/tracker/callbacks/NIDSensorStatus;Ljava/lang/Float;Ljava/lang/Float;Ljava/lang/Float;)V", "")]
		public unsafe NIDSensorData (string name, global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus status, global::Java.Lang.Float axisX, global::Java.Lang.Float axisY, global::Java.Lang.Float axisZ) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/neuroid/tracker/callbacks/NIDSensorStatus;Ljava/lang/Float;Ljava/lang/Float;Ljava/lang/Float;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [2] = new JniArgumentValue ((axisX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisX).Handle);
				__args [3] = new JniArgumentValue ((axisY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisY).Handle);
				__args [4] = new JniArgumentValue ((axisZ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisZ).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (status);
				global::System.GC.KeepAlive (axisX);
				global::System.GC.KeepAlive (axisY);
				global::System.GC.KeepAlive (axisZ);
			}
		}

		public unsafe global::Java.Lang.Float AxisX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='getAxisX' and count(parameter)=0]"
			[Register ("getAxisX", "()Ljava/lang/Float;", "")]
			get {
				const string __id = "getAxisX.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='setAxisX' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setAxisX", "(Ljava/lang/Float;)V", "")]
			set {
				const string __id = "setAxisX.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Java.Lang.Float AxisY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='getAxisY' and count(parameter)=0]"
			[Register ("getAxisY", "()Ljava/lang/Float;", "")]
			get {
				const string __id = "getAxisY.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='setAxisY' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setAxisY", "(Ljava/lang/Float;)V", "")]
			set {
				const string __id = "setAxisY.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe global::Java.Lang.Float AxisZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='getAxisZ' and count(parameter)=0]"
			[Register ("getAxisZ", "()Ljava/lang/Float;", "")]
			get {
				const string __id = "getAxisZ.()Ljava/lang/Float;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='setAxisZ' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("setAxisZ", "(Ljava/lang/Float;)V", "")]
			set {
				const string __id = "setAxisZ.(Ljava/lang/Float;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/neuroid/tracker/callbacks/NIDSensorStatus;", "")]
			get {
				const string __id = "getStatus.()Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.neuroid.tracker.callbacks.NIDSensorStatus']]"
			[Register ("setStatus", "(Lcom/neuroid/tracker/callbacks/NIDSensorStatus;)V", "")]
			set {
				const string __id = "setStatus.(Lcom/neuroid/tracker/callbacks/NIDSensorStatus;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lcom/neuroid/tracker/callbacks/NIDSensorStatus;", "")]
		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus Component2 ()
		{
			const string __id = "component2.()Lcom/neuroid/tracker/callbacks/NIDSensorStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/Float;", "")]
		public unsafe global::Java.Lang.Float Component3 ()
		{
			const string __id = "component3.()Ljava/lang/Float;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/Float;", "")]
		public unsafe global::Java.Lang.Float Component4 ()
		{
			const string __id = "component4.()Ljava/lang/Float;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/Float;", "")]
		public unsafe global::Java.Lang.Float Component5 ()
		{
			const string __id = "component5.()Ljava/lang/Float;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorData']/method[@name='copy' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.neuroid.tracker.callbacks.NIDSensorStatus'] and parameter[3][@type='java.lang.Float'] and parameter[4][@type='java.lang.Float'] and parameter[5][@type='java.lang.Float']]"
		[Register ("copy", "(Ljava/lang/String;Lcom/neuroid/tracker/callbacks/NIDSensorStatus;Ljava/lang/Float;Ljava/lang/Float;Ljava/lang/Float;)Lcom/neuroid/tracker/callbacks/NIDSensorData;", "")]
		public unsafe global::Com.Neuroid.Tracker.Callbacks.NIDSensorData Copy (string name, global::Com.Neuroid.Tracker.Callbacks.NIDSensorStatus status, global::Java.Lang.Float axisX, global::Java.Lang.Float axisY, global::Java.Lang.Float axisZ)
		{
			const string __id = "copy.(Ljava/lang/String;Lcom/neuroid/tracker/callbacks/NIDSensorStatus;Ljava/lang/Float;Ljava/lang/Float;Ljava/lang/Float;)Lcom/neuroid/tracker/callbacks/NIDSensorData;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [2] = new JniArgumentValue ((axisX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisX).Handle);
				__args [3] = new JniArgumentValue ((axisY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisY).Handle);
				__args [4] = new JniArgumentValue ((axisZ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axisZ).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Callbacks.NIDSensorData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (status);
				global::System.GC.KeepAlive (axisX);
				global::System.GC.KeepAlive (axisY);
				global::System.GC.KeepAlive (axisZ);
			}
		}

	}
}
