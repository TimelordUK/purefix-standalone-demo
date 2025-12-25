using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MDStatisticIntervalTypeValues
	{
		public const int SlidingWindow = 1;
		public const int SlidingWindowPeak = 2;
		public const int FixedDateRange = 3;
		public const int FixedTimeRange = 4;
		public const int CurrentTimeUnit = 5;
		public const int PreviousTimeUnit = 6;
		public const int MaximumRange = 7;
		public const int MaximumRangeUpToPreviousTimeUnit = 8;
	}
}
