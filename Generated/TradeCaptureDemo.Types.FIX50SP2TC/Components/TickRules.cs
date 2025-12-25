using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TickRules : IFixComponent
	{
		public sealed partial class NoTickRules : IFixGroup
		{
			[TagDetails(Tag = 1206, Type = TagType.Float, Offset = 0, Required = false)]
			public double? StartTickPriceRange {get; set;}
			
			[TagDetails(Tag = 1207, Type = TagType.Float, Offset = 1, Required = false)]
			public double? EndTickPriceRange {get; set;}
			
			[TagDetails(Tag = 1208, Type = TagType.Float, Offset = 2, Required = false)]
			public double? TickIncrement {get; set;}
			
			[TagDetails(Tag = 1209, Type = TagType.Int, Offset = 3, Required = false)]
			public int? TickRuleType {get; set;}
			
			[TagDetails(Tag = 2571, Type = TagType.String, Offset = 4, Required = false)]
			public string? TickRuleProductComplex {get; set;}
			
			[TagDetails(Tag = 1830, Type = TagType.Float, Offset = 5, Required = false)]
			public double? SettlPriceIncrement {get; set;}
			
			[TagDetails(Tag = 1831, Type = TagType.Float, Offset = 6, Required = false)]
			public double? SettlPriceSecondaryIncrement {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StartTickPriceRange is not null) writer.WriteNumber(1206, StartTickPriceRange.Value);
				if (EndTickPriceRange is not null) writer.WriteNumber(1207, EndTickPriceRange.Value);
				if (TickIncrement is not null) writer.WriteNumber(1208, TickIncrement.Value);
				if (TickRuleType is not null) writer.WriteWholeNumber(1209, TickRuleType.Value);
				if (TickRuleProductComplex is not null) writer.WriteString(2571, TickRuleProductComplex);
				if (SettlPriceIncrement is not null) writer.WriteNumber(1830, SettlPriceIncrement.Value);
				if (SettlPriceSecondaryIncrement is not null) writer.WriteNumber(1831, SettlPriceSecondaryIncrement.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StartTickPriceRange = view.GetDouble(1206);
				EndTickPriceRange = view.GetDouble(1207);
				TickIncrement = view.GetDouble(1208);
				TickRuleType = view.GetInt32(1209);
				TickRuleProductComplex = view.GetString(2571);
				SettlPriceIncrement = view.GetDouble(1830);
				SettlPriceSecondaryIncrement = view.GetDouble(1831);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StartTickPriceRange":
					{
						value = StartTickPriceRange;
						break;
					}
					case "EndTickPriceRange":
					{
						value = EndTickPriceRange;
						break;
					}
					case "TickIncrement":
					{
						value = TickIncrement;
						break;
					}
					case "TickRuleType":
					{
						value = TickRuleType;
						break;
					}
					case "TickRuleProductComplex":
					{
						value = TickRuleProductComplex;
						break;
					}
					case "SettlPriceIncrement":
					{
						value = SettlPriceIncrement;
						break;
					}
					case "SettlPriceSecondaryIncrement":
					{
						value = SettlPriceSecondaryIncrement;
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
				StartTickPriceRange = null;
				EndTickPriceRange = null;
				TickIncrement = null;
				TickRuleType = null;
				TickRuleProductComplex = null;
				SettlPriceIncrement = null;
				SettlPriceSecondaryIncrement = null;
			}
		}
		[Group(NoOfTag = 1205, Offset = 0, Required = false)]
		public NoTickRules[]? TickRulesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TickRulesItems is not null && TickRulesItems.Length != 0)
			{
				writer.WriteWholeNumber(1205, TickRulesItems.Length);
				for (int i = 0; i < TickRulesItems.Length; i++)
				{
					((IFixEncoder)TickRulesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTickRules") is IMessageView viewNoTickRules)
			{
				var count = viewNoTickRules.GroupCount();
				TickRulesItems = new NoTickRules[count];
				for (int i = 0; i < count; i++)
				{
					TickRulesItems[i] = new();
					((IFixParser)TickRulesItems[i]).Parse(viewNoTickRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTickRules":
				{
					value = TickRulesItems;
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
			TickRulesItems = null;
		}
	}
}
