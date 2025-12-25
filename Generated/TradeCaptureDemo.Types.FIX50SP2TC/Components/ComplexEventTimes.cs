using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventTimes : IFixComponent
	{
		public sealed partial class NoComplexEventTimes : IFixGroup
		{
			[TagDetails(Tag = 1495, Type = TagType.UtcTimeOnly, Offset = 0, Required = false)]
			public TimeOnly? ComplexEventStartTime {get; set;}
			
			[TagDetails(Tag = 1496, Type = TagType.UtcTimeOnly, Offset = 1, Required = false)]
			public TimeOnly? ComplexEventEndTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventStartTime is not null) writer.WriteTimeOnly(1495, ComplexEventStartTime.Value);
				if (ComplexEventEndTime is not null) writer.WriteTimeOnly(1496, ComplexEventEndTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventStartTime = view.GetTimeOnly(1495);
				ComplexEventEndTime = view.GetTimeOnly(1496);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventStartTime":
					{
						value = ComplexEventStartTime;
						break;
					}
					case "ComplexEventEndTime":
					{
						value = ComplexEventEndTime;
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
				ComplexEventStartTime = null;
				ComplexEventEndTime = null;
			}
		}
		[Group(NoOfTag = 1494, Offset = 0, Required = false)]
		public NoComplexEventTimes[]? ComplexEventTimesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventTimesItems is not null && ComplexEventTimesItems.Length != 0)
			{
				writer.WriteWholeNumber(1494, ComplexEventTimesItems.Length);
				for (int i = 0; i < ComplexEventTimesItems.Length; i++)
				{
					((IFixEncoder)ComplexEventTimesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventTimes") is IMessageView viewNoComplexEventTimes)
			{
				var count = viewNoComplexEventTimes.GroupCount();
				ComplexEventTimesItems = new NoComplexEventTimes[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventTimesItems[i] = new();
					((IFixParser)ComplexEventTimesItems[i]).Parse(viewNoComplexEventTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventTimes":
				{
					value = ComplexEventTimesItems;
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
			ComplexEventTimesItems = null;
		}
	}
}
