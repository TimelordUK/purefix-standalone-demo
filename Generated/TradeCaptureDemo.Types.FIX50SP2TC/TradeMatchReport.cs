using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DC", FixVersion.FIX50SP2)]
	public sealed partial class TradeMatchReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 880, Type = TagType.String, Offset = 2, Required = true)]
		public string? TrdMatchID {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 3, Required = false)]
		public string? MatchType {get; set;}
		
		[TagDetails(Tag = 856, Type = TagType.Int, Offset = 4, Required = false)]
		public int? TradeReportType {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 5, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 6, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 7, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 9, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 10, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 11, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 1430, Type = TagType.String, Offset = 13, Required = false)]
		public string? VenueType {get; set;}
		
		[TagDetails(Tag = 1888, Type = TagType.UtcTimestamp, Offset = 14, Required = false)]
		public DateTime? TradeMatchTimestamp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 442, Type = TagType.String, Offset = 16, Required = false)]
		public string? MultiLegReportingType {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public InstrmtMatchSideGrp? InstrmtMatchSideGrp {get; set;}
		
		[Component(Offset = 18, Required = true)]
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
			if (TrdMatchID is not null) writer.WriteString(880, TrdMatchID);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (TradeReportType is not null) writer.WriteWholeNumber(856, TradeReportType.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (VenueType is not null) writer.WriteString(1430, VenueType);
			if (TradeMatchTimestamp is not null) writer.WriteUtcTimeStamp(1888, TradeMatchTimestamp.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (MultiLegReportingType is not null) writer.WriteString(442, MultiLegReportingType);
			if (InstrmtMatchSideGrp is not null) ((IFixEncoder)InstrmtMatchSideGrp).Encode(writer);
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
			TrdMatchID = view.GetString(880);
			MatchType = view.GetString(574);
			TradeReportType = view.GetInt32(856);
			ClearingBusinessDate = view.GetDateOnly(715);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			TradeDate = view.GetDateOnly(75);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			VenueType = view.GetString(1430);
			TradeMatchTimestamp = view.GetDateTime(1888);
			TransactTime = view.GetDateTime(60);
			MultiLegReportingType = view.GetString(442);
			if (view.GetView("InstrmtMatchSideGrp") is IMessageView viewInstrmtMatchSideGrp)
			{
				InstrmtMatchSideGrp = new();
				((IFixParser)InstrmtMatchSideGrp).Parse(viewInstrmtMatchSideGrp);
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
				case "TrdMatchID":
				{
					value = TrdMatchID;
					break;
				}
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "TradeReportType":
				{
					value = TradeReportType;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "TrdType":
				{
					value = TrdType;
					break;
				}
				case "TrdSubType":
				{
					value = TrdSubType;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
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
				case "TradingSessionID":
				{
					value = TradingSessionID;
					break;
				}
				case "TradingSessionSubID":
				{
					value = TradingSessionSubID;
					break;
				}
				case "VenueType":
				{
					value = VenueType;
					break;
				}
				case "TradeMatchTimestamp":
				{
					value = TradeMatchTimestamp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "MultiLegReportingType":
				{
					value = MultiLegReportingType;
					break;
				}
				case "InstrmtMatchSideGrp":
				{
					value = InstrmtMatchSideGrp;
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
			TrdMatchID = null;
			MatchType = null;
			TradeReportType = null;
			ClearingBusinessDate = null;
			TrdType = null;
			TrdSubType = null;
			TradeDate = null;
			MarketID = null;
			MarketSegmentID = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			VenueType = null;
			TradeMatchTimestamp = null;
			TransactTime = null;
			MultiLegReportingType = null;
			((IFixReset?)InstrmtMatchSideGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
