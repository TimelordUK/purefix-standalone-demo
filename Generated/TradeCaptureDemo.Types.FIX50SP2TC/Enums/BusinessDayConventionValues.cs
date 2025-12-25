using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class BusinessDayConventionValues
	{
		public const int NotApplicable = 0;
		public const int None = 1;
		public const int FollowingDay = 2;
		public const int FloatingRateNote = 3;
		public const int ModifiedFollowingDay = 4;
		public const int PrecedingDay = 5;
		public const int ModifiedPrecedingDay = 6;
		public const int NearestDay = 7;
	}
}
