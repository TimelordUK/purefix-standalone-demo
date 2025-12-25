using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegFinancingContractualMatrixGrp : IFixComponent
	{
		public sealed partial class NoLegContractualMatrices : IFixGroup
		{
			[TagDetails(Tag = 42204, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegContractualMatrixSource {get; set;}
			
			[TagDetails(Tag = 42205, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? LegContractualMatrixDate {get; set;}
			
			[TagDetails(Tag = 42206, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegContractualMatrixTerm {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegContractualMatrixSource is not null) writer.WriteString(42204, LegContractualMatrixSource);
				if (LegContractualMatrixDate is not null) writer.WriteLocalDateOnly(42205, LegContractualMatrixDate.Value);
				if (LegContractualMatrixTerm is not null) writer.WriteString(42206, LegContractualMatrixTerm);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegContractualMatrixSource = view.GetString(42204);
				LegContractualMatrixDate = view.GetDateOnly(42205);
				LegContractualMatrixTerm = view.GetString(42206);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegContractualMatrixSource":
					{
						value = LegContractualMatrixSource;
						break;
					}
					case "LegContractualMatrixDate":
					{
						value = LegContractualMatrixDate;
						break;
					}
					case "LegContractualMatrixTerm":
					{
						value = LegContractualMatrixTerm;
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
				LegContractualMatrixSource = null;
				LegContractualMatrixDate = null;
				LegContractualMatrixTerm = null;
			}
		}
		[Group(NoOfTag = 42203, Offset = 0, Required = false)]
		public NoLegContractualMatrices[]? LegContractualMatrices {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegContractualMatrices is not null && LegContractualMatrices.Length != 0)
			{
				writer.WriteWholeNumber(42203, LegContractualMatrices.Length);
				for (int i = 0; i < LegContractualMatrices.Length; i++)
				{
					((IFixEncoder)LegContractualMatrices[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegContractualMatrices") is IMessageView viewNoLegContractualMatrices)
			{
				var count = viewNoLegContractualMatrices.GroupCount();
				LegContractualMatrices = new NoLegContractualMatrices[count];
				for (int i = 0; i < count; i++)
				{
					LegContractualMatrices[i] = new();
					((IFixParser)LegContractualMatrices[i]).Parse(viewNoLegContractualMatrices.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegContractualMatrices":
				{
					value = LegContractualMatrices;
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
			LegContractualMatrices = null;
		}
	}
}
