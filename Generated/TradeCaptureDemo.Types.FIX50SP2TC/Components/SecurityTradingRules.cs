using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecurityTradingRules : IFixComponent
	{
		[Component(Offset = 0, Required = false)]
		public BaseTradingRules? BaseTradingRules {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public TradingSessionRulesGrp? TradingSessionRulesGrp {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public NestedInstrumentAttribute? NestedInstrumentAttribute {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (BaseTradingRules is not null) ((IFixEncoder)BaseTradingRules).Encode(writer);
			if (TradingSessionRulesGrp is not null) ((IFixEncoder)TradingSessionRulesGrp).Encode(writer);
			if (NestedInstrumentAttribute is not null) ((IFixEncoder)NestedInstrumentAttribute).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("BaseTradingRules") is IMessageView viewBaseTradingRules)
			{
				BaseTradingRules = new();
				((IFixParser)BaseTradingRules).Parse(viewBaseTradingRules);
			}
			if (view.GetView("TradingSessionRulesGrp") is IMessageView viewTradingSessionRulesGrp)
			{
				TradingSessionRulesGrp = new();
				((IFixParser)TradingSessionRulesGrp).Parse(viewTradingSessionRulesGrp);
			}
			if (view.GetView("NestedInstrumentAttribute") is IMessageView viewNestedInstrumentAttribute)
			{
				NestedInstrumentAttribute = new();
				((IFixParser)NestedInstrumentAttribute).Parse(viewNestedInstrumentAttribute);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "BaseTradingRules":
				{
					value = BaseTradingRules;
					break;
				}
				case "TradingSessionRulesGrp":
				{
					value = TradingSessionRulesGrp;
					break;
				}
				case "NestedInstrumentAttribute":
				{
					value = NestedInstrumentAttribute;
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
			((IFixReset?)BaseTradingRules)?.Reset();
			((IFixReset?)TradingSessionRulesGrp)?.Reset();
			((IFixReset?)NestedInstrumentAttribute)?.Reset();
		}
	}
}
