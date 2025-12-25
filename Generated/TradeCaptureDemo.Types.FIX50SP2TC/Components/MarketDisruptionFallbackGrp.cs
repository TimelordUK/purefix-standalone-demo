using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarketDisruptionFallbackGrp : IFixComponent
	{
		public sealed partial class NoMarketDisruptionFallbacks : IFixGroup
		{
			[TagDetails(Tag = 41095, Type = TagType.String, Offset = 0, Required = false)]
			public string? MarketDisruptionFallbackType {get; set;}
			
			[TagDetails(Tag = 40992, Type = TagType.String, Offset = 1, Required = false)]
			public string? MarketDisruptionFallbackValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MarketDisruptionFallbackType is not null) writer.WriteString(41095, MarketDisruptionFallbackType);
				if (MarketDisruptionFallbackValue is not null) writer.WriteString(40992, MarketDisruptionFallbackValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MarketDisruptionFallbackType = view.GetString(41095);
				MarketDisruptionFallbackValue = view.GetString(40992);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MarketDisruptionFallbackType":
					{
						value = MarketDisruptionFallbackType;
						break;
					}
					case "MarketDisruptionFallbackValue":
					{
						value = MarketDisruptionFallbackValue;
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
				MarketDisruptionFallbackType = null;
				MarketDisruptionFallbackValue = null;
			}
		}
		[Group(NoOfTag = 41094, Offset = 0, Required = false)]
		public NoMarketDisruptionFallbacks[]? MarketDisruptionFallbacks {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MarketDisruptionFallbacks is not null && MarketDisruptionFallbacks.Length != 0)
			{
				writer.WriteWholeNumber(41094, MarketDisruptionFallbacks.Length);
				for (int i = 0; i < MarketDisruptionFallbacks.Length; i++)
				{
					((IFixEncoder)MarketDisruptionFallbacks[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMarketDisruptionFallbacks") is IMessageView viewNoMarketDisruptionFallbacks)
			{
				var count = viewNoMarketDisruptionFallbacks.GroupCount();
				MarketDisruptionFallbacks = new NoMarketDisruptionFallbacks[count];
				for (int i = 0; i < count; i++)
				{
					MarketDisruptionFallbacks[i] = new();
					((IFixParser)MarketDisruptionFallbacks[i]).Parse(viewNoMarketDisruptionFallbacks.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMarketDisruptionFallbacks":
				{
					value = MarketDisruptionFallbacks;
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
			MarketDisruptionFallbacks = null;
		}
	}
}
