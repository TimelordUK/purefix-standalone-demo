using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DO", FixVersion.FIX50SP2)]
	public sealed partial class MarketDataStatisticsRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2452, Type = TagType.String, Offset = 1, Required = true)]
		public string? MDStatisticReqID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 2, Required = true)]
		public string? SubscriptionRequestType {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 4, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 5, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 6, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1396, Type = TagType.String, Offset = 7, Required = false)]
		public string? MarketSegmentDesc {get; set;}
		
		[TagDetails(Tag = 1397, Type = TagType.Length, Offset = 8, Required = false)]
		public int? EncodedMktSegmDescLen {get; set;}
		
		[TagDetails(Tag = 1398, Type = TagType.RawData, Offset = 9, Required = false)]
		public byte[]? EncodedMktSegmDesc {get; set;}
		
		[TagDetails(Tag = 1465, Type = TagType.String, Offset = 10, Required = false)]
		public string? SecurityListID {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 17, Required = true)]
		public MDStatisticReqGrp? MDStatisticReqGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 18, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 19, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 20, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 21, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 22, Required = true)]
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
			if (MDStatisticReqID is not null) writer.WriteString(2452, MDStatisticReqID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MarketSegmentDesc is not null) writer.WriteString(1396, MarketSegmentDesc);
			if (EncodedMktSegmDescLen is not null) writer.WriteWholeNumber(1397, EncodedMktSegmDescLen.Value);
			if (EncodedMktSegmDesc is not null) writer.WriteBuffer(1398, EncodedMktSegmDesc);
			if (SecurityListID is not null) writer.WriteString(1465, SecurityListID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (MDStatisticReqGrp is not null) ((IFixEncoder)MDStatisticReqGrp).Encode(writer);
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
			MDStatisticReqID = view.GetString(2452);
			SubscriptionRequestType = view.GetString(263);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			TradeDate = view.GetDateOnly(75);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			MarketSegmentDesc = view.GetString(1396);
			EncodedMktSegmDescLen = view.GetInt32(1397);
			EncodedMktSegmDesc = view.GetByteArray(1398);
			SecurityListID = view.GetString(1465);
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
			if (view.GetView("MDStatisticReqGrp") is IMessageView viewMDStatisticReqGrp)
			{
				MDStatisticReqGrp = new();
				((IFixParser)MDStatisticReqGrp).Parse(viewMDStatisticReqGrp);
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
				case "MDStatisticReqID":
				{
					value = MDStatisticReqID;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
				case "MarketSegmentDesc":
				{
					value = MarketSegmentDesc;
					break;
				}
				case "EncodedMktSegmDescLen":
				{
					value = EncodedMktSegmDescLen;
					break;
				}
				case "EncodedMktSegmDesc":
				{
					value = EncodedMktSegmDesc;
					break;
				}
				case "SecurityListID":
				{
					value = SecurityListID;
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
				case "MDStatisticReqGrp":
				{
					value = MDStatisticReqGrp;
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
			MDStatisticReqID = null;
			SubscriptionRequestType = null;
			((IFixReset?)Parties)?.Reset();
			TradeDate = null;
			MarketID = null;
			MarketSegmentID = null;
			MarketSegmentDesc = null;
			EncodedMktSegmDescLen = null;
			EncodedMktSegmDesc = null;
			SecurityListID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)MDStatisticReqGrp)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
