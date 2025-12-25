using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFormula : IFixComponent
	{
		[TagDetails(Tag = 42686, Type = TagType.String, Offset = 0, Required = false)]
		public string? PaymentStreamFormulaCurrency {get; set;}
		
		[TagDetails(Tag = 42687, Type = TagType.String, Offset = 1, Required = false)]
		public string? PaymentStreamFormulaCurrencyDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 42688, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PaymentStreamFormulaReferenceAmount {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public PaymentStreamFormulaMathGrp? PaymentStreamFormulaMathGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public PaymentStreamFormulaImage? PaymentStreamFormulaImage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFormulaCurrency is not null) writer.WriteString(42686, PaymentStreamFormulaCurrency);
			if (PaymentStreamFormulaCurrencyDeterminationMethod is not null) writer.WriteString(42687, PaymentStreamFormulaCurrencyDeterminationMethod);
			if (PaymentStreamFormulaReferenceAmount is not null) writer.WriteWholeNumber(42688, PaymentStreamFormulaReferenceAmount.Value);
			if (PaymentStreamFormulaMathGrp is not null) ((IFixEncoder)PaymentStreamFormulaMathGrp).Encode(writer);
			if (PaymentStreamFormulaImage is not null) ((IFixEncoder)PaymentStreamFormulaImage).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PaymentStreamFormulaCurrency = view.GetString(42686);
			PaymentStreamFormulaCurrencyDeterminationMethod = view.GetString(42687);
			PaymentStreamFormulaReferenceAmount = view.GetInt32(42688);
			if (view.GetView("PaymentStreamFormulaMathGrp") is IMessageView viewPaymentStreamFormulaMathGrp)
			{
				PaymentStreamFormulaMathGrp = new();
				((IFixParser)PaymentStreamFormulaMathGrp).Parse(viewPaymentStreamFormulaMathGrp);
			}
			if (view.GetView("PaymentStreamFormulaImage") is IMessageView viewPaymentStreamFormulaImage)
			{
				PaymentStreamFormulaImage = new();
				((IFixParser)PaymentStreamFormulaImage).Parse(viewPaymentStreamFormulaImage);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PaymentStreamFormulaCurrency":
				{
					value = PaymentStreamFormulaCurrency;
					break;
				}
				case "PaymentStreamFormulaCurrencyDeterminationMethod":
				{
					value = PaymentStreamFormulaCurrencyDeterminationMethod;
					break;
				}
				case "PaymentStreamFormulaReferenceAmount":
				{
					value = PaymentStreamFormulaReferenceAmount;
					break;
				}
				case "PaymentStreamFormulaMathGrp":
				{
					value = PaymentStreamFormulaMathGrp;
					break;
				}
				case "PaymentStreamFormulaImage":
				{
					value = PaymentStreamFormulaImage;
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
			PaymentStreamFormulaCurrency = null;
			PaymentStreamFormulaCurrencyDeterminationMethod = null;
			PaymentStreamFormulaReferenceAmount = null;
			((IFixReset?)PaymentStreamFormulaMathGrp)?.Reset();
			((IFixReset?)PaymentStreamFormulaImage)?.Reset();
		}
	}
}
