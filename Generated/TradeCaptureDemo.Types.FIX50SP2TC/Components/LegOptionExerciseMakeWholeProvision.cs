using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseMakeWholeProvision : IFixComponent
	{
		[TagDetails(Tag = 42392, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? LegMakeWholeDate {get; set;}
		
		[TagDetails(Tag = 42393, Type = TagType.Float, Offset = 1, Required = false)]
		public double? LegMakeWholeAmount {get; set;}
		
		[TagDetails(Tag = 42394, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegMakeWholeBenchmarkCurveName {get; set;}
		
		[TagDetails(Tag = 42395, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegMakeWholeBenchmarkCurvePoint {get; set;}
		
		[TagDetails(Tag = 42396, Type = TagType.Float, Offset = 4, Required = false)]
		public double? LegMakeWholeRecallSpread {get; set;}
		
		[TagDetails(Tag = 42397, Type = TagType.Int, Offset = 5, Required = false)]
		public int? LegMakeWholeBenchmarkQuote {get; set;}
		
		[TagDetails(Tag = 42398, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegMakeWholeInterpolationMethod {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegMakeWholeDate is not null) writer.WriteLocalDateOnly(42392, LegMakeWholeDate.Value);
			if (LegMakeWholeAmount is not null) writer.WriteNumber(42393, LegMakeWholeAmount.Value);
			if (LegMakeWholeBenchmarkCurveName is not null) writer.WriteString(42394, LegMakeWholeBenchmarkCurveName);
			if (LegMakeWholeBenchmarkCurvePoint is not null) writer.WriteString(42395, LegMakeWholeBenchmarkCurvePoint);
			if (LegMakeWholeRecallSpread is not null) writer.WriteNumber(42396, LegMakeWholeRecallSpread.Value);
			if (LegMakeWholeBenchmarkQuote is not null) writer.WriteWholeNumber(42397, LegMakeWholeBenchmarkQuote.Value);
			if (LegMakeWholeInterpolationMethod is not null) writer.WriteWholeNumber(42398, LegMakeWholeInterpolationMethod.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegMakeWholeDate = view.GetDateOnly(42392);
			LegMakeWholeAmount = view.GetDouble(42393);
			LegMakeWholeBenchmarkCurveName = view.GetString(42394);
			LegMakeWholeBenchmarkCurvePoint = view.GetString(42395);
			LegMakeWholeRecallSpread = view.GetDouble(42396);
			LegMakeWholeBenchmarkQuote = view.GetInt32(42397);
			LegMakeWholeInterpolationMethod = view.GetInt32(42398);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegMakeWholeDate":
				{
					value = LegMakeWholeDate;
					break;
				}
				case "LegMakeWholeAmount":
				{
					value = LegMakeWholeAmount;
					break;
				}
				case "LegMakeWholeBenchmarkCurveName":
				{
					value = LegMakeWholeBenchmarkCurveName;
					break;
				}
				case "LegMakeWholeBenchmarkCurvePoint":
				{
					value = LegMakeWholeBenchmarkCurvePoint;
					break;
				}
				case "LegMakeWholeRecallSpread":
				{
					value = LegMakeWholeRecallSpread;
					break;
				}
				case "LegMakeWholeBenchmarkQuote":
				{
					value = LegMakeWholeBenchmarkQuote;
					break;
				}
				case "LegMakeWholeInterpolationMethod":
				{
					value = LegMakeWholeInterpolationMethod;
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
			LegMakeWholeDate = null;
			LegMakeWholeAmount = null;
			LegMakeWholeBenchmarkCurveName = null;
			LegMakeWholeBenchmarkCurvePoint = null;
			LegMakeWholeRecallSpread = null;
			LegMakeWholeBenchmarkQuote = null;
			LegMakeWholeInterpolationMethod = null;
		}
	}
}
