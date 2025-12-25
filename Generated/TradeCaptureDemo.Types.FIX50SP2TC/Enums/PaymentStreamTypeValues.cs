using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class PaymentStreamTypeValues
	{
		public const int Periodic = 0;
		public const int Initial = 1;
		public const int Single = 2;
		public const int Dividend = 3;
		public const int Interest = 4;
		public const int DividendReturn = 5;
		public const int PriceReturn = 6;
		public const int TotalReturn = 7;
		public const int Variance = 8;
		public const int Correlation = 9;
	}
}
