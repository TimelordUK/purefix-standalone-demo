using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ListOrdGrp : IFixComponent
	{
		public sealed partial class NoOrders : IFixGroup
		{
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 0, Required = true)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 526, Type = TagType.String, Offset = 1, Required = false)]
			public string? SecondaryClOrdID {get; set;}
			
			[TagDetails(Tag = 67, Type = TagType.Int, Offset = 2, Required = true)]
			public int? ListSeqNo {get; set;}
			
			[TagDetails(Tag = 583, Type = TagType.String, Offset = 3, Required = false)]
			public string? ClOrdLinkID {get; set;}
			
			[TagDetails(Tag = 160, Type = TagType.String, Offset = 4, Required = false)]
			public string? SettlInstMode {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public Parties? Parties {get; set;}
			
			[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? TradeOriginationDate {get; set;}
			
			[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 7, Required = false)]
			public DateOnly? TradeDate {get; set;}
			
			[TagDetails(Tag = 1, Type = TagType.String, Offset = 8, Required = false)]
			public string? Account {get; set;}
			
			[TagDetails(Tag = 660, Type = TagType.Int, Offset = 9, Required = false)]
			public int? AcctIDSource {get; set;}
			
			[TagDetails(Tag = 581, Type = TagType.Int, Offset = 10, Required = false)]
			public int? AccountType {get; set;}
			
			[TagDetails(Tag = 589, Type = TagType.String, Offset = 11, Required = false)]
			public string? DayBookingInst {get; set;}
			
			[TagDetails(Tag = 590, Type = TagType.String, Offset = 12, Required = false)]
			public string? BookingUnit {get; set;}
			
			[TagDetails(Tag = 70, Type = TagType.String, Offset = 13, Required = false)]
			public string? AllocID {get; set;}
			
			[TagDetails(Tag = 591, Type = TagType.String, Offset = 14, Required = false)]
			public string? PreallocMethod {get; set;}
			
			[Component(Offset = 15, Required = false)]
			public PreAllocGrp? PreAllocGrp {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 16, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 17, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 544, Type = TagType.String, Offset = 18, Required = false)]
			public string? CashMargin {get; set;}
			
			[TagDetails(Tag = 635, Type = TagType.String, Offset = 19, Required = false)]
			public string? ClearingFeeIndicator {get; set;}
			
			[TagDetails(Tag = 21, Type = TagType.String, Offset = 20, Required = false)]
			public string? HandlInst {get; set;}
			
			[TagDetails(Tag = 18, Type = TagType.String, Offset = 21, Required = false)]
			public string? ExecInst {get; set;}
			
			[TagDetails(Tag = 110, Type = TagType.Float, Offset = 22, Required = false)]
			public double? MinQty {get; set;}
			
			[TagDetails(Tag = 1089, Type = TagType.Float, Offset = 23, Required = false)]
			public double? MatchIncrement {get; set;}
			
			[TagDetails(Tag = 1090, Type = TagType.Int, Offset = 24, Required = false)]
			public int? MaxPriceLevels {get; set;}
			
			[Component(Offset = 25, Required = false)]
			public DisplayInstruction? DisplayInstruction {get; set;}
			
			[TagDetails(Tag = 111, Type = TagType.Float, Offset = 26, Required = false)]
			public double? MaxFloor {get; set;}
			
			[TagDetails(Tag = 100, Type = TagType.String, Offset = 27, Required = false)]
			public string? ExDestination {get; set;}
			
			[TagDetails(Tag = 1133, Type = TagType.String, Offset = 28, Required = false)]
			public string? ExDestinationIDSource {get; set;}
			
			[Component(Offset = 29, Required = false)]
			public TrdgSesGrp? TrdgSesGrp {get; set;}
			
			[TagDetails(Tag = 81, Type = TagType.String, Offset = 30, Required = false)]
			public string? ProcessCode {get; set;}
			
			[Component(Offset = 31, Required = true)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[TagDetails(Tag = 140, Type = TagType.Float, Offset = 33, Required = false)]
			public double? PrevClosePx {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 34, Required = true)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 2102, Type = TagType.Boolean, Offset = 35, Required = false)]
			public bool? ShortMarkingExemptIndicator {get; set;}
			
			[TagDetails(Tag = 1688, Type = TagType.Int, Offset = 36, Required = false)]
			public int? ShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 401, Type = TagType.Int, Offset = 37, Required = false)]
			public int? SideValueInd {get; set;}
			
			[TagDetails(Tag = 114, Type = TagType.Boolean, Offset = 38, Required = false)]
			public bool? LocateReqd {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 39, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			[Component(Offset = 40, Required = false)]
			public Stipulations? Stipulations {get; set;}
			
			[TagDetails(Tag = 854, Type = TagType.Int, Offset = 41, Required = false)]
			public int? QtyType {get; set;}
			
			[Component(Offset = 42, Required = true)]
			public OrderQtyData? OrderQtyData {get; set;}
			
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 43, Required = false)]
			public string? OrdType {get; set;}
			
			[TagDetails(Tag = 423, Type = TagType.Int, Offset = 44, Required = false)]
			public int? PriceType {get; set;}
			
			[TagDetails(Tag = 44, Type = TagType.Float, Offset = 45, Required = false)]
			public double? Price {get; set;}
			
			[TagDetails(Tag = 1092, Type = TagType.String, Offset = 46, Required = false)]
			public string? PriceProtectionScope {get; set;}
			
			[TagDetails(Tag = 99, Type = TagType.Float, Offset = 47, Required = false)]
			public double? StopPx {get; set;}
			
			[Component(Offset = 48, Required = false)]
			public TriggeringInstruction? TriggeringInstruction {get; set;}
			
			[Component(Offset = 49, Required = false)]
			public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
			
			[Component(Offset = 50, Required = false)]
			public YieldData? YieldData {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 51, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 52, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 376, Type = TagType.String, Offset = 53, Required = false)]
			public string? ComplianceID {get; set;}
			
			[TagDetails(Tag = 2404, Type = TagType.String, Offset = 54, Required = false)]
			public string? ComplianceText {get; set;}
			
			[TagDetails(Tag = 2351, Type = TagType.Length, Offset = 55, Required = false)]
			public int? EncodedComplianceTextLen {get; set;}
			
			[TagDetails(Tag = 2352, Type = TagType.RawData, Offset = 56, Required = false)]
			public byte[]? EncodedComplianceText {get; set;}
			
			[TagDetails(Tag = 377, Type = TagType.Boolean, Offset = 57, Required = false)]
			public bool? SolicitedFlag {get; set;}
			
			[TagDetails(Tag = 23, Type = TagType.String, Offset = 58, Required = false)]
			public string? IOIID {get; set;}
			
			[TagDetails(Tag = 117, Type = TagType.String, Offset = 59, Required = false)]
			public string? QuoteID {get; set;}
			
			[TagDetails(Tag = 1080, Type = TagType.String, Offset = 60, Required = false)]
			public string? RefOrderID {get; set;}
			
			[TagDetails(Tag = 1081, Type = TagType.String, Offset = 61, Required = false)]
			public string? RefOrderIDSource {get; set;}
			
			[TagDetails(Tag = 59, Type = TagType.String, Offset = 62, Required = false)]
			public string? TimeInForce {get; set;}
			
			[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 63, Required = false)]
			public DateTime? EffectiveTime {get; set;}
			
			[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 64, Required = false)]
			public DateOnly? ExpireDate {get; set;}
			
			[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 65, Required = false)]
			public DateTime? ExpireTime {get; set;}
			
			[TagDetails(Tag = 427, Type = TagType.Int, Offset = 66, Required = false)]
			public int? GTBookingInst {get; set;}
			
			[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 67, Required = false)]
			public int? ExposureDuration {get; set;}
			
			[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 68, Required = false)]
			public int? ExposureDurationUnit {get; set;}
			
			[Component(Offset = 69, Required = false)]
			public CommissionData? CommissionData {get; set;}
			
			[Component(Offset = 70, Required = false)]
			public CommissionDataGrp? CommissionDataGrp {get; set;}
			
			[TagDetails(Tag = 528, Type = TagType.String, Offset = 71, Required = false)]
			public string? OrderCapacity {get; set;}
			
			[TagDetails(Tag = 529, Type = TagType.String, Offset = 72, Required = false)]
			public string? OrderRestrictions {get; set;}
			
			[TagDetails(Tag = 1091, Type = TagType.Boolean, Offset = 73, Required = false)]
			public bool? PreTradeAnonymity {get; set;}
			
			[TagDetails(Tag = 582, Type = TagType.Int, Offset = 74, Required = false)]
			public int? CustOrderCapacity {get; set;}
			
			[Component(Offset = 75, Required = false)]
			public OrderAttributeGrp? OrderAttributeGrp {get; set;}
			
			[TagDetails(Tag = 121, Type = TagType.Boolean, Offset = 76, Required = false)]
			public bool? ForexReq {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 77, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 78, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 775, Type = TagType.Int, Offset = 79, Required = false)]
			public int? BookingType {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 80, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 81, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 82, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 83, Required = false)]
			public DateOnly? SettlDate2 {get; set;}
			
			[TagDetails(Tag = 192, Type = TagType.Float, Offset = 84, Required = false)]
			public double? OrderQty2 {get; set;}
			
			[TagDetails(Tag = 640, Type = TagType.Float, Offset = 85, Required = false)]
			public double? Price2 {get; set;}
			
			[TagDetails(Tag = 77, Type = TagType.String, Offset = 86, Required = false)]
			public string? PositionEffect {get; set;}
			
			[TagDetails(Tag = 203, Type = TagType.Int, Offset = 87, Required = false)]
			public int? CoveredOrUncovered {get; set;}
			
			[TagDetails(Tag = 210, Type = TagType.Float, Offset = 88, Required = false)]
			public double? MaxShow {get; set;}
			
			[Component(Offset = 89, Required = false)]
			public PegInstructions? PegInstructions {get; set;}
			
			[Component(Offset = 90, Required = false)]
			public DiscretionInstructions? DiscretionInstructions {get; set;}
			
			[TagDetails(Tag = 847, Type = TagType.Int, Offset = 91, Required = false)]
			public int? TargetStrategy {get; set;}
			
			[Component(Offset = 92, Required = false)]
			public StrategyParametersGrp? StrategyParametersGrp {get; set;}
			
			[TagDetails(Tag = 848, Type = TagType.String, Offset = 93, Required = false)]
			public string? TargetStrategyParameters {get; set;}
			
			[TagDetails(Tag = 849, Type = TagType.Float, Offset = 94, Required = false)]
			public double? ParticipationRate {get; set;}
			
			[TagDetails(Tag = 494, Type = TagType.String, Offset = 95, Required = false)]
			public string? Designation {get; set;}
			
			[TagDetails(Tag = 1028, Type = TagType.Boolean, Offset = 96, Required = false)]
			public bool? ManualOrderIndicator {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
				if (ListSeqNo is not null) writer.WriteWholeNumber(67, ListSeqNo.Value);
				if (ClOrdLinkID is not null) writer.WriteString(583, ClOrdLinkID);
				if (SettlInstMode is not null) writer.WriteString(160, SettlInstMode);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
				if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
				if (Account is not null) writer.WriteString(1, Account);
				if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
				if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
				if (DayBookingInst is not null) writer.WriteString(589, DayBookingInst);
				if (BookingUnit is not null) writer.WriteString(590, BookingUnit);
				if (AllocID is not null) writer.WriteString(70, AllocID);
				if (PreallocMethod is not null) writer.WriteString(591, PreallocMethod);
				if (PreAllocGrp is not null) ((IFixEncoder)PreAllocGrp).Encode(writer);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (CashMargin is not null) writer.WriteString(544, CashMargin);
				if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
				if (HandlInst is not null) writer.WriteString(21, HandlInst);
				if (ExecInst is not null) writer.WriteString(18, ExecInst);
				if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
				if (MatchIncrement is not null) writer.WriteNumber(1089, MatchIncrement.Value);
				if (MaxPriceLevels is not null) writer.WriteWholeNumber(1090, MaxPriceLevels.Value);
				if (DisplayInstruction is not null) ((IFixEncoder)DisplayInstruction).Encode(writer);
				if (MaxFloor is not null) writer.WriteNumber(111, MaxFloor.Value);
				if (ExDestination is not null) writer.WriteString(100, ExDestination);
				if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
				if (TrdgSesGrp is not null) ((IFixEncoder)TrdgSesGrp).Encode(writer);
				if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (PrevClosePx is not null) writer.WriteNumber(140, PrevClosePx.Value);
				if (Side is not null) writer.WriteString(54, Side);
				if (ShortMarkingExemptIndicator is not null) writer.WriteBoolean(2102, ShortMarkingExemptIndicator.Value);
				if (ShortSaleExemptionReason is not null) writer.WriteWholeNumber(1688, ShortSaleExemptionReason.Value);
				if (SideValueInd is not null) writer.WriteWholeNumber(401, SideValueInd.Value);
				if (LocateReqd is not null) writer.WriteBoolean(114, LocateReqd.Value);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
				if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
				if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
				if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
				if (OrdType is not null) writer.WriteString(40, OrdType);
				if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
				if (Price is not null) writer.WriteNumber(44, Price.Value);
				if (PriceProtectionScope is not null) writer.WriteString(1092, PriceProtectionScope);
				if (StopPx is not null) writer.WriteNumber(99, StopPx.Value);
				if (TriggeringInstruction is not null) ((IFixEncoder)TriggeringInstruction).Encode(writer);
				if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
				if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (ComplianceID is not null) writer.WriteString(376, ComplianceID);
				if (ComplianceText is not null) writer.WriteString(2404, ComplianceText);
				if (EncodedComplianceTextLen is not null) writer.WriteWholeNumber(2351, EncodedComplianceTextLen.Value);
				if (EncodedComplianceText is not null) writer.WriteBuffer(2352, EncodedComplianceText);
				if (SolicitedFlag is not null) writer.WriteBoolean(377, SolicitedFlag.Value);
				if (IOIID is not null) writer.WriteString(23, IOIID);
				if (QuoteID is not null) writer.WriteString(117, QuoteID);
				if (RefOrderID is not null) writer.WriteString(1080, RefOrderID);
				if (RefOrderIDSource is not null) writer.WriteString(1081, RefOrderIDSource);
				if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
				if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
				if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
				if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
				if (GTBookingInst is not null) writer.WriteWholeNumber(427, GTBookingInst.Value);
				if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
				if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
				if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
				if (CommissionDataGrp is not null) ((IFixEncoder)CommissionDataGrp).Encode(writer);
				if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
				if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
				if (PreTradeAnonymity is not null) writer.WriteBoolean(1091, PreTradeAnonymity.Value);
				if (CustOrderCapacity is not null) writer.WriteWholeNumber(582, CustOrderCapacity.Value);
				if (OrderAttributeGrp is not null) ((IFixEncoder)OrderAttributeGrp).Encode(writer);
				if (ForexReq is not null) writer.WriteBoolean(121, ForexReq.Value);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
				if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
				if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
				if (Price2 is not null) writer.WriteNumber(640, Price2.Value);
				if (PositionEffect is not null) writer.WriteString(77, PositionEffect);
				if (CoveredOrUncovered is not null) writer.WriteWholeNumber(203, CoveredOrUncovered.Value);
				if (MaxShow is not null) writer.WriteNumber(210, MaxShow.Value);
				if (PegInstructions is not null) ((IFixEncoder)PegInstructions).Encode(writer);
				if (DiscretionInstructions is not null) ((IFixEncoder)DiscretionInstructions).Encode(writer);
				if (TargetStrategy is not null) writer.WriteWholeNumber(847, TargetStrategy.Value);
				if (StrategyParametersGrp is not null) ((IFixEncoder)StrategyParametersGrp).Encode(writer);
				if (TargetStrategyParameters is not null) writer.WriteString(848, TargetStrategyParameters);
				if (ParticipationRate is not null) writer.WriteNumber(849, ParticipationRate.Value);
				if (Designation is not null) writer.WriteString(494, Designation);
				if (ManualOrderIndicator is not null) writer.WriteBoolean(1028, ManualOrderIndicator.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ClOrdID = view.GetString(11);
				SecondaryClOrdID = view.GetString(526);
				ListSeqNo = view.GetInt32(67);
				ClOrdLinkID = view.GetString(583);
				SettlInstMode = view.GetString(160);
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				TradeOriginationDate = view.GetDateOnly(229);
				TradeDate = view.GetDateOnly(75);
				Account = view.GetString(1);
				AcctIDSource = view.GetInt32(660);
				AccountType = view.GetInt32(581);
				DayBookingInst = view.GetString(589);
				BookingUnit = view.GetString(590);
				AllocID = view.GetString(70);
				PreallocMethod = view.GetString(591);
				if (view.GetView("PreAllocGrp") is IMessageView viewPreAllocGrp)
				{
					PreAllocGrp = new();
					((IFixParser)PreAllocGrp).Parse(viewPreAllocGrp);
				}
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				CashMargin = view.GetString(544);
				ClearingFeeIndicator = view.GetString(635);
				HandlInst = view.GetString(21);
				ExecInst = view.GetString(18);
				MinQty = view.GetDouble(110);
				MatchIncrement = view.GetDouble(1089);
				MaxPriceLevels = view.GetInt32(1090);
				if (view.GetView("DisplayInstruction") is IMessageView viewDisplayInstruction)
				{
					DisplayInstruction = new();
					((IFixParser)DisplayInstruction).Parse(viewDisplayInstruction);
				}
				MaxFloor = view.GetDouble(111);
				ExDestination = view.GetString(100);
				ExDestinationIDSource = view.GetString(1133);
				if (view.GetView("TrdgSesGrp") is IMessageView viewTrdgSesGrp)
				{
					TrdgSesGrp = new();
					((IFixParser)TrdgSesGrp).Parse(viewTrdgSesGrp);
				}
				ProcessCode = view.GetString(81);
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
				if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
				{
					UndInstrmtGrp = new();
					((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
				}
				PrevClosePx = view.GetDouble(140);
				Side = view.GetString(54);
				ShortMarkingExemptIndicator = view.GetBool(2102);
				ShortSaleExemptionReason = view.GetInt32(1688);
				SideValueInd = view.GetInt32(401);
				LocateReqd = view.GetBool(114);
				TransactTime = view.GetDateTime(60);
				if (view.GetView("Stipulations") is IMessageView viewStipulations)
				{
					Stipulations = new();
					((IFixParser)Stipulations).Parse(viewStipulations);
				}
				QtyType = view.GetInt32(854);
				if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
				{
					OrderQtyData = new();
					((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
				}
				OrdType = view.GetString(40);
				PriceType = view.GetInt32(423);
				Price = view.GetDouble(44);
				PriceProtectionScope = view.GetString(1092);
				StopPx = view.GetDouble(99);
				if (view.GetView("TriggeringInstruction") is IMessageView viewTriggeringInstruction)
				{
					TriggeringInstruction = new();
					((IFixParser)TriggeringInstruction).Parse(viewTriggeringInstruction);
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
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				ComplianceID = view.GetString(376);
				ComplianceText = view.GetString(2404);
				EncodedComplianceTextLen = view.GetInt32(2351);
				EncodedComplianceText = view.GetByteArray(2352);
				SolicitedFlag = view.GetBool(377);
				IOIID = view.GetString(23);
				QuoteID = view.GetString(117);
				RefOrderID = view.GetString(1080);
				RefOrderIDSource = view.GetString(1081);
				TimeInForce = view.GetString(59);
				EffectiveTime = view.GetDateTime(168);
				ExpireDate = view.GetDateOnly(432);
				ExpireTime = view.GetDateTime(126);
				GTBookingInst = view.GetInt32(427);
				ExposureDuration = view.GetInt32(1629);
				ExposureDurationUnit = view.GetInt32(1916);
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
				OrderCapacity = view.GetString(528);
				OrderRestrictions = view.GetString(529);
				PreTradeAnonymity = view.GetBool(1091);
				CustOrderCapacity = view.GetInt32(582);
				if (view.GetView("OrderAttributeGrp") is IMessageView viewOrderAttributeGrp)
				{
					OrderAttributeGrp = new();
					((IFixParser)OrderAttributeGrp).Parse(viewOrderAttributeGrp);
				}
				ForexReq = view.GetBool(121);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				BookingType = view.GetInt32(775);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
				SettlDate2 = view.GetDateOnly(193);
				OrderQty2 = view.GetDouble(192);
				Price2 = view.GetDouble(640);
				PositionEffect = view.GetString(77);
				CoveredOrUncovered = view.GetInt32(203);
				MaxShow = view.GetDouble(210);
				if (view.GetView("PegInstructions") is IMessageView viewPegInstructions)
				{
					PegInstructions = new();
					((IFixParser)PegInstructions).Parse(viewPegInstructions);
				}
				if (view.GetView("DiscretionInstructions") is IMessageView viewDiscretionInstructions)
				{
					DiscretionInstructions = new();
					((IFixParser)DiscretionInstructions).Parse(viewDiscretionInstructions);
				}
				TargetStrategy = view.GetInt32(847);
				if (view.GetView("StrategyParametersGrp") is IMessageView viewStrategyParametersGrp)
				{
					StrategyParametersGrp = new();
					((IFixParser)StrategyParametersGrp).Parse(viewStrategyParametersGrp);
				}
				TargetStrategyParameters = view.GetString(848);
				ParticipationRate = view.GetDouble(849);
				Designation = view.GetString(494);
				ManualOrderIndicator = view.GetBool(1028);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ClOrdID":
					{
						value = ClOrdID;
						break;
					}
					case "SecondaryClOrdID":
					{
						value = SecondaryClOrdID;
						break;
					}
					case "ListSeqNo":
					{
						value = ListSeqNo;
						break;
					}
					case "ClOrdLinkID":
					{
						value = ClOrdLinkID;
						break;
					}
					case "SettlInstMode":
					{
						value = SettlInstMode;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "TradeOriginationDate":
					{
						value = TradeOriginationDate;
						break;
					}
					case "TradeDate":
					{
						value = TradeDate;
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
					case "DayBookingInst":
					{
						value = DayBookingInst;
						break;
					}
					case "BookingUnit":
					{
						value = BookingUnit;
						break;
					}
					case "AllocID":
					{
						value = AllocID;
						break;
					}
					case "PreallocMethod":
					{
						value = PreallocMethod;
						break;
					}
					case "PreAllocGrp":
					{
						value = PreAllocGrp;
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
					case "CashMargin":
					{
						value = CashMargin;
						break;
					}
					case "ClearingFeeIndicator":
					{
						value = ClearingFeeIndicator;
						break;
					}
					case "HandlInst":
					{
						value = HandlInst;
						break;
					}
					case "ExecInst":
					{
						value = ExecInst;
						break;
					}
					case "MinQty":
					{
						value = MinQty;
						break;
					}
					case "MatchIncrement":
					{
						value = MatchIncrement;
						break;
					}
					case "MaxPriceLevels":
					{
						value = MaxPriceLevels;
						break;
					}
					case "DisplayInstruction":
					{
						value = DisplayInstruction;
						break;
					}
					case "MaxFloor":
					{
						value = MaxFloor;
						break;
					}
					case "ExDestination":
					{
						value = ExDestination;
						break;
					}
					case "ExDestinationIDSource":
					{
						value = ExDestinationIDSource;
						break;
					}
					case "TrdgSesGrp":
					{
						value = TrdgSesGrp;
						break;
					}
					case "ProcessCode":
					{
						value = ProcessCode;
						break;
					}
					case "Instrument":
					{
						value = Instrument;
						break;
					}
					case "UndInstrmtGrp":
					{
						value = UndInstrmtGrp;
						break;
					}
					case "PrevClosePx":
					{
						value = PrevClosePx;
						break;
					}
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
					case "ShortSaleExemptionReason":
					{
						value = ShortSaleExemptionReason;
						break;
					}
					case "SideValueInd":
					{
						value = SideValueInd;
						break;
					}
					case "LocateReqd":
					{
						value = LocateReqd;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
						break;
					}
					case "Stipulations":
					{
						value = Stipulations;
						break;
					}
					case "QtyType":
					{
						value = QtyType;
						break;
					}
					case "OrderQtyData":
					{
						value = OrderQtyData;
						break;
					}
					case "OrdType":
					{
						value = OrdType;
						break;
					}
					case "PriceType":
					{
						value = PriceType;
						break;
					}
					case "Price":
					{
						value = Price;
						break;
					}
					case "PriceProtectionScope":
					{
						value = PriceProtectionScope;
						break;
					}
					case "StopPx":
					{
						value = StopPx;
						break;
					}
					case "TriggeringInstruction":
					{
						value = TriggeringInstruction;
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
					case "IOIID":
					{
						value = IOIID;
						break;
					}
					case "QuoteID":
					{
						value = QuoteID;
						break;
					}
					case "RefOrderID":
					{
						value = RefOrderID;
						break;
					}
					case "RefOrderIDSource":
					{
						value = RefOrderIDSource;
						break;
					}
					case "TimeInForce":
					{
						value = TimeInForce;
						break;
					}
					case "EffectiveTime":
					{
						value = EffectiveTime;
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
					case "GTBookingInst":
					{
						value = GTBookingInst;
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
					case "OrderCapacity":
					{
						value = OrderCapacity;
						break;
					}
					case "OrderRestrictions":
					{
						value = OrderRestrictions;
						break;
					}
					case "PreTradeAnonymity":
					{
						value = PreTradeAnonymity;
						break;
					}
					case "CustOrderCapacity":
					{
						value = CustOrderCapacity;
						break;
					}
					case "OrderAttributeGrp":
					{
						value = OrderAttributeGrp;
						break;
					}
					case "ForexReq":
					{
						value = ForexReq;
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
					case "BookingType":
					{
						value = BookingType;
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
					case "SettlDate2":
					{
						value = SettlDate2;
						break;
					}
					case "OrderQty2":
					{
						value = OrderQty2;
						break;
					}
					case "Price2":
					{
						value = Price2;
						break;
					}
					case "PositionEffect":
					{
						value = PositionEffect;
						break;
					}
					case "CoveredOrUncovered":
					{
						value = CoveredOrUncovered;
						break;
					}
					case "MaxShow":
					{
						value = MaxShow;
						break;
					}
					case "PegInstructions":
					{
						value = PegInstructions;
						break;
					}
					case "DiscretionInstructions":
					{
						value = DiscretionInstructions;
						break;
					}
					case "TargetStrategy":
					{
						value = TargetStrategy;
						break;
					}
					case "StrategyParametersGrp":
					{
						value = StrategyParametersGrp;
						break;
					}
					case "TargetStrategyParameters":
					{
						value = TargetStrategyParameters;
						break;
					}
					case "ParticipationRate":
					{
						value = ParticipationRate;
						break;
					}
					case "Designation":
					{
						value = Designation;
						break;
					}
					case "ManualOrderIndicator":
					{
						value = ManualOrderIndicator;
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
				ClOrdID = null;
				SecondaryClOrdID = null;
				ListSeqNo = null;
				ClOrdLinkID = null;
				SettlInstMode = null;
				((IFixReset?)Parties)?.Reset();
				TradeOriginationDate = null;
				TradeDate = null;
				Account = null;
				AcctIDSource = null;
				AccountType = null;
				DayBookingInst = null;
				BookingUnit = null;
				AllocID = null;
				PreallocMethod = null;
				((IFixReset?)PreAllocGrp)?.Reset();
				SettlType = null;
				SettlDate = null;
				CashMargin = null;
				ClearingFeeIndicator = null;
				HandlInst = null;
				ExecInst = null;
				MinQty = null;
				MatchIncrement = null;
				MaxPriceLevels = null;
				((IFixReset?)DisplayInstruction)?.Reset();
				MaxFloor = null;
				ExDestination = null;
				ExDestinationIDSource = null;
				((IFixReset?)TrdgSesGrp)?.Reset();
				ProcessCode = null;
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				PrevClosePx = null;
				Side = null;
				ShortMarkingExemptIndicator = null;
				ShortSaleExemptionReason = null;
				SideValueInd = null;
				LocateReqd = null;
				TransactTime = null;
				((IFixReset?)Stipulations)?.Reset();
				QtyType = null;
				((IFixReset?)OrderQtyData)?.Reset();
				OrdType = null;
				PriceType = null;
				Price = null;
				PriceProtectionScope = null;
				StopPx = null;
				((IFixReset?)TriggeringInstruction)?.Reset();
				((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
				((IFixReset?)YieldData)?.Reset();
				Currency = null;
				CurrencyCodeSource = null;
				ComplianceID = null;
				ComplianceText = null;
				EncodedComplianceTextLen = null;
				EncodedComplianceText = null;
				SolicitedFlag = null;
				IOIID = null;
				QuoteID = null;
				RefOrderID = null;
				RefOrderIDSource = null;
				TimeInForce = null;
				EffectiveTime = null;
				ExpireDate = null;
				ExpireTime = null;
				GTBookingInst = null;
				ExposureDuration = null;
				ExposureDurationUnit = null;
				((IFixReset?)CommissionData)?.Reset();
				((IFixReset?)CommissionDataGrp)?.Reset();
				OrderCapacity = null;
				OrderRestrictions = null;
				PreTradeAnonymity = null;
				CustOrderCapacity = null;
				((IFixReset?)OrderAttributeGrp)?.Reset();
				ForexReq = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				BookingType = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
				SettlDate2 = null;
				OrderQty2 = null;
				Price2 = null;
				PositionEffect = null;
				CoveredOrUncovered = null;
				MaxShow = null;
				((IFixReset?)PegInstructions)?.Reset();
				((IFixReset?)DiscretionInstructions)?.Reset();
				TargetStrategy = null;
				((IFixReset?)StrategyParametersGrp)?.Reset();
				TargetStrategyParameters = null;
				ParticipationRate = null;
				Designation = null;
				ManualOrderIndicator = null;
			}
		}
		[Group(NoOfTag = 73, Offset = 0, Required = false)]
		public NoOrders[]? Orders {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Orders is not null && Orders.Length != 0)
			{
				writer.WriteWholeNumber(73, Orders.Length);
				for (int i = 0; i < Orders.Length; i++)
				{
					((IFixEncoder)Orders[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOrders") is IMessageView viewNoOrders)
			{
				var count = viewNoOrders.GroupCount();
				Orders = new NoOrders[count];
				for (int i = 0; i < count; i++)
				{
					Orders[i] = new();
					((IFixParser)Orders[i]).Parse(viewNoOrders.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOrders":
				{
					value = Orders;
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
			Orders = null;
		}
	}
}
