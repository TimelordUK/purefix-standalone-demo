using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MatchingDataPointGrp : IFixComponent
	{
		public sealed partial class NoMatchingDataPoints : IFixGroup
		{
			[TagDetails(Tag = 2782, Type = TagType.Int, Offset = 0, Required = false)]
			public int? MatchingDataPointIndicator {get; set;}
			
			[TagDetails(Tag = 2783, Type = TagType.String, Offset = 1, Required = false)]
			public string? MatchingDataPointValue {get; set;}
			
			[TagDetails(Tag = 2784, Type = TagType.Int, Offset = 2, Required = false)]
			public int? MatchingDataPointType {get; set;}
			
			[TagDetails(Tag = 2785, Type = TagType.String, Offset = 3, Required = false)]
			public string? MatchingDataPointName {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MatchingDataPointIndicator is not null) writer.WriteWholeNumber(2782, MatchingDataPointIndicator.Value);
				if (MatchingDataPointValue is not null) writer.WriteString(2783, MatchingDataPointValue);
				if (MatchingDataPointType is not null) writer.WriteWholeNumber(2784, MatchingDataPointType.Value);
				if (MatchingDataPointName is not null) writer.WriteString(2785, MatchingDataPointName);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MatchingDataPointIndicator = view.GetInt32(2782);
				MatchingDataPointValue = view.GetString(2783);
				MatchingDataPointType = view.GetInt32(2784);
				MatchingDataPointName = view.GetString(2785);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MatchingDataPointIndicator":
					{
						value = MatchingDataPointIndicator;
						break;
					}
					case "MatchingDataPointValue":
					{
						value = MatchingDataPointValue;
						break;
					}
					case "MatchingDataPointType":
					{
						value = MatchingDataPointType;
						break;
					}
					case "MatchingDataPointName":
					{
						value = MatchingDataPointName;
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
				MatchingDataPointIndicator = null;
				MatchingDataPointValue = null;
				MatchingDataPointType = null;
				MatchingDataPointName = null;
			}
		}
		[Group(NoOfTag = 2781, Offset = 0, Required = false)]
		public NoMatchingDataPoints[]? MatchingDataPoints {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MatchingDataPoints is not null && MatchingDataPoints.Length != 0)
			{
				writer.WriteWholeNumber(2781, MatchingDataPoints.Length);
				for (int i = 0; i < MatchingDataPoints.Length; i++)
				{
					((IFixEncoder)MatchingDataPoints[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMatchingDataPoints") is IMessageView viewNoMatchingDataPoints)
			{
				var count = viewNoMatchingDataPoints.GroupCount();
				MatchingDataPoints = new NoMatchingDataPoints[count];
				for (int i = 0; i < count; i++)
				{
					MatchingDataPoints[i] = new();
					((IFixParser)MatchingDataPoints[i]).Parse(viewNoMatchingDataPoints.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMatchingDataPoints":
				{
					value = MatchingDataPoints;
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
			MatchingDataPoints = null;
		}
	}
}
