using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlQuoteSource : IFixComponent
	{
		[TagDetails(Tag = 40112, Type = TagType.Int, Offset = 0, Required = false)]
		public int? ProvisionCashSettlQuoteSourceValue {get; set;}
		
		[TagDetails(Tag = 41406, Type = TagType.String, Offset = 1, Required = false)]
		public string? ProvisionCashSettlQuoteReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlQuoteSourceValue is not null) writer.WriteWholeNumber(40112, ProvisionCashSettlQuoteSourceValue.Value);
			if (ProvisionCashSettlQuoteReferencePage is not null) writer.WriteString(41406, ProvisionCashSettlQuoteReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ProvisionCashSettlQuoteSourceValue = view.GetInt32(40112);
			ProvisionCashSettlQuoteReferencePage = view.GetString(41406);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ProvisionCashSettlQuoteSource":
				{
					value = ProvisionCashSettlQuoteSourceValue;
					break;
				}
				case "ProvisionCashSettlQuoteReferencePage":
				{
					value = ProvisionCashSettlQuoteReferencePage;
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
			ProvisionCashSettlQuoteSourceValue = null;
			ProvisionCashSettlQuoteReferencePage = null;
		}
	}
}
