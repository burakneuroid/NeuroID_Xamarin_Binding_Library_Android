	.arch	armv7-a
	.syntax unified
	.eabi_attribute 67, "2.09"	@ Tag_conformance
	.eabi_attribute 6, 10	@ Tag_CPU_arch
	.eabi_attribute 7, 65	@ Tag_CPU_arch_profile
	.eabi_attribute 8, 1	@ Tag_ARM_ISA_use
	.eabi_attribute 9, 2	@ Tag_THUMB_ISA_use
	.fpu	vfpv3-d16
	.eabi_attribute 34, 1	@ Tag_CPU_unaligned_access
	.eabi_attribute 15, 1	@ Tag_ABI_PCS_RW_data
	.eabi_attribute 16, 1	@ Tag_ABI_PCS_RO_data
	.eabi_attribute 17, 2	@ Tag_ABI_PCS_GOT_use
	.eabi_attribute 20, 2	@ Tag_ABI_FP_denormal
	.eabi_attribute 21, 0	@ Tag_ABI_FP_exceptions
	.eabi_attribute 23, 3	@ Tag_ABI_FP_number_model
	.eabi_attribute 24, 1	@ Tag_ABI_align_needed
	.eabi_attribute 25, 1	@ Tag_ABI_align_preserved
	.eabi_attribute 38, 1	@ Tag_ABI_FP_16bit_format
	.eabi_attribute 18, 4	@ Tag_ABI_PCS_wchar_t
	.eabi_attribute 26, 2	@ Tag_ABI_enum_size
	.eabi_attribute 14, 0	@ Tag_ABI_PCS_R9_use
	.file	"compressed_assemblies.armeabi-v7a.armeabi-v7a.s"
	.include	"compressed_assemblies.armeabi-v7a-data.inc"

	.section	.data.compressed_assembly_descriptors,"aw",%progbits
	.type	.L.compressed_assembly_descriptors, %object
	.p2align	2
.L.compressed_assembly_descriptors:
	/* 0: Java.Interop.dll */
	/* uncompressed_file_size */
	.long	165888
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_0

	/* 1: Mono.Android.dll */
	/* uncompressed_file_size */
	.long	1067008
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_1

	/* 2: NeuroIDXamarinAndroid.dll */
	/* uncompressed_file_size */
	.long	88064
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_2

	/* 3: System.Core.dll */
	/* uncompressed_file_size */
	.long	47104
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_3

	/* 4: System.dll */
	/* uncompressed_file_size */
	.long	15360
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_4

	/* 5: Xamarin.AndroidX.Activity.dll */
	/* uncompressed_file_size */
	.long	53248
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_5

	/* 6: Xamarin.AndroidX.AppCompat.dll */
	/* uncompressed_file_size */
	.long	320512
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_6

	/* 7: Xamarin.AndroidX.Core.dll */
	/* uncompressed_file_size */
	.long	155136
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_7

	/* 8: Xamarin.AndroidX.CustomView.dll */
	/* uncompressed_file_size */
	.long	8704
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_8

	/* 9: Xamarin.AndroidX.DrawerLayout.dll */
	/* uncompressed_file_size */
	.long	40960
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_9

	/* 10: Xamarin.AndroidX.Fragment.dll */
	/* uncompressed_file_size */
	.long	171520
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_10

	/* 11: Xamarin.AndroidX.Lifecycle.Common.dll */
	/* uncompressed_file_size */
	.long	15360
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_11

	/* 12: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll */
	/* uncompressed_file_size */
	.long	14848
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_12

	/* 13: Xamarin.AndroidX.Lifecycle.ViewModel.dll */
	/* uncompressed_file_size */
	.long	16896
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_13

	/* 14: Xamarin.AndroidX.Loader.dll */
	/* uncompressed_file_size */
	.long	36352
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_14

	/* 15: Xamarin.AndroidX.SavedState.dll */
	/* uncompressed_file_size */
	.long	12800
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_15

	/* 16: Xamarin.Essentials.dll */
	/* uncompressed_file_size */
	.long	25088
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_16

	/* 17: Xamarin.Google.Guava.ListenableFuture.dll */
	/* uncompressed_file_size */
	.long	18072
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_17

	/* 18: Xamarin.Jetbrains.Annotations.dll */
	/* uncompressed_file_size */
	.long	89992
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_18

	/* 19: Xamarin.Kotlin.StdLib.Common.dll */
	/* uncompressed_file_size */
	.long	14200
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_19

	/* 20: Xamarin.Kotlin.StdLib.dll */
	/* uncompressed_file_size */
	.long	2037120
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_20

	/* 21: Xamarin.KotlinX.Coroutines.Android.dll */
	/* uncompressed_file_size */
	.long	25488
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_21

	/* 22: Xamarin.KotlinX.Coroutines.Core.Jvm.dll */
	/* uncompressed_file_size */
	.long	325520
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_22

	/* 23: mscorlib.dll */
	/* uncompressed_file_size */
	.long	1715200
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_23

	/* 24: testBubblePicker.Binding.dll */
	/* uncompressed_file_size */
	.long	68608
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.long	compressed_assembly_data_24

	.size	.L.compressed_assembly_descriptors, 300
	.section	.data.compressed_assemblies,"aw",%progbits
	.type	compressed_assemblies, %object
	.p2align	2
	.global	compressed_assemblies
compressed_assemblies:
	/* count */
	.long	25
	/* descriptors */
	.long	.L.compressed_assembly_descriptors
	.size	compressed_assemblies, 8
