using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CollAsgnReasonValues
	{
		public const int Initial = 0;
		public const int Scheduled = 1;
		public const int TimeWarning = 2;
		public const int MarginDeficiency = 3;
		public const int MarginExcess = 4;
		public const int ForwardCollateralDemand = 5;
		public const int EventOfDefault = 6;
		public const int AdverseTaxEvent = 7;
		public const int TransferDeposit = 8;
		public const int TransferWithdrawal = 9;
		public const int Pledge = 10;
	}
}
