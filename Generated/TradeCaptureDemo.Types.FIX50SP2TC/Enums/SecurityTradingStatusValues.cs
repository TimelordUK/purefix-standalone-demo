using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityTradingStatusValues
	{
		public const int OpeningDelay = 1;
		public const int TradingHalt = 2;
		public const int Resume = 3;
		public const int NoOpen = 4;
		public const int PriceIndication = 5;
		public const int TradingRangeIndication = 6;
		public const int MarketImbalanceBuy = 7;
		public const int MarketImbalanceSell = 8;
		public const int MarketOnCloseImbalanceBuy = 9;
		public const int MarketOnCloseImbalanceSell = 10;
		public const int NoMarketImbalance = 12;
		public const int NoMarketOnCloseImbalance = 13;
		public const int ItsPreOpening = 14;
		public const int NewPriceIndication = 15;
		public const int TradeDisseminationTime = 16;
		public const int ReadyToTrade = 17;
		public const int NotAvailableForTrading = 18;
		public const int NotTradedOnThisMarket = 19;
		public const int UnknownOrInvalid = 20;
		public const int PreOpen = 21;
		public const int OpeningRotation = 22;
		public const int FastMarket = 23;
		public const int PreCross = 24;
		public const int Cross = 25;
		public const int PostClose = 26;
		public const int NoCancel = 27;
	}
}
