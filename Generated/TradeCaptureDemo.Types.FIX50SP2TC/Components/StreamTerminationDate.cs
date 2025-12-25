using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamTerminationDate : IFixComponent
	{
		[TagDetails(Tag = 40065, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? StreamTerminationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40066, Type = TagType.Int, Offset = 1, Required = false)]
		public int? StreamTerminationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public StreamTerminationDateBusinessCenterGrp? StreamTerminationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40068, Type = TagType.Int, Offset = 3, Required = false)]
		public int? StreamTerminationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40069, Type = TagType.Int, Offset = 4, Required = false)]
		public int? StreamTerminationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40070, Type = TagType.String, Offset = 5, Required = false)]
		public string? StreamTerminationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40071, Type = TagType.Int, Offset = 6, Required = false)]
		public int? StreamTerminationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40072, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? StreamTerminationDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamTerminationDateUnadjusted is not null) writer.WriteLocalDateOnly(40065, StreamTerminationDateUnadjusted.Value);
			if (StreamTerminationDateBusinessDayConvention is not null) writer.WriteWholeNumber(40066, StreamTerminationDateBusinessDayConvention.Value);
			if (StreamTerminationDateBusinessCenterGrp is not null) ((IFixEncoder)StreamTerminationDateBusinessCenterGrp).Encode(writer);
			if (StreamTerminationDateRelativeTo is not null) writer.WriteWholeNumber(40068, StreamTerminationDateRelativeTo.Value);
			if (StreamTerminationDateOffsetPeriod is not null) writer.WriteWholeNumber(40069, StreamTerminationDateOffsetPeriod.Value);
			if (StreamTerminationDateOffsetUnit is not null) writer.WriteString(40070, StreamTerminationDateOffsetUnit);
			if (StreamTerminationDateOffsetDayType is not null) writer.WriteWholeNumber(40071, StreamTerminationDateOffsetDayType.Value);
			if (StreamTerminationDateAdjusted is not null) writer.WriteLocalDateOnly(40072, StreamTerminationDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			StreamTerminationDateUnadjusted = view.GetDateOnly(40065);
			StreamTerminationDateBusinessDayConvention = view.GetInt32(40066);
			if (view.GetView("StreamTerminationDateBusinessCenterGrp") is IMessageView viewStreamTerminationDateBusinessCenterGrp)
			{
				StreamTerminationDateBusinessCenterGrp = new();
				((IFixParser)StreamTerminationDateBusinessCenterGrp).Parse(viewStreamTerminationDateBusinessCenterGrp);
			}
			StreamTerminationDateRelativeTo = view.GetInt32(40068);
			StreamTerminationDateOffsetPeriod = view.GetInt32(40069);
			StreamTerminationDateOffsetUnit = view.GetString(40070);
			StreamTerminationDateOffsetDayType = view.GetInt32(40071);
			StreamTerminationDateAdjusted = view.GetDateOnly(40072);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StreamTerminationDateUnadjusted":
				{
					value = StreamTerminationDateUnadjusted;
					break;
				}
				case "StreamTerminationDateBusinessDayConvention":
				{
					value = StreamTerminationDateBusinessDayConvention;
					break;
				}
				case "StreamTerminationDateBusinessCenterGrp":
				{
					value = StreamTerminationDateBusinessCenterGrp;
					break;
				}
				case "StreamTerminationDateRelativeTo":
				{
					value = StreamTerminationDateRelativeTo;
					break;
				}
				case "StreamTerminationDateOffsetPeriod":
				{
					value = StreamTerminationDateOffsetPeriod;
					break;
				}
				case "StreamTerminationDateOffsetUnit":
				{
					value = StreamTerminationDateOffsetUnit;
					break;
				}
				case "StreamTerminationDateOffsetDayType":
				{
					value = StreamTerminationDateOffsetDayType;
					break;
				}
				case "StreamTerminationDateAdjusted":
				{
					value = StreamTerminationDateAdjusted;
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
			StreamTerminationDateUnadjusted = null;
			StreamTerminationDateBusinessDayConvention = null;
			((IFixReset?)StreamTerminationDateBusinessCenterGrp)?.Reset();
			StreamTerminationDateRelativeTo = null;
			StreamTerminationDateOffsetPeriod = null;
			StreamTerminationDateOffsetUnit = null;
			StreamTerminationDateOffsetDayType = null;
			StreamTerminationDateAdjusted = null;
		}
	}
}
