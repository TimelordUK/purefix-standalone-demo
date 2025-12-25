using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MatchTypeValues
	{
		public const string OnePartyTradeReport = "1";
		public const string TwoPartyTradeReport = "2";
		public const string ConfirmedTradeReport = "3";
		public const string AutoMatch = "4";
		public const string CrossAuction = "5";
		public const string CounterOrderSelection = "6";
		public const string CallAuction = "7";
		public const string Issuing = "8";
		public const string SystematicInternaliser = "9";
		public const string AutoMatchLastLook = "10";
		public const string CrossAuctionLastLook = "11";
		public const string ActAcceptedTrade = "M3";
		public const string ActDefaultTrade = "M4";
		public const string ActDefaultAfterM2 = "M5";
		public const string Actm6Match = "M6";
		public const string ExactMatchPlus4BadgesExecTime = "A1";
		public const string ExactMatchPlus4Badges = "A2";
		public const string ExactMatchPlus2BadgesExecTime = "A3";
		public const string ExactMatchPlus2Badges = "A4";
		public const string ExactMatchPlusExecTime = "A5";
		public const string StampedAdvisoriesOrSpecialistAccepts = "AQ";
		public const string A1ExactMatchSummarizedQuantity = "S1";
		public const string A2ExactMatchSummarizedQuantity = "S2";
		public const string A3ExactMatchSummarizedQuantity = "S3";
		public const string A4ExactMatchSummarizedQuantity = "S4";
		public const string A5ExactMatchSummarizedQuantity = "S5";
		public const string ExactMatchMinusBadgesTimes = "M1";
		public const string SummarizedMatchMinusBadgesTimes = "M2";
		public const string OcsLockedIn = "MT";
	}
}
