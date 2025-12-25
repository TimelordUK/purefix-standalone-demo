using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseMakeWholeProvision : IFixComponent
	{
		[TagDetails(Tag = 42888, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? UnderlyingMakeWholeDate {get; set;}
		
		[TagDetails(Tag = 42889, Type = TagType.Float, Offset = 1, Required = false)]
		public double? UnderlyingMakeWholeAmount {get; set;}
		
		[TagDetails(Tag = 42890, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingMakeWholeBenchmarkCurveName {get; set;}
		
		[TagDetails(Tag = 42891, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingMakeWholeBenchmarkCurvePoint {get; set;}
		
		[TagDetails(Tag = 42892, Type = TagType.Float, Offset = 4, Required = false)]
		public double? UnderlyingMakeWholeRecallSpread {get; set;}
		
		[TagDetails(Tag = 42893, Type = TagType.Int, Offset = 5, Required = false)]
		public int? UnderlyingMakeWholeBenchmarkQuote {get; set;}
		
		[TagDetails(Tag = 42894, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingMakeWholeInterpolationMethod {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingMakeWholeDate is not null) writer.WriteLocalDateOnly(42888, UnderlyingMakeWholeDate.Value);
			if (UnderlyingMakeWholeAmount is not null) writer.WriteNumber(42889, UnderlyingMakeWholeAmount.Value);
			if (UnderlyingMakeWholeBenchmarkCurveName is not null) writer.WriteString(42890, UnderlyingMakeWholeBenchmarkCurveName);
			if (UnderlyingMakeWholeBenchmarkCurvePoint is not null) writer.WriteString(42891, UnderlyingMakeWholeBenchmarkCurvePoint);
			if (UnderlyingMakeWholeRecallSpread is not null) writer.WriteNumber(42892, UnderlyingMakeWholeRecallSpread.Value);
			if (UnderlyingMakeWholeBenchmarkQuote is not null) writer.WriteWholeNumber(42893, UnderlyingMakeWholeBenchmarkQuote.Value);
			if (UnderlyingMakeWholeInterpolationMethod is not null) writer.WriteWholeNumber(42894, UnderlyingMakeWholeInterpolationMethod.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingMakeWholeDate = view.GetDateOnly(42888);
			UnderlyingMakeWholeAmount = view.GetDouble(42889);
			UnderlyingMakeWholeBenchmarkCurveName = view.GetString(42890);
			UnderlyingMakeWholeBenchmarkCurvePoint = view.GetString(42891);
			UnderlyingMakeWholeRecallSpread = view.GetDouble(42892);
			UnderlyingMakeWholeBenchmarkQuote = view.GetInt32(42893);
			UnderlyingMakeWholeInterpolationMethod = view.GetInt32(42894);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingMakeWholeDate":
				{
					value = UnderlyingMakeWholeDate;
					break;
				}
				case "UnderlyingMakeWholeAmount":
				{
					value = UnderlyingMakeWholeAmount;
					break;
				}
				case "UnderlyingMakeWholeBenchmarkCurveName":
				{
					value = UnderlyingMakeWholeBenchmarkCurveName;
					break;
				}
				case "UnderlyingMakeWholeBenchmarkCurvePoint":
				{
					value = UnderlyingMakeWholeBenchmarkCurvePoint;
					break;
				}
				case "UnderlyingMakeWholeRecallSpread":
				{
					value = UnderlyingMakeWholeRecallSpread;
					break;
				}
				case "UnderlyingMakeWholeBenchmarkQuote":
				{
					value = UnderlyingMakeWholeBenchmarkQuote;
					break;
				}
				case "UnderlyingMakeWholeInterpolationMethod":
				{
					value = UnderlyingMakeWholeInterpolationMethod;
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
			UnderlyingMakeWholeDate = null;
			UnderlyingMakeWholeAmount = null;
			UnderlyingMakeWholeBenchmarkCurveName = null;
			UnderlyingMakeWholeBenchmarkCurvePoint = null;
			UnderlyingMakeWholeRecallSpread = null;
			UnderlyingMakeWholeBenchmarkQuote = null;
			UnderlyingMakeWholeInterpolationMethod = null;
		}
	}
}
