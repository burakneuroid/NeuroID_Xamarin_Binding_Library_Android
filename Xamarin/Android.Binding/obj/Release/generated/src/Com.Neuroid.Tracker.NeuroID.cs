using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/NeuroID", DoNotGenerateAcw=true)]
	public sealed partial class NeuroID : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/field[@name='ENDPOINT_PRODUCTION']"
		[Register ("ENDPOINT_PRODUCTION")]
		public const string EndpointProduction = (string) "https://receiver.neuroid.cloud/c";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']"
		[global::Android.Runtime.Register ("com/neuroid/tracker/NeuroID$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/NeuroID$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/constructor[@name='NeuroID.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/constructor[@name='NeuroID.Builder' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
			public unsafe Builder (global::Android.App.Application application, string clientKey) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/app/Application;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientKey = JNIEnv.NewString (clientKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
					__args [1] = new JniArgumentValue (native_clientKey);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientKey);
					global::System.GC.KeepAlive (application);
				}
			}

			public unsafe global::Android.App.Application Application {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='getApplication' and count(parameter)=0]"
				[Register ("getApplication", "()Landroid/app/Application;", "")]
				get {
					const string __id = "getApplication.()Landroid/app/Application;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.App.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='setApplication' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
				[Register ("setApplication", "(Landroid/app/Application;)V", "")]
				set {
					const string __id = "setApplication.(Landroid/app/Application;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			public unsafe string ClientKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='getClientKey' and count(parameter)=0]"
				[Register ("getClientKey", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getClientKey.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='setClientKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setClientKey", "(Ljava/lang/String;)V", "")]
				set {
					const string __id = "setClientKey.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/neuroid/tracker/NeuroID;", "")]
			public unsafe global::Com.Neuroid.Tracker.NeuroID Build ()
			{
				const string __id = "build.()Lcom/neuroid/tracker/NeuroID;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.NeuroID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Landroid/app/Application;", "")]
			public unsafe global::Android.App.Application Component1 ()
			{
				const string __id = "component1.()Landroid/app/Application;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Application> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Builder']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
			[Register ("copy", "(Landroid/app/Application;Ljava/lang/String;)Lcom/neuroid/tracker/NeuroID$Builder;", "")]
			public unsafe global::Com.Neuroid.Tracker.NeuroID.Builder Copy (global::Android.App.Application application, string clientKey)
			{
				const string __id = "copy.(Landroid/app/Application;Ljava/lang/String;)Lcom/neuroid/tracker/NeuroID$Builder;";
				IntPtr native_clientKey = JNIEnv.NewString (clientKey);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
					__args [1] = new JniArgumentValue (native_clientKey);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.NeuroID.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientKey);
					global::System.GC.KeepAlive (application);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Companion']"
		[global::Android.Runtime.Register ("com/neuroid/tracker/NeuroID$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/NeuroID$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Companion']/constructor[@name='NeuroID.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			public unsafe global::Com.Neuroid.Tracker.NeuroID Instance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Companion']/method[@name='getInstance' and count(parameter)=0]"
				[Register ("getInstance", "()Lcom/neuroid/tracker/NeuroID;", "")]
				get {
					const string __id = "getInstance.()Lcom/neuroid/tracker/NeuroID;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Neuroid.Tracker.NeuroID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID.Companion']/method[@name='setNeuroIdInstance' and count(parameter)=1 and parameter[1][@type='com.neuroid.tracker.NeuroID']]"
			[Register ("setNeuroIdInstance", "(Lcom/neuroid/tracker/NeuroID;)V", "")]
			public unsafe void SetNeuroIdInstance (global::Com.Neuroid.Tracker.NeuroID neuroId)
			{
				const string __id = "setNeuroIdInstance.(Lcom/neuroid/tracker/NeuroID;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((neuroId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) neuroId).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (neuroId);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/NeuroID", typeof (NeuroID));

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

		internal NeuroID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/constructor[@name='NeuroID' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
		[Register (".ctor", "(Landroid/app/Application;Ljava/lang/String;Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe NeuroID (global::Android.App.Application application, string clientKey, global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Application;Ljava/lang/String;Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_clientKey = JNIEnv.NewString (clientKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [1] = new JniArgumentValue (native_clientKey);
				__args [2] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientKey);
				global::System.GC.KeepAlive (application);
				global::System.GC.KeepAlive (_constructor_marker);
			}
		}

		public unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getEnvironment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEnvironment", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setEnvironment.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe long FirstTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getFirstTS' and count(parameter)=0]"
			[Register ("getFirstTS", "()J", "")]
			get {
				const string __id = "getFirstTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Boolean ForceStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getForceStart' and count(parameter)=0]"
			[Register ("getForceStart", "()Ljava/lang/Boolean;", "")]
			get {
				const string __id = "getForceStart.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='isStopped' and count(parameter)=0]"
			[Register ("isStopped", "()Z", "")]
			get {
				const string __id = "isStopped.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string SiteId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getSiteId' and count(parameter)=0]"
			[Register ("getSiteId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSiteId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='setSiteId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteId", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setSiteId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string TabId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getTabId' and count(parameter)=0]"
			[Register ("getTabId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTabId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='captureEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("captureEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void CaptureEvent (string eventName, string tgs)
		{
			const string __id = "captureEvent.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_tgs = JNIEnv.NewString (tgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native_tgs);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_tgs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='closeSession' and count(parameter)=0]"
		[Register ("closeSession", "()V", "")]
		public unsafe void CloseSession ()
		{
			const string __id = "closeSession.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='configureWithOptions' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureWithOptions", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureWithOptions (string clientKey, string endpoint)
		{
			const string __id = "configureWithOptions.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientKey = JNIEnv.NewString (clientKey);
			IntPtr native_endpoint = JNIEnv.NewString (endpoint);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientKey);
				__args [1] = new JniArgumentValue (native_endpoint);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientKey);
				JNIEnv.DeleteLocalRef (native_endpoint);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='excludeViewByResourceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("excludeViewByResourceID", "(Ljava/lang/String;)V", "")]
		public unsafe void ExcludeViewByResourceID (string id)
		{
			const string __id = "excludeViewByResourceID.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='formSubmit' and count(parameter)=0]"
		[Register ("formSubmit", "()V", "")]
		public unsafe void FormSubmit ()
		{
			const string __id = "formSubmit.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='formSubmitFailure' and count(parameter)=0]"
		[Register ("formSubmitFailure", "()V", "")]
		public unsafe void FormSubmitFailure ()
		{
			const string __id = "formSubmitFailure.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='formSubmitSuccess' and count(parameter)=0]"
		[Register ("formSubmitSuccess", "()V", "")]
		public unsafe void FormSubmitSuccess ()
		{
			const string __id = "formSubmitSuccess.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='getJsonPayLoad' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getJsonPayLoad", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe string GetJsonPayLoad (global::Android.Content.Context context)
		{
			const string __id = "getJsonPayLoad.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='registerTarget' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View'] and parameter[3][@type='boolean']]"
		[Register ("registerTarget", "(Landroid/app/Activity;Landroid/view/View;Z)V", "")]
		public unsafe void RegisterTarget (global::Android.App.Activity activity, global::Android.Views.View view, bool addListener)
		{
			const string __id = "registerTarget.(Landroid/app/Activity;Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue (addListener);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='resetClientId' and count(parameter)=0]"
		[Register ("resetClientId", "()V", "")]
		public unsafe void ResetClientId ()
		{
			const string __id = "resetClientId.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='resetJsonPayLoad' and count(parameter)=0]"
		[Register ("resetJsonPayLoad", "()V", "")]
		public unsafe void ResetJsonPayLoad ()
		{
			const string __id = "resetJsonPayLoad.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='setForceStart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setForceStart", "(Landroid/app/Activity;)V", "")]
		public unsafe void SetForceStart (global::Android.App.Activity activity)
		{
			const string __id = "setForceStart.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='setNeuroIdInstance' and count(parameter)=1 and parameter[1][@type='com.neuroid.tracker.NeuroID']]"
		[Register ("setNeuroIdInstance", "(Lcom/neuroid/tracker/NeuroID;)V", "")]
		public static unsafe void SetNeuroIdInstance (global::Com.Neuroid.Tracker.NeuroID neuroId)
		{
			const string __id = "setNeuroIdInstance.(Lcom/neuroid/tracker/NeuroID;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((neuroId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) neuroId).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (neuroId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='setScreenName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setScreenName", "(Ljava/lang/String;)V", "")]
		public unsafe void SetScreenName (string screen)
		{
			const string __id = "setScreenName.(Ljava/lang/String;)V";
			IntPtr native_screen = JNIEnv.NewString (screen);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_screen);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_screen);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker']/class[@name='NeuroID']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
