using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeReportingIndicatorValues
	{
		public const int NotReported = 0;
		public const int OnBook = 1;
		public const int SiSeller = 2;
		public const int SiBuyer = 3;
		public const int NonSiSeller = 4;
		public const int SubDelegationByFirm = 5;
		public const int Reportable = 6;
		public const int NonSiBuyer = 7;
		public const int OffBook = 8;
		public const int NotReportable = 9;
	}
}
