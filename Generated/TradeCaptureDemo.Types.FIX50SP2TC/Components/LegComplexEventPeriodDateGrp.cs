using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventPeriodDateGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventPeriodDateTimes : IFixGroup
		{
			[TagDetails(Tag = 41377, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegComplexEventPeriodDate {get; set;}
			
			[TagDetails(Tag = 41378, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegComplexEventPeriodTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventPeriodDate is not null) writer.WriteLocalDateOnly(41377, LegComplexEventPeriodDate.Value);
				if (LegComplexEventPeriodTime is not null) writer.WriteString(41378, LegComplexEventPeriodTime);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventPeriodDate = view.GetDateOnly(41377);
				LegComplexEventPeriodTime = view.GetString(41378);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventPeriodDate":
					{
						value = LegComplexEventPeriodDate;
						break;
					}
					case "LegComplexEventPeriodTime":
					{
						value = LegComplexEventPeriodTime;
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
				LegComplexEventPeriodDate = null;
				LegComplexEventPeriodTime = null;
			}
		}
		[Group(NoOfTag = 41376, Offset = 0, Required = false)]
		public NoLegComplexEventPeriodDateTimes[]? LegComplexEventPeriodDateTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventPeriodDateTimes is not null && LegComplexEventPeriodDateTimes.Length != 0)
			{
				writer.WriteWholeNumber(41376, LegComplexEventPeriodDateTimes.Length);
				for (int i = 0; i < LegComplexEventPeriodDateTimes.Length; i++)
				{
					((IFixEncoder)LegComplexEventPeriodDateTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventPeriodDateTimes") is IMessageView viewNoLegComplexEventPeriodDateTimes)
			{
				var count = viewNoLegComplexEventPeriodDateTimes.GroupCount();
				LegComplexEventPeriodDateTimes = new NoLegComplexEventPeriodDateTimes[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventPeriodDateTimes[i] = new();
					((IFixParser)LegComplexEventPeriodDateTimes[i]).Parse(viewNoLegComplexEventPeriodDateTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventPeriodDateTimes":
				{
					value = LegComplexEventPeriodDateTimes;
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
			LegComplexEventPeriodDateTimes = null;
		}
	}
}
