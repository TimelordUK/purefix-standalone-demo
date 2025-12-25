using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SecLstUpdRelSymsLegGrp : IFixComponent
	{
		public sealed partial class NoLegs : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public InstrumentLeg? InstrumentLeg {get; set;}
			
			[TagDetails(Tag = 690, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegSwapType {get; set;}
			
			[TagDetails(Tag = 587, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegSettlType {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public LegStipulations? LegStipulations {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public LegBenchmarkCurveData? LegBenchmarkCurveData {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentLeg is not null) ((IFixEncoder)InstrumentLeg).Encode(writer);
				if (LegSwapType is not null) writer.WriteWholeNumber(690, LegSwapType.Value);
				if (LegSettlType is not null) writer.WriteString(587, LegSettlType);
				if (LegStipulations is not null) ((IFixEncoder)LegStipulations).Encode(writer);
				if (LegBenchmarkCurveData is not null) ((IFixEncoder)LegBenchmarkCurveData).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("InstrumentLeg") is IMessageView viewInstrumentLeg)
				{
					InstrumentLeg = new();
					((IFixParser)InstrumentLeg).Parse(viewInstrumentLeg);
				}
				LegSwapType = view.GetInt32(690);
				LegSettlType = view.GetString(587);
				if (view.GetView("LegStipulations") is IMessageView viewLegStipulations)
				{
					LegStipulations = new();
					((IFixParser)LegStipulations).Parse(viewLegStipulations);
				}
				if (view.GetView("LegBenchmarkCurveData") is IMessageView viewLegBenchmarkCurveData)
				{
					LegBenchmarkCurveData = new();
					((IFixParser)LegBenchmarkCurveData).Parse(viewLegBenchmarkCurveData);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentLeg":
					{
						value = InstrumentLeg;
						break;
					}
					case "LegSwapType":
					{
						value = LegSwapType;
						break;
					}
					case "LegSettlType":
					{
						value = LegSettlType;
						break;
					}
					case "LegStipulations":
					{
						value = LegStipulations;
						break;
					}
					case "LegBenchmarkCurveData":
					{
						value = LegBenchmarkCurveData;
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
				((IFixReset?)InstrumentLeg)?.Reset();
				LegSwapType = null;
				LegSettlType = null;
				((IFixReset?)LegStipulations)?.Reset();
				((IFixReset?)LegBenchmarkCurveData)?.Reset();
			}
		}
		[Group(NoOfTag = 555, Offset = 0, Required = false)]
		public NoLegs[]? Legs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Legs is not null && Legs.Length != 0)
			{
				writer.WriteWholeNumber(555, Legs.Length);
				for (int i = 0; i < Legs.Length; i++)
				{
					((IFixEncoder)Legs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegs") is IMessageView viewNoLegs)
			{
				var count = viewNoLegs.GroupCount();
				Legs = new NoLegs[count];
				for (int i = 0; i < count; i++)
				{
					Legs[i] = new();
					((IFixParser)Legs[i]).Parse(viewNoLegs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegs":
				{
					value = Legs;
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
			Legs = null;
		}
	}
}
