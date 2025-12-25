using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegFinancingContractualDefinitionsGrp : IFixComponent
	{
		public sealed partial class NoLegContractualDefinitions : IFixGroup
		{
			[TagDetails(Tag = 42199, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegContractualDefinition {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegContractualDefinition is not null) writer.WriteString(42199, LegContractualDefinition);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegContractualDefinition = view.GetString(42199);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegContractualDefinition":
					{
						value = LegContractualDefinition;
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
				LegContractualDefinition = null;
			}
		}
		[Group(NoOfTag = 42198, Offset = 0, Required = false)]
		public NoLegContractualDefinitions[]? LegContractualDefinitions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegContractualDefinitions is not null && LegContractualDefinitions.Length != 0)
			{
				writer.WriteWholeNumber(42198, LegContractualDefinitions.Length);
				for (int i = 0; i < LegContractualDefinitions.Length; i++)
				{
					((IFixEncoder)LegContractualDefinitions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegContractualDefinitions") is IMessageView viewNoLegContractualDefinitions)
			{
				var count = viewNoLegContractualDefinitions.GroupCount();
				LegContractualDefinitions = new NoLegContractualDefinitions[count];
				for (int i = 0; i < count; i++)
				{
					LegContractualDefinitions[i] = new();
					((IFixParser)LegContractualDefinitions[i]).Parse(viewNoLegContractualDefinitions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegContractualDefinitions":
				{
					value = LegContractualDefinitions;
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
			LegContractualDefinitions = null;
		}
	}
}
