using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("d", FixVersion.FIX50SP2)]
	public sealed partial class SecurityDefinition : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 964, Type = TagType.Int, Offset = 2, Required = false)]
		public int? SecurityReportID {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 320, Type = TagType.String, Offset = 4, Required = false)]
		public string? SecurityReqID {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 5, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 322, Type = TagType.String, Offset = 6, Required = false)]
		public string? SecurityResponseID {get; set;}
		
		[TagDetails(Tag = 323, Type = TagType.Int, Offset = 7, Required = false)]
		public int? SecurityResponseType {get; set;}
		
		[TagDetails(Tag = 560, Type = TagType.Int, Offset = 8, Required = false)]
		public int? SecurityRequestResult {get; set;}
		
		[TagDetails(Tag = 1607, Type = TagType.Int, Offset = 9, Required = false)]
		public int? SecurityRejectReason {get; set;}
		
		[TagDetails(Tag = 292, Type = TagType.String, Offset = 10, Required = false)]
		public string? CorporateAction {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public SecurityClassificationGrp? SecurityClassificationGrp {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 17, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 18, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 2572, Type = TagType.Float, Offset = 19, Required = false)]
		public double? PreviousAdjustedOpenInterest {get; set;}
		
		[TagDetails(Tag = 2573, Type = TagType.Float, Offset = 20, Required = false)]
		public double? PreviousUnadjustedOpenInterest {get; set;}
		
		[TagDetails(Tag = 734, Type = TagType.Float, Offset = 21, Required = false)]
		public double? PriorSettlPrice {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 22, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 23, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 24, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 25, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[TagDetails(Tag = 1606, Type = TagType.Int, Offset = 26, Required = false)]
		public int? NumOfSimpleInstruments {get; set;}
		
		[TagDetails(Tag = 2562, Type = TagType.Int, Offset = 27, Required = false)]
		public int? NumOfComplexInstruments {get; set;}
		
		[Component(Offset = 28, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 30, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[Component(Offset = 31, Required = false)]
		public MarketSegmentGrp? MarketSegmentGrp {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 32, Required = false)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 2400, Type = TagType.LocalDate, Offset = 33, Required = false)]
		public DateOnly? EffectiveBusinessDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 34, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 35, Required = true)]
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
			if (SecurityReportID is not null) writer.WriteWholeNumber(964, SecurityReportID.Value);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (SecurityReqID is not null) writer.WriteString(320, SecurityReqID);
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (SecurityResponseID is not null) writer.WriteString(322, SecurityResponseID);
			if (SecurityResponseType is not null) writer.WriteWholeNumber(323, SecurityResponseType.Value);
			if (SecurityRequestResult is not null) writer.WriteWholeNumber(560, SecurityRequestResult.Value);
			if (SecurityRejectReason is not null) writer.WriteWholeNumber(1607, SecurityRejectReason.Value);
			if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (SecurityClassificationGrp is not null) ((IFixEncoder)SecurityClassificationGrp).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (PreviousAdjustedOpenInterest is not null) writer.WriteNumber(2572, PreviousAdjustedOpenInterest.Value);
			if (PreviousUnadjustedOpenInterest is not null) writer.WriteNumber(2573, PreviousUnadjustedOpenInterest.Value);
			if (PriorSettlPrice is not null) writer.WriteNumber(734, PriorSettlPrice.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (NumOfSimpleInstruments is not null) writer.WriteWholeNumber(1606, NumOfSimpleInstruments.Value);
			if (NumOfComplexInstruments is not null) writer.WriteWholeNumber(2562, NumOfComplexInstruments.Value);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (MarketSegmentGrp is not null) ((IFixEncoder)MarketSegmentGrp).Encode(writer);
			if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
			if (EffectiveBusinessDate is not null) writer.WriteLocalDateOnly(2400, EffectiveBusinessDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
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
			SecurityReportID = view.GetInt32(964);
			ClearingBusinessDate = view.GetDateOnly(715);
			SecurityReqID = view.GetString(320);
			OrderRequestID = view.GetInt32(2422);
			SecurityResponseID = view.GetString(322);
			SecurityResponseType = view.GetInt32(323);
			SecurityRequestResult = view.GetInt32(560);
			SecurityRejectReason = view.GetInt32(1607);
			CorporateAction = view.GetString(292);
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
			if (view.GetView("RelatedInstrumentGrp") is IMessageView viewRelatedInstrumentGrp)
			{
				RelatedInstrumentGrp = new();
				((IFixParser)RelatedInstrumentGrp).Parse(viewRelatedInstrumentGrp);
			}
			if (view.GetView("SecurityClassificationGrp") is IMessageView viewSecurityClassificationGrp)
			{
				SecurityClassificationGrp = new();
				((IFixParser)SecurityClassificationGrp).Parse(viewSecurityClassificationGrp);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			PreviousAdjustedOpenInterest = view.GetDouble(2572);
			PreviousUnadjustedOpenInterest = view.GetDouble(2573);
			PriorSettlPrice = view.GetDouble(734);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
			}
			NumOfSimpleInstruments = view.GetInt32(1606);
			NumOfComplexInstruments = view.GetInt32(2562);
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			if (view.GetView("MarketSegmentGrp") is IMessageView viewMarketSegmentGrp)
			{
				MarketSegmentGrp = new();
				((IFixParser)MarketSegmentGrp).Parse(viewMarketSegmentGrp);
			}
			LastUpdateTime = view.GetDateTime(779);
			EffectiveBusinessDate = view.GetDateOnly(2400);
			TransactTime = view.GetDateTime(60);
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
				case "SecurityReportID":
				{
					value = SecurityReportID;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "SecurityReqID":
				{
					value = SecurityReqID;
					break;
				}
				case "OrderRequestID":
				{
					value = OrderRequestID;
					break;
				}
				case "SecurityResponseID":
				{
					value = SecurityResponseID;
					break;
				}
				case "SecurityResponseType":
				{
					value = SecurityResponseType;
					break;
				}
				case "SecurityRequestResult":
				{
					value = SecurityRequestResult;
					break;
				}
				case "SecurityRejectReason":
				{
					value = SecurityRejectReason;
					break;
				}
				case "CorporateAction":
				{
					value = CorporateAction;
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
				case "RelatedInstrumentGrp":
				{
					value = RelatedInstrumentGrp;
					break;
				}
				case "SecurityClassificationGrp":
				{
					value = SecurityClassificationGrp;
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
				case "PreviousAdjustedOpenInterest":
				{
					value = PreviousAdjustedOpenInterest;
					break;
				}
				case "PreviousUnadjustedOpenInterest":
				{
					value = PreviousUnadjustedOpenInterest;
					break;
				}
				case "PriorSettlPrice":
				{
					value = PriorSettlPrice;
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
				case "Stipulations":
				{
					value = Stipulations;
					break;
				}
				case "NumOfSimpleInstruments":
				{
					value = NumOfSimpleInstruments;
					break;
				}
				case "NumOfComplexInstruments":
				{
					value = NumOfComplexInstruments;
					break;
				}
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "MarketSegmentGrp":
				{
					value = MarketSegmentGrp;
					break;
				}
				case "LastUpdateTime":
				{
					value = LastUpdateTime;
					break;
				}
				case "EffectiveBusinessDate":
				{
					value = EffectiveBusinessDate;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
			SecurityReportID = null;
			ClearingBusinessDate = null;
			SecurityReqID = null;
			OrderRequestID = null;
			SecurityResponseID = null;
			SecurityResponseType = null;
			SecurityRequestResult = null;
			SecurityRejectReason = null;
			CorporateAction = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)SecurityClassificationGrp)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			PreviousAdjustedOpenInterest = null;
			PreviousUnadjustedOpenInterest = null;
			PriorSettlPrice = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)Stipulations)?.Reset();
			NumOfSimpleInstruments = null;
			NumOfComplexInstruments = null;
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			((IFixReset?)MarketSegmentGrp)?.Reset();
			LastUpdateTime = null;
			EffectiveBusinessDate = null;
			TransactTime = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
