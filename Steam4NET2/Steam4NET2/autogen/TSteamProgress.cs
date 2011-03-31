// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamProgress
	{
		Int32 bValid;
		UInt32 uPercentDone;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
		string szProgress;
	};
	
}
