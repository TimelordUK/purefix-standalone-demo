using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCalculationPeriodDateGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCalculationPeriodDates : IFixGroup
		{
			[TagDetails(Tag = 41639, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegStreamCalculationPeriodDate {get; set;}
			
			[TagDetails(Tag = 41640, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegStreamCalculationPeriodDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCalculationPeriodDate is not null) writer.WriteLocalDateOnly(41639, LegStreamCalculationPeriodDate.Value);
				if (LegStreamCalculationPeriodDateType is not null) writer.WriteWholeNumber(41640, LegStreamCalculationPeriodDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCalculationPeriodDate = view.GetDateOnly(41639);
				LegStreamCalculationPeriodDateType = view.GetInt32(41640);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCalculationPeriodDate":
					{
						value = LegStreamCalculationPeriodDate;
						break;
					}
					case "LegStreamCalculationPeriodDateType":
					{
						value = LegStreamCalculationPeriodDateType;
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
				LegStreamCalculationPeriodDate = null;
				LegStreamCalculationPeriodDateType = null;
			}
		}
		[Group(NoOfTag = 41638, Offset = 0, Required = false)]
		public NoLegStreamCalculationPeriodDates[]? LegStreamCalculationPeriodDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCalculationPeriodDates is not null && LegStreamCalculationPeriodDates.Length != 0)
			{
				writer.WriteWholeNumber(41638, LegStreamCalculationPeriodDates.Length);
				for (int i = 0; i < LegStreamCalculationPeriodDates.Length; i++)
				{
					((IFixEncoder)LegStreamCalculationPeriodDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCalculationPeriodDates") is IMessageView viewNoLegStreamCalculationPeriodDates)
			{
				var count = viewNoLegStreamCalculationPeriodDates.GroupCount();
				LegStreamCalculationPeriodDates = new NoLegStreamCalculationPeriodDates[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCalculationPeriodDates[i] = new();
					((IFixParser)LegStreamCalculationPeriodDates[i]).Parse(viewNoLegStreamCalculationPeriodDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCalculationPeriodDates":
				{
					value = LegStreamCalculationPeriodDates;
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
			LegStreamCalculationPeriodDates = null;
		}
	}
}
