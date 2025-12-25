using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamFormulaMathGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamFormulas : IFixGroup
		{
			[TagDetails(Tag = 43109, Type = TagType.Length, Offset = 0, Required = false)]
			public int? PaymentStreamFormulaLength {get; set;}
			
			[TagDetails(Tag = 42684, Type = TagType.String, Offset = 1, Required = false)]
			public string? PaymentStreamFormula {get; set;}
			
			[TagDetails(Tag = 42685, Type = TagType.String, Offset = 2, Required = false)]
			public string? PaymentStreamFormulaDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamFormulaLength is not null) writer.WriteWholeNumber(43109, PaymentStreamFormulaLength.Value);
				if (PaymentStreamFormula is not null) writer.WriteString(42684, PaymentStreamFormula);
				if (PaymentStreamFormulaDesc is not null) writer.WriteString(42685, PaymentStreamFormulaDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamFormulaLength = view.GetInt32(43109);
				PaymentStreamFormula = view.GetString(42684);
				PaymentStreamFormulaDesc = view.GetString(42685);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamFormulaLength":
					{
						value = PaymentStreamFormulaLength;
						break;
					}
					case "PaymentStreamFormula":
					{
						value = PaymentStreamFormula;
						break;
					}
					case "PaymentStreamFormulaDesc":
					{
						value = PaymentStreamFormulaDesc;
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
				PaymentStreamFormulaLength = null;
				PaymentStreamFormula = null;
				PaymentStreamFormulaDesc = null;
			}
		}
		[Group(NoOfTag = 42683, Offset = 0, Required = false)]
		public NoPaymentStreamFormulas[]? PaymentStreamFormulas {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamFormulas is not null && PaymentStreamFormulas.Length != 0)
			{
				writer.WriteWholeNumber(42683, PaymentStreamFormulas.Length);
				for (int i = 0; i < PaymentStreamFormulas.Length; i++)
				{
					((IFixEncoder)PaymentStreamFormulas[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamFormulas") is IMessageView viewNoPaymentStreamFormulas)
			{
				var count = viewNoPaymentStreamFormulas.GroupCount();
				PaymentStreamFormulas = new NoPaymentStreamFormulas[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamFormulas[i] = new();
					((IFixParser)PaymentStreamFormulas[i]).Parse(viewNoPaymentStreamFormulas.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamFormulas":
				{
					value = PaymentStreamFormulas;
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
			PaymentStreamFormulas = null;
		}
	}
}
