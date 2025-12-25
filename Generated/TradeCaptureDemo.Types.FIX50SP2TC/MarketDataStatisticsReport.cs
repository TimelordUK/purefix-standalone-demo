using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DP", FixVersion.FIX50SP2)]
	public sealed partial class MarketDataStatisticsReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 2453, Type = TagType.String, Offset = 2, Required = true)]
		public string? MDStatisticRptID {get; set;}
		
		[TagDetails(Tag = 2452, Type = TagType.String, Offset = 3, Required = false)]
		public string? MDStatisticReqID {get; set;}
		
		[TagDetails(Tag = 2473, Type = TagType.Int, Offset = 4, Required = false)]
		public int? MDStatisticRequestResult {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 5, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 582, Type = TagType.Int, Offset = 7, Required = false)]
		public int? CustOrderCapacity {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 9, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 10, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 1396, Type = TagType.String, Offset = 11, Required = false)]
		public string? MarketSegmentDesc {get; set;}
		
		[TagDetails(Tag = 1397, Type = TagType.Length, Offset = 12, Required = false)]
		public int? EncodedMktSegmDescLen {get; set;}
		
		[TagDetails(Tag = 1398, Type = TagType.RawData, Offset = 13, Required = false)]
		public byte[]? EncodedMktSegmDesc {get; set;}
		
		[TagDetails(Tag = 1465, Type = TagType.String, Offset = 14, Required = false)]
		public string? SecurityListID {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 15, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 16, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 19, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 20, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 22, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 23, Required = true)]
		public MDStatisticRptGrp? MDStatisticRptGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 24, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 25, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 26, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 27, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 28, Required = true)]
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
			if (MDStatisticRptID is not null) writer.WriteString(2453, MDStatisticRptID);
			if (MDStatisticReqID is not null) writer.WriteString(2452, MDStatisticReqID);
			if (MDStatisticRequestResult is not null) writer.WriteWholeNumber(2473, MDStatisticRequestResult.Value);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (MarketSegmentDesc is not null) writer.WriteString(1396, MarketSegmentDesc);
			if (EncodedMktSegmDescLen is not null) writer.WriteWholeNumber(1397, EncodedMktSegmDescLen.Value);
			if (EncodedMktSegmDesc is not null) writer.WriteBuffer(1398, EncodedMktSegmDesc);
			if (SecurityListID is not null) writer.WriteString(1465, SecurityListID);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (MDStatisticRptGrp is not null) ((IFixEncoder)MDStatisticRptGrp).Encode(writer);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			MDStatisticRptID = view.GetString(2453);
			MDStatisticReqID = view.GetString(2452);
			MDStatisticRequestResult = view.GetInt32(2473);
			UnsolicitedIndicator = view.GetBool(325);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			CustOrderCapacity = view.GetInt32(582);
			TradeDate = view.GetDateOnly(75);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			MarketSegmentDesc = view.GetString(1396);
			EncodedMktSegmDescLen = view.GetInt32(1397);
			EncodedMktSegmDesc = view.GetByteArray(1398);
			SecurityListID = view.GetString(1465);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
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
			if (view.GetView("MDStatisticRptGrp") is IMessageView viewMDStatisticRptGrp)
			{
				MDStatisticRptGrp = new();
				((IFixParser)MDStatisticRptGrp).Parse(viewMDStatisticRptGrp);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "MDStatisticRptID":
				{
					value = MDStatisticRptID;
					break;
				}
				case "MDStatisticReqID":
				{
					value = MDStatisticReqID;
					break;
				}
				case "MDStatisticRequestResult":
				{
					value = MDStatisticRequestResult;
					break;
				}
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "CustOrderCapacity":
				{
					value = CustOrderCapacity;
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
				case "Currency":
				{
					value = Currency;
					break;
				}
				case "CurrencyCodeSource":
				{
					value = CurrencyCodeSource;
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
				case "MDStatisticRptGrp":
				{
					value = MDStatisticRptGrp;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			MDStatisticRptID = null;
			MDStatisticReqID = null;
			MDStatisticRequestResult = null;
			UnsolicitedIndicator = null;
			((IFixReset?)Parties)?.Reset();
			CustOrderCapacity = null;
			TradeDate = null;
			MarketID = null;
			MarketSegmentID = null;
			MarketSegmentDesc = null;
			EncodedMktSegmDescLen = null;
			EncodedMktSegmDesc = null;
			SecurityListID = null;
			Currency = null;
			CurrencyCodeSource = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)MDStatisticRptGrp)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
