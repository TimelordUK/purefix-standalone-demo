using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DX", FixVersion.FIX50SP2)]
	public sealed partial class TradeAggregationReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2792, Type = TagType.String, Offset = 1, Required = true)]
		public string? TradeAggregationReportID {get; set;}
		
		[TagDetails(Tag = 2786, Type = TagType.String, Offset = 2, Required = false)]
		public string? TradeAggregationRequestID {get; set;}
		
		[TagDetails(Tag = 2790, Type = TagType.Int, Offset = 3, Required = true)]
		public int? TradeAggregationRequestStatus {get; set;}
		
		[TagDetails(Tag = 1003, Type = TagType.String, Offset = 4, Required = false)]
		public string? TradeID {get; set;}
		
		[TagDetails(Tag = 2791, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TradeAggregationRejectReason {get; set;}
		
		[TagDetails(Tag = 2789, Type = TagType.Float, Offset = 6, Required = false)]
		public double? AggregatedQty {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 7, Required = false)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 2793, Type = TagType.Float, Offset = 8, Required = false)]
		public double? AvgSpotRate {get; set;}
		
		[TagDetails(Tag = 2794, Type = TagType.Float, Offset = 9, Required = false)]
		public double? AvgForwardPoints {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 12, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 13, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 14, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 15, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[Component(Offset = 16, Required = true)]
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
			if (TradeAggregationReportID is not null) writer.WriteString(2792, TradeAggregationReportID);
			if (TradeAggregationRequestID is not null) writer.WriteString(2786, TradeAggregationRequestID);
			if (TradeAggregationRequestStatus is not null) writer.WriteWholeNumber(2790, TradeAggregationRequestStatus.Value);
			if (TradeID is not null) writer.WriteString(1003, TradeID);
			if (TradeAggregationRejectReason is not null) writer.WriteWholeNumber(2791, TradeAggregationRejectReason.Value);
			if (AggregatedQty is not null) writer.WriteNumber(2789, AggregatedQty.Value);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (AvgSpotRate is not null) writer.WriteNumber(2793, AvgSpotRate.Value);
			if (AvgForwardPoints is not null) writer.WriteNumber(2794, AvgForwardPoints.Value);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
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
			TradeAggregationReportID = view.GetString(2792);
			TradeAggregationRequestID = view.GetString(2786);
			TradeAggregationRequestStatus = view.GetInt32(2790);
			TradeID = view.GetString(1003);
			TradeAggregationRejectReason = view.GetInt32(2791);
			AggregatedQty = view.GetDouble(2789);
			AvgPx = view.GetDouble(6);
			AvgSpotRate = view.GetDouble(2793);
			AvgForwardPoints = view.GetDouble(2794);
			SettlDate = view.GetDateOnly(64);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			Side = view.GetString(54);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
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
				case "TradeAggregationReportID":
				{
					value = TradeAggregationReportID;
					break;
				}
				case "TradeAggregationRequestID":
				{
					value = TradeAggregationRequestID;
					break;
				}
				case "TradeAggregationRequestStatus":
				{
					value = TradeAggregationRequestStatus;
					break;
				}
				case "TradeID":
				{
					value = TradeID;
					break;
				}
				case "TradeAggregationRejectReason":
				{
					value = TradeAggregationRejectReason;
					break;
				}
				case "AggregatedQty":
				{
					value = AggregatedQty;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "AvgSpotRate":
				{
					value = AvgSpotRate;
					break;
				}
				case "AvgForwardPoints":
				{
					value = AvgForwardPoints;
					break;
				}
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "Side":
				{
					value = Side;
					break;
				}
				case "RejectText":
				{
					value = RejectText;
					break;
				}
				case "EncodedRejectTextLen":
				{
					value = EncodedRejectTextLen;
					break;
				}
				case "EncodedRejectText":
				{
					value = EncodedRejectText;
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
			TradeAggregationReportID = null;
			TradeAggregationRequestID = null;
			TradeAggregationRequestStatus = null;
			TradeID = null;
			TradeAggregationRejectReason = null;
			AggregatedQty = null;
			AvgPx = null;
			AvgSpotRate = null;
			AvgForwardPoints = null;
			SettlDate = null;
			((IFixReset?)Instrument)?.Reset();
			Side = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
