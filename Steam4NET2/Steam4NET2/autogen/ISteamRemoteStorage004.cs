// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamRemoteStorage004VTable
	{
		public IntPtr FileWrite0;
		public IntPtr FileRead1;
		public IntPtr FileForget2;
		public IntPtr FileDelete3;
		public IntPtr FileShare4;
		public IntPtr SetSyncPlatforms5;
		public IntPtr FileExists6;
		public IntPtr FilePersisted7;
		public IntPtr GetFileSize8;
		public IntPtr GetFileTimestamp9;
		public IntPtr GetSyncPlatforms10;
		public IntPtr GetFileCount11;
		public IntPtr GetFileNameAndSize12;
		public IntPtr GetQuota13;
		public IntPtr IsCloudEnabledForAccount14;
		public IntPtr IsCloudEnabledThisApp15;
		public IntPtr SetCloudEnabledThisApp16;
		public IntPtr UGCDownload17;
		public IntPtr GetUGCDetails18;
		public IntPtr UGCRead19;
		public IntPtr GetCachedUGCCount20;
		public IntPtr GetCachedUGCHandle21;
		private IntPtr DTorISteamRemoteStorage00422;
	};
	
	public class ISteamRemoteStorage004 : InteropHelp.NativeWrapper<ISteamRemoteStorage004VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileWriteSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FileWrite( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileWriteSBI>( this.Functions.FileWrite0 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeFileReadSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubDataToRead );
		public Int32 FileRead( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileReadSBI>( this.Functions.FileRead1 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileForgetS( IntPtr thisptr, string pchFile );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FileForget( string pchFile ) 
		{
			return this.GetFunction<NativeFileForgetS>( this.Functions.FileForget2 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileDeleteS( IntPtr thisptr, string pchFile );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FileDelete( string pchFile ) 
		{
			return this.GetFunction<NativeFileDeleteS>( this.Functions.FileDelete3 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFileShareS( IntPtr thisptr, ref UInt64 retarg, string pchFile );
		public UInt64 FileShare( string pchFile ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeFileShareS>( this.Functions.FileShare4 )( this.ObjectAddress, ref ret, pchFile ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetSyncPlatformsSI( IntPtr thisptr, string pchFile, Int32 iUnk );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetSyncPlatforms( string pchFile, Int32 iUnk ) 
		{
			return this.GetFunction<NativeSetSyncPlatformsSI>( this.Functions.SetSyncPlatforms5 )( this.ObjectAddress, pchFile, iUnk ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS( IntPtr thisptr, string pchFile );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FileExists( string pchFile ) 
		{
			return this.GetFunction<NativeFileExistsS>( this.Functions.FileExists6 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFilePersistedS( IntPtr thisptr, string pchFile );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool FilePersisted( string pchFile ) 
		{
			return this.GetFunction<NativeFilePersistedS>( this.Functions.FilePersisted7 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileSizeS( IntPtr thisptr, string pchFile );
		public Int32 GetFileSize( string pchFile ) 
		{
			return this.GetFunction<NativeGetFileSizeS>( this.Functions.GetFileSize8 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int64 NativeGetFileTimestampS( IntPtr thisptr, ref UInt64 retarg, string pchFile );
		public Int64 GetFileTimestamp( string pchFile ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFileTimestampS>( this.Functions.GetFileTimestamp9 )( this.ObjectAddress, ref ret, pchFile ); return (Int64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetSyncPlatformsS( IntPtr thisptr, string pchFile );
		public Int32 GetSyncPlatforms( string pchFile ) 
		{
			return this.GetFunction<NativeGetSyncPlatformsS>( this.Functions.GetSyncPlatforms10 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileCount( IntPtr thisptr );
		public Int32 GetFileCount(  ) 
		{
			return this.GetFunction<NativeGetFileCount>( this.Functions.GetFileCount11 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetFileNameAndSizeII( IntPtr thisptr, Int32 iFile, ref Int32 pnFileSizeInBytes );
		public string GetFileNameAndSize( Int32 iFile, ref Int32 pnFileSizeInBytes ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetFileNameAndSizeII>( this.Functions.GetFileNameAndSize12 )( this.ObjectAddress, iFile, ref pnFileSizeInBytes ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII( IntPtr thisptr, ref Int32 pnTotalBytes, ref Int32 puAvailableBytes );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetQuota( ref Int32 pnTotalBytes, ref Int32 puAvailableBytes ) 
		{
			return this.GetFunction<NativeGetQuotaII>( this.Functions.GetQuota13 )( this.ObjectAddress, ref pnTotalBytes, ref puAvailableBytes ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForAccount( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsCloudEnabledForAccount(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledForAccount>( this.Functions.IsCloudEnabledForAccount14 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledThisApp( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsCloudEnabledThisApp(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledThisApp>( this.Functions.IsCloudEnabledThisApp15 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetCloudEnabledThisAppB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnable );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetCloudEnabledThisApp( bool bEnable ) 
		{
			return this.GetFunction<NativeSetCloudEnabledThisAppB>( this.Functions.SetCloudEnabledThisApp16 )( this.ObjectAddress, bEnable ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCDownloadII( IntPtr thisptr, Int32 unk1, Int32 unk2 );
		public Int32 UGCDownload( Int32 unk1, Int32 unk2 ) 
		{
			return this.GetFunction<NativeUGCDownloadII>( this.Functions.UGCDownload17 )( this.ObjectAddress, unk1, unk2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetUGCDetailsIIIIII( IntPtr thisptr, Int32 unk1, Int32 unk2, Int32 unk3, Int32 unk4, Int32 unk5, Int32 unk6 );
		public Int32 GetUGCDetails( Int32 unk1, Int32 unk2, Int32 unk3, Int32 unk4, Int32 unk5, Int32 unk6 ) 
		{
			return this.GetFunction<NativeGetUGCDetailsIIIIII>( this.Functions.GetUGCDetails18 )( this.ObjectAddress, unk1, unk2, unk3, unk4, unk5, unk6 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCReadIIII( IntPtr thisptr, Int32 unk1, Int32 unk2, Int32 unk3, Int32 unk4 );
		public Int32 UGCRead( Int32 unk1, Int32 unk2, Int32 unk3, Int32 unk4 ) 
		{
			return this.GetFunction<NativeUGCReadIIII>( this.Functions.UGCRead19 )( this.ObjectAddress, unk1, unk2, unk3, unk4 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCCount( IntPtr thisptr );
		public Int32 GetCachedUGCCount(  ) 
		{
			return this.GetFunction<NativeGetCachedUGCCount>( this.Functions.GetCachedUGCCount20 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCHandle( IntPtr thisptr );
		public Int32 GetCachedUGCHandle(  ) 
		{
			return this.GetFunction<NativeGetCachedUGCHandle>( this.Functions.GetCachedUGCHandle21 )( this.ObjectAddress ); 
		}
		
	};
}
