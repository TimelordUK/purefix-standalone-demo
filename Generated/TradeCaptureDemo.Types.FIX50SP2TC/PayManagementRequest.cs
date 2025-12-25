using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DY", FixVersion.FIX50SP2)]
	public sealed partial class PayManagementRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2812, Type = TagType.String, Offset = 1, Required = true)]
		public string? PayRequestID {get; set;}
		
		[TagDetails(Tag = 2811, Type = TagType.Int, Offset = 2, Required = true)]
		public int? PayRequestTransType {get; set;}
		
		[TagDetails(Tag = 2810, Type = TagType.String, Offset = 3, Required = false)]
		public string? PayRequestRefID {get; set;}
		
		[TagDetails(Tag = 2807, Type = TagType.String, Offset = 4, Required = false)]
		public string? CancelText {get; set;}
		
		[TagDetails(Tag = 2809, Type = TagType.Length, Offset = 5, Required = false)]
		public int? EncodedCancelTextLen {get; set;}
		
		[TagDetails(Tag = 2808, Type = TagType.RawData, Offset = 6, Required = false)]
		public byte[]? EncodedCancelText {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 8, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 9, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 10, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 11, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public RelatedTradeGrp? RelatedTradeGrp {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 15, Required = true)]
		public PostTradePayment? PostTradePayment {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public SettlDetails? SettlDetails {get; set;}
		
		[Component(Offset = 17, Required = true)]
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
			if (PayRequestID is not null) writer.WriteString(2812, PayRequestID);
			if (PayRequestTransType is not null) writer.WriteWholeNumber(2811, PayRequestTransType.Value);
			if (PayRequestRefID is not null) writer.WriteString(2810, PayRequestRefID);
			if (CancelText is not null) writer.WriteString(2807, CancelText);
			if (EncodedCancelTextLen is not null) writer.WriteWholeNumber(2809, EncodedCancelTextLen.Value);
			if (EncodedCancelText is not null) writer.WriteBuffer(2808, EncodedCancelText);
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
			PayRequestID = view.GetString(2812);
			PayRequestTransType = view.GetInt32(2811);
			PayRequestRefID = view.GetString(2810);
			CancelText = view.GetString(2807);
			EncodedCancelTextLen = view.GetInt32(2809);
			EncodedCancelText = view.GetByteArray(2808);
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
				case "PayRequestID":
				{
					value = PayRequestID;
					break;
				}
				case "PayRequestTransType":
				{
					value = PayRequestTransType;
					break;
				}
				case "PayRequestRefID":
				{
					value = PayRequestRefID;
					break;
				}
				case "CancelText":
				{
					value = CancelText;
					break;
				}
				case "EncodedCancelTextLen":
				{
					value = EncodedCancelTextLen;
					break;
				}
				case "EncodedCancelText":
				{
					value = EncodedCancelText;
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
			PayRequestID = null;
			PayRequestTransType = null;
			PayRequestRefID = null;
			CancelText = null;
			EncodedCancelTextLen = null;
			EncodedCancelText = null;
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
