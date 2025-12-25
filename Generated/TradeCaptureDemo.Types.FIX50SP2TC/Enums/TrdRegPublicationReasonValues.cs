using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TrdRegPublicationReasonValues
	{
		public const int NoBookOrderDueToAverageSpreadPrice = 0;
		public const int NoBookOrderDueToRefPrice = 1;
		public const int NoBookOrderDueToOtherConditions = 2;
		public const int NoPublicPriceDueToRefPrice = 3;
		public const int NoPublicPriceDueToIlliquid = 4;
		public const int NoPublicPriceDueToOrderSize = 5;
		public const int DeferralDueToLargeInScale = 6;
		public const int DeferralDueToIlliquid = 7;
		public const int DeferralDueToSizeSpecific = 8;
		public const int NoPublicPriceDueToLargeInScale = 9;
		public const int NoPublicPriceSizeDueToOrderHidden = 10;
		public const int ExemptedDueToSecuritiesFinancingTransaction = 11;
		public const int ExemptedDueToEscbPolicyTransaction = 12;
		public const int ExceptionDueToReportByPaper = 13;
		public const int ExceptionDueToTradeExecutedWithNonReportingParty = 14;
		public const int ExceptionDueToIntraFirmOrder = 15;
		public const int ReportedOutsideReportingHours = 16;
	}
}
