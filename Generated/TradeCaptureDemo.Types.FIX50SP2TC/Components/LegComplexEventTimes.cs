using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventTimes : IFixComponent
	{
		public sealed partial class NoLegComplexEventTimes : IFixGroup
		{
			[TagDetails(Tag = 2204, Type = TagType.UtcTimeOnly, Offset = 0, Required = false)]
			public TimeOnly? LegComplexEventStartTime {get; set;}
			
			[TagDetails(Tag = 2247, Type = TagType.UtcTimeOnly, Offset = 1, Required = false)]
			public TimeOnly? LegComplexEventEndTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventStartTime is not null) writer.WriteTimeOnly(2204, LegComplexEventStartTime.Value);
				if (LegComplexEventEndTime is not null) writer.WriteTimeOnly(2247, LegComplexEventEndTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventStartTime = view.GetTimeOnly(2204);
				LegComplexEventEndTime = view.GetTimeOnly(2247);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventStartTime":
					{
						value = LegComplexEventStartTime;
						break;
					}
					case "LegComplexEventEndTime":
					{
						value = LegComplexEventEndTime;
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
				LegComplexEventStartTime = null;
				LegComplexEventEndTime = null;
			}
		}
		[Group(NoOfTag = 2253, Offset = 0, Required = false)]
		public NoLegComplexEventTimes[]? LegComplexEventTimesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventTimesItems is not null && LegComplexEventTimesItems.Length != 0)
			{
				writer.WriteWholeNumber(2253, LegComplexEventTimesItems.Length);
				for (int i = 0; i < LegComplexEventTimesItems.Length; i++)
				{
					((IFixEncoder)LegComplexEventTimesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventTimes") is IMessageView viewNoLegComplexEventTimes)
			{
				var count = viewNoLegComplexEventTimes.GroupCount();
				LegComplexEventTimesItems = new NoLegComplexEventTimes[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventTimesItems[i] = new();
					((IFixParser)LegComplexEventTimesItems[i]).Parse(viewNoLegComplexEventTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventTimes":
				{
					value = LegComplexEventTimesItems;
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
			LegComplexEventTimesItems = null;
		}
	}
}
