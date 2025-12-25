using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegBenchmarkCurveData : IFixComponent
	{
		[TagDetails(Tag = 676, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegBenchmarkCurveCurrency {get; set;}
		
		[TagDetails(Tag = 2951, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegBenchmarkCurveCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 677, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegBenchmarkCurveName {get; set;}
		
		[TagDetails(Tag = 678, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegBenchmarkCurvePoint {get; set;}
		
		[TagDetails(Tag = 679, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegBenchmarkPrice {get; set;}
		
		[TagDetails(Tag = 680, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegBenchmarkPriceType {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegBenchmarkCurveCurrency is not null) writer.WriteString(676, LegBenchmarkCurveCurrency);
			if (LegBenchmarkCurveCurrencyCodeSource is not null) writer.WriteString(2951, LegBenchmarkCurveCurrencyCodeSource);
			if (LegBenchmarkCurveName is not null) writer.WriteString(677, LegBenchmarkCurveName);
			if (LegBenchmarkCurvePoint is not null) writer.WriteString(678, LegBenchmarkCurvePoint);
			if (LegBenchmarkPrice is not null) writer.WriteNumber(679, LegBenchmarkPrice.Value);
			if (LegBenchmarkPriceType is not null) writer.WriteWholeNumber(680, LegBenchmarkPriceType.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegBenchmarkCurveCurrency = view.GetString(676);
			LegBenchmarkCurveCurrencyCodeSource = view.GetString(2951);
			LegBenchmarkCurveName = view.GetString(677);
			LegBenchmarkCurvePoint = view.GetString(678);
			LegBenchmarkPrice = view.GetDouble(679);
			LegBenchmarkPriceType = view.GetInt32(680);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegBenchmarkCurveCurrency":
				{
					value = LegBenchmarkCurveCurrency;
					break;
				}
				case "LegBenchmarkCurveCurrencyCodeSource":
				{
					value = LegBenchmarkCurveCurrencyCodeSource;
					break;
				}
				case "LegBenchmarkCurveName":
				{
					value = LegBenchmarkCurveName;
					break;
				}
				case "LegBenchmarkCurvePoint":
				{
					value = LegBenchmarkCurvePoint;
					break;
				}
				case "LegBenchmarkPrice":
				{
					value = LegBenchmarkPrice;
					break;
				}
				case "LegBenchmarkPriceType":
				{
					value = LegBenchmarkPriceType;
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
			LegBenchmarkCurveCurrency = null;
			LegBenchmarkCurveCurrencyCodeSource = null;
			LegBenchmarkCurveName = null;
			LegBenchmarkCurvePoint = null;
			LegBenchmarkPrice = null;
			LegBenchmarkPriceType = null;
		}
	}
}
