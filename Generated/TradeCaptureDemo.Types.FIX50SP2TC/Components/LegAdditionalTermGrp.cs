using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegAdditionalTermGrp : IFixComponent
	{
		public sealed partial class NoLegAdditionalTerms : IFixGroup
		{
			[TagDetails(Tag = 41336, Type = TagType.Boolean, Offset = 0, Required = false)]
			public bool? LegAdditionalTermConditionPrecedentBondIndicator {get; set;}
			
			[TagDetails(Tag = 41337, Type = TagType.Boolean, Offset = 1, Required = false)]
			public bool? LegAdditionalTermDiscrepancyClauseIndicator {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public LegAdditionalTermBondRefGrp? LegAdditionalTermBondRefGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegAdditionalTermConditionPrecedentBondIndicator is not null) writer.WriteBoolean(41336, LegAdditionalTermConditionPrecedentBondIndicator.Value);
				if (LegAdditionalTermDiscrepancyClauseIndicator is not null) writer.WriteBoolean(41337, LegAdditionalTermDiscrepancyClauseIndicator.Value);
				if (LegAdditionalTermBondRefGrp is not null) ((IFixEncoder)LegAdditionalTermBondRefGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegAdditionalTermConditionPrecedentBondIndicator = view.GetBool(41336);
				LegAdditionalTermDiscrepancyClauseIndicator = view.GetBool(41337);
				if (view.GetView("LegAdditionalTermBondRefGrp") is IMessageView viewLegAdditionalTermBondRefGrp)
				{
					LegAdditionalTermBondRefGrp = new();
					((IFixParser)LegAdditionalTermBondRefGrp).Parse(viewLegAdditionalTermBondRefGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegAdditionalTermConditionPrecedentBondIndicator":
					{
						value = LegAdditionalTermConditionPrecedentBondIndicator;
						break;
					}
					case "LegAdditionalTermDiscrepancyClauseIndicator":
					{
						value = LegAdditionalTermDiscrepancyClauseIndicator;
						break;
					}
					case "LegAdditionalTermBondRefGrp":
					{
						value = LegAdditionalTermBondRefGrp;
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
				LegAdditionalTermConditionPrecedentBondIndicator = null;
				LegAdditionalTermDiscrepancyClauseIndicator = null;
				((IFixReset?)LegAdditionalTermBondRefGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41335, Offset = 0, Required = false)]
		public NoLegAdditionalTerms[]? LegAdditionalTerms {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegAdditionalTerms is not null && LegAdditionalTerms.Length != 0)
			{
				writer.WriteWholeNumber(41335, LegAdditionalTerms.Length);
				for (int i = 0; i < LegAdditionalTerms.Length; i++)
				{
					((IFixEncoder)LegAdditionalTerms[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegAdditionalTerms") is IMessageView viewNoLegAdditionalTerms)
			{
				var count = viewNoLegAdditionalTerms.GroupCount();
				LegAdditionalTerms = new NoLegAdditionalTerms[count];
				for (int i = 0; i < count; i++)
				{
					LegAdditionalTerms[i] = new();
					((IFixParser)LegAdditionalTerms[i]).Parse(viewNoLegAdditionalTerms.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegAdditionalTerms":
				{
					value = LegAdditionalTerms;
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
			LegAdditionalTerms = null;
		}
	}
}
