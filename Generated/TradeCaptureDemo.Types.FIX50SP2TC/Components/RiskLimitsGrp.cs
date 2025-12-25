using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RiskLimitsGrp : IFixComponent
	{
		public sealed partial class NoRiskLimits : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public RiskLimitTypesGrp? RiskLimitTypesGrp {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public RiskInstrumentScopeGrp? RiskInstrumentScopeGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RiskLimitTypesGrp is not null) ((IFixEncoder)RiskLimitTypesGrp).Encode(writer);
				if (RiskInstrumentScopeGrp is not null) ((IFixEncoder)RiskInstrumentScopeGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("RiskLimitTypesGrp") is IMessageView viewRiskLimitTypesGrp)
				{
					RiskLimitTypesGrp = new();
					((IFixParser)RiskLimitTypesGrp).Parse(viewRiskLimitTypesGrp);
				}
				if (view.GetView("RiskInstrumentScopeGrp") is IMessageView viewRiskInstrumentScopeGrp)
				{
					RiskInstrumentScopeGrp = new();
					((IFixParser)RiskInstrumentScopeGrp).Parse(viewRiskInstrumentScopeGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RiskLimitTypesGrp":
					{
						value = RiskLimitTypesGrp;
						break;
					}
					case "RiskInstrumentScopeGrp":
					{
						value = RiskInstrumentScopeGrp;
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
				((IFixReset?)RiskLimitTypesGrp)?.Reset();
				((IFixReset?)RiskInstrumentScopeGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1669, Offset = 0, Required = false)]
		public NoRiskLimits[]? RiskLimits {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RiskLimits is not null && RiskLimits.Length != 0)
			{
				writer.WriteWholeNumber(1669, RiskLimits.Length);
				for (int i = 0; i < RiskLimits.Length; i++)
				{
					((IFixEncoder)RiskLimits[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRiskLimits") is IMessageView viewNoRiskLimits)
			{
				var count = viewNoRiskLimits.GroupCount();
				RiskLimits = new NoRiskLimits[count];
				for (int i = 0; i < count; i++)
				{
					RiskLimits[i] = new();
					((IFixParser)RiskLimits[i]).Parse(viewNoRiskLimits.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRiskLimits":
				{
					value = RiskLimits;
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
			RiskLimits = null;
		}
	}
}
