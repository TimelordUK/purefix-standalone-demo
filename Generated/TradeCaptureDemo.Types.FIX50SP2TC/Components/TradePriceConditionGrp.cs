using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TradePriceConditionGrp : IFixComponent
	{
		public sealed partial class NoTradePriceConditions : IFixGroup
		{
			[TagDetails(Tag = 1839, Type = TagType.Int, Offset = 0, Required = false)]
			public int? TradePriceCondition {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradePriceCondition is not null) writer.WriteWholeNumber(1839, TradePriceCondition.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradePriceCondition = view.GetInt32(1839);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TradePriceCondition":
					{
						value = TradePriceCondition;
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
				TradePriceCondition = null;
			}
		}
		[Group(NoOfTag = 1838, Offset = 0, Required = false)]
		public NoTradePriceConditions[]? TradePriceConditions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TradePriceConditions is not null && TradePriceConditions.Length != 0)
			{
				writer.WriteWholeNumber(1838, TradePriceConditions.Length);
				for (int i = 0; i < TradePriceConditions.Length; i++)
				{
					((IFixEncoder)TradePriceConditions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTradePriceConditions") is IMessageView viewNoTradePriceConditions)
			{
				var count = viewNoTradePriceConditions.GroupCount();
				TradePriceConditions = new NoTradePriceConditions[count];
				for (int i = 0; i < count; i++)
				{
					TradePriceConditions[i] = new();
					((IFixParser)TradePriceConditions[i]).Parse(viewNoTradePriceConditions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTradePriceConditions":
				{
					value = TradePriceConditions;
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
			TradePriceConditions = null;
		}
	}
}
