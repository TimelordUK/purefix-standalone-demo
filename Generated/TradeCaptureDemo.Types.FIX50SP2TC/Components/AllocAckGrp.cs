using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AllocAckGrp : IFixComponent
	{
		public sealed partial class NoAllocs : IFixGroup
		{
			[TagDetails(Tag = 79, Type = TagType.String, Offset = 0, Required = false)]
			public string? AllocAccount {get; set;}
			
			[TagDetails(Tag = 661, Type = TagType.Int, Offset = 1, Required = false)]
			public int? AllocAcctIDSource {get; set;}
			
			[TagDetails(Tag = 366, Type = TagType.Float, Offset = 2, Required = false)]
			public double? AllocPrice {get; set;}
			
			[TagDetails(Tag = 1047, Type = TagType.String, Offset = 3, Required = false)]
			public string? AllocPositionEffect {get; set;}
			
			[TagDetails(Tag = 467, Type = TagType.String, Offset = 4, Required = false)]
			public string? IndividualAllocID {get; set;}
			
			[TagDetails(Tag = 1593, Type = TagType.String, Offset = 5, Required = false)]
			public string? ParentAllocID {get; set;}
			
			[TagDetails(Tag = 1729, Type = TagType.String, Offset = 6, Required = false)]
			public string? FirmMnemonic {get; set;}
			
			[TagDetails(Tag = 1832, Type = TagType.Int, Offset = 7, Required = false)]
			public int? ClearedIndicator {get; set;}
			
			[TagDetails(Tag = 2727, Type = TagType.String, Offset = 8, Required = false)]
			public string? AllocLegRefID {get; set;}
			
			[Component(Offset = 9, Required = false)]
			public AllocRegulatoryTradeIDGrp? AllocRegulatoryTradeIDGrp {get; set;}
			
			[TagDetails(Tag = 776, Type = TagType.Int, Offset = 10, Required = false)]
			public int? IndividualAllocRejCode {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public NestedParties? NestedParties {get; set;}
			
			[TagDetails(Tag = 209, Type = TagType.Int, Offset = 12, Required = false)]
			public int? AllocHandlInst {get; set;}
			
			[TagDetails(Tag = 161, Type = TagType.String, Offset = 13, Required = false)]
			public string? AllocText {get; set;}
			
			[TagDetails(Tag = 360, Type = TagType.Length, Offset = 14, Required = false)]
			public int? EncodedAllocTextLen {get; set;}
			
			[TagDetails(Tag = 361, Type = TagType.RawData, Offset = 15, Required = false)]
			public byte[]? EncodedAllocText {get; set;}
			
			[TagDetails(Tag = 1732, Type = TagType.String, Offset = 16, Required = false)]
			public string? FirmAllocText {get; set;}
			
			[TagDetails(Tag = 1733, Type = TagType.Length, Offset = 17, Required = false)]
			public int? EncodedFirmAllocTextLen {get; set;}
			
			[TagDetails(Tag = 1734, Type = TagType.RawData, Offset = 18, Required = false)]
			public byte[]? EncodedFirmAllocText {get; set;}
			
			[TagDetails(Tag = 989, Type = TagType.String, Offset = 19, Required = false)]
			public string? SecondaryIndividualAllocID {get; set;}
			
			[TagDetails(Tag = 993, Type = TagType.String, Offset = 20, Required = false)]
			public string? AllocCustomerCapacity {get; set;}
			
			[TagDetails(Tag = 992, Type = TagType.Int, Offset = 21, Required = false)]
			public int? IndividualAllocType {get; set;}
			
			[TagDetails(Tag = 80, Type = TagType.Float, Offset = 22, Required = false)]
			public double? AllocQty {get; set;}
			
			[TagDetails(Tag = 2515, Type = TagType.Float, Offset = 23, Required = false)]
			public double? AllocCalculatedCcyQty {get; set;}
			
			[TagDetails(Tag = 1752, Type = TagType.String, Offset = 24, Required = false)]
			public string? CustodialLotID {get; set;}
			
			[TagDetails(Tag = 1753, Type = TagType.LocalDate, Offset = 25, Required = false)]
			public DateOnly? VersusPurchaseDate {get; set;}
			
			[TagDetails(Tag = 1754, Type = TagType.Float, Offset = 26, Required = false)]
			public double? VersusPurchasePrice {get; set;}
			
			[TagDetails(Tag = 1755, Type = TagType.Float, Offset = 27, Required = false)]
			public double? CurrentCostBasis {get; set;}
			
			[TagDetails(Tag = 2770, Type = TagType.String, Offset = 28, Required = false)]
			public string? AllocAvgPxGroupID {get; set;}
			
			[TagDetails(Tag = 2769, Type = TagType.Int, Offset = 29, Required = false)]
			public int? AllocAvgPxIndicator {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
				if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
				if (AllocPrice is not null) writer.WriteNumber(366, AllocPrice.Value);
				if (AllocPositionEffect is not null) writer.WriteString(1047, AllocPositionEffect);
				if (IndividualAllocID is not null) writer.WriteString(467, IndividualAllocID);
				if (ParentAllocID is not null) writer.WriteString(1593, ParentAllocID);
				if (FirmMnemonic is not null) writer.WriteString(1729, FirmMnemonic);
				if (ClearedIndicator is not null) writer.WriteWholeNumber(1832, ClearedIndicator.Value);
				if (AllocLegRefID is not null) writer.WriteString(2727, AllocLegRefID);
				if (AllocRegulatoryTradeIDGrp is not null) ((IFixEncoder)AllocRegulatoryTradeIDGrp).Encode(writer);
				if (IndividualAllocRejCode is not null) writer.WriteWholeNumber(776, IndividualAllocRejCode.Value);
				if (NestedParties is not null) ((IFixEncoder)NestedParties).Encode(writer);
				if (AllocHandlInst is not null) writer.WriteWholeNumber(209, AllocHandlInst.Value);
				if (AllocText is not null) writer.WriteString(161, AllocText);
				if (EncodedAllocTextLen is not null) writer.WriteWholeNumber(360, EncodedAllocTextLen.Value);
				if (EncodedAllocText is not null) writer.WriteBuffer(361, EncodedAllocText);
				if (FirmAllocText is not null) writer.WriteString(1732, FirmAllocText);
				if (EncodedFirmAllocTextLen is not null) writer.WriteWholeNumber(1733, EncodedFirmAllocTextLen.Value);
				if (EncodedFirmAllocText is not null) writer.WriteBuffer(1734, EncodedFirmAllocText);
				if (SecondaryIndividualAllocID is not null) writer.WriteString(989, SecondaryIndividualAllocID);
				if (AllocCustomerCapacity is not null) writer.WriteString(993, AllocCustomerCapacity);
				if (IndividualAllocType is not null) writer.WriteWholeNumber(992, IndividualAllocType.Value);
				if (AllocQty is not null) writer.WriteNumber(80, AllocQty.Value);
				if (AllocCalculatedCcyQty is not null) writer.WriteNumber(2515, AllocCalculatedCcyQty.Value);
				if (CustodialLotID is not null) writer.WriteString(1752, CustodialLotID);
				if (VersusPurchaseDate is not null) writer.WriteLocalDateOnly(1753, VersusPurchaseDate.Value);
				if (VersusPurchasePrice is not null) writer.WriteNumber(1754, VersusPurchasePrice.Value);
				if (CurrentCostBasis is not null) writer.WriteNumber(1755, CurrentCostBasis.Value);
				if (AllocAvgPxGroupID is not null) writer.WriteString(2770, AllocAvgPxGroupID);
				if (AllocAvgPxIndicator is not null) writer.WriteWholeNumber(2769, AllocAvgPxIndicator.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocAccount = view.GetString(79);
				AllocAcctIDSource = view.GetInt32(661);
				AllocPrice = view.GetDouble(366);
				AllocPositionEffect = view.GetString(1047);
				IndividualAllocID = view.GetString(467);
				ParentAllocID = view.GetString(1593);
				FirmMnemonic = view.GetString(1729);
				ClearedIndicator = view.GetInt32(1832);
				AllocLegRefID = view.GetString(2727);
				if (view.GetView("AllocRegulatoryTradeIDGrp") is IMessageView viewAllocRegulatoryTradeIDGrp)
				{
					AllocRegulatoryTradeIDGrp = new();
					((IFixParser)AllocRegulatoryTradeIDGrp).Parse(viewAllocRegulatoryTradeIDGrp);
				}
				IndividualAllocRejCode = view.GetInt32(776);
				if (view.GetView("NestedParties") is IMessageView viewNestedParties)
				{
					NestedParties = new();
					((IFixParser)NestedParties).Parse(viewNestedParties);
				}
				AllocHandlInst = view.GetInt32(209);
				AllocText = view.GetString(161);
				EncodedAllocTextLen = view.GetInt32(360);
				EncodedAllocText = view.GetByteArray(361);
				FirmAllocText = view.GetString(1732);
				EncodedFirmAllocTextLen = view.GetInt32(1733);
				EncodedFirmAllocText = view.GetByteArray(1734);
				SecondaryIndividualAllocID = view.GetString(989);
				AllocCustomerCapacity = view.GetString(993);
				IndividualAllocType = view.GetInt32(992);
				AllocQty = view.GetDouble(80);
				AllocCalculatedCcyQty = view.GetDouble(2515);
				CustodialLotID = view.GetString(1752);
				VersusPurchaseDate = view.GetDateOnly(1753);
				VersusPurchasePrice = view.GetDouble(1754);
				CurrentCostBasis = view.GetDouble(1755);
				AllocAvgPxGroupID = view.GetString(2770);
				AllocAvgPxIndicator = view.GetInt32(2769);
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
					case "AllocPrice":
					{
						value = AllocPrice;
						break;
					}
					case "AllocPositionEffect":
					{
						value = AllocPositionEffect;
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
					case "FirmMnemonic":
					{
						value = FirmMnemonic;
						break;
					}
					case "ClearedIndicator":
					{
						value = ClearedIndicator;
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
					case "IndividualAllocRejCode":
					{
						value = IndividualAllocRejCode;
						break;
					}
					case "NestedParties":
					{
						value = NestedParties;
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
					case "SecondaryIndividualAllocID":
					{
						value = SecondaryIndividualAllocID;
						break;
					}
					case "AllocCustomerCapacity":
					{
						value = AllocCustomerCapacity;
						break;
					}
					case "IndividualAllocType":
					{
						value = IndividualAllocType;
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
				AllocPrice = null;
				AllocPositionEffect = null;
				IndividualAllocID = null;
				ParentAllocID = null;
				FirmMnemonic = null;
				ClearedIndicator = null;
				AllocLegRefID = null;
				((IFixReset?)AllocRegulatoryTradeIDGrp)?.Reset();
				IndividualAllocRejCode = null;
				((IFixReset?)NestedParties)?.Reset();
				AllocHandlInst = null;
				AllocText = null;
				EncodedAllocTextLen = null;
				EncodedAllocText = null;
				FirmAllocText = null;
				EncodedFirmAllocTextLen = null;
				EncodedFirmAllocText = null;
				SecondaryIndividualAllocID = null;
				AllocCustomerCapacity = null;
				IndividualAllocType = null;
				AllocQty = null;
				AllocCalculatedCcyQty = null;
				CustodialLotID = null;
				VersusPurchaseDate = null;
				VersusPurchasePrice = null;
				CurrentCostBasis = null;
				AllocAvgPxGroupID = null;
				AllocAvgPxIndicator = null;
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
