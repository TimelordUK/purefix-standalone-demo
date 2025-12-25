using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingRateSpreadSchedule : IFixComponent
	{
		[TagDetails(Tag = 43004, Type = TagType.Float, Offset = 0, Required = false)]
		public double? UnderlyingRateSpreadInitialValue {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingRateSpreadStepGrp? UnderlyingRateSpreadStepGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingRateSpreadInitialValue is not null) writer.WriteNumber(43004, UnderlyingRateSpreadInitialValue.Value);
			if (UnderlyingRateSpreadStepGrp is not null) ((IFixEncoder)UnderlyingRateSpreadStepGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingRateSpreadInitialValue = view.GetDouble(43004);
			if (view.GetView("UnderlyingRateSpreadStepGrp") is IMessageView viewUnderlyingRateSpreadStepGrp)
			{
				UnderlyingRateSpreadStepGrp = new();
				((IFixParser)UnderlyingRateSpreadStepGrp).Parse(viewUnderlyingRateSpreadStepGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingRateSpreadInitialValue":
				{
					value = UnderlyingRateSpreadInitialValue;
					break;
				}
				case "UnderlyingRateSpreadStepGrp":
				{
					value = UnderlyingRateSpreadStepGrp;
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
			UnderlyingRateSpreadInitialValue = null;
			((IFixReset?)UnderlyingRateSpreadStepGrp)?.Reset();
		}
	}
}
