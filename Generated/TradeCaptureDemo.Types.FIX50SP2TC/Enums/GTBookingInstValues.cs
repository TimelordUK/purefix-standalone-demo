using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class GTBookingInstValues
	{
		public const int BookOutAllTradesOnDayOfExecution = 0;
		public const int AccumulateUntilFilledOrExpired = 1;
		public const int AccumulateUntilVerballyNotifiedOtherwise = 2;
	}
}
