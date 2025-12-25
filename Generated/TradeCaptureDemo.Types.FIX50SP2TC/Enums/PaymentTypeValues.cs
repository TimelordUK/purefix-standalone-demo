using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class PaymentTypeValues
	{
		public const int Brokerage = 0;
		public const int UpfrontFee = 1;
		public const int IndependentAmountCollateral = 2;
		public const int PrincipalExchange = 3;
		public const int NovationTermination = 4;
		public const int EarlyTerminationProvision = 5;
		public const int CancelableProvision = 6;
		public const int ExtendibleProvision = 7;
		public const int CapRateProvision = 8;
		public const int FloorRateProvision = 9;
		public const int OptionPremium = 10;
		public const int SettlementPayment = 11;
		public const int CashSettl = 12;
		public const int SecurityLending = 13;
		public const int Rebate = 14;
		public const int Other = 99;
	}
}
