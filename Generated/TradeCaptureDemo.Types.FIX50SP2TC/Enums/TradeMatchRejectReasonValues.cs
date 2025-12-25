using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeMatchRejectReasonValues
	{
		public const int Successful = 0;
		public const int InvalidPartyInformation = 1;
		public const int UnknownInstrument = 2;
		public const int Unauthorized = 3;
		public const int InvalidTradeType = 4;
		public const int Other = 99;
	}
}
