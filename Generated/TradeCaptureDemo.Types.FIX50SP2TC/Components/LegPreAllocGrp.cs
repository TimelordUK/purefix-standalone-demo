using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPreAllocGrp : IFixComponent
	{
		public sealed partial class NoLegAllocs : IFixGroup
		{
			[TagDetails(Tag = 671, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegAllocAccount {get; set;}
			
			[TagDetails(Tag = 672, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegIndividualAllocID {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public NestedParties2? NestedParties2 {get; set;}
			
			[TagDetails(Tag = 673, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LegAllocQty {get; set;}
			
			[TagDetails(Tag = 674, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LegAllocAcctIDSource {get; set;}
			
			[TagDetails(Tag = 1367, Type = TagType.String, Offset = 5, Required = false)]
			public string? LegAllocSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2928, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegAllocSettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1756, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegCustodialLotID {get; set;}
			
			[TagDetails(Tag = 1757, Type = TagType.LocalDate, Offset = 8, Required = false)]
			public DateOnly? LegVersusPurchaseDate {get; set;}
			
			[TagDetails(Tag = 1758, Type = TagType.Float, Offset = 9, Required = false)]
			public double? LegVersusPurchasePrice {get; set;}
			
			[TagDetails(Tag = 1759, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LegCurrentCostBasis {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegAllocAccount is not null) writer.WriteString(671, LegAllocAccount);
				if (LegIndividualAllocID is not null) writer.WriteString(672, LegIndividualAllocID);
				if (NestedParties2 is not null) ((IFixEncoder)NestedParties2).Encode(writer);
				if (LegAllocQty is not null) writer.WriteNumber(673, LegAllocQty.Value);
				if (LegAllocAcctIDSource is not null) writer.WriteWholeNumber(674, LegAllocAcctIDSource.Value);
				if (LegAllocSettlCurrency is not null) writer.WriteString(1367, LegAllocSettlCurrency);
				if (LegAllocSettlCurrencyCodeSource is not null) writer.WriteString(2928, LegAllocSettlCurrencyCodeSource);
				if (LegCustodialLotID is not null) writer.WriteString(1756, LegCustodialLotID);
				if (LegVersusPurchaseDate is not null) writer.WriteLocalDateOnly(1757, LegVersusPurchaseDate.Value);
				if (LegVersusPurchasePrice is not null) writer.WriteNumber(1758, LegVersusPurchasePrice.Value);
				if (LegCurrentCostBasis is not null) writer.WriteNumber(1759, LegCurrentCostBasis.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegAllocAccount = view.GetString(671);
				LegIndividualAllocID = view.GetString(672);
				if (view.GetView("NestedParties2") is IMessageView viewNestedParties2)
				{
					NestedParties2 = new();
					((IFixParser)NestedParties2).Parse(viewNestedParties2);
				}
				LegAllocQty = view.GetDouble(673);
				LegAllocAcctIDSource = view.GetInt32(674);
				LegAllocSettlCurrency = view.GetString(1367);
				LegAllocSettlCurrencyCodeSource = view.GetString(2928);
				LegCustodialLotID = view.GetString(1756);
				LegVersusPurchaseDate = view.GetDateOnly(1757);
				LegVersusPurchasePrice = view.GetDouble(1758);
				LegCurrentCostBasis = view.GetDouble(1759);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegAllocAccount":
					{
						value = LegAllocAccount;
						break;
					}
					case "LegIndividualAllocID":
					{
						value = LegIndividualAllocID;
						break;
					}
					case "NestedParties2":
					{
						value = NestedParties2;
						break;
					}
					case "LegAllocQty":
					{
						value = LegAllocQty;
						break;
					}
					case "LegAllocAcctIDSource":
					{
						value = LegAllocAcctIDSource;
						break;
					}
					case "LegAllocSettlCurrency":
					{
						value = LegAllocSettlCurrency;
						break;
					}
					case "LegAllocSettlCurrencyCodeSource":
					{
						value = LegAllocSettlCurrencyCodeSource;
						break;
					}
					case "LegCustodialLotID":
					{
						value = LegCustodialLotID;
						break;
					}
					case "LegVersusPurchaseDate":
					{
						value = LegVersusPurchaseDate;
						break;
					}
					case "LegVersusPurchasePrice":
					{
						value = LegVersusPurchasePrice;
						break;
					}
					case "LegCurrentCostBasis":
					{
						value = LegCurrentCostBasis;
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
				LegAllocAccount = null;
				LegIndividualAllocID = null;
				((IFixReset?)NestedParties2)?.Reset();
				LegAllocQty = null;
				LegAllocAcctIDSource = null;
				LegAllocSettlCurrency = null;
				LegAllocSettlCurrencyCodeSource = null;
				LegCustodialLotID = null;
				LegVersusPurchaseDate = null;
				LegVersusPurchasePrice = null;
				LegCurrentCostBasis = null;
			}
		}
		[Group(NoOfTag = 670, Offset = 0, Required = false)]
		public NoLegAllocs[]? LegAllocs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegAllocs is not null && LegAllocs.Length != 0)
			{
				writer.WriteWholeNumber(670, LegAllocs.Length);
				for (int i = 0; i < LegAllocs.Length; i++)
				{
					((IFixEncoder)LegAllocs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegAllocs") is IMessageView viewNoLegAllocs)
			{
				var count = viewNoLegAllocs.GroupCount();
				LegAllocs = new NoLegAllocs[count];
				for (int i = 0; i < count; i++)
				{
					LegAllocs[i] = new();
					((IFixParser)LegAllocs[i]).Parse(viewNoLegAllocs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegAllocs":
				{
					value = LegAllocs;
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
			LegAllocs = null;
		}
	}
}
