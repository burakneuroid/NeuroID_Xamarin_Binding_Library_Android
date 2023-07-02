; ModuleID = 'obj/Debug/android/marshal_methods.arm64-v8a.ll'
source_filename = "obj/Debug/android/marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [188 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 3
	i64 210515253464952879, ; 1: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 52
	i64 232391251801502327, ; 2: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 76
	i64 295915112840604065, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 77
	i64 316157742385208084, ; 4: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 54
	i64 590536689428908136, ; 5: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 18
	i64 634308326490598313, ; 6: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 68
	i64 702024105029695270, ; 7: System.Drawing.Common => 0x9be17343c0e7726 => 1
	i64 720058930071658100, ; 8: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 62
	i64 816102801403336439, ; 9: Xamarin.Android.Support.Collections => 0xb53612c89d8d6f7 => 22
	i64 846634227898301275, ; 10: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 15
	i64 872800313462103108, ; 11: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 59
	i64 1000557547492888992, ; 12: Mono.Security.dll => 0xde2b1c9cba651a0 => 92
	i64 1315114680217950157, ; 13: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 48
	i64 1342439039765371018, ; 14: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 32
	i64 1490981186906623721, ; 15: Xamarin.Android.Support.VersionedParcelable => 0x14b1077d6c5c0ee9 => 41
	i64 1624659445732251991, ; 16: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 46
	i64 1628611045998245443, ; 17: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 70
	i64 1636321030536304333, ; 18: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 63
	i64 1744702963312407042, ; 19: Xamarin.Android.Support.v7.AppCompat => 0x18366e19eeceb202 => 39
	i64 1795316252682057001, ; 20: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 47
	i64 1797764377906887651, ; 21: testBubblePicker => 0x18f2f12d3efdbbe3 => 0
	i64 1836611346387731153, ; 22: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 76
	i64 1875917498431009007, ; 23: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 44
	i64 1981742497975770890, ; 24: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 69
	i64 2136356949452311481, ; 25: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 74
	i64 2165725771938924357, ; 26: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 51
	i64 2182376669197654945, ; 27: testBubblePicker.dll => 0x1e495c0495a05ba1 => 0
	i64 2262844636196693701, ; 28: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 59
	i64 2329709569556905518, ; 29: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 66
	i64 2470498323731680442, ; 30: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 53
	i64 2479423007379663237, ; 31: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 80
	i64 2497223385847772520, ; 32: System.Runtime => 0x22a7eb7046413568 => 9
	i64 2547086958574651984, ; 33: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 43
	i64 2592350477072141967, ; 34: System.Xml.dll => 0x23f9e10627330e8f => 10
	i64 2624866290265602282, ; 35: mscorlib.dll => 0x246d65fbde2db8ea => 4
	i64 2949706848458024531, ; 36: Xamarin.Android.Support.SlidingPaneLayout => 0x28ef76c01de0a653 => 37
	i64 2977248461349026546, ; 37: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 31
	i64 3289520064315143713, ; 38: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 65
	i64 3303437397778967116, ; 39: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 45
	i64 3311221304742556517, ; 40: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 8
	i64 3344514922410554693, ; 41: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 90
	i64 3493805808809882663, ; 42: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 79
	i64 3522470458906976663, ; 43: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 78
	i64 3531994851595924923, ; 44: System.Numerics => 0x31042a9aade235bb => 7
	i64 3571415421602489686, ; 45: System.Runtime.dll => 0x319037675df7e556 => 9
	i64 4201423742386704971, ; 46: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 54
	i64 4252163538099460320, ; 47: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 42
	i64 4349341163892612332, ; 48: Xamarin.Android.Support.DocumentFile => 0x3c5bf6bea8cd9cec => 30
	i64 4416987920449902723, ; 49: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0x3d4c4b1c879b9883 => 21
	i64 4636684751163556186, ; 50: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 82
	i64 4782108999019072045, ; 51: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 50
	i64 4794310189461587505, ; 52: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 43
	i64 4795410492532947900, ; 53: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 78
	i64 4841234827713643511, ; 54: Xamarin.Android.Support.CoordinaterLayout => 0x432f856d041f03f7 => 24
	i64 4963205065368577818, ; 55: Xamarin.Android.Support.LocalBroadcastManager.dll => 0x44e0d8b5f4b6a71a => 35
	i64 5119588640464285880, ; 56: testBubblePicker.Binding => 0x470c6ebe66ffb0b8 => 11
	i64 5178572682164047940, ; 57: Xamarin.Android.Support.Print.dll => 0x47ddfc6acbee1044 => 36
	i64 5203618020066742981, ; 58: Xamarin.Essentials => 0x4836f704f0e652c5 => 84
	i64 5205316157927637098, ; 59: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 72
	i64 5288341611614403055, ; 60: Xamarin.Android.Support.Interpolator.dll => 0x4963f6ad4b3179ef => 33
	i64 5348796042099802469, ; 61: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 73
	i64 5376510917114486089, ; 62: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 80
	i64 5439315836349573567, ; 63: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0x4b7c54ef36c5e9bf => 19
	i64 5507995362134886206, ; 64: System.Core.dll => 0x4c705499688c873e => 5
	i64 5767696078500135884, ; 65: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 20
	i64 5896680224035167651, ; 66: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 67
	i64 6044705416426755068, ; 67: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0x53e31b8ccdff13fc => 38
	i64 6311200438583329442, ; 68: Xamarin.Android.Support.LocalBroadcastManager => 0x5795e35c580c82a2 => 35
	i64 6319713645133255417, ; 69: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 68
	i64 6401687960814735282, ; 70: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 66
	i64 6405879832841858445, ; 71: Xamarin.Android.Support.Vector.Drawable.dll => 0x58e641c4a660ad8d => 40
	i64 6504860066809920875, ; 72: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 51
	i64 6548213210057960872, ; 73: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 57
	i64 6659513131007730089, ; 74: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 62
	i64 6894844156784520562, ; 75: System.Numerics.Vectors => 0x5faf683aead1ad72 => 8
	i64 7036436454368433159, ; 76: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 64
	i64 7103753931438454322, ; 77: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 61
	i64 7194160955514091247, ; 78: Xamarin.Android.Support.CursorAdapter.dll => 0x63d6cb45d266f6ef => 27
	i64 7637365915383206639, ; 79: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 84
	i64 7654504624184590948, ; 80: System.Net.Http => 0x6a3a4366801b8264 => 91
	i64 7735352534559001595, ; 81: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 88
	i64 7821246742157274664, ; 82: Xamarin.Android.Support.AsyncLayoutInflater => 0x6c8aa67926f72e28 => 21
	i64 7836164640616011524, ; 83: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 46
	i64 7879037620440914030, ; 84: Xamarin.Android.Support.v7.AppCompat.dll => 0x6d57f6f88a51d86e => 39
	i64 8044118961405839122, ; 85: System.ComponentModel.Composition => 0x6fa2739369944712 => 93
	i64 8083354569033831015, ; 86: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 65
	i64 8101777744205214367, ; 87: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 20
	i64 8167236081217502503, ; 88: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8187640529827139739, ; 89: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 89
	i64 8196541262927413903, ; 90: Xamarin.Android.Support.Interpolator => 0x71bff6d9fb9ec28f => 33
	i64 8385935383968044654, ; 91: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0x7460d3cd16cb566e => 17
	i64 8626175481042262068, ; 92: Java.Interop => 0x77b654e585b55834 => 2
	i64 8796457469147618732, ; 93: Xamarin.Android.Support.CustomTabs => 0x7a134b766a601dac => 28
	i64 8808820144457481518, ; 94: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 34
	i64 8853378295825400934, ; 95: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 87
	i64 8917102979740339192, ; 96: Xamarin.Android.Support.DocumentFile.dll => 0x7bbfe9ea4d000bf8 => 30
	i64 9324707631942237306, ; 97: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 47
	i64 9662334977499516867, ; 98: System.Numerics.dll => 0x8617827802b0cfc3 => 7
	i64 9678050649315576968, ; 99: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 53
	i64 9711637524876806384, ; 100: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 73
	i64 9808709177481450983, ; 101: Mono.Android.dll => 0x881f890734e555e7 => 3
	i64 9866412715007501892, ; 102: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 14
	i64 9998632235833408227, ; 103: Mono.Security => 0x8ac2470b209ebae3 => 92
	i64 10038780035334861115, ; 104: System.Net.Http.dll => 0x8b50e941206af13b => 91
	i64 10229024438826829339, ; 105: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 57
	i64 10303855825347935641, ; 106: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 34
	i64 10321854143672141184, ; 107: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 86
	i64 10363495123250631811, ; 108: Xamarin.Android.Support.Collections.dll => 0x8fd287e80cd8d483 => 22
	i64 10376576884623852283, ; 109: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 79
	i64 10406448008575299332, ; 110: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 90
	i64 10430153318873392755, ; 111: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 55
	i64 10635644668885628703, ; 112: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 31
	i64 10847732767863316357, ; 113: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 48
	i64 10850923258212604222, ; 114: Xamarin.Android.Arch.Lifecycle.Runtime => 0x9696393672c9593e => 17
	i64 10913891249535884439, ; 115: Xamarin.Android.Support.CustomTabs.dll => 0x9775ee4465d49c97 => 28
	i64 11023048688141570732, ; 116: System.Core => 0x98f9bc61168392ac => 5
	i64 11037814507248023548, ; 117: System.Xml => 0x992e31d0412bf7fc => 10
	i64 11162124722117608902, ; 118: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 83
	i64 11340910727871153756, ; 119: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 56
	i64 11376461258732682436, ; 120: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 23
	i64 11392833485892708388, ; 121: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 75
	i64 11529969570048099689, ; 122: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 83
	i64 11578238080964724296, ; 123: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 64
	i64 11580057168383206117, ; 124: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 44
	i64 11672361001936329215, ; 125: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 61
	i64 11834399401546345650, ; 126: Xamarin.Android.Support.SlidingPaneLayout.dll => 0xa43c3b8deb43ecb2 => 37
	i64 11865714326292153359, ; 127: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa4ab7c5000e8440f => 16
	i64 12137774235383566651, ; 128: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 81
	i64 12388767885335911387, ; 129: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0xabedbec0d236dbdb => 16
	i64 12414299427252656003, ; 130: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 23
	i64 12451044538927396471, ; 131: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 60
	i64 12466513435562512481, ; 132: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 71
	i64 12487638416075308985, ; 133: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 58
	i64 12700543734426720211, ; 134: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 52
	i64 12952608645614506925, ; 135: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 26
	i64 12963446364377008305, ; 136: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 1
	i64 13358059602087096138, ; 137: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 32
	i64 13401370062847626945, ; 138: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 81
	i64 13454009404024712428, ; 139: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 85
	i64 13465488254036897740, ; 140: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 88
	i64 13491513212026656886, ; 141: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 49
	i64 13625219876625789355, ; 142: testBubblePicker.Binding.dll => 0xbd168149ccdf31ab => 11
	i64 13828521679616088467, ; 143: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 87
	i64 13959074834287824816, ; 144: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 60
	i64 14172845254133543601, ; 145: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 74
	i64 14261073672896646636, ; 146: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 75
	i64 14369828458497533121, ; 147: Xamarin.Android.Support.Vector.Drawable => 0xc76be2d9300b64c1 => 40
	i64 14400856865250966808, ; 148: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 25
	i64 14486659737292545672, ; 149: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 67
	i64 14644440854989303794, ; 150: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 72
	i64 14661790646341542033, ; 151: Xamarin.Android.Support.SwipeRefreshLayout => 0xcb7924e94e552091 => 38
	i64 14792063746108907174, ; 152: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 85
	i64 14852515768018889994, ; 153: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 56
	i64 14988210264188246988, ; 154: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 58
	i64 15188640517174936311, ; 155: Xamarin.Android.Arch.Core.Common => 0xd2c8e413d75142f7 => 12
	i64 15246441518555807158, ; 156: Xamarin.Android.Arch.Core.Common.dll => 0xd3963dc832493db6 => 12
	i64 15279429628684179188, ; 157: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 89
	i64 15326820765897713587, ; 158: Xamarin.Android.Arch.Core.Runtime.dll => 0xd4b3ce481769e7b3 => 13
	i64 15370334346939861994, ; 159: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 55
	i64 15568534730848034786, ; 160: Xamarin.Android.Support.VersionedParcelable.dll => 0xd80e8bda21875fe2 => 41
	i64 15582737692548360875, ; 161: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 70
	i64 15609085926864131306, ; 162: System.dll => 0xd89e9cf3334914ea => 6
	i64 15777549416145007739, ; 163: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 77
	i64 16154507427712707110, ; 164: System => 0xe03056ea4e39aa26 => 6
	i64 16242842420508142678, ; 165: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe16a2b1f8908ac56 => 24
	i64 16565028646146589191, ; 166: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 93
	i64 16767985610513713374, ; 167: Xamarin.Android.Arch.Core.Runtime => 0xe8b3da12798808de => 13
	i64 16833383113903931215, ; 168: mscorlib => 0xe99c30c1484d7f4f => 4
	i64 16932527889823454152, ; 169: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 26
	i64 17009591894298689098, ; 170: Xamarin.Android.Support.Animated.Vector.Drawable => 0xec0e35b50a097e4a => 19
	i64 17024911836938395553, ; 171: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 45
	i64 17037200463775726619, ; 172: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 63
	i64 17383232329670771222, ; 173: Xamarin.Android.Support.CustomView.dll => 0xf13da5b41a1cc216 => 29
	i64 17428701562824544279, ; 174: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 25
	i64 17483646997724851973, ; 175: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 42
	i64 17524135665394030571, ; 176: Xamarin.Android.Support.Print => 0xf3323c8a739097eb => 36
	i64 17544493274320527064, ; 177: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 50
	i64 17666959971718154066, ; 178: Xamarin.Android.Support.CustomView => 0xf52da67d9f4e4752 => 29
	i64 17704177640604968747, ; 179: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 71
	i64 17710060891934109755, ; 180: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 69
	i64 17760961058993581169, ; 181: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 14
	i64 17841643939744178149, ; 182: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 18
	i64 17891337867145587222, ; 183: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 86
	i64 17958105683855786126, ; 184: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 15
	i64 18116111925905154859, ; 185: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 49
	i64 18301997741680159453, ; 186: Xamarin.Android.Support.CursorAdapter => 0xfdfdc1fa58d8eadd => 27
	i64 18380184030268848184 ; 187: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 82
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [188 x i32] [
	i32 3, i32 52, i32 76, i32 77, i32 54, i32 18, i32 68, i32 1, ; 0..7
	i32 62, i32 22, i32 15, i32 59, i32 92, i32 48, i32 32, i32 41, ; 8..15
	i32 46, i32 70, i32 63, i32 39, i32 47, i32 0, i32 76, i32 44, ; 16..23
	i32 69, i32 74, i32 51, i32 0, i32 59, i32 66, i32 53, i32 80, ; 24..31
	i32 9, i32 43, i32 10, i32 4, i32 37, i32 31, i32 65, i32 45, ; 32..39
	i32 8, i32 90, i32 79, i32 78, i32 7, i32 9, i32 54, i32 42, ; 40..47
	i32 30, i32 21, i32 82, i32 50, i32 43, i32 78, i32 24, i32 35, ; 48..55
	i32 11, i32 36, i32 84, i32 72, i32 33, i32 73, i32 80, i32 19, ; 56..63
	i32 5, i32 20, i32 67, i32 38, i32 35, i32 68, i32 66, i32 40, ; 64..71
	i32 51, i32 57, i32 62, i32 8, i32 64, i32 61, i32 27, i32 84, ; 72..79
	i32 91, i32 88, i32 21, i32 46, i32 39, i32 93, i32 65, i32 20, ; 80..87
	i32 2, i32 89, i32 33, i32 17, i32 2, i32 28, i32 34, i32 87, ; 88..95
	i32 30, i32 47, i32 7, i32 53, i32 73, i32 3, i32 14, i32 92, ; 96..103
	i32 91, i32 57, i32 34, i32 86, i32 22, i32 79, i32 90, i32 55, ; 104..111
	i32 31, i32 48, i32 17, i32 28, i32 5, i32 10, i32 83, i32 56, ; 112..119
	i32 23, i32 75, i32 83, i32 64, i32 44, i32 61, i32 37, i32 16, ; 120..127
	i32 81, i32 16, i32 23, i32 60, i32 71, i32 58, i32 52, i32 26, ; 128..135
	i32 1, i32 32, i32 81, i32 85, i32 88, i32 49, i32 11, i32 87, ; 136..143
	i32 60, i32 74, i32 75, i32 40, i32 25, i32 67, i32 72, i32 38, ; 144..151
	i32 85, i32 56, i32 58, i32 12, i32 12, i32 89, i32 13, i32 55, ; 152..159
	i32 41, i32 70, i32 6, i32 77, i32 6, i32 24, i32 93, i32 13, ; 160..167
	i32 4, i32 26, i32 19, i32 45, i32 63, i32 29, i32 25, i32 42, ; 168..175
	i32 36, i32 50, i32 29, i32 71, i32 69, i32 14, i32 18, i32 86, ; 176..183
	i32 15, i32 49, i32 27, i32 82 ; 184..187
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
