using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MatchExceptionTypeValues
	{
		public const int NoMatchingConfirmation = 0;
		public const int NoMatchingAllocation = 1;
		public const int AllocationDataElementMissing = 2;
		public const int ConfirmationDataElementMissing = 3;
		public const int DataDifferenceNotWithinTolerance = 4;
		public const int MatchWithinTolerance = 5;
		public const int Other = 99;
	}
}
