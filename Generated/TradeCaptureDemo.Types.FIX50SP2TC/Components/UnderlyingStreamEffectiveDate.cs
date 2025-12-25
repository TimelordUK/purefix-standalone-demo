using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamEffectiveDate : IFixComponent
	{
		[TagDetails(Tag = 40057, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingStreamEffectiveDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40058, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingStreamEffectiveDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingStreamEffectiveDateBusinessCenterGrp? UnderlyingStreamEffectiveDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40060, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingStreamEffectiveDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40061, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingStreamEffectiveDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40062, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingStreamEffectiveDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40063, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingStreamEffectiveDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40064, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingStreamEffectiveDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamEffectiveDateUnadjusted is not null) writer.WriteLocalDateOnly(40057, UnderlyingStreamEffectiveDateUnadjusted.Value);
			if (UnderlyingStreamEffectiveDateBusinessDayConvention is not null) writer.WriteWholeNumber(40058, UnderlyingStreamEffectiveDateBusinessDayConvention.Value);
			if (UnderlyingStreamEffectiveDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingStreamEffectiveDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingStreamEffectiveDateRelativeTo is not null) writer.WriteWholeNumber(40060, UnderlyingStreamEffectiveDateRelativeTo.Value);
			if (UnderlyingStreamEffectiveDateOffsetPeriod is not null) writer.WriteWholeNumber(40061, UnderlyingStreamEffectiveDateOffsetPeriod.Value);
			if (UnderlyingStreamEffectiveDateOffsetUnit is not null) writer.WriteString(40062, UnderlyingStreamEffectiveDateOffsetUnit);
			if (UnderlyingStreamEffectiveDateOffsetDayType is not null) writer.WriteWholeNumber(40063, UnderlyingStreamEffectiveDateOffsetDayType.Value);
			if (UnderlyingStreamEffectiveDateAdjusted is not null) writer.WriteLocalDateOnly(40064, UnderlyingStreamEffectiveDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingStreamEffectiveDateUnadjusted = view.GetDateOnly(40057);
			UnderlyingStreamEffectiveDateBusinessDayConvention = view.GetInt32(40058);
			if (view.GetView("UnderlyingStreamEffectiveDateBusinessCenterGrp") is IMessageView viewUnderlyingStreamEffectiveDateBusinessCenterGrp)
			{
				UnderlyingStreamEffectiveDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingStreamEffectiveDateBusinessCenterGrp).Parse(viewUnderlyingStreamEffectiveDateBusinessCenterGrp);
			}
			UnderlyingStreamEffectiveDateRelativeTo = view.GetInt32(40060);
			UnderlyingStreamEffectiveDateOffsetPeriod = view.GetInt32(40061);
			UnderlyingStreamEffectiveDateOffsetUnit = view.GetString(40062);
			UnderlyingStreamEffectiveDateOffsetDayType = view.GetInt32(40063);
			UnderlyingStreamEffectiveDateAdjusted = view.GetDateOnly(40064);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingStreamEffectiveDateUnadjusted":
				{
					value = UnderlyingStreamEffectiveDateUnadjusted;
					break;
				}
				case "UnderlyingStreamEffectiveDateBusinessDayConvention":
				{
					value = UnderlyingStreamEffectiveDateBusinessDayConvention;
					break;
				}
				case "UnderlyingStreamEffectiveDateBusinessCenterGrp":
				{
					value = UnderlyingStreamEffectiveDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingStreamEffectiveDateRelativeTo":
				{
					value = UnderlyingStreamEffectiveDateRelativeTo;
					break;
				}
				case "UnderlyingStreamEffectiveDateOffsetPeriod":
				{
					value = UnderlyingStreamEffectiveDateOffsetPeriod;
					break;
				}
				case "UnderlyingStreamEffectiveDateOffsetUnit":
				{
					value = UnderlyingStreamEffectiveDateOffsetUnit;
					break;
				}
				case "UnderlyingStreamEffectiveDateOffsetDayType":
				{
					value = UnderlyingStreamEffectiveDateOffsetDayType;
					break;
				}
				case "UnderlyingStreamEffectiveDateAdjusted":
				{
					value = UnderlyingStreamEffectiveDateAdjusted;
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
			UnderlyingStreamEffectiveDateUnadjusted = null;
			UnderlyingStreamEffectiveDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingStreamEffectiveDateBusinessCenterGrp)?.Reset();
			UnderlyingStreamEffectiveDateRelativeTo = null;
			UnderlyingStreamEffectiveDateOffsetPeriod = null;
			UnderlyingStreamEffectiveDateOffsetUnit = null;
			UnderlyingStreamEffectiveDateOffsetDayType = null;
			UnderlyingStreamEffectiveDateAdjusted = null;
		}
	}
}
