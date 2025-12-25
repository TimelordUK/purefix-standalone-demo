using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamFormulaMathGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamFormulas : IFixGroup
		{
			[TagDetails(Tag = 43110, Type = TagType.Length, Offset = 0, Required = false)]
			public int? LegPaymentStreamFormulaLength {get; set;}
			
			[TagDetails(Tag = 42486, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegPaymentStreamFormula {get; set;}
			
			[TagDetails(Tag = 42487, Type = TagType.String, Offset = 2, Required = false)]
			public string? LegPaymentStreamFormulaDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamFormulaLength is not null) writer.WriteWholeNumber(43110, LegPaymentStreamFormulaLength.Value);
				if (LegPaymentStreamFormula is not null) writer.WriteString(42486, LegPaymentStreamFormula);
				if (LegPaymentStreamFormulaDesc is not null) writer.WriteString(42487, LegPaymentStreamFormulaDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamFormulaLength = view.GetInt32(43110);
				LegPaymentStreamFormula = view.GetString(42486);
				LegPaymentStreamFormulaDesc = view.GetString(42487);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamFormulaLength":
					{
						value = LegPaymentStreamFormulaLength;
						break;
					}
					case "LegPaymentStreamFormula":
					{
						value = LegPaymentStreamFormula;
						break;
					}
					case "LegPaymentStreamFormulaDesc":
					{
						value = LegPaymentStreamFormulaDesc;
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
				LegPaymentStreamFormulaLength = null;
				LegPaymentStreamFormula = null;
				LegPaymentStreamFormulaDesc = null;
			}
		}
		[Group(NoOfTag = 42485, Offset = 0, Required = false)]
		public NoLegPaymentStreamFormulas[]? LegPaymentStreamFormulas {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamFormulas is not null && LegPaymentStreamFormulas.Length != 0)
			{
				writer.WriteWholeNumber(42485, LegPaymentStreamFormulas.Length);
				for (int i = 0; i < LegPaymentStreamFormulas.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamFormulas[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamFormulas") is IMessageView viewNoLegPaymentStreamFormulas)
			{
				var count = viewNoLegPaymentStreamFormulas.GroupCount();
				LegPaymentStreamFormulas = new NoLegPaymentStreamFormulas[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamFormulas[i] = new();
					((IFixParser)LegPaymentStreamFormulas[i]).Parse(viewNoLegPaymentStreamFormulas.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamFormulas":
				{
					value = LegPaymentStreamFormulas;
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
			LegPaymentStreamFormulas = null;
		}
	}
}
