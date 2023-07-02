using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.neuroid.tracker", Managed="Com.Neuroid.Tracker")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.neuroid.tracker.callbacks", Managed="Com.Neuroid.Tracker.Callbacks")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.neuroid.tracker.storage", Managed="Com.Neuroid.Tracker.Storage")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.neuroid.tracker.utils", Managed="Com.Neuroid.Tracker.Utils")]

#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

