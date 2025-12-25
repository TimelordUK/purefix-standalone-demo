using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingAdditionalTermGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingAdditionalTerms : IFixGroup
		{
			[TagDetails(Tag = 42037, Type = TagType.Boolean, Offset = 0, Required = false)]
			public bool? UnderlyingAdditionalTermConditionPrecedentBondIndicator {get; set;}
			
			[TagDetails(Tag = 42038, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? UnderlyingAdditionalTermDiscrepancyClauseIndicator {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UnderlyingAdditionalTermBondRefGrp? UnderlyingAdditionalTermBondRefGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingAdditionalTermConditionPrecedentBondIndicator is not null) writer.WriteBoolean(42037, UnderlyingAdditionalTermConditionPrecedentBondIndicator.Value);
				if (UnderlyingAdditionalTermDiscrepancyClauseIndicator is not null) writer.WriteBoolean(42038, UnderlyingAdditionalTermDiscrepancyClauseIndicator.Value);
				if (UnderlyingAdditionalTermBondRefGrp is not null) ((IFixEncoder)UnderlyingAdditionalTermBondRefGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingAdditionalTermConditionPrecedentBondIndicator = view.GetBool(42037);
				UnderlyingAdditionalTermDiscrepancyClauseIndicator = view.GetBool(42038);
				if (view.GetView("UnderlyingAdditionalTermBondRefGrp") is IMessageView viewUnderlyingAdditionalTermBondRefGrp)
				{
					UnderlyingAdditionalTermBondRefGrp = new();
					((IFixParser)UnderlyingAdditionalTermBondRefGrp).Parse(viewUnderlyingAdditionalTermBondRefGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingAdditionalTermConditionPrecedentBondIndicator":
					{
						value = UnderlyingAdditionalTermConditionPrecedentBondIndicator;
						break;
					}
					case "UnderlyingAdditionalTermDiscrepancyClauseIndicator":
					{
						value = UnderlyingAdditionalTermDiscrepancyClauseIndicator;
						break;
					}
					case "UnderlyingAdditionalTermBondRefGrp":
					{
						value = UnderlyingAdditionalTermBondRefGrp;
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
				UnderlyingAdditionalTermConditionPrecedentBondIndicator = null;
				UnderlyingAdditionalTermDiscrepancyClauseIndicator = null;
				((IFixReset?)UnderlyingAdditionalTermBondRefGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 42036, Offset = 0, Required = false)]
		public NoUnderlyingAdditionalTerms[]? UnderlyingAdditionalTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingAdditionalTerms is not null && UnderlyingAdditionalTerms.Length != 0)
			{
				writer.WriteWholeNumber(42036, UnderlyingAdditionalTerms.Length);
				for (int i = 0; i < UnderlyingAdditionalTerms.Length; i++)
				{
					((IFixEncoder)UnderlyingAdditionalTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingAdditionalTerms") is IMessageView viewNoUnderlyingAdditionalTerms)
			{
				var count = viewNoUnderlyingAdditionalTerms.GroupCount();
				UnderlyingAdditionalTerms = new NoUnderlyingAdditionalTerms[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingAdditionalTerms[i] = new();
					((IFixParser)UnderlyingAdditionalTerms[i]).Parse(viewNoUnderlyingAdditionalTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingAdditionalTerms":
				{
					value = UnderlyingAdditionalTerms;
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
			UnderlyingAdditionalTerms = null;
		}
	}
}
