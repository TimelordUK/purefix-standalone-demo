using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCalculationPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCalculationPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40266, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCalculationPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCalculationPeriodBusinessCenter is not null) writer.WriteString(40266, LegStreamCalculationPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCalculationPeriodBusinessCenter = view.GetString(40266);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCalculationPeriodBusinessCenter":
					{
						value = LegStreamCalculationPeriodBusinessCenter;
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
				LegStreamCalculationPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40940, Offset = 0, Required = false)]
		public NoLegStreamCalculationPeriodBusinessCenters[]? LegStreamCalculationPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCalculationPeriodBusinessCenters is not null && LegStreamCalculationPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40940, LegStreamCalculationPeriodBusinessCenters.Length);
				for (int i = 0; i < LegStreamCalculationPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegStreamCalculationPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCalculationPeriodBusinessCenters") is IMessageView viewNoLegStreamCalculationPeriodBusinessCenters)
			{
				var count = viewNoLegStreamCalculationPeriodBusinessCenters.GroupCount();
				LegStreamCalculationPeriodBusinessCenters = new NoLegStreamCalculationPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCalculationPeriodBusinessCenters[i] = new();
					((IFixParser)LegStreamCalculationPeriodBusinessCenters[i]).Parse(viewNoLegStreamCalculationPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCalculationPeriodBusinessCenters":
				{
					value = LegStreamCalculationPeriodBusinessCenters;
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
			LegStreamCalculationPeriodBusinessCenters = null;
		}
	}
}
