using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class CollStatusValues
	{
		public const int Unassigned = 0;
		public const int PartiallyAssigned = 1;
		public const int AssignmentProposed = 2;
		public const int Assigned = 3;
		public const int Challenged = 4;
		public const int Reused = 5;
	}
}
