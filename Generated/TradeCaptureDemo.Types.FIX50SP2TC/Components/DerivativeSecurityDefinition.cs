using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeSecurityDefinition : IFixComponent
	{
		[Component(Offset = 0, Required = false)]
		public DerivativeInstrument? DerivativeInstrument {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public DerivativeInstrumentAttribute? DerivativeInstrumentAttribute {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public MarketSegmentGrp? MarketSegmentGrp {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public SecurityClassificationGrp? SecurityClassificationGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeInstrument is not null) ((IFixEncoder)DerivativeInstrument).Encode(writer);
			if (DerivativeInstrumentAttribute is not null) ((IFixEncoder)DerivativeInstrumentAttribute).Encode(writer);
			if (MarketSegmentGrp is not null) ((IFixEncoder)MarketSegmentGrp).Encode(writer);
			if (SecurityClassificationGrp is not null) ((IFixEncoder)SecurityClassificationGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("DerivativeInstrument") is IMessageView viewDerivativeInstrument)
			{
				DerivativeInstrument = new();
				((IFixParser)DerivativeInstrument).Parse(viewDerivativeInstrument);
			}
			if (view.GetView("DerivativeInstrumentAttribute") is IMessageView viewDerivativeInstrumentAttribute)
			{
				DerivativeInstrumentAttribute = new();
				((IFixParser)DerivativeInstrumentAttribute).Parse(viewDerivativeInstrumentAttribute);
			}
			if (view.GetView("MarketSegmentGrp") is IMessageView viewMarketSegmentGrp)
			{
				MarketSegmentGrp = new();
				((IFixParser)MarketSegmentGrp).Parse(viewMarketSegmentGrp);
			}
			if (view.GetView("SecurityClassificationGrp") is IMessageView viewSecurityClassificationGrp)
			{
				SecurityClassificationGrp = new();
				((IFixParser)SecurityClassificationGrp).Parse(viewSecurityClassificationGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DerivativeInstrument":
				{
					value = DerivativeInstrument;
					break;
				}
				case "DerivativeInstrumentAttribute":
				{
					value = DerivativeInstrumentAttribute;
					break;
				}
				case "MarketSegmentGrp":
				{
					value = MarketSegmentGrp;
					break;
				}
				case "SecurityClassificationGrp":
				{
					value = SecurityClassificationGrp;
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
			((IFixReset?)DerivativeInstrument)?.Reset();
			((IFixReset?)DerivativeInstrumentAttribute)?.Reset();
			((IFixReset?)MarketSegmentGrp)?.Reset();
			((IFixReset?)SecurityClassificationGrp)?.Reset();
		}
	}
}
