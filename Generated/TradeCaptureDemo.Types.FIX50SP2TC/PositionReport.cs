using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AP", FixVersion.FIX50SP2)]
	public sealed partial class PositionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 721, Type = TagType.String, Offset = 2, Required = true)]
		public string? PosMaintRptID {get; set;}
		
		[TagDetails(Tag = 2618, Type = TagType.String, Offset = 3, Required = false)]
		public string? PositionID {get; set;}
		
		[TagDetails(Tag = 710, Type = TagType.String, Offset = 4, Required = false)]
		public string? PosReqID {get; set;}
		
		[TagDetails(Tag = 724, Type = TagType.Int, Offset = 5, Required = false)]
		public int? PosReqType {get; set;}
		
		[TagDetails(Tag = 2364, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PosReportAction {get; set;}
		
		[TagDetails(Tag = 1635, Type = TagType.String, Offset = 7, Required = false)]
		public string? MarginReqmtInqID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 8, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 727, Type = TagType.Int, Offset = 9, Required = false)]
		public int? TotalNumPosReports {get; set;}
		
		[TagDetails(Tag = 911, Type = TagType.Int, Offset = 10, Required = false)]
		public int? TotNumReports {get; set;}
		
		[TagDetails(Tag = 912, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? LastRptRequested {get; set;}
		
		[TagDetails(Tag = 728, Type = TagType.Int, Offset = 12, Required = false)]
		public int? PosReqResult {get; set;}
		
		[TagDetails(Tag = 325, Type = TagType.Boolean, Offset = 13, Required = false)]
		public bool? UnsolicitedIndicator {get; set;}
		
		[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 14, Required = false)]
		public int? RegulatoryReportType {get; set;}
		
		[TagDetails(Tag = 2869, Type = TagType.LocalDate, Offset = 15, Required = false)]
		public DateOnly? RegulatoryReportTypeBusinessDate {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public TransactionAttributeGrp? TransactionAttributeGrp {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 18, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2084, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? PreviousClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 2870, Type = TagType.String, Offset = 20, Required = false)]
		public string? ClearingPortfolioID {get; set;}
		
		[TagDetails(Tag = 716, Type = TagType.String, Offset = 21, Required = false)]
		public string? SettlSessID {get; set;}
		
		[TagDetails(Tag = 717, Type = TagType.String, Offset = 22, Required = false)]
		public string? SettlSessSubID {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 23, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 24, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 25, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1011, Type = TagType.String, Offset = 26, Required = false)]
		public string? MessageEventSource {get; set;}
		
		[TagDetails(Tag = 1832, Type = TagType.Int, Offset = 27, Required = false)]
		public int? ClearedIndicator {get; set;}
		
		[TagDetails(Tag = 1833, Type = TagType.Int, Offset = 28, Required = false)]
		public int? ContractRefPosType {get; set;}
		
		[TagDetails(Tag = 1834, Type = TagType.Int, Offset = 29, Required = false)]
		public int? PositionCapacity {get; set;}
		
		[TagDetails(Tag = 2101, Type = TagType.Boolean, Offset = 30, Required = false)]
		public bool? TerminatedIndicator {get; set;}
		
		[TagDetails(Tag = 2878, Type = TagType.LocalDate, Offset = 31, Required = false)]
		public DateOnly? TerminationDate {get; set;}
		
		[TagDetails(Tag = 2373, Type = TagType.Boolean, Offset = 32, Required = false)]
		public bool? IntraFirmTradeIndicator {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 33, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 34, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 35, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 36, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 1936, Type = TagType.Int, Offset = 37, Required = false)]
		public int? TradeCollateralization {get; set;}
		
		[Component(Offset = 38, Required = true)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 39, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 40, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 581, Type = TagType.Int, Offset = 41, Required = false)]
		public int? AccountType {get; set;}
		
		[TagDetails(Tag = 2375, Type = TagType.String, Offset = 42, Required = false)]
		public string? TaxonomyType {get; set;}
		
		[Component(Offset = 43, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 44, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 45, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 46, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 47, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 730, Type = TagType.Float, Offset = 48, Required = false)]
		public double? SettlPrice {get; set;}
		
		[TagDetails(Tag = 2366, Type = TagType.String, Offset = 49, Required = false)]
		public string? SettlPriceFxRateCalc {get; set;}
		
		[TagDetails(Tag = 2365, Type = TagType.Float, Offset = 50, Required = false)]
		public double? SettlForwardPoints {get; set;}
		
		[TagDetails(Tag = 1886, Type = TagType.String, Offset = 51, Required = false)]
		public string? SettlPriceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1887, Type = TagType.String, Offset = 52, Required = false)]
		public string? SettlPriceUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2960, Type = TagType.String, Offset = 53, Required = false)]
		public string? SettlPriceUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 731, Type = TagType.Int, Offset = 54, Required = false)]
		public int? SettlPriceType {get; set;}
		
		[TagDetails(Tag = 734, Type = TagType.Float, Offset = 55, Required = false)]
		public double? PriorSettlPrice {get; set;}
		
		[TagDetails(Tag = 1595, Type = TagType.Float, Offset = 56, Required = false)]
		public double? PositionContingentPrice {get; set;}
		
		[TagDetails(Tag = 1592, Type = TagType.Float, Offset = 57, Required = false)]
		public double? DiscountFactor {get; set;}
		
		[TagDetails(Tag = 2085, Type = TagType.LocalDate, Offset = 58, Required = false)]
		public DateOnly? ValuationDate {get; set;}
		
		[TagDetails(Tag = 2086, Type = TagType.String, Offset = 59, Required = false)]
		public string? ValuationTime {get; set;}
		
		[TagDetails(Tag = 2087, Type = TagType.String, Offset = 60, Required = false)]
		public string? ValuationBusinessCenter {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 61, Required = false)]
		public string? MatchStatus {get; set;}
		
		[Component(Offset = 62, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 63, Required = false)]
		public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
		
		[Component(Offset = 64, Required = false)]
		public CollateralAmountGrp? CollateralAmountGrp {get; set;}
		
		[TagDetails(Tag = 2868, Type = TagType.LocalDate, Offset = 65, Required = false)]
		public DateOnly? CollateralizationValueDate {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public PosUndInstrmtGrp? PosUndInstrmtGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 67, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 68, Required = false)]
		public PositionQty? PositionQty {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[Component(Offset = 70, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[Component(Offset = 71, Required = false)]
		public PaymentGrp? PaymentGrp {get; set;}
		
		[TagDetails(Tag = 506, Type = TagType.String, Offset = 72, Required = false)]
		public string? RegistStatus {get; set;}
		
		[TagDetails(Tag = 743, Type = TagType.LocalDate, Offset = 73, Required = false)]
		public DateOnly? DeliveryDate {get; set;}
		
		[TagDetails(Tag = 1434, Type = TagType.Int, Offset = 74, Required = false)]
		public int? ModelType {get; set;}
		
		[TagDetails(Tag = 811, Type = TagType.Float, Offset = 75, Required = false)]
		public double? PriceDelta {get; set;}
		
		[Component(Offset = 76, Required = false)]
		public RelatedTradeGrp? RelatedTradeGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 77, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 78, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 79, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 80, Required = true)]
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
			if (PosMaintRptID is not null) writer.WriteString(721, PosMaintRptID);
			if (PositionID is not null) writer.WriteString(2618, PositionID);
			if (PosReqID is not null) writer.WriteString(710, PosReqID);
			if (PosReqType is not null) writer.WriteWholeNumber(724, PosReqType.Value);
			if (PosReportAction is not null) writer.WriteWholeNumber(2364, PosReportAction.Value);
			if (MarginReqmtInqID is not null) writer.WriteString(1635, MarginReqmtInqID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (TotalNumPosReports is not null) writer.WriteWholeNumber(727, TotalNumPosReports.Value);
			if (TotNumReports is not null) writer.WriteWholeNumber(911, TotNumReports.Value);
			if (LastRptRequested is not null) writer.WriteBoolean(912, LastRptRequested.Value);
			if (PosReqResult is not null) writer.WriteWholeNumber(728, PosReqResult.Value);
			if (UnsolicitedIndicator is not null) writer.WriteBoolean(325, UnsolicitedIndicator.Value);
			if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
			if (RegulatoryReportTypeBusinessDate is not null) writer.WriteLocalDateOnly(2869, RegulatoryReportTypeBusinessDate.Value);
			if (TransactionAttributeGrp is not null) ((IFixEncoder)TransactionAttributeGrp).Encode(writer);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (PreviousClearingBusinessDate is not null) writer.WriteLocalDateOnly(2084, PreviousClearingBusinessDate.Value);
			if (ClearingPortfolioID is not null) writer.WriteString(2870, ClearingPortfolioID);
			if (SettlSessID is not null) writer.WriteString(716, SettlSessID);
			if (SettlSessSubID is not null) writer.WriteString(717, SettlSessSubID);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (MessageEventSource is not null) writer.WriteString(1011, MessageEventSource);
			if (ClearedIndicator is not null) writer.WriteWholeNumber(1832, ClearedIndicator.Value);
			if (ContractRefPosType is not null) writer.WriteWholeNumber(1833, ContractRefPosType.Value);
			if (PositionCapacity is not null) writer.WriteWholeNumber(1834, PositionCapacity.Value);
			if (TerminatedIndicator is not null) writer.WriteBoolean(2101, TerminatedIndicator.Value);
			if (TerminationDate is not null) writer.WriteLocalDateOnly(2878, TerminationDate.Value);
			if (IntraFirmTradeIndicator is not null) writer.WriteBoolean(2373, IntraFirmTradeIndicator.Value);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (TradeCollateralization is not null) writer.WriteWholeNumber(1936, TradeCollateralization.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
			if (TaxonomyType is not null) writer.WriteString(2375, TaxonomyType);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (SettlPrice is not null) writer.WriteNumber(730, SettlPrice.Value);
			if (SettlPriceFxRateCalc is not null) writer.WriteString(2366, SettlPriceFxRateCalc);
			if (SettlForwardPoints is not null) writer.WriteNumber(2365, SettlForwardPoints.Value);
			if (SettlPriceUnitOfMeasure is not null) writer.WriteString(1886, SettlPriceUnitOfMeasure);
			if (SettlPriceUnitOfMeasureCurrency is not null) writer.WriteString(1887, SettlPriceUnitOfMeasureCurrency);
			if (SettlPriceUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2960, SettlPriceUnitOfMeasureCurrencyCodeSource);
			if (SettlPriceType is not null) writer.WriteWholeNumber(731, SettlPriceType.Value);
			if (PriorSettlPrice is not null) writer.WriteNumber(734, PriorSettlPrice.Value);
			if (PositionContingentPrice is not null) writer.WriteNumber(1595, PositionContingentPrice.Value);
			if (DiscountFactor is not null) writer.WriteNumber(1592, DiscountFactor.Value);
			if (ValuationDate is not null) writer.WriteLocalDateOnly(2085, ValuationDate.Value);
			if (ValuationTime is not null) writer.WriteString(2086, ValuationTime);
			if (ValuationBusinessCenter is not null) writer.WriteString(2087, ValuationBusinessCenter);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
			if (CollateralAmountGrp is not null) ((IFixEncoder)CollateralAmountGrp).Encode(writer);
			if (CollateralizationValueDate is not null) writer.WriteLocalDateOnly(2868, CollateralizationValueDate.Value);
			if (PosUndInstrmtGrp is not null) ((IFixEncoder)PosUndInstrmtGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (PositionQty is not null) ((IFixEncoder)PositionQty).Encode(writer);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (PaymentGrp is not null) ((IFixEncoder)PaymentGrp).Encode(writer);
			if (RegistStatus is not null) writer.WriteString(506, RegistStatus);
			if (DeliveryDate is not null) writer.WriteLocalDateOnly(743, DeliveryDate.Value);
			if (ModelType is not null) writer.WriteWholeNumber(1434, ModelType.Value);
			if (PriceDelta is not null) writer.WriteNumber(811, PriceDelta.Value);
			if (RelatedTradeGrp is not null) ((IFixEncoder)RelatedTradeGrp).Encode(writer);
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
			PosMaintRptID = view.GetString(721);
			PositionID = view.GetString(2618);
			PosReqID = view.GetString(710);
			PosReqType = view.GetInt32(724);
			PosReportAction = view.GetInt32(2364);
			MarginReqmtInqID = view.GetString(1635);
			SubscriptionRequestType = view.GetString(263);
			TotalNumPosReports = view.GetInt32(727);
			TotNumReports = view.GetInt32(911);
			LastRptRequested = view.GetBool(912);
			PosReqResult = view.GetInt32(728);
			UnsolicitedIndicator = view.GetBool(325);
			RegulatoryReportType = view.GetInt32(1934);
			RegulatoryReportTypeBusinessDate = view.GetDateOnly(2869);
			if (view.GetView("TransactionAttributeGrp") is IMessageView viewTransactionAttributeGrp)
			{
				TransactionAttributeGrp = new();
				((IFixParser)TransactionAttributeGrp).Parse(viewTransactionAttributeGrp);
			}
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
			ClearingBusinessDate = view.GetDateOnly(715);
			PreviousClearingBusinessDate = view.GetDateOnly(2084);
			ClearingPortfolioID = view.GetString(2870);
			SettlSessID = view.GetString(716);
			SettlSessSubID = view.GetString(717);
			PriceType = view.GetInt32(423);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			MessageEventSource = view.GetString(1011);
			ClearedIndicator = view.GetInt32(1832);
			ContractRefPosType = view.GetInt32(1833);
			PositionCapacity = view.GetInt32(1834);
			TerminatedIndicator = view.GetBool(2101);
			TerminationDate = view.GetDateOnly(2878);
			IntraFirmTradeIndicator = view.GetBool(2373);
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			TradeCollateralization = view.GetInt32(1936);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			AccountType = view.GetInt32(581);
			TaxonomyType = view.GetString(2375);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
			{
				FinancingDetails = new();
				((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
			}
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			SettlDate = view.GetDateOnly(64);
			SettlPrice = view.GetDouble(730);
			SettlPriceFxRateCalc = view.GetString(2366);
			SettlForwardPoints = view.GetDouble(2365);
			SettlPriceUnitOfMeasure = view.GetString(1886);
			SettlPriceUnitOfMeasureCurrency = view.GetString(1887);
			SettlPriceUnitOfMeasureCurrencyCodeSource = view.GetString(2960);
			SettlPriceType = view.GetInt32(731);
			PriorSettlPrice = view.GetDouble(734);
			PositionContingentPrice = view.GetDouble(1595);
			DiscountFactor = view.GetDouble(1592);
			ValuationDate = view.GetDateOnly(2085);
			ValuationTime = view.GetString(2086);
			ValuationBusinessCenter = view.GetString(2087);
			MatchStatus = view.GetString(573);
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
			if (view.GetView("CollateralAmountGrp") is IMessageView viewCollateralAmountGrp)
			{
				CollateralAmountGrp = new();
				((IFixParser)CollateralAmountGrp).Parse(viewCollateralAmountGrp);
			}
			CollateralizationValueDate = view.GetDateOnly(2868);
			if (view.GetView("PosUndInstrmtGrp") is IMessageView viewPosUndInstrmtGrp)
			{
				PosUndInstrmtGrp = new();
				((IFixParser)PosUndInstrmtGrp).Parse(viewPosUndInstrmtGrp);
			}
			TransactTime = view.GetDateTime(60);
			if (view.GetView("PositionQty") is IMessageView viewPositionQty)
			{
				PositionQty = new();
				((IFixParser)PositionQty).Parse(viewPositionQty);
			}
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			if (view.GetView("PaymentGrp") is IMessageView viewPaymentGrp)
			{
				PaymentGrp = new();
				((IFixParser)PaymentGrp).Parse(viewPaymentGrp);
			}
			RegistStatus = view.GetString(506);
			DeliveryDate = view.GetDateOnly(743);
			ModelType = view.GetInt32(1434);
			PriceDelta = view.GetDouble(811);
			if (view.GetView("RelatedTradeGrp") is IMessageView viewRelatedTradeGrp)
			{
				RelatedTradeGrp = new();
				((IFixParser)RelatedTradeGrp).Parse(viewRelatedTradeGrp);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "PosMaintRptID":
				{
					value = PosMaintRptID;
					break;
				}
				case "PositionID":
				{
					value = PositionID;
					break;
				}
				case "PosReqID":
				{
					value = PosReqID;
					break;
				}
				case "PosReqType":
				{
					value = PosReqType;
					break;
				}
				case "PosReportAction":
				{
					value = PosReportAction;
					break;
				}
				case "MarginReqmtInqID":
				{
					value = MarginReqmtInqID;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
					break;
				}
				case "TotalNumPosReports":
				{
					value = TotalNumPosReports;
					break;
				}
				case "TotNumReports":
				{
					value = TotNumReports;
					break;
				}
				case "LastRptRequested":
				{
					value = LastRptRequested;
					break;
				}
				case "PosReqResult":
				{
					value = PosReqResult;
					break;
				}
				case "UnsolicitedIndicator":
				{
					value = UnsolicitedIndicator;
					break;
				}
				case "RegulatoryReportType":
				{
					value = RegulatoryReportType;
					break;
				}
				case "RegulatoryReportTypeBusinessDate":
				{
					value = RegulatoryReportTypeBusinessDate;
					break;
				}
				case "TransactionAttributeGrp":
				{
					value = TransactionAttributeGrp;
					break;
				}
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "PreviousClearingBusinessDate":
				{
					value = PreviousClearingBusinessDate;
					break;
				}
				case "ClearingPortfolioID":
				{
					value = ClearingPortfolioID;
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
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "SettlCurrency":
				{
					value = SettlCurrency;
					break;
				}
				case "SettlCurrencyCodeSource":
				{
					value = SettlCurrencyCodeSource;
					break;
				}
				case "MessageEventSource":
				{
					value = MessageEventSource;
					break;
				}
				case "ClearedIndicator":
				{
					value = ClearedIndicator;
					break;
				}
				case "ContractRefPosType":
				{
					value = ContractRefPosType;
					break;
				}
				case "PositionCapacity":
				{
					value = PositionCapacity;
					break;
				}
				case "TerminatedIndicator":
				{
					value = TerminatedIndicator;
					break;
				}
				case "TerminationDate":
				{
					value = TerminationDate;
					break;
				}
				case "IntraFirmTradeIndicator":
				{
					value = IntraFirmTradeIndicator;
					break;
				}
				case "TradeContinuation":
				{
					value = TradeContinuation;
					break;
				}
				case "TradeContinuationText":
				{
					value = TradeContinuationText;
					break;
				}
				case "EncodedTradeContinuationTextLen":
				{
					value = EncodedTradeContinuationTextLen;
					break;
				}
				case "EncodedTradeContinuationText":
				{
					value = EncodedTradeContinuationText;
					break;
				}
				case "TradeCollateralization":
				{
					value = TradeCollateralization;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "Account":
				{
					value = Account;
					break;
				}
				case "AcctIDSource":
				{
					value = AcctIDSource;
					break;
				}
				case "AccountType":
				{
					value = AccountType;
					break;
				}
				case "TaxonomyType":
				{
					value = TaxonomyType;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "FinancingDetails":
				{
					value = FinancingDetails;
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
				case "SettlDate":
				{
					value = SettlDate;
					break;
				}
				case "SettlPrice":
				{
					value = SettlPrice;
					break;
				}
				case "SettlPriceFxRateCalc":
				{
					value = SettlPriceFxRateCalc;
					break;
				}
				case "SettlForwardPoints":
				{
					value = SettlForwardPoints;
					break;
				}
				case "SettlPriceUnitOfMeasure":
				{
					value = SettlPriceUnitOfMeasure;
					break;
				}
				case "SettlPriceUnitOfMeasureCurrency":
				{
					value = SettlPriceUnitOfMeasureCurrency;
					break;
				}
				case "SettlPriceUnitOfMeasureCurrencyCodeSource":
				{
					value = SettlPriceUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "SettlPriceType":
				{
					value = SettlPriceType;
					break;
				}
				case "PriorSettlPrice":
				{
					value = PriorSettlPrice;
					break;
				}
				case "PositionContingentPrice":
				{
					value = PositionContingentPrice;
					break;
				}
				case "DiscountFactor":
				{
					value = DiscountFactor;
					break;
				}
				case "ValuationDate":
				{
					value = ValuationDate;
					break;
				}
				case "ValuationTime":
				{
					value = ValuationTime;
					break;
				}
				case "ValuationBusinessCenter":
				{
					value = ValuationBusinessCenter;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
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
				case "CollateralAmountGrp":
				{
					value = CollateralAmountGrp;
					break;
				}
				case "CollateralizationValueDate":
				{
					value = CollateralizationValueDate;
					break;
				}
				case "PosUndInstrmtGrp":
				{
					value = PosUndInstrmtGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "PositionQty":
				{
					value = PositionQty;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
					break;
				}
				case "RegulatoryTradeIDGrp":
				{
					value = RegulatoryTradeIDGrp;
					break;
				}
				case "PaymentGrp":
				{
					value = PaymentGrp;
					break;
				}
				case "RegistStatus":
				{
					value = RegistStatus;
					break;
				}
				case "DeliveryDate":
				{
					value = DeliveryDate;
					break;
				}
				case "ModelType":
				{
					value = ModelType;
					break;
				}
				case "PriceDelta":
				{
					value = PriceDelta;
					break;
				}
				case "RelatedTradeGrp":
				{
					value = RelatedTradeGrp;
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
			PosMaintRptID = null;
			PositionID = null;
			PosReqID = null;
			PosReqType = null;
			PosReportAction = null;
			MarginReqmtInqID = null;
			SubscriptionRequestType = null;
			TotalNumPosReports = null;
			TotNumReports = null;
			LastRptRequested = null;
			PosReqResult = null;
			UnsolicitedIndicator = null;
			RegulatoryReportType = null;
			RegulatoryReportTypeBusinessDate = null;
			((IFixReset?)TransactionAttributeGrp)?.Reset();
			((IFixReset?)TrdRegTimestamps)?.Reset();
			ClearingBusinessDate = null;
			PreviousClearingBusinessDate = null;
			ClearingPortfolioID = null;
			SettlSessID = null;
			SettlSessSubID = null;
			PriceType = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			MessageEventSource = null;
			ClearedIndicator = null;
			ContractRefPosType = null;
			PositionCapacity = null;
			TerminatedIndicator = null;
			TerminationDate = null;
			IntraFirmTradeIndicator = null;
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			TradeCollateralization = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AcctIDSource = null;
			AccountType = null;
			TaxonomyType = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			Currency = null;
			CurrencyCodeSource = null;
			SettlDate = null;
			SettlPrice = null;
			SettlPriceFxRateCalc = null;
			SettlForwardPoints = null;
			SettlPriceUnitOfMeasure = null;
			SettlPriceUnitOfMeasureCurrency = null;
			SettlPriceUnitOfMeasureCurrencyCodeSource = null;
			SettlPriceType = null;
			PriorSettlPrice = null;
			PositionContingentPrice = null;
			DiscountFactor = null;
			ValuationDate = null;
			ValuationTime = null;
			ValuationBusinessCenter = null;
			MatchStatus = null;
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)RelatedInstrumentGrp)?.Reset();
			((IFixReset?)CollateralAmountGrp)?.Reset();
			CollateralizationValueDate = null;
			((IFixReset?)PosUndInstrmtGrp)?.Reset();
			TransactTime = null;
			((IFixReset?)PositionQty)?.Reset();
			((IFixReset?)PositionAmountData)?.Reset();
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			((IFixReset?)PaymentGrp)?.Reset();
			RegistStatus = null;
			DeliveryDate = null;
			ModelType = null;
			PriceDelta = null;
			((IFixReset?)RelatedTradeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
