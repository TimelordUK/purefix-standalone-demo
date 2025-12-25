using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TimeInForceValues
	{
		public const string Day = "0";
		public const string GoodTillCancel = "1";
		public const string AtTheOpening = "2";
		public const string ImmediateOrCancel = "3";
		public const string FillOrKill = "4";
		public const string GoodTillCrossing = "5";
		public const string GoodTillDate = "6";
		public const string AtTheClose = "7";
		public const string GoodThroughCrossing = "8";
		public const string AtCrossing = "9";
		public const string GoodForTime = "A";
		public const string GoodForAuction = "B";
		public const string GoodForMonth = "C";
	}
}
