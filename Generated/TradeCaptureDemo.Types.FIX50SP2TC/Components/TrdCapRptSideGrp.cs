using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdCapRptSideGrp : IFixComponent
	{
		public sealed partial class NoSides : IFixGroup
		{
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 0, Required = true)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 2102, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? ShortMarkingExemptIndicator {get; set;}
			
			[TagDetails(Tag = 1427, Type = TagType.String, Offset = 2, Required = false)]
			public string? SideExecID {get; set;}
			
			[TagDetails(Tag = 1428, Type = TagType.Int, Offset = 3, Required = false)]
			public int? OrderDelay {get; set;}
			
			[TagDetails(Tag = 1429, Type = TagType.Int, Offset = 4, Required = false)]
			public int? OrderDelayUnit {get; set;}
			
			[TagDetails(Tag = 1009, Type = TagType.Float, Offset = 5, Required = false)]
			public double? SideLastQty {get; set;}
			
			[TagDetails(Tag = 1597, Type = TagType.Float, Offset = 6, Required = false)]
			public double? SideClearingTradePrice {get; set;}
			
			[TagDetails(Tag = 1599, Type = TagType.Float, Offset = 7, Required = false)]
			public double? SidePriceDifferential {get; set;}
			
			[TagDetails(Tag = 1598, Type = TagType.Int, Offset = 8, Required = false)]
			public int? SideClearingTradePriceType {get; set;}
			
			[TagDetails(Tag = 1005, Type = TagType.String, Offset = 9, Required = false)]
			public string? SideTradeReportID {get; set;}
			
			[TagDetails(Tag = 1506, Type = TagType.String, Offset = 10, Required = false)]
			public string? SideTradeID {get; set;}
			
			[TagDetails(Tag = 1507, Type = TagType.String, Offset = 11, Required = false)]
			public string? SideOrigTradeID {get; set;}
			
			[TagDetails(Tag = 1006, Type = TagType.String, Offset = 12, Required = false)]
			public string? SideFillStationCd {get; set;}
			
			[TagDetails(Tag = 1007, Type = TagType.String, Offset = 13, Required = false)]
			public string? SideReasonCd {get; set;}
			
			[TagDetails(Tag = 83, Type = TagType.Int, Offset = 14, Required = false)]
			public int? RptSeq {get; set;}
			
			[TagDetails(Tag = 1008, Type = TagType.Int, Offset = 15, Required = false)]
			public int? SideTrdSubType {get; set;}
			
			[TagDetails(Tag = 430, Type = TagType.Int, Offset = 16, Required = false)]
			public int? NetGrossInd {get; set;}
			
			[TagDetails(Tag = 1154, Type = TagType.String, Offset = 17, Required = false)]
			public string? SideCurrency {get; set;}
			
			[TagDetails(Tag = 2901, Type = TagType.String, Offset = 18, Required = false)]
			public string? SideCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1155, Type = TagType.String, Offset = 19, Required = false)]
			public string? SideSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2902, Type = TagType.String, Offset = 20, Required = false)]
			public string? SideSettlCurrencyCodeSource {get; set;}
			
			[Component(Offset = 21, Required = false)]
			public Parties? Parties {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			[TagDetails(Tag = 1, Type = TagType.String, Offset = 23, Required = false)]
			public string? Account {get; set;}
			
			[TagDetails(Tag = 660, Type = TagType.Int, Offset = 24, Required = false)]
			public int? AcctIDSource {get; set;}
			
			[TagDetails(Tag = 581, Type = TagType.Int, Offset = 25, Required = false)]
			public int? AccountType {get; set;}
			
			[TagDetails(Tag = 522, Type = TagType.Int, Offset = 26, Required = false)]
			public int? OwnerType {get; set;}
			
			[Component(Offset = 27, Required = false)]
			public LimitAmts? LimitAmts {get; set;}
			
			[TagDetails(Tag = 81, Type = TagType.String, Offset = 28, Required = false)]
			public string? ProcessCode {get; set;}
			
			[TagDetails(Tag = 575, Type = TagType.Boolean, Offset = 29, Required = false)]
			public bool? OddLot {get; set;}
			
			[Component(Offset = 30, Required = false)]
			public ClrInstGrp? ClrInstGrp {get; set;}
			
			[TagDetails(Tag = 635, Type = TagType.String, Offset = 31, Required = false)]
			public string? ClearingFeeIndicator {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public SideRegulatoryTradeIDGrp? SideRegulatoryTradeIDGrp {get; set;}
			
			[TagDetails(Tag = 2671, Type = TagType.Int, Offset = 33, Required = false)]
			public int? SideTradeReportingIndicator {get; set;}
			
			[TagDetails(Tag = 2418, Type = TagType.String, Offset = 34, Required = false)]
			public string? FirmTradeEventID {get; set;}
			
			[TagDetails(Tag = 578, Type = TagType.String, Offset = 35, Required = false)]
			public string? TradeInputSource {get; set;}
			
			[TagDetails(Tag = 579, Type = TagType.String, Offset = 36, Required = false)]
			public string? TradeInputDevice {get; set;}
			
			[TagDetails(Tag = 376, Type = TagType.String, Offset = 37, Required = false)]
			public string? ComplianceID {get; set;}
			
			[TagDetails(Tag = 2404, Type = TagType.String, Offset = 38, Required = false)]
			public string? ComplianceText {get; set;}
			
			[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 39, Required = false)]
			public int? EncodedComplianceTextLen {get; set;}
			
			[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 40, Required = false)]
			public byte[]? EncodedComplianceText {get; set;}
			
			[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 41, Required = false)]
			public bool? SolicitedFlag {get; set;}
			
			[TagDetails(Tag = 582, Type = TagType.Int, Offset = 42, Required = false)]
			public int? CustOrderCapacity {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 43, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 44, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 943, Type = TagType.String, Offset = 45, Required = false)]
			public string? TimeBracket {get; set;}
			
			[TagDetails(Tag = 2356, Type = TagType.Int, Offset = 46, Required = false)]
			public int? RemunerationIndicator {get; set;}
			
			[Component(Offset = 47, Required = false)]
			public CommissionData? CommissionData {get; set;}
			
			[Component(Offset = 48, Required = false)]
			public CommissionDataGrp? CommissionDataGrp {get; set;}
			
			[TagDetails(Tag = 157, Type = TagType.Int, Offset = 49, Required = false)]
			public int? NumDaysInterest {get; set;}
			
			[TagDetails(Tag = 230, Type = TagType.LocalDate, Offset = 50, Required = false)]
			public DateOnly? ExDate {get; set;}
			
			[TagDetails(Tag = 158, Type = TagType.Float, Offset = 51, Required = false)]
			public double? AccruedInterestRate {get; set;}
			
			[TagDetails(Tag = 159, Type = TagType.Float, Offset = 52, Required = false)]
			public double? AccruedInterestAmt {get; set;}
			
			[TagDetails(Tag = 738, Type = TagType.Float, Offset = 53, Required = false)]
			public double? InterestAtMaturity {get; set;}
			
			[TagDetails(Tag = 920, Type = TagType.Float, Offset = 54, Required = false)]
			public double? EndAccruedInterestAmt {get; set;}
			
			[TagDetails(Tag = 921, Type = TagType.Float, Offset = 55, Required = false)]
			public double? StartCash {get; set;}
			
			[TagDetails(Tag = 922, Type = TagType.Float, Offset = 56, Required = false)]
			public double? EndCash {get; set;}
			
			[TagDetails(Tag = 238, Type = TagType.Float, Offset = 57, Required = false)]
			public double? Concession {get; set;}
			
			[TagDetails(Tag = 237, Type = TagType.Float, Offset = 58, Required = false)]
			public double? TotalTakedown {get; set;}
			
			[TagDetails(Tag = 118, Type = TagType.Float, Offset = 59, Required = false)]
			public double? NetMoney {get; set;}
			
			[TagDetails(Tag = 119, Type = TagType.Float, Offset = 60, Required = false)]
			public double? SettlCurrAmt {get; set;}
			
			[TagDetails(Tag = 155, Type = TagType.Float, Offset = 61, Required = false)]
			public double? SettlCurrFxRate {get; set;}
			
			[TagDetails(Tag = 156, Type = TagType.String, Offset = 62, Required = false)]
			public string? SettlCurrFxRateCalc {get; set;}
			
			[TagDetails(Tag = 77, Type = TagType.String, Offset = 63, Required = false)]
			public string? PositionEffect {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 64, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 65, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 66, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			[TagDetails(Tag = 752, Type = TagType.Int, Offset = 67, Required = false)]
			public int? SideMultiLegReportingType {get; set;}
			
			[Component(Offset = 68, Required = false)]
			public ContAmtGrp? ContAmtGrp {get; set;}
			
			[Component(Offset = 69, Required = false)]
			public Stipulations? Stipulations {get; set;}
			
			[Component(Offset = 70, Required = false)]
			public MiscFeesGrp? MiscFeesGrp {get; set;}
			
			[TagDetails(Tag = 825, Type = TagType.String, Offset = 71, Required = false)]
			public string? ExchangeRule {get; set;}
			
			[TagDetails(Tag = 826, Type = TagType.Int, Offset = 72, Required = false)]
			public int? TradeAllocIndicator {get; set;}
			
			[TagDetails(Tag = 1848, Type = TagType.Int, Offset = 73, Required = false)]
			public int? TradeAllocGroupInstruction {get; set;}
			
			[TagDetails(Tag = 1730, Type = TagType.String, Offset = 74, Required = false)]
			public string? AllocGroupID {get; set;}
			
			[TagDetails(Tag = 2771, Type = TagType.String, Offset = 75, Required = false)]
			public string? PreviousAllocGroupID {get; set;}
			
			[TagDetails(Tag = 2759, Type = TagType.Float, Offset = 76, Required = false)]
			public double? GroupAmount {get; set;}
			
			[TagDetails(Tag = 2767, Type = TagType.Int, Offset = 77, Required = false)]
			public int? AllocGroupStatus {get; set;}
			
			[TagDetails(Tag = 1853, Type = TagType.Int, Offset = 78, Required = false)]
			public int? SideAvgPxIndicator {get; set;}
			
			[TagDetails(Tag = 1854, Type = TagType.String, Offset = 79, Required = false)]
			public string? SideAvgPxGroupID {get; set;}
			
			[TagDetails(Tag = 1852, Type = TagType.Float, Offset = 80, Required = false)]
			public double? SideAvgPx {get; set;}
			
			[TagDetails(Tag = 591, Type = TagType.String, Offset = 81, Required = false)]
			public string? PreallocMethod {get; set;}
			
			[TagDetails(Tag = 70, Type = TagType.String, Offset = 82, Required = false)]
			public string? AllocID {get; set;}
			
			[Component(Offset = 83, Required = false)]
			public TrdAllocGrp? TrdAllocGrp {get; set;}
			
			[Component(Offset = 84, Required = false)]
			public SideTrdRegTS? SideTrdRegTS {get; set;}
			
			[Component(Offset = 85, Required = false)]
			public SettlDetails? SettlDetails {get; set;}
			
			[TagDetails(Tag = 1072, Type = TagType.Float, Offset = 86, Required = false)]
			public double? SideGrossTradeAmt {get; set;}
			
			[TagDetails(Tag = 1057, Type = TagType.Boolean, Offset = 87, Required = false)]
			public bool? AggressorIndicator {get; set;}
			
			[TagDetails(Tag = 1139, Type = TagType.String, Offset = 88, Required = false)]
			public string? ExchangeSpecialInstructions {get; set;}
			
			[TagDetails(Tag = 1690, Type = TagType.Int, Offset = 89, Required = false)]
			public int? SideShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 1115, Type = TagType.String, Offset = 90, Required = false)]
			public string? OrderCategory {get; set;}
			
			[TagDetails(Tag = 1444, Type = TagType.Int, Offset = 91, Required = false)]
			public int? SideLiquidityInd {get; set;}
			
			[TagDetails(Tag = 1851, Type = TagType.String, Offset = 92, Required = false)]
			public string? StrategyLinkID {get; set;}
			
			[Component(Offset = 93, Required = false)]
			public TradeReportOrderDetail? TradeReportOrderDetail {get; set;}
			
			[TagDetails(Tag = 1031, Type = TagType.String, Offset = 94, Required = false)]
			public string? CustOrderHandlingInst {get; set;}
			
			[TagDetails(Tag = 1032, Type = TagType.Int, Offset = 95, Required = false)]
			public int? OrderHandlingInstSource {get; set;}
			
			[Component(Offset = 96, Required = false)]
			public TradePositionQty? TradePositionQty {get; set;}
			
			[Component(Offset = 97, Required = false)]
			public RelatedTradeGrp? RelatedTradeGrp {get; set;}
			
			[Component(Offset = 98, Required = false)]
			public RelatedPositionGrp? RelatedPositionGrp {get; set;}
			
			[TagDetails(Tag = 1980, Type = TagType.Int, Offset = 99, Required = false)]
			public int? BlockTrdAllocIndicator {get; set;}
			
			[TagDetails(Tag = 2344, Type = TagType.Int, Offset = 100, Required = false)]
			public int? SideRiskLimitCheckStatus {get; set;}
			
			[TagDetails(Tag = 29, Type = TagType.String, Offset = 101, Required = false)]
			public string? LastCapacity {get; set;}
			
			[TagDetails(Tag = 2334, Type = TagType.String, Offset = 102, Required = false)]
			public string? RefRiskLimitCheckID {get; set;}
			
			[TagDetails(Tag = 2335, Type = TagType.Int, Offset = 103, Required = false)]
			public int? RefRiskLimitCheckIDType {get; set;}
			
			[TagDetails(Tag = 2361, Type = TagType.String, Offset = 104, Required = false)]
			public string? CompressionGroupID {get; set;}
			
			[Component(Offset = 105, Required = false)]
			public SideCollateralAmountGrp? SideCollateralAmountGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Side is not null) writer.WriteString(54, Side);
				if (ShortMarkingExemptIndicator is not null) writer.WriteBoolean(2102, ShortMarkingExemptIndicator.Value);
				if (SideExecID is not null) writer.WriteString(1427, SideExecID);
				if (OrderDelay is not null) writer.WriteWholeNumber(1428, OrderDelay.Value);
				if (OrderDelayUnit is not null) writer.WriteWholeNumber(1429, OrderDelayUnit.Value);
				if (SideLastQty is not null) writer.WriteNumber(1009, SideLastQty.Value);
				if (SideClearingTradePrice is not null) writer.WriteNumber(1597, SideClearingTradePrice.Value);
				if (SidePriceDifferential is not null) writer.WriteNumber(1599, SidePriceDifferential.Value);
				if (SideClearingTradePriceType is not null) writer.WriteWholeNumber(1598, SideClearingTradePriceType.Value);
				if (SideTradeReportID is not null) writer.WriteString(1005, SideTradeReportID);
				if (SideTradeID is not null) writer.WriteString(1506, SideTradeID);
				if (SideOrigTradeID is not null) writer.WriteString(1507, SideOrigTradeID);
				if (SideFillStationCd is not null) writer.WriteString(1006, SideFillStationCd);
				if (SideReasonCd is not null) writer.WriteString(1007, SideReasonCd);
				if (RptSeq is not null) writer.WriteWholeNumber(83, RptSeq.Value);
				if (SideTrdSubType is not null) writer.WriteWholeNumber(1008, SideTrdSubType.Value);
				if (NetGrossInd is not null) writer.WriteWholeNumber(430, NetGrossInd.Value);
				if (SideCurrency is not null) writer.WriteString(1154, SideCurrency);
				if (SideCurrencyCodeSource is not null) writer.WriteString(2901, SideCurrencyCodeSource);
				if (SideSettlCurrency is not null) writer.WriteString(1155, SideSettlCurrency);
				if (SideSettlCurrencyCodeSource is not null) writer.WriteString(2902, SideSettlCurrencyCodeSource);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
				if (Account is not null) writer.WriteString(1, Account);
				if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
				if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
				if (OwnerType is not null) writer.WriteWholeNumber(522, OwnerType.Value);
				if (LimitAmts is not null) ((IFixEncoder)LimitAmts).Encode(writer);
				if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
				if (OddLot is not null) writer.WriteBoolean(575, OddLot.Value);
				if (ClrInstGrp is not null) ((IFixEncoder)ClrInstGrp).Encode(writer);
				if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
				if (SideRegulatoryTradeIDGrp is not null) ((IFixEncoder)SideRegulatoryTradeIDGrp).Encode(writer);
				if (SideTradeReportingIndicator is not null) writer.WriteWholeNumber(2671, SideTradeReportingIndicator.Value);
				if (FirmTradeEventID is not null) writer.WriteString(2418, FirmTradeEventID);
				if (TradeInputSource is not null) writer.WriteString(578, TradeInputSource);
				if (TradeInputDevice is not null) writer.WriteString(579, TradeInputDevice);
				if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
				if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
				if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
				if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
				if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
				if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (TimeBracket is not null) writer.WriteString(943, TimeBracket);
				if (RemunerationIndicator is not null) writer.WriteWholeNumber(2356, RemunerationIndicator.Value);
				if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
				if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
				if (NumDaysInterest is not null) writer.WriteWholeNumber(157, NumDaysInterest.Value);
				if (ExDate is not null) writer.WriteLocalDateOnly(230, ExDate.Value);
				if (AccruedInterestRate is not null) writer.WriteNumber(158, AccruedInterestRate.Value);
				if (AccruedInterestAmt is not null) writer.WriteNumber(159, AccruedInterestAmt.Value);
				if (InterestAtMaturity is not null) writer.WriteNumber(738, InterestAtMaturity.Value);
				if (EndAccruedInterestAmt is not null) writer.WriteNumber(920, EndAccruedInterestAmt.Value);
				if (StartCash is not null) writer.WriteNumber(921, StartCash.Value);
				if (EndCash is not null) writer.WriteNumber(922, EndCash.Value);
				if (Concession is not null) writer.WriteNumber(238, Concession.Value);
				if (TotalTakedown is not null) writer.WriteNumber(237, TotalTakedown.Value);
				if (NetMoney is not null) writer.WriteNumber(118, NetMoney.Value);
				if (SettlCurrAmt is not null) writer.WriteNumber(119, SettlCurrAmt.Value);
				if (SettlCurrFxRate is not null) writer.WriteNumber(155, SettlCurrFxRate.Value);
				if (SettlCurrFxRateCalc is not null) writer.WriteString(156, SettlCurrFxRateCalc);
				if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
				if (SideMultiLegReportingType is not null) writer.WriteWholeNumber(752, SideMultiLegReportingType.Value);
				if (ContAmtGrp is not null) ((IFixEncoder)ContAmtGrp).Encode(writer);
				if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
				if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
				if (ExchangeRule is not null) writer.WriteString(825, ExchangeRule);
				if (TradeAllocIndicator is not null) writer.WriteWholeNumber(826, TradeAllocIndicator.Value);
				if (TradeAllocGroupInstruction is not null) writer.WriteWholeNumber(1848, TradeAllocGroupInstruction.Value);
				if (AllocGroupID is not null) writer.WriteString(1730, AllocGroupID);
				if (PreviousAllocGroupID is not null) writer.WriteString(2771, PreviousAllocGroupID);
				if (GroupAmount is not null) writer.WriteNumber(2759, GroupAmount.Value);
				if (AllocGroupStatus is not null) writer.WriteWholeNumber(2767, AllocGroupStatus.Value);
				if (SideAvgPxIndicator is not null) writer.WriteWholeNumber(1853, SideAvgPxIndicator.Value);
				if (SideAvgPxGroupID is not null) writer.WriteString(1854, SideAvgPxGroupID);
				if (SideAvgPx is not null) writer.WriteNumber(1852, SideAvgPx.Value);
				if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
				if (AllocID is not null) writer.WriteString(70, AllocID);
				if (TrdAllocGrp is not null) ((IFixEncoder)TrdAllocGrp).Encode(writer);
				if (SideTrdRegTS is not null) ((IFixEncoder)SideTrdRegTS).Encode(writer);
				if (SettlDetails is not null) ((IFixEncoder)SettlDetails).Encode(writer);
				if (SideGrossTradeAmt is not null) writer.WriteNumber(1072, SideGrossTradeAmt.Value);
				if (AggressorIndicator is not null) writer.WriteBoolean(1057, AggressorIndicator.Value);
				if (ExchangeSpecialInstructions is not null) writer.WriteString(1139, ExchangeSpecialInstructions);
				if (SideShortSaleExemptionReason is not null) writer.WriteWholeNumber(1690, SideShortSaleExemptionReason.Value);
				if (OrderCategory is not null) writer.WriteString(1115, OrderCategory);
				if (SideLiquidityInd is not null) writer.WriteWholeNumber(1444, SideLiquidityInd.Value);
				if (StrategyLinkID is not null) writer.WriteString(1851, StrategyLinkID);
				if (TradeReportOrderDetail is not null) ((IFixEncoder)TradeReportOrderDetail).Encode(writer);
				if (CustOrderHandlingInst is not null) writer.WriteString(1031, CustOrderHandlingInst);
				if (OrderHandlingInstSource is not null) writer.WriteWholeNumber(1032, OrderHandlingInstSource.Value);
				if (TradePositionQty is not null) ((IFixEncoder)TradePositionQty).Encode(writer);
				if (RelatedTradeGrp is not null) ((IFixEncoder)RelatedTradeGrp).Encode(writer);
				if (RelatedPositionGrp is not null) ((IFixEncoder)RelatedPositionGrp).Encode(writer);
				if (BlockTrdAllocIndicator is not null) writer.WriteWholeNumber(1980, BlockTrdAllocIndicator.Value);
				if (SideRiskLimitCheckStatus is not null) writer.WriteWholeNumber(2344, SideRiskLimitCheckStatus.Value);
				if (LastCapacity is not null) writer.WriteString(29, LastCapacity);
				if (RefRiskLimitCheckID is not null) writer.WriteString(2334, RefRiskLimitCheckID);
				if (RefRiskLimitCheckIDType is not null) writer.WriteWholeNumber(2335, RefRiskLimitCheckIDType.Value);
				if (CompressionGroupID is not null) writer.WriteString(2361, CompressionGroupID);
				if (SideCollateralAmountGrp is not null) ((IFixEncoder)SideCollateralAmountGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Side = view.GetString(54);
				ShortMarkingExemptIndicator = view.GetBool(2102);
				SideExecID = view.GetString(1427);
				OrderDelay = view.GetInt32(1428);
				OrderDelayUnit = view.GetInt32(1429);
				SideLastQty = view.GetDouble(1009);
				SideClearingTradePrice = view.GetDouble(1597);
				SidePriceDifferential = view.GetDouble(1599);
				SideClearingTradePriceType = view.GetInt32(1598);
				SideTradeReportID = view.GetString(1005);
				SideTradeID = view.GetString(1506);
				SideOrigTradeID = view.GetString(1507);
				SideFillStationCd = view.GetString(1006);
				SideReasonCd = view.GetString(1007);
				RptSeq = view.GetInt32(83);
				SideTrdSubType = view.GetInt32(1008);
				NetGrossInd = view.GetInt32(430);
				SideCurrency = view.GetString(1154);
				SideCurrencyCodeSource = view.GetString(2901);
				SideSettlCurrency = view.GetString(1155);
				SideSettlCurrencyCodeSource = view.GetString(2902);
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				if (view.GetView("PartyDetailGrp") is IMessageView viewPartyDetailGrp)
				{
					PartyDetailGrp = new();
					((IFixParser)PartyDetailGrp).Parse(viewPartyDetailGrp);
				}
				Account = view.GetString(1);
				AcctIDSource = view.GetInt32(660);
				AccountType = view.GetInt32(581);
				OwnerType = view.GetInt32(522);
				if (view.GetView("LimitAmts") is IMessageView viewLimitAmts)
				{
					LimitAmts = new();
					((IFixParser)LimitAmts).Parse(viewLimitAmts);
				}
				ProcessCode = view.GetString(81);
				OddLot = view.GetBool(575);
				if (view.GetView("ClrInstGrp") is IMessageView viewClrInstGrp)
				{
					ClrInstGrp = new();
					((IFixParser)ClrInstGrp).Parse(viewClrInstGrp);
				}
				ClearingFeeIndicator = view.GetString(635);
				if (view.GetView("SideRegulatoryTradeIDGrp") is IMessageView viewSideRegulatoryTradeIDGrp)
				{
					SideRegulatoryTradeIDGrp = new();
					((IFixParser)SideRegulatoryTradeIDGrp).Parse(viewSideRegulatoryTradeIDGrp);
				}
				SideTradeReportingIndicator = view.GetInt32(2671);
				FirmTradeEventID = view.GetString(2418);
				TradeInputSource = view.GetString(578);
				TradeInputDevice = view.GetString(579);
				ComplianceID = view.GetString(376);
				ComplianceText = view.GetString(2404);
				EncodedComplianceTextLen = view.GetInt32(2351);
				EncodedComplianceText = view.GetByteArray(2352);
				SolicitedFlag = view.GetBool(377);
				CustOrderCapacity = view.GetInt32(582);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				TimeBracket = view.GetString(943);
				RemunerationIndicator = view.GetInt32(2356);
				if (view.GetView("CommissionData") is IMessageView viewCommissionData)
				{
					CommissionData = new();
					((IFixParser)CommissionData).Parse(viewCommissionData);
				}
				if (view.GetView("CommissionDataGrp") is IMessageView viewCommissionDataGrp)
				{
					CommissionDataGrp = new();
					((IFixParser)CommissionDataGrp).Parse(viewCommissionDataGrp);
				}
				NumDaysInterest = view.GetInt32(157);
				ExDate = view.GetDateOnly(230);
				AccruedInterestRate = view.GetDouble(158);
				AccruedInterestAmt = view.GetDouble(159);
				InterestAtMaturity = view.GetDouble(738);
				EndAccruedInterestAmt = view.GetDouble(920);
				StartCash = view.GetDouble(921);
				EndCash = view.GetDouble(922);
				Concession = view.GetDouble(238);
				TotalTakedown = view.GetDouble(237);
				NetMoney = view.GetDouble(118);
				SettlCurrAmt = view.GetDouble(119);
				SettlCurrFxRate = view.GetDouble(155);
				SettlCurrFxRateCalc = view.GetString(156);
				PositionEffect = view.GetString(77);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
				SideMultiLegReportingType = view.GetInt32(752);
				if (view.GetView("ContAmtGrp") is IMessageView viewContAmtGrp)
				{
					ContAmtGrp = new();
					((IFixParser)ContAmtGrp).Parse(viewContAmtGrp);
				}
				if (view.GetView("Stipulations") is IMessageView viewStipulations)
				{
					Stipulations = new();
					((IFixParser)Stipulations).Parse(viewStipulations);
				}
				if (view.GetView("MiscFeesGrp") is IMessageView viewMiscFeesGrp)
				{
					MiscFeesGrp = new();
					((IFixParser)MiscFeesGrp).Parse(viewMiscFeesGrp);
				}
				ExchangeRule = view.GetString(825);
				TradeAllocIndicator = view.GetInt32(826);
				TradeAllocGroupInstruction = view.GetInt32(1848);
				AllocGroupID = view.GetString(1730);
				PreviousAllocGroupID = view.GetString(2771);
				GroupAmount = view.GetDouble(2759);
				AllocGroupStatus = view.GetInt32(2767);
				SideAvgPxIndicator = view.GetInt32(1853);
				SideAvgPxGroupID = view.GetString(1854);
				SideAvgPx = view.GetDouble(1852);
				PreallocMethod = view.GetString(591);
				AllocID = view.GetString(70);
				if (view.GetView("TrdAllocGrp") is IMessageView viewTrdAllocGrp)
				{
					TrdAllocGrp = new();
					((IFixParser)TrdAllocGrp).Parse(viewTrdAllocGrp);
				}
				if (view.GetView("SideTrdRegTS") is IMessageView viewSideTrdRegTS)
				{
					SideTrdRegTS = new();
					((IFixParser)SideTrdRegTS).Parse(viewSideTrdRegTS);
				}
				if (view.GetView("SettlDetails") is IMessageView viewSettlDetails)
				{
					SettlDetails = new();
					((IFixParser)SettlDetails).Parse(viewSettlDetails);
				}
				SideGrossTradeAmt = view.GetDouble(1072);
				AggressorIndicator = view.GetBool(1057);
				ExchangeSpecialInstructions = view.GetString(1139);
				SideShortSaleExemptionReason = view.GetInt32(1690);
				OrderCategory = view.GetString(1115);
				SideLiquidityInd = view.GetInt32(1444);
				StrategyLinkID = view.GetString(1851);
				if (view.GetView("TradeReportOrderDetail") is IMessageView viewTradeReportOrderDetail)
				{
					TradeReportOrderDetail = new();
					((IFixParser)TradeReportOrderDetail).Parse(viewTradeReportOrderDetail);
				}
				CustOrderHandlingInst = view.GetString(1031);
				OrderHandlingInstSource = view.GetInt32(1032);
				if (view.GetView("TradePositionQty") is IMessageView viewTradePositionQty)
				{
					TradePositionQty = new();
					((IFixParser)TradePositionQty).Parse(viewTradePositionQty);
				}
				if (view.GetView("RelatedTradeGrp") is IMessageView viewRelatedTradeGrp)
				{
					RelatedTradeGrp = new();
					((IFixParser)RelatedTradeGrp).Parse(viewRelatedTradeGrp);
				}
				if (view.GetView("RelatedPositionGrp") is IMessageView viewRelatedPositionGrp)
				{
					RelatedPositionGrp = new();
					((IFixParser)RelatedPositionGrp).Parse(viewRelatedPositionGrp);
				}
				BlockTrdAllocIndicator = view.GetInt32(1980);
				SideRiskLimitCheckStatus = view.GetInt32(2344);
				LastCapacity = view.GetString(29);
				RefRiskLimitCheckID = view.GetString(2334);
				RefRiskLimitCheckIDType = view.GetInt32(2335);
				CompressionGroupID = view.GetString(2361);
				if (view.GetView("SideCollateralAmountGrp") is IMessageView viewSideCollateralAmountGrp)
				{
					SideCollateralAmountGrp = new();
					((IFixParser)SideCollateralAmountGrp).Parse(viewSideCollateralAmountGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Side":
					{
						value = Side;
						break;
					}
					case "ShortMarkingExemptIndicator":
					{
						value = ShortMarkingExemptIndicator;
						break;
					}
					case "SideExecID":
					{
						value = SideExecID;
						break;
					}
					case "OrderDelay":
					{
						value = OrderDelay;
						break;
					}
					case "OrderDelayUnit":
					{
						value = OrderDelayUnit;
						break;
					}
					case "SideLastQty":
					{
						value = SideLastQty;
						break;
					}
					case "SideClearingTradePrice":
					{
						value = SideClearingTradePrice;
						break;
					}
					case "SidePriceDifferential":
					{
						value = SidePriceDifferential;
						break;
					}
					case "SideClearingTradePriceType":
					{
						value = SideClearingTradePriceType;
						break;
					}
					case "SideTradeReportID":
					{
						value = SideTradeReportID;
						break;
					}
					case "SideTradeID":
					{
						value = SideTradeID;
						break;
					}
					case "SideOrigTradeID":
					{
						value = SideOrigTradeID;
						break;
					}
					case "SideFillStationCd":
					{
						value = SideFillStationCd;
						break;
					}
					case "SideReasonCd":
					{
						value = SideReasonCd;
						break;
					}
					case "RptSeq":
					{
						value = RptSeq;
						break;
					}
					case "SideTrdSubType":
					{
						value = SideTrdSubType;
						break;
					}
					case "NetGrossInd":
					{
						value = NetGrossInd;
						break;
					}
					case "SideCurrency":
					{
						value = SideCurrency;
						break;
					}
					case "SideCurrencyCodeSource":
					{
						value = SideCurrencyCodeSource;
						break;
					}
					case "SideSettlCurrency":
					{
						value = SideSettlCurrency;
						break;
					}
					case "SideSettlCurrencyCodeSource":
					{
						value = SideSettlCurrencyCodeSource;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "PartyDetailGrp":
					{
						value = PartyDetailGrp;
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
					case "OwnerType":
					{
						value = OwnerType;
						break;
					}
					case "LimitAmts":
					{
						value = LimitAmts;
						break;
					}
					case "ProcessCode":
					{
						value = ProcessCode;
						break;
					}
					case "OddLot":
					{
						value = OddLot;
						break;
					}
					case "ClrInstGrp":
					{
						value = ClrInstGrp;
						break;
					}
					case "ClearingFeeIndicator":
					{
						value = ClearingFeeIndicator;
						break;
					}
					case "SideRegulatoryTradeIDGrp":
					{
						value = SideRegulatoryTradeIDGrp;
						break;
					}
					case "SideTradeReportingIndicator":
					{
						value = SideTradeReportingIndicator;
						break;
					}
					case "FirmTradeEventID":
					{
						value = FirmTradeEventID;
						break;
					}
					case "TradeInputSource":
					{
						value = TradeInputSource;
						break;
					}
					case "TradeInputDevice":
					{
						value = TradeInputDevice;
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
					case "SolicitedFlag":
					{
						value = SolicitedFlag;
						break;
					}
					case "CustOrderCapacity":
					{
						value = CustOrderCapacity;
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
					case "TimeBracket":
					{
						value = TimeBracket;
						break;
					}
					case "RemunerationIndicator":
					{
						value = RemunerationIndicator;
						break;
					}
					case "CommissionData":
					{
						value = CommissionData;
						break;
					}
					case "CommissionDataGrp":
					{
						value = CommissionDataGrp;
						break;
					}
					case "NumDaysInterest":
					{
						value = NumDaysInterest;
						break;
					}
					case "ExDate":
					{
						value = ExDate;
						break;
					}
					case "AccruedInterestRate":
					{
						value = AccruedInterestRate;
						break;
					}
					case "AccruedInterestAmt":
					{
						value = AccruedInterestAmt;
						break;
					}
					case "InterestAtMaturity":
					{
						value = InterestAtMaturity;
						break;
					}
					case "EndAccruedInterestAmt":
					{
						value = EndAccruedInterestAmt;
						break;
					}
					case "StartCash":
					{
						value = StartCash;
						break;
					}
					case "EndCash":
					{
						value = EndCash;
						break;
					}
					case "Concession":
					{
						value = Concession;
						break;
					}
					case "TotalTakedown":
					{
						value = TotalTakedown;
						break;
					}
					case "NetMoney":
					{
						value = NetMoney;
						break;
					}
					case "SettlCurrAmt":
					{
						value = SettlCurrAmt;
						break;
					}
					case "SettlCurrFxRate":
					{
						value = SettlCurrFxRate;
						break;
					}
					case "SettlCurrFxRateCalc":
					{
						value = SettlCurrFxRateCalc;
						break;
					}
					case "PositionEffect":
					{
						value = PositionEffect;
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
					case "SideMultiLegReportingType":
					{
						value = SideMultiLegReportingType;
						break;
					}
					case "ContAmtGrp":
					{
						value = ContAmtGrp;
						break;
					}
					case "Stipulations":
					{
						value = Stipulations;
						break;
					}
					case "MiscFeesGrp":
					{
						value = MiscFeesGrp;
						break;
					}
					case "ExchangeRule":
					{
						value = ExchangeRule;
						break;
					}
					case "TradeAllocIndicator":
					{
						value = TradeAllocIndicator;
						break;
					}
					case "TradeAllocGroupInstruction":
					{
						value = TradeAllocGroupInstruction;
						break;
					}
					case "AllocGroupID":
					{
						value = AllocGroupID;
						break;
					}
					case "PreviousAllocGroupID":
					{
						value = PreviousAllocGroupID;
						break;
					}
					case "GroupAmount":
					{
						value = GroupAmount;
						break;
					}
					case "AllocGroupStatus":
					{
						value = AllocGroupStatus;
						break;
					}
					case "SideAvgPxIndicator":
					{
						value = SideAvgPxIndicator;
						break;
					}
					case "SideAvgPxGroupID":
					{
						value = SideAvgPxGroupID;
						break;
					}
					case "SideAvgPx":
					{
						value = SideAvgPx;
						break;
					}
					case "PreallocMethod":
					{
						value = PreallocMethod;
						break;
					}
					case "AllocID":
					{
						value = AllocID;
						break;
					}
					case "TrdAllocGrp":
					{
						value = TrdAllocGrp;
						break;
					}
					case "SideTrdRegTS":
					{
						value = SideTrdRegTS;
						break;
					}
					case "SettlDetails":
					{
						value = SettlDetails;
						break;
					}
					case "SideGrossTradeAmt":
					{
						value = SideGrossTradeAmt;
						break;
					}
					case "AggressorIndicator":
					{
						value = AggressorIndicator;
						break;
					}
					case "ExchangeSpecialInstructions":
					{
						value = ExchangeSpecialInstructions;
						break;
					}
					case "SideShortSaleExemptionReason":
					{
						value = SideShortSaleExemptionReason;
						break;
					}
					case "OrderCategory":
					{
						value = OrderCategory;
						break;
					}
					case "SideLiquidityInd":
					{
						value = SideLiquidityInd;
						break;
					}
					case "StrategyLinkID":
					{
						value = StrategyLinkID;
						break;
					}
					case "TradeReportOrderDetail":
					{
						value = TradeReportOrderDetail;
						break;
					}
					case "CustOrderHandlingInst":
					{
						value = CustOrderHandlingInst;
						break;
					}
					case "OrderHandlingInstSource":
					{
						value = OrderHandlingInstSource;
						break;
					}
					case "TradePositionQty":
					{
						value = TradePositionQty;
						break;
					}
					case "RelatedTradeGrp":
					{
						value = RelatedTradeGrp;
						break;
					}
					case "RelatedPositionGrp":
					{
						value = RelatedPositionGrp;
						break;
					}
					case "BlockTrdAllocIndicator":
					{
						value = BlockTrdAllocIndicator;
						break;
					}
					case "SideRiskLimitCheckStatus":
					{
						value = SideRiskLimitCheckStatus;
						break;
					}
					case "LastCapacity":
					{
						value = LastCapacity;
						break;
					}
					case "RefRiskLimitCheckID":
					{
						value = RefRiskLimitCheckID;
						break;
					}
					case "RefRiskLimitCheckIDType":
					{
						value = RefRiskLimitCheckIDType;
						break;
					}
					case "CompressionGroupID":
					{
						value = CompressionGroupID;
						break;
					}
					case "SideCollateralAmountGrp":
					{
						value = SideCollateralAmountGrp;
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
				Side = null;
				ShortMarkingExemptIndicator = null;
				SideExecID = null;
				OrderDelay = null;
				OrderDelayUnit = null;
				SideLastQty = null;
				SideClearingTradePrice = null;
				SidePriceDifferential = null;
				SideClearingTradePriceType = null;
				SideTradeReportID = null;
				SideTradeID = null;
				SideOrigTradeID = null;
				SideFillStationCd = null;
				SideReasonCd = null;
				RptSeq = null;
				SideTrdSubType = null;
				NetGrossInd = null;
				SideCurrency = null;
				SideCurrencyCodeSource = null;
				SideSettlCurrency = null;
				SideSettlCurrencyCodeSource = null;
				((IFixReset?)Parties)?.Reset();
				((IFixReset?)PartyDetailGrp)?.Reset();
				Account = null;
				AcctIDSource = null;
				AccountType = null;
				OwnerType = null;
				((IFixReset?)LimitAmts)?.Reset();
				ProcessCode = null;
				OddLot = null;
				((IFixReset?)ClrInstGrp)?.Reset();
				ClearingFeeIndicator = null;
				((IFixReset?)SideRegulatoryTradeIDGrp)?.Reset();
				SideTradeReportingIndicator = null;
				FirmTradeEventID = null;
				TradeInputSource = null;
				TradeInputDevice = null;
				ComplianceID = null;
				ComplianceText = null;
				EncodedComplianceTextLen = null;
				EncodedComplianceText = null;
				SolicitedFlag = null;
				CustOrderCapacity = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				TimeBracket = null;
				RemunerationIndicator = null;
				((IFixReset?)CommissionData)?.Reset();
				((IFixReset?)CommissionDataGrp)?.Reset();
				NumDaysInterest = null;
				ExDate = null;
				AccruedInterestRate = null;
				AccruedInterestAmt = null;
				InterestAtMaturity = null;
				EndAccruedInterestAmt = null;
				StartCash = null;
				EndCash = null;
				Concession = null;
				TotalTakedown = null;
				NetMoney = null;
				SettlCurrAmt = null;
				SettlCurrFxRate = null;
				SettlCurrFxRateCalc = null;
				PositionEffect = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
				SideMultiLegReportingType = null;
				((IFixReset?)ContAmtGrp)?.Reset();
				((IFixReset?)Stipulations)?.Reset();
				((IFixReset?)MiscFeesGrp)?.Reset();
				ExchangeRule = null;
				TradeAllocIndicator = null;
				TradeAllocGroupInstruction = null;
				AllocGroupID = null;
				PreviousAllocGroupID = null;
				GroupAmount = null;
				AllocGroupStatus = null;
				SideAvgPxIndicator = null;
				SideAvgPxGroupID = null;
				SideAvgPx = null;
				PreallocMethod = null;
				AllocID = null;
				((IFixReset?)TrdAllocGrp)?.Reset();
				((IFixReset?)SideTrdRegTS)?.Reset();
				((IFixReset?)SettlDetails)?.Reset();
				SideGrossTradeAmt = null;
				AggressorIndicator = null;
				ExchangeSpecialInstructions = null;
				SideShortSaleExemptionReason = null;
				OrderCategory = null;
				SideLiquidityInd = null;
				StrategyLinkID = null;
				((IFixReset?)TradeReportOrderDetail)?.Reset();
				CustOrderHandlingInst = null;
				OrderHandlingInstSource = null;
				((IFixReset?)TradePositionQty)?.Reset();
				((IFixReset?)RelatedTradeGrp)?.Reset();
				((IFixReset?)RelatedPositionGrp)?.Reset();
				BlockTrdAllocIndicator = null;
				SideRiskLimitCheckStatus = null;
				LastCapacity = null;
				RefRiskLimitCheckID = null;
				RefRiskLimitCheckIDType = null;
				CompressionGroupID = null;
				((IFixReset?)SideCollateralAmountGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 552, Offset = 0, Required = false)]
		public NoSides[]? Sides {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Sides is not null && Sides.Length != 0)
			{
				writer.WriteWholeNumber(552, Sides.Length);
				for (int i = 0; i < Sides.Length; i++)
				{
					((IFixEncoder)Sides[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSides") is IMessageView viewNoSides)
			{
				var count = viewNoSides.GroupCount();
				Sides = new NoSides[count];
				for (int i = 0; i < count; i++)
				{
					Sides[i] = new();
					((IFixParser)Sides[i]).Parse(viewNoSides.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSides":
				{
					value = Sides;
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
			Sides = null;
		}
	}
}
