using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class SecurityResponseTypeValues
	{
		public const int AcceptAsIs = 1;
		public const int AcceptWithRevisions = 2;
		public const int ListOfSecurityTypesReturnedPerRequest = 3;
		public const int ListOfSecuritiesReturnedPerRequest = 4;
		public const int RejectSecurityProposal = 5;
		public const int CannotMatchSelectionCriteria = 6;
	}
}
