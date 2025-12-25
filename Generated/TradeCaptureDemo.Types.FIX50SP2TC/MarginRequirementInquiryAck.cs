using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CI", FixVersion.FIX50SP2)]
	public sealed partial class MarginRequirementInquiryAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1635, Type = TagType.String, Offset = 1, Required = true)]
		public string? MarginReqmtInqID {get; set;}
		
		[Component(Offset = 2, Required = true)]
		public MarginReqmtInqQualGrp? MarginReqmtInqQualGrp {get; set;}
		
		[TagDetails(Tag = 1640, Type = TagType.Int, Offset = 3, Required = true)]
		public int? MarginReqmtInqStatus {get; set;}
		
		[TagDetails(Tag = 1641, Type = TagType.Int, Offset = 4, Required = false)]
		public int? MarginReqmtInqResult {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 6, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 725, Type = TagType.Int, Offset = 7, Required = false)]
		public int? ResponseTransportType {get; set;}
		
		[TagDetails(Tag = 726, Type = TagType.String, Offset = 8, Required = false)]
		public string? ResponseDestination {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 10, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 11, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 12, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 1639, Type = TagType.String, Offset = 13, Required = false)]
		public string? MarginClass {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
		public DateTime? TransactTime {get; set;}
		
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
			if (MarginReqmtInqID is not null) writer.WriteString(1635, MarginReqmtInqID);
			if (MarginReqmtInqQualGrp is not null) ((IFixEncoder)MarginReqmtInqQualGrp).Encode(writer);
			if (MarginReqmtInqStatus is not null) writer.WriteWholeNumber(1640, MarginReqmtInqStatus.Value);
			if (MarginReqmtInqResult is not null) writer.WriteWholeNumber(1641, MarginReqmtInqResult.Value);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (ResponseTransportType is not null) writer.WriteWholeNumber(725, ResponseTransportType.Value);
			if (ResponseDestination is not null) writer.WriteString(726, ResponseDestination);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (MarginClass is not null) writer.WriteString(1639, MarginClass);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
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
			MarginReqmtInqID = view.GetString(1635);
			if (view.GetView("MarginReqmtInqQualGrp") is IMessageView viewMarginReqmtInqQualGrp)
			{
				MarginReqmtInqQualGrp = new();
				((IFixParser)MarginReqmtInqQualGrp).Parse(viewMarginReqmtInqQualGrp);
			}
			MarginReqmtInqStatus = view.GetInt32(1640);
			MarginReqmtInqResult = view.GetInt32(1641);
			TotNumReports = view.GetInt32(911);
			SubscriptionRequestType = view.GetString(263);
			ResponseTransportType = view.GetInt32(725);
			ResponseDestination = view.GetString(726);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			ClearingBusinessDate = view.GetDateOnly(715);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			MarginClass = view.GetString(1639);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			TransactTime = view.GetDateTime(60);
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
				case "MarginReqmtInqID":
				{
					value = MarginReqmtInqID;
					break;
				}
				case "MarginReqmtInqQualGrp":
				{
					value = MarginReqmtInqQualGrp;
					break;
				}
				case "MarginReqmtInqStatus":
				{
					value = MarginReqmtInqStatus;
					break;
				}
				case "MarginReqmtInqResult":
				{
					value = MarginReqmtInqResult;
					break;
				}
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "ResponseTransportType":
				{
					value = ResponseTransportType;
					break;
				}
				case "ResponseDestination":
				{
					value = ResponseDestination;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "SettlSessID":
				{
					value = SettlSessID;
					break;
				}
				case "SettlSessSubID":
				{
					value = SettlSessSubID;
					break;
				}
				case "MarginClass":
				{
					value = MarginClass;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
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
			MarginReqmtInqID = null;
			((IFixReset?)MarginReqmtInqQualGrp)?.Reset();
			MarginReqmtInqStatus = null;
			MarginReqmtInqResult = null;
			TotNumReports = null;
			SubscriptionRequestType = null;
			ResponseTransportType = null;
			ResponseDestination = null;
			((IFixReset?)Parties)?.Reset();
			ClearingBusinessDate = null;
			SettlSessID = null;
			SettlSessSubID = null;
			MarginClass = null;
			((IFixReset?)Instrument)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
