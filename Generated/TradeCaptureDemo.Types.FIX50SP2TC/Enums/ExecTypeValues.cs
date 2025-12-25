using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ExecTypeValues
	{
		public const string New = "0";
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
		public const string Restated = "D";
		public const string PendingReplace = "E";
		public const string Trade = "F";
		public const string TradeCorrect = "G";
		public const string TradeCancel = "H";
		public const string OrderStatus = "I";
		public const string TradeInAClearingHold = "J";
		public const string TradeHasBeenReleasedToClearing = "K";
		public const string TriggeredOrActivatedBySystem = "L";
		public const string Locked = "M";
		public const string Released = "N";
	}
}
