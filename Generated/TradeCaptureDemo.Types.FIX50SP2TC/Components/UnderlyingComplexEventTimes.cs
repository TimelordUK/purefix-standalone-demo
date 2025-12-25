using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventTimes : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventTimes : IFixGroup
		{
			[TagDetails(Tag = 2057, Type = TagType.UtcTimeOnly, Offset = 0, Required = false)]
			public TimeOnly? UnderlyingComplexEventStartTime {get; set;}
			
			[TagDetails(Tag = 2058, Type = TagType.UtcTimeOnly, Offset = 1, Required = false)]
			public TimeOnly? UnderlyingComplexEventEndTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventStartTime is not null) writer.WriteTimeOnly(2057, UnderlyingComplexEventStartTime.Value);
				if (UnderlyingComplexEventEndTime is not null) writer.WriteTimeOnly(2058, UnderlyingComplexEventEndTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventStartTime = view.GetTimeOnly(2057);
				UnderlyingComplexEventEndTime = view.GetTimeOnly(2058);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventStartTime":
					{
						value = UnderlyingComplexEventStartTime;
						break;
					}
					case "UnderlyingComplexEventEndTime":
					{
						value = UnderlyingComplexEventEndTime;
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
				UnderlyingComplexEventStartTime = null;
				UnderlyingComplexEventEndTime = null;
			}
		}
		[Group(NoOfTag = 2056, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventTimes[]? UnderlyingComplexEventTimesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventTimesItems is not null && UnderlyingComplexEventTimesItems.Length != 0)
			{
				writer.WriteWholeNumber(2056, UnderlyingComplexEventTimesItems.Length);
				for (int i = 0; i < UnderlyingComplexEventTimesItems.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventTimesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventTimes") is IMessageView viewNoUnderlyingComplexEventTimes)
			{
				var count = viewNoUnderlyingComplexEventTimes.GroupCount();
				UnderlyingComplexEventTimesItems = new NoUnderlyingComplexEventTimes[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventTimesItems[i] = new();
					((IFixParser)UnderlyingComplexEventTimesItems[i]).Parse(viewNoUnderlyingComplexEventTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventTimes":
				{
					value = UnderlyingComplexEventTimesItems;
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
			UnderlyingComplexEventTimesItems = null;
		}
	}
}
