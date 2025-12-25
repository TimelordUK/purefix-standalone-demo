using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("t", FixVersion.FIX50SP2)]
	public sealed partial class CrossOrderCancelReplaceRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 1, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 2422, Type = TagType.Int, Offset = 2, Required = false)]
		public int? OrderRequestID {get; set;}
		
		[TagDetails(Tag = 548, Type = TagType.String, Offset = 3, Required = true)]
		public string? CrossID {get; set;}
		
		[TagDetails(Tag = 551, Type = TagType.String, Offset = 4, Required = true)]
		public string? OrigCrossID {get; set;}
		
		[TagDetails(Tag = 961, Type = TagType.String, Offset = 5, Required = false)]
		public string? HostCrossID {get; set;}
		
		[TagDetails(Tag = 549, Type = TagType.Int, Offset = 6, Required = true)]
		public int? CrossType {get; set;}
		
		[TagDetails(Tag = 550, Type = TagType.Int, Offset = 7, Required = true)]
		public int? CrossPrioritization {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public RootParties? RootParties {get; set;}
		
		[Component(Offset = 9, Required = true)]
		public SideCrossOrdModGrp? SideCrossOrdModGrp {get; set;}
		
		[Component(Offset = 10, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 63, Type = TagType.String, Offset = 13, Required = false)]
		public string? SettlType {get; set;}
		
		[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? SettlDate {get; set;}
		
		[TagDetails(Tag = 21, Type = TagType.String, Offset = 15, Required = false)]
		public string? HandlInst {get; set;}
		
		[TagDetails(Tag = 18, Type = TagType.String, Offset = 16, Required = false)]
		public string? ExecInst {get; set;}
		
		[TagDetails(Tag = 110, Type = TagType.Float, Offset = 17, Required = false)]
		public double? MinQty {get; set;}
		
		[TagDetails(Tag = 1822, Type = TagType.Int, Offset = 18, Required = false)]
		public int? MinQtyMethod {get; set;}
		
		[TagDetails(Tag = 1089, Type = TagType.Float, Offset = 19, Required = false)]
		public double? MatchIncrement {get; set;}
		
		[TagDetails(Tag = 1090, Type = TagType.Int, Offset = 20, Required = false)]
		public int? MaxPriceLevels {get; set;}
		
		[Component(Offset = 21, Required = false)]
		public DisplayInstruction? DisplayInstruction {get; set;}
		
		[TagDetails(Tag = 111, Type = TagType.Float, Offset = 22, Required = false)]
		public double? MaxFloor {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 23, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 100, Type = TagType.String, Offset = 24, Required = false)]
		public string? ExDestination {get; set;}
		
		[TagDetails(Tag = 1133, Type = TagType.String, Offset = 25, Required = false)]
		public string? ExDestinationIDSource {get; set;}
		
		[Component(Offset = 26, Required = false)]
		public TrdgSesGrp? TrdgSesGrp {get; set;}
		
		[TagDetails(Tag = 81, Type = TagType.String, Offset = 27, Required = false)]
		public string? ProcessCode {get; set;}
		
		[TagDetails(Tag = 140, Type = TagType.Float, Offset = 28, Required = false)]
		public double? PrevClosePx {get; set;}
		
		[TagDetails(Tag = 114, Type = TagType.Boolean, Offset = 29, Required = false)]
		public bool? LocateReqd {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 30, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 483, Type = TagType.UtcTimestamp, Offset = 31, Required = false)]
		public DateTime? TransBkdTime {get; set;}
		
		[Component(Offset = 32, Required = false)]
		public Stipulations? Stipulations {get; set;}
		
		[TagDetails(Tag = 40, Type = TagType.String, Offset = 33, Required = true)]
		public string? OrdType {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 34, Required = false)]
		public int? PriceType {get; set;}
		
		[TagDetails(Tag = 44, Type = TagType.Float, Offset = 35, Required = false)]
		public double? Price {get; set;}
		
		[TagDetails(Tag = 1092, Type = TagType.String, Offset = 36, Required = false)]
		public string? PriceProtectionScope {get; set;}
		
		[TagDetails(Tag = 99, Type = TagType.Float, Offset = 37, Required = false)]
		public double? StopPx {get; set;}
		
		[Component(Offset = 38, Required = false)]
		public TriggeringInstruction? TriggeringInstruction {get; set;}
		
		[Component(Offset = 39, Required = false)]
		public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
		
		[Component(Offset = 40, Required = false)]
		public YieldData? YieldData {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 41, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 42, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 376, Type = TagType.String, Offset = 43, Required = false)]
		public string? ComplianceID {get; set;}
		
		[TagDetails(Tag = 23, Type = TagType.String, Offset = 44, Required = false)]
		public string? IOIID {get; set;}
		
		[TagDetails(Tag = 117, Type = TagType.String, Offset = 45, Required = false)]
		public string? QuoteID {get; set;}
		
		[TagDetails(Tag = 59, Type = TagType.String, Offset = 46, Required = false)]
		public string? TimeInForce {get; set;}
		
		[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 47, Required = false)]
		public DateTime? EffectiveTime {get; set;}
		
		[TagDetails(Tag = 432, Type = TagType.LocalDate, Offset = 48, Required = false)]
		public DateOnly? ExpireDate {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 49, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[TagDetails(Tag = 427, Type = TagType.Int, Offset = 50, Required = false)]
		public int? GTBookingInst {get; set;}
		
		[TagDetails(Tag = 1629, Type = TagType.Int, Offset = 51, Required = false)]
		public int? ExposureDuration {get; set;}
		
		[TagDetails(Tag = 1916, Type = TagType.Int, Offset = 52, Required = false)]
		public int? ExposureDurationUnit {get; set;}
		
		[TagDetails(Tag = 1815, Type = TagType.Int, Offset = 53, Required = false)]
		public int? TradingCapacity {get; set;}
		
		[TagDetails(Tag = 210, Type = TagType.Float, Offset = 54, Required = false)]
		public double? MaxShow {get; set;}
		
		[Component(Offset = 55, Required = false)]
		public PegInstructions? PegInstructions {get; set;}
		
		[Component(Offset = 56, Required = false)]
		public DiscretionInstructions? DiscretionInstructions {get; set;}
		
		[TagDetails(Tag = 847, Type = TagType.Int, Offset = 57, Required = false)]
		public int? TargetStrategy {get; set;}
		
		[Component(Offset = 58, Required = false)]
		public StrategyParametersGrp? StrategyParametersGrp {get; set;}
		
		[TagDetails(Tag = 848, Type = TagType.String, Offset = 59, Required = false)]
		public string? TargetStrategyParameters {get; set;}
		
		[TagDetails(Tag = 849, Type = TagType.Float, Offset = 60, Required = false)]
		public double? ParticipationRate {get; set;}
		
		[TagDetails(Tag = 480, Type = TagType.String, Offset = 61, Required = false)]
		public string? CancellationRights {get; set;}
		
		[TagDetails(Tag = 481, Type = TagType.String, Offset = 62, Required = false)]
		public string? MoneyLaunderingStatus {get; set;}
		
		[TagDetails(Tag = 513, Type = TagType.String, Offset = 63, Required = false)]
		public string? RegistID {get; set;}
		
		[TagDetails(Tag = 494, Type = TagType.String, Offset = 64, Required = false)]
		public string? Designation {get; set;}
		
		[TagDetails(Tag = 1685, Type = TagType.Int, Offset = 65, Required = false)]
		public int? ThrottleInst {get; set;}
		
		[Component(Offset = 66, Required = true)]
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
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (OrderRequestID is not null) writer.WriteWholeNumber(2422, OrderRequestID.Value);
			if (CrossID is not null) writer.WriteString(548, CrossID);
			if (OrigCrossID is not null) writer.WriteString(551, OrigCrossID);
			if (HostCrossID is not null) writer.WriteString(961, HostCrossID);
			if (CrossType is not null) writer.WriteWholeNumber(549, CrossType.Value);
			if (CrossPrioritization is not null) writer.WriteWholeNumber(550, CrossPrioritization.Value);
			if (RootParties is not null) ((IFixEncoder)RootParties).Encode(writer);
			if (SideCrossOrdModGrp is not null) ((IFixEncoder)SideCrossOrdModGrp).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (SettlType is not null) writer.WriteString(63, SettlType);
			if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
			if (HandlInst is not null) writer.WriteString(21, HandlInst);
			if (ExecInst is not null) writer.WriteString(18, ExecInst);
			if (MinQty is not null) writer.WriteNumber(110, MinQty.Value);
			if (MinQtyMethod is not null) writer.WriteWholeNumber(1822, MinQtyMethod.Value);
			if (MatchIncrement is not null) writer.WriteNumber(1089, MatchIncrement.Value);
			if (MaxPriceLevels is not null) writer.WriteWholeNumber(1090, MaxPriceLevels.Value);
			if (DisplayInstruction is not null) ((IFixEncoder)DisplayInstruction).Encode(writer);
			if (MaxFloor is not null) writer.WriteNumber(111, MaxFloor.Value);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (ExDestination is not null) writer.WriteString(100, ExDestination);
			if (ExDestinationIDSource is not null) writer.WriteString(1133, ExDestinationIDSource);
			if (TrdgSesGrp is not null) ((IFixEncoder)TrdgSesGrp).Encode(writer);
			if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
			if (PrevClosePx is not null) writer.WriteNumber(140, PrevClosePx.Value);
			if (LocateReqd is not null) writer.WriteBoolean(114, LocateReqd.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (TransBkdTime is not null) writer.WriteUtcTimeStamp(483, TransBkdTime.Value);
			if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
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
			if (IOIID is not null) writer.WriteString(23, IOIID);
			if (QuoteID is not null) writer.WriteString(117, QuoteID);
			if (TimeInForce is not null) writer.WriteString(59, TimeInForce);
			if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
			if (ExpireDate is not null) writer.WriteLocalDateOnly(432, ExpireDate.Value);
			if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
			if (GTBookingInst is not null) writer.WriteWholeNumber(427, GTBookingInst.Value);
			if (ExposureDuration is not null) writer.WriteWholeNumber(1629, ExposureDuration.Value);
			if (ExposureDurationUnit is not null) writer.WriteWholeNumber(1916, ExposureDurationUnit.Value);
			if (TradingCapacity is not null) writer.WriteWholeNumber(1815, TradingCapacity.Value);
			if (MaxShow is not null) writer.WriteNumber(210, MaxShow.Value);
			if (PegInstructions is not null) ((IFixEncoder)PegInstructions).Encode(writer);
			if (DiscretionInstructions is not null) ((IFixEncoder)DiscretionInstructions).Encode(writer);
			if (TargetStrategy is not null) writer.WriteWholeNumber(847, TargetStrategy.Value);
			if (StrategyParametersGrp is not null) ((IFixEncoder)StrategyParametersGrp).Encode(writer);
			if (TargetStrategyParameters is not null) writer.WriteString(848, TargetStrategyParameters);
			if (ParticipationRate is not null) writer.WriteNumber(849, ParticipationRate.Value);
			if (CancellationRights is not null) writer.WriteString(480, CancellationRights);
			if (MoneyLaunderingStatus is not null) writer.WriteString(481, MoneyLaunderingStatus);
			if (RegistID is not null) writer.WriteString(513, RegistID);
			if (Designation is not null) writer.WriteString(494, Designation);
			if (ThrottleInst is not null) writer.WriteWholeNumber(1685, ThrottleInst.Value);
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
			OrderID = view.GetString(37);
			OrderRequestID = view.GetInt32(2422);
			CrossID = view.GetString(548);
			OrigCrossID = view.GetString(551);
			HostCrossID = view.GetString(961);
			CrossType = view.GetInt32(549);
			CrossPrioritization = view.GetInt32(550);
			if (view.GetView("RootParties") is IMessageView viewRootParties)
			{
				RootParties = new();
				((IFixParser)RootParties).Parse(viewRootParties);
			}
			if (view.GetView("SideCrossOrdModGrp") is IMessageView viewSideCrossOrdModGrp)
			{
				SideCrossOrdModGrp = new();
				((IFixParser)SideCrossOrdModGrp).Parse(viewSideCrossOrdModGrp);
			}
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
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			SettlType = view.GetString(63);
			SettlDate = view.GetDateOnly(64);
			HandlInst = view.GetString(21);
			ExecInst = view.GetString(18);
			MinQty = view.GetDouble(110);
			MinQtyMethod = view.GetInt32(1822);
			MatchIncrement = view.GetDouble(1089);
			MaxPriceLevels = view.GetInt32(1090);
			if (view.GetView("DisplayInstruction") is IMessageView viewDisplayInstruction)
			{
				DisplayInstruction = new();
				((IFixParser)DisplayInstruction).Parse(viewDisplayInstruction);
			}
			MaxFloor = view.GetDouble(111);
			MarketSegmentID = view.GetString(1300);
			ExDestination = view.GetString(100);
			ExDestinationIDSource = view.GetString(1133);
			if (view.GetView("TrdgSesGrp") is IMessageView viewTrdgSesGrp)
			{
				TrdgSesGrp = new();
				((IFixParser)TrdgSesGrp).Parse(viewTrdgSesGrp);
			}
			ProcessCode = view.GetString(81);
			PrevClosePx = view.GetDouble(140);
			LocateReqd = view.GetBool(114);
			TransactTime = view.GetDateTime(60);
			TransBkdTime = view.GetDateTime(483);
			if (view.GetView("Stipulations") is IMessageView viewStipulations)
			{
				Stipulations = new();
				((IFixParser)Stipulations).Parse(viewStipulations);
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
			IOIID = view.GetString(23);
			QuoteID = view.GetString(117);
			TimeInForce = view.GetString(59);
			EffectiveTime = view.GetDateTime(168);
			ExpireDate = view.GetDateOnly(432);
			ExpireTime = view.GetDateTime(126);
			GTBookingInst = view.GetInt32(427);
			ExposureDuration = view.GetInt32(1629);
			ExposureDurationUnit = view.GetInt32(1916);
			TradingCapacity = view.GetInt32(1815);
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
			CancellationRights = view.GetString(480);
			MoneyLaunderingStatus = view.GetString(481);
			RegistID = view.GetString(513);
			Designation = view.GetString(494);
			ThrottleInst = view.GetInt32(1685);
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
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "OrderRequestID":
				{
					value = OrderRequestID;
					break;
				}
				case "CrossID":
				{
					value = CrossID;
					break;
				}
				case "OrigCrossID":
				{
					value = OrigCrossID;
					break;
				}
				case "HostCrossID":
				{
					value = HostCrossID;
					break;
				}
				case "CrossType":
				{
					value = CrossType;
					break;
				}
				case "CrossPrioritization":
				{
					value = CrossPrioritization;
					break;
				}
				case "RootParties":
				{
					value = RootParties;
					break;
				}
				case "SideCrossOrdModGrp":
				{
					value = SideCrossOrdModGrp;
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
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
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
				case "MinQtyMethod":
				{
					value = MinQtyMethod;
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
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
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
				case "PrevClosePx":
				{
					value = PrevClosePx;
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
				case "TransBkdTime":
				{
					value = TransBkdTime;
					break;
				}
				case "Stipulations":
				{
					value = Stipulations;
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
				case "TradingCapacity":
				{
					value = TradingCapacity;
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
				case "CancellationRights":
				{
					value = CancellationRights;
					break;
				}
				case "MoneyLaunderingStatus":
				{
					value = MoneyLaunderingStatus;
					break;
				}
				case "RegistID":
				{
					value = RegistID;
					break;
				}
				case "Designation":
				{
					value = Designation;
					break;
				}
				case "ThrottleInst":
				{
					value = ThrottleInst;
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
			OrderID = null;
			OrderRequestID = null;
			CrossID = null;
			OrigCrossID = null;
			HostCrossID = null;
			CrossType = null;
			CrossPrioritization = null;
			((IFixReset?)RootParties)?.Reset();
			((IFixReset?)SideCrossOrdModGrp)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			SettlType = null;
			SettlDate = null;
			HandlInst = null;
			ExecInst = null;
			MinQty = null;
			MinQtyMethod = null;
			MatchIncrement = null;
			MaxPriceLevels = null;
			((IFixReset?)DisplayInstruction)?.Reset();
			MaxFloor = null;
			MarketSegmentID = null;
			ExDestination = null;
			ExDestinationIDSource = null;
			((IFixReset?)TrdgSesGrp)?.Reset();
			ProcessCode = null;
			PrevClosePx = null;
			LocateReqd = null;
			TransactTime = null;
			TransBkdTime = null;
			((IFixReset?)Stipulations)?.Reset();
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
			IOIID = null;
			QuoteID = null;
			TimeInForce = null;
			EffectiveTime = null;
			ExpireDate = null;
			ExpireTime = null;
			GTBookingInst = null;
			ExposureDuration = null;
			ExposureDurationUnit = null;
			TradingCapacity = null;
			MaxShow = null;
			((IFixReset?)PegInstructions)?.Reset();
			((IFixReset?)DiscretionInstructions)?.Reset();
			TargetStrategy = null;
			((IFixReset?)StrategyParametersGrp)?.Reset();
			TargetStrategyParameters = null;
			ParticipationRate = null;
			CancellationRights = null;
			MoneyLaunderingStatus = null;
			RegistID = null;
			Designation = null;
			ThrottleInst = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
