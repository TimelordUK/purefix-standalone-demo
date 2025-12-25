using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AllocRejCodeValues
	{
		public const int UnknownAccount = 0;
		public const int IncorrectQuantity = 1;
		public const int IncorrectAveragePrice = 2;
		public const int UnknownExecutingBrokerMnemonic = 3;
		public const int CommissionDifference = 4;
		public const int UnknownOrderId = 5;
		public const int UnknownListId = 6;
		public const int OtherSeeText = 7;
		public const int IncorrectAllocatedQuantity = 8;
		public const int CalculationDifference = 9;
		public const int UnknownOrStaleExecId = 10;
		public const int MismatchedData = 11;
		public const int UnknownClOrdId = 12;
		public const int WarehouseRequestRejected = 13;
		public const int DuplicateOrMissingIndividualAllocId = 14;
		public const int TradeNotRecognized = 15;
		public const int DuplicateTrade = 16;
		public const int IncorrectOrMissingInstrument = 17;
		public const int IncorrectOrMissingSettlDate = 18;
		public const int IncorrectOrMissingFundIdOrFundName = 19;
		public const int IncorrectOrMissingSettlInstructions = 20;
		public const int IncorrectOrMissingFees = 21;
		public const int IncorrectOrMissingTax = 22;
		public const int UnknownOrMissingParty = 23;
		public const int IncorrectOrMissingSide = 24;
		public const int IncorrectOrMissingNetMoney = 25;
		public const int IncorrectOrMissingTradeDate = 26;
		public const int IncorrectOrMissingSettlCcyInstructions = 27;
		public const int IncorrectOrMissingProcessCode = 28;
		public const int Other = 99;
	}
}
