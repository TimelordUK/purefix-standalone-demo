using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPricingDateTime : IFixComponent
	{
		[TagDetails(Tag = 41949, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingPricingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41950, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingPricingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingPricingDateBusinessCenterGrp? UnderlyingPricingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41951, Type = TagType.LocalDate, Offset = 3, Required = false)]
		public DateOnly? UnderlyingPricingDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41952, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingPricingTime {get; set;}
		
		[TagDetails(Tag = 41953, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingPricingTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPricingDateUnadjusted is not null) writer.WriteLocalDateOnly(41949, UnderlyingPricingDateUnadjusted.Value);
			if (UnderlyingPricingDateBusinessDayConvention is not null) writer.WriteWholeNumber(41950, UnderlyingPricingDateBusinessDayConvention.Value);
			if (UnderlyingPricingDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingPricingDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingPricingDateAdjusted is not null) writer.WriteLocalDateOnly(41951, UnderlyingPricingDateAdjusted.Value);
			if (UnderlyingPricingTime is not null) writer.WriteString(41952, UnderlyingPricingTime);
			if (UnderlyingPricingTimeBusinessCenter is not null) writer.WriteString(41953, UnderlyingPricingTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPricingDateUnadjusted = view.GetDateOnly(41949);
			UnderlyingPricingDateBusinessDayConvention = view.GetInt32(41950);
			if (view.GetView("UnderlyingPricingDateBusinessCenterGrp") is IMessageView viewUnderlyingPricingDateBusinessCenterGrp)
			{
				UnderlyingPricingDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingPricingDateBusinessCenterGrp).Parse(viewUnderlyingPricingDateBusinessCenterGrp);
			}
			UnderlyingPricingDateAdjusted = view.GetDateOnly(41951);
			UnderlyingPricingTime = view.GetString(41952);
			UnderlyingPricingTimeBusinessCenter = view.GetString(41953);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPricingDateUnadjusted":
				{
					value = UnderlyingPricingDateUnadjusted;
					break;
				}
				case "UnderlyingPricingDateBusinessDayConvention":
				{
					value = UnderlyingPricingDateBusinessDayConvention;
					break;
				}
				case "UnderlyingPricingDateBusinessCenterGrp":
				{
					value = UnderlyingPricingDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingPricingDateAdjusted":
				{
					value = UnderlyingPricingDateAdjusted;
					break;
				}
				case "UnderlyingPricingTime":
				{
					value = UnderlyingPricingTime;
					break;
				}
				case "UnderlyingPricingTimeBusinessCenter":
				{
					value = UnderlyingPricingTimeBusinessCenter;
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
			UnderlyingPricingDateUnadjusted = null;
			UnderlyingPricingDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingPricingDateBusinessCenterGrp)?.Reset();
			UnderlyingPricingDateAdjusted = null;
			UnderlyingPricingTime = null;
			UnderlyingPricingTimeBusinessCenter = null;
		}
	}
}
