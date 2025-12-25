using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class LastLiquidityIndValues
	{
		public const int NeitherAddedNorRemovedLiquidity = 0;
		public const int AddedLiquidity = 1;
		public const int RemovedLiquidity = 2;
		public const int LiquidityRoutedOut = 3;
		public const int Auction = 4;
		public const int TriggeredStopOrder = 5;
		public const int TriggeredContingencyOrder = 6;
		public const int TriggeredMarketOrder = 7;
		public const int RemovedLiquidityAfterFirmOrderCommitment = 8;
		public const int AuctionExecutionAfterFirmOrderCommitment = 9;
		public const int Unknown = 10;
		public const int Other = 11;
	}
}
