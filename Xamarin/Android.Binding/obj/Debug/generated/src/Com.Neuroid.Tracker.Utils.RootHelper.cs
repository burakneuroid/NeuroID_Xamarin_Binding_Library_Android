using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/utils/RootHelper", DoNotGenerateAcw=true)]
	public sealed partial class RootHelper : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']/field[@name='BINARY_BUSYBOX']"
		[Register ("BINARY_BUSYBOX")]
		[Obsolete ("deprecated")]
		public const string BinaryBusybox = (string) "busybox";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']/field[@name='BINARY_SU']"
		[Register ("BINARY_SU")]
		[Obsolete ("deprecated")]
		public const string BinarySu = (string) "su";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/utils/RootHelper", typeof (RootHelper));

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

		internal RootHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']/constructor[@name='RootHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RootHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsProbablyEmulator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']/method[@name='isProbablyEmulator' and count(parameter)=0]"
			[Register ("isProbablyEmulator", "()Z", "")]
			get {
				const string __id = "isProbablyEmulator.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='RootHelper']/method[@name='isRooted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isRooted", "(Landroid/content/Context;)Z", "")]
		public unsafe bool IsRooted (global::Android.Content.Context context)
		{
			const string __id = "isRooted.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
