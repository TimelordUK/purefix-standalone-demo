using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingComplexEventScheduleGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingComplexEventSchedules : IFixGroup
		{
			[TagDetails(Tag = 41751, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingComplexEventScheduleStartDate {get; set;}
			
			[TagDetails(Tag = 41752, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? UnderlyingComplexEventScheduleEndDate {get; set;}
			
			[TagDetails(Tag = 41753, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingComplexEventScheduleFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41754, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingComplexEventScheduleFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41755, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingComplexEventScheduleRollConvention {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingComplexEventScheduleStartDate is not null) writer.WriteLocalDateOnly(41751, UnderlyingComplexEventScheduleStartDate.Value);
				if (UnderlyingComplexEventScheduleEndDate is not null) writer.WriteLocalDateOnly(41752, UnderlyingComplexEventScheduleEndDate.Value);
				if (UnderlyingComplexEventScheduleFrequencyPeriod is not null) writer.WriteWholeNumber(41753, UnderlyingComplexEventScheduleFrequencyPeriod.Value);
				if (UnderlyingComplexEventScheduleFrequencyUnit is not null) writer.WriteString(41754, UnderlyingComplexEventScheduleFrequencyUnit);
				if (UnderlyingComplexEventScheduleRollConvention is not null) writer.WriteString(41755, UnderlyingComplexEventScheduleRollConvention);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingComplexEventScheduleStartDate = view.GetDateOnly(41751);
				UnderlyingComplexEventScheduleEndDate = view.GetDateOnly(41752);
				UnderlyingComplexEventScheduleFrequencyPeriod = view.GetInt32(41753);
				UnderlyingComplexEventScheduleFrequencyUnit = view.GetString(41754);
				UnderlyingComplexEventScheduleRollConvention = view.GetString(41755);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingComplexEventScheduleStartDate":
					{
						value = UnderlyingComplexEventScheduleStartDate;
						break;
					}
					case "UnderlyingComplexEventScheduleEndDate":
					{
						value = UnderlyingComplexEventScheduleEndDate;
						break;
					}
					case "UnderlyingComplexEventScheduleFrequencyPeriod":
					{
						value = UnderlyingComplexEventScheduleFrequencyPeriod;
						break;
					}
					case "UnderlyingComplexEventScheduleFrequencyUnit":
					{
						value = UnderlyingComplexEventScheduleFrequencyUnit;
						break;
					}
					case "UnderlyingComplexEventScheduleRollConvention":
					{
						value = UnderlyingComplexEventScheduleRollConvention;
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
				UnderlyingComplexEventScheduleStartDate = null;
				UnderlyingComplexEventScheduleEndDate = null;
				UnderlyingComplexEventScheduleFrequencyPeriod = null;
				UnderlyingComplexEventScheduleFrequencyUnit = null;
				UnderlyingComplexEventScheduleRollConvention = null;
			}
		}
		[Group(NoOfTag = 41750, Offset = 0, Required = false)]
		public NoUnderlyingComplexEventSchedules[]? UnderlyingComplexEventSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingComplexEventSchedules is not null && UnderlyingComplexEventSchedules.Length != 0)
			{
				writer.WriteWholeNumber(41750, UnderlyingComplexEventSchedules.Length);
				for (int i = 0; i < UnderlyingComplexEventSchedules.Length; i++)
				{
					((IFixEncoder)UnderlyingComplexEventSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingComplexEventSchedules") is IMessageView viewNoUnderlyingComplexEventSchedules)
			{
				var count = viewNoUnderlyingComplexEventSchedules.GroupCount();
				UnderlyingComplexEventSchedules = new NoUnderlyingComplexEventSchedules[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingComplexEventSchedules[i] = new();
					((IFixParser)UnderlyingComplexEventSchedules[i]).Parse(viewNoUnderlyingComplexEventSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingComplexEventSchedules":
				{
					value = UnderlyingComplexEventSchedules;
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
			UnderlyingComplexEventSchedules = null;
		}
	}
}
