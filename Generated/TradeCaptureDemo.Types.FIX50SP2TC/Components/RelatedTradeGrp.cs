using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedTradeGrp : IFixComponent
	{
		public sealed partial class NoRelatedTrades : IFixGroup
		{
			[TagDetails(Tag = 1856, Type = TagType.String, Offset = 0, Required = false)]
			public string? RelatedTradeID {get; set;}
			
			[TagDetails(Tag = 1857, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RelatedTradeIDSource {get; set;}
			
			[TagDetails(Tag = 2103, Type = TagType.String, Offset = 2, Required = false)]
			public string? RelatedRegulatoryTradeIDSource {get; set;}
			
			[TagDetails(Tag = 1858, Type = TagType.LocalDate, Offset = 3, Required = false)]
			public DateOnly? RelatedTradeDate {get; set;}
			
			[TagDetails(Tag = 1859, Type = TagType.String, Offset = 4, Required = false)]
			public string? RelatedTradeMarketID {get; set;}
			
			[TagDetails(Tag = 1860, Type = TagType.Float, Offset = 5, Required = false)]
			public double? RelatedTradeQuantity {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedTradeID is not null) writer.WriteString(1856, RelatedTradeID);
				if (RelatedTradeIDSource is not null) writer.WriteWholeNumber(1857, RelatedTradeIDSource.Value);
				if (RelatedRegulatoryTradeIDSource is not null) writer.WriteString(2103, RelatedRegulatoryTradeIDSource);
				if (RelatedTradeDate is not null) writer.WriteLocalDateOnly(1858, RelatedTradeDate.Value);
				if (RelatedTradeMarketID is not null) writer.WriteString(1859, RelatedTradeMarketID);
				if (RelatedTradeQuantity is not null) writer.WriteNumber(1860, RelatedTradeQuantity.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedTradeID = view.GetString(1856);
				RelatedTradeIDSource = view.GetInt32(1857);
				RelatedRegulatoryTradeIDSource = view.GetString(2103);
				RelatedTradeDate = view.GetDateOnly(1858);
				RelatedTradeMarketID = view.GetString(1859);
				RelatedTradeQuantity = view.GetDouble(1860);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedTradeID":
					{
						value = RelatedTradeID;
						break;
					}
					case "RelatedTradeIDSource":
					{
						value = RelatedTradeIDSource;
						break;
					}
					case "RelatedRegulatoryTradeIDSource":
					{
						value = RelatedRegulatoryTradeIDSource;
						break;
					}
					case "RelatedTradeDate":
					{
						value = RelatedTradeDate;
						break;
					}
					case "RelatedTradeMarketID":
					{
						value = RelatedTradeMarketID;
						break;
					}
					case "RelatedTradeQuantity":
					{
						value = RelatedTradeQuantity;
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
				RelatedTradeID = null;
				RelatedTradeIDSource = null;
				RelatedRegulatoryTradeIDSource = null;
				RelatedTradeDate = null;
				RelatedTradeMarketID = null;
				RelatedTradeQuantity = null;
			}
		}
		[Group(NoOfTag = 1855, Offset = 0, Required = false)]
		public NoRelatedTrades[]? RelatedTrades {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedTrades is not null && RelatedTrades.Length != 0)
			{
				writer.WriteWholeNumber(1855, RelatedTrades.Length);
				for (int i = 0; i < RelatedTrades.Length; i++)
				{
					((IFixEncoder)RelatedTrades[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedTrades") is IMessageView viewNoRelatedTrades)
			{
				var count = viewNoRelatedTrades.GroupCount();
				RelatedTrades = new NoRelatedTrades[count];
				for (int i = 0; i < count; i++)
				{
					RelatedTrades[i] = new();
					((IFixParser)RelatedTrades[i]).Parse(viewNoRelatedTrades.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedTrades":
				{
					value = RelatedTrades;
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
			RelatedTrades = null;
		}
	}
}
