using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CollateralReinvestmentGrp : IFixComponent
	{
		public sealed partial class NoCollateralReinvestments : IFixGroup
		{
			[TagDetails(Tag = 2844, Type = TagType.Int, Offset = 0, Required = false)]
			public int? CollateralReinvestmentType {get; set;}
			
			[TagDetails(Tag = 2842, Type = TagType.Float, Offset = 1, Required = false)]
			public double? CollateralReinvestmentAmount {get; set;}
			
			[TagDetails(Tag = 2843, Type = TagType.String, Offset = 2, Required = false)]
			public string? CollateralReinvestmentCurrency {get; set;}
			
			[TagDetails(Tag = 2931, Type = TagType.String, Offset = 3, Required = false)]
			public string? CollateralReinvestmentCurrencyCodeSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CollateralReinvestmentType is not null) writer.WriteWholeNumber(2844, CollateralReinvestmentType.Value);
				if (CollateralReinvestmentAmount is not null) writer.WriteNumber(2842, CollateralReinvestmentAmount.Value);
				if (CollateralReinvestmentCurrency is not null) writer.WriteString(2843, CollateralReinvestmentCurrency);
				if (CollateralReinvestmentCurrencyCodeSource is not null) writer.WriteString(2931, CollateralReinvestmentCurrencyCodeSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CollateralReinvestmentType = view.GetInt32(2844);
				CollateralReinvestmentAmount = view.GetDouble(2842);
				CollateralReinvestmentCurrency = view.GetString(2843);
				CollateralReinvestmentCurrencyCodeSource = view.GetString(2931);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CollateralReinvestmentType":
					{
						value = CollateralReinvestmentType;
						break;
					}
					case "CollateralReinvestmentAmount":
					{
						value = CollateralReinvestmentAmount;
						break;
					}
					case "CollateralReinvestmentCurrency":
					{
						value = CollateralReinvestmentCurrency;
						break;
					}
					case "CollateralReinvestmentCurrencyCodeSource":
					{
						value = CollateralReinvestmentCurrencyCodeSource;
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
				CollateralReinvestmentType = null;
				CollateralReinvestmentAmount = null;
				CollateralReinvestmentCurrency = null;
				CollateralReinvestmentCurrencyCodeSource = null;
			}
		}
		[Group(NoOfTag = 2845, Offset = 0, Required = false)]
		public NoCollateralReinvestments[]? CollateralReinvestments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CollateralReinvestments is not null && CollateralReinvestments.Length != 0)
			{
				writer.WriteWholeNumber(2845, CollateralReinvestments.Length);
				for (int i = 0; i < CollateralReinvestments.Length; i++)
				{
					((IFixEncoder)CollateralReinvestments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCollateralReinvestments") is IMessageView viewNoCollateralReinvestments)
			{
				var count = viewNoCollateralReinvestments.GroupCount();
				CollateralReinvestments = new NoCollateralReinvestments[count];
				for (int i = 0; i < count; i++)
				{
					CollateralReinvestments[i] = new();
					((IFixParser)CollateralReinvestments[i]).Parse(viewNoCollateralReinvestments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCollateralReinvestments":
				{
					value = CollateralReinvestments;
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
			CollateralReinvestments = null;
		}
	}
}
