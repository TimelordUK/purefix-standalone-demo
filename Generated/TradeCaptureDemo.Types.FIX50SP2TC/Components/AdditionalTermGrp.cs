using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AdditionalTermGrp : IFixComponent
	{
		public sealed partial class NoAdditionalTerms : IFixGroup
		{
			[TagDetails(Tag = 40020, Type = TagType.Boolean, Offset = 0, Required = false)]
			public bool? AdditionalTermConditionPrecedentBondIndicator {get; set;}
			
			[TagDetails(Tag = 40021, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? AdditionalTermDiscrepancyClauseIndicator {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public AdditionalTermBondRefGrp? AdditionalTermBondRefGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AdditionalTermConditionPrecedentBondIndicator is not null) writer.WriteBoolean(40020, AdditionalTermConditionPrecedentBondIndicator.Value);
				if (AdditionalTermDiscrepancyClauseIndicator is not null) writer.WriteBoolean(40021, AdditionalTermDiscrepancyClauseIndicator.Value);
				if (AdditionalTermBondRefGrp is not null) ((IFixEncoder)AdditionalTermBondRefGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AdditionalTermConditionPrecedentBondIndicator = view.GetBool(40020);
				AdditionalTermDiscrepancyClauseIndicator = view.GetBool(40021);
				if (view.GetView("AdditionalTermBondRefGrp") is IMessageView viewAdditionalTermBondRefGrp)
				{
					AdditionalTermBondRefGrp = new();
					((IFixParser)AdditionalTermBondRefGrp).Parse(viewAdditionalTermBondRefGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AdditionalTermConditionPrecedentBondIndicator":
					{
						value = AdditionalTermConditionPrecedentBondIndicator;
						break;
					}
					case "AdditionalTermDiscrepancyClauseIndicator":
					{
						value = AdditionalTermDiscrepancyClauseIndicator;
						break;
					}
					case "AdditionalTermBondRefGrp":
					{
						value = AdditionalTermBondRefGrp;
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
				AdditionalTermConditionPrecedentBondIndicator = null;
				AdditionalTermDiscrepancyClauseIndicator = null;
				((IFixReset?)AdditionalTermBondRefGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 40019, Offset = 0, Required = false)]
		public NoAdditionalTerms[]? AdditionalTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AdditionalTerms is not null && AdditionalTerms.Length != 0)
			{
				writer.WriteWholeNumber(40019, AdditionalTerms.Length);
				for (int i = 0; i < AdditionalTerms.Length; i++)
				{
					((IFixEncoder)AdditionalTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAdditionalTerms") is IMessageView viewNoAdditionalTerms)
			{
				var count = viewNoAdditionalTerms.GroupCount();
				AdditionalTerms = new NoAdditionalTerms[count];
				for (int i = 0; i < count; i++)
				{
					AdditionalTerms[i] = new();
					((IFixParser)AdditionalTerms[i]).Parse(viewNoAdditionalTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAdditionalTerms":
				{
					value = AdditionalTerms;
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
			AdditionalTerms = null;
		}
	}
}
