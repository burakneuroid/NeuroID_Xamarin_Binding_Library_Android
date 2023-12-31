using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/storage/NIDSharedPrefsDefaults", DoNotGenerateAcw=true)]
	public sealed partial class NIDSharedPrefsDefaults : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults.Companion']"
		[global::Android.Runtime.Register ("com/neuroid/tracker/storage/NIDSharedPrefsDefaults$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/storage/NIDSharedPrefsDefaults$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults.Companion']/constructor[@name='NIDSharedPrefsDefaults.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

			public unsafe int DisplayHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults.Companion']/method[@name='getDisplayHeight' and count(parameter)=0]"
				[Register ("getDisplayHeight", "()I", "")]
				get {
					const string __id = "getDisplayHeight.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe int DisplayWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults.Companion']/method[@name='getDisplayWidth' and count(parameter)=0]"
				[Register ("getDisplayWidth", "()I", "")]
				get {
					const string __id = "getDisplayWidth.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string HexRandomID {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults.Companion']/method[@name='getHexRandomID' and count(parameter)=0]"
				[Register ("getHexRandomID", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getHexRandomID.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/storage/NIDSharedPrefsDefaults", typeof (NIDSharedPrefsDefaults));

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

		internal NIDSharedPrefsDefaults (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/constructor[@name='NIDSharedPrefsDefaults' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NIDSharedPrefsDefaults (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		public unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string IntermediateId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getIntermediateId' and count(parameter)=0]"
			[Register ("getIntermediateId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getIntermediateId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLocale.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string NewSessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getNewSessionID' and count(parameter)=0]"
			[Register ("getNewSessionID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getNewSessionID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPlatform.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSessionID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()I", "")]
			get {
				const string __id = "getTimeZone.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string UserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getUserAgent' and count(parameter)=0]"
			[Register ("getUserAgent", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getUserAgent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getUserId.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='generateUniqueHexId' and count(parameter)=0]"
		[Register ("generateUniqueHexId", "()Ljava/lang/String;", "")]
		public unsafe string GenerateUniqueHexId ()
		{
			const string __id = "generateUniqueHexId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='resetClientId' and count(parameter)=0]"
		[Register ("resetClientId", "()Ljava/lang/String;", "")]
		public unsafe string ResetClientId ()
		{
			const string __id = "resetClientId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.storage']/class[@name='NIDSharedPrefsDefaults']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserId", "(Ljava/lang/String;)V", "")]
		public unsafe void SetUserId (string userId)
		{
			const string __id = "setUserId.(Ljava/lang/String;)V";
			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userId);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

	}
}
