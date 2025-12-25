using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingMarketDisruption : IFixComponent
	{
		[TagDetails(Tag = 41859, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingMarketDisruptionProvision {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingMarketDisruptionEventGrp? UnderlyingMarketDisruptionEventGrp {get; set;}
		
		[TagDetails(Tag = 41860, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingMarketDisruptionFallbackProvision {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public UnderlyingMarketDisruptionFallbackGrp? UnderlyingMarketDisruptionFallbackGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingMarketDisruptionFallbackReferencePriceGrp? UnderlyingMarketDisruptionFallbackReferencePriceGrp {get; set;}
		
		[TagDetails(Tag = 41861, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingMarketDisruptionMaximumDays {get; set;}
		
		[TagDetails(Tag = 41862, Type = TagType.Float, Offset = 6, Required = false)]
		public double? UnderlyingMarketDisruptionMaterialityPercentage {get; set;}
		
		[TagDetails(Tag = 41863, Type = TagType.Int, Offset = 7, Required = false)]
		public int? UnderlyingMarketDisruptionMinimumFuturesContracts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingMarketDisruptionProvision is not null) writer.WriteWholeNumber(41859, UnderlyingMarketDisruptionProvision.Value);
			if (UnderlyingMarketDisruptionEventGrp is not null) ((IFixEncoder)UnderlyingMarketDisruptionEventGrp).Encode(writer);
			if (UnderlyingMarketDisruptionFallbackProvision is not null) writer.WriteWholeNumber(41860, UnderlyingMarketDisruptionFallbackProvision.Value);
			if (UnderlyingMarketDisruptionFallbackGrp is not null) ((IFixEncoder)UnderlyingMarketDisruptionFallbackGrp).Encode(writer);
			if (UnderlyingMarketDisruptionFallbackReferencePriceGrp is not null) ((IFixEncoder)UnderlyingMarketDisruptionFallbackReferencePriceGrp).Encode(writer);
			if (UnderlyingMarketDisruptionMaximumDays is not null) writer.WriteWholeNumber(41861, UnderlyingMarketDisruptionMaximumDays.Value);
			if (UnderlyingMarketDisruptionMaterialityPercentage is not null) writer.WriteNumber(41862, UnderlyingMarketDisruptionMaterialityPercentage.Value);
			if (UnderlyingMarketDisruptionMinimumFuturesContracts is not null) writer.WriteWholeNumber(41863, UnderlyingMarketDisruptionMinimumFuturesContracts.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingMarketDisruptionProvision = view.GetInt32(41859);
			if (view.GetView("UnderlyingMarketDisruptionEventGrp") is IMessageView viewUnderlyingMarketDisruptionEventGrp)
			{
				UnderlyingMarketDisruptionEventGrp = new();
				((IFixParser)UnderlyingMarketDisruptionEventGrp).Parse(viewUnderlyingMarketDisruptionEventGrp);
			}
			UnderlyingMarketDisruptionFallbackProvision = view.GetInt32(41860);
			if (view.GetView("UnderlyingMarketDisruptionFallbackGrp") is IMessageView viewUnderlyingMarketDisruptionFallbackGrp)
			{
				UnderlyingMarketDisruptionFallbackGrp = new();
				((IFixParser)UnderlyingMarketDisruptionFallbackGrp).Parse(viewUnderlyingMarketDisruptionFallbackGrp);
			}
			if (view.GetView("UnderlyingMarketDisruptionFallbackReferencePriceGrp") is IMessageView viewUnderlyingMarketDisruptionFallbackReferencePriceGrp)
			{
				UnderlyingMarketDisruptionFallbackReferencePriceGrp = new();
				((IFixParser)UnderlyingMarketDisruptionFallbackReferencePriceGrp).Parse(viewUnderlyingMarketDisruptionFallbackReferencePriceGrp);
			}
			UnderlyingMarketDisruptionMaximumDays = view.GetInt32(41861);
			UnderlyingMarketDisruptionMaterialityPercentage = view.GetDouble(41862);
			UnderlyingMarketDisruptionMinimumFuturesContracts = view.GetInt32(41863);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingMarketDisruptionProvision":
				{
					value = UnderlyingMarketDisruptionProvision;
					break;
				}
				case "UnderlyingMarketDisruptionEventGrp":
				{
					value = UnderlyingMarketDisruptionEventGrp;
					break;
				}
				case "UnderlyingMarketDisruptionFallbackProvision":
				{
					value = UnderlyingMarketDisruptionFallbackProvision;
					break;
				}
				case "UnderlyingMarketDisruptionFallbackGrp":
				{
					value = UnderlyingMarketDisruptionFallbackGrp;
					break;
				}
				case "UnderlyingMarketDisruptionFallbackReferencePriceGrp":
				{
					value = UnderlyingMarketDisruptionFallbackReferencePriceGrp;
					break;
				}
				case "UnderlyingMarketDisruptionMaximumDays":
				{
					value = UnderlyingMarketDisruptionMaximumDays;
					break;
				}
				case "UnderlyingMarketDisruptionMaterialityPercentage":
				{
					value = UnderlyingMarketDisruptionMaterialityPercentage;
					break;
				}
				case "UnderlyingMarketDisruptionMinimumFuturesContracts":
				{
					value = UnderlyingMarketDisruptionMinimumFuturesContracts;
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
			UnderlyingMarketDisruptionProvision = null;
			((IFixReset?)UnderlyingMarketDisruptionEventGrp)?.Reset();
			UnderlyingMarketDisruptionFallbackProvision = null;
			((IFixReset?)UnderlyingMarketDisruptionFallbackGrp)?.Reset();
			((IFixReset?)UnderlyingMarketDisruptionFallbackReferencePriceGrp)?.Reset();
			UnderlyingMarketDisruptionMaximumDays = null;
			UnderlyingMarketDisruptionMaterialityPercentage = null;
			UnderlyingMarketDisruptionMinimumFuturesContracts = null;
		}
	}
}
