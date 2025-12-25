using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AU", FixVersion.FIX50SP2)]
	public sealed partial class ConfirmationAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 664, Type = TagType.String, Offset = 1, Required = true)]
		public string? ConfirmID {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 2, Required = true)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 3, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 940, Type = TagType.Int, Offset = 4, Required = true)]
		public int? AffirmStatus {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[TagDetails(Tag = 2390, Type = TagType.String, Offset = 6, Required = false)]
		public string? TradeConfirmationReferenceID {get; set;}
		
		[TagDetails(Tag = 774, Type = TagType.Int, Offset = 7, Required = false)]
		public int? ConfirmRejReason {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 8, Required = false)]
		public string? MatchStatus {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public MatchExceptionGrp? MatchExceptionGrp {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public MatchingDataPointGrp? MatchingDataPointGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 11, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 12, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 13, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 14, Required = true)]
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
			if (ConfirmID is not null) writer.WriteString(664, ConfirmID);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (AffirmStatus is not null) writer.WriteWholeNumber(940, AffirmStatus.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (TradeConfirmationReferenceID is not null) writer.WriteString(2390, TradeConfirmationReferenceID);
			if (ConfirmRejReason is not null) writer.WriteWholeNumber(774, ConfirmRejReason.Value);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (MatchExceptionGrp is not null) ((IFixEncoder)MatchExceptionGrp).Encode(writer);
			if (MatchingDataPointGrp is not null) ((IFixEncoder)MatchingDataPointGrp).Encode(writer);
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
			ConfirmID = view.GetString(664);
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			AffirmStatus = view.GetInt32(940);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			TradeConfirmationReferenceID = view.GetString(2390);
			ConfirmRejReason = view.GetInt32(774);
			MatchStatus = view.GetString(573);
			if (view.GetView("MatchExceptionGrp") is IMessageView viewMatchExceptionGrp)
			{
				MatchExceptionGrp = new();
				((IFixParser)MatchExceptionGrp).Parse(viewMatchExceptionGrp);
			}
			if (view.GetView("MatchingDataPointGrp") is IMessageView viewMatchingDataPointGrp)
			{
				MatchingDataPointGrp = new();
				((IFixParser)MatchingDataPointGrp).Parse(viewMatchingDataPointGrp);
			}
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
				case "ConfirmID":
				{
					value = ConfirmID;
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
				case "AffirmStatus":
				{
					value = AffirmStatus;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "TradeConfirmationReferenceID":
				{
					value = TradeConfirmationReferenceID;
					break;
				}
				case "ConfirmRejReason":
				{
					value = ConfirmRejReason;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
					break;
				}
				case "MatchExceptionGrp":
				{
					value = MatchExceptionGrp;
					break;
				}
				case "MatchingDataPointGrp":
				{
					value = MatchingDataPointGrp;
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
			ConfirmID = null;
			TradeDate = null;
			TransactTime = null;
			AffirmStatus = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			TradeConfirmationReferenceID = null;
			ConfirmRejReason = null;
			MatchStatus = null;
			((IFixReset?)MatchExceptionGrp)?.Reset();
			((IFixReset?)MatchingDataPointGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
