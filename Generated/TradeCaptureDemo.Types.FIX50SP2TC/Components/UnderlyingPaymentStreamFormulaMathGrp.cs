using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFormulaMathGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamFormulas : IFixGroup
		{
			[TagDetails(Tag = 43111, Type = TagType.Length, Offset = 0, Required = false)]
			public int? UnderlyingPaymentStreamFormulaLength {get; set;}
			
			[TagDetails(Tag = 42982, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingPaymentStreamFormula {get; set;}
			
			[TagDetails(Tag = 42983, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingPaymentStreamFormulaDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamFormulaLength is not null) writer.WriteWholeNumber(43111, UnderlyingPaymentStreamFormulaLength.Value);
				if (UnderlyingPaymentStreamFormula is not null) writer.WriteString(42982, UnderlyingPaymentStreamFormula);
				if (UnderlyingPaymentStreamFormulaDesc is not null) writer.WriteString(42983, UnderlyingPaymentStreamFormulaDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamFormulaLength = view.GetInt32(43111);
				UnderlyingPaymentStreamFormula = view.GetString(42982);
				UnderlyingPaymentStreamFormulaDesc = view.GetString(42983);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamFormulaLength":
					{
						value = UnderlyingPaymentStreamFormulaLength;
						break;
					}
					case "UnderlyingPaymentStreamFormula":
					{
						value = UnderlyingPaymentStreamFormula;
						break;
					}
					case "UnderlyingPaymentStreamFormulaDesc":
					{
						value = UnderlyingPaymentStreamFormulaDesc;
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
				UnderlyingPaymentStreamFormulaLength = null;
				UnderlyingPaymentStreamFormula = null;
				UnderlyingPaymentStreamFormulaDesc = null;
			}
		}
		[Group(NoOfTag = 42981, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamFormulas[]? UnderlyingPaymentStreamFormulas {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFormulas is not null && UnderlyingPaymentStreamFormulas.Length != 0)
			{
				writer.WriteWholeNumber(42981, UnderlyingPaymentStreamFormulas.Length);
				for (int i = 0; i < UnderlyingPaymentStreamFormulas.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamFormulas[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamFormulas") is IMessageView viewNoUnderlyingPaymentStreamFormulas)
			{
				var count = viewNoUnderlyingPaymentStreamFormulas.GroupCount();
				UnderlyingPaymentStreamFormulas = new NoUnderlyingPaymentStreamFormulas[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamFormulas[i] = new();
					((IFixParser)UnderlyingPaymentStreamFormulas[i]).Parse(viewNoUnderlyingPaymentStreamFormulas.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamFormulas":
				{
					value = UnderlyingPaymentStreamFormulas;
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
			UnderlyingPaymentStreamFormulas = null;
		}
	}
}
