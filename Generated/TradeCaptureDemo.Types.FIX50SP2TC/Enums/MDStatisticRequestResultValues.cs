using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MDStatisticRequestResultValues
	{
		public const int Successful = 0;
		public const int InvalidOrUnknownMarket = 1;
		public const int InvalidOrUnknownMarketSegment = 2;
		public const int InvalidOrUnknownSecurityList = 3;
		public const int InvalidOrUnknownInstruments = 4;
		public const int InvalidParties = 5;
		public const int TradeDateOutOfSupportedRange = 6;
		public const int UnsupportedStatisticType = 7;
		public const int UnsupportedScopeOrSubScope = 8;
		public const int UnsupportedScopeType = 9;
		public const int MarketDepthNotSupported = 10;
		public const int FrequencyNotSupported = 11;
		public const int UnsupportedStatisticInterval = 12;
		public const int UnsupportedStatisticDateRange = 13;
		public const int UnsupportedStatisticTimeRange = 14;
		public const int UnsupportedRatioType = 15;
		public const int InvalidOrUnknownTradeInputSource = 16;
		public const int InvalidOrUnknownTradingSession = 17;
		public const int UnauthorizedForStatisticRequest = 18;
		public const int Other = 99;
	}
}
