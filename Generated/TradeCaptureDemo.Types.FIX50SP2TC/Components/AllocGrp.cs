using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AllocGrp : IFixComponent
	{
		public sealed partial class NoAllocs : IFixGroup
		{
			[TagDetails(Tag = 79, Type = TagType.String, Offset = 0, Required = false)]
			public string? AllocAccount {get; set;}
			
			[TagDetails(Tag = 661, Type = TagType.Int, Offset = 1, Required = false)]
			public int? AllocAcctIDSource {get; set;}
			
			[TagDetails(Tag = 573, Type = TagType.String, Offset = 2, Required = false)]
			public string? MatchStatus {get; set;}
			
			[TagDetails(Tag = 366, Type = TagType.Float, Offset = 3, Required = false)]
			public double? AllocPrice {get; set;}
			
			[TagDetails(Tag = 80, Type = TagType.Float, Offset = 4, Required = false)]
			public double? AllocQty {get; set;}
			
			[TagDetails(Tag = 2515, Type = TagType.Float, Offset = 5, Required = false)]
			public double? AllocCalculatedCcyQty {get; set;}
			
			[TagDetails(Tag = 1752, Type = TagType.String, Offset = 6, Required = false)]
			public string? CustodialLotID {get; set;}
			
			[TagDetails(Tag = 1753, Type = TagType.LocalDate, Offset = 7, Required = false)]
			public DateOnly? VersusPurchaseDate {get; set;}
			
			[TagDetails(Tag = 1754, Type = TagType.Float, Offset = 8, Required = false)]
			public double? VersusPurchasePrice {get; set;}
			
			[TagDetails(Tag = 1755, Type = TagType.Float, Offset = 9, Required = false)]
			public double? CurrentCostBasis {get; set;}
			
			[TagDetails(Tag = 467, Type = TagType.String, Offset = 10, Required = false)]
			public string? IndividualAllocID {get; set;}
			
			[TagDetails(Tag = 1729, Type = TagType.String, Offset = 11, Required = false)]
			public string? FirmMnemonic {get; set;}
			
			[TagDetails(Tag = 1593, Type = TagType.String, Offset = 12, Required = false)]
			public string? ParentAllocID {get; set;}
			
			[TagDetails(Tag = 2727, Type = TagType.String, Offset = 13, Required = false)]
			public string? AllocLegRefID {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public AllocRegulatoryTradeIDGrp? AllocRegulatoryTradeIDGrp {get; set;}
			
			[TagDetails(Tag = 81, Type = TagType.String, Offset = 15, Required = false)]
			public string? ProcessCode {get; set;}
			
			[TagDetails(Tag = 989, Type = TagType.String, Offset = 16, Required = false)]
			public string? SecondaryIndividualAllocID {get; set;}
			
			[TagDetails(Tag = 1002, Type = TagType.Int, Offset = 17, Required = false)]
			public int? AllocMethod {get; set;}
			
			[TagDetails(Tag = 1735, Type = TagType.Int, Offset = 18, Required = false)]
			public int? AllocationRollupInstruction {get; set;}
			
			[TagDetails(Tag = 993, Type = TagType.String, Offset = 19, Required = false)]
			public string? AllocCustomerCapacity {get; set;}
			
			[TagDetails(Tag = 1047, Type = TagType.String, Offset = 20, Required = false)]
			public string? AllocPositionEffect {get; set;}
			
			[TagDetails(Tag = 992, Type = TagType.Int, Offset = 21, Required = false)]
			public int? IndividualAllocType {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public NestedParties? NestedParties {get; set;}
			
			[TagDetails(Tag = 208, Type = TagType.Boolean, Offset = 23, Required = false)]
			public bool? NotifyBrokerOfCredit {get; set;}
			
			[TagDetails(Tag = 209, Type = TagType.Int, Offset = 24, Required = false)]
			public int? AllocHandlInst {get; set;}
			
			[TagDetails(Tag = 161, Type = TagType.String, Offset = 25, Required = false)]
			public string? AllocText {get; set;}
			
			[TagDetails(Tag = 360, Type = TagType.Length, Offset = 26, Required = false)]
			public int? EncodedAllocTextLen {get; set;}
			
			[TagDetails(Tag = 361, Type = TagType.RawData, Offset = 27, Required = false)]
			public byte[]? EncodedAllocText {get; set;}
			
			[TagDetails(Tag = 1732, Type = TagType.String, Offset = 28, Required = false)]
			public string? FirmAllocText {get; set;}
			
			[TagDetails(Tag = 1733, Type = TagType.Length, Offset = 29, Required = false)]
			public int? EncodedFirmAllocTextLen {get; set;}
			
			[TagDetails(Tag = 1734, Type = TagType.RawData, Offset = 30, Required = false)]
			public byte[]? EncodedFirmAllocText {get; set;}
			
			[Component(Offset = 31, Required = false)]
			public CommissionData? CommissionData {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public AllocCommissionDataGrp? AllocCommissionDataGrp {get; set;}
			
			[TagDetails(Tag = 153, Type = TagType.Float, Offset = 33, Required = false)]
			public double? AllocAvgPx {get; set;}
			
			[TagDetails(Tag = 154, Type = TagType.Float, Offset = 34, Required = false)]
			public double? AllocNetMoney {get; set;}
			
			[TagDetails(Tag = 119, Type = TagType.Float, Offset = 35, Required = false)]
			public double? SettlCurrAmt {get; set;}
			
			[TagDetails(Tag = 2300, Type = TagType.Float, Offset = 36, Required = false)]
			public double? AllocGrossTradeAmt {get; set;}
			
			[TagDetails(Tag = 737, Type = TagType.Float, Offset = 37, Required = false)]
			public double? AllocSettlCurrAmt {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 38, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 736, Type = TagType.String, Offset = 39, Required = false)]
			public string? AllocSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2927, Type = TagType.String, Offset = 40, Required = false)]
			public string? AllocSettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 155, Type = TagType.Float, Offset = 41, Required = false)]
			public double? SettlCurrFxRate {get; set;}
			
			[TagDetails(Tag = 156, Type = TagType.String, Offset = 42, Required = false)]
			public string? SettlCurrFxRateCalc {get; set;}
			
			[TagDetails(Tag = 742, Type = TagType.Float, Offset = 43, Required = false)]
			public double? AllocAccruedInterestAmt {get; set;}
			
			[TagDetails(Tag = 741, Type = TagType.Float, Offset = 44, Required = false)]
			public double? AllocInterestAtMaturity {get; set;}
			
			[Component(Offset = 45, Required = false)]
			public MiscFeesGrp? MiscFeesGrp {get; set;}
			
			[Component(Offset = 46, Required = false)]
			public ClrInstGrp? ClrInstGrp {get; set;}
			
			[TagDetails(Tag = 635, Type = TagType.String, Offset = 47, Required = false)]
			public string? ClearingFeeIndicator {get; set;}
			
			[TagDetails(Tag = 780, Type = TagType.Int, Offset = 48, Required = false)]
			public int? AllocSettlInstType {get; set;}
			
			[Component(Offset = 49, Required = false)]
			public SettlInstructionsData? SettlInstructionsData {get; set;}
			
			[TagDetails(Tag = 2392, Type = TagType.String, Offset = 50, Required = false)]
			public string? AllocRefRiskLimitCheckID {get; set;}
			
			[TagDetails(Tag = 2393, Type = TagType.Int, Offset = 51, Required = false)]
			public int? AllocRefRiskLimitCheckIDType {get; set;}
			
			[TagDetails(Tag = 2483, Type = TagType.Int, Offset = 52, Required = false)]
			public int? AllocRiskLimitCheckStatus {get; set;}
			
			[TagDetails(Tag = 2761, Type = TagType.Float, Offset = 53, Required = false)]
			public double? AllocGroupAmount {get; set;}
			
			[TagDetails(Tag = 2770, Type = TagType.String, Offset = 54, Required = false)]
			public string? AllocAvgPxGroupID {get; set;}
			
			[TagDetails(Tag = 2769, Type = TagType.Int, Offset = 55, Required = false)]
			public int? AllocAvgPxIndicator {get; set;}
			
			[Component(Offset = 56, Required = false)]
			public TradeAllocAmtGrp? TradeAllocAmtGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
				if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
				if (MatchStatus is not null) writer.WriteString(573, MatchStatus);
				if (AllocPrice is not null) writer.WriteNumber(366, AllocPrice.Value);
				if (AllocQty is not null) writer.WriteNumber(80, AllocQty.Value);
				if (AllocCalculatedCcyQty is not null) writer.WriteNumber(2515, AllocCalculatedCcyQty.Value);
				if (CustodialLotID is not null) writer.WriteString(1752, CustodialLotID);
				if (VersusPurchaseDate is not null) writer.WriteLocalDateOnly(1753, VersusPurchaseDate.Value);
				if (VersusPurchasePrice is not null) writer.WriteNumber(1754, VersusPurchasePrice.Value);
				if (CurrentCostBasis is not null) writer.WriteNumber(1755, CurrentCostBasis.Value);
				if (IndividualAllocID is not null) writer.WriteString(467, IndividualAllocID);
				if (FirmMnemonic is not null) writer.WriteString(1729, FirmMnemonic);
				if (ParentAllocID is not null) writer.WriteString(1593, ParentAllocID);
				if (AllocLegRefID is not null) writer.WriteString(2727, AllocLegRefID);
				if (AllocRegulatoryTradeIDGrp is not null) ((IFixEncoder)AllocRegulatoryTradeIDGrp).Encode(writer);
				if (ProcessCode is not null) writer.WriteString(81, ProcessCode);
				if (SecondaryIndividualAllocID is not null) writer.WriteString(989, SecondaryIndividualAllocID);
				if (AllocMethod is not null) writer.WriteWholeNumber(1002, AllocMethod.Value);
				if (AllocationRollupInstruction is not null) writer.WriteWholeNumber(1735, AllocationRollupInstruction.Value);
				if (AllocCustomerCapacity is not null) writer.WriteString(993, AllocCustomerCapacity);
				if (AllocPositionEffect is not null) writer.WriteString(1047, AllocPositionEffect);
				if (IndividualAllocType is not null) writer.WriteWholeNumber(992, IndividualAllocType.Value);
				if (NestedParties is not null) ((IFixEncoder)NestedParties).Encode(writer);
				if (NotifyBrokerOfCredit is not null) writer.WriteBoolean(208, NotifyBrokerOfCredit.Value);
				if (AllocHandlInst is not null) writer.WriteWholeNumber(209, AllocHandlInst.Value);
				if (AllocText is not null) writer.WriteString(161, AllocText);
				if (EncodedAllocTextLen is not null) writer.WriteWholeNumber(360, EncodedAllocTextLen.Value);
				if (EncodedAllocText is not null) writer.WriteBuffer(361, EncodedAllocText);
				if (FirmAllocText is not null) writer.WriteString(1732, FirmAllocText);
				if (EncodedFirmAllocTextLen is not null) writer.WriteWholeNumber(1733, EncodedFirmAllocTextLen.Value);
				if (EncodedFirmAllocText is not null) writer.WriteBuffer(1734, EncodedFirmAllocText);
				if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
				if (AllocCommissionDataGrp is not null) ((IFixEncoder)AllocCommissionDataGrp).Encode(writer);
				if (AllocAvgPx is not null) writer.WriteNumber(153, AllocAvgPx.Value);
				if (AllocNetMoney is not null) writer.WriteNumber(154, AllocNetMoney.Value);
				if (SettlCurrAmt is not null) writer.WriteNumber(119, SettlCurrAmt.Value);
				if (AllocGrossTradeAmt is not null) writer.WriteNumber(2300, AllocGrossTradeAmt.Value);
				if (AllocSettlCurrAmt is not null) writer.WriteNumber(737, AllocSettlCurrAmt.Value);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (AllocSettlCurrency is not null) writer.WriteString(736, AllocSettlCurrency);
				if (AllocSettlCurrencyCodeSource is not null) writer.WriteString(2927, AllocSettlCurrencyCodeSource);
				if (SettlCurrFxRate is not null) writer.WriteNumber(155, SettlCurrFxRate.Value);
				if (SettlCurrFxRateCalc is not null) writer.WriteString(156, SettlCurrFxRateCalc);
				if (AllocAccruedInterestAmt is not null) writer.WriteNumber(742, AllocAccruedInterestAmt.Value);
				if (AllocInterestAtMaturity is not null) writer.WriteNumber(741, AllocInterestAtMaturity.Value);
				if (MiscFeesGrp is not null) ((IFixEncoder)MiscFeesGrp).Encode(writer);
				if (ClrInstGrp is not null) ((IFixEncoder)ClrInstGrp).Encode(writer);
				if (ClearingFeeIndicator is not null) writer.WriteString(635, ClearingFeeIndicator);
				if (AllocSettlInstType is not null) writer.WriteWholeNumber(780, AllocSettlInstType.Value);
				if (SettlInstructionsData is not null) ((IFixEncoder)SettlInstructionsData).Encode(writer);
				if (AllocRefRiskLimitCheckID is not null) writer.WriteString(2392, AllocRefRiskLimitCheckID);
				if (AllocRefRiskLimitCheckIDType is not null) writer.WriteWholeNumber(2393, AllocRefRiskLimitCheckIDType.Value);
				if (AllocRiskLimitCheckStatus is not null) writer.WriteWholeNumber(2483, AllocRiskLimitCheckStatus.Value);
				if (AllocGroupAmount is not null) writer.WriteNumber(2761, AllocGroupAmount.Value);
				if (AllocAvgPxGroupID is not null) writer.WriteString(2770, AllocAvgPxGroupID);
				if (AllocAvgPxIndicator is not null) writer.WriteWholeNumber(2769, AllocAvgPxIndicator.Value);
				if (TradeAllocAmtGrp is not null) ((IFixEncoder)TradeAllocAmtGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocAccount = view.GetString(79);
				AllocAcctIDSource = view.GetInt32(661);
				MatchStatus = view.GetString(573);
				AllocPrice = view.GetDouble(366);
				AllocQty = view.GetDouble(80);
				AllocCalculatedCcyQty = view.GetDouble(2515);
				CustodialLotID = view.GetString(1752);
				VersusPurchaseDate = view.GetDateOnly(1753);
				VersusPurchasePrice = view.GetDouble(1754);
				CurrentCostBasis = view.GetDouble(1755);
				IndividualAllocID = view.GetString(467);
				FirmMnemonic = view.GetString(1729);
				ParentAllocID = view.GetString(1593);
				AllocLegRefID = view.GetString(2727);
				if (view.GetView("AllocRegulatoryTradeIDGrp") is IMessageView viewAllocRegulatoryTradeIDGrp)
				{
					AllocRegulatoryTradeIDGrp = new();
					((IFixParser)AllocRegulatoryTradeIDGrp).Parse(viewAllocRegulatoryTradeIDGrp);
				}
				ProcessCode = view.GetString(81);
				SecondaryIndividualAllocID = view.GetString(989);
				AllocMethod = view.GetInt32(1002);
				AllocationRollupInstruction = view.GetInt32(1735);
				AllocCustomerCapacity = view.GetString(993);
				AllocPositionEffect = view.GetString(1047);
				IndividualAllocType = view.GetInt32(992);
				if (view.GetView("NestedParties") is IMessageView viewNestedParties)
				{
					NestedParties = new();
					((IFixParser)NestedParties).Parse(viewNestedParties);
				}
				NotifyBrokerOfCredit = view.GetBool(208);
				AllocHandlInst = view.GetInt32(209);
				AllocText = view.GetString(161);
				EncodedAllocTextLen = view.GetInt32(360);
				EncodedAllocText = view.GetByteArray(361);
				FirmAllocText = view.GetString(1732);
				EncodedFirmAllocTextLen = view.GetInt32(1733);
				EncodedFirmAllocText = view.GetByteArray(1734);
				if (view.GetView("CommissionData") is IMessageView viewCommissionData)
				{
					CommissionData = new();
					((IFixParser)CommissionData).Parse(viewCommissionData);
				}
				if (view.GetView("AllocCommissionDataGrp") is IMessageView viewAllocCommissionDataGrp)
				{
					AllocCommissionDataGrp = new();
					((IFixParser)AllocCommissionDataGrp).Parse(viewAllocCommissionDataGrp);
				}
				AllocAvgPx = view.GetDouble(153);
				AllocNetMoney = view.GetDouble(154);
				SettlCurrAmt = view.GetDouble(119);
				AllocGrossTradeAmt = view.GetDouble(2300);
				AllocSettlCurrAmt = view.GetDouble(737);
				SettlCurrency = view.GetString(120);
				AllocSettlCurrency = view.GetString(736);
				AllocSettlCurrencyCodeSource = view.GetString(2927);
				SettlCurrFxRate = view.GetDouble(155);
				SettlCurrFxRateCalc = view.GetString(156);
				AllocAccruedInterestAmt = view.GetDouble(742);
				AllocInterestAtMaturity = view.GetDouble(741);
				if (view.GetView("MiscFeesGrp") is IMessageView viewMiscFeesGrp)
				{
					MiscFeesGrp = new();
					((IFixParser)MiscFeesGrp).Parse(viewMiscFeesGrp);
				}
				if (view.GetView("ClrInstGrp") is IMessageView viewClrInstGrp)
				{
					ClrInstGrp = new();
					((IFixParser)ClrInstGrp).Parse(viewClrInstGrp);
				}
				ClearingFeeIndicator = view.GetString(635);
				AllocSettlInstType = view.GetInt32(780);
				if (view.GetView("SettlInstructionsData") is IMessageView viewSettlInstructionsData)
				{
					SettlInstructionsData = new();
					((IFixParser)SettlInstructionsData).Parse(viewSettlInstructionsData);
				}
				AllocRefRiskLimitCheckID = view.GetString(2392);
				AllocRefRiskLimitCheckIDType = view.GetInt32(2393);
				AllocRiskLimitCheckStatus = view.GetInt32(2483);
				AllocGroupAmount = view.GetDouble(2761);
				AllocAvgPxGroupID = view.GetString(2770);
				AllocAvgPxIndicator = view.GetInt32(2769);
				if (view.GetView("TradeAllocAmtGrp") is IMessageView viewTradeAllocAmtGrp)
				{
					TradeAllocAmtGrp = new();
					((IFixParser)TradeAllocAmtGrp).Parse(viewTradeAllocAmtGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
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
					case "MatchStatus":
					{
						value = MatchStatus;
						break;
					}
					case "AllocPrice":
					{
						value = AllocPrice;
						break;
					}
					case "AllocQty":
					{
						value = AllocQty;
						break;
					}
					case "AllocCalculatedCcyQty":
					{
						value = AllocCalculatedCcyQty;
						break;
					}
					case "CustodialLotID":
					{
						value = CustodialLotID;
						break;
					}
					case "VersusPurchaseDate":
					{
						value = VersusPurchaseDate;
						break;
					}
					case "VersusPurchasePrice":
					{
						value = VersusPurchasePrice;
						break;
					}
					case "CurrentCostBasis":
					{
						value = CurrentCostBasis;
						break;
					}
					case "IndividualAllocID":
					{
						value = IndividualAllocID;
						break;
					}
					case "FirmMnemonic":
					{
						value = FirmMnemonic;
						break;
					}
					case "ParentAllocID":
					{
						value = ParentAllocID;
						break;
					}
					case "AllocLegRefID":
					{
						value = AllocLegRefID;
						break;
					}
					case "AllocRegulatoryTradeIDGrp":
					{
						value = AllocRegulatoryTradeIDGrp;
						break;
					}
					case "ProcessCode":
					{
						value = ProcessCode;
						break;
					}
					case "SecondaryIndividualAllocID":
					{
						value = SecondaryIndividualAllocID;
						break;
					}
					case "AllocMethod":
					{
						value = AllocMethod;
						break;
					}
					case "AllocationRollupInstruction":
					{
						value = AllocationRollupInstruction;
						break;
					}
					case "AllocCustomerCapacity":
					{
						value = AllocCustomerCapacity;
						break;
					}
					case "AllocPositionEffect":
					{
						value = AllocPositionEffect;
						break;
					}
					case "IndividualAllocType":
					{
						value = IndividualAllocType;
						break;
					}
					case "NestedParties":
					{
						value = NestedParties;
						break;
					}
					case "NotifyBrokerOfCredit":
					{
						value = NotifyBrokerOfCredit;
						break;
					}
					case "AllocHandlInst":
					{
						value = AllocHandlInst;
						break;
					}
					case "AllocText":
					{
						value = AllocText;
						break;
					}
					case "EncodedAllocTextLen":
					{
						value = EncodedAllocTextLen;
						break;
					}
					case "EncodedAllocText":
					{
						value = EncodedAllocText;
						break;
					}
					case "FirmAllocText":
					{
						value = FirmAllocText;
						break;
					}
					case "EncodedFirmAllocTextLen":
					{
						value = EncodedFirmAllocTextLen;
						break;
					}
					case "EncodedFirmAllocText":
					{
						value = EncodedFirmAllocText;
						break;
					}
					case "CommissionData":
					{
						value = CommissionData;
						break;
					}
					case "AllocCommissionDataGrp":
					{
						value = AllocCommissionDataGrp;
						break;
					}
					case "AllocAvgPx":
					{
						value = AllocAvgPx;
						break;
					}
					case "AllocNetMoney":
					{
						value = AllocNetMoney;
						break;
					}
					case "SettlCurrAmt":
					{
						value = SettlCurrAmt;
						break;
					}
					case "AllocGrossTradeAmt":
					{
						value = AllocGrossTradeAmt;
						break;
					}
					case "AllocSettlCurrAmt":
					{
						value = AllocSettlCurrAmt;
						break;
					}
					case "SettlCurrency":
					{
						value = SettlCurrency;
						break;
					}
					case "AllocSettlCurrency":
					{
						value = AllocSettlCurrency;
						break;
					}
					case "AllocSettlCurrencyCodeSource":
					{
						value = AllocSettlCurrencyCodeSource;
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
					case "AllocAccruedInterestAmt":
					{
						value = AllocAccruedInterestAmt;
						break;
					}
					case "AllocInterestAtMaturity":
					{
						value = AllocInterestAtMaturity;
						break;
					}
					case "MiscFeesGrp":
					{
						value = MiscFeesGrp;
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
					case "AllocSettlInstType":
					{
						value = AllocSettlInstType;
						break;
					}
					case "SettlInstructionsData":
					{
						value = SettlInstructionsData;
						break;
					}
					case "AllocRefRiskLimitCheckID":
					{
						value = AllocRefRiskLimitCheckID;
						break;
					}
					case "AllocRefRiskLimitCheckIDType":
					{
						value = AllocRefRiskLimitCheckIDType;
						break;
					}
					case "AllocRiskLimitCheckStatus":
					{
						value = AllocRiskLimitCheckStatus;
						break;
					}
					case "AllocGroupAmount":
					{
						value = AllocGroupAmount;
						break;
					}
					case "AllocAvgPxGroupID":
					{
						value = AllocAvgPxGroupID;
						break;
					}
					case "AllocAvgPxIndicator":
					{
						value = AllocAvgPxIndicator;
						break;
					}
					case "TradeAllocAmtGrp":
					{
						value = TradeAllocAmtGrp;
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
				AllocAccount = null;
				AllocAcctIDSource = null;
				MatchStatus = null;
				AllocPrice = null;
				AllocQty = null;
				AllocCalculatedCcyQty = null;
				CustodialLotID = null;
				VersusPurchaseDate = null;
				VersusPurchasePrice = null;
				CurrentCostBasis = null;
				IndividualAllocID = null;
				FirmMnemonic = null;
				ParentAllocID = null;
				AllocLegRefID = null;
				((IFixReset?)AllocRegulatoryTradeIDGrp)?.Reset();
				ProcessCode = null;
				SecondaryIndividualAllocID = null;
				AllocMethod = null;
				AllocationRollupInstruction = null;
				AllocCustomerCapacity = null;
				AllocPositionEffect = null;
				IndividualAllocType = null;
				((IFixReset?)NestedParties)?.Reset();
				NotifyBrokerOfCredit = null;
				AllocHandlInst = null;
				AllocText = null;
				EncodedAllocTextLen = null;
				EncodedAllocText = null;
				FirmAllocText = null;
				EncodedFirmAllocTextLen = null;
				EncodedFirmAllocText = null;
				((IFixReset?)CommissionData)?.Reset();
				((IFixReset?)AllocCommissionDataGrp)?.Reset();
				AllocAvgPx = null;
				AllocNetMoney = null;
				SettlCurrAmt = null;
				AllocGrossTradeAmt = null;
				AllocSettlCurrAmt = null;
				SettlCurrency = null;
				AllocSettlCurrency = null;
				AllocSettlCurrencyCodeSource = null;
				SettlCurrFxRate = null;
				SettlCurrFxRateCalc = null;
				AllocAccruedInterestAmt = null;
				AllocInterestAtMaturity = null;
				((IFixReset?)MiscFeesGrp)?.Reset();
				((IFixReset?)ClrInstGrp)?.Reset();
				ClearingFeeIndicator = null;
				AllocSettlInstType = null;
				((IFixReset?)SettlInstructionsData)?.Reset();
				AllocRefRiskLimitCheckID = null;
				AllocRefRiskLimitCheckIDType = null;
				AllocRiskLimitCheckStatus = null;
				AllocGroupAmount = null;
				AllocAvgPxGroupID = null;
				AllocAvgPxIndicator = null;
				((IFixReset?)TradeAllocAmtGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 78, Offset = 0, Required = false)]
		public NoAllocs[]? Allocs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Allocs is not null && Allocs.Length != 0)
			{
				writer.WriteWholeNumber(78, Allocs.Length);
				for (int i = 0; i < Allocs.Length; i++)
				{
					((IFixEncoder)Allocs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAllocs") is IMessageView viewNoAllocs)
			{
				var count = viewNoAllocs.GroupCount();
				Allocs = new NoAllocs[count];
				for (int i = 0; i < count; i++)
				{
					Allocs[i] = new();
					((IFixParser)Allocs[i]).Parse(viewNoAllocs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAllocs":
				{
					value = Allocs;
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
			Allocs = null;
		}
	}
}
