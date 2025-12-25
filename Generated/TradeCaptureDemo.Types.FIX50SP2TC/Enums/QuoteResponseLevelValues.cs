using System;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public static class QuoteResponseLevelValues
	{
		public const int NoAcknowledgement = 0;
		public const int AcknowledgeOnlyNegativeOrErroneousQuotes = 1;
		public const int AcknowledgeEachQuoteMessage = 2;
		public const int SummaryAcknowledgement = 3;
	}
}
