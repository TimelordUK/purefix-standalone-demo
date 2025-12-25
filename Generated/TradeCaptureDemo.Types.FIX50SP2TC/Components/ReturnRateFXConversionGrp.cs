using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRateFXConversionGrp : IFixComponent
	{
		public sealed partial class NoReturnRateFXConversions : IFixGroup
		{
			[TagDetails(Tag = 42732, Type = TagType.String, Offset = 0, Required = false)]
			public string? ReturnRateFXCurrencySymbol {get; set;}
			
			[TagDetails(Tag = 42733, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ReturnRateFXRate {get; set;}
			
			[TagDetails(Tag = 42734, Type = TagType.String, Offset = 2, Required = false)]
			public string? ReturnRateFXRateCalc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRateFXCurrencySymbol is not null) writer.WriteString(42732, ReturnRateFXCurrencySymbol);
				if (ReturnRateFXRate is not null) writer.WriteNumber(42733, ReturnRateFXRate.Value);
				if (ReturnRateFXRateCalc is not null) writer.WriteString(42734, ReturnRateFXRateCalc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRateFXCurrencySymbol = view.GetString(42732);
				ReturnRateFXRate = view.GetDouble(42733);
				ReturnRateFXRateCalc = view.GetString(42734);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRateFXCurrencySymbol":
					{
						value = ReturnRateFXCurrencySymbol;
						break;
					}
					case "ReturnRateFXRate":
					{
						value = ReturnRateFXRate;
						break;
					}
					case "ReturnRateFXRateCalc":
					{
						value = ReturnRateFXRateCalc;
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
				ReturnRateFXCurrencySymbol = null;
				ReturnRateFXRate = null;
				ReturnRateFXRateCalc = null;
			}
		}
		[Group(NoOfTag = 42731, Offset = 0, Required = false)]
		public NoReturnRateFXConversions[]? ReturnRateFXConversions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRateFXConversions is not null && ReturnRateFXConversions.Length != 0)
			{
				writer.WriteWholeNumber(42731, ReturnRateFXConversions.Length);
				for (int i = 0; i < ReturnRateFXConversions.Length; i++)
				{
					((IFixEncoder)ReturnRateFXConversions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRateFXConversions") is IMessageView viewNoReturnRateFXConversions)
			{
				var count = viewNoReturnRateFXConversions.GroupCount();
				ReturnRateFXConversions = new NoReturnRateFXConversions[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRateFXConversions[i] = new();
					((IFixParser)ReturnRateFXConversions[i]).Parse(viewNoReturnRateFXConversions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRateFXConversions":
				{
					value = ReturnRateFXConversions;
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
			ReturnRateFXConversions = null;
		}
	}
}
