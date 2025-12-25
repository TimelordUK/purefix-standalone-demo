using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ShortSaleExemptionReasonValues
	{
		public const int ExemptionReasonUnknown = 0;
		public const int IncomingSse = 1;
		public const int AboveNationalBestBid = 2;
		public const int DelayedDelivery = 3;
		public const int OddLot = 4;
		public const int DomesticArbitrage = 5;
		public const int InternationalArbitrage = 6;
		public const int UnderwriterOrSyndicateDistribution = 7;
		public const int RisklessPrincipal = 8;
		public const int Vwap = 9;
	}
}
