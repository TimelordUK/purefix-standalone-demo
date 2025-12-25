using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class MoneyLaunderingStatusValues
	{
		public const string Passed = "Y";
		public const string NotChecked = "N";
		public const string ExemptBelowLimit = "1";
		public const string ExemptMoneyType = "2";
		public const string ExemptAuthorised = "3";
	}
}
