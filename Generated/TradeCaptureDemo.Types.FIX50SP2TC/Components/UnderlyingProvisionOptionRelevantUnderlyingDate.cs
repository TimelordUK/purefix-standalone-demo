using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionRelevantUnderlyingDate : IFixComponent
	{
		[TagDetails(Tag = 42142, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 42143, Type = TagType.Int, Offset = 1, Required = false)]
		public int? UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp? UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 42144, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo {get; set;}
		
		[TagDetails(Tag = 42145, Type = TagType.Int, Offset = 4, Required = false)]
		public int? UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod {get; set;}
		
		[TagDetails(Tag = 42146, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit {get; set;}
		
		[TagDetails(Tag = 42147, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType {get; set;}
		
		[TagDetails(Tag = 42148, Type = TagType.LocalDate, Offset = 7, Required = false)]
		public DateOnly? UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted is not null) writer.WriteLocalDateOnly(42142, UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted.Value);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention is not null) writer.WriteWholeNumber(42143, UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention.Value);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Encode(writer);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo is not null) writer.WriteWholeNumber(42144, UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo.Value);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod is not null) writer.WriteWholeNumber(42145, UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod.Value);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit is not null) writer.WriteString(42146, UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType is not null) writer.WriteWholeNumber(42147, UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType.Value);
			if (UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted is not null) writer.WriteLocalDateOnly(42148, UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted = view.GetDateOnly(42142);
			UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention = view.GetInt32(42143);
			if (view.GetView("UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp") is IMessageView viewUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)
			{
				UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp = new();
				((IFixParser)UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp).Parse(viewUnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp);
			}
			UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo = view.GetInt32(42144);
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod = view.GetInt32(42145);
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit = view.GetString(42146);
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType = view.GetInt32(42147);
			UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted = view.GetDateOnly(42148);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType;
					break;
				}
				case "UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted":
				{
					value = UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted;
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
			UnderlyingProvisionOptionRelevantUnderlyingDateUnadjusted = null;
			UnderlyingProvisionOptionRelevantUnderlyingDateBizDayConvention = null;
			((IFixReset?)UnderlyingProvisionOptionRelevantUnderlyingDateBusinessCenterGrp)?.Reset();
			UnderlyingProvisionOptionRelevantUnderlyingDateRelativeTo = null;
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetPeriod = null;
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetUnit = null;
			UnderlyingProvisionOptionRelevantUnderlyingDateOffsetDayType = null;
			UnderlyingProvisionOptionRelevantUnderlyingDateAdjusted = null;
		}
	}
}
