; ModuleID = 'obj/Release/android/compressed_assemblies.arm64-v8a.ll'
source_filename = "obj/Release/android/compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [168448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [1081856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [88064 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [47104 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [15360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [53248 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [320512 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [154624 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [8704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [40960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [171520 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [15360 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [14848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [36352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [12800 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [25088 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [18072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [89992 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [14200 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [2037120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [25488 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [325520 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [1714176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [68608 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [25 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 168448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([168448 x i8], [168448 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 1081856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1081856 x i8], [1081856 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 88064, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([88064 x i8], [88064 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 47104, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([47104 x i8], [47104 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15360 x i8], [15360 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 53248, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([53248 x i8], [53248 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 320512, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([320512 x i8], [320512 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 154624, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([154624 x i8], [154624 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 40960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40960 x i8], [40960 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 171520, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([171520 x i8], [171520 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15360 x i8], [15360 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 36352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36352 x i8], [36352 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12800 x i8], [12800 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 25088, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25088 x i8], [25088 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 18072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18072 x i8], [18072 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 89992, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([89992 x i8], [89992 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 14200, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14200 x i8], [14200 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 2037120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2037120 x i8], [2037120 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 25488, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25488 x i8], [25488 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 325520, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([325520 x i8], [325520 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 1714176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1714176 x i8], [1714176 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 68608, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([68608 x i8], [68608 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}
], align 8; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 25, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([25 x %struct.CompressedAssemblyDescriptor], [25 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
