using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDateAdjustment : IFixComponent
	{
		[TagDetails(Tag = 40925, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegBusinessCenterGrp? LegBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40926, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegDateRollConvention {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegBusinessDayConvention is not null) writer.WriteWholeNumber(40925, LegBusinessDayConvention.Value);
			if (LegBusinessCenterGrp is not null) ((IFixEncoder)LegBusinessCenterGrp).Encode(writer);
			if (LegDateRollConvention is not null) writer.WriteString(40926, LegDateRollConvention);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegBusinessDayConvention = view.GetInt32(40925);
			if (view.GetView("LegBusinessCenterGrp") is IMessageView viewLegBusinessCenterGrp)
			{
				LegBusinessCenterGrp = new();
				((IFixParser)LegBusinessCenterGrp).Parse(viewLegBusinessCenterGrp);
			}
			LegDateRollConvention = view.GetString(40926);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegBusinessDayConvention":
				{
					value = LegBusinessDayConvention;
					break;
				}
				case "LegBusinessCenterGrp":
				{
					value = LegBusinessCenterGrp;
					break;
				}
				case "LegDateRollConvention":
				{
					value = LegDateRollConvention;
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
			LegBusinessDayConvention = null;
			((IFixReset?)LegBusinessCenterGrp)?.Reset();
			LegDateRollConvention = null;
		}
	}
}
