using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FinancingContractualMatrixGrp : IFixComponent
	{
		public sealed partial class NoContractualMatrices : IFixGroup
		{
			[TagDetails(Tag = 40043, Type = TagType.String, Offset = 0, Required = false)]
			public string? ContractualMatrixSource {get; set;}
			
			[TagDetails(Tag = 40044, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? ContractualMatrixDate {get; set;}
			
			[TagDetails(Tag = 40045, Type = TagType.String, Offset = 2, Required = false)]
			public string? ContractualMatrixTerm {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ContractualMatrixSource is not null) writer.WriteString(40043, ContractualMatrixSource);
				if (ContractualMatrixDate is not null) writer.WriteLocalDateOnly(40044, ContractualMatrixDate.Value);
				if (ContractualMatrixTerm is not null) writer.WriteString(40045, ContractualMatrixTerm);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ContractualMatrixSource = view.GetString(40043);
				ContractualMatrixDate = view.GetDateOnly(40044);
				ContractualMatrixTerm = view.GetString(40045);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ContractualMatrixSource":
					{
						value = ContractualMatrixSource;
						break;
					}
					case "ContractualMatrixDate":
					{
						value = ContractualMatrixDate;
						break;
					}
					case "ContractualMatrixTerm":
					{
						value = ContractualMatrixTerm;
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
				ContractualMatrixSource = null;
				ContractualMatrixDate = null;
				ContractualMatrixTerm = null;
			}
		}
		[Group(NoOfTag = 40042, Offset = 0, Required = false)]
		public NoContractualMatrices[]? ContractualMatrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ContractualMatrices is not null && ContractualMatrices.Length != 0)
			{
				writer.WriteWholeNumber(40042, ContractualMatrices.Length);
				for (int i = 0; i < ContractualMatrices.Length; i++)
				{
					((IFixEncoder)ContractualMatrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoContractualMatrices") is IMessageView viewNoContractualMatrices)
			{
				var count = viewNoContractualMatrices.GroupCount();
				ContractualMatrices = new NoContractualMatrices[count];
				for (int i = 0; i < count; i++)
				{
					ContractualMatrices[i] = new();
					((IFixParser)ContractualMatrices[i]).Parse(viewNoContractualMatrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoContractualMatrices":
				{
					value = ContractualMatrices;
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
			ContractualMatrices = null;
		}
	}
}
