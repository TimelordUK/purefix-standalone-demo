using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamNonDeliverableSettlRateSource : IFixComponent
	{
		[TagDetails(Tag = 40087, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegPaymentStreamNonDeliverableSettlRateSourceValue {get; set;}
		
		[TagDetails(Tag = 40228, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegPaymentStreamNonDeliverableSettlReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamNonDeliverableSettlRateSourceValue is not null) writer.WriteWholeNumber(40087, LegPaymentStreamNonDeliverableSettlRateSourceValue.Value);
			if (LegPaymentStreamNonDeliverableSettlReferencePage is not null) writer.WriteString(40228, LegPaymentStreamNonDeliverableSettlReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamNonDeliverableSettlRateSourceValue = view.GetInt32(40087);
			LegPaymentStreamNonDeliverableSettlReferencePage = view.GetString(40228);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamNonDeliverableSettlRateSource":
				{
					value = LegPaymentStreamNonDeliverableSettlRateSourceValue;
					break;
				}
				case "LegPaymentStreamNonDeliverableSettlReferencePage":
				{
					value = LegPaymentStreamNonDeliverableSettlReferencePage;
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
			LegPaymentStreamNonDeliverableSettlRateSourceValue = null;
			LegPaymentStreamNonDeliverableSettlReferencePage = null;
		}
	}
}
