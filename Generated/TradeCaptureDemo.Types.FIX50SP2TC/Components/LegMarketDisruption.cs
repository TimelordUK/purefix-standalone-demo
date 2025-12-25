using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegMarketDisruption : IFixComponent
	{
		[TagDetails(Tag = 41462, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegMarketDisruptionProvision {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegMarketDisruptionEventGrp? LegMarketDisruptionEventGrp {get; set;}
		
		[TagDetails(Tag = 41463, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegMarketDisruptionFallbackProvision {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public LegMarketDisruptionFallbackGrp? LegMarketDisruptionFallbackGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegMarketDisruptionFallbackReferencePriceGrp? LegMarketDisruptionFallbackReferencePriceGrp {get; set;}
		
		[TagDetails(Tag = 41464, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegMarketDisruptionMaximumDays {get; set;}
		
		[TagDetails(Tag = 41465, Type = TagType.Float, Offset = 6, Required = false)]
		public double? LegMarketDisruptionMaterialityPercentage {get; set;}
		
		[TagDetails(Tag = 41466, Type = TagType.Int, Offset = 7, Required = false)]
		public int? LegMarketDisruptionMinimumFuturesContracts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegMarketDisruptionProvision is not null) writer.WriteWholeNumber(41462, LegMarketDisruptionProvision.Value);
			if (LegMarketDisruptionEventGrp is not null) ((IFixEncoder)LegMarketDisruptionEventGrp).Encode(writer);
			if (LegMarketDisruptionFallbackProvision is not null) writer.WriteWholeNumber(41463, LegMarketDisruptionFallbackProvision.Value);
			if (LegMarketDisruptionFallbackGrp is not null) ((IFixEncoder)LegMarketDisruptionFallbackGrp).Encode(writer);
			if (LegMarketDisruptionFallbackReferencePriceGrp is not null) ((IFixEncoder)LegMarketDisruptionFallbackReferencePriceGrp).Encode(writer);
			if (LegMarketDisruptionMaximumDays is not null) writer.WriteWholeNumber(41464, LegMarketDisruptionMaximumDays.Value);
			if (LegMarketDisruptionMaterialityPercentage is not null) writer.WriteNumber(41465, LegMarketDisruptionMaterialityPercentage.Value);
			if (LegMarketDisruptionMinimumFuturesContracts is not null) writer.WriteWholeNumber(41466, LegMarketDisruptionMinimumFuturesContracts.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegMarketDisruptionProvision = view.GetInt32(41462);
			if (view.GetView("LegMarketDisruptionEventGrp") is IMessageView viewLegMarketDisruptionEventGrp)
			{
				LegMarketDisruptionEventGrp = new();
				((IFixParser)LegMarketDisruptionEventGrp).Parse(viewLegMarketDisruptionEventGrp);
			}
			LegMarketDisruptionFallbackProvision = view.GetInt32(41463);
			if (view.GetView("LegMarketDisruptionFallbackGrp") is IMessageView viewLegMarketDisruptionFallbackGrp)
			{
				LegMarketDisruptionFallbackGrp = new();
				((IFixParser)LegMarketDisruptionFallbackGrp).Parse(viewLegMarketDisruptionFallbackGrp);
			}
			if (view.GetView("LegMarketDisruptionFallbackReferencePriceGrp") is IMessageView viewLegMarketDisruptionFallbackReferencePriceGrp)
			{
				LegMarketDisruptionFallbackReferencePriceGrp = new();
				((IFixParser)LegMarketDisruptionFallbackReferencePriceGrp).Parse(viewLegMarketDisruptionFallbackReferencePriceGrp);
			}
			LegMarketDisruptionMaximumDays = view.GetInt32(41464);
			LegMarketDisruptionMaterialityPercentage = view.GetDouble(41465);
			LegMarketDisruptionMinimumFuturesContracts = view.GetInt32(41466);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegMarketDisruptionProvision":
				{
					value = LegMarketDisruptionProvision;
					break;
				}
				case "LegMarketDisruptionEventGrp":
				{
					value = LegMarketDisruptionEventGrp;
					break;
				}
				case "LegMarketDisruptionFallbackProvision":
				{
					value = LegMarketDisruptionFallbackProvision;
					break;
				}
				case "LegMarketDisruptionFallbackGrp":
				{
					value = LegMarketDisruptionFallbackGrp;
					break;
				}
				case "LegMarketDisruptionFallbackReferencePriceGrp":
				{
					value = LegMarketDisruptionFallbackReferencePriceGrp;
					break;
				}
				case "LegMarketDisruptionMaximumDays":
				{
					value = LegMarketDisruptionMaximumDays;
					break;
				}
				case "LegMarketDisruptionMaterialityPercentage":
				{
					value = LegMarketDisruptionMaterialityPercentage;
					break;
				}
				case "LegMarketDisruptionMinimumFuturesContracts":
				{
					value = LegMarketDisruptionMinimumFuturesContracts;
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
			LegMarketDisruptionProvision = null;
			((IFixReset?)LegMarketDisruptionEventGrp)?.Reset();
			LegMarketDisruptionFallbackProvision = null;
			((IFixReset?)LegMarketDisruptionFallbackGrp)?.Reset();
			((IFixReset?)LegMarketDisruptionFallbackReferencePriceGrp)?.Reset();
			LegMarketDisruptionMaximumDays = null;
			LegMarketDisruptionMaterialityPercentage = null;
			LegMarketDisruptionMinimumFuturesContracts = null;
		}
	}
}
