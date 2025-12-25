using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassOrderRequestResultValues
	{
		public const int Successful = 0;
		public const int ResponseLevelNotSupported = 1;
		public const int InvalidMarket = 2;
		public const int InvalidMarketSegment = 3;
		public const int Other = 99;
	}
}
