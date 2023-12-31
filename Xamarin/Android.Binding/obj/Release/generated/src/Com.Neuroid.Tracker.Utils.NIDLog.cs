using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/utils/NIDLog", DoNotGenerateAcw=true)]
	public sealed partial class NIDLog : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='CHECK_BOX_CHANGE_TAG']"
		[Register ("CHECK_BOX_CHANGE_TAG")]
		public const string CheckBoxChangeTag = (string) "CheckBoxChange";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='CHECK_BOX_ID']"
		[Register ("CHECK_BOX_ID")]
		public const string CheckBoxId = (string) "CheckBoxID:";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Neuroid.Tracker.Utils.NIDLog Instance {
			get {
				const string __id = "INSTANCE.Lcom/neuroid/tracker/utils/NIDLog;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.Utils.NIDLog> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='RADIO_BUTTON_CHANGE_TAG']"
		[Register ("RADIO_BUTTON_CHANGE_TAG")]
		public const string RadioButtonChangeTag = (string) "RadioButtonChange";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='RADIO_BUTTON_ID']"
		[Register ("RADIO_BUTTON_ID")]
		public const string RadioButtonId = (string) "RadioButtonID:";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='SLIDER_CHANGE_TAG']"
		[Register ("SLIDER_CHANGE_TAG")]
		public const string SliderChangeTag = (string) "SliderChange";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/field[@name='SLIDER_ID']"
		[Register ("SLIDER_ID")]
		public const string SliderId = (string) "SliderID:";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/utils/NIDLog", typeof (NIDLog));

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

		internal NIDLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void D (string tag, string msg)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void E (string tag, string msg)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void I (string tag, string msg)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void V (string tag, string msg)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.utils']/class[@name='NIDLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void W (string tag, string msg)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
