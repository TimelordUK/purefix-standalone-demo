using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendPayout : IFixComponent
	{
		[TagDetails(Tag = 42860, Type = TagType.Float, Offset = 0, Required = false)]
		public double? UnderlyingDividendPayoutRatio {get; set;}
		
		[TagDetails(Tag = 42861, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingDividendPayoutConditions {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public UnderlyingDividendPaymentGrp? UnderlyingDividendPaymentGrp {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendPayoutRatio is not null) writer.WriteNumber(42860, UnderlyingDividendPayoutRatio.Value);
			if (UnderlyingDividendPayoutConditions is not null) writer.WriteString(42861, UnderlyingDividendPayoutConditions);
			if (UnderlyingDividendPaymentGrp is not null) ((IFixEncoder)UnderlyingDividendPaymentGrp).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDividendPayoutRatio = view.GetDouble(42860);
			UnderlyingDividendPayoutConditions = view.GetString(42861);
			if (view.GetView("UnderlyingDividendPaymentGrp") is IMessageView viewUnderlyingDividendPaymentGrp)
			{
				UnderlyingDividendPaymentGrp = new();
				((IFixParser)UnderlyingDividendPaymentGrp).Parse(viewUnderlyingDividendPaymentGrp);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDividendPayoutRatio":
				{
					value = UnderlyingDividendPayoutRatio;
					break;
				}
				case "UnderlyingDividendPayoutConditions":
				{
					value = UnderlyingDividendPayoutConditions;
					break;
				}
				case "UnderlyingDividendPaymentGrp":
				{
					value = UnderlyingDividendPaymentGrp;
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
			UnderlyingDividendPayoutRatio = null;
			UnderlyingDividendPayoutConditions = null;
			((IFixReset?)UnderlyingDividendPaymentGrp)?.Reset();
		}
	}
}
