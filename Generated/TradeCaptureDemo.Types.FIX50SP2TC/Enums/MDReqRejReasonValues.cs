using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MDReqRejReasonValues
	{
		public const string UnknownSymbol = "0";
		public const string DuplicateMdReqId = "1";
		public const string InsufficientBandwidth = "2";
		public const string InsufficientPermissions = "3";
		public const string UnsupportedSubscriptionRequestType = "4";
		public const string UnsupportedMarketDepth = "5";
		public const string UnsupportedMdUpdateType = "6";
		public const string UnsupportedAggregatedBook = "7";
		public const string UnsupportedMdEntryType = "8";
		public const string UnsupportedTradingSessionId = "9";
		public const string UnsupportedScope = "A";
		public const string UnsupportedOpenCloseSettleFlag = "B";
		public const string UnsupportedMdImplicitDelete = "C";
		public const string InsufficientCredit = "D";
	}
}
