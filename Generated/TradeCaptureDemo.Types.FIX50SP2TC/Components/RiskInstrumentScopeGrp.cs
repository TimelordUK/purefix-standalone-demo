using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RiskInstrumentScopeGrp : IFixComponent
	{
		public sealed partial class NoRiskInstrumentScopes : IFixGroup
		{
			[TagDetails(Tag = 1535, Type = TagType.Int, Offset = 0, Required = false)]
			public int? InstrumentScopeOperator {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public InstrumentScope? InstrumentScope {get; set;}
			
			[TagDetails(Tag = 1558, Type = TagType.Float, Offset = 2, Required = false)]
			public double? RiskInstrumentMultiplier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentScopeOperator is not null) writer.WriteWholeNumber(1535, InstrumentScopeOperator.Value);
				if (InstrumentScope is not null) ((IFixEncoder)InstrumentScope).Encode(writer);
				if (RiskInstrumentMultiplier is not null) writer.WriteNumber(1558, RiskInstrumentMultiplier.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrumentScopeOperator = view.GetInt32(1535);
				if (view.GetView("InstrumentScope") is IMessageView viewInstrumentScope)
				{
					InstrumentScope = new();
					((IFixParser)InstrumentScope).Parse(viewInstrumentScope);
				}
				RiskInstrumentMultiplier = view.GetDouble(1558);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentScopeOperator":
					{
						value = InstrumentScopeOperator;
						break;
					}
					case "InstrumentScope":
					{
						value = InstrumentScope;
						break;
					}
					case "RiskInstrumentMultiplier":
					{
						value = RiskInstrumentMultiplier;
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
				InstrumentScopeOperator = null;
				((IFixReset?)InstrumentScope)?.Reset();
				RiskInstrumentMultiplier = null;
			}
		}
		[Group(NoOfTag = 1534, Offset = 0, Required = false)]
		public NoRiskInstrumentScopes[]? RiskInstrumentScopes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RiskInstrumentScopes is not null && RiskInstrumentScopes.Length != 0)
			{
				writer.WriteWholeNumber(1534, RiskInstrumentScopes.Length);
				for (int i = 0; i < RiskInstrumentScopes.Length; i++)
				{
					((IFixEncoder)RiskInstrumentScopes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRiskInstrumentScopes") is IMessageView viewNoRiskInstrumentScopes)
			{
				var count = viewNoRiskInstrumentScopes.GroupCount();
				RiskInstrumentScopes = new NoRiskInstrumentScopes[count];
				for (int i = 0; i < count; i++)
				{
					RiskInstrumentScopes[i] = new();
					((IFixParser)RiskInstrumentScopes[i]).Parse(viewNoRiskInstrumentScopes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRiskInstrumentScopes":
				{
					value = RiskInstrumentScopes;
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
			RiskInstrumentScopes = null;
		}
	}
}
