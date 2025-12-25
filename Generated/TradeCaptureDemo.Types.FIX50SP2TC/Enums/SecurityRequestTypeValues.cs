using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityRequestTypeValues
	{
		public const int RequestSecurityIdentityAndSpecifications = 0;
		public const int RequestSecurityIdentityForSpecifications = 1;
		public const int RequestListSecurityTypes = 2;
		public const int RequestListSecurities = 3;
		public const int Symbol = 4;
		public const int SecurityTypeAndOrCfiCode = 5;
		public const int Product = 6;
		public const int TradingSessionId = 7;
		public const int AllSecurities = 8;
		public const int MarketIdOrMarketId = 9;
	}
}
