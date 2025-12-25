using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MassActionReasonValues
	{
		public const int None = 0;
		public const int TradingRiskControl = 1;
		public const int ClearingRiskControl = 2;
		public const int MarketMakerProtection = 3;
		public const int StopTrading = 4;
		public const int EmergencyAction = 5;
		public const int SessionLossLogout = 6;
		public const int DuplicateLogin = 7;
		public const int ProductNotTraded = 8;
		public const int InstrumentNotTraded = 9;
		public const int CompleInstrumentDeleted = 10;
		public const int CircuitBreakerActivated = 11;
		public const int Other = 99;
	}
}
