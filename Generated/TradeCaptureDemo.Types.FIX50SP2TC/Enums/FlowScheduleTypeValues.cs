using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class FlowScheduleTypeValues
	{
		public const int NercEasternOffPeak = 0;
		public const int NercWesternOffPeak = 1;
		public const int NercCalendarAllDaysInMonth = 2;
		public const int NercEasternPeak = 3;
		public const int NercWesternPeak = 4;
		public const int AllTimes = 5;
		public const int OnPeak = 6;
		public const int OffPeak = 7;
		public const int Base = 8;
		public const int Block = 9;
		public const int Other = 99;
	}
}
