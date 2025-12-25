using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionExpirationDate : IFixComponent
	{
		[TagDetails(Tag = 40498, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegProvisionOptionExpirationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40499, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegProvisionOptionExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegProvisionOptionExpirationDateBusinessCenterGrp? LegProvisionOptionExpirationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40501, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegProvisionOptionExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40502, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegProvisionOptionExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40503, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegProvisionOptionExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40504, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegProvisionOptionExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40505, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegProvisionOptionExpirationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40506, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegProvisionOptionExpirationTime {get; set;}
		
		[TagDetails(Tag = 40507, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegProvisionOptionExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionExpirationDateUnadjusted is not null) writer.WriteLocalDateOnly(40498, LegProvisionOptionExpirationDateUnadjusted.Value);
			if (LegProvisionOptionExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(40499, LegProvisionOptionExpirationDateBusinessDayConvention.Value);
			if (LegProvisionOptionExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionOptionExpirationDateBusinessCenterGrp).Encode(writer);
			if (LegProvisionOptionExpirationDateRelativeTo is not null) writer.WriteWholeNumber(40501, LegProvisionOptionExpirationDateRelativeTo.Value);
			if (LegProvisionOptionExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(40502, LegProvisionOptionExpirationDateOffsetPeriod.Value);
			if (LegProvisionOptionExpirationDateOffsetUnit is not null) writer.WriteString(40503, LegProvisionOptionExpirationDateOffsetUnit);
			if (LegProvisionOptionExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(40504, LegProvisionOptionExpirationDateOffsetDayType.Value);
			if (LegProvisionOptionExpirationDateAdjusted is not null) writer.WriteLocalDateOnly(40505, LegProvisionOptionExpirationDateAdjusted.Value);
			if (LegProvisionOptionExpirationTime is not null) writer.WriteString(40506, LegProvisionOptionExpirationTime);
			if (LegProvisionOptionExpirationTimeBusinessCenter is not null) writer.WriteString(40507, LegProvisionOptionExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegProvisionOptionExpirationDateUnadjusted = view.GetDateOnly(40498);
			LegProvisionOptionExpirationDateBusinessDayConvention = view.GetInt32(40499);
			if (view.GetView("LegProvisionOptionExpirationDateBusinessCenterGrp") is IMessageView viewLegProvisionOptionExpirationDateBusinessCenterGrp)
			{
				LegProvisionOptionExpirationDateBusinessCenterGrp = new();
				((IFixParser)LegProvisionOptionExpirationDateBusinessCenterGrp).Parse(viewLegProvisionOptionExpirationDateBusinessCenterGrp);
			}
			LegProvisionOptionExpirationDateRelativeTo = view.GetInt32(40501);
			LegProvisionOptionExpirationDateOffsetPeriod = view.GetInt32(40502);
			LegProvisionOptionExpirationDateOffsetUnit = view.GetString(40503);
			LegProvisionOptionExpirationDateOffsetDayType = view.GetInt32(40504);
			LegProvisionOptionExpirationDateAdjusted = view.GetDateOnly(40505);
			LegProvisionOptionExpirationTime = view.GetString(40506);
			LegProvisionOptionExpirationTimeBusinessCenter = view.GetString(40507);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegProvisionOptionExpirationDateUnadjusted":
				{
					value = LegProvisionOptionExpirationDateUnadjusted;
					break;
				}
				case "LegProvisionOptionExpirationDateBusinessDayConvention":
				{
					value = LegProvisionOptionExpirationDateBusinessDayConvention;
					break;
				}
				case "LegProvisionOptionExpirationDateBusinessCenterGrp":
				{
					value = LegProvisionOptionExpirationDateBusinessCenterGrp;
					break;
				}
				case "LegProvisionOptionExpirationDateRelativeTo":
				{
					value = LegProvisionOptionExpirationDateRelativeTo;
					break;
				}
				case "LegProvisionOptionExpirationDateOffsetPeriod":
				{
					value = LegProvisionOptionExpirationDateOffsetPeriod;
					break;
				}
				case "LegProvisionOptionExpirationDateOffsetUnit":
				{
					value = LegProvisionOptionExpirationDateOffsetUnit;
					break;
				}
				case "LegProvisionOptionExpirationDateOffsetDayType":
				{
					value = LegProvisionOptionExpirationDateOffsetDayType;
					break;
				}
				case "LegProvisionOptionExpirationDateAdjusted":
				{
					value = LegProvisionOptionExpirationDateAdjusted;
					break;
				}
				case "LegProvisionOptionExpirationTime":
				{
					value = LegProvisionOptionExpirationTime;
					break;
				}
				case "LegProvisionOptionExpirationTimeBusinessCenter":
				{
					value = LegProvisionOptionExpirationTimeBusinessCenter;
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
			LegProvisionOptionExpirationDateUnadjusted = null;
			LegProvisionOptionExpirationDateBusinessDayConvention = null;
			((IFixReset?)LegProvisionOptionExpirationDateBusinessCenterGrp)?.Reset();
			LegProvisionOptionExpirationDateRelativeTo = null;
			LegProvisionOptionExpirationDateOffsetPeriod = null;
			LegProvisionOptionExpirationDateOffsetUnit = null;
			LegProvisionOptionExpirationDateOffsetDayType = null;
			LegProvisionOptionExpirationDateAdjusted = null;
			LegProvisionOptionExpirationTime = null;
			LegProvisionOptionExpirationTimeBusinessCenter = null;
		}
	}
}
