using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class OrderAttributeTypeValues
	{
		public const int AggregatedOrder = 0;
		public const int PendingAllocation = 1;
		public const int LiquidityProvisionActivityOrder = 2;
		public const int RiskReductionOrder = 3;
		public const int AlgorithmicOrder = 4;
		public const int SystematicInternaliserOrder = 5;
		public const int AllExecutionsSubmittedToApa = 6;
		public const int OrderExecutionInstructedByClient = 7;
		public const int LargeInScale = 8;
		public const int Hidden = 9;
		public const int SubjectToEusto = 10;
		public const int SubjectToUksto = 11;
		public const int RepresentativeOrder = 12;
		public const int LinkageType = 13;
		public const int ExemptFromSto = 14;
	}
}
