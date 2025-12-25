using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamFirstPeriodStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegStreamFirstPeriodStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40269, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamFirstPeriodStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamFirstPeriodStartDateBusinessCenter is not null) writer.WriteString(40269, LegStreamFirstPeriodStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamFirstPeriodStartDateBusinessCenter = view.GetString(40269);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamFirstPeriodStartDateBusinessCenter":
					{
						value = LegStreamFirstPeriodStartDateBusinessCenter;
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
				LegStreamFirstPeriodStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40941, Offset = 0, Required = false)]
		public NoLegStreamFirstPeriodStartDateBusinessCenters[]? LegStreamFirstPeriodStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamFirstPeriodStartDateBusinessCenters is not null && LegStreamFirstPeriodStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40941, LegStreamFirstPeriodStartDateBusinessCenters.Length);
				for (int i = 0; i < LegStreamFirstPeriodStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegStreamFirstPeriodStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamFirstPeriodStartDateBusinessCenters") is IMessageView viewNoLegStreamFirstPeriodStartDateBusinessCenters)
			{
				var count = viewNoLegStreamFirstPeriodStartDateBusinessCenters.GroupCount();
				LegStreamFirstPeriodStartDateBusinessCenters = new NoLegStreamFirstPeriodStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamFirstPeriodStartDateBusinessCenters[i] = new();
					((IFixParser)LegStreamFirstPeriodStartDateBusinessCenters[i]).Parse(viewNoLegStreamFirstPeriodStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamFirstPeriodStartDateBusinessCenters":
				{
					value = LegStreamFirstPeriodStartDateBusinessCenters;
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
			LegStreamFirstPeriodStartDateBusinessCenters = null;
		}
	}
}
