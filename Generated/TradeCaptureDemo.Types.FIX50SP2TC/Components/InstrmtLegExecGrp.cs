using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrmtLegExecGrp : IFixComponent
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
			
			[Component(Offset = 5, Required = false)]
			public LegStipulations? LegStipulations {get; set;}
			
			[TagDetails(Tag = 1366, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegAllocID {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public LegPreAllocGrp? LegPreAllocGrp {get; set;}
			
			[TagDetails(Tag = 2680, Type = TagType.String, Offset = 8, Required = false)]
			public string? LegAccount {get; set;}
			
			[TagDetails(Tag = 1817, Type = TagType.Int, Offset = 9, Required = false)]
			public int? LegClearingAccountType {get; set;}
			
			[TagDetails(Tag = 564, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegPositionEffect {get; set;}
			
			[TagDetails(Tag = 565, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegCoveredOrUncovered {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public NestedParties3? NestedParties3 {get; set;}
			
			[TagDetails(Tag = 654, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegRefID {get; set;}
			
			[TagDetails(Tag = 587, Type = TagType.String, Offset = 14, Required = false)]
			public string? LegSettlType {get; set;}
			
			[TagDetails(Tag = 588, Type = TagType.LocalDate, Offset = 15, Required = false)]
			public DateOnly? LegSettlDate {get; set;}
			
			[TagDetails(Tag = 637, Type = TagType.Float, Offset = 16, Required = false)]
			public double? LegLastPx {get; set;}
			
			[TagDetails(Tag = 675, Type = TagType.String, Offset = 17, Required = false)]
			public string? LegSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2900, Type = TagType.String, Offset = 18, Required = false)]
			public string? LegSettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1073, Type = TagType.Float, Offset = 19, Required = false)]
			public double? LegLastForwardPoints {get; set;}
			
			[TagDetails(Tag = 1074, Type = TagType.Float, Offset = 20, Required = false)]
			public double? LegCalculatedCcyLastQty {get; set;}
			
			[TagDetails(Tag = 1075, Type = TagType.Float, Offset = 21, Required = false)]
			public double? LegGrossTradeAmt {get; set;}
			
			[TagDetails(Tag = 1689, Type = TagType.Int, Offset = 22, Required = false)]
			public int? LegShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 1379, Type = TagType.Float, Offset = 23, Required = false)]
			public double? LegVolatility {get; set;}
			
			[TagDetails(Tag = 1381, Type = TagType.Float, Offset = 24, Required = false)]
			public double? LegDividendYield {get; set;}
			
			[TagDetails(Tag = 1383, Type = TagType.Float, Offset = 25, Required = false)]
			public double? LegCurrencyRatio {get; set;}
			
			[TagDetails(Tag = 1384, Type = TagType.String, Offset = 26, Required = false)]
			public string? LegExecInst {get; set;}
			
			[TagDetails(Tag = 1418, Type = TagType.Float, Offset = 27, Required = false)]
			public double? LegLastQty {get; set;}
			
			[TagDetails(Tag = 2421, Type = TagType.String, Offset = 28, Required = false)]
			public string? FillRefID {get; set;}
			
			
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
				if (LegStipulations is not null) ((IFixEncoder)LegStipulations).Encode(writer);
				if (LegAllocID is not null) writer.WriteString(1366, LegAllocID);
				if (LegPreAllocGrp is not null) ((IFixEncoder)LegPreAllocGrp).Encode(writer);
				if (LegAccount is not null) writer.WriteString(2680, LegAccount);
				if (LegClearingAccountType is not null) writer.WriteWholeNumber(1817, LegClearingAccountType.Value);
				if (LegPositionEffect is not null) writer.WriteString(564, LegPositionEffect);
				if (LegCoveredOrUncovered is not null) writer.WriteWholeNumber(565, LegCoveredOrUncovered.Value);
				if (NestedParties3 is not null) ((IFixEncoder)NestedParties3).Encode(writer);
				if (LegRefID is not null) writer.WriteString(654, LegRefID);
				if (LegSettlType is not null) writer.WriteString(587, LegSettlType);
				if (LegSettlDate is not null) writer.WriteLocalDateOnly(588, LegSettlDate.Value);
				if (LegLastPx is not null) writer.WriteNumber(637, LegLastPx.Value);
				if (LegSettlCurrency is not null) writer.WriteString(675, LegSettlCurrency);
				if (LegSettlCurrencyCodeSource is not null) writer.WriteString(2900, LegSettlCurrencyCodeSource);
				if (LegLastForwardPoints is not null) writer.WriteNumber(1073, LegLastForwardPoints.Value);
				if (LegCalculatedCcyLastQty is not null) writer.WriteNumber(1074, LegCalculatedCcyLastQty.Value);
				if (LegGrossTradeAmt is not null) writer.WriteNumber(1075, LegGrossTradeAmt.Value);
				if (LegShortSaleExemptionReason is not null) writer.WriteWholeNumber(1689, LegShortSaleExemptionReason.Value);
				if (LegVolatility is not null) writer.WriteNumber(1379, LegVolatility.Value);
				if (LegDividendYield is not null) writer.WriteNumber(1381, LegDividendYield.Value);
				if (LegCurrencyRatio is not null) writer.WriteNumber(1383, LegCurrencyRatio.Value);
				if (LegExecInst is not null) writer.WriteString(1384, LegExecInst);
				if (LegLastQty is not null) writer.WriteNumber(1418, LegLastQty.Value);
				if (FillRefID is not null) writer.WriteString(2421, FillRefID);
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
				if (view.GetView("LegStipulations") is IMessageView viewLegStipulations)
				{
					LegStipulations = new();
					((IFixParser)LegStipulations).Parse(viewLegStipulations);
				}
				LegAllocID = view.GetString(1366);
				if (view.GetView("LegPreAllocGrp") is IMessageView viewLegPreAllocGrp)
				{
					LegPreAllocGrp = new();
					((IFixParser)LegPreAllocGrp).Parse(viewLegPreAllocGrp);
				}
				LegAccount = view.GetString(2680);
				LegClearingAccountType = view.GetInt32(1817);
				LegPositionEffect = view.GetString(564);
				LegCoveredOrUncovered = view.GetInt32(565);
				if (view.GetView("NestedParties3") is IMessageView viewNestedParties3)
				{
					NestedParties3 = new();
					((IFixParser)NestedParties3).Parse(viewNestedParties3);
				}
				LegRefID = view.GetString(654);
				LegSettlType = view.GetString(587);
				LegSettlDate = view.GetDateOnly(588);
				LegLastPx = view.GetDouble(637);
				LegSettlCurrency = view.GetString(675);
				LegSettlCurrencyCodeSource = view.GetString(2900);
				LegLastForwardPoints = view.GetDouble(1073);
				LegCalculatedCcyLastQty = view.GetDouble(1074);
				LegGrossTradeAmt = view.GetDouble(1075);
				LegShortSaleExemptionReason = view.GetInt32(1689);
				LegVolatility = view.GetDouble(1379);
				LegDividendYield = view.GetDouble(1381);
				LegCurrencyRatio = view.GetDouble(1383);
				LegExecInst = view.GetString(1384);
				LegLastQty = view.GetDouble(1418);
				FillRefID = view.GetString(2421);
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
					case "LegStipulations":
					{
						value = LegStipulations;
						break;
					}
					case "LegAllocID":
					{
						value = LegAllocID;
						break;
					}
					case "LegPreAllocGrp":
					{
						value = LegPreAllocGrp;
						break;
					}
					case "LegAccount":
					{
						value = LegAccount;
						break;
					}
					case "LegClearingAccountType":
					{
						value = LegClearingAccountType;
						break;
					}
					case "LegPositionEffect":
					{
						value = LegPositionEffect;
						break;
					}
					case "LegCoveredOrUncovered":
					{
						value = LegCoveredOrUncovered;
						break;
					}
					case "NestedParties3":
					{
						value = NestedParties3;
						break;
					}
					case "LegRefID":
					{
						value = LegRefID;
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
					case "LegLastPx":
					{
						value = LegLastPx;
						break;
					}
					case "LegSettlCurrency":
					{
						value = LegSettlCurrency;
						break;
					}
					case "LegSettlCurrencyCodeSource":
					{
						value = LegSettlCurrencyCodeSource;
						break;
					}
					case "LegLastForwardPoints":
					{
						value = LegLastForwardPoints;
						break;
					}
					case "LegCalculatedCcyLastQty":
					{
						value = LegCalculatedCcyLastQty;
						break;
					}
					case "LegGrossTradeAmt":
					{
						value = LegGrossTradeAmt;
						break;
					}
					case "LegShortSaleExemptionReason":
					{
						value = LegShortSaleExemptionReason;
						break;
					}
					case "LegVolatility":
					{
						value = LegVolatility;
						break;
					}
					case "LegDividendYield":
					{
						value = LegDividendYield;
						break;
					}
					case "LegCurrencyRatio":
					{
						value = LegCurrencyRatio;
						break;
					}
					case "LegExecInst":
					{
						value = LegExecInst;
						break;
					}
					case "LegLastQty":
					{
						value = LegLastQty;
						break;
					}
					case "FillRefID":
					{
						value = FillRefID;
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
				((IFixReset?)LegStipulations)?.Reset();
				LegAllocID = null;
				((IFixReset?)LegPreAllocGrp)?.Reset();
				LegAccount = null;
				LegClearingAccountType = null;
				LegPositionEffect = null;
				LegCoveredOrUncovered = null;
				((IFixReset?)NestedParties3)?.Reset();
				LegRefID = null;
				LegSettlType = null;
				LegSettlDate = null;
				LegLastPx = null;
				LegSettlCurrency = null;
				LegSettlCurrencyCodeSource = null;
				LegLastForwardPoints = null;
				LegCalculatedCcyLastQty = null;
				LegGrossTradeAmt = null;
				LegShortSaleExemptionReason = null;
				LegVolatility = null;
				LegDividendYield = null;
				LegCurrencyRatio = null;
				LegExecInst = null;
				LegLastQty = null;
				FillRefID = null;
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
