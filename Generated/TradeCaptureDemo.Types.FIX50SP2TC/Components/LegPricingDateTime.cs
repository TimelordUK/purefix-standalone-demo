using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPricingDateTime : IFixComponent
	{
		[TagDetails(Tag = 41609, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegPricingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41610, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegPricingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegPricingDateBusinessCenterGrp? LegPricingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41611, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? LegPricingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41612, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegPricingTime {get; set;}
		
		[TagDetails(Tag = 41613, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegPricingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPricingDateUnadjusted is not null) writer.WriteLocalDateOnly(41609, LegPricingDateUnadjusted.Value);
			if (LegPricingDateBusinessDayConvention is not null) writer.WriteWholeNumber(41610, LegPricingDateBusinessDayConvention.Value);
			if (LegPricingDateBusinessCenterGrp is not null) ((IFixEncoder)LegPricingDateBusinessCenterGrp).Encode(writer);
			if (LegPricingDateAdjusted is not null) writer.WriteLocalDateOnly(41611, LegPricingDateAdjusted.Value);
			if (LegPricingTime is not null) writer.WriteString(41612, LegPricingTime);
			if (LegPricingTimeBusinessCenter is not null) writer.WriteString(41613, LegPricingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPricingDateUnadjusted = view.GetDateOnly(41609);
			LegPricingDateBusinessDayConvention = view.GetInt32(41610);
			if (view.GetView("LegPricingDateBusinessCenterGrp") is IMessageView viewLegPricingDateBusinessCenterGrp)
			{
				LegPricingDateBusinessCenterGrp = new();
				((IFixParser)LegPricingDateBusinessCenterGrp).Parse(viewLegPricingDateBusinessCenterGrp);
			}
			LegPricingDateAdjusted = view.GetDateOnly(41611);
			LegPricingTime = view.GetString(41612);
			LegPricingTimeBusinessCenter = view.GetString(41613);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPricingDateUnadjusted":
				{
					value = LegPricingDateUnadjusted;
					break;
				}
				case "LegPricingDateBusinessDayConvention":
				{
					value = LegPricingDateBusinessDayConvention;
					break;
				}
				case "LegPricingDateBusinessCenterGrp":
				{
					value = LegPricingDateBusinessCenterGrp;
					break;
				}
				case "LegPricingDateAdjusted":
				{
					value = LegPricingDateAdjusted;
					break;
				}
				case "LegPricingTime":
				{
					value = LegPricingTime;
					break;
				}
				case "LegPricingTimeBusinessCenter":
				{
					value = LegPricingTimeBusinessCenter;
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
			LegPricingDateUnadjusted = null;
			LegPricingDateBusinessDayConvention = null;
			((IFixReset?)LegPricingDateBusinessCenterGrp)?.Reset();
			LegPricingDateAdjusted = null;
			LegPricingTime = null;
			LegPricingTimeBusinessCenter = null;
		}
	}
}
