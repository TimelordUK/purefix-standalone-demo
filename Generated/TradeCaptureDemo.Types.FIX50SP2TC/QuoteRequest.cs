using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("R", FixVersion.FIX50SP2)]
	public sealed partial class QuoteRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 131, Type = TagType.String, Offset = 1, Required = true)]
		public string? QuoteReqID {get; set;}
		
		[TagDetails(Tag = 644, Type = TagType.String, Offset = 2, Required = false)]
		public string? RFQReqID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 3, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 775, Type = TagType.Int, Offset = 4, Required = false)]
		public int? BookingType {get; set;}
		
		[TagDetails(Tag = 528, Type = TagType.String, Offset = 5, Required = false)]
		public string? OrderCapacity {get; set;}
		
		[TagDetails(Tag = 529, Type = TagType.String, Offset = 6, Required = false)]
		public string? OrderRestrictions {get; set;}
		
		[TagDetails(Tag = 1171, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? PrivateQuote {get; set;}
		
		[TagDetails(Tag = 1172, Type = TagType.Int, Offset = 8, Required = false)]
		public int? RespondentType {get; set;}
		
		[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 9, Required = false)]
		public bool? PreTradeAnonymity {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[Component(Offset = 11, Required = true)]
		public QuotReqGrp? QuotReqGrp {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 12, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 2404, Type = TagType.String, Offset = 13, Required = false)]
		public string? ComplianceText {get; set;}
		
		[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 14, Required = false)]
		public int? EncodedComplianceTextLen {get; set;}
		
		[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 15, Required = false)]
		public byte[]? EncodedComplianceText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 16, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 17, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 18, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 19, Required = true)]
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
			if (QuoteReqID is not null) writer.WriteString(131, QuoteReqID);
			if (RFQReqID is not null) writer.WriteString(644, RFQReqID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
			if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
			if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			if (PrivateQuote is not null) writer.WriteBoolean(1171, PrivateQuote.Value);
			if (RespondentType is not null) writer.WriteWholeNumber(1172, RespondentType.Value);
			if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (QuotReqGrp is not null) ((IFixEncoder)QuotReqGrp).Encode(writer);
			if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
			if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
			if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
			if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
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
			QuoteReqID = view.GetString(131);
			RFQReqID = view.GetString(644);
			ClOrdID = view.GetString(11);
			BookingType = view.GetInt32(775);
			OrderCapacity = view.GetString(528);
			OrderRestrictions = view.GetString(529);
			PrivateQuote = view.GetBool(1171);
			RespondentType = view.GetInt32(1172);
			PreTradeAnonymity = view.GetBool(1091);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			if (view.GetView("QuotReqGrp") is IMessageView viewQuotReqGrp)
			{
				QuotReqGrp = new();
				((IFixParser)QuotReqGrp).Parse(viewQuotReqGrp);
			}
			ComplianceID = view.GetString(376);
			ComplianceText = view.GetString(2404);
			EncodedComplianceTextLen = view.GetInt32(2351);
			EncodedComplianceText = view.GetByteArray(2352);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
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
				case "QuoteReqID":
				{
					value = QuoteReqID;
					break;
				}
				case "RFQReqID":
				{
					value = RFQReqID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "BookingType":
				{
					value = BookingType;
					break;
				}
				case "OrderCapacity":
				{
					value = OrderCapacity;
					break;
				}
				case "OrderRestrictions":
				{
					value = OrderRestrictions;
					break;
				}
				case "PrivateQuote":
				{
					value = PrivateQuote;
					break;
				}
				case "RespondentType":
				{
					value = RespondentType;
					break;
				}
				case "PreTradeAnonymity":
				{
					value = PreTradeAnonymity;
					break;
				}
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "QuotReqGrp":
				{
					value = QuotReqGrp;
					break;
				}
				case "ComplianceID":
				{
					value = ComplianceID;
					break;
				}
				case "ComplianceText":
				{
					value = ComplianceText;
					break;
				}
				case "EncodedComplianceTextLen":
				{
					value = EncodedComplianceTextLen;
					break;
				}
				case "EncodedComplianceText":
				{
					value = EncodedComplianceText;
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
			QuoteReqID = null;
			RFQReqID = null;
			ClOrdID = null;
			BookingType = null;
			OrderCapacity = null;
			OrderRestrictions = null;
			PrivateQuote = null;
			RespondentType = null;
			PreTradeAnonymity = null;
			((IFixReset?)RootParties)?.Reset();
			((IFixReset?)QuotReqGrp)?.Reset();
			ComplianceID = null;
			ComplianceText = null;
			EncodedComplianceTextLen = null;
			EncodedComplianceText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
