using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarketDisruption : IFixComponent
	{
		[TagDetails(Tag = 41087, Type = TagType.Int, Offset = 0, Required = false)]
		public int? MarketDisruptionProvision {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public MarketDisruptionEventGrp? MarketDisruptionEventGrp {get; set;}
		
		[TagDetails(Tag = 41088, Type = TagType.Int, Offset = 2, Required = false)]
		public int? MarketDisruptionFallbackProvision {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public MarketDisruptionFallbackGrp? MarketDisruptionFallbackGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public MarketDisruptionFallbackReferencePriceGrp? MarketDisruptionFallbackReferencePriceGrp {get; set;}
		
		[TagDetails(Tag = 41089, Type = TagType.Int, Offset = 5, Required = false)]
		public int? MarketDisruptionMaximumDays {get; set;}
		
		[TagDetails(Tag = 41090, Type = TagType.Float, Offset = 6, Required = false)]
		public double? MarketDisruptionMaterialityPercentage {get; set;}
		
		[TagDetails(Tag = 41091, Type = TagType.Int, Offset = 7, Required = false)]
		public int? MarketDisruptionMinimumFuturesContracts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MarketDisruptionProvision is not null) writer.WriteWholeNumber(41087, MarketDisruptionProvision.Value);
			if (MarketDisruptionEventGrp is not null) ((IFixEncoder)MarketDisruptionEventGrp).Encode(writer);
			if (MarketDisruptionFallbackProvision is not null) writer.WriteWholeNumber(41088, MarketDisruptionFallbackProvision.Value);
			if (MarketDisruptionFallbackGrp is not null) ((IFixEncoder)MarketDisruptionFallbackGrp).Encode(writer);
			if (MarketDisruptionFallbackReferencePriceGrp is not null) ((IFixEncoder)MarketDisruptionFallbackReferencePriceGrp).Encode(writer);
			if (MarketDisruptionMaximumDays is not null) writer.WriteWholeNumber(41089, MarketDisruptionMaximumDays.Value);
			if (MarketDisruptionMaterialityPercentage is not null) writer.WriteNumber(41090, MarketDisruptionMaterialityPercentage.Value);
			if (MarketDisruptionMinimumFuturesContracts is not null) writer.WriteWholeNumber(41091, MarketDisruptionMinimumFuturesContracts.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			MarketDisruptionProvision = view.GetInt32(41087);
			if (view.GetView("MarketDisruptionEventGrp") is IMessageView viewMarketDisruptionEventGrp)
			{
				MarketDisruptionEventGrp = new();
				((IFixParser)MarketDisruptionEventGrp).Parse(viewMarketDisruptionEventGrp);
			}
			MarketDisruptionFallbackProvision = view.GetInt32(41088);
			if (view.GetView("MarketDisruptionFallbackGrp") is IMessageView viewMarketDisruptionFallbackGrp)
			{
				MarketDisruptionFallbackGrp = new();
				((IFixParser)MarketDisruptionFallbackGrp).Parse(viewMarketDisruptionFallbackGrp);
			}
			if (view.GetView("MarketDisruptionFallbackReferencePriceGrp") is IMessageView viewMarketDisruptionFallbackReferencePriceGrp)
			{
				MarketDisruptionFallbackReferencePriceGrp = new();
				((IFixParser)MarketDisruptionFallbackReferencePriceGrp).Parse(viewMarketDisruptionFallbackReferencePriceGrp);
			}
			MarketDisruptionMaximumDays = view.GetInt32(41089);
			MarketDisruptionMaterialityPercentage = view.GetDouble(41090);
			MarketDisruptionMinimumFuturesContracts = view.GetInt32(41091);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "MarketDisruptionProvision":
				{
					value = MarketDisruptionProvision;
					break;
				}
				case "MarketDisruptionEventGrp":
				{
					value = MarketDisruptionEventGrp;
					break;
				}
				case "MarketDisruptionFallbackProvision":
				{
					value = MarketDisruptionFallbackProvision;
					break;
				}
				case "MarketDisruptionFallbackGrp":
				{
					value = MarketDisruptionFallbackGrp;
					break;
				}
				case "MarketDisruptionFallbackReferencePriceGrp":
				{
					value = MarketDisruptionFallbackReferencePriceGrp;
					break;
				}
				case "MarketDisruptionMaximumDays":
				{
					value = MarketDisruptionMaximumDays;
					break;
				}
				case "MarketDisruptionMaterialityPercentage":
				{
					value = MarketDisruptionMaterialityPercentage;
					break;
				}
				case "MarketDisruptionMinimumFuturesContracts":
				{
					value = MarketDisruptionMinimumFuturesContracts;
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
			MarketDisruptionProvision = null;
			((IFixReset?)MarketDisruptionEventGrp)?.Reset();
			MarketDisruptionFallbackProvision = null;
			((IFixReset?)MarketDisruptionFallbackGrp)?.Reset();
			((IFixReset?)MarketDisruptionFallbackReferencePriceGrp)?.Reset();
			MarketDisruptionMaximumDays = null;
			MarketDisruptionMaterialityPercentage = null;
			MarketDisruptionMinimumFuturesContracts = null;
		}
	}
}
