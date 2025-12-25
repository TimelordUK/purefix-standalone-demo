using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DiscretionInstructions : IFixComponent
	{
		[TagDetails(Tag = 388, Type = TagType.String, Offset = 0, Required = false)]
		public string? DiscretionInst {get; set;}
		
		[TagDetails(Tag = 389, Type = TagType.Float, Offset = 1, Required = false)]
		public double? DiscretionOffsetValue {get; set;}
		
		[TagDetails(Tag = 841, Type = TagType.Int, Offset = 2, Required = false)]
		public int? DiscretionMoveType {get; set;}
		
		[TagDetails(Tag = 842, Type = TagType.Int, Offset = 3, Required = false)]
		public int? DiscretionOffsetType {get; set;}
		
		[TagDetails(Tag = 843, Type = TagType.Int, Offset = 4, Required = false)]
		public int? DiscretionLimitType {get; set;}
		
		[TagDetails(Tag = 844, Type = TagType.Int, Offset = 5, Required = false)]
		public int? DiscretionRoundDirection {get; set;}
		
		[TagDetails(Tag = 846, Type = TagType.Int, Offset = 6, Required = false)]
		public int? DiscretionScope {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DiscretionInst is not null) writer.WriteString(388, DiscretionInst);
			if (DiscretionOffsetValue is not null) writer.WriteNumber(389, DiscretionOffsetValue.Value);
			if (DiscretionMoveType is not null) writer.WriteWholeNumber(841, DiscretionMoveType.Value);
			if (DiscretionOffsetType is not null) writer.WriteWholeNumber(842, DiscretionOffsetType.Value);
			if (DiscretionLimitType is not null) writer.WriteWholeNumber(843, DiscretionLimitType.Value);
			if (DiscretionRoundDirection is not null) writer.WriteWholeNumber(844, DiscretionRoundDirection.Value);
			if (DiscretionScope is not null) writer.WriteWholeNumber(846, DiscretionScope.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DiscretionInst = view.GetString(388);
			DiscretionOffsetValue = view.GetDouble(389);
			DiscretionMoveType = view.GetInt32(841);
			DiscretionOffsetType = view.GetInt32(842);
			DiscretionLimitType = view.GetInt32(843);
			DiscretionRoundDirection = view.GetInt32(844);
			DiscretionScope = view.GetInt32(846);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DiscretionInst":
				{
					value = DiscretionInst;
					break;
				}
				case "DiscretionOffsetValue":
				{
					value = DiscretionOffsetValue;
					break;
				}
				case "DiscretionMoveType":
				{
					value = DiscretionMoveType;
					break;
				}
				case "DiscretionOffsetType":
				{
					value = DiscretionOffsetType;
					break;
				}
				case "DiscretionLimitType":
				{
					value = DiscretionLimitType;
					break;
				}
				case "DiscretionRoundDirection":
				{
					value = DiscretionRoundDirection;
					break;
				}
				case "DiscretionScope":
				{
					value = DiscretionScope;
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
			DiscretionInst = null;
			DiscretionOffsetValue = null;
			DiscretionMoveType = null;
			DiscretionOffsetType = null;
			DiscretionLimitType = null;
			DiscretionRoundDirection = null;
			DiscretionScope = null;
		}
	}
}
