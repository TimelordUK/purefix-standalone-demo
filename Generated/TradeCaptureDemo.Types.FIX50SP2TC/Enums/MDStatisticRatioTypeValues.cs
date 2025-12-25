using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MDStatisticRatioTypeValues
	{
		public const int BuyersToSellers = 1;
		public const int UpticksToDownticks = 2;
		public const int MarketMakerToNonMarketMaker = 3;
		public const int AutomatedToNonAutomated = 4;
		public const int OrdersToTrades = 5;
		public const int QuotesToTrades = 6;
		public const int OrdersAndQuotesToTrades = 7;
		public const int FailedToTotalTradedValue = 8;
		public const int BenefitsToTotalTradedValue = 9;
		public const int FeesToTotalTradedValue = 10;
		public const int TradeVolumeToTotalTradedVolume = 11;
		public const int OrdersToTotalNumberOrders = 12;
	}
}
