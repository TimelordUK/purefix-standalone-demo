using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFormula : IFixComponent
	{
		[TagDetails(Tag = 42482, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegPaymentStreamFormulaCurrency {get; set;}
		
		[TagDetails(Tag = 42483, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegPaymentStreamFormulaCurrencyDeterminationMethod {get; set;}
		
		[TagDetails(Tag = 42484, Type = TagType.Int, Offset = 2, Required = false)]
		public int? LegPaymentStreamFormulaReferenceAmount {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public LegPaymentStreamFormulaMathGrp? LegPaymentStreamFormulaMathGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegPaymentStreamFormulaImage? LegPaymentStreamFormulaImage {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamFormulaCurrency is not null) writer.WriteString(42482, LegPaymentStreamFormulaCurrency);
			if (LegPaymentStreamFormulaCurrencyDeterminationMethod is not null) writer.WriteString(42483, LegPaymentStreamFormulaCurrencyDeterminationMethod);
			if (LegPaymentStreamFormulaReferenceAmount is not null) writer.WriteWholeNumber(42484, LegPaymentStreamFormulaReferenceAmount.Value);
			if (LegPaymentStreamFormulaMathGrp is not null) ((IFixEncoder)LegPaymentStreamFormulaMathGrp).Encode(writer);
			if (LegPaymentStreamFormulaImage is not null) ((IFixEncoder)LegPaymentStreamFormulaImage).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegPaymentStreamFormulaCurrency = view.GetString(42482);
			LegPaymentStreamFormulaCurrencyDeterminationMethod = view.GetString(42483);
			LegPaymentStreamFormulaReferenceAmount = view.GetInt32(42484);
			if (view.GetView("LegPaymentStreamFormulaMathGrp") is IMessageView viewLegPaymentStreamFormulaMathGrp)
			{
				LegPaymentStreamFormulaMathGrp = new();
				((IFixParser)LegPaymentStreamFormulaMathGrp).Parse(viewLegPaymentStreamFormulaMathGrp);
			}
			if (view.GetView("LegPaymentStreamFormulaImage") is IMessageView viewLegPaymentStreamFormulaImage)
			{
				LegPaymentStreamFormulaImage = new();
				((IFixParser)LegPaymentStreamFormulaImage).Parse(viewLegPaymentStreamFormulaImage);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegPaymentStreamFormulaCurrency":
				{
					value = LegPaymentStreamFormulaCurrency;
					break;
				}
				case "LegPaymentStreamFormulaCurrencyDeterminationMethod":
				{
					value = LegPaymentStreamFormulaCurrencyDeterminationMethod;
					break;
				}
				case "LegPaymentStreamFormulaReferenceAmount":
				{
					value = LegPaymentStreamFormulaReferenceAmount;
					break;
				}
				case "LegPaymentStreamFormulaMathGrp":
				{
					value = LegPaymentStreamFormulaMathGrp;
					break;
				}
				case "LegPaymentStreamFormulaImage":
				{
					value = LegPaymentStreamFormulaImage;
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
			LegPaymentStreamFormulaCurrency = null;
			LegPaymentStreamFormulaCurrencyDeterminationMethod = null;
			LegPaymentStreamFormulaReferenceAmount = null;
			((IFixReset?)LegPaymentStreamFormulaMathGrp)?.Reset();
			((IFixReset?)LegPaymentStreamFormulaImage)?.Reset();
		}
	}
}
