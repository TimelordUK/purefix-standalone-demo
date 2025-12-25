using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamTerminationDate : IFixComponent
	{
		[TagDetails(Tag = 40548, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingStreamTerminationDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 40549, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingStreamTerminationDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingStreamTerminationDateBusinessCenterGrp? UnderlyingStreamTerminationDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40551, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingStreamTerminationDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 40552, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingStreamTerminationDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 40553, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingStreamTerminationDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 40554, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingStreamTerminationDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 40555, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingStreamTerminationDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamTerminationDateUnadjusted is not null) writer.WriteLocalDateOnly(40548, UnderlyingStreamTerminationDateUnadjusted.Value);
			if (UnderlyingStreamTerminationDateBusinessDayConvention is not null) writer.WriteWholeNumber(40549, UnderlyingStreamTerminationDateBusinessDayConvention.Value);
			if (UnderlyingStreamTerminationDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingStreamTerminationDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingStreamTerminationDateRelativeTo is not null) writer.WriteWholeNumber(40551, UnderlyingStreamTerminationDateRelativeTo.Value);
			if (UnderlyingStreamTerminationDateOffsetPeriod is not null) writer.WriteWholeNumber(40552, UnderlyingStreamTerminationDateOffsetPeriod.Value);
			if (UnderlyingStreamTerminationDateOffsetUnit is not null) writer.WriteString(40553, UnderlyingStreamTerminationDateOffsetUnit);
			if (UnderlyingStreamTerminationDateOffsetDayType is not null) writer.WriteWholeNumber(40554, UnderlyingStreamTerminationDateOffsetDayType.Value);
			if (UnderlyingStreamTerminationDateAdjusted is not null) writer.WriteLocalDateOnly(40555, UnderlyingStreamTerminationDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingStreamTerminationDateUnadjusted = view.GetDateOnly(40548);
			UnderlyingStreamTerminationDateBusinessDayConvention = view.GetInt32(40549);
			if (view.GetView("UnderlyingStreamTerminationDateBusinessCenterGrp") is IMessageView viewUnderlyingStreamTerminationDateBusinessCenterGrp)
			{
				UnderlyingStreamTerminationDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingStreamTerminationDateBusinessCenterGrp).Parse(viewUnderlyingStreamTerminationDateBusinessCenterGrp);
			}
			UnderlyingStreamTerminationDateRelativeTo = view.GetInt32(40551);
			UnderlyingStreamTerminationDateOffsetPeriod = view.GetInt32(40552);
			UnderlyingStreamTerminationDateOffsetUnit = view.GetString(40553);
			UnderlyingStreamTerminationDateOffsetDayType = view.GetInt32(40554);
			UnderlyingStreamTerminationDateAdjusted = view.GetDateOnly(40555);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingStreamTerminationDateUnadjusted":
				{
					value = UnderlyingStreamTerminationDateUnadjusted;
					break;
				}
				case "UnderlyingStreamTerminationDateBusinessDayConvention":
				{
					value = UnderlyingStreamTerminationDateBusinessDayConvention;
					break;
				}
				case "UnderlyingStreamTerminationDateBusinessCenterGrp":
				{
					value = UnderlyingStreamTerminationDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingStreamTerminationDateRelativeTo":
				{
					value = UnderlyingStreamTerminationDateRelativeTo;
					break;
				}
				case "UnderlyingStreamTerminationDateOffsetPeriod":
				{
					value = UnderlyingStreamTerminationDateOffsetPeriod;
					break;
				}
				case "UnderlyingStreamTerminationDateOffsetUnit":
				{
					value = UnderlyingStreamTerminationDateOffsetUnit;
					break;
				}
				case "UnderlyingStreamTerminationDateOffsetDayType":
				{
					value = UnderlyingStreamTerminationDateOffsetDayType;
					break;
				}
				case "UnderlyingStreamTerminationDateAdjusted":
				{
					value = UnderlyingStreamTerminationDateAdjusted;
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
			UnderlyingStreamTerminationDateUnadjusted = null;
			UnderlyingStreamTerminationDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingStreamTerminationDateBusinessCenterGrp)?.Reset();
			UnderlyingStreamTerminationDateRelativeTo = null;
			UnderlyingStreamTerminationDateOffsetPeriod = null;
			UnderlyingStreamTerminationDateOffsetUnit = null;
			UnderlyingStreamTerminationDateOffsetDayType = null;
			UnderlyingStreamTerminationDateAdjusted = null;
		}
	}
}
