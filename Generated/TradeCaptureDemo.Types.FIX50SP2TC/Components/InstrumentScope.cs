using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentScope : IFixComponent
	{
		[TagDetails(Tag = 1536, Type = TagType.String, Offset = 0, Required = false)]
		public string? InstrumentScopeSymbol {get; set;}
		
		[TagDetails(Tag = 1537, Type = TagType.String, Offset = 1, Required = false)]
		public string? InstrumentScopeSymbolSfx {get; set;}
		
		[TagDetails(Tag = 1538, Type = TagType.String, Offset = 2, Required = false)]
		public string? InstrumentScopeSecurityID {get; set;}
		
		[TagDetails(Tag = 1539, Type = TagType.String, Offset = 3, Required = false)]
		public string? InstrumentScopeSecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public InstrumentScopeSecurityAltIDGrp? InstrumentScopeSecurityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 1543, Type = TagType.Int, Offset = 5, Required = false)]
		public int? InstrumentScopeProduct {get; set;}
		
		[TagDetails(Tag = 1544, Type = TagType.String, Offset = 6, Required = false)]
		public string? InstrumentScopeProductComplex {get; set;}
		
		[TagDetails(Tag = 1545, Type = TagType.String, Offset = 7, Required = false)]
		public string? InstrumentScopeSecurityGroup {get; set;}
		
		[TagDetails(Tag = 1546, Type = TagType.String, Offset = 8, Required = false)]
		public string? InstrumentScopeCFICode {get; set;}
		
		[TagDetails(Tag = 2895, Type = TagType.String, Offset = 9, Required = false)]
		public string? InstrumentScopeUPICode {get; set;}
		
		[TagDetails(Tag = 1547, Type = TagType.String, Offset = 10, Required = false)]
		public string? InstrumentScopeSecurityType {get; set;}
		
		[TagDetails(Tag = 1548, Type = TagType.String, Offset = 11, Required = false)]
		public string? InstrumentScopeSecuritySubType {get; set;}
		
		[TagDetails(Tag = 1549, Type = TagType.MonthYear, Offset = 12, Required = false)]
		public MonthYear? InstrumentScopeMaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 1550, Type = TagType.String, Offset = 13, Required = false)]
		public string? InstrumentScopeMaturityTime {get; set;}
		
		[TagDetails(Tag = 1551, Type = TagType.String, Offset = 14, Required = false)]
		public string? InstrumentScopeRestructuringType {get; set;}
		
		[TagDetails(Tag = 1552, Type = TagType.String, Offset = 15, Required = false)]
		public string? InstrumentScopeSeniority {get; set;}
		
		[TagDetails(Tag = 1553, Type = TagType.Int, Offset = 16, Required = false)]
		public int? InstrumentScopePutOrCall {get; set;}
		
		[TagDetails(Tag = 1554, Type = TagType.Boolean, Offset = 17, Required = false)]
		public bool? InstrumentScopeFlexibleIndicator {get; set;}
		
		[TagDetails(Tag = 1555, Type = TagType.Float, Offset = 18, Required = false)]
		public double? InstrumentScopeCouponRate {get; set;}
		
		[TagDetails(Tag = 1616, Type = TagType.String, Offset = 19, Required = false)]
		public string? InstrumentScopeSecurityExchange {get; set;}
		
		[TagDetails(Tag = 1556, Type = TagType.String, Offset = 20, Required = false)]
		public string? InstrumentScopeSecurityDesc {get; set;}
		
		[TagDetails(Tag = 1620, Type = TagType.Length, Offset = 21, Required = false)]
		public int? InstrumentScopeEncodedSecurityDescLen {get; set;}
		
		[TagDetails(Tag = 1621, Type = TagType.RawData, Offset = 22, Required = false)]
		public byte[]? InstrumentScopeEncodedSecurityDesc {get; set;}
		
		[TagDetails(Tag = 1557, Type = TagType.String, Offset = 23, Required = false)]
		public string? InstrumentScopeSettlType {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrumentScopeSymbol is not null) writer.WriteString(1536, InstrumentScopeSymbol);
			if (InstrumentScopeSymbolSfx is not null) writer.WriteString(1537, InstrumentScopeSymbolSfx);
			if (InstrumentScopeSecurityID is not null) writer.WriteString(1538, InstrumentScopeSecurityID);
			if (InstrumentScopeSecurityIDSource is not null) writer.WriteString(1539, InstrumentScopeSecurityIDSource);
			if (InstrumentScopeSecurityAltIDGrp is not null) ((IFixEncoder)InstrumentScopeSecurityAltIDGrp).Encode(writer);
			if (InstrumentScopeProduct is not null) writer.WriteWholeNumber(1543, InstrumentScopeProduct.Value);
			if (InstrumentScopeProductComplex is not null) writer.WriteString(1544, InstrumentScopeProductComplex);
			if (InstrumentScopeSecurityGroup is not null) writer.WriteString(1545, InstrumentScopeSecurityGroup);
			if (InstrumentScopeCFICode is not null) writer.WriteString(1546, InstrumentScopeCFICode);
			if (InstrumentScopeUPICode is not null) writer.WriteString(2895, InstrumentScopeUPICode);
			if (InstrumentScopeSecurityType is not null) writer.WriteString(1547, InstrumentScopeSecurityType);
			if (InstrumentScopeSecuritySubType is not null) writer.WriteString(1548, InstrumentScopeSecuritySubType);
			if (InstrumentScopeMaturityMonthYear is not null) writer.WriteMonthYear(1549, InstrumentScopeMaturityMonthYear.Value);
			if (InstrumentScopeMaturityTime is not null) writer.WriteString(1550, InstrumentScopeMaturityTime);
			if (InstrumentScopeRestructuringType is not null) writer.WriteString(1551, InstrumentScopeRestructuringType);
			if (InstrumentScopeSeniority is not null) writer.WriteString(1552, InstrumentScopeSeniority);
			if (InstrumentScopePutOrCall is not null) writer.WriteWholeNumber(1553, InstrumentScopePutOrCall.Value);
			if (InstrumentScopeFlexibleIndicator is not null) writer.WriteBoolean(1554, InstrumentScopeFlexibleIndicator.Value);
			if (InstrumentScopeCouponRate is not null) writer.WriteNumber(1555, InstrumentScopeCouponRate.Value);
			if (InstrumentScopeSecurityExchange is not null) writer.WriteString(1616, InstrumentScopeSecurityExchange);
			if (InstrumentScopeSecurityDesc is not null) writer.WriteString(1556, InstrumentScopeSecurityDesc);
			if (InstrumentScopeEncodedSecurityDescLen is not null) writer.WriteWholeNumber(1620, InstrumentScopeEncodedSecurityDescLen.Value);
			if (InstrumentScopeEncodedSecurityDesc is not null) writer.WriteBuffer(1621, InstrumentScopeEncodedSecurityDesc);
			if (InstrumentScopeSettlType is not null) writer.WriteString(1557, InstrumentScopeSettlType);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			InstrumentScopeSymbol = view.GetString(1536);
			InstrumentScopeSymbolSfx = view.GetString(1537);
			InstrumentScopeSecurityID = view.GetString(1538);
			InstrumentScopeSecurityIDSource = view.GetString(1539);
			if (view.GetView("InstrumentScopeSecurityAltIDGrp") is IMessageView viewInstrumentScopeSecurityAltIDGrp)
			{
				InstrumentScopeSecurityAltIDGrp = new();
				((IFixParser)InstrumentScopeSecurityAltIDGrp).Parse(viewInstrumentScopeSecurityAltIDGrp);
			}
			InstrumentScopeProduct = view.GetInt32(1543);
			InstrumentScopeProductComplex = view.GetString(1544);
			InstrumentScopeSecurityGroup = view.GetString(1545);
			InstrumentScopeCFICode = view.GetString(1546);
			InstrumentScopeUPICode = view.GetString(2895);
			InstrumentScopeSecurityType = view.GetString(1547);
			InstrumentScopeSecuritySubType = view.GetString(1548);
			InstrumentScopeMaturityMonthYear = view.GetMonthYear(1549);
			InstrumentScopeMaturityTime = view.GetString(1550);
			InstrumentScopeRestructuringType = view.GetString(1551);
			InstrumentScopeSeniority = view.GetString(1552);
			InstrumentScopePutOrCall = view.GetInt32(1553);
			InstrumentScopeFlexibleIndicator = view.GetBool(1554);
			InstrumentScopeCouponRate = view.GetDouble(1555);
			InstrumentScopeSecurityExchange = view.GetString(1616);
			InstrumentScopeSecurityDesc = view.GetString(1556);
			InstrumentScopeEncodedSecurityDescLen = view.GetInt32(1620);
			InstrumentScopeEncodedSecurityDesc = view.GetByteArray(1621);
			InstrumentScopeSettlType = view.GetString(1557);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "InstrumentScopeSymbol":
				{
					value = InstrumentScopeSymbol;
					break;
				}
				case "InstrumentScopeSymbolSfx":
				{
					value = InstrumentScopeSymbolSfx;
					break;
				}
				case "InstrumentScopeSecurityID":
				{
					value = InstrumentScopeSecurityID;
					break;
				}
				case "InstrumentScopeSecurityIDSource":
				{
					value = InstrumentScopeSecurityIDSource;
					break;
				}
				case "InstrumentScopeSecurityAltIDGrp":
				{
					value = InstrumentScopeSecurityAltIDGrp;
					break;
				}
				case "InstrumentScopeProduct":
				{
					value = InstrumentScopeProduct;
					break;
				}
				case "InstrumentScopeProductComplex":
				{
					value = InstrumentScopeProductComplex;
					break;
				}
				case "InstrumentScopeSecurityGroup":
				{
					value = InstrumentScopeSecurityGroup;
					break;
				}
				case "InstrumentScopeCFICode":
				{
					value = InstrumentScopeCFICode;
					break;
				}
				case "InstrumentScopeUPICode":
				{
					value = InstrumentScopeUPICode;
					break;
				}
				case "InstrumentScopeSecurityType":
				{
					value = InstrumentScopeSecurityType;
					break;
				}
				case "InstrumentScopeSecuritySubType":
				{
					value = InstrumentScopeSecuritySubType;
					break;
				}
				case "InstrumentScopeMaturityMonthYear":
				{
					value = InstrumentScopeMaturityMonthYear;
					break;
				}
				case "InstrumentScopeMaturityTime":
				{
					value = InstrumentScopeMaturityTime;
					break;
				}
				case "InstrumentScopeRestructuringType":
				{
					value = InstrumentScopeRestructuringType;
					break;
				}
				case "InstrumentScopeSeniority":
				{
					value = InstrumentScopeSeniority;
					break;
				}
				case "InstrumentScopePutOrCall":
				{
					value = InstrumentScopePutOrCall;
					break;
				}
				case "InstrumentScopeFlexibleIndicator":
				{
					value = InstrumentScopeFlexibleIndicator;
					break;
				}
				case "InstrumentScopeCouponRate":
				{
					value = InstrumentScopeCouponRate;
					break;
				}
				case "InstrumentScopeSecurityExchange":
				{
					value = InstrumentScopeSecurityExchange;
					break;
				}
				case "InstrumentScopeSecurityDesc":
				{
					value = InstrumentScopeSecurityDesc;
					break;
				}
				case "InstrumentScopeEncodedSecurityDescLen":
				{
					value = InstrumentScopeEncodedSecurityDescLen;
					break;
				}
				case "InstrumentScopeEncodedSecurityDesc":
				{
					value = InstrumentScopeEncodedSecurityDesc;
					break;
				}
				case "InstrumentScopeSettlType":
				{
					value = InstrumentScopeSettlType;
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
			InstrumentScopeSymbol = null;
			InstrumentScopeSymbolSfx = null;
			InstrumentScopeSecurityID = null;
			InstrumentScopeSecurityIDSource = null;
			((IFixReset?)InstrumentScopeSecurityAltIDGrp)?.Reset();
			InstrumentScopeProduct = null;
			InstrumentScopeProductComplex = null;
			InstrumentScopeSecurityGroup = null;
			InstrumentScopeCFICode = null;
			InstrumentScopeUPICode = null;
			InstrumentScopeSecurityType = null;
			InstrumentScopeSecuritySubType = null;
			InstrumentScopeMaturityMonthYear = null;
			InstrumentScopeMaturityTime = null;
			InstrumentScopeRestructuringType = null;
			InstrumentScopeSeniority = null;
			InstrumentScopePutOrCall = null;
			InstrumentScopeFlexibleIndicator = null;
			InstrumentScopeCouponRate = null;
			InstrumentScopeSecurityExchange = null;
			InstrumentScopeSecurityDesc = null;
			InstrumentScopeEncodedSecurityDescLen = null;
			InstrumentScopeEncodedSecurityDesc = null;
			InstrumentScopeSettlType = null;
		}
	}
}
