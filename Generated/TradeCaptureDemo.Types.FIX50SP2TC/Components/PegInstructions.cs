using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PegInstructions : IFixComponent
	{
		[TagDetails(Tag = 211, Type = TagType.Float, Offset = 0, Required = false)]
		public double? PegOffsetValue {get; set;}
		
		[TagDetails(Tag = 1094, Type = TagType.Int, Offset = 1, Required = false)]
		public int? PegPriceType {get; set;}
		
		[TagDetails(Tag = 835, Type = TagType.Int, Offset = 2, Required = false)]
		public int? PegMoveType {get; set;}
		
		[TagDetails(Tag = 836, Type = TagType.Int, Offset = 3, Required = false)]
		public int? PegOffsetType {get; set;}
		
		[TagDetails(Tag = 837, Type = TagType.Int, Offset = 4, Required = false)]
		public int? PegLimitType {get; set;}
		
		[TagDetails(Tag = 838, Type = TagType.Int, Offset = 5, Required = false)]
		public int? PegRoundDirection {get; set;}
		
		[TagDetails(Tag = 840, Type = TagType.Int, Offset = 6, Required = false)]
		public int? PegScope {get; set;}
		
		[TagDetails(Tag = 1096, Type = TagType.String, Offset = 7, Required = false)]
		public string? PegSecurityIDSource {get; set;}
		
		[TagDetails(Tag = 1097, Type = TagType.String, Offset = 8, Required = false)]
		public string? PegSecurityID {get; set;}
		
		[TagDetails(Tag = 1098, Type = TagType.String, Offset = 9, Required = false)]
		public string? PegSymbol {get; set;}
		
		[TagDetails(Tag = 1099, Type = TagType.String, Offset = 10, Required = false)]
		public string? PegSecurityDesc {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PegOffsetValue is not null) writer.WriteNumber(211, PegOffsetValue.Value);
			if (PegPriceType is not null) writer.WriteWholeNumber(1094, PegPriceType.Value);
			if (PegMoveType is not null) writer.WriteWholeNumber(835, PegMoveType.Value);
			if (PegOffsetType is not null) writer.WriteWholeNumber(836, PegOffsetType.Value);
			if (PegLimitType is not null) writer.WriteWholeNumber(837, PegLimitType.Value);
			if (PegRoundDirection is not null) writer.WriteWholeNumber(838, PegRoundDirection.Value);
			if (PegScope is not null) writer.WriteWholeNumber(840, PegScope.Value);
			if (PegSecurityIDSource is not null) writer.WriteString(1096, PegSecurityIDSource);
			if (PegSecurityID is not null) writer.WriteString(1097, PegSecurityID);
			if (PegSymbol is not null) writer.WriteString(1098, PegSymbol);
			if (PegSecurityDesc is not null) writer.WriteString(1099, PegSecurityDesc);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			PegOffsetValue = view.GetDouble(211);
			PegPriceType = view.GetInt32(1094);
			PegMoveType = view.GetInt32(835);
			PegOffsetType = view.GetInt32(836);
			PegLimitType = view.GetInt32(837);
			PegRoundDirection = view.GetInt32(838);
			PegScope = view.GetInt32(840);
			PegSecurityIDSource = view.GetString(1096);
			PegSecurityID = view.GetString(1097);
			PegSymbol = view.GetString(1098);
			PegSecurityDesc = view.GetString(1099);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "PegOffsetValue":
				{
					value = PegOffsetValue;
					break;
				}
				case "PegPriceType":
				{
					value = PegPriceType;
					break;
				}
				case "PegMoveType":
				{
					value = PegMoveType;
					break;
				}
				case "PegOffsetType":
				{
					value = PegOffsetType;
					break;
				}
				case "PegLimitType":
				{
					value = PegLimitType;
					break;
				}
				case "PegRoundDirection":
				{
					value = PegRoundDirection;
					break;
				}
				case "PegScope":
				{
					value = PegScope;
					break;
				}
				case "PegSecurityIDSource":
				{
					value = PegSecurityIDSource;
					break;
				}
				case "PegSecurityID":
				{
					value = PegSecurityID;
					break;
				}
				case "PegSymbol":
				{
					value = PegSymbol;
					break;
				}
				case "PegSecurityDesc":
				{
					value = PegSecurityDesc;
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
			PegOffsetValue = null;
			PegPriceType = null;
			PegMoveType = null;
			PegOffsetType = null;
			PegLimitType = null;
			PegRoundDirection = null;
			PegScope = null;
			PegSecurityIDSource = null;
			PegSecurityID = null;
			PegSymbol = null;
			PegSecurityDesc = null;
		}
	}
}
