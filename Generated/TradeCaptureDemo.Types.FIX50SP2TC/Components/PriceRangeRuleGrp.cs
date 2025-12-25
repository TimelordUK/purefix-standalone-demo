using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PriceRangeRuleGrp : IFixComponent
	{
		public sealed partial class NoPriceRangeRules : IFixGroup
		{
			[TagDetails(Tag = 2551, Type = TagType.Float, Offset = 0, Required = false)]
			public double? StartPriceRange {get; set;}
			
			[TagDetails(Tag = 2552, Type = TagType.Float, Offset = 1, Required = false)]
			public double? EndPriceRange {get; set;}
			
			[TagDetails(Tag = 2553, Type = TagType.Float, Offset = 2, Required = false)]
			public double? PriceRangeValue {get; set;}
			
			[TagDetails(Tag = 2554, Type = TagType.Float, Offset = 3, Required = false)]
			public double? PriceRangePercentage {get; set;}
			
			[TagDetails(Tag = 2556, Type = TagType.String, Offset = 4, Required = false)]
			public string? PriceRangeRuleID {get; set;}
			
			[TagDetails(Tag = 2555, Type = TagType.String, Offset = 5, Required = false)]
			public string? PriceRangeProductComplex {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StartPriceRange is not null) writer.WriteNumber(2551, StartPriceRange.Value);
				if (EndPriceRange is not null) writer.WriteNumber(2552, EndPriceRange.Value);
				if (PriceRangeValue is not null) writer.WriteNumber(2553, PriceRangeValue.Value);
				if (PriceRangePercentage is not null) writer.WriteNumber(2554, PriceRangePercentage.Value);
				if (PriceRangeRuleID is not null) writer.WriteString(2556, PriceRangeRuleID);
				if (PriceRangeProductComplex is not null) writer.WriteString(2555, PriceRangeProductComplex);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StartPriceRange = view.GetDouble(2551);
				EndPriceRange = view.GetDouble(2552);
				PriceRangeValue = view.GetDouble(2553);
				PriceRangePercentage = view.GetDouble(2554);
				PriceRangeRuleID = view.GetString(2556);
				PriceRangeProductComplex = view.GetString(2555);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StartPriceRange":
					{
						value = StartPriceRange;
						break;
					}
					case "EndPriceRange":
					{
						value = EndPriceRange;
						break;
					}
					case "PriceRangeValue":
					{
						value = PriceRangeValue;
						break;
					}
					case "PriceRangePercentage":
					{
						value = PriceRangePercentage;
						break;
					}
					case "PriceRangeRuleID":
					{
						value = PriceRangeRuleID;
						break;
					}
					case "PriceRangeProductComplex":
					{
						value = PriceRangeProductComplex;
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
				StartPriceRange = null;
				EndPriceRange = null;
				PriceRangeValue = null;
				PriceRangePercentage = null;
				PriceRangeRuleID = null;
				PriceRangeProductComplex = null;
			}
		}
		[Group(NoOfTag = 2550, Offset = 0, Required = false)]
		public NoPriceRangeRules[]? PriceRangeRules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PriceRangeRules is not null && PriceRangeRules.Length != 0)
			{
				writer.WriteWholeNumber(2550, PriceRangeRules.Length);
				for (int i = 0; i < PriceRangeRules.Length; i++)
				{
					((IFixEncoder)PriceRangeRules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPriceRangeRules") is IMessageView viewNoPriceRangeRules)
			{
				var count = viewNoPriceRangeRules.GroupCount();
				PriceRangeRules = new NoPriceRangeRules[count];
				for (int i = 0; i < count; i++)
				{
					PriceRangeRules[i] = new();
					((IFixParser)PriceRangeRules[i]).Parse(viewNoPriceRangeRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPriceRangeRules":
				{
					value = PriceRangeRules;
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
			PriceRangeRules = null;
		}
	}
}
