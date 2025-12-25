using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFormulaImage : IFixComponent
	{
		[TagDetails(Tag = 42652, Type = TagType.Length, Offset = 0, Required = false)]
		public int? PaymentStreamFormulaImageLength {get; set;}
		
		[TagDetails(Tag = 42653, Type = TagType.RawData, Offset = 1, Required = false)]
		public byte[]? PaymentStreamFormulaImageValue {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFormulaImageLength is not null) writer.WriteWholeNumber(42652, PaymentStreamFormulaImageLength.Value);
			if (PaymentStreamFormulaImageValue is not null) writer.WriteBuffer(42653, PaymentStreamFormulaImageValue);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamFormulaImageLength = view.GetInt32(42652);
			PaymentStreamFormulaImageValue = view.GetByteArray(42653);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamFormulaImageLength":
				{
					value = PaymentStreamFormulaImageLength;
					break;
				}
				case "PaymentStreamFormulaImage":
				{
					value = PaymentStreamFormulaImageValue;
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
			PaymentStreamFormulaImageLength = null;
			PaymentStreamFormulaImageValue = null;
		}
	}
}
