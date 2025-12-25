using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingSettlRateFallbackRateSource : IFixComponent
	{
		[TagDetails(Tag = 40904, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingSettlRateFallbackRateSourceValue {get; set;}
		
		[TagDetails(Tag = 40915, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingSettlRateFallbackReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingSettlRateFallbackRateSourceValue is not null) writer.WriteWholeNumber(40904, UnderlyingSettlRateFallbackRateSourceValue.Value);
			if (UnderlyingSettlRateFallbackReferencePage is not null) writer.WriteString(40915, UnderlyingSettlRateFallbackReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingSettlRateFallbackRateSourceValue = view.GetInt32(40904);
			UnderlyingSettlRateFallbackReferencePage = view.GetString(40915);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingSettlRateFallbackRateSource":
				{
					value = UnderlyingSettlRateFallbackRateSourceValue;
					break;
				}
				case "UnderlyingSettlRateFallbackReferencePage":
				{
					value = UnderlyingSettlRateFallbackReferencePage;
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
			UnderlyingSettlRateFallbackRateSourceValue = null;
			UnderlyingSettlRateFallbackReferencePage = null;
		}
	}
}
