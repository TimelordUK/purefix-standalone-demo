using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeCollateralizationValues
	{
		public const int Uncollateralized = 0;
		public const int PartiallyCollateralized = 1;
		public const int OneWayCollaterallization = 2;
		public const int FullyCollateralized = 3;
		public const int NetExposure = 4;
	}
}
