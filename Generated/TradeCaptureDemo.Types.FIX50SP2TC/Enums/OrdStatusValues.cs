using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrdStatusValues
	{
		public const string New = "0";
		public const string PartiallyFilled = "1";
		public const string Filled = "2";
		public const string DoneForDay = "3";
		public const string Canceled = "4";
		public const string Replaced = "5";
		public const string PendingCancel = "6";
		public const string Stopped = "7";
		public const string Rejected = "8";
		public const string Suspended = "9";
		public const string PendingNew = "A";
		public const string Calculated = "B";
		public const string Expired = "C";
		public const string AcceptedForBidding = "D";
		public const string PendingReplace = "E";
	}
}
