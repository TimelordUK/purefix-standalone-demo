using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityStatusValues
	{
		public const string Active = "1";
		public const string Inactive = "2";
		public const string ActiveClosingOrdersOnly = "3";
		public const string Expired = "4";
		public const string Delisted = "5";
		public const string KnockedOut = "6";
		public const string KnockOutRevoked = "7";
		public const string PendingExpiry = "8";
		public const string Suspended = "9";
		public const string Published = "10";
		public const string PendingDeletion = "11";
	}
}
