using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AT", FixVersion.FIX50SP2)]
	public sealed partial class AllocationReportAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 755, Type = TagType.String, Offset = 1, Required = true)]
		public string? AllocReportID {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 2, Required = false)]
		public string? AllocID {get; set;}
		
		[TagDetails(Tag = 2758, Type = TagType.String, Offset = 3, Required = false)]
		public string? AllocRequestID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 819, Type = TagType.Int, Offset = 5, Required = false)]
		public int? AvgPxIndicator {get; set;}
		
		[TagDetails(Tag = 53, Type = TagType.Float, Offset = 6, Required = false)]
		public double? Quantity {get; set;}
		
		[TagDetails(Tag = 71, Type = TagType.String, Offset = 7, Required = false)]
		public string? AllocTransType {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 793, Type = TagType.String, Offset = 10, Required = false)]
		public string? SecondaryAllocID {get; set;}
		
		[TagDetails(Tag = 1730, Type = TagType.String, Offset = 11, Required = false)]
		public string? AllocGroupID {get; set;}
		
		[TagDetails(Tag = 1728, Type = TagType.String, Offset = 12, Required = false)]
		public string? FirmGroupID {get; set;}
		
		[TagDetails(Tag = 1731, Type = TagType.String, Offset = 13, Required = false)]
		public string? AvgPxGroupID {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 87, Type = TagType.Int, Offset = 16, Required = false)]
		public int? AllocStatus {get; set;}
		
		[TagDetails(Tag = 88, Type = TagType.Int, Offset = 17, Required = false)]
		public int? AllocRejCode {get; set;}
		
		[TagDetails(Tag = 794, Type = TagType.Int, Offset = 18, Required = false)]
		public int? AllocReportType {get; set;}
		
		[TagDetails(Tag = 808, Type = TagType.Int, Offset = 19, Required = false)]
		public int? AllocIntermedReqType {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 20, Required = false)]
		public string? MatchStatus {get; set;}
		
		[TagDetails(Tag = 1031, Type = TagType.String, Offset = 21, Required = false)]
		public string? CustOrderHandlingInst {get; set;}
		
		[TagDetails(Tag = 1032, Type = TagType.Int, Offset = 22, Required = false)]
		public int? OrderHandlingInstSource {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 23, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 24, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 25, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 26, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 27, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 28, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[Component(Offset = 30, Required = false)]
		public AllocAckGrp? AllocAckGrp {get; set;}
		
		[Component(Offset = 31, Required = true)]
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
			if (AllocReportID is not null) writer.WriteString(755, AllocReportID);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (AllocRequestID is not null) writer.WriteString(2758, AllocRequestID);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
			if (Quantity is not null) writer.WriteNumber(53, Quantity.Value);
			if (AllocTransType is not null) writer.WriteString(71, AllocTransType);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (SecondaryAllocID is not null) writer.WriteString(793, SecondaryAllocID);
			if (AllocGroupID is not null) writer.WriteString(1730, AllocGroupID);
			if (FirmGroupID is not null) writer.WriteString(1728, FirmGroupID);
			if (AvgPxGroupID is not null) writer.WriteString(1731, AvgPxGroupID);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (AllocStatus is not null) writer.WriteWholeNumber(87, AllocStatus.Value);
			if (AllocRejCode is not null) writer.WriteWholeNumber(88, AllocRejCode.Value);
			if (AllocReportType is not null) writer.WriteWholeNumber(794, AllocReportType.Value);
			if (AllocIntermedReqType is not null) writer.WriteWholeNumber(808, AllocIntermedReqType.Value);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (CustOrderHandlingInst is not null) writer.WriteString(1031, CustOrderHandlingInst);
			if (OrderHandlingInstSource is not null) writer.WriteWholeNumber(1032, OrderHandlingInstSource.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (AllocAckGrp is not null) ((IFixEncoder)AllocAckGrp).Encode(writer);
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
			AllocReportID = view.GetString(755);
			AllocID = view.GetString(70);
			AllocRequestID = view.GetString(2758);
			ClearingBusinessDate = view.GetDateOnly(715);
			AvgPxIndicator = view.GetInt32(819);
			Quantity = view.GetDouble(53);
			AllocTransType = view.GetString(71);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			SecondaryAllocID = view.GetString(793);
			AllocGroupID = view.GetString(1730);
			FirmGroupID = view.GetString(1728);
			AvgPxGroupID = view.GetString(1731);
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			AllocStatus = view.GetInt32(87);
			AllocRejCode = view.GetInt32(88);
			AllocReportType = view.GetInt32(794);
			AllocIntermedReqType = view.GetInt32(808);
			MatchStatus = view.GetString(573);
			CustOrderHandlingInst = view.GetString(1031);
			OrderHandlingInstSource = view.GetInt32(1032);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			if (view.GetView("AllocAckGrp") is IMessageView viewAllocAckGrp)
			{
				AllocAckGrp = new();
				((IFixParser)AllocAckGrp).Parse(viewAllocAckGrp);
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
				case "AllocReportID":
				{
					value = AllocReportID;
					break;
				}
				case "AllocID":
				{
					value = AllocID;
					break;
				}
				case "AllocRequestID":
				{
					value = AllocRequestID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "AvgPxIndicator":
				{
					value = AvgPxIndicator;
					break;
				}
				case "Quantity":
				{
					value = Quantity;
					break;
				}
				case "AllocTransType":
				{
					value = AllocTransType;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "SecondaryAllocID":
				{
					value = SecondaryAllocID;
					break;
				}
				case "AllocGroupID":
				{
					value = AllocGroupID;
					break;
				}
				case "FirmGroupID":
				{
					value = FirmGroupID;
					break;
				}
				case "AvgPxGroupID":
				{
					value = AvgPxGroupID;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "AllocStatus":
				{
					value = AllocStatus;
					break;
				}
				case "AllocRejCode":
				{
					value = AllocRejCode;
					break;
				}
				case "AllocReportType":
				{
					value = AllocReportType;
					break;
				}
				case "AllocIntermedReqType":
				{
					value = AllocIntermedReqType;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
					break;
				}
				case "CustOrderHandlingInst":
				{
					value = CustOrderHandlingInst;
					break;
				}
				case "OrderHandlingInstSource":
				{
					value = OrderHandlingInstSource;
					break;
				}
				case "Text":
				{
					value = Text;
					break;
				}
				case "EncodedTextLen":
				{
					value = EncodedTextLen;
					break;
				}
				case "EncodedText":
				{
					value = EncodedText;
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
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "AllocAckGrp":
				{
					value = AllocAckGrp;
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
			AllocReportID = null;
			AllocID = null;
			AllocRequestID = null;
			ClearingBusinessDate = null;
			AvgPxIndicator = null;
			Quantity = null;
			AllocTransType = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)Parties)?.Reset();
			SecondaryAllocID = null;
			AllocGroupID = null;
			FirmGroupID = null;
			AvgPxGroupID = null;
			TradeDate = null;
			TransactTime = null;
			AllocStatus = null;
			AllocRejCode = null;
			AllocReportType = null;
			AllocIntermedReqType = null;
			MatchStatus = null;
			CustOrderHandlingInst = null;
			OrderHandlingInstSource = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			((IFixReset?)AllocAckGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
