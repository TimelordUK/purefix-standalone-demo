using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeReportRejectReasonValues
	{
		public const int Successful = 0;
		public const int InvalidPartyInformation = 1;
		public const int UnknownInstrument = 2;
		public const int UnauthorizedToReportTrades = 3;
		public const int InvalidTradeType = 4;
		public const int PriceExceedsCurrentPriceBand = 5;
		public const int ReferencePriceNotAvailable = 6;
		public const int NotionalValueExceedsThreshold = 7;
		public const int Other = 99;
	}
}
