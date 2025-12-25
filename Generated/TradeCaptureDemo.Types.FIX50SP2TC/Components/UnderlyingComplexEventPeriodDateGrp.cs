using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventPeriodDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventPeriodDateTimes : IFixGroup
		{
			[TagDetails(Tag = 41727, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingComplexEventPeriodDate {get; set;}
			
			[TagDetails(Tag = 41728, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingComplexEventPeriodTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventPeriodDate is not null) writer.WriteLocalDateOnly(41727, UnderlyingComplexEventPeriodDate.Value);
				if (UnderlyingComplexEventPeriodTime is not null) writer.WriteString(41728, UnderlyingComplexEventPeriodTime);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventPeriodDate = view.GetDateOnly(41727);
				UnderlyingComplexEventPeriodTime = view.GetString(41728);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventPeriodDate":
					{
						value = UnderlyingComplexEventPeriodDate;
						break;
					}
					case "UnderlyingComplexEventPeriodTime":
					{
						value = UnderlyingComplexEventPeriodTime;
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
				UnderlyingComplexEventPeriodDate = null;
				UnderlyingComplexEventPeriodTime = null;
			}
		}
		[Group(NoOfTag = 41726, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventPeriodDateTimes[]? UnderlyingComplexEventPeriodDateTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventPeriodDateTimes is not null && UnderlyingComplexEventPeriodDateTimes.Length != 0)
			{
				writer.WriteWholeNumber(41726, UnderlyingComplexEventPeriodDateTimes.Length);
				for (int i = 0; i < UnderlyingComplexEventPeriodDateTimes.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventPeriodDateTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventPeriodDateTimes") is IMessageView viewNoUnderlyingComplexEventPeriodDateTimes)
			{
				var count = viewNoUnderlyingComplexEventPeriodDateTimes.GroupCount();
				UnderlyingComplexEventPeriodDateTimes = new NoUnderlyingComplexEventPeriodDateTimes[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventPeriodDateTimes[i] = new();
					((IFixParser)UnderlyingComplexEventPeriodDateTimes[i]).Parse(viewNoUnderlyingComplexEventPeriodDateTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventPeriodDateTimes":
				{
					value = UnderlyingComplexEventPeriodDateTimes;
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
			UnderlyingComplexEventPeriodDateTimes = null;
		}
	}
}
