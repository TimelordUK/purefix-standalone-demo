using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class StrikePriceDeterminationMethodValues
	{
		public const int FixedStrike = 1;
		public const int StrikeSetAtExpiration = 2;
		public const int StrikeSetToAverageAcrossLife = 3;
		public const int StrikeSetToOptimalValue = 4;
	}
}
