using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FinancingContractualDefinitionGrp : IFixComponent
	{
		public sealed partial class NoContractualDefinitions : IFixGroup
		{
			[TagDetails(Tag = 40041, Type = TagType.String, Offset = 0, Required = false)]
			public string? ContractualDefinition {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ContractualDefinition is not null) writer.WriteString(40041, ContractualDefinition);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ContractualDefinition = view.GetString(40041);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ContractualDefinition":
					{
						value = ContractualDefinition;
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
				ContractualDefinition = null;
			}
		}
		[Group(NoOfTag = 40040, Offset = 0, Required = false)]
		public NoContractualDefinitions[]? ContractualDefinitions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ContractualDefinitions is not null && ContractualDefinitions.Length != 0)
			{
				writer.WriteWholeNumber(40040, ContractualDefinitions.Length);
				for (int i = 0; i < ContractualDefinitions.Length; i++)
				{
					((IFixEncoder)ContractualDefinitions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoContractualDefinitions") is IMessageView viewNoContractualDefinitions)
			{
				var count = viewNoContractualDefinitions.GroupCount();
				ContractualDefinitions = new NoContractualDefinitions[count];
				for (int i = 0; i < count; i++)
				{
					ContractualDefinitions[i] = new();
					((IFixParser)ContractualDefinitions[i]).Parse(viewNoContractualDefinitions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoContractualDefinitions":
				{
					value = ContractualDefinitions;
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
			ContractualDefinitions = null;
		}
	}
}
