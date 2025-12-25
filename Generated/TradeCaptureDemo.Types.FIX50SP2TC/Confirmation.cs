using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AK", FixVersion.FIX50SP2)]
	public sealed partial class Confirmation : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 664, Type = TagType.String, Offset = 1, Required = true)]
		public string? ConfirmID {get; set;}
		
		[TagDetails(Tag = 772, Type = TagType.String, Offset = 2, Required = false)]
		public string? ConfirmRefID {get; set;}
		
		[TagDetails(Tag = 859, Type = TagType.String, Offset = 3, Required = false)]
		public string? ConfirmReqID {get; set;}
		
		[TagDetails(Tag = 666, Type = TagType.Int, Offset = 4, Required = true)]
		public int? ConfirmTransType {get; set;}
		
		[TagDetails(Tag = 773, Type = TagType.Int, Offset = 5, Required = true)]
		public int? ConfirmType {get; set;}
		
		[TagDetails(Tag = 797, Type = TagType.Boolean, Offset = 6, Required = false)]
		public bool? CopyMsgIndicator {get; set;}
		
		[TagDetails(Tag = 650, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? LegalConfirm {get; set;}
		
		[TagDetails(Tag = 665, Type = TagType.Int, Offset = 8, Required = true)]
		public int? ConfirmStatus {get; set;}
		
		[TagDetails(Tag = 573, Type = TagType.String, Offset = 9, Required = false)]
		public string? MatchStatus {get; set;}
		
		[TagDetails(Tag = 940, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AffirmStatus {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public RegulatoryTradeIDGrp? RegulatoryTradeIDGrp {get; set;}
		
		[TagDetails(Tag = 2390, Type = TagType.String, Offset = 12, Required = false)]
		public string? TradeConfirmationReferenceID {get; set;}
		
		[TagDetails(Tag = 1832, Type = TagType.Int, Offset = 13, Required = false)]
		public int? ClearedIndicator {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 15, Required = false)]
		public OrdAllocGrp? OrdAllocGrp {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public ExecAllocGrp? ExecAllocGrp {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 17, Required = false)]
		public string? AllocID {get; set;}
		
		[TagDetails(Tag = 793, Type = TagType.String, Offset = 18, Required = false)]
		public string? SecondaryAllocID {get; set;}
		
		[TagDetails(Tag = 467, Type = TagType.String, Offset = 19, Required = false)]
		public string? IndividualAllocID {get; set;}
		
		[TagDetails(Tag = 828, Type = TagType.Int, Offset = 20, Required = false)]
		public int? TrdType {get; set;}
		
		[TagDetails(Tag = 829, Type = TagType.Int, Offset = 21, Required = false)]
		public int? TrdSubType {get; set;}
		
		[TagDetails(Tag = 855, Type = TagType.Int, Offset = 22, Required = false)]
		public int? SecondaryTrdType {get; set;}
		
		[TagDetails(Tag = 1937, Type = TagType.Int, Offset = 23, Required = false)]
		public int? TradeContinuation {get; set;}
		
		[TagDetails(Tag = 2374, Type = TagType.String, Offset = 24, Required = false)]
		public string? TradeContinuationText {get; set;}
		
		[TagDetails(Tag = 2372, Type = TagType.Length, Offset = 25, Required = false)]
		public int? EncodedTradeContinuationTextLen {get; set;}
		
		[TagDetails(Tag = 2371, Type = TagType.RawData, Offset = 26, Required = false)]
		public byte[]? EncodedTradeContinuationText {get; set;}
		
		[TagDetails(Tag = 574, Type = TagType.String, Offset = 27, Required = false)]
		public string? MatchType {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 28, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 29, Required = true)]
		public DateOnly? TradeDate {get; set;}
		
		[Component(Offset = 30, Required = false)]
		public TrdRegTimestamps? TrdRegTimestamps {get; set;}
		
		[Component(Offset = 31, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public InstrumentExtension? InstrumentExtension {get; set;}
		
		[Component(Offset = 33, Required = false)]
		public FinancingDetails? FinancingDetails {get; set;}
		
		[Component(Offset = 34, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 35, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[Component(Offset = 36, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[TagDetails(Tag = 80, Type = TagType.Float, Offset = 37, Required = true)]
		public double? AllocQty {get; set;}
		
		[TagDetails(Tag = 854, Type = TagType.Int, Offset = 38, Required = false)]
		public int? QtyType {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 39, Required = true)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 40, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 41, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 30, Type = TagType.String, Offset = 42, Required = false)]
		public string? LastMkt {get; set;}
		
		[Component(Offset = 43, Required = true)]
		public CpctyConfGrp? CpctyConfGrp {get; set;}
		
		[TagDetails(Tag = 79, Type = TagType.String, Offset = 44, Required = true)]
		public string? AllocAccount {get; set;}
		
		[TagDetails(Tag = 661, Type = TagType.Int, Offset = 45, Required = false)]
		public int? AllocAcctIDSource {get; set;}
		
		[TagDetails(Tag = 798, Type = TagType.Int, Offset = 46, Required = false)]
		public int? AllocAccountType {get; set;}
		
		[TagDetails(Tag = 6, Type = TagType.Float, Offset = 47, Required = true)]
		public double? AvgPx {get; set;}
		
		[TagDetails(Tag = 74, Type = TagType.Int, Offset = 48, Required = false)]
		public int? AvgPxPrecision {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 49, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 50, Required = false)]
		public PriceQualifierGrp? PriceQualifierGrp {get; set;}
		
		[TagDetails(Tag = 860, Type = TagType.Float, Offset = 51, Required = false)]
		public double? AvgParPx {get; set;}
		
		[Component(Offset = 52, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[TagDetails(Tag = 861, Type = TagType.Float, Offset = 53, Required = false)]
		public double? ReportedPx {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 54, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 55, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 56, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 81, Type = TagType.String, Offset = 57, Required = false)]
		public string? ProcessCode {get; set;}
		
		[TagDetails(Tag = 381, Type = TagType.Float, Offset = 58, Required = true)]
		public double? GrossTradeAmt {get; set;}
		
		[TagDetails(Tag = 157, Type = TagType.Int, Offset = 59, Required = false)]
		public int? NumDaysInterest {get; set;}
		
		[TagDetails(Tag = 230, Type = TagType.LocalDate, Offset = 60, Required = false)]
		public DateOnly? ExDate {get; set;}
		
		[TagDetails(Tag = 158, Type = TagType.Float, Offset = 61, Required = false)]
		public double? AccruedInterestRate {get; set;}
		
		[TagDetails(Tag = 159, Type = TagType.Float, Offset = 62, Required = false)]
		public double? AccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 738, Type = TagType.Float, Offset = 63, Required = false)]
		public double? InterestAtMaturity {get; set;}
		
		[TagDetails(Tag = 920, Type = TagType.Float, Offset = 64, Required = false)]
		public double? EndAccruedInterestAmt {get; set;}
		
		[TagDetails(Tag = 921, Type = TagType.Float, Offset = 65, Required = false)]
		public double? StartCash {get; set;}
		
		[TagDetails(Tag = 922, Type = TagType.Float, Offset = 66, Required = false)]
		public double? EndCash {get; set;}
		
		[TagDetails(Tag = 238, Type = TagType.Float, Offset = 67, Required = false)]
		public double? Concession {get; set;}
		
		[TagDetails(Tag = 237, Type = TagType.Float, Offset = 68, Required = false)]
		public double? TotalTakedown {get; set;}
		
		[TagDetails(Tag = 118, Type = TagType.Float, Offset = 69, Required = true)]
		public double? NetMoney {get; set;}
		
		[TagDetails(Tag = 890, Type = TagType.Float, Offset = 70, Required = false)]
		public double? MaturityNetMoney {get; set;}
		
		[TagDetails(Tag = 119, Type = TagType.Float, Offset = 71, Required = false)]
		public double? SettlCurrAmt {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 72, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 73, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 155, Type = TagType.Float, Offset = 74, Required = false)]
		public double? SettlCurrFxRate {get; set;}
		
		[TagDetails(Tag = 156, Type = TagType.String, Offset = 75, Required = false)]
		public string? SettlCurrFxRateCalc {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 76, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 77, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[Component(Offset = 78, Required = false)]
		public SettlInstructionsData? SettlInstructionsData {get; set;}
		
		[Component(Offset = 79, Required = false)]
		public CommissionData? CommissionData {get; set;}
		
		[TagDetails(Tag = 858, Type = TagType.Float, Offset = 80, Required = false)]
		public double? SharedCommission {get; set;}
		
		[Component(Offset = 81, Required = false)]
		public CommissionDataGrp? CommissionDataGrp {get; set;}
		
		[Component(Offset = 82, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[Component(Offset = 83, Required = false)]
		public MiscFeesGrp? MiscFeesGrp {get; set;}
		
		[Component(Offset = 84, Required = false)]
		public MatchExceptionGrp? MatchExceptionGrp {get; set;}
		
		[Component(Offset = 85, Required = false)]
		public MatchingDataPointGrp? MatchingDataPointGrp {get; set;}
		
		[Component(Offset = 86, Required = true)]
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
			if (ConfirmRefID is not null) writer.WriteString(772, ConfirmRefID);
			if (ConfirmReqID is not null) writer.WriteString(859, ConfirmReqID);
			if (ConfirmTransType is not null) writer.WriteWholeNumber(666, ConfirmTransType.Value);
			if (ConfirmType is not null) writer.WriteWholeNumber(773, ConfirmType.Value);
			if (CopyMsgIndicator is not null) writer.WriteBoolean(797, CopyMsgIndicator.Value);
			if (LegalConfirm is not null) writer.WriteBoolean(650, LegalConfirm.Value);
			if (ConfirmStatus is not null) writer.WriteWholeNumber(665, ConfirmStatus.Value);
			if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
			if (AffirmStatus is not null) writer.WriteWholeNumber(940, AffirmStatus.Value);
			if (RegulatoryTradeIDGrp is not null) ((IFixEncoder)RegulatoryTradeIDGrp).Encode(writer);
			if (TradeConfirmationReferenceID is not null) writer.WriteString(2390, TradeConfirmationReferenceID);
			if (ClearedIndicator is not null) writer.WriteWholeNumber(1832, ClearedIndicator.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (OrdAllocGrp is not null) ((IFixEncoder)OrdAllocGrp).Encode(writer);
			if (ExecAllocGrp is not null) ((IFixEncoder)ExecAllocGrp).Encode(writer);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (SecondaryAllocID is not null) writer.WriteString(793, SecondaryAllocID);
			if (IndividualAllocID is not null) writer.WriteString(467, IndividualAllocID);
			if (TrdType is not null) writer.WriteWholeNumber(828, TrdType.Value);
			if (TrdSubType is not null) writer.WriteWholeNumber(829, TrdSubType.Value);
			if (SecondaryTrdType is not null) writer.WriteWholeNumber(855, SecondaryTrdType.Value);
			if (TradeContinuation is not null) writer.WriteWholeNumber(1937, TradeContinuation.Value);
			if (TradeContinuationText is not null) writer.WriteString(2374, TradeContinuationText);
			if (EncodedTradeContinuationTextLen is not null) writer.WriteWholeNumber(2372, EncodedTradeContinuationTextLen.Value);
			if (EncodedTradeContinuationText is not null) writer.WriteBuffer(2371, EncodedTradeContinuationText);
			if (MatchType is not null) writer.WriteString(574, MatchType);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TrdRegTimestamps is not null) ((IFixEncoder)TrdRegTimestamps).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (InstrumentExtension is not null) ((IFixEncoder)InstrumentExtension).Encode(writer);
			if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
			if (AllocQty is not null) writer.WriteNumber(80, AllocQty.Value);
			if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
			if (Side is not null) writer.WriteString(54, Side);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (LastMkt is not null) writer.WriteString(30, LastMkt);
			if (CpctyConfGrp is not null) ((IFixEncoder)CpctyConfGrp).Encode(writer);
			if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
			if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
			if (AllocAccountType is not null) writer.WriteWholeNumber(798, AllocAccountType.Value);
			if (AvgPx is not null) writer.WriteNumber(6, AvgPx.Value);
			if (AvgPxPrecision is not null) writer.WriteWholeNumber(74, AvgPxPrecision.Value);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
			if (AvgParPx is not null) writer.WriteNumber(860, AvgParPx.Value);
			if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
			if (ReportedPx is not null) writer.WriteNumber(861, ReportedPx.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
			if (GrossTradeAmt is not null) writer.WriteNumber(381, GrossTradeAmt.Value);
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
			if (MaturityNetMoney is not null) writer.WriteNumber(890, MaturityNetMoney.Value);
			if (SettlCurrAmt is not null) writer.WriteNumber(119, SettlCurrAmt.Value);
			if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
			if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
			if (SettlCurrFxRate is not null) writer.WriteNumber(155, SettlCurrFxRate.Value);
			if (SettlCurrFxRateCalc is not null) writer.WriteString(156, SettlCurrFxRateCalc);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (SettlInstructionsData is not null) ((IFixEncoder)SettlInstructionsData).Encode(writer);
			if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
			if (SharedCommission is not null) writer.WriteNumber(858, SharedCommission.Value);
			if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
			if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
			if (MatchExceptionGrp is not null) ((IFixEncoder)MatchExceptionGrp).Encode(writer);
			if (MatchingDataPointGrp is not null) ((IFixEncoder)MatchingDataPointGrp).Encode(writer);
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
			ConfirmRefID = view.GetString(772);
			ConfirmReqID = view.GetString(859);
			ConfirmTransType = view.GetInt32(666);
			ConfirmType = view.GetInt32(773);
			CopyMsgIndicator = view.GetBool(797);
			LegalConfirm = view.GetBool(650);
			ConfirmStatus = view.GetInt32(665);
			MatchStatus = view.GetString(573);
			AffirmStatus = view.GetInt32(940);
			if (view.GetView("RegulatoryTradeIDGrp") is IMessageView viewRegulatoryTradeIDGrp)
			{
				RegulatoryTradeIDGrp = new();
				((IFixParser)RegulatoryTradeIDGrp).Parse(viewRegulatoryTradeIDGrp);
			}
			TradeConfirmationReferenceID = view.GetString(2390);
			ClearedIndicator = view.GetInt32(1832);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("OrdAllocGrp") is IMessageView viewOrdAllocGrp)
			{
				OrdAllocGrp = new();
				((IFixParser)OrdAllocGrp).Parse(viewOrdAllocGrp);
			}
			if (view.GetView("ExecAllocGrp") is IMessageView viewExecAllocGrp)
			{
				ExecAllocGrp = new();
				((IFixParser)ExecAllocGrp).Parse(viewExecAllocGrp);
			}
			AllocID = view.GetString(70);
			SecondaryAllocID = view.GetString(793);
			IndividualAllocID = view.GetString(467);
			TrdType = view.GetInt32(828);
			TrdSubType = view.GetInt32(829);
			SecondaryTrdType = view.GetInt32(855);
			TradeContinuation = view.GetInt32(1937);
			TradeContinuationText = view.GetString(2374);
			EncodedTradeContinuationTextLen = view.GetInt32(2372);
			EncodedTradeContinuationText = view.GetByteArray(2371);
			MatchType = view.GetString(574);
			TransactTime = view.GetDateTime(60);
			TradeDate = view.GetDateOnly(75);
			if (view.GetView("TrdRegTimestamps") is IMessageView viewTrdRegTimestamps)
			{
				TrdRegTimestamps = new();
				((IFixParser)TrdRegTimestamps).Parse(viewTrdRegTimestamps);
			}
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
			if (view.GetView("YieldData") is IMessageView viewYieldData)
			{
				YieldData = new();
				((IFixParser)YieldData).Parse(viewYieldData);
			}
			AllocQty = view.GetDouble(80);
			QtyType = view.GetInt32(854);
			Side = view.GetString(54);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			LastMkt = view.GetString(30);
			if (view.GetView("CpctyConfGrp") is IMessageView viewCpctyConfGrp)
			{
				CpctyConfGrp = new();
				((IFixParser)CpctyConfGrp).Parse(viewCpctyConfGrp);
			}
			AllocAccount = view.GetString(79);
			AllocAcctIDSource = view.GetInt32(661);
			AllocAccountType = view.GetInt32(798);
			AvgPx = view.GetDouble(6);
			AvgPxPrecision = view.GetInt32(74);
			PriceType = view.GetInt32(423);
			if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
			{
				PriceQualifierGrp = new();
				((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
			}
			AvgParPx = view.GetDouble(860);
			if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
			{
				SpreadOrBenchmarkCurveData = new();
				((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
			}
			ReportedPx = view.GetDouble(861);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			ProcessCode = view.GetString(81);
			GrossTradeAmt = view.GetDouble(381);
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
			MaturityNetMoney = view.GetDouble(890);
			SettlCurrAmt = view.GetDouble(119);
			SettlCurrency = view.GetString(120);
			SettlCurrencyCodeSource = view.GetString(2899);
			SettlCurrFxRate = view.GetDouble(155);
			SettlCurrFxRateCalc = view.GetString(156);
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			if (view.GetView("SettlInstructionsData") is IMessageView viewSettlInstructionsData)
			{
				SettlInstructionsData = new();
				((IFixParser)SettlInstructionsData).Parse(viewSettlInstructionsData);
			}
			if (view.GetView("CommissionData") is IMessageView viewCommissionData)
			{
				CommissionData = new();
				((IFixParser)CommissionData).Parse(viewCommissionData);
			}
			SharedCommission = view.GetDouble(858);
			if (view.GetView("CommissionDataGrp") is IMessageView viewCommissionDataGrp)
			{
				CommissionDataGrp = new();
				((IFixParser)CommissionDataGrp).Parse(viewCommissionDataGrp);
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
				case "ConfirmRefID":
				{
					value = ConfirmRefID;
					break;
				}
				case "ConfirmReqID":
				{
					value = ConfirmReqID;
					break;
				}
				case "ConfirmTransType":
				{
					value = ConfirmTransType;
					break;
				}
				case "ConfirmType":
				{
					value = ConfirmType;
					break;
				}
				case "CopyMsgIndicator":
				{
					value = CopyMsgIndicator;
					break;
				}
				case "LegalConfirm":
				{
					value = LegalConfirm;
					break;
				}
				case "ConfirmStatus":
				{
					value = ConfirmStatus;
					break;
				}
				case "MatchStatus":
				{
					value = MatchStatus;
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
				case "ClearedIndicator":
				{
					value = ClearedIndicator;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "OrdAllocGrp":
				{
					value = OrdAllocGrp;
					break;
				}
				case "ExecAllocGrp":
				{
					value = ExecAllocGrp;
					break;
				}
				case "AllocID":
				{
					value = AllocID;
					break;
				}
				case "SecondaryAllocID":
				{
					value = SecondaryAllocID;
					break;
				}
				case "IndividualAllocID":
				{
					value = IndividualAllocID;
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
				case "MatchType":
				{
					value = MatchType;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TrdRegTimestamps":
				{
					value = TrdRegTimestamps;
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
				case "YieldData":
				{
					value = YieldData;
					break;
				}
				case "AllocQty":
				{
					value = AllocQty;
					break;
				}
				case "QtyType":
				{
					value = QtyType;
					break;
				}
				case "Side":
				{
					value = Side;
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
				case "LastMkt":
				{
					value = LastMkt;
					break;
				}
				case "CpctyConfGrp":
				{
					value = CpctyConfGrp;
					break;
				}
				case "AllocAccount":
				{
					value = AllocAccount;
					break;
				}
				case "AllocAcctIDSource":
				{
					value = AllocAcctIDSource;
					break;
				}
				case "AllocAccountType":
				{
					value = AllocAccountType;
					break;
				}
				case "AvgPx":
				{
					value = AvgPx;
					break;
				}
				case "AvgPxPrecision":
				{
					value = AvgPxPrecision;
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
				case "AvgParPx":
				{
					value = AvgParPx;
					break;
				}
				case "SpreadOrBenchmarkCurveData":
				{
					value = SpreadOrBenchmarkCurveData;
					break;
				}
				case "ReportedPx":
				{
					value = ReportedPx;
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
				case "ProcessCode":
				{
					value = ProcessCode;
					break;
				}
				case "GrossTradeAmt":
				{
					value = GrossTradeAmt;
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
				case "MaturityNetMoney":
				{
					value = MaturityNetMoney;
					break;
				}
				case "SettlCurrAmt":
				{
					value = SettlCurrAmt;
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
				case "SettlInstructionsData":
				{
					value = SettlInstructionsData;
					break;
				}
				case "CommissionData":
				{
					value = CommissionData;
					break;
				}
				case "SharedCommission":
				{
					value = SharedCommission;
					break;
				}
				case "CommissionDataGrp":
				{
					value = CommissionDataGrp;
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
			ConfirmRefID = null;
			ConfirmReqID = null;
			ConfirmTransType = null;
			ConfirmType = null;
			CopyMsgIndicator = null;
			LegalConfirm = null;
			ConfirmStatus = null;
			MatchStatus = null;
			AffirmStatus = null;
			((IFixReset?)RegulatoryTradeIDGrp)?.Reset();
			TradeConfirmationReferenceID = null;
			ClearedIndicator = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)OrdAllocGrp)?.Reset();
			((IFixReset?)ExecAllocGrp)?.Reset();
			AllocID = null;
			SecondaryAllocID = null;
			IndividualAllocID = null;
			TrdType = null;
			TrdSubType = null;
			SecondaryTrdType = null;
			TradeContinuation = null;
			TradeContinuationText = null;
			EncodedTradeContinuationTextLen = null;
			EncodedTradeContinuationText = null;
			MatchType = null;
			TransactTime = null;
			TradeDate = null;
			((IFixReset?)TrdRegTimestamps)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)InstrumentExtension)?.Reset();
			((IFixReset?)FinancingDetails)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			((IFixReset?)YieldData)?.Reset();
			AllocQty = null;
			QtyType = null;
			Side = null;
			Currency = null;
			CurrencyCodeSource = null;
			LastMkt = null;
			((IFixReset?)CpctyConfGrp)?.Reset();
			AllocAccount = null;
			AllocAcctIDSource = null;
			AllocAccountType = null;
			AvgPx = null;
			AvgPxPrecision = null;
			PriceType = null;
			((IFixReset?)PriceQualifierGrp)?.Reset();
			AvgParPx = null;
			((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
			ReportedPx = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			ProcessCode = null;
			GrossTradeAmt = null;
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
			MaturityNetMoney = null;
			SettlCurrAmt = null;
			SettlCurrency = null;
			SettlCurrencyCodeSource = null;
			SettlCurrFxRate = null;
			SettlCurrFxRateCalc = null;
			SettlType = null;
			SettlDate = null;
			((IFixReset?)SettlInstructionsData)?.Reset();
			((IFixReset?)CommissionData)?.Reset();
			SharedCommission = null;
			((IFixReset?)CommissionDataGrp)?.Reset();
			((IFixReset?)Stipulations)?.Reset();
			((IFixReset?)MiscFeesGrp)?.Reset();
			((IFixReset?)MatchExceptionGrp)?.Reset();
			((IFixReset?)MatchingDataPointGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
