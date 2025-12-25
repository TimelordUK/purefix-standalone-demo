using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionExpirationDate : IFixComponent
	{
		[TagDetails(Tag = 42133, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExpirationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42134, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingProvisionOptionExpirationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingProvisionOptionExpirationDateBusinessCenterGrp? UnderlyingProvisionOptionExpirationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42135, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingProvisionOptionExpirationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42136, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingProvisionOptionExpirationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42137, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingProvisionOptionExpirationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42138, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingProvisionOptionExpirationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42139, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingProvisionOptionExpirationDateAdjusted {get; set;}
		
		[TagDetails(Tag = 42140, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingProvisionOptionExpirationTime {get; set;}
		
		[TagDetails(Tag = 42141, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingProvisionOptionExpirationTimeBusinessCenter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionExpirationDateUnadjusted is not null) writer.WriteLocalDateOnly(42133, UnderlyingProvisionOptionExpirationDateUnadjusted.Value);
			if (UnderlyingProvisionOptionExpirationDateBusinessDayConvention is not null) writer.WriteWholeNumber(42134, UnderlyingProvisionOptionExpirationDateBusinessDayConvention.Value);
			if (UnderlyingProvisionOptionExpirationDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionOptionExpirationDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingProvisionOptionExpirationDateRelativeTo is not null) writer.WriteWholeNumber(42135, UnderlyingProvisionOptionExpirationDateRelativeTo.Value);
			if (UnderlyingProvisionOptionExpirationDateOffsetPeriod is not null) writer.WriteWholeNumber(42136, UnderlyingProvisionOptionExpirationDateOffsetPeriod.Value);
			if (UnderlyingProvisionOptionExpirationDateOffsetUnit is not null) writer.WriteString(42137, UnderlyingProvisionOptionExpirationDateOffsetUnit);
			if (UnderlyingProvisionOptionExpirationDateOffsetDayType is not null) writer.WriteWholeNumber(42138, UnderlyingProvisionOptionExpirationDateOffsetDayType.Value);
			if (UnderlyingProvisionOptionExpirationDateAdjusted is not null) writer.WriteLocalDateOnly(42139, UnderlyingProvisionOptionExpirationDateAdjusted.Value);
			if (UnderlyingProvisionOptionExpirationTime is not null) writer.WriteString(42140, UnderlyingProvisionOptionExpirationTime);
			if (UnderlyingProvisionOptionExpirationTimeBusinessCenter is not null) writer.WriteString(42141, UnderlyingProvisionOptionExpirationTimeBusinessCenter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingProvisionOptionExpirationDateUnadjusted = view.GetDateOnly(42133);
			UnderlyingProvisionOptionExpirationDateBusinessDayConvention = view.GetInt32(42134);
			if (view.GetView("UnderlyingProvisionOptionExpirationDateBusinessCenterGrp") is IMessageView viewUnderlyingProvisionOptionExpirationDateBusinessCenterGrp)
			{
				UnderlyingProvisionOptionExpirationDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingProvisionOptionExpirationDateBusinessCenterGrp).Parse(viewUnderlyingProvisionOptionExpirationDateBusinessCenterGrp);
			}
			UnderlyingProvisionOptionExpirationDateRelativeTo = view.GetInt32(42135);
			UnderlyingProvisionOptionExpirationDateOffsetPeriod = view.GetInt32(42136);
			UnderlyingProvisionOptionExpirationDateOffsetUnit = view.GetString(42137);
			UnderlyingProvisionOptionExpirationDateOffsetDayType = view.GetInt32(42138);
			UnderlyingProvisionOptionExpirationDateAdjusted = view.GetDateOnly(42139);
			UnderlyingProvisionOptionExpirationTime = view.GetString(42140);
			UnderlyingProvisionOptionExpirationTimeBusinessCenter = view.GetString(42141);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingProvisionOptionExpirationDateUnadjusted":
				{
					value = UnderlyingProvisionOptionExpirationDateUnadjusted;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateBusinessDayConvention":
				{
					value = UnderlyingProvisionOptionExpirationDateBusinessDayConvention;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateBusinessCenterGrp":
				{
					value = UnderlyingProvisionOptionExpirationDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateRelativeTo":
				{
					value = UnderlyingProvisionOptionExpirationDateRelativeTo;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateOffsetPeriod":
				{
					value = UnderlyingProvisionOptionExpirationDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateOffsetUnit":
				{
					value = UnderlyingProvisionOptionExpirationDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateOffsetDayType":
				{
					value = UnderlyingProvisionOptionExpirationDateOffsetDayType;
					break;
				}
				case "UnderlyingProvisionOptionExpirationDateAdjusted":
				{
					value = UnderlyingProvisionOptionExpirationDateAdjusted;
					break;
				}
				case "UnderlyingProvisionOptionExpirationTime":
				{
					value = UnderlyingProvisionOptionExpirationTime;
					break;
				}
				case "UnderlyingProvisionOptionExpirationTimeBusinessCenter":
				{
					value = UnderlyingProvisionOptionExpirationTimeBusinessCenter;
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
			UnderlyingProvisionOptionExpirationDateUnadjusted = null;
			UnderlyingProvisionOptionExpirationDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingProvisionOptionExpirationDateBusinessCenterGrp)?.Reset();
			UnderlyingProvisionOptionExpirationDateRelativeTo = null;
			UnderlyingProvisionOptionExpirationDateOffsetPeriod = null;
			UnderlyingProvisionOptionExpirationDateOffsetUnit = null;
			UnderlyingProvisionOptionExpirationDateOffsetDayType = null;
			UnderlyingProvisionOptionExpirationDateAdjusted = null;
			UnderlyingProvisionOptionExpirationTime = null;
			UnderlyingProvisionOptionExpirationTimeBusinessCenter = null;
		}
	}
}
