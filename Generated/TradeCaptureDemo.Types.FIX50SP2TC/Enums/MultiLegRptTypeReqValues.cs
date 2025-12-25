using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MultiLegRptTypeReqValues
	{
		public const int ReportByMulitlegSecurityOnly = 0;
		public const int ReportByMultilegSecurityAndInstrumentLegs = 1;
		public const int ReportByInstrumentLegsOnly = 2;
	}
}
