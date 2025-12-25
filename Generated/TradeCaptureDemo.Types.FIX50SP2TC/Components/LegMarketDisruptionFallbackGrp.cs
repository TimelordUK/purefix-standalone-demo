using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegMarketDisruptionFallbackGrp : IFixComponent
	{
		public sealed partial class NoLegMarketDisruptionFallbacks : IFixGroup
		{
			[TagDetails(Tag = 41470, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegMarketDisruptionFallbackType {get; set;}
			
			[TagDetails(Tag = 40990, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegMarketDisruptionFallbackValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegMarketDisruptionFallbackType is not null) writer.WriteString(41470, LegMarketDisruptionFallbackType);
				if (LegMarketDisruptionFallbackValue is not null) writer.WriteString(40990, LegMarketDisruptionFallbackValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegMarketDisruptionFallbackType = view.GetString(41470);
				LegMarketDisruptionFallbackValue = view.GetString(40990);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegMarketDisruptionFallbackType":
					{
						value = LegMarketDisruptionFallbackType;
						break;
					}
					case "LegMarketDisruptionFallbackValue":
					{
						value = LegMarketDisruptionFallbackValue;
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
				LegMarketDisruptionFallbackType = null;
				LegMarketDisruptionFallbackValue = null;
			}
		}
		[Group(NoOfTag = 41469, Offset = 0, Required = false)]
		public NoLegMarketDisruptionFallbacks[]? LegMarketDisruptionFallbacks {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegMarketDisruptionFallbacks is not null && LegMarketDisruptionFallbacks.Length != 0)
			{
				writer.WriteWholeNumber(41469, LegMarketDisruptionFallbacks.Length);
				for (int i = 0; i < LegMarketDisruptionFallbacks.Length; i++)
				{
					((IFixEncoder)LegMarketDisruptionFallbacks[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegMarketDisruptionFallbacks") is IMessageView viewNoLegMarketDisruptionFallbacks)
			{
				var count = viewNoLegMarketDisruptionFallbacks.GroupCount();
				LegMarketDisruptionFallbacks = new NoLegMarketDisruptionFallbacks[count];
				for (int i = 0; i < count; i++)
				{
					LegMarketDisruptionFallbacks[i] = new();
					((IFixParser)LegMarketDisruptionFallbacks[i]).Parse(viewNoLegMarketDisruptionFallbacks.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegMarketDisruptionFallbacks":
				{
					value = LegMarketDisruptionFallbacks;
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
			LegMarketDisruptionFallbacks = null;
		}
	}
}
