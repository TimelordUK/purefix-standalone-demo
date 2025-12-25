using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class AuctionTypeValues
	{
		public const int None = 0;
		public const int BlockOrderAuction = 1;
		public const int DirectedOrderAuction = 2;
		public const int ExposureOrderAuction = 3;
		public const int FlashOrderAuction = 4;
		public const int FacilitationOrderAuction = 5;
		public const int SolicitationOrderAuction = 6;
		public const int PriceImprovementMechanism = 7;
		public const int DirectedOrderPriceImprovementMechanism = 8;
	}
}
