using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class FloatingRateIndex : IFixComponent
	{
		[TagDetails(Tag = 2731, Type = TagType.String, Offset = 0, Required = false)]
		public string? FloatingRateIndexID {get; set;}
		
		[TagDetails(Tag = 2732, Type = TagType.String, Offset = 1, Required = false)]
		public string? FloatingRateIndexIDSource {get; set;}
		
		[TagDetails(Tag = 2730, Type = TagType.String, Offset = 2, Required = false)]
		public string? FloatingRateIndexCurveUnit {get; set;}
		
		[TagDetails(Tag = 2728, Type = TagType.Int, Offset = 3, Required = false)]
		public int? FloatingRateIndexCurvePeriod {get; set;}
		
		[TagDetails(Tag = 2729, Type = TagType.Float, Offset = 4, Required = false)]
		public double? FloatingRateIndexCurveSpread {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (FloatingRateIndexID is not null) writer.WriteString(2731, FloatingRateIndexID);
			if (FloatingRateIndexIDSource is not null) writer.WriteString(2732, FloatingRateIndexIDSource);
			if (FloatingRateIndexCurveUnit is not null) writer.WriteString(2730, FloatingRateIndexCurveUnit);
			if (FloatingRateIndexCurvePeriod is not null) writer.WriteWholeNumber(2728, FloatingRateIndexCurvePeriod.Value);
			if (FloatingRateIndexCurveSpread is not null) writer.WriteNumber(2729, FloatingRateIndexCurveSpread.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			FloatingRateIndexID = view.GetString(2731);
			FloatingRateIndexIDSource = view.GetString(2732);
			FloatingRateIndexCurveUnit = view.GetString(2730);
			FloatingRateIndexCurvePeriod = view.GetInt32(2728);
			FloatingRateIndexCurveSpread = view.GetDouble(2729);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "FloatingRateIndexID":
				{
					value = FloatingRateIndexID;
					break;
				}
				case "FloatingRateIndexIDSource":
				{
					value = FloatingRateIndexIDSource;
					break;
				}
				case "FloatingRateIndexCurveUnit":
				{
					value = FloatingRateIndexCurveUnit;
					break;
				}
				case "FloatingRateIndexCurvePeriod":
				{
					value = FloatingRateIndexCurvePeriod;
					break;
				}
				case "FloatingRateIndexCurveSpread":
				{
					value = FloatingRateIndexCurveSpread;
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
			FloatingRateIndexID = null;
			FloatingRateIndexIDSource = null;
			FloatingRateIndexCurveUnit = null;
			FloatingRateIndexCurvePeriod = null;
			FloatingRateIndexCurveSpread = null;
		}
	}
}
