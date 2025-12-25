using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseMakeWholeProvision : IFixComponent
	{
		[TagDetails(Tag = 42591, Type = TagType.LocalDate, Offset = 0, Required = false)]
		public DateOnly? MakeWholeDate {get; set;}
		
		[TagDetails(Tag = 42592, Type = TagType.Float, Offset = 1, Required = false)]
		public double? MakeWholeAmount {get; set;}
		
		[TagDetails(Tag = 42593, Type = TagType.String, Offset = 2, Required = false)]
		public string? MakeWholeBenchmarkCurveName {get; set;}
		
		[TagDetails(Tag = 42594, Type = TagType.String, Offset = 3, Required = false)]
		public string? MakeWholeBenchmarkCurvePoint {get; set;}
		
		[TagDetails(Tag = 42595, Type = TagType.Float, Offset = 4, Required = false)]
		public double? MakeWholeRecallSpread {get; set;}
		
		[TagDetails(Tag = 42596, Type = TagType.Int, Offset = 5, Required = false)]
		public int? MakeWholeBenchmarkQuote {get; set;}
		
		[TagDetails(Tag = 42597, Type = TagType.Int, Offset = 6, Required = false)]
		public int? MakeWholeInterpolationMethod {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MakeWholeDate is not null) writer.WriteLocalDateOnly(42591, MakeWholeDate.Value);
			if (MakeWholeAmount is not null) writer.WriteNumber(42592, MakeWholeAmount.Value);
			if (MakeWholeBenchmarkCurveName is not null) writer.WriteString(42593, MakeWholeBenchmarkCurveName);
			if (MakeWholeBenchmarkCurvePoint is not null) writer.WriteString(42594, MakeWholeBenchmarkCurvePoint);
			if (MakeWholeRecallSpread is not null) writer.WriteNumber(42595, MakeWholeRecallSpread.Value);
			if (MakeWholeBenchmarkQuote is not null) writer.WriteWholeNumber(42596, MakeWholeBenchmarkQuote.Value);
			if (MakeWholeInterpolationMethod is not null) writer.WriteWholeNumber(42597, MakeWholeInterpolationMethod.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			MakeWholeDate = view.GetDateOnly(42591);
			MakeWholeAmount = view.GetDouble(42592);
			MakeWholeBenchmarkCurveName = view.GetString(42593);
			MakeWholeBenchmarkCurvePoint = view.GetString(42594);
			MakeWholeRecallSpread = view.GetDouble(42595);
			MakeWholeBenchmarkQuote = view.GetInt32(42596);
			MakeWholeInterpolationMethod = view.GetInt32(42597);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "MakeWholeDate":
				{
					value = MakeWholeDate;
					break;
				}
				case "MakeWholeAmount":
				{
					value = MakeWholeAmount;
					break;
				}
				case "MakeWholeBenchmarkCurveName":
				{
					value = MakeWholeBenchmarkCurveName;
					break;
				}
				case "MakeWholeBenchmarkCurvePoint":
				{
					value = MakeWholeBenchmarkCurvePoint;
					break;
				}
				case "MakeWholeRecallSpread":
				{
					value = MakeWholeRecallSpread;
					break;
				}
				case "MakeWholeBenchmarkQuote":
				{
					value = MakeWholeBenchmarkQuote;
					break;
				}
				case "MakeWholeInterpolationMethod":
				{
					value = MakeWholeInterpolationMethod;
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
			MakeWholeDate = null;
			MakeWholeAmount = null;
			MakeWholeBenchmarkCurveName = null;
			MakeWholeBenchmarkCurvePoint = null;
			MakeWholeRecallSpread = null;
			MakeWholeBenchmarkQuote = null;
			MakeWholeInterpolationMethod = null;
		}
	}
}
