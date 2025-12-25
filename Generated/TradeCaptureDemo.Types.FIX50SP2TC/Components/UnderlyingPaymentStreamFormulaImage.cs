using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFormulaImage : IFixComponent
	{
		[TagDetails(Tag = 42947, Type = TagType.Length, Offset = 0, Required = false)]
		public int? UnderlyingPaymentStreamFormulaImageLength {get; set;}
		
		[TagDetails(Tag = 42948, Type = TagType.RawData, Offset = 1, Required = false)]
		public byte[]? UnderlyingPaymentStreamFormulaImageValue {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFormulaImageLength is not null) writer.WriteWholeNumber(42947, UnderlyingPaymentStreamFormulaImageLength.Value);
			if (UnderlyingPaymentStreamFormulaImageValue is not null) writer.WriteBuffer(42948, UnderlyingPaymentStreamFormulaImageValue);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamFormulaImageLength = view.GetInt32(42947);
			UnderlyingPaymentStreamFormulaImageValue = view.GetByteArray(42948);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamFormulaImageLength":
				{
					value = UnderlyingPaymentStreamFormulaImageLength;
					break;
				}
				case "UnderlyingPaymentStreamFormulaImage":
				{
					value = UnderlyingPaymentStreamFormulaImageValue;
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
			UnderlyingPaymentStreamFormulaImageLength = null;
			UnderlyingPaymentStreamFormulaImageValue = null;
		}
	}
}
