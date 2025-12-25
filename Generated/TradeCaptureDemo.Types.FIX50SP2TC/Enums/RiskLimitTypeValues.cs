using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class RiskLimitTypeValues
	{
		public const int CreditLimit = 0;
		public const int GrossLimit = 1;
		public const int NetLimit = 2;
		public const int Exposure = 3;
		public const int LongLimit = 4;
		public const int ShortLimit = 5;
		public const int CashMargin = 6;
		public const int AdditionalMargin = 7;
		public const int TotalMargin = 8;
		public const int LimitConsumed = 9;
		public const int ClipSize = 10;
		public const int MaxNotionalOrderSize = 11;
		public const int Dv01Pv01Limit = 12;
		public const int Cs01Limit = 13;
		public const int VolumeLimitPerTimePeriod = 14;
		public const int VolFilledPctOrdVolTmPeriod = 15;
		public const int NotlFilledPctNotlTmPeriod = 16;
		public const int TransactionExecutionLimitPerTimePeriod = 17;
	}
}
