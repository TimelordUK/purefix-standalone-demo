using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PositionAmountData : IFixComponent
	{
		public sealed partial class NoPosAmt : IFixGroup
		{
			[TagDetails(Tag = 707, Type = TagType.String, Offset = 0, Required = false)]
			public string? PosAmtType {get; set;}
			
			[TagDetails(Tag = 708, Type = TagType.Float, Offset = 1, Required = false)]
			public double? PosAmt {get; set;}
			
			[TagDetails(Tag = 2096, Type = TagType.String, Offset = 2, Required = false)]
			public string? PosAmtStreamDesc {get; set;}
			
			[TagDetails(Tag = 1055, Type = TagType.String, Offset = 3, Required = false)]
			public string? PositionCurrency {get; set;}
			
			[TagDetails(Tag = 2937, Type = TagType.String, Offset = 4, Required = false)]
			public string? PositionCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 2097, Type = TagType.Float, Offset = 5, Required = false)]
			public double? PositionFXRate {get; set;}
			
			[TagDetails(Tag = 2098, Type = TagType.String, Offset = 6, Required = false)]
			public string? PositionFXRateCalc {get; set;}
			
			[TagDetails(Tag = 1585, Type = TagType.Int, Offset = 7, Required = false)]
			public int? PosAmtReason {get; set;}
			
			[TagDetails(Tag = 2099, Type = TagType.String, Offset = 8, Required = false)]
			public string? PosAmtMarketSegmentID {get; set;}
			
			[TagDetails(Tag = 2100, Type = TagType.String, Offset = 9, Required = false)]
			public string? PosAmtMarketID {get; set;}
			
			[TagDetails(Tag = 2876, Type = TagType.Float, Offset = 10, Required = false)]
			public double? PosAmtPrice {get; set;}
			
			[TagDetails(Tag = 2877, Type = TagType.Int, Offset = 11, Required = false)]
			public int? PosAmtPriceType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PosAmtType is not null) writer.WriteString(707, PosAmtType);
				if (PosAmt is not null) writer.WriteNumber(708, PosAmt.Value);
				if (PosAmtStreamDesc is not null) writer.WriteString(2096, PosAmtStreamDesc);
				if (PositionCurrency is not null) writer.WriteString(1055, PositionCurrency);
				if (PositionCurrencyCodeSource is not null) writer.WriteString(2937, PositionCurrencyCodeSource);
				if (PositionFXRate is not null) writer.WriteNumber(2097, PositionFXRate.Value);
				if (PositionFXRateCalc is not null) writer.WriteString(2098, PositionFXRateCalc);
				if (PosAmtReason is not null) writer.WriteWholeNumber(1585, PosAmtReason.Value);
				if (PosAmtMarketSegmentID is not null) writer.WriteString(2099, PosAmtMarketSegmentID);
				if (PosAmtMarketID is not null) writer.WriteString(2100, PosAmtMarketID);
				if (PosAmtPrice is not null) writer.WriteNumber(2876, PosAmtPrice.Value);
				if (PosAmtPriceType is not null) writer.WriteWholeNumber(2877, PosAmtPriceType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PosAmtType = view.GetString(707);
				PosAmt = view.GetDouble(708);
				PosAmtStreamDesc = view.GetString(2096);
				PositionCurrency = view.GetString(1055);
				PositionCurrencyCodeSource = view.GetString(2937);
				PositionFXRate = view.GetDouble(2097);
				PositionFXRateCalc = view.GetString(2098);
				PosAmtReason = view.GetInt32(1585);
				PosAmtMarketSegmentID = view.GetString(2099);
				PosAmtMarketID = view.GetString(2100);
				PosAmtPrice = view.GetDouble(2876);
				PosAmtPriceType = view.GetInt32(2877);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PosAmtType":
					{
						value = PosAmtType;
						break;
					}
					case "PosAmt":
					{
						value = PosAmt;
						break;
					}
					case "PosAmtStreamDesc":
					{
						value = PosAmtStreamDesc;
						break;
					}
					case "PositionCurrency":
					{
						value = PositionCurrency;
						break;
					}
					case "PositionCurrencyCodeSource":
					{
						value = PositionCurrencyCodeSource;
						break;
					}
					case "PositionFXRate":
					{
						value = PositionFXRate;
						break;
					}
					case "PositionFXRateCalc":
					{
						value = PositionFXRateCalc;
						break;
					}
					case "PosAmtReason":
					{
						value = PosAmtReason;
						break;
					}
					case "PosAmtMarketSegmentID":
					{
						value = PosAmtMarketSegmentID;
						break;
					}
					case "PosAmtMarketID":
					{
						value = PosAmtMarketID;
						break;
					}
					case "PosAmtPrice":
					{
						value = PosAmtPrice;
						break;
					}
					case "PosAmtPriceType":
					{
						value = PosAmtPriceType;
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
				PosAmtType = null;
				PosAmt = null;
				PosAmtStreamDesc = null;
				PositionCurrency = null;
				PositionCurrencyCodeSource = null;
				PositionFXRate = null;
				PositionFXRateCalc = null;
				PosAmtReason = null;
				PosAmtMarketSegmentID = null;
				PosAmtMarketID = null;
				PosAmtPrice = null;
				PosAmtPriceType = null;
			}
		}
		[Group(NoOfTag = 753, Offset = 0, Required = false)]
		public NoPosAmt[]? PosAmt {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PosAmt is not null && PosAmt.Length != 0)
			{
				writer.WriteWholeNumber(753, PosAmt.Length);
				for (int i = 0; i < PosAmt.Length; i++)
				{
					((IFixEncoder)PosAmt[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPosAmt") is IMessageView viewNoPosAmt)
			{
				var count = viewNoPosAmt.GroupCount();
				PosAmt = new NoPosAmt[count];
				for (int i = 0; i < count; i++)
				{
					PosAmt[i] = new();
					((IFixParser)PosAmt[i]).Parse(viewNoPosAmt.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPosAmt":
				{
					value = PosAmt;
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
			PosAmt = null;
		}
	}
}
