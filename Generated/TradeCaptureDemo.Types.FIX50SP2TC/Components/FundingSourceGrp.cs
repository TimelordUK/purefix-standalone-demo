using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FundingSourceGrp : IFixComponent
	{
		public sealed partial class NoFundingSources : IFixGroup
		{
			[TagDetails(Tag = 2846, Type = TagType.Int, Offset = 0, Required = false)]
			public int? FundingSource {get; set;}
			
			[TagDetails(Tag = 2848, Type = TagType.Float, Offset = 1, Required = false)]
			public double? FundingSourceMarketValue {get; set;}
			
			[TagDetails(Tag = 2847, Type = TagType.String, Offset = 2, Required = false)]
			public string? FundingSourceCurrency {get; set;}
			
			[TagDetails(Tag = 2954, Type = TagType.String, Offset = 3, Required = false)]
			public string? FundingSourceCurrencyCodeSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (FundingSource is not null) writer.WriteWholeNumber(2846, FundingSource.Value);
				if (FundingSourceMarketValue is not null) writer.WriteNumber(2848, FundingSourceMarketValue.Value);
				if (FundingSourceCurrency is not null) writer.WriteString(2847, FundingSourceCurrency);
				if (FundingSourceCurrencyCodeSource is not null) writer.WriteString(2954, FundingSourceCurrencyCodeSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				FundingSource = view.GetInt32(2846);
				FundingSourceMarketValue = view.GetDouble(2848);
				FundingSourceCurrency = view.GetString(2847);
				FundingSourceCurrencyCodeSource = view.GetString(2954);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "FundingSource":
					{
						value = FundingSource;
						break;
					}
					case "FundingSourceMarketValue":
					{
						value = FundingSourceMarketValue;
						break;
					}
					case "FundingSourceCurrency":
					{
						value = FundingSourceCurrency;
						break;
					}
					case "FundingSourceCurrencyCodeSource":
					{
						value = FundingSourceCurrencyCodeSource;
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
				FundingSource = null;
				FundingSourceMarketValue = null;
				FundingSourceCurrency = null;
				FundingSourceCurrencyCodeSource = null;
			}
		}
		[Group(NoOfTag = 2849, Offset = 0, Required = false)]
		public NoFundingSources[]? FundingSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (FundingSources is not null && FundingSources.Length != 0)
			{
				writer.WriteWholeNumber(2849, FundingSources.Length);
				for (int i = 0; i < FundingSources.Length; i++)
				{
					((IFixEncoder)FundingSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoFundingSources") is IMessageView viewNoFundingSources)
			{
				var count = viewNoFundingSources.GroupCount();
				FundingSources = new NoFundingSources[count];
				for (int i = 0; i < count; i++)
				{
					FundingSources[i] = new();
					((IFixParser)FundingSources[i]).Parse(viewNoFundingSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoFundingSources":
				{
					value = FundingSources;
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
			FundingSources = null;
		}
	}
}
