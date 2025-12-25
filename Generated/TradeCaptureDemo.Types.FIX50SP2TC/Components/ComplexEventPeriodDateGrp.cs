using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventPeriodDateGrp : IFixComponent
	{
		public sealed partial class NoComplexEventPeriodDateTimes : IFixGroup
		{
			[TagDetails(Tag = 41008, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? ComplexEventPeriodDate {get; set;}
			
			[TagDetails(Tag = 41009, Type = TagType.String, Offset = 1, Required = false)]
			public string? ComplexEventPeriodTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventPeriodDate is not null) writer.WriteLocalDateOnly(41008, ComplexEventPeriodDate.Value);
				if (ComplexEventPeriodTime is not null) writer.WriteString(41009, ComplexEventPeriodTime);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventPeriodDate = view.GetDateOnly(41008);
				ComplexEventPeriodTime = view.GetString(41009);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventPeriodDate":
					{
						value = ComplexEventPeriodDate;
						break;
					}
					case "ComplexEventPeriodTime":
					{
						value = ComplexEventPeriodTime;
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
				ComplexEventPeriodDate = null;
				ComplexEventPeriodTime = null;
			}
		}
		[Group(NoOfTag = 41007, Offset = 0, Required = false)]
		public NoComplexEventPeriodDateTimes[]? ComplexEventPeriodDateTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventPeriodDateTimes is not null && ComplexEventPeriodDateTimes.Length != 0)
			{
				writer.WriteWholeNumber(41007, ComplexEventPeriodDateTimes.Length);
				for (int i = 0; i < ComplexEventPeriodDateTimes.Length; i++)
				{
					((IFixEncoder)ComplexEventPeriodDateTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventPeriodDateTimes") is IMessageView viewNoComplexEventPeriodDateTimes)
			{
				var count = viewNoComplexEventPeriodDateTimes.GroupCount();
				ComplexEventPeriodDateTimes = new NoComplexEventPeriodDateTimes[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventPeriodDateTimes[i] = new();
					((IFixParser)ComplexEventPeriodDateTimes[i]).Parse(viewNoComplexEventPeriodDateTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventPeriodDateTimes":
				{
					value = ComplexEventPeriodDateTimes;
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
			ComplexEventPeriodDateTimes = null;
		}
	}
}
