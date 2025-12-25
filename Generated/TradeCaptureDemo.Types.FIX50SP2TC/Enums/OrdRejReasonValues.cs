using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrdRejReasonValues
	{
		public const int BrokerCredit = 0;
		public const int UnknownSymbol = 1;
		public const int ExchangeClosed = 2;
		public const int OrderExceedsLimit = 3;
		public const int TooLateToEnter = 4;
		public const int UnknownOrder = 5;
		public const int DuplicateOrder = 6;
		public const int DuplicateOfAVerballyCommunicatedOrder = 7;
		public const int StaleOrder = 8;
		public const int TradeAlongRequired = 9;
		public const int InvalidInvestorId = 10;
		public const int UnsupportedOrderCharacteristic = 11;
		public const int SurveillanceOption = 12;
		public const int IncorrectQuantity = 13;
		public const int IncorrectAllocatedQuantity = 14;
		public const int UnknownAccount = 15;
		public const int PriceExceedsCurrentPriceBand = 16;
		public const int InvalidPriceIncrement = 18;
		public const int ReferencePriceNotAvailable = 19;
		public const int NotionalValueExceedsThreshold = 20;
		public const int AlgorithmRiskThresholdBreached = 21;
		public const int ShortSellNotPermitted = 22;
		public const int ShortSellSecurityPreBorrowRestriction = 23;
		public const int ShortSellAccountPreBorrowRestriction = 24;
		public const int InsufficientCreditLimit = 25;
		public const int ExceededClipSizeLimit = 26;
		public const int ExceededMaxNotionalOrderAmt = 27;
		public const int ExceededDv01Pv01Limit = 28;
		public const int ExceededCs01Limit = 29;
		public const int Other = 99;
	}
}
