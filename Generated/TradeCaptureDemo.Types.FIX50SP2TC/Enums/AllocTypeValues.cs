using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AllocTypeValues
	{
		public const int Calculated = 1;
		public const int Preliminary = 2;
		public const int SellsideCalculatedUsingPreliminary = 3;
		public const int SellsideCalculatedWithoutPreliminary = 4;
		public const int ReadyToBook = 5;
		public const int BuysideReadyToBook = 6;
		public const int WarehouseInstruction = 7;
		public const int RequestToIntermediary = 8;
		public const int Accept = 9;
		public const int Reject = 10;
		public const int AcceptPending = 11;
		public const int IncompleteGroup = 12;
		public const int CompleteGroup = 13;
		public const int ReversalPending = 14;
		public const int ReopenGroup = 15;
		public const int CancelGroup = 16;
		public const int Giveup = 17;
		public const int Takeup = 18;
		public const int RefuseTakeup = 19;
		public const int InitiateReversal = 20;
		public const int Reverse = 21;
		public const int RefuseReversal = 22;
		public const int SubAllocationGiveup = 23;
		public const int ApproveGiveup = 24;
		public const int ApproveTakeup = 25;
		public const int NotionalValueAveragePxGroupAlloc = 26;
	}
}
