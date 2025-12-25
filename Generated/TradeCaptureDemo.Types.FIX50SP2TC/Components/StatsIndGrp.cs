using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StatsIndGrp : IFixComponent
	{
		public sealed partial class NoStatsIndicators : IFixGroup
		{
			[TagDetails(Tag = 1176, Type = TagType.Int, Offset = 0, Required = false)]
			public int? StatsType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StatsType is not null) writer.WriteWholeNumber(1176, StatsType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StatsType = view.GetInt32(1176);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StatsType":
					{
						value = StatsType;
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
				StatsType = null;
			}
		}
		[Group(NoOfTag = 1175, Offset = 0, Required = false)]
		public NoStatsIndicators[]? StatsIndicators {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StatsIndicators is not null && StatsIndicators.Length != 0)
			{
				writer.WriteWholeNumber(1175, StatsIndicators.Length);
				for (int i = 0; i < StatsIndicators.Length; i++)
				{
					((IFixEncoder)StatsIndicators[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStatsIndicators") is IMessageView viewNoStatsIndicators)
			{
				var count = viewNoStatsIndicators.GroupCount();
				StatsIndicators = new NoStatsIndicators[count];
				for (int i = 0; i < count; i++)
				{
					StatsIndicators[i] = new();
					((IFixParser)StatsIndicators[i]).Parse(viewNoStatsIndicators.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStatsIndicators":
				{
					value = StatsIndicators;
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
			StatsIndicators = null;
		}
	}
}
