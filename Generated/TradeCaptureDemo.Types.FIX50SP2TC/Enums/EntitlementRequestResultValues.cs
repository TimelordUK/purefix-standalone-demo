using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class EntitlementRequestResultValues
	{
		public const int Successful = 0;
		public const int InvalidParty = 1;
		public const int InvalidRelatedParty = 2;
		public const int InvalidEntitlementType = 3;
		public const int InvalidEntitlementId = 4;
		public const int InvalidEntitlementAttribute = 5;
		public const int InvalidInstrumentScope = 6;
		public const int InvalidMarketSegmentScope = 7;
		public const int InvalidStartDate = 8;
		public const int InvalidEndDate = 9;
		public const int InstrumentScopeNotSupported = 10;
		public const int MarketSegmentScopeNotSupported = 11;
		public const int EntitlementNotApprovedForParty = 12;
		public const int EntitlementAlreadyDefinedForParty = 13;
		public const int InstrumentNotApprovedForParty = 14;
		public const int NotAuthorized = 98;
		public const int Other = 99;
	}
}
