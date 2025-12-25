using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlRateFallbackRateSource : IFixComponent
	{
		[TagDetails(Tag = 40373, Type = TagType.Int, Offset = 0, Required = false)]
		public int? SettlRateFallbackRateSourceValue {get; set;}
		
		[TagDetails(Tag = 40655, Type = TagType.String, Offset = 1, Required = false)]
		public string? SettlRateFallbackReferencePage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlRateFallbackRateSourceValue is not null) writer.WriteWholeNumber(40373, SettlRateFallbackRateSourceValue.Value);
			if (SettlRateFallbackReferencePage is not null) writer.WriteString(40655, SettlRateFallbackReferencePage);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SettlRateFallbackRateSourceValue = view.GetInt32(40373);
			SettlRateFallbackReferencePage = view.GetString(40655);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SettlRateFallbackRateSource":
				{
					value = SettlRateFallbackRateSourceValue;
					break;
				}
				case "SettlRateFallbackReferencePage":
				{
					value = SettlRateFallbackReferencePage;
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
			SettlRateFallbackRateSourceValue = null;
			SettlRateFallbackReferencePage = null;
		}
	}
}
