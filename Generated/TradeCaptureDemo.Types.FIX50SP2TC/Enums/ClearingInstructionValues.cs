using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ClearingInstructionValues
	{
		public const int ProcessNormally = 0;
		public const int ExcludeFromAllNetting = 1;
		public const int BilateralNettingOnly = 2;
		public const int ExClearing = 3;
		public const int SpecialTrade = 4;
		public const int MultilateralNetting = 5;
		public const int ClearAgainstCentralCounterparty = 6;
		public const int ExcludeFromCentralCounterparty = 7;
		public const int ManualMode = 8;
		public const int AutomaticPostingMode = 9;
		public const int AutomaticGiveUpMode = 10;
		public const int QualifiedServiceRepresentativeQsr = 11;
		public const int CustomerTrade = 12;
		public const int SelfClearing = 13;
		public const int BuyIn = 14;
	}
}
