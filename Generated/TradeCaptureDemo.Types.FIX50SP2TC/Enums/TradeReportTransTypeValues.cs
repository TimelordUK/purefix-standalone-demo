using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeReportTransTypeValues
	{
		public const int New = 0;
		public const int Cancel = 1;
		public const int Replace = 2;
		public const int Release = 3;
		public const int Reverse = 4;
		public const int CancelDueToBackOutOfTrade = 5;
	}
}
