using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdAllocGrp : IFixComponent
	{
		public sealed partial class NoAllocs : IFixGroup
		{
			[TagDetails(Tag = 79, Type = TagType.String, Offset = 0, Required = false)]
			public string? AllocAccount {get; set;}
			
			[TagDetails(Tag = 661, Type = TagType.Int, Offset = 1, Required = false)]
			public int? AllocAcctIDSource {get; set;}
			
			[TagDetails(Tag = 736, Type = TagType.String, Offset = 2, Required = false)]
			public string? AllocSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2927, Type = TagType.String, Offset = 3, Required = false)]
			public string? AllocSettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 467, Type = TagType.String, Offset = 4, Required = false)]
			public string? IndividualAllocID {get; set;}
			
			[TagDetails(Tag = 1593, Type = TagType.String, Offset = 5, Required = false)]
			public string? ParentAllocID {get; set;}
			
			[TagDetails(Tag = 2727, Type = TagType.String, Offset = 6, Required = false)]
			public string? AllocLegRefID {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public AllocRegulatoryTradeIDGrp? AllocRegulatoryTradeIDGrp {get; set;}
			
			[TagDetails(Tag = 1729, Type = TagType.String, Offset = 8, Required = false)]
			public string? FirmMnemonic {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public NestedParties2? NestedParties2 {get; set;}
			
			[TagDetails(Tag = 209, Type = TagType.Int, Offset = 10, Required = false)]
			public int? AllocHandlInst {get; set;}
			
			[TagDetails(Tag = 80, Type = TagType.Float, Offset = 11, Required = false)]
			public double? AllocQty {get; set;}
			
			[TagDetails(Tag = 2515, Type = TagType.Float, Offset = 12, Required = false)]
			public double? AllocCalculatedCcyQty {get; set;}
			
			[TagDetails(Tag = 1752, Type = TagType.String, Offset = 13, Required = false)]
			public string? CustodialLotID {get; set;}
			
			[TagDetails(Tag = 1753, Type = TagType.LocalDate, Offset = 14, Required = false)]
			public DateOnly? VersusPurchaseDate {get; set;}
			
			[TagDetails(Tag = 1754, Type = TagType.Float, Offset = 15, Required = false)]
			public double? VersusPurchasePrice {get; set;}
			
			[TagDetails(Tag = 1755, Type = TagType.Float, Offset = 16, Required = false)]
			public double? CurrentCostBasis {get; set;}
			
			[TagDetails(Tag = 993, Type = TagType.String, Offset = 17, Required = false)]
			public string? AllocCustomerCapacity {get; set;}
			
			[TagDetails(Tag = 1002, Type = TagType.Int, Offset = 18, Required = false)]
			public int? AllocMethod {get; set;}
			
			[TagDetails(Tag = 989, Type = TagType.String, Offset = 19, Required = false)]
			public string? SecondaryIndividualAllocID {get; set;}
			
			[TagDetails(Tag = 1136, Type = TagType.String, Offset = 20, Required = false)]
			public string? AllocClearingFeeIndicator {get; set;}
			
			[Component(Offset = 21, Required = false)]
			public TradeAllocAmtGrp? TradeAllocAmtGrp {get; set;}
			
			[TagDetails(Tag = 1840, Type = TagType.Int, Offset = 22, Required = false)]
			public int? TradeAllocStatus {get; set;}
			
			[TagDetails(Tag = 1735, Type = TagType.Int, Offset = 23, Required = false)]
			public int? AllocationRollupInstruction {get; set;}
			
			[TagDetails(Tag = 161, Type = TagType.String, Offset = 24, Required = false)]
			public string? AllocText {get; set;}
			
			[TagDetails(Tag = 360, Type = TagType.Length, Offset = 25, Required = false)]
			public int? EncodedAllocTextLen {get; set;}
			
			[TagDetails(Tag = 361, Type = TagType.RawData, Offset = 26, Required = false)]
			public byte[]? EncodedAllocText {get; set;}
			
			[TagDetails(Tag = 1732, Type = TagType.String, Offset = 27, Required = false)]
			public string? FirmAllocText {get; set;}
			
			[TagDetails(Tag = 1733, Type = TagType.Length, Offset = 28, Required = false)]
			public int? EncodedFirmAllocTextLen {get; set;}
			
			[TagDetails(Tag = 1734, Type = TagType.RawData, Offset = 29, Required = false)]
			public byte[]? EncodedFirmAllocText {get; set;}
			
			[TagDetails(Tag = 2392, Type = TagType.String, Offset = 30, Required = false)]
			public string? AllocRefRiskLimitCheckID {get; set;}
			
			[TagDetails(Tag = 2393, Type = TagType.Int, Offset = 31, Required = false)]
			public int? AllocRefRiskLimitCheckIDType {get; set;}
			
			[Component(Offset = 32, Required = false)]
			public AllocCommissionDataGrp? AllocCommissionDataGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
				if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
				if (AllocSettlCurrency is not null) writer.WriteString(736, AllocSettlCurrency);
				if (AllocSettlCurrencyCodeSource is not null) writer.WriteString(2927, AllocSettlCurrencyCodeSource);
				if (IndividualAllocID is not null) writer.WriteString(467, IndividualAllocID);
				if (ParentAllocID is not null) writer.WriteString(1593, ParentAllocID);
				if (AllocLegRefID is not null) writer.WriteString(2727, AllocLegRefID);
				if (AllocRegulatoryTradeIDGrp is not null) ((IFixEncoder)AllocRegulatoryTradeIDGrp).Encode(writer);
				if (FirmMnemonic is not null) writer.WriteString(1729, FirmMnemonic);
				if (NestedParties2 is not null) ((IFixEncoder)NestedParties2).Encode(writer);
				if (AllocHandlInst is not null) writer.WriteWholeNumber(209, AllocHandlInst.Value);
				if (AllocQty is not null) writer.WriteNumber(80, AllocQty.Value);
				if (AllocCalculatedCcyQty is not null) writer.WriteNumber(2515, AllocCalculatedCcyQty.Value);
				if (CustodialLotID is not null) writer.WriteString(1752, CustodialLotID);
				if (VersusPurchaseDate is not null) writer.WriteLocalDateOnly(1753, VersusPurchaseDate.Value);
				if (VersusPurchasePrice is not null) writer.WriteNumber(1754, VersusPurchasePrice.Value);
				if (CurrentCostBasis is not null) writer.WriteNumber(1755, CurrentCostBasis.Value);
				if (AllocCustomerCapacity is not null) writer.WriteString(993, AllocCustomerCapacity);
				if (AllocMethod is not null) writer.WriteWholeNumber(1002, AllocMethod.Value);
				if (SecondaryIndividualAllocID is not null) writer.WriteString(989, SecondaryIndividualAllocID);
				if (AllocClearingFeeIndicator is not null) writer.WriteString(1136, AllocClearingFeeIndicator);
				if (TradeAllocAmtGrp is not null) ((IFixEncoder)TradeAllocAmtGrp).Encode(writer);
				if (TradeAllocStatus is not null) writer.WriteWholeNumber(1840, TradeAllocStatus.Value);
				if (AllocationRollupInstruction is not null) writer.WriteWholeNumber(1735, AllocationRollupInstruction.Value);
				if (AllocText is not null) writer.WriteString(161, AllocText);
				if (EncodedAllocTextLen is not null) writer.WriteWholeNumber(360, EncodedAllocTextLen.Value);
				if (EncodedAllocText is not null) writer.WriteBuffer(361, EncodedAllocText);
				if (FirmAllocText is not null) writer.WriteString(1732, FirmAllocText);
				if (EncodedFirmAllocTextLen is not null) writer.WriteWholeNumber(1733, EncodedFirmAllocTextLen.Value);
				if (EncodedFirmAllocText is not null) writer.WriteBuffer(1734, EncodedFirmAllocText);
				if (AllocRefRiskLimitCheckID is not null) writer.WriteString(2392, AllocRefRiskLimitCheckID);
				if (AllocRefRiskLimitCheckIDType is not null) writer.WriteWholeNumber(2393, AllocRefRiskLimitCheckIDType.Value);
				if (AllocCommissionDataGrp is not null) ((IFixEncoder)AllocCommissionDataGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocAccount = view.GetString(79);
				AllocAcctIDSource = view.GetInt32(661);
				AllocSettlCurrency = view.GetString(736);
				AllocSettlCurrencyCodeSource = view.GetString(2927);
				IndividualAllocID = view.GetString(467);
				ParentAllocID = view.GetString(1593);
				AllocLegRefID = view.GetString(2727);
				if (view.GetView("AllocRegulatoryTradeIDGrp") is IMessageView viewAllocRegulatoryTradeIDGrp)
				{
					AllocRegulatoryTradeIDGrp = new();
					((IFixParser)AllocRegulatoryTradeIDGrp).Parse(viewAllocRegulatoryTradeIDGrp);
				}
				FirmMnemonic = view.GetString(1729);
				if (view.GetView("NestedParties2") is IMessageView viewNestedParties2)
				{
					NestedParties2 = new();
					((IFixParser)NestedParties2).Parse(viewNestedParties2);
				}
				AllocHandlInst = view.GetInt32(209);
				AllocQty = view.GetDouble(80);
				AllocCalculatedCcyQty = view.GetDouble(2515);
				CustodialLotID = view.GetString(1752);
				VersusPurchaseDate = view.GetDateOnly(1753);
				VersusPurchasePrice = view.GetDouble(1754);
				CurrentCostBasis = view.GetDouble(1755);
				AllocCustomerCapacity = view.GetString(993);
				AllocMethod = view.GetInt32(1002);
				SecondaryIndividualAllocID = view.GetString(989);
				AllocClearingFeeIndicator = view.GetString(1136);
				if (view.GetView("TradeAllocAmtGrp") is IMessageView viewTradeAllocAmtGrp)
				{
					TradeAllocAmtGrp = new();
					((IFixParser)TradeAllocAmtGrp).Parse(viewTradeAllocAmtGrp);
				}
				TradeAllocStatus = view.GetInt32(1840);
				AllocationRollupInstruction = view.GetInt32(1735);
				AllocText = view.GetString(161);
				EncodedAllocTextLen = view.GetInt32(360);
				EncodedAllocText = view.GetByteArray(361);
				FirmAllocText = view.GetString(1732);
				EncodedFirmAllocTextLen = view.GetInt32(1733);
				EncodedFirmAllocText = view.GetByteArray(1734);
				AllocRefRiskLimitCheckID = view.GetString(2392);
				AllocRefRiskLimitCheckIDType = view.GetInt32(2393);
				if (view.GetView("AllocCommissionDataGrp") is IMessageView viewAllocCommissionDataGrp)
				{
					AllocCommissionDataGrp = new();
					((IFixParser)AllocCommissionDataGrp).Parse(viewAllocCommissionDataGrp);
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
					case "IndividualAllocID":
					{
						value = IndividualAllocID;
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
					case "FirmMnemonic":
					{
						value = FirmMnemonic;
						break;
					}
					case "NestedParties2":
					{
						value = NestedParties2;
						break;
					}
					case "AllocHandlInst":
					{
						value = AllocHandlInst;
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
					case "AllocCustomerCapacity":
					{
						value = AllocCustomerCapacity;
						break;
					}
					case "AllocMethod":
					{
						value = AllocMethod;
						break;
					}
					case "SecondaryIndividualAllocID":
					{
						value = SecondaryIndividualAllocID;
						break;
					}
					case "AllocClearingFeeIndicator":
					{
						value = AllocClearingFeeIndicator;
						break;
					}
					case "TradeAllocAmtGrp":
					{
						value = TradeAllocAmtGrp;
						break;
					}
					case "TradeAllocStatus":
					{
						value = TradeAllocStatus;
						break;
					}
					case "AllocationRollupInstruction":
					{
						value = AllocationRollupInstruction;
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
					case "AllocCommissionDataGrp":
					{
						value = AllocCommissionDataGrp;
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
				AllocSettlCurrency = null;
				AllocSettlCurrencyCodeSource = null;
				IndividualAllocID = null;
				ParentAllocID = null;
				AllocLegRefID = null;
				((IFixReset?)AllocRegulatoryTradeIDGrp)?.Reset();
				FirmMnemonic = null;
				((IFixReset?)NestedParties2)?.Reset();
				AllocHandlInst = null;
				AllocQty = null;
				AllocCalculatedCcyQty = null;
				CustodialLotID = null;
				VersusPurchaseDate = null;
				VersusPurchasePrice = null;
				CurrentCostBasis = null;
				AllocCustomerCapacity = null;
				AllocMethod = null;
				SecondaryIndividualAllocID = null;
				AllocClearingFeeIndicator = null;
				((IFixReset?)TradeAllocAmtGrp)?.Reset();
				TradeAllocStatus = null;
				AllocationRollupInstruction = null;
				AllocText = null;
				EncodedAllocTextLen = null;
				EncodedAllocText = null;
				FirmAllocText = null;
				EncodedFirmAllocTextLen = null;
				EncodedFirmAllocText = null;
				AllocRefRiskLimitCheckID = null;
				AllocRefRiskLimitCheckIDType = null;
				((IFixReset?)AllocCommissionDataGrp)?.Reset();
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
