using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AdjustmentTypeValues
	{
		public const int ProcessRequestAsMarginDisposition = 0;
		public const int DeltaPlus = 1;
		public const int DeltaMinus = 2;
		public const int Final = 3;
		public const int CustomerSpecificPosition = 4;
	}
}
