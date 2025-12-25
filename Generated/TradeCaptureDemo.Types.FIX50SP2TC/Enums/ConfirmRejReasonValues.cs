using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class ConfirmRejReasonValues
	{
		public const int MismatchedAccount = 1;
		public const int MissingSettlementInstructions = 2;
		public const int UnknownOrMissingIndividualAllocId = 3;
		public const int TransactionNotRecognized = 4;
		public const int DuplicateTransaction = 5;
		public const int IncorrectOrMissingInstrument = 6;
		public const int IncorrectOrMissingPrice = 7;
		public const int IncorrectOrMissingCommission = 8;
		public const int IncorrectOrMissingSettlDate = 9;
		public const int IncorrectOrMissingFundIdOrFundName = 10;
		public const int IncorrectOrMissingQuantity = 11;
		public const int IncorrectOrMissingFees = 12;
		public const int IncorrectOrMissingTax = 13;
		public const int IncorrectOrMissingParty = 14;
		public const int IncorrectOrMissingSide = 15;
		public const int IncorrectOrMissingNetMoney = 16;
		public const int IncorrectOrMissingTradeDate = 17;
		public const int IncorrectOrMissingSettlCcyInstructions = 18;
		public const int IncorrectOrMissingCapacity = 19;
		public const int Other = 99;
	}
}
