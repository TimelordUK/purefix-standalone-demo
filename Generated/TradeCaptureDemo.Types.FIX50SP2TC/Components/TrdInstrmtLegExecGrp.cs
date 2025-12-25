using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdInstrmtLegExecGrp : IFixComponent
	{
		public sealed partial class NoLegExecs : IFixGroup
		{
			[TagDetails(Tag = 654, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegRefID {get; set;}
			
			[TagDetails(Tag = 1893, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegExecID {get; set;}
			
			[TagDetails(Tag = 1901, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegExecRefID {get; set;}
			
			[TagDetails(Tag = 1894, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegTradeID {get; set;}
			
			[TagDetails(Tag = 1895, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegTradeReportID {get; set;}
			
			[TagDetails(Tag = 685, Type = TagType.Float, Offset = 5, Required = false)]
			public double? LegOrderQty {get; set;}
			
			[TagDetails(Tag = 564, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegPositionEffect {get; set;}
			
			[TagDetails(Tag = 565, Type = TagType.Int, Offset = 7, Required = false)]
			public int? LegCoveredOrUncovered {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public NestedParties3? NestedParties3 {get; set;}
			
			[TagDetails(Tag = 637, Type = TagType.Float, Offset = 9, Required = false)]
			public double? LegLastPx {get; set;}
			
			[TagDetails(Tag = 686, Type = TagType.Int, Offset = 10, Required = false)]
			public int? LegPriceType {get; set;}
			
			[TagDetails(Tag = 675, Type = TagType.String, Offset = 11, Required = false)]
			public string? LegSettlCurrency {get; set;}
			
			[TagDetails(Tag = 2900, Type = TagType.String, Offset = 12, Required = false)]
			public string? LegSettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 1689, Type = TagType.Int, Offset = 13, Required = false)]
			public int? LegShortSaleExemptionReason {get; set;}
			
			[TagDetails(Tag = 1418, Type = TagType.Float, Offset = 14, Required = false)]
			public double? LegLastQty {get; set;}
			
			[TagDetails(Tag = 1591, Type = TagType.Int, Offset = 15, Required = false)]
			public int? LegQtyType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegRefID is not null) writer.WriteString(654, LegRefID);
				if (LegExecID is not null) writer.WriteString(1893, LegExecID);
				if (LegExecRefID is not null) writer.WriteString(1901, LegExecRefID);
				if (LegTradeID is not null) writer.WriteString(1894, LegTradeID);
				if (LegTradeReportID is not null) writer.WriteString(1895, LegTradeReportID);
				if (LegOrderQty is not null) writer.WriteNumber(685, LegOrderQty.Value);
				if (LegPositionEffect is not null) writer.WriteString(564, LegPositionEffect);
				if (LegCoveredOrUncovered is not null) writer.WriteWholeNumber(565, LegCoveredOrUncovered.Value);
				if (NestedParties3 is not null) ((IFixEncoder)NestedParties3).Encode(writer);
				if (LegLastPx is not null) writer.WriteNumber(637, LegLastPx.Value);
				if (LegPriceType is not null) writer.WriteWholeNumber(686, LegPriceType.Value);
				if (LegSettlCurrency is not null) writer.WriteString(675, LegSettlCurrency);
				if (LegSettlCurrencyCodeSource is not null) writer.WriteString(2900, LegSettlCurrencyCodeSource);
				if (LegShortSaleExemptionReason is not null) writer.WriteWholeNumber(1689, LegShortSaleExemptionReason.Value);
				if (LegLastQty is not null) writer.WriteNumber(1418, LegLastQty.Value);
				if (LegQtyType is not null) writer.WriteWholeNumber(1591, LegQtyType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegRefID = view.GetString(654);
				LegExecID = view.GetString(1893);
				LegExecRefID = view.GetString(1901);
				LegTradeID = view.GetString(1894);
				LegTradeReportID = view.GetString(1895);
				LegOrderQty = view.GetDouble(685);
				LegPositionEffect = view.GetString(564);
				LegCoveredOrUncovered = view.GetInt32(565);
				if (view.GetView("NestedParties3") is IMessageView viewNestedParties3)
				{
					NestedParties3 = new();
					((IFixParser)NestedParties3).Parse(viewNestedParties3);
				}
				LegLastPx = view.GetDouble(637);
				LegPriceType = view.GetInt32(686);
				LegSettlCurrency = view.GetString(675);
				LegSettlCurrencyCodeSource = view.GetString(2900);
				LegShortSaleExemptionReason = view.GetInt32(1689);
				LegLastQty = view.GetDouble(1418);
				LegQtyType = view.GetInt32(1591);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegRefID":
					{
						value = LegRefID;
						break;
					}
					case "LegExecID":
					{
						value = LegExecID;
						break;
					}
					case "LegExecRefID":
					{
						value = LegExecRefID;
						break;
					}
					case "LegTradeID":
					{
						value = LegTradeID;
						break;
					}
					case "LegTradeReportID":
					{
						value = LegTradeReportID;
						break;
					}
					case "LegOrderQty":
					{
						value = LegOrderQty;
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
					case "LegLastPx":
					{
						value = LegLastPx;
						break;
					}
					case "LegPriceType":
					{
						value = LegPriceType;
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
					case "LegShortSaleExemptionReason":
					{
						value = LegShortSaleExemptionReason;
						break;
					}
					case "LegLastQty":
					{
						value = LegLastQty;
						break;
					}
					case "LegQtyType":
					{
						value = LegQtyType;
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
				LegRefID = null;
				LegExecID = null;
				LegExecRefID = null;
				LegTradeID = null;
				LegTradeReportID = null;
				LegOrderQty = null;
				LegPositionEffect = null;
				LegCoveredOrUncovered = null;
				((IFixReset?)NestedParties3)?.Reset();
				LegLastPx = null;
				LegPriceType = null;
				LegSettlCurrency = null;
				LegSettlCurrencyCodeSource = null;
				LegShortSaleExemptionReason = null;
				LegLastQty = null;
				LegQtyType = null;
			}
		}
		[Group(NoOfTag = 1892, Offset = 0, Required = false)]
		public NoLegExecs[]? LegExecs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegExecs is not null && LegExecs.Length != 0)
			{
				writer.WriteWholeNumber(1892, LegExecs.Length);
				for (int i = 0; i < LegExecs.Length; i++)
				{
					((IFixEncoder)LegExecs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegExecs") is IMessageView viewNoLegExecs)
			{
				var count = viewNoLegExecs.GroupCount();
				LegExecs = new NoLegExecs[count];
				for (int i = 0; i < count; i++)
				{
					LegExecs[i] = new();
					((IFixParser)LegExecs[i]).Parse(viewNoLegExecs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegExecs":
				{
					value = LegExecs;
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
			LegExecs = null;
		}
	}
}
