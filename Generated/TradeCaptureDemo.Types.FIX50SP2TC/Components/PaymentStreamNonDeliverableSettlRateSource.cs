using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamNonDeliverableSettlRateSource : IFixComponent
	{
		[TagDetails(Tag = 40371, Type = TagType.Int, Offset = 0, Required = false)]
		public int? PaymentStreamNonDeliverableSettlRateSourceValue {get; set;}
		
		[TagDetails(Tag = 40372, Type = TagType.String, Offset = 1, Required = false)]
		public string? PaymentStreamNonDeliverableSettlReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamNonDeliverableSettlRateSourceValue is not null) writer.WriteWholeNumber(40371, PaymentStreamNonDeliverableSettlRateSourceValue.Value);
			if (PaymentStreamNonDeliverableSettlReferencePage is not null) writer.WriteString(40372, PaymentStreamNonDeliverableSettlReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamNonDeliverableSettlRateSourceValue = view.GetInt32(40371);
			PaymentStreamNonDeliverableSettlReferencePage = view.GetString(40372);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamNonDeliverableSettlRateSource":
				{
					value = PaymentStreamNonDeliverableSettlRateSourceValue;
					break;
				}
				case "PaymentStreamNonDeliverableSettlReferencePage":
				{
					value = PaymentStreamNonDeliverableSettlReferencePage;
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
			PaymentStreamNonDeliverableSettlRateSourceValue = null;
			PaymentStreamNonDeliverableSettlReferencePage = null;
		}
	}
}
