using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamEffectiveDate : IFixComponent
	{
		[TagDetails(Tag = 40907, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? StreamEffectiveDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40908, Type = TagType.Int, Offset = 1, Required = false)]
		public int? StreamEffectiveDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public StreamEffectiveDateBusinessCenterGrp? StreamEffectiveDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40910, Type = TagType.Int, Offset = 3, Required = false)]
		public int? StreamEffectiveDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40911, Type = TagType.Int, Offset = 4, Required = false)]
		public int? StreamEffectiveDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40912, Type = TagType.String, Offset = 5, Required = false)]
		public string? StreamEffectiveDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40913, Type = TagType.Int, Offset = 6, Required = false)]
		public int? StreamEffectiveDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40914, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? StreamEffectiveDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamEffectiveDateUnadjusted is not null) writer.WriteLocalDateOnly(40907, StreamEffectiveDateUnadjusted.Value);
			if (StreamEffectiveDateBusinessDayConvention is not null) writer.WriteWholeNumber(40908, StreamEffectiveDateBusinessDayConvention.Value);
			if (StreamEffectiveDateBusinessCenterGrp is not null) ((IFixEncoder)StreamEffectiveDateBusinessCenterGrp).Encode(writer);
			if (StreamEffectiveDateRelativeTo is not null) writer.WriteWholeNumber(40910, StreamEffectiveDateRelativeTo.Value);
			if (StreamEffectiveDateOffsetPeriod is not null) writer.WriteWholeNumber(40911, StreamEffectiveDateOffsetPeriod.Value);
			if (StreamEffectiveDateOffsetUnit is not null) writer.WriteString(40912, StreamEffectiveDateOffsetUnit);
			if (StreamEffectiveDateOffsetDayType is not null) writer.WriteWholeNumber(40913, StreamEffectiveDateOffsetDayType.Value);
			if (StreamEffectiveDateAdjusted is not null) writer.WriteLocalDateOnly(40914, StreamEffectiveDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			StreamEffectiveDateUnadjusted = view.GetDateOnly(40907);
			StreamEffectiveDateBusinessDayConvention = view.GetInt32(40908);
			if (view.GetView("StreamEffectiveDateBusinessCenterGrp") is IMessageView viewStreamEffectiveDateBusinessCenterGrp)
			{
				StreamEffectiveDateBusinessCenterGrp = new();
				((IFixParser)StreamEffectiveDateBusinessCenterGrp).Parse(viewStreamEffectiveDateBusinessCenterGrp);
			}
			StreamEffectiveDateRelativeTo = view.GetInt32(40910);
			StreamEffectiveDateOffsetPeriod = view.GetInt32(40911);
			StreamEffectiveDateOffsetUnit = view.GetString(40912);
			StreamEffectiveDateOffsetDayType = view.GetInt32(40913);
			StreamEffectiveDateAdjusted = view.GetDateOnly(40914);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StreamEffectiveDateUnadjusted":
				{
					value = StreamEffectiveDateUnadjusted;
					break;
				}
				case "StreamEffectiveDateBusinessDayConvention":
				{
					value = StreamEffectiveDateBusinessDayConvention;
					break;
				}
				case "StreamEffectiveDateBusinessCenterGrp":
				{
					value = StreamEffectiveDateBusinessCenterGrp;
					break;
				}
				case "StreamEffectiveDateRelativeTo":
				{
					value = StreamEffectiveDateRelativeTo;
					break;
				}
				case "StreamEffectiveDateOffsetPeriod":
				{
					value = StreamEffectiveDateOffsetPeriod;
					break;
				}
				case "StreamEffectiveDateOffsetUnit":
				{
					value = StreamEffectiveDateOffsetUnit;
					break;
				}
				case "StreamEffectiveDateOffsetDayType":
				{
					value = StreamEffectiveDateOffsetDayType;
					break;
				}
				case "StreamEffectiveDateAdjusted":
				{
					value = StreamEffectiveDateAdjusted;
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
			StreamEffectiveDateUnadjusted = null;
			StreamEffectiveDateBusinessDayConvention = null;
			((IFixReset?)StreamEffectiveDateBusinessCenterGrp)?.Reset();
			StreamEffectiveDateRelativeTo = null;
			StreamEffectiveDateOffsetPeriod = null;
			StreamEffectiveDateOffsetUnit = null;
			StreamEffectiveDateOffsetDayType = null;
			StreamEffectiveDateAdjusted = null;
		}
	}
}
