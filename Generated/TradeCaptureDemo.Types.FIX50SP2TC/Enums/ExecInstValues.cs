using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ExecInstValues
	{
		public const string StayOnOfferSide = "0";
		public const string NotHeld = "1";
		public const string Work = "2";
		public const string GoAlong = "3";
		public const string OverTheDay = "4";
		public const string Held = "5";
		public const string ParticipateDoNotInitiate = "6";
		public const string StrictScale = "7";
		public const string TryToScale = "8";
		public const string StayOnBidSide = "9";
		public const string NoCross = "A";
		public const string OkToCross = "B";
		public const string CallFirst = "C";
		public const string PercentOfVolume = "D";
		public const string DoNotIncrease = "E";
		public const string DoNotReduce = "F";
		public const string AllOrNone = "G";
		public const string ReinstateOnSystemFailure = "H";
		public const string InstitutionsOnly = "I";
		public const string ReinstateOnTradingHalt = "J";
		public const string CancelOnTradingHalt = "K";
		public const string LastPeg = "L";
		public const string MidPricePeg = "M";
		public const string NonNegotiable = "N";
		public const string OpeningPeg = "O";
		public const string MarketPeg = "P";
		public const string CancelOnSystemFailure = "Q";
		public const string PrimaryPeg = "R";
		public const string Suspend = "S";
		public const string FixedPegToLocalBestBidOrOfferAtTimeOfOrder = "T";
		public const string CustomerDisplayInstruction = "U";
		public const string Netting = "V";
		public const string PegToVwap = "W";
		public const string TradeAlong = "X";
		public const string TryToStop = "Y";
		public const string CancelIfNotBest = "Z";
		public const string TrailingStopPeg = "a";
		public const string StrictLimit = "b";
		public const string IgnorePriceValidityChecks = "c";
		public const string PegToLimitPrice = "d";
		public const string WorkToTargetStrategy = "e";
		public const string IntermarketSweep = "f";
		public const string ExternalRoutingAllowed = "g";
		public const string ExternalRoutingNotAllowed = "h";
		public const string ImbalanceOnly = "i";
		public const string SingleExecutionRequestedForBlockTrade = "j";
		public const string BestExecution = "k";
		public const string SuspendOnSystemFailure = "l";
		public const string SuspendOnTradingHalt = "m";
		public const string ReinstateOnConnectionLoss = "n";
		public const string CancelOnConnectionLoss = "o";
		public const string SuspendOnConnectionLoss = "p";
		public const string Release = "q";
		public const string ExecuteAsDeltaNeutral = "r";
		public const string ExecuteAsDurationNeutral = "s";
		public const string ExecuteAsFxNeutral = "t";
		public const string MinGuaranteedFillEligible = "u";
		public const string BypassNonDisplayLiquidity = "v";
		public const string Lock = "w";
		public const string IgnoreNotionalValueChecks = "x";
		public const string TrdAtRefPx = "y";
		public const string AllowFacilitation = "z";
	}
}
