using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PricingDateTime : IFixComponent
	{
		[TagDetails(Tag = 41232, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? PricingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41233, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PricingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public PricingDateBusinessCenterGrp? PricingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41234, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? PricingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41235, Type = TagType.String, Offset = 4, Required = false)]
		public string? PricingTime {get; set;}
		
		[TagDetails(Tag = 41236, Type = TagType.String, Offset = 5, Required = false)]
		public string? PricingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PricingDateUnadjusted is not null) writer.WriteLocalDateOnly(41232, PricingDateUnadjusted.Value);
			if (PricingDateBusinessDayConvention is not null) writer.WriteWholeNumber(41233, PricingDateBusinessDayConvention.Value);
			if (PricingDateBusinessCenterGrp is not null) ((IFixEncoder)PricingDateBusinessCenterGrp).Encode(writer);
			if (PricingDateAdjusted is not null) writer.WriteLocalDateOnly(41234, PricingDateAdjusted.Value);
			if (PricingTime is not null) writer.WriteString(41235, PricingTime);
			if (PricingTimeBusinessCenter is not null) writer.WriteString(41236, PricingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PricingDateUnadjusted = view.GetDateOnly(41232);
			PricingDateBusinessDayConvention = view.GetInt32(41233);
			if (view.GetView("PricingDateBusinessCenterGrp") is IMessageView viewPricingDateBusinessCenterGrp)
			{
				PricingDateBusinessCenterGrp = new();
				((IFixParser)PricingDateBusinessCenterGrp).Parse(viewPricingDateBusinessCenterGrp);
			}
			PricingDateAdjusted = view.GetDateOnly(41234);
			PricingTime = view.GetString(41235);
			PricingTimeBusinessCenter = view.GetString(41236);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PricingDateUnadjusted":
				{
					value = PricingDateUnadjusted;
					break;
				}
				case "PricingDateBusinessDayConvention":
				{
					value = PricingDateBusinessDayConvention;
					break;
				}
				case "PricingDateBusinessCenterGrp":
				{
					value = PricingDateBusinessCenterGrp;
					break;
				}
				case "PricingDateAdjusted":
				{
					value = PricingDateAdjusted;
					break;
				}
				case "PricingTime":
				{
					value = PricingTime;
					break;
				}
				case "PricingTimeBusinessCenter":
				{
					value = PricingTimeBusinessCenter;
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
			PricingDateUnadjusted = null;
			PricingDateBusinessDayConvention = null;
			((IFixReset?)PricingDateBusinessCenterGrp)?.Reset();
			PricingDateAdjusted = null;
			PricingTime = null;
			PricingTimeBusinessCenter = null;
		}
	}
}
