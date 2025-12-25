using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDateAdjustment : IFixComponent
	{
		[TagDetails(Tag = 40964, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingBusinessDayConvention {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingBusinessCenterGrp? UnderlyingBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 40965, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingDateRollConvention {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingBusinessDayConvention is not null) writer.WriteWholeNumber(40964, UnderlyingBusinessDayConvention.Value);
			if (UnderlyingBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingBusinessCenterGrp).Encode(writer);
			if (UnderlyingDateRollConvention is not null) writer.WriteString(40965, UnderlyingDateRollConvention);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingBusinessDayConvention = view.GetInt32(40964);
			if (view.GetView("UnderlyingBusinessCenterGrp") is IMessageView viewUnderlyingBusinessCenterGrp)
			{
				UnderlyingBusinessCenterGrp = new();
				((IFixParser)UnderlyingBusinessCenterGrp).Parse(viewUnderlyingBusinessCenterGrp);
			}
			UnderlyingDateRollConvention = view.GetString(40965);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingBusinessDayConvention":
				{
					value = UnderlyingBusinessDayConvention;
					break;
				}
				case "UnderlyingBusinessCenterGrp":
				{
					value = UnderlyingBusinessCenterGrp;
					break;
				}
				case "UnderlyingDateRollConvention":
				{
					value = UnderlyingDateRollConvention;
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
			UnderlyingBusinessDayConvention = null;
			((IFixReset?)UnderlyingBusinessCenterGrp)?.Reset();
			UnderlyingDateRollConvention = null;
		}
	}
}
