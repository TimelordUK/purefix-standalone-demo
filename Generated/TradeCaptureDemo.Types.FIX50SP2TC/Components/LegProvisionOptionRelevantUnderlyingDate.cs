using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionRelevantUnderlyingDate : IFixComponent
	{
		[TagDetails(Tag = 40508, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegProvisionOptionRelevantUnderlyingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40509, Type = TagType.Int, Offset = 1, Required = false)]
		public int? LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp? LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40511, Type = TagType.Int, Offset = 3, Required = false)]
		public int? LegProvisionOptionRelevantUnderlyingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40512, Type = TagType.Int, Offset = 4, Required = false)]
		public int? LegProvisionOptionRelevantUnderlyingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40513, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegProvisionOptionRelevantUnderlyingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40514, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegProvisionOptionRelevantUnderlyingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40515, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? LegProvisionOptionRelevantUnderlyingDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionRelevantUnderlyingDateUnadjusted is not null) writer.WriteLocalDateOnly(40508, LegProvisionOptionRelevantUnderlyingDateUnadjusted.Value);
			if (LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40509, LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention.Value);
			if (LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp is not null) ((IFixEncoder)LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Encode(writer);
			if (LegProvisionOptionRelevantUnderlyingDateRelativeTo is not null) writer.WriteWholeNumber(40511, LegProvisionOptionRelevantUnderlyingDateRelativeTo.Value);
			if (LegProvisionOptionRelevantUnderlyingDateOffsetPeriod is not null) writer.WriteWholeNumber(40512, LegProvisionOptionRelevantUnderlyingDateOffsetPeriod.Value);
			if (LegProvisionOptionRelevantUnderlyingDateOffsetUnit is not null) writer.WriteString(40513, LegProvisionOptionRelevantUnderlyingDateOffsetUnit);
			if (LegProvisionOptionRelevantUnderlyingDateOffsetDayType is not null) writer.WriteWholeNumber(40514, LegProvisionOptionRelevantUnderlyingDateOffsetDayType.Value);
			if (LegProvisionOptionRelevantUnderlyingDateAdjusted is not null) writer.WriteLocalDateOnly(40515, LegProvisionOptionRelevantUnderlyingDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegProvisionOptionRelevantUnderlyingDateUnadjusted = view.GetDateOnly(40508);
			LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention = view.GetInt32(40509);
			if (view.GetView("LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp") is IMessageView viewLegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)
			{
				LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp = new();
				((IFixParser)LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Parse(viewLegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp);
			}
			LegProvisionOptionRelevantUnderlyingDateRelativeTo = view.GetInt32(40511);
			LegProvisionOptionRelevantUnderlyingDateOffsetPeriod = view.GetInt32(40512);
			LegProvisionOptionRelevantUnderlyingDateOffsetUnit = view.GetString(40513);
			LegProvisionOptionRelevantUnderlyingDateOffsetDayType = view.GetInt32(40514);
			LegProvisionOptionRelevantUnderlyingDateAdjusted = view.GetDateOnly(40515);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegProvisionOptionRelevantUnderlyingDateUnadjusted":
				{
					value = LegProvisionOptionRelevantUnderlyingDateUnadjusted;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention":
				{
					value = LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp":
				{
					value = LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateRelativeTo":
				{
					value = LegProvisionOptionRelevantUnderlyingDateRelativeTo;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateOffsetPeriod":
				{
					value = LegProvisionOptionRelevantUnderlyingDateOffsetPeriod;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateOffsetUnit":
				{
					value = LegProvisionOptionRelevantUnderlyingDateOffsetUnit;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateOffsetDayType":
				{
					value = LegProvisionOptionRelevantUnderlyingDateOffsetDayType;
					break;
				}
				case "LegProvisionOptionRelevantUnderlyingDateAdjusted":
				{
					value = LegProvisionOptionRelevantUnderlyingDateAdjusted;
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
			LegProvisionOptionRelevantUnderlyingDateUnadjusted = null;
			LegProvisionOptionRelevantUnderlyingDateBusinessDayConvention = null;
			((IFixReset?)LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)?.Reset();
			LegProvisionOptionRelevantUnderlyingDateRelativeTo = null;
			LegProvisionOptionRelevantUnderlyingDateOffsetPeriod = null;
			LegProvisionOptionRelevantUnderlyingDateOffsetUnit = null;
			LegProvisionOptionRelevantUnderlyingDateOffsetDayType = null;
			LegProvisionOptionRelevantUnderlyingDateAdjusted = null;
		}
	}
}
