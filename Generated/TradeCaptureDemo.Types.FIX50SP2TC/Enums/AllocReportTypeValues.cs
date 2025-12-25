using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AllocReportTypeValues
	{
		public const int PreliminaryRequestToIntermediary = 2;
		public const int SellsideCalculatedUsingPreliminary = 3;
		public const int SellsideCalculatedWithoutPreliminary = 4;
		public const int WarehouseRecap = 5;
		public const int RequestToIntermediary = 8;
		public const int Accept = 9;
		public const int Reject = 10;
		public const int AcceptPending = 11;
		public const int Complete = 12;
		public const int ReversePending = 14;
		public const int Giveup = 15;
		public const int Takeup = 16;
		public const int Reversal = 17;
		public const int Alleged = 18;
		public const int SubAllocationGiveup = 19;
	}
}
