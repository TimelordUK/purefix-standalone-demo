using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ExecRestatementReasonValues
	{
		public const int GtCorporateAction = 0;
		public const int GtRenewal = 1;
		public const int VerbalChange = 2;
		public const int RepricingOfOrder = 3;
		public const int BrokerOption = 4;
		public const int PartialDeclineOfOrderQty = 5;
		public const int CancelOnTradingHalt = 6;
		public const int CancelOnSystemFailure = 7;
		public const int Market = 8;
		public const int Canceled = 9;
		public const int WarehouseRecap = 10;
		public const int PegRefresh = 11;
		public const int CancelOnConnectionLoss = 12;
		public const int CancelOnLogout = 13;
		public const int AssignTimePriority = 14;
		public const int CancelledForTradePriceViolation = 15;
		public const int CancelledForCrossImbalance = 16;
		public const int CxldSmp = 17;
		public const int CxldSmpAggressive = 18;
		public const int CxldSmpPassive = 19;
		public const int CxldSmpAggressivePassive = 20;
		public const int Other = 99;
	}
}
