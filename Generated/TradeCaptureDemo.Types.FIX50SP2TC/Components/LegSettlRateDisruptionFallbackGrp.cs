using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSettlRateDisruptionFallbackGrp : IFixComponent
	{
		public sealed partial class NoLegSettlRateFallbacks : IFixGroup
		{
			[TagDetails(Tag = 40903, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegSettlRatePostponementMaximumDays {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public LegSettlRateFallbackRateSource? LegSettlRateFallbackRateSource {get; set;}
			
			[TagDetails(Tag = 40905, Type = TagType.Boolean, Offset = 2, Required = false)]
			public bool? LegSettlRatePostponementSurvey {get; set;}
			
			[TagDetails(Tag = 40906, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegSettlRatePostponementCalculationAgent {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegSettlRatePostponementMaximumDays is not null) writer.WriteWholeNumber(40903, LegSettlRatePostponementMaximumDays.Value);
				if (LegSettlRateFallbackRateSource is not null) ((IFixEncoder)LegSettlRateFallbackRateSource).Encode(writer);
				if (LegSettlRatePostponementSurvey is not null) writer.WriteBoolean(40905, LegSettlRatePostponementSurvey.Value);
				if (LegSettlRatePostponementCalculationAgent is not null) writer.WriteWholeNumber(40906, LegSettlRatePostponementCalculationAgent.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegSettlRatePostponementMaximumDays = view.GetInt32(40903);
				if (view.GetView("LegSettlRateFallbackRateSource") is IMessageView viewLegSettlRateFallbackRateSource)
				{
					LegSettlRateFallbackRateSource = new();
					((IFixParser)LegSettlRateFallbackRateSource).Parse(viewLegSettlRateFallbackRateSource);
				}
				LegSettlRatePostponementSurvey = view.GetBool(40905);
				LegSettlRatePostponementCalculationAgent = view.GetInt32(40906);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegSettlRatePostponementMaximumDays":
					{
						value = LegSettlRatePostponementMaximumDays;
						break;
					}
					case "LegSettlRateFallbackRateSource":
					{
						value = LegSettlRateFallbackRateSource;
						break;
					}
					case "LegSettlRatePostponementSurvey":
					{
						value = LegSettlRatePostponementSurvey;
						break;
					}
					case "LegSettlRatePostponementCalculationAgent":
					{
						value = LegSettlRatePostponementCalculationAgent;
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
				LegSettlRatePostponementMaximumDays = null;
				((IFixReset?)LegSettlRateFallbackRateSource)?.Reset();
				LegSettlRatePostponementSurvey = null;
				LegSettlRatePostponementCalculationAgent = null;
			}
		}
		[Group(NoOfTag = 40902, Offset = 0, Required = false)]
		public NoLegSettlRateFallbacks[]? LegSettlRateFallbacks {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSettlRateFallbacks is not null && LegSettlRateFallbacks.Length != 0)
			{
				writer.WriteWholeNumber(40902, LegSettlRateFallbacks.Length);
				for (int i = 0; i < LegSettlRateFallbacks.Length; i++)
				{
					((IFixEncoder)LegSettlRateFallbacks[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegSettlRateFallbacks") is IMessageView viewNoLegSettlRateFallbacks)
			{
				var count = viewNoLegSettlRateFallbacks.GroupCount();
				LegSettlRateFallbacks = new NoLegSettlRateFallbacks[count];
				for (int i = 0; i < count; i++)
				{
					LegSettlRateFallbacks[i] = new();
					((IFixParser)LegSettlRateFallbacks[i]).Parse(viewNoLegSettlRateFallbacks.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegSettlRateFallbacks":
				{
					value = LegSettlRateFallbacks;
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
			LegSettlRateFallbacks = null;
		}
	}
}
