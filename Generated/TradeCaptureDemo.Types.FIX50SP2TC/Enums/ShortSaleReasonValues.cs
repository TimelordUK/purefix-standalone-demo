using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ShortSaleReasonValues
	{
		public const int DealerSoldShort = 0;
		public const int DealerSoldShortExempt = 1;
		public const int SellingCustomerSoldShort = 2;
		public const int SellingCustomerSoldShortExempt = 3;
		public const int QualifiedServiceRepresentative = 4;
		public const int QsrOrAguContraSideSoldShortExempt = 5;
	}
}
