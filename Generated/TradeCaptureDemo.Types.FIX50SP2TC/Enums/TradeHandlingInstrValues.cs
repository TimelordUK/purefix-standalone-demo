using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeHandlingInstrValues
	{
		public const string TradeConfirmation = "0";
		public const string TwoPartyReport = "1";
		public const string OnePartyReportForMatching = "2";
		public const string OnePartyReportForPassThrough = "3";
		public const string AutomatedFloorOrderRouting = "4";
		public const string TwoPartyReportForClaim = "5";
		public const string OnePartyReport = "6";
		public const string ThirdPtyRptForPassThrough = "7";
		public const string OnePartyReportAutoMatch = "8";
	}
}
