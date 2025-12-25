using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ListExecInstTypeValues
	{
		public const string Immediate = "1";
		public const string WaitForInstruction = "2";
		public const string SellDriven = "3";
		public const string BuyDrivenCashTopUp = "4";
		public const string BuyDrivenCashWithdraw = "5";
	}
}
