using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("W", FixVersion.FIX50SP2)]
	public sealed partial class MarketDataSnapshotFullRefresh : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 2, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 963, Type = TagType.Int, Offset = 3, Required = false)]
		public int? MDReportID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 1021, Type = TagType.Int, Offset = 5, Required = false)]
		public int? MDBookType {get; set;}
		
		[TagDetails(Tag = 1173, Type = TagType.Int, Offset = 6, Required = false)]
		public int? MDSubBookType {get; set;}
		
		[TagDetails(Tag = 264, Type = TagType.Int, Offset = 7, Required = false)]
		public int? MarketDepth {get; set;}
		
		[TagDetails(Tag = 1022, Type = TagType.String, Offset = 8, Required = false)]
		public string? MDFeedType {get; set;}
		
		[TagDetails(Tag = 1683, Type = TagType.String, Offset = 9, Required = false)]
		public string? MDSubFeedType {get; set;}
		
		[TagDetails(Tag = 1187, Type = TagType.Boolean, Offset = 10, Required = false)]
		public bool? RefreshIndicator {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 11, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 262, Type = TagType.String, Offset = 12, Required = false)]
		public string? MDReqID {get; set;}
		
		[TagDetails(Tag = 1500, Type = TagType.String, Offset = 13, Required = false)]
		public string? MDStreamID {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 14, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 15, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[Component(Offset = 16, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 22, Required = true)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 291, Type = TagType.String, Offset = 23, Required = false)]
		public string? FinancialStatus {get; set;}
		
		[TagDetails(Tag = 292, Type = TagType.String, Offset = 24, Required = false)]
		public string? CorporateAction {get; set;}
		
		[TagDetails(Tag = 451, Type = TagType.Float, Offset = 25, Required = false)]
		public double? NetChgPrevDay {get; set;}
		
		[TagDetails(Tag = 1682, Type = TagType.Int, Offset = 26, Required = false)]
		public int? MDSecurityTradingStatus {get; set;}
		
		[TagDetails(Tag = 1684, Type = TagType.Int, Offset = 27, Required = false)]
		public int? MDHaltReason {get; set;}
		
		[Component(Offset = 28, Required = true)]
		public MDFullGrp? MDFullGrp {get; set;}
		
		[TagDetails(Tag = 813, Type = TagType.Int, Offset = 29, Required = false)]
		public int? ApplQueueDepth {get; set;}
		
		[TagDetails(Tag = 814, Type = TagType.Int, Offset = 30, Required = false)]
		public int? ApplQueueResolution {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[Component(Offset = 32, Required = true)]
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
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (MDReportID is not null) writer.WriteWholeNumber(963, MDReportID.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (MDBookType is not null) writer.WriteWholeNumber(1021, MDBookType.Value);
			if (MDSubBookType is not null) writer.WriteWholeNumber(1173, MDSubBookType.Value);
			if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
			if (MDFeedType is not null) writer.WriteString(1022, MDFeedType);
			if (MDSubFeedType is not null) writer.WriteString(1683, MDSubFeedType);
			if (RefreshIndicator is not null) writer.WriteBoolean(1187, RefreshIndicator.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (MDReqID is not null) writer.WriteString(262, MDReqID);
			if (MDStreamID is not null) writer.WriteString(1500, MDStreamID);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
			if (FinancialStatus is not null) writer.WriteString(291, FinancialStatus);
			if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
			if (NetChgPrevDay is not null) writer.WriteNumber(451, NetChgPrevDay.Value);
			if (MDSecurityTradingStatus is not null) writer.WriteWholeNumber(1682, MDSecurityTradingStatus.Value);
			if (MDHaltReason is not null) writer.WriteWholeNumber(1684, MDHaltReason.Value);
			if (MDFullGrp is not null) ((IFixEncoder)MDFullGrp).Encode(writer);
			if (ApplQueueDepth is not null) writer.WriteWholeNumber(813, ApplQueueDepth.Value);
			if (ApplQueueResolution is not null) writer.WriteWholeNumber(814, ApplQueueResolution.Value);
			if (RoutingGrp is not null) ((IFixEncoder)RoutingGrp).Encode(writer);
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
			TotNumReports = view.GetInt32(911);
			MDReportID = view.GetInt32(963);
			ClearingBusinessDate = view.GetDateOnly(715);
			MDBookType = view.GetInt32(1021);
			MDSubBookType = view.GetInt32(1173);
			MarketDepth = view.GetInt32(264);
			MDFeedType = view.GetString(1022);
			MDSubFeedType = view.GetString(1683);
			RefreshIndicator = view.GetBool(1187);
			TradeDate = view.GetDateOnly(75);
			MDReqID = view.GetString(262);
			MDStreamID = view.GetString(1500);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("InstrumentExtension") is IMessageView viewInstrumentExtension)
			{
				InstrumentExtension = new();
				((IFixParser)InstrumentExtension).Parse(viewInstrumentExtension);
			}
			if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
			{
				FinancingDetails = new();
				((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			LastUpdateTime = view.GetDateTime(779);
			FinancialStatus = view.GetString(291);
			CorporateAction = view.GetString(292);
			NetChgPrevDay = view.GetDouble(451);
			MDSecurityTradingStatus = view.GetInt32(1682);
			MDHaltReason = view.GetInt32(1684);
			if (view.GetView("MDFullGrp") is IMessageView viewMDFullGrp)
			{
				MDFullGrp = new();
				((IFixParser)MDFullGrp).Parse(viewMDFullGrp);
			}
			ApplQueueDepth = view.GetInt32(813);
			ApplQueueResolution = view.GetInt32(814);
			if (view.GetView("RoutingGrp") is IMessageView viewRoutingGrp)
			{
				RoutingGrp = new();
				((IFixParser)RoutingGrp).Parse(viewRoutingGrp);
			}
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
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "MDReportID":
				{
					value = MDReportID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "MDBookType":
				{
					value = MDBookType;
					break;
				}
				case "MDSubBookType":
				{
					value = MDSubBookType;
					break;
				}
				case "MarketDepth":
				{
					value = MarketDepth;
					break;
				}
				case "MDFeedType":
				{
					value = MDFeedType;
					break;
				}
				case "MDSubFeedType":
				{
					value = MDSubFeedType;
					break;
				}
				case "RefreshIndicator":
				{
					value = RefreshIndicator;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "MDReqID":
				{
					value = MDReqID;
					break;
				}
				case "MDStreamID":
				{
					value = MDStreamID;
					break;
				}
				case "MarketID":
				{
					value = MarketID;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "InstrumentExtension":
				{
					value = InstrumentExtension;
					break;
				}
				case "FinancingDetails":
				{
					value = FinancingDetails;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
					break;
				}
				case "LastUpdateTime":
				{
					value = LastUpdateTime;
					break;
				}
				case "FinancialStatus":
				{
					value = FinancialStatus;
					break;
				}
				case "CorporateAction":
				{
					value = CorporateAction;
					break;
				}
				case "NetChgPrevDay":
				{
					value = NetChgPrevDay;
					break;
				}
				case "MDSecurityTradingStatus":
				{
					value = MDSecurityTradingStatus;
					break;
				}
				case "MDHaltReason":
				{
					value = MDHaltReason;
					break;
				}
				case "MDFullGrp":
				{
					value = MDFullGrp;
					break;
				}
				case "ApplQueueDepth":
				{
					value = ApplQueueDepth;
					break;
				}
				case "ApplQueueResolution":
				{
					value = ApplQueueResolution;
					break;
				}
				case "RoutingGrp":
				{
					value = RoutingGrp;
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
			TotNumReports = null;
			MDReportID = null;
			ClearingBusinessDate = null;
			MDBookType = null;
			MDSubBookType = null;
			MarketDepth = null;
			MDFeedType = null;
			MDSubFeedType = null;
			RefreshIndicator = null;
			TradeDate = null;
			MDReqID = null;
			MDStreamID = null;
			MarketID = null;
			MarketSegmentID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			LastUpdateTime = null;
			FinancialStatus = null;
			CorporateAction = null;
			NetChgPrevDay = null;
			MDSecurityTradingStatus = null;
			MDHaltReason = null;
			((IFixReset?)MDFullGrp)?.Reset();
			ApplQueueDepth = null;
			ApplQueueResolution = null;
			((IFixReset?)RoutingGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
