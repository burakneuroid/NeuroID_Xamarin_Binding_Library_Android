//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.extensions']/class[@name='NIDTextExtensionsKt']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/extensions/NIDTextExtensionsKt", DoNotGenerateAcw=true)]
	public sealed partial class NIDTextExtensionsKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/extensions/NIDTextExtensionsKt", typeof (NIDTextExtensionsKt));

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

		internal NIDTextExtensionsKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.extensions']/class[@name='NIDTextExtensionsKt']/method[@name='getSHA256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSHA256", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSHA256 (string obj)
		{
			const string __id = "getSHA256.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_obj = JNIEnv.NewString ((string)obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.extensions']/class[@name='NIDTextExtensionsKt']/method[@name='getSHA256withSalt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSHA256withSalt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSHA256withSalt (string obj)
		{
			const string __id = "getSHA256withSalt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_obj = JNIEnv.NewString ((string)obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

	}
}