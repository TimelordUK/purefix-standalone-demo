using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("EA", FixVersion.FIX50SP2)]
	public sealed partial class PayManagementReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2799, Type = TagType.String, Offset = 1, Required = true)]
		public string? PayReportID {get; set;}
		
		[TagDetails(Tag = 2812, Type = TagType.String, Offset = 2, Required = false)]
		public string? PayRequestID {get; set;}
		
		[TagDetails(Tag = 2804, Type = TagType.Int, Offset = 3, Required = true)]
		public int? PayReportTransType {get; set;}
		
		[TagDetails(Tag = 2803, Type = TagType.String, Offset = 4, Required = false)]
		public string? PayReportRefID {get; set;}
		
		[TagDetails(Tag = 2805, Type = TagType.String, Offset = 5, Required = false)]
		public string? ReplaceText {get; set;}
		
		[TagDetails(Tag = 2802, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedReplaceTextLen {get; set;}
		
		[TagDetails(Tag = 2801, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedReplaceText {get; set;}
		
		[TagDetails(Tag = 2813, Type = TagType.Int, Offset = 8, Required = false)]
		public int? PayRequestStatus {get; set;}
		
		[TagDetails(Tag = 2800, Type = TagType.Int, Offset = 9, Required = false)]
		public int? PayDisputeReason {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 10, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 11, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 12, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 13, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 14, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 15, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 16, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 17, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public RelatedTradeGrp? RelatedTradeGrp {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 21, Required = true)]
		public PostTradePayment? PostTradePayment {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public SettlDetails? SettlDetails {get; set;}
		
		[Component(Offset = 23, Required = true)]
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
			if (PayReportID is not null) writer.WriteString(2799, PayReportID);
			if (PayRequestID is not null) writer.WriteString(2812, PayRequestID);
			if (PayReportTransType is not null) writer.WriteWholeNumber(2804, PayReportTransType.Value);
			if (PayReportRefID is not null) writer.WriteString(2803, PayReportRefID);
			if (ReplaceText is not null) writer.WriteString(2805, ReplaceText);
			if (EncodedReplaceTextLen is not null) writer.WriteWholeNumber(2802, EncodedReplaceTextLen.Value);
			if (EncodedReplaceText is not null) writer.WriteBuffer(2801, EncodedReplaceText);
			if (PayRequestStatus is not null) writer.WriteWholeNumber(2813, PayRequestStatus.Value);
			if (PayDisputeReason is not null) writer.WriteWholeNumber(2800, PayDisputeReason.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (RelatedTradeGrp is not null) ((IFixEncoder)RelatedTradeGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (PostTradePayment is not null) ((IFixEncoder)PostTradePayment).Encode(writer);
			if (SettlDetails is not null) ((IFixEncoder)SettlDetails).Encode(writer);
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
			PayReportID = view.GetString(2799);
			PayRequestID = view.GetString(2812);
			PayReportTransType = view.GetInt32(2804);
			PayReportRefID = view.GetString(2803);
			ReplaceText = view.GetString(2805);
			EncodedReplaceTextLen = view.GetInt32(2802);
			EncodedReplaceText = view.GetByteArray(2801);
			PayRequestStatus = view.GetInt32(2813);
			PayDisputeReason = view.GetInt32(2800);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
			ClearingBusinessDate = view.GetDateOnly(715);
			TransactTime = view.GetDateTime(60);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("RelatedTradeGrp") is IMessageView viewRelatedTradeGrp)
			{
				RelatedTradeGrp = new();
				((IFixParser)RelatedTradeGrp).Parse(viewRelatedTradeGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("PostTradePayment") is IMessageView viewPostTradePayment)
			{
				PostTradePayment = new();
				((IFixParser)PostTradePayment).Parse(viewPostTradePayment);
			}
			if (view.GetView("SettlDetails") is IMessageView viewSettlDetails)
			{
				SettlDetails = new();
				((IFixParser)SettlDetails).Parse(viewSettlDetails);
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
				case "PayReportID":
				{
					value = PayReportID;
					break;
				}
				case "PayRequestID":
				{
					value = PayRequestID;
					break;
				}
				case "PayReportTransType":
				{
					value = PayReportTransType;
					break;
				}
				case "PayReportRefID":
				{
					value = PayReportRefID;
					break;
				}
				case "ReplaceText":
				{
					value = ReplaceText;
					break;
				}
				case "EncodedReplaceTextLen":
				{
					value = EncodedReplaceTextLen;
					break;
				}
				case "EncodedReplaceText":
				{
					value = EncodedReplaceText;
					break;
				}
				case "PayRequestStatus":
				{
					value = PayRequestStatus;
					break;
				}
				case "PayDisputeReason":
				{
					value = PayDisputeReason;
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
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "RelatedTradeGrp":
				{
					value = RelatedTradeGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "PostTradePayment":
				{
					value = PostTradePayment;
					break;
				}
				case "SettlDetails":
				{
					value = SettlDetails;
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
			PayReportID = null;
			PayRequestID = null;
			PayReportTransType = null;
			PayReportRefID = null;
			ReplaceText = null;
			EncodedReplaceTextLen = null;
			EncodedReplaceText = null;
			PayRequestStatus = null;
			PayDisputeReason = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			ClearingBusinessDate = null;
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)RelatedTradeGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)PostTradePayment)?.Reset();
			((IFixReset?)SettlDetails)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
