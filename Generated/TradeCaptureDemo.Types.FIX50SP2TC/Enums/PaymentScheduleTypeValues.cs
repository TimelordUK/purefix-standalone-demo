using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class PaymentScheduleTypeValues
	{
		public const int Notional = 0;
		public const int CashFlow = 1;
		public const int FxLinkedNotional = 2;
		public const int FixedRate = 3;
		public const int FutureValueNotional = 4;
		public const int KnownAmount = 5;
		public const int FloatingRateMultiplier = 6;
		public const int Spread = 7;
		public const int CapRate = 8;
		public const int FloorRate = 9;
		public const int NonDeliverableSettlPaymentDates = 10;
		public const int NonDeliverableSettlCalculationDates = 11;
		public const int NonDeliverableFxFixingDates = 12;
		public const int SettlPeriodNotnl = 13;
		public const int SettlPeriodPx = 14;
		public const int CalcPeriod = 15;
		public const int DividendAccrualRateMultiplier = 16;
		public const int DividendAccrualRateSpread = 17;
		public const int DividendAccrualCapRate = 18;
		public const int DividendAccrualFloorRate = 19;
		public const int CompoundingRateMultiplier = 20;
		public const int CompoundingRateSpread = 21;
		public const int CompoundingCapRate = 22;
		public const int CompoundingFloorRate = 23;
	}
}
