using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegComplexEventScheduleGrp : IFixComponent
	{
		public sealed partial class NoLegComplexEventSchedules : IFixGroup
		{
			[TagDetails(Tag = 41401, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegComplexEventScheduleStartDate {get; set;}
			
			[TagDetails(Tag = 41402, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? LegComplexEventScheduleEndDate {get; set;}
			
			[TagDetails(Tag = 41403, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegComplexEventScheduleFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41404, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegComplexEventScheduleFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41405, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegComplexEventScheduleRollConvention {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegComplexEventScheduleStartDate is not null) writer.WriteLocalDateOnly(41401, LegComplexEventScheduleStartDate.Value);
				if (LegComplexEventScheduleEndDate is not null) writer.WriteLocalDateOnly(41402, LegComplexEventScheduleEndDate.Value);
				if (LegComplexEventScheduleFrequencyPeriod is not null) writer.WriteWholeNumber(41403, LegComplexEventScheduleFrequencyPeriod.Value);
				if (LegComplexEventScheduleFrequencyUnit is not null) writer.WriteString(41404, LegComplexEventScheduleFrequencyUnit);
				if (LegComplexEventScheduleRollConvention is not null) writer.WriteString(41405, LegComplexEventScheduleRollConvention);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegComplexEventScheduleStartDate = view.GetDateOnly(41401);
				LegComplexEventScheduleEndDate = view.GetDateOnly(41402);
				LegComplexEventScheduleFrequencyPeriod = view.GetInt32(41403);
				LegComplexEventScheduleFrequencyUnit = view.GetString(41404);
				LegComplexEventScheduleRollConvention = view.GetString(41405);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegComplexEventScheduleStartDate":
					{
						value = LegComplexEventScheduleStartDate;
						break;
					}
					case "LegComplexEventScheduleEndDate":
					{
						value = LegComplexEventScheduleEndDate;
						break;
					}
					case "LegComplexEventScheduleFrequencyPeriod":
					{
						value = LegComplexEventScheduleFrequencyPeriod;
						break;
					}
					case "LegComplexEventScheduleFrequencyUnit":
					{
						value = LegComplexEventScheduleFrequencyUnit;
						break;
					}
					case "LegComplexEventScheduleRollConvention":
					{
						value = LegComplexEventScheduleRollConvention;
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
				LegComplexEventScheduleStartDate = null;
				LegComplexEventScheduleEndDate = null;
				LegComplexEventScheduleFrequencyPeriod = null;
				LegComplexEventScheduleFrequencyUnit = null;
				LegComplexEventScheduleRollConvention = null;
			}
		}
		[Group(NoOfTag = 41400, Offset = 0, Required = false)]
		public NoLegComplexEventSchedules[]? LegComplexEventSchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegComplexEventSchedules is not null && LegComplexEventSchedules.Length != 0)
			{
				writer.WriteWholeNumber(41400, LegComplexEventSchedules.Length);
				for (int i = 0; i < LegComplexEventSchedules.Length; i++)
				{
					((IFixEncoder)LegComplexEventSchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegComplexEventSchedules") is IMessageView viewNoLegComplexEventSchedules)
			{
				var count = viewNoLegComplexEventSchedules.GroupCount();
				LegComplexEventSchedules = new NoLegComplexEventSchedules[count];
				for (int i = 0; i < count; i++)
				{
					LegComplexEventSchedules[i] = new();
					((IFixParser)LegComplexEventSchedules[i]).Parse(viewNoLegComplexEventSchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegComplexEventSchedules":
				{
					value = LegComplexEventSchedules;
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
			LegComplexEventSchedules = null;
		}
	}
}
