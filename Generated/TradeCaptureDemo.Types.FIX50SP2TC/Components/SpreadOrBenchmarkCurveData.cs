using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SpreadOrBenchmarkCurveData : IFixComponent
	{
		[TagDetails(Tag = 218, Type = TagType.Float, Offset = 0, Required = false)]
		public double? Spread {get; set;}
		
		[TagDetails(Tag = 220, Type = TagType.String, Offset = 1, Required = false)]
		public string? BenchmarkCurveCurrency {get; set;}
		
		[TagDetails(Tag = 2950, Type = TagType.String, Offset = 2, Required = false)]
		public string? BenchmarkCurveCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 221, Type = TagType.String, Offset = 3, Required = false)]
		public string? BenchmarkCurveName {get; set;}
		
		[TagDetails(Tag = 222, Type = TagType.String, Offset = 4, Required = false)]
		public string? BenchmarkCurvePoint {get; set;}
		
		[TagDetails(Tag = 662, Type = TagType.Float, Offset = 5, Required = false)]
		public double? BenchmarkPrice {get; set;}
		
		[TagDetails(Tag = 663, Type = TagType.Int, Offset = 6, Required = false)]
		public int? BenchmarkPriceType {get; set;}
		
		[TagDetails(Tag = 699, Type = TagType.String, Offset = 7, Required = false)]
		public string? BenchmarkSecurityID {get; set;}
		
		[TagDetails(Tag = 761, Type = TagType.String, Offset = 8, Required = false)]
		public string? BenchmarkSecurityIDSource {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Spread is not null) writer.WriteNumber(218, Spread.Value);
			if (BenchmarkCurveCurrency is not null) writer.WriteString(220, BenchmarkCurveCurrency);
			if (BenchmarkCurveCurrencyCodeSource is not null) writer.WriteString(2950, BenchmarkCurveCurrencyCodeSource);
			if (BenchmarkCurveName is not null) writer.WriteString(221, BenchmarkCurveName);
			if (BenchmarkCurvePoint is not null) writer.WriteString(222, BenchmarkCurvePoint);
			if (BenchmarkPrice is not null) writer.WriteNumber(662, BenchmarkPrice.Value);
			if (BenchmarkPriceType is not null) writer.WriteWholeNumber(663, BenchmarkPriceType.Value);
			if (BenchmarkSecurityID is not null) writer.WriteString(699, BenchmarkSecurityID);
			if (BenchmarkSecurityIDSource is not null) writer.WriteString(761, BenchmarkSecurityIDSource);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			Spread = view.GetDouble(218);
			BenchmarkCurveCurrency = view.GetString(220);
			BenchmarkCurveCurrencyCodeSource = view.GetString(2950);
			BenchmarkCurveName = view.GetString(221);
			BenchmarkCurvePoint = view.GetString(222);
			BenchmarkPrice = view.GetDouble(662);
			BenchmarkPriceType = view.GetInt32(663);
			BenchmarkSecurityID = view.GetString(699);
			BenchmarkSecurityIDSource = view.GetString(761);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "Spread":
				{
					value = Spread;
					break;
				}
				case "BenchmarkCurveCurrency":
				{
					value = BenchmarkCurveCurrency;
					break;
				}
				case "BenchmarkCurveCurrencyCodeSource":
				{
					value = BenchmarkCurveCurrencyCodeSource;
					break;
				}
				case "BenchmarkCurveName":
				{
					value = BenchmarkCurveName;
					break;
				}
				case "BenchmarkCurvePoint":
				{
					value = BenchmarkCurvePoint;
					break;
				}
				case "BenchmarkPrice":
				{
					value = BenchmarkPrice;
					break;
				}
				case "BenchmarkPriceType":
				{
					value = BenchmarkPriceType;
					break;
				}
				case "BenchmarkSecurityID":
				{
					value = BenchmarkSecurityID;
					break;
				}
				case "BenchmarkSecurityIDSource":
				{
					value = BenchmarkSecurityIDSource;
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
			Spread = null;
			BenchmarkCurveCurrency = null;
			BenchmarkCurveCurrencyCodeSource = null;
			BenchmarkCurveName = null;
			BenchmarkCurvePoint = null;
			BenchmarkPrice = null;
			BenchmarkPriceType = null;
			BenchmarkSecurityID = null;
			BenchmarkSecurityIDSource = null;
		}
	}
}
