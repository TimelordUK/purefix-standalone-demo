using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFormula : IFixComponent
	{
		[TagDetails(Tag = 42978, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingPaymentStreamFormulaCurrency {get; set;}
		
		[TagDetails(Tag = 42979, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 42980, Type = TagType.Int, Offset = 2, Required = false)]
		public int? UnderlyingPaymentStreamFormulaReferenceAmount {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public UnderlyingPaymentStreamFormulaMathGrp? UnderlyingPaymentStreamFormulaMathGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingPaymentStreamFormulaImage? UnderlyingPaymentStreamFormulaImage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFormulaCurrency is not null) writer.WriteString(42978, UnderlyingPaymentStreamFormulaCurrency);
			if (UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod is not null) writer.WriteString(42979, UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod);
			if (UnderlyingPaymentStreamFormulaReferenceAmount is not null) writer.WriteWholeNumber(42980, UnderlyingPaymentStreamFormulaReferenceAmount.Value);
			if (UnderlyingPaymentStreamFormulaMathGrp is not null) ((IFixEncoder)UnderlyingPaymentStreamFormulaMathGrp).Encode(writer);
			if (UnderlyingPaymentStreamFormulaImage is not null) ((IFixEncoder)UnderlyingPaymentStreamFormulaImage).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingPaymentStreamFormulaCurrency = view.GetString(42978);
			UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod = view.GetString(42979);
			UnderlyingPaymentStreamFormulaReferenceAmount = view.GetInt32(42980);
			if (view.GetView("UnderlyingPaymentStreamFormulaMathGrp") is IMessageView viewUnderlyingPaymentStreamFormulaMathGrp)
			{
				UnderlyingPaymentStreamFormulaMathGrp = new();
				((IFixParser)UnderlyingPaymentStreamFormulaMathGrp).Parse(viewUnderlyingPaymentStreamFormulaMathGrp);
			}
			if (view.GetView("UnderlyingPaymentStreamFormulaImage") is IMessageView viewUnderlyingPaymentStreamFormulaImage)
			{
				UnderlyingPaymentStreamFormulaImage = new();
				((IFixParser)UnderlyingPaymentStreamFormulaImage).Parse(viewUnderlyingPaymentStreamFormulaImage);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingPaymentStreamFormulaCurrency":
				{
					value = UnderlyingPaymentStreamFormulaCurrency;
					break;
				}
				case "UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod":
				{
					value = UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod;
					break;
				}
				case "UnderlyingPaymentStreamFormulaReferenceAmount":
				{
					value = UnderlyingPaymentStreamFormulaReferenceAmount;
					break;
				}
				case "UnderlyingPaymentStreamFormulaMathGrp":
				{
					value = UnderlyingPaymentStreamFormulaMathGrp;
					break;
				}
				case "UnderlyingPaymentStreamFormulaImage":
				{
					value = UnderlyingPaymentStreamFormulaImage;
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
			UnderlyingPaymentStreamFormulaCurrency = null;
			UnderlyingPaymentStreamFormulaCurrencyDeterminationMethod = null;
			UnderlyingPaymentStreamFormulaReferenceAmount = null;
			((IFixReset?)UnderlyingPaymentStreamFormulaMathGrp)?.Reset();
			((IFixReset?)UnderlyingPaymentStreamFormulaImage)?.Reset();
		}
	}
}
