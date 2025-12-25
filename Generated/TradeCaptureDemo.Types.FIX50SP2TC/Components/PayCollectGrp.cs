using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PayCollectGrp : IFixComponent
	{
		public sealed partial class NoPayCollects : IFixGroup
		{
			[TagDetails(Tag = 1708, Type = TagType.String, Offset = 0, Required = false)]
			public string? PayCollectType {get; set;}
			
			[TagDetails(Tag = 1709, Type = TagType.String, Offset = 1, Required = false)]
			public string? PayCollectCurrency {get; set;}
			
			[TagDetails(Tag = 2955, Type = TagType.String, Offset = 2, Required = false)]
			public string? PayCollectCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2094, Type = TagType.Float, Offset = 3, Required = false)]
			public double? PayCollectFXRate {get; set;}
			
			[TagDetails(Tag = 2095, Type = TagType.String, Offset = 4, Required = false)]
			public string? PayCollectFXRateCalc {get; set;}
			
			[TagDetails(Tag = 1710, Type = TagType.Float, Offset = 5, Required = false)]
			public double? PayAmount {get; set;}
			
			[TagDetails(Tag = 1711, Type = TagType.Float, Offset = 6, Required = false)]
			public double? CollectAmount {get; set;}
			
			[TagDetails(Tag = 1712, Type = TagType.String, Offset = 7, Required = false)]
			public string? PayCollectMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 1713, Type = TagType.String, Offset = 8, Required = false)]
			public string? PayCollectMarketID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PayCollectType is not null) writer.WriteString(1708, PayCollectType);
				if (PayCollectCurrency is not null) writer.WriteString(1709, PayCollectCurrency);
				if (PayCollectCurrencyCodeSource is not null) writer.WriteString(2955, PayCollectCurrencyCodeSource);
				if (PayCollectFXRate is not null) writer.WriteNumber(2094, PayCollectFXRate.Value);
				if (PayCollectFXRateCalc is not null) writer.WriteString(2095, PayCollectFXRateCalc);
				if (PayAmount is not null) writer.WriteNumber(1710, PayAmount.Value);
				if (CollectAmount is not null) writer.WriteNumber(1711, CollectAmount.Value);
				if (PayCollectMarketSegmentID is not null) writer.WriteString(1712, PayCollectMarketSegmentID);
				if (PayCollectMarketID is not null) writer.WriteString(1713, PayCollectMarketID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PayCollectType = view.GetString(1708);
				PayCollectCurrency = view.GetString(1709);
				PayCollectCurrencyCodeSource = view.GetString(2955);
				PayCollectFXRate = view.GetDouble(2094);
				PayCollectFXRateCalc = view.GetString(2095);
				PayAmount = view.GetDouble(1710);
				CollectAmount = view.GetDouble(1711);
				PayCollectMarketSegmentID = view.GetString(1712);
				PayCollectMarketID = view.GetString(1713);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PayCollectType":
					{
						value = PayCollectType;
						break;
					}
					case "PayCollectCurrency":
					{
						value = PayCollectCurrency;
						break;
					}
					case "PayCollectCurrencyCodeSource":
					{
						value = PayCollectCurrencyCodeSource;
						break;
					}
					case "PayCollectFXRate":
					{
						value = PayCollectFXRate;
						break;
					}
					case "PayCollectFXRateCalc":
					{
						value = PayCollectFXRateCalc;
						break;
					}
					case "PayAmount":
					{
						value = PayAmount;
						break;
					}
					case "CollectAmount":
					{
						value = CollectAmount;
						break;
					}
					case "PayCollectMarketSegmentID":
					{
						value = PayCollectMarketSegmentID;
						break;
					}
					case "PayCollectMarketID":
					{
						value = PayCollectMarketID;
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
				PayCollectType = null;
				PayCollectCurrency = null;
				PayCollectCurrencyCodeSource = null;
				PayCollectFXRate = null;
				PayCollectFXRateCalc = null;
				PayAmount = null;
				CollectAmount = null;
				PayCollectMarketSegmentID = null;
				PayCollectMarketID = null;
			}
		}
		[Group(NoOfTag = 1707, Offset = 0, Required = false)]
		public NoPayCollects[]? PayCollects {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PayCollects is not null && PayCollects.Length != 0)
			{
				writer.WriteWholeNumber(1707, PayCollects.Length);
				for (int i = 0; i < PayCollects.Length; i++)
				{
					((IFixEncoder)PayCollects[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPayCollects") is IMessageView viewNoPayCollects)
			{
				var count = viewNoPayCollects.GroupCount();
				PayCollects = new NoPayCollects[count];
				for (int i = 0; i < count; i++)
				{
					PayCollects[i] = new();
					((IFixParser)PayCollects[i]).Parse(viewNoPayCollects.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPayCollects":
				{
					value = PayCollects;
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
			PayCollects = null;
		}
	}
}
