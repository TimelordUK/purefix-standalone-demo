using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class BookingUnitValues
	{
		public const string EachPartialExecutionIsABookableUnit = "0";
		public const string AggregatePartialExecutionsOnThisOrder = "1";
		public const string AggregateExecutionsForThisSymbol = "2";
	}
}
