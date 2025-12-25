using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeRequestResultValues
	{
		public const int Successful = 0;
		public const int InvalidOrUnknownInstrument = 1;
		public const int InvalidTypeOfTradeRequested = 2;
		public const int InvalidParties = 3;
		public const int InvalidTransportTypeRequested = 4;
		public const int InvalidDestinationRequested = 5;
		public const int TradeRequestTypeNotSupported = 8;
		public const int NotAuthorized = 9;
		public const int Other = 99;
	}
}
