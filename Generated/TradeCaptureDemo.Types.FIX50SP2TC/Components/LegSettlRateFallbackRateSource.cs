using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegSettlRateFallbackRateSource : IFixComponent
	{
		[TagDetails(Tag = 40366, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegSettlRateFallbackRateSourceValue {get; set;}
		
		[TagDetails(Tag = 40370, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegSettlRateFallbackReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegSettlRateFallbackRateSourceValue is not null) writer.WriteWholeNumber(40366, LegSettlRateFallbackRateSourceValue.Value);
			if (LegSettlRateFallbackReferencePage is not null) writer.WriteString(40370, LegSettlRateFallbackReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegSettlRateFallbackRateSourceValue = view.GetInt32(40366);
			LegSettlRateFallbackReferencePage = view.GetString(40370);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegSettlRateFallbackRateSource":
				{
					value = LegSettlRateFallbackRateSourceValue;
					break;
				}
				case "LegSettlRateFallbackReferencePage":
				{
					value = LegSettlRateFallbackReferencePage;
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
			LegSettlRateFallbackRateSourceValue = null;
			LegSettlRateFallbackReferencePage = null;
		}
	}
}
