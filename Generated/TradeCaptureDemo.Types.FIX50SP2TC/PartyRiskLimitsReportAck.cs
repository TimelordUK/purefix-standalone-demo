using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DE", FixVersion.FIX50SP2)]
	public sealed partial class PartyRiskLimitsReportAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1667, Type = TagType.String, Offset = 1, Required = true)]
		public string? RiskLimitReportID {get; set;}
		
		[TagDetails(Tag = 1666, Type = TagType.String, Offset = 2, Required = false)]
		public string? RiskLimitRequestID {get; set;}
		
		[TagDetails(Tag = 2316, Type = TagType.Int, Offset = 3, Required = true)]
		public int? RiskLimitReportStatus {get; set;}
		
		[TagDetails(Tag = 2317, Type = TagType.Int, Offset = 4, Required = false)]
		public int? RiskLimitReportRejectReason {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public PartyRiskLimitsUpdateGrp? PartyRiskLimitsUpdateGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 6, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 7, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 8, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 9, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 10, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 11, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 12, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 13, Required = true)]
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
			if (RiskLimitReportID is not null) writer.WriteString(1667, RiskLimitReportID);
			if (RiskLimitRequestID is not null) writer.WriteString(1666, RiskLimitRequestID);
			if (RiskLimitReportStatus is not null) writer.WriteWholeNumber(2316, RiskLimitReportStatus.Value);
			if (RiskLimitReportRejectReason is not null) writer.WriteWholeNumber(2317, RiskLimitReportRejectReason.Value);
			if (PartyRiskLimitsUpdateGrp is not null) ((IFixEncoder)PartyRiskLimitsUpdateGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
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
			RiskLimitReportID = view.GetString(1667);
			RiskLimitRequestID = view.GetString(1666);
			RiskLimitReportStatus = view.GetInt32(2316);
			RiskLimitReportRejectReason = view.GetInt32(2317);
			if (view.GetView("PartyRiskLimitsUpdateGrp") is IMessageView viewPartyRiskLimitsUpdateGrp)
			{
				PartyRiskLimitsUpdateGrp = new();
				((IFixParser)PartyRiskLimitsUpdateGrp).Parse(viewPartyRiskLimitsUpdateGrp);
			}
			TransactTime = view.GetDateTime(60);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
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
				case "RiskLimitReportID":
				{
					value = RiskLimitReportID;
					break;
				}
				case "RiskLimitRequestID":
				{
					value = RiskLimitRequestID;
					break;
				}
				case "RiskLimitReportStatus":
				{
					value = RiskLimitReportStatus;
					break;
				}
				case "RiskLimitReportRejectReason":
				{
					value = RiskLimitReportRejectReason;
					break;
				}
				case "PartyRiskLimitsUpdateGrp":
				{
					value = PartyRiskLimitsUpdateGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
			RiskLimitReportID = null;
			RiskLimitRequestID = null;
			RiskLimitReportStatus = null;
			RiskLimitReportRejectReason = null;
			((IFixReset?)PartyRiskLimitsUpdateGrp)?.Reset();
			TransactTime = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
