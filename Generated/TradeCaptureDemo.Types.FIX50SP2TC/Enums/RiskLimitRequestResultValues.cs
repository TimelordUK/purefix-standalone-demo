using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RiskLimitRequestResultValues
	{
		public const int Successful = 0;
		public const int InvalidParty = 1;
		public const int InvalidRelatedParty = 2;
		public const int InvalidRiskLimitType = 3;
		public const int InvalidRiskLimitId = 4;
		public const int InvalidRiskLimitAmount = 5;
		public const int InvalidRiskWarningLevelAction = 6;
		public const int InvalidRiskInstrumentScope = 7;
		public const int RiskLimitActionsNotSupported = 8;
		public const int WarningLevelsNotSupported = 9;
		public const int WarningLevelActionsNotSupported = 10;
		public const int RiskInstrumentScopeNotSupported = 11;
		public const int RiskLimitNotApprovedForParty = 12;
		public const int RiskLimitAlreadyDefinedForParty = 13;
		public const int InstrumentNotApprovedForParty = 14;
		public const int NotAuthorized = 98;
		public const int Other = 99;
	}
}
