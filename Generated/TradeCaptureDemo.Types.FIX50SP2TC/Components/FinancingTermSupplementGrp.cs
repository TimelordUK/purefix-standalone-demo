using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FinancingTermSupplementGrp : IFixComponent
	{
		public sealed partial class NoFinancingTermSupplements : IFixGroup
		{
			[TagDetails(Tag = 40047, Type = TagType.String, Offset = 0, Required = false)]
			public string? FinancingTermSupplementDesc {get; set;}
			
			[TagDetails(Tag = 40048, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? FinancingTermSupplementDate {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (FinancingTermSupplementDesc is not null) writer.WriteString(40047, FinancingTermSupplementDesc);
				if (FinancingTermSupplementDate is not null) writer.WriteLocalDateOnly(40048, FinancingTermSupplementDate.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				FinancingTermSupplementDesc = view.GetString(40047);
				FinancingTermSupplementDate = view.GetDateOnly(40048);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "FinancingTermSupplementDesc":
					{
						value = FinancingTermSupplementDesc;
						break;
					}
					case "FinancingTermSupplementDate":
					{
						value = FinancingTermSupplementDate;
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
				FinancingTermSupplementDesc = null;
				FinancingTermSupplementDate = null;
			}
		}
		[Group(NoOfTag = 40046, Offset = 0, Required = false)]
		public NoFinancingTermSupplements[]? FinancingTermSupplements {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (FinancingTermSupplements is not null && FinancingTermSupplements.Length != 0)
			{
				writer.WriteWholeNumber(40046, FinancingTermSupplements.Length);
				for (int i = 0; i < FinancingTermSupplements.Length; i++)
				{
					((IFixEncoder)FinancingTermSupplements[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoFinancingTermSupplements") is IMessageView viewNoFinancingTermSupplements)
			{
				var count = viewNoFinancingTermSupplements.GroupCount();
				FinancingTermSupplements = new NoFinancingTermSupplements[count];
				for (int i = 0; i < count; i++)
				{
					FinancingTermSupplements[i] = new();
					((IFixParser)FinancingTermSupplements[i]).Parse(viewNoFinancingTermSupplements.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoFinancingTermSupplements":
				{
					value = FinancingTermSupplements;
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
			FinancingTermSupplements = null;
		}
	}
}
