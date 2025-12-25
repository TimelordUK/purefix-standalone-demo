using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CollInquiryQualifierValues
	{
		public const int TradeDate = 0;
		public const int GcInstrument = 1;
		public const int CollateralInstrument = 2;
		public const int SubstitutionEligible = 3;
		public const int NotAssigned = 4;
		public const int PartiallyAssigned = 5;
		public const int FullyAssigned = 6;
		public const int OutstandingTrades = 7;
	}
}
