using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TradeContinuationValues
	{
		public const int Novation = 0;
		public const int PartialNovation = 1;
		public const int TradeUnwind = 2;
		public const int PartialTradeUnwind = 3;
		public const int Exercise = 4;
		public const int Netting = 5;
		public const int FullNetting = 6;
		public const int PartialNetting = 7;
		public const int Amendment = 8;
		public const int Increase = 9;
		public const int CreditEvent = 10;
		public const int StrategicRestructuring = 11;
		public const int SuccessionEventReorganization = 12;
		public const int SuccessionEventRenaming = 13;
		public const int Porting = 14;
		public const int Withdrawl = 15;
		public const int Void = 16;
		public const int AccountTransfer = 17;
		public const int GiveUp = 18;
		public const int TakeUp = 19;
		public const int AveragePricing = 20;
		public const int Reversal = 21;
		public const int AllocTrdPosting = 22;
		public const int Cascade = 23;
		public const int Delivery = 24;
		public const int OptionAsgn = 25;
		public const int Expiration = 26;
		public const int Maturity = 27;
		public const int EqualPosAdj = 28;
		public const int UnequalPosAdj = 29;
		public const int Correction = 30;
		public const int EarlyTermination = 31;
		public const int Rerate = 32;
		public const int Other = 99;
	}
}
