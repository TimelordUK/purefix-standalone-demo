using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDIncGrp : IFixComponent
	{
		public sealed partial class NoMDEntries : IFixGroup
		{
			[TagDetails(Tag = 279, Type = TagType.String, Offset = 0, Required = true)]
			public string? MDUpdateAction {get; set;}
			
			[TagDetails(Tag = 285, Type = TagType.String, Offset = 1, Required = false)]
			public string? DeleteReason {get; set;}
			
			[TagDetails(Tag = 1173, Type = TagType.Int, Offset = 2, Required = false)]
			public int? MDSubBookType {get; set;}
			
			[TagDetails(Tag = 264, Type = TagType.Int, Offset = 3, Required = false)]
			public int? MarketDepth {get; set;}
			
			[TagDetails(Tag = 269, Type = TagType.String, Offset = 4, Required = false)]
			public string? MDEntryType {get; set;}
			
			[TagDetails(Tag = 278, Type = TagType.String, Offset = 5, Required = false)]
			public string? MDEntryID {get; set;}
			
			[TagDetails(Tag = 280, Type = TagType.String, Offset = 6, Required = false)]
			public string? MDEntryRefID {get; set;}
			
			[TagDetails(Tag = 1500, Type = TagType.String, Offset = 7, Required = false)]
			public string? MDStreamID {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public InstrumentExtension? InstrumentExtension {get; set;}
			
			[Component(Offset = 10, Required = false)]
			public FinancingDetails? FinancingDetails {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public InstrmtLegGrp? InstrmtLegGrp {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public RelatedInstrumentGrp? RelatedInstrumentGrp {get; set;}
			
			[TagDetails(Tag = 291, Type = TagType.String, Offset = 14, Required = false)]
			public string? FinancialStatus {get; set;}
			
			[TagDetails(Tag = 292, Type = TagType.String, Offset = 15, Required = false)]
			public string? CorporateAction {get; set;}
			
			[TagDetails(Tag = 270, Type = TagType.Float, Offset = 16, Required = false)]
			public double? MDEntryPx {get; set;}
			
			[TagDetails(Tag = 423, Type = TagType.Int, Offset = 17, Required = false)]
			public int? PriceType {get; set;}
			
			[Component(Offset = 18, Required = false)]
			public PriceQualifierGrp? PriceQualifierGrp {get; set;}
			
			[TagDetails(Tag = 819, Type = TagType.Int, Offset = 19, Required = false)]
			public int? AvgPxIndicator {get; set;}
			
			[Component(Offset = 20, Required = false)]
			public YieldData? YieldData {get; set;}
			
			[Component(Offset = 21, Required = false)]
			public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
			
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 22, Required = false)]
			public string? OrdType {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 23, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 24, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 25, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 26, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[Component(Offset = 27, Required = false)]
			public RateSource? RateSource {get; set;}
			
			[TagDetails(Tag = 271, Type = TagType.Float, Offset = 28, Required = false)]
			public double? MDEntrySize {get; set;}
			
			[Component(Offset = 29, Required = false)]
			public SecSizesGrp? SecSizesGrp {get; set;}
			
			[TagDetails(Tag = 1093, Type = TagType.String, Offset = 30, Required = false)]
			public string? LotType {get; set;}
			
			[TagDetails(Tag = 272, Type = TagType.UtcDateOnly, Offset = 31, Required = false)]
			public DateOnly? MDEntryDate {get; set;}
			
			[TagDetails(Tag = 273, Type = TagType.UtcTimeOnly, Offset = 32, Required = false)]
			public TimeOnly? MDEntryTime {get; set;}
			
			[TagDetails(Tag = 274, Type = TagType.String, Offset = 33, Required = false)]
			public string? TickDirection {get; set;}
			
			[TagDetails(Tag = 275, Type = TagType.String, Offset = 34, Required = false)]
			public string? MDMkt {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 35, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 36, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 326, Type = TagType.Int, Offset = 37, Required = false)]
			public int? SecurityTradingStatus {get; set;}
			
			[TagDetails(Tag = 327, Type = TagType.Int, Offset = 38, Required = false)]
			public int? HaltReasonInt {get; set;}
			
			[TagDetails(Tag = 2447, Type = TagType.Boolean, Offset = 39, Required = false)]
			public bool? FastMarketIndicator {get; set;}
			
			[TagDetails(Tag = 2705, Type = TagType.Int, Offset = 40, Required = false)]
			public int? MarketCondition {get; set;}
			
			[TagDetails(Tag = 276, Type = TagType.String, Offset = 41, Required = false)]
			public string? QuoteCondition {get; set;}
			
			[TagDetails(Tag = 277, Type = TagType.String, Offset = 42, Required = false)]
			public string? TradeCondition {get; set;}
			
			[Component(Offset = 43, Required = false)]
			public TradePriceConditionGrp? TradePriceConditionGrp {get; set;}
			
			[TagDetails(Tag = 2961, Type = TagType.Boolean, Offset = 44, Required = false)]
			public bool? AnonymousTradeIndicator {get; set;}
			
			[TagDetails(Tag = 2667, Type = TagType.Int, Offset = 45, Required = false)]
			public int? AlgorithmicTradeIndicator {get; set;}
			
			[TagDetails(Tag = 1934, Type = TagType.Int, Offset = 46, Required = false)]
			public int? RegulatoryReportType {get; set;}
			
			[TagDetails(Tag = 2963, Type = TagType.Int, Offset = 47, Required = false)]
			public int? MultiJurisdictionReportingIndicator {get; set;}
			
			[TagDetails(Tag = 828, Type = TagType.Int, Offset = 48, Required = false)]
			public int? TrdType {get; set;}
			
			[TagDetails(Tag = 829, Type = TagType.Int, Offset = 49, Required = false)]
			public int? TrdSubType {get; set;}
			
			[TagDetails(Tag = 855, Type = TagType.Int, Offset = 50, Required = false)]
			public int? SecondaryTrdType {get; set;}
			
			[TagDetails(Tag = 2896, Type = TagType.Int, Offset = 51, Required = false)]
			public int? TertiaryTrdType {get; set;}
			
			[TagDetails(Tag = 2405, Type = TagType.Int, Offset = 52, Required = false)]
			public int? ExecMethod {get; set;}
			
			[TagDetails(Tag = 574, Type = TagType.String, Offset = 53, Required = false)]
			public string? MatchType {get; set;}
			
			[TagDetails(Tag = 1115, Type = TagType.String, Offset = 54, Required = false)]
			public string? OrderCategory {get; set;}
			
			[TagDetails(Tag = 1390, Type = TagType.Int, Offset = 55, Required = false)]
			public int? TradePublishIndicator {get; set;}
			
			[Component(Offset = 56, Required = false)]
			public TrdRegPublicationGrp? TrdRegPublicationGrp {get; set;}
			
			[TagDetails(Tag = 2373, Type = TagType.Boolean, Offset = 57, Required = false)]
			public bool? IntraFirmTradeIndicator {get; set;}
			
			[TagDetails(Tag = 570, Type = TagType.Boolean, Offset = 58, Required = false)]
			public bool? PreviouslyReported {get; set;}
			
			[Component(Offset = 59, Required = false)]
			public RelatedTradeGrp? RelatedTradeGrp {get; set;}
			
			[TagDetails(Tag = 282, Type = TagType.String, Offset = 60, Required = false)]
			public string? MDEntryOriginator {get; set;}
			
			[TagDetails(Tag = 283, Type = TagType.String, Offset = 61, Required = false)]
			public string? LocationID {get; set;}
			
			[TagDetails(Tag = 284, Type = TagType.String, Offset = 62, Required = false)]
			public string? DeskID {get; set;}
			
			[TagDetails(Tag = 286, Type = TagType.String, Offset = 63, Required = false)]
			public string? OpenCloseSettlFlag {get; set;}
			
			[TagDetails(Tag = 59, Type = TagType.String, Offset = 64, Required = false)]
			public string? TimeInForce {get; set;}
			
			[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 65, Required = false)]
			public DateOnly? ExpireDate {get; set;}
			
			[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 66, Required = false)]
			public DateTime? ExpireTime {get; set;}
			
			[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 67, Required = false)]
			public int? ExposureDuration {get; set;}
			
			[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 68, Required = false)]
			public int? ExposureDurationUnit {get; set;}
			
			[TagDetails(Tag = 110, Type = TagType.Float, Offset = 69, Required = false)]
			public double? MinQty {get; set;}
			
			[TagDetails(Tag = 18, Type = TagType.String, Offset = 70, Required = false)]
			public string? ExecInst {get; set;}
			
			[TagDetails(Tag = 287, Type = TagType.Int, Offset = 71, Required = false)]
			public int? SellerDays {get; set;}
			
			[TagDetails(Tag = 37, Type = TagType.String, Offset = 72, Required = false)]
			public string? OrderID {get; set;}
			
			[TagDetails(Tag = 198, Type = TagType.String, Offset = 73, Required = false)]
			public string? SecondaryOrderID {get; set;}
			
			[TagDetails(Tag = 299, Type = TagType.String, Offset = 74, Required = false)]
			public string? QuoteEntryID {get; set;}
			
			[TagDetails(Tag = 1003, Type = TagType.String, Offset = 75, Required = false)]
			public string? TradeID {get; set;}
			
			[TagDetails(Tag = 1851, Type = TagType.String, Offset = 76, Required = false)]
			public string? StrategyLinkID {get; set;}
			
			[TagDetails(Tag = 288, Type = TagType.String, Offset = 77, Required = false)]
			public string? MDEntryBuyer {get; set;}
			
			[TagDetails(Tag = 289, Type = TagType.String, Offset = 78, Required = false)]
			public string? MDEntrySeller {get; set;}
			
			[TagDetails(Tag = 2449, Type = TagType.Int, Offset = 79, Required = false)]
			public int? NumberOfBuyOrders {get; set;}
			
			[TagDetails(Tag = 2450, Type = TagType.Int, Offset = 80, Required = false)]
			public int? NumberOfSellOrders {get; set;}
			
			[TagDetails(Tag = 346, Type = TagType.Int, Offset = 81, Required = false)]
			public int? NumberOfOrders {get; set;}
			
			[TagDetails(Tag = 290, Type = TagType.Int, Offset = 82, Required = false)]
			public int? MDEntryPositionNo {get; set;}
			
			[TagDetails(Tag = 546, Type = TagType.String, Offset = 83, Required = false)]
			public string? Scope {get; set;}
			
			[TagDetails(Tag = 811, Type = TagType.Float, Offset = 84, Required = false)]
			public double? PriceDelta {get; set;}
			
			[TagDetails(Tag = 451, Type = TagType.Float, Offset = 85, Required = false)]
			public double? NetChgPrevDay {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 86, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 87, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 88, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			[TagDetails(Tag = 1023, Type = TagType.Int, Offset = 89, Required = false)]
			public int? MDPriceLevel {get; set;}
			
			[TagDetails(Tag = 528, Type = TagType.String, Offset = 90, Required = false)]
			public string? OrderCapacity {get; set;}
			
			[TagDetails(Tag = 1024, Type = TagType.Int, Offset = 91, Required = false)]
			public int? MDOriginType {get; set;}
			
			[TagDetails(Tag = 332, Type = TagType.Float, Offset = 92, Required = false)]
			public double? HighPx {get; set;}
			
			[TagDetails(Tag = 333, Type = TagType.Float, Offset = 93, Required = false)]
			public double? LowPx {get; set;}
			
			[TagDetails(Tag = 1025, Type = TagType.Float, Offset = 94, Required = false)]
			public double? FirstPx {get; set;}
			
			[TagDetails(Tag = 31, Type = TagType.Float, Offset = 95, Required = false)]
			public double? LastPx {get; set;}
			
			[TagDetails(Tag = 1592, Type = TagType.Float, Offset = 96, Required = false)]
			public double? DiscountFactor {get; set;}
			
			[TagDetails(Tag = 1020, Type = TagType.Float, Offset = 97, Required = false)]
			public double? TradeVolume {get; set;}
			
			[Component(Offset = 98, Required = false)]
			public PriceLimits? PriceLimits {get; set;}
			
			[TagDetails(Tag = 1143, Type = TagType.Float, Offset = 99, Required = false)]
			public double? MaxPriceVariation {get; set;}
			
			[TagDetails(Tag = 731, Type = TagType.Int, Offset = 100, Required = false)]
			public int? SettlPriceType {get; set;}
			
			[TagDetails(Tag = 2451, Type = TagType.Int, Offset = 101, Required = false)]
			public int? SettlPriceDeterminationMethod {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 102, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 103, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 483, Type = TagType.UtcTimestamp, Offset = 104, Required = false)]
			public DateTime? TransBkdTime {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 105, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			[TagDetails(Tag = 2445, Type = TagType.UtcTimestamp, Offset = 106, Required = false)]
			public DateTime? AggressorTime {get; set;}
			
			[TagDetails(Tag = 2446, Type = TagType.String, Offset = 107, Required = false)]
			public string? AggressorSide {get; set;}
			
			[TagDetails(Tag = 1070, Type = TagType.Int, Offset = 108, Required = false)]
			public int? MDQuoteType {get; set;}
			
			[TagDetails(Tag = 83, Type = TagType.Int, Offset = 109, Required = false)]
			public int? RptSeq {get; set;}
			
			[TagDetails(Tag = 1048, Type = TagType.String, Offset = 110, Required = false)]
			public string? DealingCapacity {get; set;}
			
			[TagDetails(Tag = 1026, Type = TagType.Float, Offset = 111, Required = false)]
			public double? MDEntrySpotRate {get; set;}
			
			[TagDetails(Tag = 1027, Type = TagType.Float, Offset = 112, Required = false)]
			public double? MDEntryForwardPoints {get; set;}
			
			[Component(Offset = 113, Required = false)]
			public StatsIndGrp? StatsIndGrp {get; set;}
			
			[Component(Offset = 114, Required = false)]
			public Parties? Parties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MDUpdateAction is not null) writer.WriteString(279, MDUpdateAction);
				if (DeleteReason is not null) writer.WriteString(285, DeleteReason);
				if (MDSubBookType is not null) writer.WriteWholeNumber(1173, MDSubBookType.Value);
				if (MarketDepth is not null) writer.WriteWholeNumber(264, MarketDepth.Value);
				if (MDEntryType is not null) writer.WriteString(269, MDEntryType);
				if (MDEntryID is not null) writer.WriteString(278, MDEntryID);
				if (MDEntryRefID is not null) writer.WriteString(280, MDEntryRefID);
				if (MDStreamID is not null) writer.WriteString(1500, MDStreamID);
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
				if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
				if (RelatedInstrumentGrp is not null) ((IFixEncoder)RelatedInstrumentGrp).Encode(writer);
				if (FinancialStatus is not null) writer.WriteString(291, FinancialStatus);
				if (CorporateAction is not null) writer.WriteString(292, CorporateAction);
				if (MDEntryPx is not null) writer.WriteNumber(270, MDEntryPx.Value);
				if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
				if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
				if (AvgPxIndicator is not null) writer.WriteWholeNumber(819, AvgPxIndicator.Value);
				if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
				if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
				if (OrdType is not null) writer.WriteString(40, OrdType);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (RateSource is not null) ((IFixEncoder)RateSource).Encode(writer);
				if (MDEntrySize is not null) writer.WriteNumber(271, MDEntrySize.Value);
				if (SecSizesGrp is not null) ((IFixEncoder)SecSizesGrp).Encode(writer);
				if (LotType is not null) writer.WriteString(1093, LotType);
				if (MDEntryDate is not null) writer.WriteUtcDateOnly(272, MDEntryDate.Value);
				if (MDEntryTime is not null) writer.WriteTimeOnly(273, MDEntryTime.Value);
				if (TickDirection is not null) writer.WriteString(274, TickDirection);
				if (MDMkt is not null) writer.WriteString(275, MDMkt);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (SecurityTradingStatus is not null) writer.WriteWholeNumber(326, SecurityTradingStatus.Value);
				if (HaltReasonInt is not null) writer.WriteWholeNumber(327, HaltReasonInt.Value);
				if (FastMarketIndicator is not null) writer.WriteBoolean(2447, FastMarketIndicator.Value);
				if (MarketCondition is not null) writer.WriteWholeNumber(2705, MarketCondition.Value);
				if (QuoteCondition is not null) writer.WriteString(276, QuoteCondition);
				if (TradeCondition is not null) writer.WriteString(277, TradeCondition);
				if (TradePriceConditionGrp is not null) ((IFixEncoder)TradePriceConditionGrp).Encode(writer);
				if (AnonymousTradeIndicator is not null) writer.WriteBoolean(2961, AnonymousTradeIndicator.Value);
				if (AlgorithmicTradeIndicator is not null) writer.WriteWholeNumber(2667, AlgorithmicTradeIndicator.Value);
				if (RegulatoryReportType is not null) writer.WriteWholeNumber(1934, RegulatoryReportType.Value);
				if (MultiJurisdictionReportingIndicator is not null) writer.WriteWholeNumber(2963, MultiJurisdictionReportingIndicator.Value);
				if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
				if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
				if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
				if (TertiaryTrdType is not null) writer.WriteWholeNumber(2896, TertiaryTrdType.Value);
				if (ExecMethod is not null) writer.WriteWholeNumber(2405, ExecMethod.Value);
				if (MatchType is not null) writer.WriteString(574, MatchType);
				if (OrderCategory is not null) writer.WriteString(1115, OrderCategory);
				if (TradePublishIndicator is not null) writer.WriteWholeNumber(1390, TradePublishIndicator.Value);
				if (TrdRegPublicationGrp is not null) ((IFixEncoder)TrdRegPublicationGrp).Encode(writer);
				if (IntraFirmTradeIndicator is not null) writer.WriteBoolean(2373, IntraFirmTradeIndicator.Value);
				if (PreviouslyReported is not null) writer.WriteBoolean(570, PreviouslyReported.Value);
				if (RelatedTradeGrp is not null) ((IFixEncoder)RelatedTradeGrp).Encode(writer);
				if (MDEntryOriginator is not null) writer.WriteString(282, MDEntryOriginator);
				if (LocationID is not null) writer.WriteString(283, LocationID);
				if (DeskID is not null) writer.WriteString(284, DeskID);
				if (OpenCloseSettlFlag is not null) writer.WriteString(286, OpenCloseSettlFlag);
				if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
				if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
				if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
				if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
				if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
				if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
				if (ExecInst is not null) writer.WriteString(18, ExecInst);
				if (SellerDays is not null) writer.WriteWholeNumber(287, SellerDays.Value);
				if (OrderID is not null) writer.WriteString(37, OrderID);
				if (SecondaryOrderID is not null) writer.WriteString(198, SecondaryOrderID);
				if (QuoteEntryID is not null) writer.WriteString(299, QuoteEntryID);
				if (TradeID is not null) writer.WriteString(1003, TradeID);
				if (StrategyLinkID is not null) writer.WriteString(1851, StrategyLinkID);
				if (MDEntryBuyer is not null) writer.WriteString(288, MDEntryBuyer);
				if (MDEntrySeller is not null) writer.WriteString(289, MDEntrySeller);
				if (NumberOfBuyOrders is not null) writer.WriteWholeNumber(2449, NumberOfBuyOrders.Value);
				if (NumberOfSellOrders is not null) writer.WriteWholeNumber(2450, NumberOfSellOrders.Value);
				if (NumberOfOrders is not null) writer.WriteWholeNumber(346, NumberOfOrders.Value);
				if (MDEntryPositionNo is not null) writer.WriteWholeNumber(290, MDEntryPositionNo.Value);
				if (Scope is not null) writer.WriteString(546, Scope);
				if (PriceDelta is not null) writer.WriteNumber(811, PriceDelta.Value);
				if (NetChgPrevDay is not null) writer.WriteNumber(451, NetChgPrevDay.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
				if (MDPriceLevel is not null) writer.WriteWholeNumber(1023, MDPriceLevel.Value);
				if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
				if (MDOriginType is not null) writer.WriteWholeNumber(1024, MDOriginType.Value);
				if (HighPx is not null) writer.WriteNumber(332, HighPx.Value);
				if (LowPx is not null) writer.WriteNumber(333, LowPx.Value);
				if (FirstPx is not null) writer.WriteNumber(1025, FirstPx.Value);
				if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
				if (DiscountFactor is not null) writer.WriteNumber(1592, DiscountFactor.Value);
				if (TradeVolume is not null) writer.WriteNumber(1020, TradeVolume.Value);
				if (PriceLimits is not null) ((IFixEncoder)PriceLimits).Encode(writer);
				if (MaxPriceVariation is not null) writer.WriteNumber(1143, MaxPriceVariation.Value);
				if (SettlPriceType is not null) writer.WriteWholeNumber(731, SettlPriceType.Value);
				if (SettlPriceDeterminationMethod is not null) writer.WriteWholeNumber(2451, SettlPriceDeterminationMethod.Value);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (TransBkdTime is not null) writer.WriteUtcTimeStamp(483, TransBkdTime.Value);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
				if (AggressorTime is not null) writer.WriteUtcTimeStamp(2445, AggressorTime.Value);
				if (AggressorSide is not null) writer.WriteString(2446, AggressorSide);
				if (MDQuoteType is not null) writer.WriteWholeNumber(1070, MDQuoteType.Value);
				if (RptSeq is not null) writer.WriteWholeNumber(83, RptSeq.Value);
				if (DealingCapacity is not null) writer.WriteString(1048, DealingCapacity);
				if (MDEntrySpotRate is not null) writer.WriteNumber(1026, MDEntrySpotRate.Value);
				if (MDEntryForwardPoints is not null) writer.WriteNumber(1027, MDEntryForwardPoints.Value);
				if (StatsIndGrp is not null) ((IFixEncoder)StatsIndGrp).Encode(writer);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MDUpdateAction = view.GetString(279);
				DeleteReason = view.GetString(285);
				MDSubBookType = view.GetInt32(1173);
				MarketDepth = view.GetInt32(264);
				MDEntryType = view.GetString(269);
				MDEntryID = view.GetString(278);
				MDEntryRefID = view.GetString(280);
				MDStreamID = view.GetString(1500);
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
				FinancialStatus = view.GetString(291);
				CorporateAction = view.GetString(292);
				MDEntryPx = view.GetDouble(270);
				PriceType = view.GetInt32(423);
				if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
				{
					PriceQualifierGrp = new();
					((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
				}
				AvgPxIndicator = view.GetInt32(819);
				if (view.GetView("YieldData") is IMessageView viewYieldData)
				{
					YieldData = new();
					((IFixParser)YieldData).Parse(viewYieldData);
				}
				if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
				{
					SpreadOrBenchmarkCurveData = new();
					((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
				}
				OrdType = view.GetString(40);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				if (view.GetView("RateSource") is IMessageView viewRateSource)
				{
					RateSource = new();
					((IFixParser)RateSource).Parse(viewRateSource);
				}
				MDEntrySize = view.GetDouble(271);
				if (view.GetView("SecSizesGrp") is IMessageView viewSecSizesGrp)
				{
					SecSizesGrp = new();
					((IFixParser)SecSizesGrp).Parse(viewSecSizesGrp);
				}
				LotType = view.GetString(1093);
				MDEntryDate = view.GetDateOnly(272);
				MDEntryTime = view.GetTimeOnly(273);
				TickDirection = view.GetString(274);
				MDMkt = view.GetString(275);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				SecurityTradingStatus = view.GetInt32(326);
				HaltReasonInt = view.GetInt32(327);
				FastMarketIndicator = view.GetBool(2447);
				MarketCondition = view.GetInt32(2705);
				QuoteCondition = view.GetString(276);
				TradeCondition = view.GetString(277);
				if (view.GetView("TradePriceConditionGrp") is IMessageView viewTradePriceConditionGrp)
				{
					TradePriceConditionGrp = new();
					((IFixParser)TradePriceConditionGrp).Parse(viewTradePriceConditionGrp);
				}
				AnonymousTradeIndicator = view.GetBool(2961);
				AlgorithmicTradeIndicator = view.GetInt32(2667);
				RegulatoryReportType = view.GetInt32(1934);
				MultiJurisdictionReportingIndicator = view.GetInt32(2963);
				TrdType = view.GetInt32(828);
				TrdSubType = view.GetInt32(829);
				SecondaryTrdType = view.GetInt32(855);
				TertiaryTrdType = view.GetInt32(2896);
				ExecMethod = view.GetInt32(2405);
				MatchType = view.GetString(574);
				OrderCategory = view.GetString(1115);
				TradePublishIndicator = view.GetInt32(1390);
				if (view.GetView("TrdRegPublicationGrp") is IMessageView viewTrdRegPublicationGrp)
				{
					TrdRegPublicationGrp = new();
					((IFixParser)TrdRegPublicationGrp).Parse(viewTrdRegPublicationGrp);
				}
				IntraFirmTradeIndicator = view.GetBool(2373);
				PreviouslyReported = view.GetBool(570);
				if (view.GetView("RelatedTradeGrp") is IMessageView viewRelatedTradeGrp)
				{
					RelatedTradeGrp = new();
					((IFixParser)RelatedTradeGrp).Parse(viewRelatedTradeGrp);
				}
				MDEntryOriginator = view.GetString(282);
				LocationID = view.GetString(283);
				DeskID = view.GetString(284);
				OpenCloseSettlFlag = view.GetString(286);
				TimeInForce = view.GetString(59);
				ExpireDate = view.GetDateOnly(432);
				ExpireTime = view.GetDateTime(126);
				ExposureDuration = view.GetInt32(1629);
				ExposureDurationUnit = view.GetInt32(1916);
				MinQty = view.GetDouble(110);
				ExecInst = view.GetString(18);
				SellerDays = view.GetInt32(287);
				OrderID = view.GetString(37);
				SecondaryOrderID = view.GetString(198);
				QuoteEntryID = view.GetString(299);
				TradeID = view.GetString(1003);
				StrategyLinkID = view.GetString(1851);
				MDEntryBuyer = view.GetString(288);
				MDEntrySeller = view.GetString(289);
				NumberOfBuyOrders = view.GetInt32(2449);
				NumberOfSellOrders = view.GetInt32(2450);
				NumberOfOrders = view.GetInt32(346);
				MDEntryPositionNo = view.GetInt32(290);
				Scope = view.GetString(546);
				PriceDelta = view.GetDouble(811);
				NetChgPrevDay = view.GetDouble(451);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
				MDPriceLevel = view.GetInt32(1023);
				OrderCapacity = view.GetString(528);
				MDOriginType = view.GetInt32(1024);
				HighPx = view.GetDouble(332);
				LowPx = view.GetDouble(333);
				FirstPx = view.GetDouble(1025);
				LastPx = view.GetDouble(31);
				DiscountFactor = view.GetDouble(1592);
				TradeVolume = view.GetDouble(1020);
				if (view.GetView("PriceLimits") is IMessageView viewPriceLimits)
				{
					PriceLimits = new();
					((IFixParser)PriceLimits).Parse(viewPriceLimits);
				}
				MaxPriceVariation = view.GetDouble(1143);
				SettlPriceType = view.GetInt32(731);
				SettlPriceDeterminationMethod = view.GetInt32(2451);
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				TransBkdTime = view.GetDateTime(483);
				TransactTime = view.GetDateTime(60);
				AggressorTime = view.GetDateTime(2445);
				AggressorSide = view.GetString(2446);
				MDQuoteType = view.GetInt32(1070);
				RptSeq = view.GetInt32(83);
				DealingCapacity = view.GetString(1048);
				MDEntrySpotRate = view.GetDouble(1026);
				MDEntryForwardPoints = view.GetDouble(1027);
				if (view.GetView("StatsIndGrp") is IMessageView viewStatsIndGrp)
				{
					StatsIndGrp = new();
					((IFixParser)StatsIndGrp).Parse(viewStatsIndGrp);
				}
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MDUpdateAction":
					{
						value = MDUpdateAction;
						break;
					}
					case "DeleteReason":
					{
						value = DeleteReason;
						break;
					}
					case "MDSubBookType":
					{
						value = MDSubBookType;
						break;
					}
					case "MarketDepth":
					{
						value = MarketDepth;
						break;
					}
					case "MDEntryType":
					{
						value = MDEntryType;
						break;
					}
					case "MDEntryID":
					{
						value = MDEntryID;
						break;
					}
					case "MDEntryRefID":
					{
						value = MDEntryRefID;
						break;
					}
					case "MDStreamID":
					{
						value = MDStreamID;
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
					case "FinancialStatus":
					{
						value = FinancialStatus;
						break;
					}
					case "CorporateAction":
					{
						value = CorporateAction;
						break;
					}
					case "MDEntryPx":
					{
						value = MDEntryPx;
						break;
					}
					case "PriceType":
					{
						value = PriceType;
						break;
					}
					case "PriceQualifierGrp":
					{
						value = PriceQualifierGrp;
						break;
					}
					case "AvgPxIndicator":
					{
						value = AvgPxIndicator;
						break;
					}
					case "YieldData":
					{
						value = YieldData;
						break;
					}
					case "SpreadOrBenchmarkCurveData":
					{
						value = SpreadOrBenchmarkCurveData;
						break;
					}
					case "OrdType":
					{
						value = OrdType;
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
					case "RateSource":
					{
						value = RateSource;
						break;
					}
					case "MDEntrySize":
					{
						value = MDEntrySize;
						break;
					}
					case "SecSizesGrp":
					{
						value = SecSizesGrp;
						break;
					}
					case "LotType":
					{
						value = LotType;
						break;
					}
					case "MDEntryDate":
					{
						value = MDEntryDate;
						break;
					}
					case "MDEntryTime":
					{
						value = MDEntryTime;
						break;
					}
					case "TickDirection":
					{
						value = TickDirection;
						break;
					}
					case "MDMkt":
					{
						value = MDMkt;
						break;
					}
					case "TradingSessionID":
					{
						value = TradingSessionID;
						break;
					}
					case "TradingSessionSubID":
					{
						value = TradingSessionSubID;
						break;
					}
					case "SecurityTradingStatus":
					{
						value = SecurityTradingStatus;
						break;
					}
					case "HaltReasonInt":
					{
						value = HaltReasonInt;
						break;
					}
					case "FastMarketIndicator":
					{
						value = FastMarketIndicator;
						break;
					}
					case "MarketCondition":
					{
						value = MarketCondition;
						break;
					}
					case "QuoteCondition":
					{
						value = QuoteCondition;
						break;
					}
					case "TradeCondition":
					{
						value = TradeCondition;
						break;
					}
					case "TradePriceConditionGrp":
					{
						value = TradePriceConditionGrp;
						break;
					}
					case "AnonymousTradeIndicator":
					{
						value = AnonymousTradeIndicator;
						break;
					}
					case "AlgorithmicTradeIndicator":
					{
						value = AlgorithmicTradeIndicator;
						break;
					}
					case "RegulatoryReportType":
					{
						value = RegulatoryReportType;
						break;
					}
					case "MultiJurisdictionReportingIndicator":
					{
						value = MultiJurisdictionReportingIndicator;
						break;
					}
					case "TrdType":
					{
						value = TrdType;
						break;
					}
					case "TrdSubType":
					{
						value = TrdSubType;
						break;
					}
					case "SecondaryTrdType":
					{
						value = SecondaryTrdType;
						break;
					}
					case "TertiaryTrdType":
					{
						value = TertiaryTrdType;
						break;
					}
					case "ExecMethod":
					{
						value = ExecMethod;
						break;
					}
					case "MatchType":
					{
						value = MatchType;
						break;
					}
					case "OrderCategory":
					{
						value = OrderCategory;
						break;
					}
					case "TradePublishIndicator":
					{
						value = TradePublishIndicator;
						break;
					}
					case "TrdRegPublicationGrp":
					{
						value = TrdRegPublicationGrp;
						break;
					}
					case "IntraFirmTradeIndicator":
					{
						value = IntraFirmTradeIndicator;
						break;
					}
					case "PreviouslyReported":
					{
						value = PreviouslyReported;
						break;
					}
					case "RelatedTradeGrp":
					{
						value = RelatedTradeGrp;
						break;
					}
					case "MDEntryOriginator":
					{
						value = MDEntryOriginator;
						break;
					}
					case "LocationID":
					{
						value = LocationID;
						break;
					}
					case "DeskID":
					{
						value = DeskID;
						break;
					}
					case "OpenCloseSettlFlag":
					{
						value = OpenCloseSettlFlag;
						break;
					}
					case "TimeInForce":
					{
						value = TimeInForce;
						break;
					}
					case "ExpireDate":
					{
						value = ExpireDate;
						break;
					}
					case "ExpireTime":
					{
						value = ExpireTime;
						break;
					}
					case "ExposureDuration":
					{
						value = ExposureDuration;
						break;
					}
					case "ExposureDurationUnit":
					{
						value = ExposureDurationUnit;
						break;
					}
					case "MinQty":
					{
						value = MinQty;
						break;
					}
					case "ExecInst":
					{
						value = ExecInst;
						break;
					}
					case "SellerDays":
					{
						value = SellerDays;
						break;
					}
					case "OrderID":
					{
						value = OrderID;
						break;
					}
					case "SecondaryOrderID":
					{
						value = SecondaryOrderID;
						break;
					}
					case "QuoteEntryID":
					{
						value = QuoteEntryID;
						break;
					}
					case "TradeID":
					{
						value = TradeID;
						break;
					}
					case "StrategyLinkID":
					{
						value = StrategyLinkID;
						break;
					}
					case "MDEntryBuyer":
					{
						value = MDEntryBuyer;
						break;
					}
					case "MDEntrySeller":
					{
						value = MDEntrySeller;
						break;
					}
					case "NumberOfBuyOrders":
					{
						value = NumberOfBuyOrders;
						break;
					}
					case "NumberOfSellOrders":
					{
						value = NumberOfSellOrders;
						break;
					}
					case "NumberOfOrders":
					{
						value = NumberOfOrders;
						break;
					}
					case "MDEntryPositionNo":
					{
						value = MDEntryPositionNo;
						break;
					}
					case "Scope":
					{
						value = Scope;
						break;
					}
					case "PriceDelta":
					{
						value = PriceDelta;
						break;
					}
					case "NetChgPrevDay":
					{
						value = NetChgPrevDay;
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
					case "MDPriceLevel":
					{
						value = MDPriceLevel;
						break;
					}
					case "OrderCapacity":
					{
						value = OrderCapacity;
						break;
					}
					case "MDOriginType":
					{
						value = MDOriginType;
						break;
					}
					case "HighPx":
					{
						value = HighPx;
						break;
					}
					case "LowPx":
					{
						value = LowPx;
						break;
					}
					case "FirstPx":
					{
						value = FirstPx;
						break;
					}
					case "LastPx":
					{
						value = LastPx;
						break;
					}
					case "DiscountFactor":
					{
						value = DiscountFactor;
						break;
					}
					case "TradeVolume":
					{
						value = TradeVolume;
						break;
					}
					case "PriceLimits":
					{
						value = PriceLimits;
						break;
					}
					case "MaxPriceVariation":
					{
						value = MaxPriceVariation;
						break;
					}
					case "SettlPriceType":
					{
						value = SettlPriceType;
						break;
					}
					case "SettlPriceDeterminationMethod":
					{
						value = SettlPriceDeterminationMethod;
						break;
					}
					case "SettlType":
					{
						value = SettlType;
						break;
					}
					case "SettlDate":
					{
						value = SettlDate;
						break;
					}
					case "TransBkdTime":
					{
						value = TransBkdTime;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
						break;
					}
					case "AggressorTime":
					{
						value = AggressorTime;
						break;
					}
					case "AggressorSide":
					{
						value = AggressorSide;
						break;
					}
					case "MDQuoteType":
					{
						value = MDQuoteType;
						break;
					}
					case "RptSeq":
					{
						value = RptSeq;
						break;
					}
					case "DealingCapacity":
					{
						value = DealingCapacity;
						break;
					}
					case "MDEntrySpotRate":
					{
						value = MDEntrySpotRate;
						break;
					}
					case "MDEntryForwardPoints":
					{
						value = MDEntryForwardPoints;
						break;
					}
					case "StatsIndGrp":
					{
						value = StatsIndGrp;
						break;
					}
					case "Parties":
					{
						value = Parties;
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
				MDUpdateAction = null;
				DeleteReason = null;
				MDSubBookType = null;
				MarketDepth = null;
				MDEntryType = null;
				MDEntryID = null;
				MDEntryRefID = null;
				MDStreamID = null;
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)InstrumentExtension)?.Reset();
				((IFixReset?)FinancingDetails)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				((IFixReset?)InstrmtLegGrp)?.Reset();
				((IFixReset?)RelatedInstrumentGrp)?.Reset();
				FinancialStatus = null;
				CorporateAction = null;
				MDEntryPx = null;
				PriceType = null;
				((IFixReset?)PriceQualifierGrp)?.Reset();
				AvgPxIndicator = null;
				((IFixReset?)YieldData)?.Reset();
				((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
				OrdType = null;
				Currency = null;
				CurrencyCodeSource = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				((IFixReset?)RateSource)?.Reset();
				MDEntrySize = null;
				((IFixReset?)SecSizesGrp)?.Reset();
				LotType = null;
				MDEntryDate = null;
				MDEntryTime = null;
				TickDirection = null;
				MDMkt = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				SecurityTradingStatus = null;
				HaltReasonInt = null;
				FastMarketIndicator = null;
				MarketCondition = null;
				QuoteCondition = null;
				TradeCondition = null;
				((IFixReset?)TradePriceConditionGrp)?.Reset();
				AnonymousTradeIndicator = null;
				AlgorithmicTradeIndicator = null;
				RegulatoryReportType = null;
				MultiJurisdictionReportingIndicator = null;
				TrdType = null;
				TrdSubType = null;
				SecondaryTrdType = null;
				TertiaryTrdType = null;
				ExecMethod = null;
				MatchType = null;
				OrderCategory = null;
				TradePublishIndicator = null;
				((IFixReset?)TrdRegPublicationGrp)?.Reset();
				IntraFirmTradeIndicator = null;
				PreviouslyReported = null;
				((IFixReset?)RelatedTradeGrp)?.Reset();
				MDEntryOriginator = null;
				LocationID = null;
				DeskID = null;
				OpenCloseSettlFlag = null;
				TimeInForce = null;
				ExpireDate = null;
				ExpireTime = null;
				ExposureDuration = null;
				ExposureDurationUnit = null;
				MinQty = null;
				ExecInst = null;
				SellerDays = null;
				OrderID = null;
				SecondaryOrderID = null;
				QuoteEntryID = null;
				TradeID = null;
				StrategyLinkID = null;
				MDEntryBuyer = null;
				MDEntrySeller = null;
				NumberOfBuyOrders = null;
				NumberOfSellOrders = null;
				NumberOfOrders = null;
				MDEntryPositionNo = null;
				Scope = null;
				PriceDelta = null;
				NetChgPrevDay = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
				MDPriceLevel = null;
				OrderCapacity = null;
				MDOriginType = null;
				HighPx = null;
				LowPx = null;
				FirstPx = null;
				LastPx = null;
				DiscountFactor = null;
				TradeVolume = null;
				((IFixReset?)PriceLimits)?.Reset();
				MaxPriceVariation = null;
				SettlPriceType = null;
				SettlPriceDeterminationMethod = null;
				SettlType = null;
				SettlDate = null;
				TransBkdTime = null;
				TransactTime = null;
				AggressorTime = null;
				AggressorSide = null;
				MDQuoteType = null;
				RptSeq = null;
				DealingCapacity = null;
				MDEntrySpotRate = null;
				MDEntryForwardPoints = null;
				((IFixReset?)StatsIndGrp)?.Reset();
				((IFixReset?)Parties)?.Reset();
			}
		}
		[Group(NoOfTag = 268, Offset = 0, Required = false)]
		public NoMDEntries[]? MDEntries {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MDEntries is not null && MDEntries.Length != 0)
			{
				writer.WriteWholeNumber(268, MDEntries.Length);
				for (int i = 0; i < MDEntries.Length; i++)
				{
					((IFixEncoder)MDEntries[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMDEntries") is IMessageView viewNoMDEntries)
			{
				var count = viewNoMDEntries.GroupCount();
				MDEntries = new NoMDEntries[count];
				for (int i = 0; i < count; i++)
				{
					MDEntries[i] = new();
					((IFixParser)MDEntries[i]).Parse(viewNoMDEntries.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMDEntries":
				{
					value = MDEntries;
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
			MDEntries = null;
		}
	}
}
