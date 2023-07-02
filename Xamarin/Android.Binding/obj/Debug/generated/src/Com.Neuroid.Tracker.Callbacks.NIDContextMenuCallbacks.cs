using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDContextMenuCallbacks", DoNotGenerateAcw=true)]
	public sealed partial class NIDContextMenuCallbacks : global::Java.Lang.Object, global::Android.Views.ActionMode.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDContextMenuCallbacks", typeof (NIDContextMenuCallbacks));

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

		internal NIDContextMenuCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']/constructor[@name='NIDContextMenuCallbacks' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode.Callback']]"
		[Register (".ctor", "(Landroid/view/ActionMode$Callback;)V", "")]
		public unsafe NIDContextMenuCallbacks (global::Android.Views.ActionMode.ICallback actionCallBack) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/ActionMode$Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actionCallBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionCallBack).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (actionCallBack);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']/method[@name='onActionItemClicked' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z", "")]
		public unsafe bool OnActionItemClicked (global::Android.Views.ActionMode action, global::Android.Views.IMenuItem item)
		{
			const string __id = "onActionItemClicked.(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				__args [1] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (action);
				global::System.GC.KeepAlive (item);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']/method[@name='onCreateActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "")]
		public unsafe bool OnCreateActionMode (global::Android.Views.ActionMode action, global::Android.Views.IMenu menu)
		{
			const string __id = "onCreateActionMode.(Landroid/view/ActionMode;Landroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				__args [1] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (action);
				global::System.GC.KeepAlive (menu);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']/method[@name='onDestroyActionMode' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onDestroyActionMode", "(Landroid/view/ActionMode;)V", "")]
		public unsafe void OnDestroyActionMode (global::Android.Views.ActionMode actionMode)
		{
			const string __id = "onDestroyActionMode.(Landroid/view/ActionMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actionMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionMode).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (actionMode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDContextMenuCallbacks']/method[@name='onPrepareActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "")]
		public unsafe bool OnPrepareActionMode (global::Android.Views.ActionMode action, global::Android.Views.IMenu menu)
		{
			const string __id = "onPrepareActionMode.(Landroid/view/ActionMode;Landroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				__args [1] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (action);
				global::System.GC.KeepAlive (menu);
			}
		}

	}
}
