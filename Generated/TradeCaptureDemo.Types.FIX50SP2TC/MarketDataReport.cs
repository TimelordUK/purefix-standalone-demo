using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DR", FixVersion.FIX50SP2)]
	public sealed partial class MarketDataReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 963, Type = TagType.Int, Offset = 2, Required = false)]
		public int? MDReportID {get; set;}
		
		[TagDetails(Tag = 2535, Type = TagType.Int, Offset = 3, Required = true)]
		public int? MDReportEvent {get; set;}
		
		[TagDetails(Tag = 2536, Type = TagType.Int, Offset = 4, Required = true)]
		public int? MDReportCount {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 5, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 2537, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TotNoMarketSegmentReports {get; set;}
		
		[TagDetails(Tag = 2538, Type = TagType.Int, Offset = 8, Required = false)]
		public int? TotNoInstrumentReports {get; set;}
		
		[TagDetails(Tag = 2539, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TotNoPartyDetailReports {get; set;}
		
		[TagDetails(Tag = 2540, Type = TagType.Int, Offset = 10, Required = false)]
		public int? TotNoEntitlementReports {get; set;}
		
		[TagDetails(Tag = 2541, Type = TagType.Int, Offset = 11, Required = false)]
		public int? TotNoRiskLimitReports {get; set;}
		
		[Component(Offset = 12, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (MDReportID is not null) writer.WriteWholeNumber(963, MDReportID.Value);
			if (MDReportEvent is not null) writer.WriteWholeNumber(2535, MDReportEvent.Value);
			if (MDReportCount is not null) writer.WriteWholeNumber(2536, MDReportCount.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (TotNoMarketSegmentReports is not null) writer.WriteWholeNumber(2537, TotNoMarketSegmentReports.Value);
			if (TotNoInstrumentReports is not null) writer.WriteWholeNumber(2538, TotNoInstrumentReports.Value);
			if (TotNoPartyDetailReports is not null) writer.WriteWholeNumber(2539, TotNoPartyDetailReports.Value);
			if (TotNoEntitlementReports is not null) writer.WriteWholeNumber(2540, TotNoEntitlementReports.Value);
			if (TotNoRiskLimitReports is not null) writer.WriteWholeNumber(2541, TotNoRiskLimitReports.Value);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			MDReportID = view.GetInt32(963);
			MDReportEvent = view.GetInt32(2535);
			MDReportCount = view.GetInt32(2536);
			TransactTime = view.GetDateTime(60);
			TotNumReports = view.GetInt32(911);
			TotNoMarketSegmentReports = view.GetInt32(2537);
			TotNoInstrumentReports = view.GetInt32(2538);
			TotNoPartyDetailReports = view.GetInt32(2539);
			TotNoEntitlementReports = view.GetInt32(2540);
			TotNoRiskLimitReports = view.GetInt32(2541);
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "MDReportID":
				{
					value = MDReportID;
					break;
				}
				case "MDReportEvent":
				{
					value = MDReportEvent;
					break;
				}
				case "MDReportCount":
				{
					value = MDReportCount;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "TotNoMarketSegmentReports":
				{
					value = TotNoMarketSegmentReports;
					break;
				}
				case "TotNoInstrumentReports":
				{
					value = TotNoInstrumentReports;
					break;
				}
				case "TotNoPartyDetailReports":
				{
					value = TotNoPartyDetailReports;
					break;
				}
				case "TotNoEntitlementReports":
				{
					value = TotNoEntitlementReports;
					break;
				}
				case "TotNoRiskLimitReports":
				{
					value = TotNoRiskLimitReports;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
					break;
				}
				default:
				{
					return false;
				}
			}
			return true;
		}
		
		void IFixReset.Reset()
		{
			((IFixReset?)StandardHeader)?.Reset();
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			MDReportID = null;
			MDReportEvent = null;
			MDReportCount = null;
			TransactTime = null;
			TotNumReports = null;
			TotNoMarketSegmentReports = null;
			TotNoInstrumentReports = null;
			TotNoPartyDetailReports = null;
			TotNoEntitlementReports = null;
			TotNoRiskLimitReports = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
