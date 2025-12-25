using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class TriggerScopeValues
	{
		public const int ThisOrder = 0;
		public const int OtherOrder = 1;
		public const int AllOtherOrdersForGivenSecurity = 2;
		public const int AllOtherOrdersForGivenSecurityAndPrice = 3;
		public const int AllOtherOrdersForGivenSecurityAndSide = 4;
		public const int AllOtherOrdersForGivenSecurityPriceAndSide = 5;
	}
}
