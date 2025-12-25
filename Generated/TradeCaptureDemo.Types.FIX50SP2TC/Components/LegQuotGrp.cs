using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegQuotGrp : IFixComponent
	{
		public sealed partial class NoLegs : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public InstrumentLeg? InstrumentLeg {get; set;}
			
			[TagDetails(Tag = 685, Type = TagType.Float, Offset = 1, Required = false)]
			public double? LegOrderQty {get; set;}
			
			[TagDetails(Tag = 687, Type = TagType.Float, Offset = 2, Required = false)]
			public double? LegQty {get; set;}
			
			[TagDetails(Tag = 2346, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LegMidPx {get; set;}
			
			[TagDetails(Tag = 690, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LegSwapType {get; set;}
			
			[TagDetails(Tag = 587, Type = TagType.String, Offset = 5, Required = false)]
			public string? LegSettlType {get; set;}
			
			[TagDetails(Tag = 588, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? LegSettlDate {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegStipulations? LegStipulations {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public NestedParties? NestedParties {get; set;}
			
			[TagDetails(Tag = 686, Type = TagType.Int, Offset = 9, Required = false)]
			public int? LegPriceType {get; set;}
			
			[TagDetails(Tag = 681, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LegBidPx {get; set;}
			
			[TagDetails(Tag = 684, Type = TagType.Float, Offset = 11, Required = false)]
			public double? LegOfferPx {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public LegBenchmarkCurveData? LegBenchmarkCurveData {get; set;}
			
			[TagDetails(Tag = 654, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegRefID {get; set;}
			
			[TagDetails(Tag = 1067, Type = TagType.Float, Offset = 14, Required = false)]
			public double? LegBidForwardPoints {get; set;}
			
			[TagDetails(Tag = 1068, Type = TagType.Float, Offset = 15, Required = false)]
			public double? LegOfferForwardPoints {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentLeg is not null) ((IFixEncoder)InstrumentLeg).Encode(writer);
				if (LegOrderQty is not null) writer.WriteNumber(685, LegOrderQty.Value);
				if (LegQty is not null) writer.WriteNumber(687, LegQty.Value);
				if (LegMidPx is not null) writer.WriteNumber(2346, LegMidPx.Value);
				if (LegSwapType is not null) writer.WriteWholeNumber(690, LegSwapType.Value);
				if (LegSettlType is not null) writer.WriteString(587, LegSettlType);
				if (LegSettlDate is not null) writer.WriteLocalDateOnly(588, LegSettlDate.Value);
				if (LegStipulations is not null) ((IFixEncoder)LegStipulations).Encode(writer);
				if (NestedParties is not null) ((IFixEncoder)NestedParties).Encode(writer);
				if (LegPriceType is not null) writer.WriteWholeNumber(686, LegPriceType.Value);
				if (LegBidPx is not null) writer.WriteNumber(681, LegBidPx.Value);
				if (LegOfferPx is not null) writer.WriteNumber(684, LegOfferPx.Value);
				if (LegBenchmarkCurveData is not null) ((IFixEncoder)LegBenchmarkCurveData).Encode(writer);
				if (LegRefID is not null) writer.WriteString(654, LegRefID);
				if (LegBidForwardPoints is not null) writer.WriteNumber(1067, LegBidForwardPoints.Value);
				if (LegOfferForwardPoints is not null) writer.WriteNumber(1068, LegOfferForwardPoints.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("InstrumentLeg") is IMessageView viewInstrumentLeg)
				{
					InstrumentLeg = new();
					((IFixParser)InstrumentLeg).Parse(viewInstrumentLeg);
				}
				LegOrderQty = view.GetDouble(685);
				LegQty = view.GetDouble(687);
				LegMidPx = view.GetDouble(2346);
				LegSwapType = view.GetInt32(690);
				LegSettlType = view.GetString(587);
				LegSettlDate = view.GetDateOnly(588);
				if (view.GetView("LegStipulations") is IMessageView viewLegStipulations)
				{
					LegStipulations = new();
					((IFixParser)LegStipulations).Parse(viewLegStipulations);
				}
				if (view.GetView("NestedParties") is IMessageView viewNestedParties)
				{
					NestedParties = new();
					((IFixParser)NestedParties).Parse(viewNestedParties);
				}
				LegPriceType = view.GetInt32(686);
				LegBidPx = view.GetDouble(681);
				LegOfferPx = view.GetDouble(684);
				if (view.GetView("LegBenchmarkCurveData") is IMessageView viewLegBenchmarkCurveData)
				{
					LegBenchmarkCurveData = new();
					((IFixParser)LegBenchmarkCurveData).Parse(viewLegBenchmarkCurveData);
				}
				LegRefID = view.GetString(654);
				LegBidForwardPoints = view.GetDouble(1067);
				LegOfferForwardPoints = view.GetDouble(1068);
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
					case "LegOrderQty":
					{
						value = LegOrderQty;
						break;
					}
					case "LegQty":
					{
						value = LegQty;
						break;
					}
					case "LegMidPx":
					{
						value = LegMidPx;
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
					case "LegSettlDate":
					{
						value = LegSettlDate;
						break;
					}
					case "LegStipulations":
					{
						value = LegStipulations;
						break;
					}
					case "NestedParties":
					{
						value = NestedParties;
						break;
					}
					case "LegPriceType":
					{
						value = LegPriceType;
						break;
					}
					case "LegBidPx":
					{
						value = LegBidPx;
						break;
					}
					case "LegOfferPx":
					{
						value = LegOfferPx;
						break;
					}
					case "LegBenchmarkCurveData":
					{
						value = LegBenchmarkCurveData;
						break;
					}
					case "LegRefID":
					{
						value = LegRefID;
						break;
					}
					case "LegBidForwardPoints":
					{
						value = LegBidForwardPoints;
						break;
					}
					case "LegOfferForwardPoints":
					{
						value = LegOfferForwardPoints;
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
				LegOrderQty = null;
				LegQty = null;
				LegMidPx = null;
				LegSwapType = null;
				LegSettlType = null;
				LegSettlDate = null;
				((IFixReset?)LegStipulations)?.Reset();
				((IFixReset?)NestedParties)?.Reset();
				LegPriceType = null;
				LegBidPx = null;
				LegOfferPx = null;
				((IFixReset?)LegBenchmarkCurveData)?.Reset();
				LegRefID = null;
				LegBidForwardPoints = null;
				LegOfferForwardPoints = null;
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
