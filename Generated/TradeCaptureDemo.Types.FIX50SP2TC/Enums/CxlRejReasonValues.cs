using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CxlRejReasonValues
	{
		public const int TooLateToCancel = 0;
		public const int UnknownOrder = 1;
		public const int BrokerCredit = 2;
		public const int OrderAlreadyInPendingStatus = 3;
		public const int UnableToProcessOrderMassCancelRequest = 4;
		public const int OrigOrdModTime = 5;
		public const int DuplicateClOrdId = 6;
		public const int PriceExceedsCurrentPrice = 7;
		public const int PriceExceedsCurrentPriceBand = 8;
		public const int InvalidPriceIncrement = 18;
		public const int Other = 99;
	}
}
