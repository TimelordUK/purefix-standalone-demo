using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionExpirationDate : IFixComponent
	{
		[TagDetails(Tag = 40145, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? ProvisionOptionExpirationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40146, Type = TagType.Int, Offset = 1, Required = false)]
		public int? ProvisionOptionExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public ProvisionOptionExpirationDateBusinessCenterGrp? ProvisionOptionExpirationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40148, Type = TagType.Int, Offset = 3, Required = false)]
		public int? ProvisionOptionExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40149, Type = TagType.Int, Offset = 4, Required = false)]
		public int? ProvisionOptionExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40150, Type = TagType.String, Offset = 5, Required = false)]
		public string? ProvisionOptionExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40151, Type = TagType.Int, Offset = 6, Required = false)]
		public int? ProvisionOptionExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40152, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? ProvisionOptionExpirationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 40153, Type = TagType.String, Offset = 8, Required = false)]
		public string? ProvisionOptionExpirationTime {get; set;}
		
		[TagDetails(Tag = 40154, Type = TagType.String, Offset = 9, Required = false)]
		public string? ProvisionOptionExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionExpirationDateUnadjusted is not null) writer.WriteLocalDateOnly(40145, ProvisionOptionExpirationDateUnadjusted.Value);
			if (ProvisionOptionExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(40146, ProvisionOptionExpirationDateBusinessDayConvention.Value);
			if (ProvisionOptionExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)ProvisionOptionExpirationDateBusinessCenterGrp).Encode(writer);
			if (ProvisionOptionExpirationDateRelativeTo is not null) writer.WriteWholeNumber(40148, ProvisionOptionExpirationDateRelativeTo.Value);
			if (ProvisionOptionExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(40149, ProvisionOptionExpirationDateOffsetPeriod.Value);
			if (ProvisionOptionExpirationDateOffsetUnit is not null) writer.WriteString(40150, ProvisionOptionExpirationDateOffsetUnit);
			if (ProvisionOptionExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(40151, ProvisionOptionExpirationDateOffsetDayType.Value);
			if (ProvisionOptionExpirationDateAdjusted is not null) writer.WriteLocalDateOnly(40152, ProvisionOptionExpirationDateAdjusted.Value);
			if (ProvisionOptionExpirationTime is not null) writer.WriteString(40153, ProvisionOptionExpirationTime);
			if (ProvisionOptionExpirationTimeBusinessCenter is not null) writer.WriteString(40154, ProvisionOptionExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionOptionExpirationDateUnadjusted = view.GetDateOnly(40145);
			ProvisionOptionExpirationDateBusinessDayConvention = view.GetInt32(40146);
			if (view.GetView("ProvisionOptionExpirationDateBusinessCenterGrp") is IMessageView viewProvisionOptionExpirationDateBusinessCenterGrp)
			{
				ProvisionOptionExpirationDateBusinessCenterGrp = new();
				((IFixParser)ProvisionOptionExpirationDateBusinessCenterGrp).Parse(viewProvisionOptionExpirationDateBusinessCenterGrp);
			}
			ProvisionOptionExpirationDateRelativeTo = view.GetInt32(40148);
			ProvisionOptionExpirationDateOffsetPeriod = view.GetInt32(40149);
			ProvisionOptionExpirationDateOffsetUnit = view.GetString(40150);
			ProvisionOptionExpirationDateOffsetDayType = view.GetInt32(40151);
			ProvisionOptionExpirationDateAdjusted = view.GetDateOnly(40152);
			ProvisionOptionExpirationTime = view.GetString(40153);
			ProvisionOptionExpirationTimeBusinessCenter = view.GetString(40154);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionOptionExpirationDateUnadjusted":
				{
					value = ProvisionOptionExpirationDateUnadjusted;
					break;
				}
				case "ProvisionOptionExpirationDateBusinessDayConvention":
				{
					value = ProvisionOptionExpirationDateBusinessDayConvention;
					break;
				}
				case "ProvisionOptionExpirationDateBusinessCenterGrp":
				{
					value = ProvisionOptionExpirationDateBusinessCenterGrp;
					break;
				}
				case "ProvisionOptionExpirationDateRelativeTo":
				{
					value = ProvisionOptionExpirationDateRelativeTo;
					break;
				}
				case "ProvisionOptionExpirationDateOffsetPeriod":
				{
					value = ProvisionOptionExpirationDateOffsetPeriod;
					break;
				}
				case "ProvisionOptionExpirationDateOffsetUnit":
				{
					value = ProvisionOptionExpirationDateOffsetUnit;
					break;
				}
				case "ProvisionOptionExpirationDateOffsetDayType":
				{
					value = ProvisionOptionExpirationDateOffsetDayType;
					break;
				}
				case "ProvisionOptionExpirationDateAdjusted":
				{
					value = ProvisionOptionExpirationDateAdjusted;
					break;
				}
				case "ProvisionOptionExpirationTime":
				{
					value = ProvisionOptionExpirationTime;
					break;
				}
				case "ProvisionOptionExpirationTimeBusinessCenter":
				{
					value = ProvisionOptionExpirationTimeBusinessCenter;
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
			ProvisionOptionExpirationDateUnadjusted = null;
			ProvisionOptionExpirationDateBusinessDayConvention = null;
			((IFixReset?)ProvisionOptionExpirationDateBusinessCenterGrp)?.Reset();
			ProvisionOptionExpirationDateRelativeTo = null;
			ProvisionOptionExpirationDateOffsetPeriod = null;
			ProvisionOptionExpirationDateOffsetUnit = null;
			ProvisionOptionExpirationDateOffsetDayType = null;
			ProvisionOptionExpirationDateAdjusted = null;
			ProvisionOptionExpirationTime = null;
			ProvisionOptionExpirationTimeBusinessCenter = null;
		}
	}
}
