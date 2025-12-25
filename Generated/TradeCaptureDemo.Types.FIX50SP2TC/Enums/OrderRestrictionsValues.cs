using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrderRestrictionsValues
	{
		public const string ProgramTrade = "1";
		public const string IndexArbitrage = "2";
		public const string NonIndexArbitrage = "3";
		public const string CompetingMarketMaker = "4";
		public const string ActingAsMarketMakerOrSpecialistInSecurity = "5";
		public const string ActingAsMarketMakerOrSpecialistInUnderlying = "6";
		public const string ForeignEntity = "7";
		public const string ExternalMarketParticipant = "8";
		public const string ExternalInterConnectedMarketLinkage = "9";
		public const string RisklessArbitrage = "A";
		public const string IssuerHolding = "B";
		public const string IssuePriceStabilization = "C";
		public const string NonAlgorithmic = "D";
		public const string Algorithmic = "E";
		public const string Cross = "F";
		public const string InsiderAccount = "G";
		public const string SignificantShareholder = "H";
		public const string NormalCourseIssuerBid = "I";
	}
}
