using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TriggeringInstruction : IFixComponent
	{
		[TagDetails(Tag = 1100, Type = TagType.String, Offset = 0, Required = false)]
		public string? TriggerType {get; set;}
		
		[TagDetails(Tag = 1101, Type = TagType.String, Offset = 1, Required = false)]
		public string? TriggerAction {get; set;}
		
		[TagDetails(Tag = 1628, Type = TagType.Int, Offset = 2, Required = false)]
		public int? TriggerScope {get; set;}
		
		[TagDetails(Tag = 1102, Type = TagType.Float, Offset = 3, Required = false)]
		public double? TriggerPrice {get; set;}
		
		[TagDetails(Tag = 1103, Type = TagType.String, Offset = 4, Required = false)]
		public string? TriggerSymbol {get; set;}
		
		[TagDetails(Tag = 1104, Type = TagType.String, Offset = 5, Required = false)]
		public string? TriggerSecurityID {get; set;}
		
		[TagDetails(Tag = 1105, Type = TagType.String, Offset = 6, Required = false)]
		public string? TriggerSecurityIDSource {get; set;}
		
		[TagDetails(Tag = 1106, Type = TagType.String, Offset = 7, Required = false)]
		public string? TriggerSecurityDesc {get; set;}
		
		[TagDetails(Tag = 1107, Type = TagType.String, Offset = 8, Required = false)]
		public string? TriggerPriceType {get; set;}
		
		[TagDetails(Tag = 1108, Type = TagType.String, Offset = 9, Required = false)]
		public string? TriggerPriceTypeScope {get; set;}
		
		[TagDetails(Tag = 1109, Type = TagType.String, Offset = 10, Required = false)]
		public string? TriggerPriceDirection {get; set;}
		
		[TagDetails(Tag = 1110, Type = TagType.Float, Offset = 11, Required = false)]
		public double? TriggerNewPrice {get; set;}
		
		[TagDetails(Tag = 1111, Type = TagType.String, Offset = 12, Required = false)]
		public string? TriggerOrderType {get; set;}
		
		[TagDetails(Tag = 1112, Type = TagType.Float, Offset = 13, Required = false)]
		public double? TriggerNewQty {get; set;}
		
		[TagDetails(Tag = 1113, Type = TagType.String, Offset = 14, Required = false)]
		public string? TriggerTradingSessionID {get; set;}
		
		[TagDetails(Tag = 1114, Type = TagType.String, Offset = 15, Required = false)]
		public string? TriggerTradingSessionSubID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TriggerType is not null) writer.WriteString(1100, TriggerType);
			if (TriggerAction is not null) writer.WriteString(1101, TriggerAction);
			if (TriggerScope is not null) writer.WriteWholeNumber(1628, TriggerScope.Value);
			if (TriggerPrice is not null) writer.WriteNumber(1102, TriggerPrice.Value);
			if (TriggerSymbol is not null) writer.WriteString(1103, TriggerSymbol);
			if (TriggerSecurityID is not null) writer.WriteString(1104, TriggerSecurityID);
			if (TriggerSecurityIDSource is not null) writer.WriteString(1105, TriggerSecurityIDSource);
			if (TriggerSecurityDesc is not null) writer.WriteString(1106, TriggerSecurityDesc);
			if (TriggerPriceType is not null) writer.WriteString(1107, TriggerPriceType);
			if (TriggerPriceTypeScope is not null) writer.WriteString(1108, TriggerPriceTypeScope);
			if (TriggerPriceDirection is not null) writer.WriteString(1109, TriggerPriceDirection);
			if (TriggerNewPrice is not null) writer.WriteNumber(1110, TriggerNewPrice.Value);
			if (TriggerOrderType is not null) writer.WriteString(1111, TriggerOrderType);
			if (TriggerNewQty is not null) writer.WriteNumber(1112, TriggerNewQty.Value);
			if (TriggerTradingSessionID is not null) writer.WriteString(1113, TriggerTradingSessionID);
			if (TriggerTradingSessionSubID is not null) writer.WriteString(1114, TriggerTradingSessionSubID);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			TriggerType = view.GetString(1100);
			TriggerAction = view.GetString(1101);
			TriggerScope = view.GetInt32(1628);
			TriggerPrice = view.GetDouble(1102);
			TriggerSymbol = view.GetString(1103);
			TriggerSecurityID = view.GetString(1104);
			TriggerSecurityIDSource = view.GetString(1105);
			TriggerSecurityDesc = view.GetString(1106);
			TriggerPriceType = view.GetString(1107);
			TriggerPriceTypeScope = view.GetString(1108);
			TriggerPriceDirection = view.GetString(1109);
			TriggerNewPrice = view.GetDouble(1110);
			TriggerOrderType = view.GetString(1111);
			TriggerNewQty = view.GetDouble(1112);
			TriggerTradingSessionID = view.GetString(1113);
			TriggerTradingSessionSubID = view.GetString(1114);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "TriggerType":
				{
					value = TriggerType;
					break;
				}
				case "TriggerAction":
				{
					value = TriggerAction;
					break;
				}
				case "TriggerScope":
				{
					value = TriggerScope;
					break;
				}
				case "TriggerPrice":
				{
					value = TriggerPrice;
					break;
				}
				case "TriggerSymbol":
				{
					value = TriggerSymbol;
					break;
				}
				case "TriggerSecurityID":
				{
					value = TriggerSecurityID;
					break;
				}
				case "TriggerSecurityIDSource":
				{
					value = TriggerSecurityIDSource;
					break;
				}
				case "TriggerSecurityDesc":
				{
					value = TriggerSecurityDesc;
					break;
				}
				case "TriggerPriceType":
				{
					value = TriggerPriceType;
					break;
				}
				case "TriggerPriceTypeScope":
				{
					value = TriggerPriceTypeScope;
					break;
				}
				case "TriggerPriceDirection":
				{
					value = TriggerPriceDirection;
					break;
				}
				case "TriggerNewPrice":
				{
					value = TriggerNewPrice;
					break;
				}
				case "TriggerOrderType":
				{
					value = TriggerOrderType;
					break;
				}
				case "TriggerNewQty":
				{
					value = TriggerNewQty;
					break;
				}
				case "TriggerTradingSessionID":
				{
					value = TriggerTradingSessionID;
					break;
				}
				case "TriggerTradingSessionSubID":
				{
					value = TriggerTradingSessionSubID;
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
			TriggerType = null;
			TriggerAction = null;
			TriggerScope = null;
			TriggerPrice = null;
			TriggerSymbol = null;
			TriggerSecurityID = null;
			TriggerSecurityIDSource = null;
			TriggerSecurityDesc = null;
			TriggerPriceType = null;
			TriggerPriceTypeScope = null;
			TriggerPriceDirection = null;
			TriggerNewPrice = null;
			TriggerOrderType = null;
			TriggerNewQty = null;
			TriggerTradingSessionID = null;
			TriggerTradingSessionSubID = null;
		}
	}
}
