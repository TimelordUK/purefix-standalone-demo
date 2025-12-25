using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventScheduleGrp : IFixComponent
	{
		public sealed partial class NoComplexEventSchedules : IFixGroup
		{
			[TagDetails(Tag = 41032, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? ComplexEventScheduleStartDate {get; set;}
			
			[TagDetails(Tag = 41033, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? ComplexEventScheduleEndDate {get; set;}
			
			[TagDetails(Tag = 41034, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ComplexEventScheduleFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41035, Type = TagType.String, Offset = 3, Required = false)]
			public string? ComplexEventScheduleFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41036, Type = TagType.String, Offset = 4, Required = false)]
			public string? ComplexEventScheduleRollConvention {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventScheduleStartDate is not null) writer.WriteLocalDateOnly(41032, ComplexEventScheduleStartDate.Value);
				if (ComplexEventScheduleEndDate is not null) writer.WriteLocalDateOnly(41033, ComplexEventScheduleEndDate.Value);
				if (ComplexEventScheduleFrequencyPeriod is not null) writer.WriteWholeNumber(41034, ComplexEventScheduleFrequencyPeriod.Value);
				if (ComplexEventScheduleFrequencyUnit is not null) writer.WriteString(41035, ComplexEventScheduleFrequencyUnit);
				if (ComplexEventScheduleRollConvention is not null) writer.WriteString(41036, ComplexEventScheduleRollConvention);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventScheduleStartDate = view.GetDateOnly(41032);
				ComplexEventScheduleEndDate = view.GetDateOnly(41033);
				ComplexEventScheduleFrequencyPeriod = view.GetInt32(41034);
				ComplexEventScheduleFrequencyUnit = view.GetString(41035);
				ComplexEventScheduleRollConvention = view.GetString(41036);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventScheduleStartDate":
					{
						value = ComplexEventScheduleStartDate;
						break;
					}
					case "ComplexEventScheduleEndDate":
					{
						value = ComplexEventScheduleEndDate;
						break;
					}
					case "ComplexEventScheduleFrequencyPeriod":
					{
						value = ComplexEventScheduleFrequencyPeriod;
						break;
					}
					case "ComplexEventScheduleFrequencyUnit":
					{
						value = ComplexEventScheduleFrequencyUnit;
						break;
					}
					case "ComplexEventScheduleRollConvention":
					{
						value = ComplexEventScheduleRollConvention;
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
				ComplexEventScheduleStartDate = null;
				ComplexEventScheduleEndDate = null;
				ComplexEventScheduleFrequencyPeriod = null;
				ComplexEventScheduleFrequencyUnit = null;
				ComplexEventScheduleRollConvention = null;
			}
		}
		[Group(NoOfTag = 41031, Offset = 0, Required = false)]
		public NoComplexEventSchedules[]? ComplexEventSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventSchedules is not null && ComplexEventSchedules.Length != 0)
			{
				writer.WriteWholeNumber(41031, ComplexEventSchedules.Length);
				for (int i = 0; i < ComplexEventSchedules.Length; i++)
				{
					((IFixEncoder)ComplexEventSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventSchedules") is IMessageView viewNoComplexEventSchedules)
			{
				var count = viewNoComplexEventSchedules.GroupCount();
				ComplexEventSchedules = new NoComplexEventSchedules[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventSchedules[i] = new();
					((IFixParser)ComplexEventSchedules[i]).Parse(viewNoComplexEventSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventSchedules":
				{
					value = ComplexEventSchedules;
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
			ComplexEventSchedules = null;
		}
	}
}
