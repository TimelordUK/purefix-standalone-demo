using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TriggerTypeValues
	{
		public const string PartialExecution = "1";
		public const string SpecifiedTradingSession = "2";
		public const string NextAuction = "3";
		public const string PriceMovement = "4";
		public const string OnOrderEntryOrModification = "5";
	}
}
