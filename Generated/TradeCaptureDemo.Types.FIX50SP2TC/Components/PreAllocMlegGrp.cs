using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PreAllocMlegGrp : IFixComponent
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
			
			[TagDetails(Tag = 2727, Type = TagType.String, Offset = 5, Required = false)]
			public string? AllocLegRefID {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public NestedParties3? NestedParties3 {get; set;}
			
			[TagDetails(Tag = 80, Type = TagType.Float, Offset = 7, Required = false)]
			public double? AllocQty {get; set;}
			
			[TagDetails(Tag = 1752, Type = TagType.String, Offset = 8, Required = false)]
			public string? CustodialLotID {get; set;}
			
			[TagDetails(Tag = 1753, Type = TagType.LocalDate, Offset = 9, Required = false)]
			public DateOnly? VersusPurchaseDate {get; set;}
			
			[TagDetails(Tag = 1754, Type = TagType.Float, Offset = 10, Required = false)]
			public double? VersusPurchasePrice {get; set;}
			
			[TagDetails(Tag = 1755, Type = TagType.Float, Offset = 11, Required = false)]
			public double? CurrentCostBasis {get; set;}
			
			
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
				if (AllocLegRefID is not null) writer.WriteString(2727, AllocLegRefID);
				if (NestedParties3 is not null) ((IFixEncoder)NestedParties3).Encode(writer);
				if (AllocQty is not null) writer.WriteNumber(80, AllocQty.Value);
				if (CustodialLotID is not null) writer.WriteString(1752, CustodialLotID);
				if (VersusPurchaseDate is not null) writer.WriteLocalDateOnly(1753, VersusPurchaseDate.Value);
				if (VersusPurchasePrice is not null) writer.WriteNumber(1754, VersusPurchasePrice.Value);
				if (CurrentCostBasis is not null) writer.WriteNumber(1755, CurrentCostBasis.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AllocAccount = view.GetString(79);
				AllocAcctIDSource = view.GetInt32(661);
				AllocSettlCurrency = view.GetString(736);
				AllocSettlCurrencyCodeSource = view.GetString(2927);
				IndividualAllocID = view.GetString(467);
				AllocLegRefID = view.GetString(2727);
				if (view.GetView("NestedParties3") is IMessageView viewNestedParties3)
				{
					NestedParties3 = new();
					((IFixParser)NestedParties3).Parse(viewNestedParties3);
				}
				AllocQty = view.GetDouble(80);
				CustodialLotID = view.GetString(1752);
				VersusPurchaseDate = view.GetDateOnly(1753);
				VersusPurchasePrice = view.GetDouble(1754);
				CurrentCostBasis = view.GetDouble(1755);
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
					case "AllocLegRefID":
					{
						value = AllocLegRefID;
						break;
					}
					case "NestedParties3":
					{
						value = NestedParties3;
						break;
					}
					case "AllocQty":
					{
						value = AllocQty;
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
				AllocLegRefID = null;
				((IFixReset?)NestedParties3)?.Reset();
				AllocQty = null;
				CustodialLotID = null;
				VersusPurchaseDate = null;
				VersusPurchasePrice = null;
				CurrentCostBasis = null;
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
