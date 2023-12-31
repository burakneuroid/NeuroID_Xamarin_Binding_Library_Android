using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorGenListener']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDSensorGenListener", DoNotGenerateAcw=true)]
	public sealed partial class NIDSensorGenListener : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDSensorGenListener", typeof (NIDSensorGenListener));

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

		internal NIDSensorGenListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorGenListener']/constructor[@name='NIDSensorGenListener' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.functions.Function1&lt;? super com.neuroid.tracker.callbacks.AxisData, kotlin.Unit&gt;']]"
		[Register (".ctor", "(Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe NIDSensorGenListener (global::Kotlin.Jvm.Functions.IFunction1 @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkotlin/jvm/functions/Function1;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		public unsafe global::Kotlin.Jvm.Functions.IFunction1 Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorGenListener']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lkotlin/jvm/functions/Function1;", "")]
			get {
				const string __id = "getCallback.()Lkotlin/jvm/functions/Function1;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorGenListener']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "")]
		public unsafe void OnAccuracyChanged (global::Android.Hardware.Sensor sensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus accuracy)
		{
			const string __id = "onAccuracyChanged.(Landroid/hardware/Sensor;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sensor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensor).Handle);
				__args [1] = new JniArgumentValue ((int) accuracy);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sensor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDSensorGenListener']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "")]
		public unsafe void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			const string __id = "onSensorChanged.(Landroid/hardware/SensorEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
