// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamAppVersion
	{
		IntPtr szLabel;
		UInt32 uMaxLabelChars;
		UInt32 uVersionId;
		Int32 bIsNotAvailable;
	};
	
}
