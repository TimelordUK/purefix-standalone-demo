using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradingSessionSubIDValues
	{
		public const string PreTrading = "1";
		public const string OpeningOrOpeningAuction = "2";
		public const string Continuous = "3";
		public const string ClosingOrClosingAuction = "4";
		public const string PostTrading = "5";
		public const string ScheduledIntradayAuction = "6";
		public const string Quiescent = "7";
		public const string AnyAuction = "8";
		public const string UnscheduledIntradayAuction = "9";
		public const string OutOfMainSessionTrading = "10";
		public const string PrivateAuction = "11";
		public const string PublicAuction = "12";
		public const string GroupAuction = "13";
	}
}
