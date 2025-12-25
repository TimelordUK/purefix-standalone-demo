using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFormulaImage : IFixComponent
	{
		[TagDetails(Tag = 42451, Type = TagType.Length, Offset = 0, Required = false)]
		public int? LegPaymentStreamFormulaImageLength {get; set;}
		
		[TagDetails(Tag = 42452, Type = TagType.RawData, Offset = 1, Required = false)]
		public byte[]? LegPaymentStreamFormulaImageValue {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamFormulaImageLength is not null) writer.WriteWholeNumber(42451, LegPaymentStreamFormulaImageLength.Value);
			if (LegPaymentStreamFormulaImageValue is not null) writer.WriteBuffer(42452, LegPaymentStreamFormulaImageValue);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamFormulaImageLength = view.GetInt32(42451);
			LegPaymentStreamFormulaImageValue = view.GetByteArray(42452);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamFormulaImageLength":
				{
					value = LegPaymentStreamFormulaImageLength;
					break;
				}
				case "LegPaymentStreamFormulaImage":
				{
					value = LegPaymentStreamFormulaImageValue;
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
			LegPaymentStreamFormulaImageLength = null;
			LegPaymentStreamFormulaImageValue = null;
		}
	}
}
