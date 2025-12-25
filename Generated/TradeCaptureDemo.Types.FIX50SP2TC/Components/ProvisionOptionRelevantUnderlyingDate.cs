using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionRelevantUnderlyingDate : IFixComponent
	{
		[TagDetails(Tag = 40155, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? ProvisionOptionRelevantUnderlyingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40156, Type = TagType.Int, Offset = 1, Required = false)]
		public int? ProvisionOptionRelevantUnderlyingDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp? ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40158, Type = TagType.Int, Offset = 3, Required = false)]
		public int? ProvisionOptionRelevantUnderlyingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40159, Type = TagType.Int, Offset = 4, Required = false)]
		public int? ProvisionOptionRelevantUnderlyingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40160, Type = TagType.String, Offset = 5, Required = false)]
		public string? ProvisionOptionRelevantUnderlyingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40161, Type = TagType.Int, Offset = 6, Required = false)]
		public int? ProvisionOptionRelevantUnderlyingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40162, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ProvisionOptionRelevantUnderlyingDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionRelevantUnderlyingDateUnadjusted is not null) writer.WriteLocalDateOnly(40155, ProvisionOptionRelevantUnderlyingDateUnadjusted.Value);
			if (ProvisionOptionRelevantUnderlyingDateBusinessDayConvention is not null) writer.WriteWholeNumber(40156, ProvisionOptionRelevantUnderlyingDateBusinessDayConvention.Value);
			if (ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp is not null) ((IFixEncoder)ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Encode(writer);
			if (ProvisionOptionRelevantUnderlyingDateRelativeTo is not null) writer.WriteWholeNumber(40158, ProvisionOptionRelevantUnderlyingDateRelativeTo.Value);
			if (ProvisionOptionRelevantUnderlyingDateOffsetPeriod is not null) writer.WriteWholeNumber(40159, ProvisionOptionRelevantUnderlyingDateOffsetPeriod.Value);
			if (ProvisionOptionRelevantUnderlyingDateOffsetUnit is not null) writer.WriteString(40160, ProvisionOptionRelevantUnderlyingDateOffsetUnit);
			if (ProvisionOptionRelevantUnderlyingDateOffsetDayType is not null) writer.WriteWholeNumber(40161, ProvisionOptionRelevantUnderlyingDateOffsetDayType.Value);
			if (ProvisionOptionRelevantUnderlyingDateAdjusted is not null) writer.WriteLocalDateOnly(40162, ProvisionOptionRelevantUnderlyingDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionOptionRelevantUnderlyingDateUnadjusted = view.GetDateOnly(40155);
			ProvisionOptionRelevantUnderlyingDateBusinessDayConvention = view.GetInt32(40156);
			if (view.GetView("ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp") is IMessageView viewProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)
			{
				ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp = new();
				((IFixParser)ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Parse(viewProvisionOptionRelevantUnderlyingDateBusinessCenterGrp);
			}
			ProvisionOptionRelevantUnderlyingDateRelativeTo = view.GetInt32(40158);
			ProvisionOptionRelevantUnderlyingDateOffsetPeriod = view.GetInt32(40159);
			ProvisionOptionRelevantUnderlyingDateOffsetUnit = view.GetString(40160);
			ProvisionOptionRelevantUnderlyingDateOffsetDayType = view.GetInt32(40161);
			ProvisionOptionRelevantUnderlyingDateAdjusted = view.GetDateOnly(40162);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionOptionRelevantUnderlyingDateUnadjusted":
				{
					value = ProvisionOptionRelevantUnderlyingDateUnadjusted;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateBusinessDayConvention":
				{
					value = ProvisionOptionRelevantUnderlyingDateBusinessDayConvention;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp":
				{
					value = ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateRelativeTo":
				{
					value = ProvisionOptionRelevantUnderlyingDateRelativeTo;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateOffsetPeriod":
				{
					value = ProvisionOptionRelevantUnderlyingDateOffsetPeriod;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateOffsetUnit":
				{
					value = ProvisionOptionRelevantUnderlyingDateOffsetUnit;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateOffsetDayType":
				{
					value = ProvisionOptionRelevantUnderlyingDateOffsetDayType;
					break;
				}
				case "ProvisionOptionRelevantUnderlyingDateAdjusted":
				{
					value = ProvisionOptionRelevantUnderlyingDateAdjusted;
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
			ProvisionOptionRelevantUnderlyingDateUnadjusted = null;
			ProvisionOptionRelevantUnderlyingDateBusinessDayConvention = null;
			((IFixReset?)ProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)?.Reset();
			ProvisionOptionRelevantUnderlyingDateRelativeTo = null;
			ProvisionOptionRelevantUnderlyingDateOffsetPeriod = null;
			ProvisionOptionRelevantUnderlyingDateOffsetUnit = null;
			ProvisionOptionRelevantUnderlyingDateOffsetDayType = null;
			ProvisionOptionRelevantUnderlyingDateAdjusted = null;
		}
	}
}
