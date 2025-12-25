using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSettlRateDisruptionFallbackGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingSettlRateFallbacks : IFixGroup
		{
			[TagDetails(Tag = 40660, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingSettlRatePostponementMaximumDays {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public UnderlyingSettlRateFallbackRateSource? UnderlyingSettlRateFallbackRateSource {get; set;}
			
			[TagDetails(Tag = 40662, Type = TagType.Boolean, Offset = 2, Required = false)]
			public bool? UnderlyingSettlRatePostponementSurvey {get; set;}
			
			[TagDetails(Tag = 40663, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingSettlRatePostponementCalculationAgent {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingSettlRatePostponementMaximumDays is not null) writer.WriteWholeNumber(40660, UnderlyingSettlRatePostponementMaximumDays.Value);
				if (UnderlyingSettlRateFallbackRateSource is not null) ((IFixEncoder)UnderlyingSettlRateFallbackRateSource).Encode(writer);
				if (UnderlyingSettlRatePostponementSurvey is not null) writer.WriteBoolean(40662, UnderlyingSettlRatePostponementSurvey.Value);
				if (UnderlyingSettlRatePostponementCalculationAgent is not null) writer.WriteWholeNumber(40663, UnderlyingSettlRatePostponementCalculationAgent.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingSettlRatePostponementMaximumDays = view.GetInt32(40660);
				if (view.GetView("UnderlyingSettlRateFallbackRateSource") is IMessageView viewUnderlyingSettlRateFallbackRateSource)
				{
					UnderlyingSettlRateFallbackRateSource = new();
					((IFixParser)UnderlyingSettlRateFallbackRateSource).Parse(viewUnderlyingSettlRateFallbackRateSource);
				}
				UnderlyingSettlRatePostponementSurvey = view.GetBool(40662);
				UnderlyingSettlRatePostponementCalculationAgent = view.GetInt32(40663);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingSettlRatePostponementMaximumDays":
					{
						value = UnderlyingSettlRatePostponementMaximumDays;
						break;
					}
					case "UnderlyingSettlRateFallbackRateSource":
					{
						value = UnderlyingSettlRateFallbackRateSource;
						break;
					}
					case "UnderlyingSettlRatePostponementSurvey":
					{
						value = UnderlyingSettlRatePostponementSurvey;
						break;
					}
					case "UnderlyingSettlRatePostponementCalculationAgent":
					{
						value = UnderlyingSettlRatePostponementCalculationAgent;
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
				UnderlyingSettlRatePostponementMaximumDays = null;
				((IFixReset?)UnderlyingSettlRateFallbackRateSource)?.Reset();
				UnderlyingSettlRatePostponementSurvey = null;
				UnderlyingSettlRatePostponementCalculationAgent = null;
			}
		}
		[Group(NoOfTag = 40659, Offset = 0, Required = false)]
		public NoUnderlyingSettlRateFallbacks[]? UnderlyingSettlRateFallbacks {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSettlRateFallbacks is not null && UnderlyingSettlRateFallbacks.Length != 0)
			{
				writer.WriteWholeNumber(40659, UnderlyingSettlRateFallbacks.Length);
				for (int i = 0; i < UnderlyingSettlRateFallbacks.Length; i++)
				{
					((IFixEncoder)UnderlyingSettlRateFallbacks[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingSettlRateFallbacks") is IMessageView viewNoUnderlyingSettlRateFallbacks)
			{
				var count = viewNoUnderlyingSettlRateFallbacks.GroupCount();
				UnderlyingSettlRateFallbacks = new NoUnderlyingSettlRateFallbacks[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingSettlRateFallbacks[i] = new();
					((IFixParser)UnderlyingSettlRateFallbacks[i]).Parse(viewNoUnderlyingSettlRateFallbacks.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingSettlRateFallbacks":
				{
					value = UnderlyingSettlRateFallbacks;
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
			UnderlyingSettlRateFallbacks = null;
		}
	}
}
