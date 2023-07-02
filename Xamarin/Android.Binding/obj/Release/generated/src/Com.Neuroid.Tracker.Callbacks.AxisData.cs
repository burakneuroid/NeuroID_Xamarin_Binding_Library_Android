using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/AxisData", DoNotGenerateAcw=true)]
	public sealed partial class AxisData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/AxisData", typeof (AxisData));

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

		internal AxisData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']/constructor[@name='AxisData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(IFFF)V", "")]
		public unsafe AxisData (int type, float axisX, float axisY, float axisZ) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IFFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (axisX);
				__args [2] = new JniArgumentValue (axisY);
				__args [3] = new JniArgumentValue (axisZ);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe float AxisX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']/method[@name='getAxisX' and count(parameter)=0]"
			[Register ("getAxisX", "()F", "")]
			get {
				const string __id = "getAxisX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AxisY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']/method[@name='getAxisY' and count(parameter)=0]"
			[Register ("getAxisY", "()F", "")]
			get {
				const string __id = "getAxisY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AxisZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']/method[@name='getAxisZ' and count(parameter)=0]"
			[Register ("getAxisZ", "()F", "")]
			get {
				const string __id = "getAxisZ.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='AxisData']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
