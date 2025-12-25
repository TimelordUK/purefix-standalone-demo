using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OptPayoutTypeValues
	{
		public const int Vanilla = 1;
		public const int Capped = 2;
		public const int Binary = 3;
		public const int Asian = 4;
		public const int Barrier = 5;
		public const int DigitalBarrier = 6;
		public const int Lookback = 7;
		public const int OtherPathDependent = 8;
		public const int Other = 99;
	}
}
