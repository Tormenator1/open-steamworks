// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EBillingType : int
	{
		eNoCost = 0,
		eBillOnceOnly = 1,
		eBillMonthly = 2,
		eProofOfPrepurchaseOnly = 3,
		eGuestPass = 4,
		eHardwarePromo = 5,
		eGift = 6,
		eAutoGrant = 7,
		eNumBillingTypes = 8,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamSubscription
	{
		IntPtr szName;
		UInt32 uMaxNameChars;
		IntPtr puAppIds;
		UInt32 uMaxAppIds;
		UInt32 uId;
		UInt32 uNumApps;
		EBillingType eBillingType;
		UInt32 uCostInCents;
		UInt32 uNumDiscounts;
		Int32 bIsPreorder;
		Int32 bRequiresShippingAddress;
		UInt32 uDomesticShippingCostInCents;
		UInt32 uInternationalShippingCostInCents;
		[MarshalAs(UnmanagedType.I1)]
		bool bIsCyberCafeSubscription;
		UInt32 uGameCode;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
		string szGameCodeDesc;
		[MarshalAs(UnmanagedType.I1)]
		bool bIsDisabled;
		[MarshalAs(UnmanagedType.I1)]
		bool bRequiresCD;
		UInt32 uTerritoryCode;
		[MarshalAs(UnmanagedType.I1)]
		bool bIsSteam3Subscription;
	};
	
}
