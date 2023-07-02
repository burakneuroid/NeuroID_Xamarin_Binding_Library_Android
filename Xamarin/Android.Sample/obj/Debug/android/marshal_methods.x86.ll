; ModuleID = 'obj/Debug/android/marshal_methods.x86.ll'
source_filename = "obj/Debug/android/marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [188 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 68
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 85
	i32 38110119, ; 2: testBubblePicker.Binding.dll => 0x24583a7 => 11
	i32 57967248, ; 3: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 41
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 77
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 77
	i32 160529393, ; 6: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 12
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 52
	i32 166922606, ; 8: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 23
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 78
	i32 201930040, ; 10: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 13
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 51
	i32 230216969, ; 12: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 63
	i32 278686392, ; 13: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 67
	i32 280482487, ; 14: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 61
	i32 318968648, ; 15: Xamarin.AndroidX.Activity.dll => 0x13031348 => 43
	i32 321597661, ; 16: System.Numerics => 0x132b30dd => 7
	i32 342366114, ; 17: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 65
	i32 388313361, ; 18: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 19
	i32 389971796, ; 19: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 25
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 84
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 60
	i32 465846621, ; 22: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 23: System.dll => 0x1bff388e => 6
	i32 476646585, ; 24: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 61
	i32 486930444, ; 25: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 72
	i32 514659665, ; 26: Xamarin.Android.Support.Compat => 0x1ead1551 => 23
	i32 524864063, ; 27: Xamarin.Android.Support.Print => 0x1f48ca3f => 36
	i32 627609679, ; 28: Xamarin.AndroidX.CustomView => 0x2568904f => 57
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 82
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 48
	i32 691348768, ; 31: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 89
	i32 692692150, ; 32: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 20
	i32 700284507, ; 33: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 86
	i32 801787702, ; 34: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 33
	i32 809851609, ; 35: System.Drawing.Common.dll => 0x30455ad9 => 1
	i32 843511501, ; 36: Xamarin.AndroidX.Print => 0x3246f6cd => 75
	i32 916714535, ; 37: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 36
	i32 928116545, ; 38: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 85
	i32 967690846, ; 39: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 65
	i32 987342438, ; 40: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 16
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 76
	i32 1035644815, ; 42: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 47
	i32 1052210849, ; 43: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 69
	i32 1084122840, ; 44: Xamarin.Kotlin.StdLib => 0x409e66d8 => 88
	i32 1098167829, ; 45: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 18
	i32 1098259244, ; 46: System => 0x41761b2c => 6
	i32 1175144683, ; 47: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 80
	i32 1204270330, ; 48: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 48
	i32 1267360935, ; 49: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 81
	i32 1275534314, ; 50: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 89
	i32 1292763917, ; 51: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 27
	i32 1293217323, ; 52: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 59
	i32 1297413738, ; 53: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 15
	i32 1376866003, ; 54: Xamarin.AndroidX.SavedState => 0x52114ed3 => 76
	i32 1395857551, ; 55: Xamarin.AndroidX.Media.dll => 0x5333188f => 73
	i32 1406073936, ; 56: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 53
	i32 1445445088, ; 57: Xamarin.Android.Support.Fragment => 0x5627bde0 => 32
	i32 1469204771, ; 58: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 46
	i32 1574652163, ; 59: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 26
	i32 1582372066, ; 60: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 58
	i32 1587447679, ; 61: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 12
	i32 1622152042, ; 62: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 71
	i32 1636350590, ; 63: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 56
	i32 1639515021, ; 64: System.Net.Http.dll => 0x61b9038d => 91
	i32 1657153582, ; 65: System.Runtime => 0x62c6282e => 9
	i32 1658241508, ; 66: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 79
	i32 1662014763, ; 67: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 40
	i32 1698840827, ; 68: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 87
	i32 1766324549, ; 69: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 78
	i32 1776026572, ; 70: System.Core.dll => 0x69dc03cc => 5
	i32 1788241197, ; 71: Xamarin.AndroidX.Fragment => 0x6a96652d => 60
	i32 1808609942, ; 72: Xamarin.AndroidX.Loader => 0x6bcd3296 => 71
	i32 1813058853, ; 73: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 88
	i32 1866717392, ; 74: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 33
	i32 1867746548, ; 75: Xamarin.Essentials.dll => 0x6f538cf4 => 84
	i32 1885316902, ; 76: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 49
	i32 1916660109, ; 77: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 18
	i32 1919157823, ; 78: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 74
	i32 1983156543, ; 79: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 87
	i32 2019465201, ; 80: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 69
	i32 2037417872, ; 81: Xamarin.Android.Support.ViewPager => 0x79708790 => 42
	i32 2044222327, ; 82: Xamarin.Android.Support.Loader => 0x79d85b77 => 34
	i32 2055257422, ; 83: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 66
	i32 2079903147, ; 84: System.Runtime.dll => 0x7bf8cdab => 9
	i32 2090596640, ; 85: System.Numerics.Vectors => 0x7c9bf920 => 8
	i32 2097448633, ; 86: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 62
	i32 2139458754, ; 87: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 31
	i32 2166116741, ; 88: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 26
	i32 2196165013, ; 89: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 41
	i32 2201107256, ; 90: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 90
	i32 2201231467, ; 91: System.Net.Http => 0x8334206b => 91
	i32 2217644978, ; 92: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 80
	i32 2244775296, ; 93: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 72
	i32 2256548716, ; 94: Xamarin.AndroidX.MultiDex => 0x8680336c => 74
	i32 2261435625, ; 95: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 64
	i32 2313394179, ; 96: testBubblePicker.dll => 0x89e39803 => 0
	i32 2315684594, ; 97: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 44
	i32 2330457430, ; 98: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 25
	i32 2330986192, ; 99: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 37
	i32 2373288475, ; 100: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 32
	i32 2440966767, ; 101: Xamarin.Android.Support.Loader.dll => 0x917e326f => 34
	i32 2475788418, ; 102: Java.Interop.dll => 0x93918882 => 2
	i32 2484490808, ; 103: testBubblePicker.Binding => 0x94165238 => 11
	i32 2487632829, ; 104: Xamarin.Android.Support.DocumentFile => 0x944643bd => 30
	i32 2505896520, ; 105: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 68
	i32 2581819634, ; 106: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 81
	i32 2605712449, ; 107: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 90
	i32 2620871830, ; 108: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 56
	i32 2633051222, ; 109: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 67
	i32 2698266930, ; 110: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 16
	i32 2701096212, ; 111: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 79
	i32 2732626843, ; 112: Xamarin.AndroidX.Activity => 0xa2e0939b => 43
	i32 2737747696, ; 113: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 46
	i32 2751899777, ; 114: Xamarin.Android.Support.Collections => 0xa406a881 => 22
	i32 2770495804, ; 115: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 86
	i32 2778768386, ; 116: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 83
	i32 2782647110, ; 117: Xamarin.Android.Support.CustomTabs.dll => 0xa5dbd346 => 28
	i32 2788639665, ; 118: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 35
	i32 2788775637, ; 119: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 38
	i32 2810250172, ; 120: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 53
	i32 2819470561, ; 121: System.Xml.dll => 0xa80db4e1 => 10
	i32 2853208004, ; 122: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 83
	i32 2876493027, ; 123: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 38
	i32 2888451725, ; 124: testBubblePicker => 0xac2a468d => 0
	i32 2893257763, ; 125: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 13
	i32 2903344695, ; 126: System.ComponentModel.Composition => 0xad0d8637 => 93
	i32 2905242038, ; 127: mscorlib.dll => 0xad2a79b6 => 4
	i32 2919462931, ; 128: System.Numerics.Vectors.dll => 0xae037813 => 8
	i32 2921128767, ; 129: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 45
	i32 2921692953, ; 130: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 29
	i32 2922925221, ; 131: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 40
	i32 2978675010, ; 132: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 59
	i32 3024354802, ; 133: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 63
	i32 3056250942, ; 134: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 21
	i32 3068715062, ; 135: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 14
	i32 3191408315, ; 136: Xamarin.Android.Support.CustomTabs => 0xbe3906bb => 28
	i32 3204912593, ; 137: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 21
	i32 3211777861, ; 138: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 58
	i32 3233339011, ; 139: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 15
	i32 3247949154, ; 140: Mono.Security => 0xc197c562 => 92
	i32 3267021929, ; 141: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 50
	i32 3296380511, ; 142: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 22
	i32 3317135071, ; 143: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 57
	i32 3321585405, ; 144: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 30
	i32 3340431453, ; 145: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 49
	i32 3352662376, ; 146: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 24
	i32 3353484488, ; 147: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 62
	i32 3357663996, ; 148: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 27
	i32 3362522851, ; 149: Xamarin.AndroidX.Core => 0xc86c06e3 => 55
	i32 3366347497, ; 150: Java.Interop => 0xc8a662e9 => 2
	i32 3429136800, ; 151: System.Xml => 0xcc6479a0 => 10
	i32 3439690031, ; 152: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 20
	i32 3476120550, ; 153: Mono.Android => 0xcf3163e6 => 3
	i32 3501239056, ; 154: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 50
	i32 3547625832, ; 155: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 37
	i32 3567349600, ; 156: System.ComponentModel.Composition.dll => 0xd4a16f60 => 93
	i32 3627220390, ; 157: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 75
	i32 3633644679, ; 158: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 45
	i32 3641597786, ; 159: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 66
	i32 3664423555, ; 160: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 42
	i32 3672681054, ; 161: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3678221644, ; 162: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 39
	i32 3681174138, ; 163: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 14
	i32 3682565725, ; 164: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 51
	i32 3689375977, ; 165: System.Drawing.Common => 0xdbe768e9 => 1
	i32 3706696989, ; 166: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 54
	i32 3714038699, ; 167: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 35
	i32 3718463572, ; 168: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 19
	i32 3718780102, ; 169: Xamarin.AndroidX.Annotation => 0xdda814c6 => 44
	i32 3758932259, ; 170: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 64
	i32 3776062606, ; 171: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 31
	i32 3786282454, ; 172: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 52
	i32 3822602673, ; 173: Xamarin.AndroidX.Media => 0xe3d849b1 => 73
	i32 3829621856, ; 174: System.Numerics.dll => 0xe4436460 => 7
	i32 3832731800, ; 175: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 24
	i32 3862817207, ; 176: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 17
	i32 3874897629, ; 177: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 17
	i32 3883175360, ; 178: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 39
	i32 3896760992, ; 179: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 55
	i32 3921031405, ; 180: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 82
	i32 3955647286, ; 181: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 47
	i32 4063435586, ; 182: Xamarin.Android.Support.CustomView => 0xf2331b42 => 29
	i32 4105002889, ; 183: Mono.Security.dll => 0xf4ad5f89 => 92
	i32 4151237749, ; 184: System.Core => 0xf76edc75 => 5
	i32 4182413190, ; 185: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 70
	i32 4256097574, ; 186: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 54
	i32 4292120959 ; 187: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 70
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [188 x i32] [
	i32 68, i32 85, i32 11, i32 41, i32 77, i32 77, i32 12, i32 52, ; 0..7
	i32 23, i32 78, i32 13, i32 51, i32 63, i32 67, i32 61, i32 43, ; 8..15
	i32 7, i32 65, i32 19, i32 25, i32 84, i32 60, i32 4, i32 6, ; 16..23
	i32 61, i32 72, i32 23, i32 36, i32 57, i32 82, i32 48, i32 89, ; 24..31
	i32 20, i32 86, i32 33, i32 1, i32 75, i32 36, i32 85, i32 65, ; 32..39
	i32 16, i32 76, i32 47, i32 69, i32 88, i32 18, i32 6, i32 80, ; 40..47
	i32 48, i32 81, i32 89, i32 27, i32 59, i32 15, i32 76, i32 73, ; 48..55
	i32 53, i32 32, i32 46, i32 26, i32 58, i32 12, i32 71, i32 56, ; 56..63
	i32 91, i32 9, i32 79, i32 40, i32 87, i32 78, i32 5, i32 60, ; 64..71
	i32 71, i32 88, i32 33, i32 84, i32 49, i32 18, i32 74, i32 87, ; 72..79
	i32 69, i32 42, i32 34, i32 66, i32 9, i32 8, i32 62, i32 31, ; 80..87
	i32 26, i32 41, i32 90, i32 91, i32 80, i32 72, i32 74, i32 64, ; 88..95
	i32 0, i32 44, i32 25, i32 37, i32 32, i32 34, i32 2, i32 11, ; 96..103
	i32 30, i32 68, i32 81, i32 90, i32 56, i32 67, i32 16, i32 79, ; 104..111
	i32 43, i32 46, i32 22, i32 86, i32 83, i32 28, i32 35, i32 38, ; 112..119
	i32 53, i32 10, i32 83, i32 38, i32 0, i32 13, i32 93, i32 4, ; 120..127
	i32 8, i32 45, i32 29, i32 40, i32 59, i32 63, i32 21, i32 14, ; 128..135
	i32 28, i32 21, i32 58, i32 15, i32 92, i32 50, i32 22, i32 57, ; 136..143
	i32 30, i32 49, i32 24, i32 62, i32 27, i32 55, i32 2, i32 10, ; 144..151
	i32 20, i32 3, i32 50, i32 37, i32 93, i32 75, i32 45, i32 66, ; 152..159
	i32 42, i32 3, i32 39, i32 14, i32 51, i32 1, i32 54, i32 35, ; 160..167
	i32 19, i32 44, i32 64, i32 31, i32 52, i32 73, i32 7, i32 24, ; 168..175
	i32 17, i32 17, i32 39, i32 55, i32 82, i32 47, i32 29, i32 92, ; 176..183
	i32 5, i32 70, i32 54, i32 70 ; 184..187
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
