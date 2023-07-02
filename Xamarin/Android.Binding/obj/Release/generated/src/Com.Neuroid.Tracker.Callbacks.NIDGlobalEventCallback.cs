using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neuroid.Tracker.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']"
	[global::Android.Runtime.Register ("com/neuroid/tracker/callbacks/NIDGlobalEventCallback", DoNotGenerateAcw=true)]
	public sealed partial class NIDGlobalEventCallback : global::Java.Lang.Object, global::Android.Views.ViewTreeObserver.IOnGlobalFocusChangeListener, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, global::Android.Views.Window.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neuroid/tracker/callbacks/NIDGlobalEventCallback", typeof (NIDGlobalEventCallback));

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

		internal NIDGlobalEventCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchGenericMotionEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", "")]
		public unsafe bool DispatchGenericMotionEvent (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "dispatchGenericMotionEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (motionEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "")]
		public unsafe bool DispatchKeyEvent (global::Android.Views.KeyEvent keyEvent)
		{
			const string __id = "dispatchKeyEvent.(Landroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (keyEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchKeyShortcutEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", "")]
		public unsafe bool DispatchKeyShortcutEvent (global::Android.Views.KeyEvent keyEvent)
		{
			const string __id = "dispatchKeyShortcutEvent.(Landroid/view/KeyEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (keyEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchPopulateAccessibilityEvent' and count(parameter)=1 and parameter[1][@type='android.view.accessibility.AccessibilityEvent']]"
		[Register ("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", "")]
		public unsafe bool DispatchPopulateAccessibilityEvent (global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent)
		{
			const string __id = "dispatchPopulateAccessibilityEvent.(Landroid/view/accessibility/AccessibilityEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accessibilityEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accessibilityEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (accessibilityEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "")]
		public unsafe bool DispatchTouchEvent (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "dispatchTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (motionEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='dispatchTrackballEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", "")]
		public unsafe bool DispatchTrackballEvent (global::Android.Views.MotionEvent motionEvent)
		{
			const string __id = "dispatchTrackballEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((motionEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) motionEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (motionEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onActionModeFinished' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeFinished", "(Landroid/view/ActionMode;)V", "")]
		public unsafe void OnActionModeFinished (global::Android.Views.ActionMode p0)
		{
			const string __id = "onActionModeFinished.(Landroid/view/ActionMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onActionModeStarted' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeStarted", "(Landroid/view/ActionMode;)V", "")]
		public unsafe void OnActionModeStarted (global::Android.Views.ActionMode p0)
		{
			const string __id = "onActionModeStarted.(Landroid/view/ActionMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "")]
		public unsafe void OnAttachedToWindow ()
		{
			const string __id = "onAttachedToWindow.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onContentChanged' and count(parameter)=0]"
		[Register ("onContentChanged", "()V", "")]
		public unsafe void OnContentChanged ()
		{
			const string __id = "onContentChanged.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", "")]
		public unsafe bool OnCreatePanelMenu (int p0, global::Android.Views.IMenu menu)
		{
			const string __id = "onCreatePanelMenu.(ILandroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (menu);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onCreatePanelView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCreatePanelView", "(I)Landroid/view/View;", "")]
		public unsafe global::Android.Views.View OnCreatePanelView (int p0)
		{
			const string __id = "onCreatePanelView.(I)Landroid/view/View;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "")]
		public unsafe void OnDetachedFromWindow ()
		{
			const string __id = "onDetachedFromWindow.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onGlobalFocusChanged' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
		[Register ("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", "")]
		public unsafe void OnGlobalFocusChanged (global::Android.Views.View oldView, global::Android.Views.View newView)
		{
			const string __id = "onGlobalFocusChanged.(Landroid/view/View;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((oldView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldView).Handle);
				__args [1] = new JniArgumentValue ((newView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newView).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (oldView);
				global::System.GC.KeepAlive (newView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onGlobalLayout' and count(parameter)=0]"
		[Register ("onGlobalLayout", "()V", "")]
		public unsafe void OnGlobalLayout ()
		{
			const string __id = "onGlobalLayout.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", "")]
		public unsafe bool OnMenuItemSelected (int p0, global::Android.Views.IMenuItem menuItem)
		{
			const string __id = "onMenuItemSelected.(ILandroid/view/MenuItem;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((menuItem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menuItem).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (menuItem);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onMenuOpened' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onMenuOpened", "(ILandroid/view/Menu;)Z", "")]
		public unsafe bool OnMenuOpened (int p0, global::Android.Views.IMenu menu)
		{
			const string __id = "onMenuOpened.(ILandroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (menu);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onPanelClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onPanelClosed", "(ILandroid/view/Menu;)V", "")]
		public unsafe void OnPanelClosed (int p0, global::Android.Views.IMenu menu)
		{
			const string __id = "onPanelClosed.(ILandroid/view/Menu;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (menu);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.Menu']]"
		[Register ("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", "")]
		public unsafe bool OnPreparePanel (int p0, global::Android.Views.View view, global::Android.Views.IMenu menu)
		{
			const string __id = "onPreparePanel.(ILandroid/view/View;Landroid/view/Menu;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue ((menu == null) ? IntPtr.Zero : ((global::Java.Lang.Object) menu).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (menu);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onSearchRequested' and count(parameter)=0]"
		[Register ("onSearchRequested", "()Z", "")]
		public unsafe bool OnSearchRequested ()
		{
			const string __id = "onSearchRequested.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onSearchRequested' and count(parameter)=1 and parameter[1][@type='android.view.SearchEvent']]"
		[Register ("onSearchRequested", "(Landroid/view/SearchEvent;)Z", "")]
		public unsafe bool OnSearchRequested (global::Android.Views.SearchEvent searchEvent)
		{
			const string __id = "onSearchRequested.(Landroid/view/SearchEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((searchEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) searchEvent).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (searchEvent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onWindowAttributesChanged' and count(parameter)=1 and parameter[1][@type='android.view.WindowManager.LayoutParams']]"
		[Register ("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", "")]
		public unsafe void OnWindowAttributesChanged (global::Android.Views.WindowManagerLayoutParams layoutParams)
		{
			const string __id = "onWindowAttributesChanged.(Landroid/view/WindowManager$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onWindowFocusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onWindowFocusChanged", "(Z)V", "")]
		public unsafe void OnWindowFocusChanged (bool p0)
		{
			const string __id = "onWindowFocusChanged.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onWindowStartingActionMode' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode.Callback']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", "")]
		public unsafe global::Android.Views.ActionMode OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback actionMode)
		{
			const string __id = "onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actionMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actionMode).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (actionMode);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neuroid.tracker.callbacks']/class[@name='NIDGlobalEventCallback']/method[@name='onWindowStartingActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode.Callback'] and parameter[2][@type='int']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", "")]
		public unsafe global::Android.Views.ActionMode OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback p0, [global::Android.Runtime.GeneratedEnum] global::Android.Views.ActionModeType p1)
		{
			const string __id = "onWindowStartingActionMode.(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
