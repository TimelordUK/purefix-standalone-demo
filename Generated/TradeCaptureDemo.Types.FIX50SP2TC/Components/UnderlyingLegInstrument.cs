using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingLegInstrument : IFixComponent
	{
		[TagDetails(Tag = 1330, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingLegSymbol {get; set;}
		
		[TagDetails(Tag = 1331, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingLegSymbolSfx {get; set;}
		
		[TagDetails(Tag = 1332, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingLegSecurityID {get; set;}
		
		[TagDetails(Tag = 1333, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingLegSecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingLegSecurityAltIDGrp? UnderlyingLegSecurityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 1344, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingLegCFICode {get; set;}
		
		[TagDetails(Tag = 1337, Type = TagType.String, Offset = 6, Required = false)]
		public string? UnderlyingLegSecurityType {get; set;}
		
		[TagDetails(Tag = 1338, Type = TagType.String, Offset = 7, Required = false)]
		public string? UnderlyingLegSecuritySubType {get; set;}
		
		[TagDetails(Tag = 1339, Type = TagType.MonthYear, Offset = 8, Required = false)]
		public MonthYear? UnderlyingLegMaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 1345, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? UnderlyingLegMaturityDate {get; set;}
		
		[TagDetails(Tag = 1405, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingLegMaturityTime {get; set;}
		
		[TagDetails(Tag = 1340, Type = TagType.Float, Offset = 11, Required = false)]
		public double? UnderlyingLegStrikePrice {get; set;}
		
		[TagDetails(Tag = 1391, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingLegOptAttribute {get; set;}
		
		[TagDetails(Tag = 1343, Type = TagType.Int, Offset = 13, Required = false)]
		public int? UnderlyingLegPutOrCall {get; set;}
		
		[TagDetails(Tag = 1341, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingLegSecurityExchange {get; set;}
		
		[TagDetails(Tag = 1392, Type = TagType.String, Offset = 15, Required = false)]
		public string? UnderlyingLegSecurityDesc {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingLegSymbol is not null) writer.WriteString(1330, UnderlyingLegSymbol);
			if (UnderlyingLegSymbolSfx is not null) writer.WriteString(1331, UnderlyingLegSymbolSfx);
			if (UnderlyingLegSecurityID is not null) writer.WriteString(1332, UnderlyingLegSecurityID);
			if (UnderlyingLegSecurityIDSource is not null) writer.WriteString(1333, UnderlyingLegSecurityIDSource);
			if (UnderlyingLegSecurityAltIDGrp is not null) ((IFixEncoder)UnderlyingLegSecurityAltIDGrp).Encode(writer);
			if (UnderlyingLegCFICode is not null) writer.WriteString(1344, UnderlyingLegCFICode);
			if (UnderlyingLegSecurityType is not null) writer.WriteString(1337, UnderlyingLegSecurityType);
			if (UnderlyingLegSecuritySubType is not null) writer.WriteString(1338, UnderlyingLegSecuritySubType);
			if (UnderlyingLegMaturityMonthYear is not null) writer.WriteMonthYear(1339, UnderlyingLegMaturityMonthYear.Value);
			if (UnderlyingLegMaturityDate is not null) writer.WriteLocalDateOnly(1345, UnderlyingLegMaturityDate.Value);
			if (UnderlyingLegMaturityTime is not null) writer.WriteString(1405, UnderlyingLegMaturityTime);
			if (UnderlyingLegStrikePrice is not null) writer.WriteNumber(1340, UnderlyingLegStrikePrice.Value);
			if (UnderlyingLegOptAttribute is not null) writer.WriteString(1391, UnderlyingLegOptAttribute);
			if (UnderlyingLegPutOrCall is not null) writer.WriteWholeNumber(1343, UnderlyingLegPutOrCall.Value);
			if (UnderlyingLegSecurityExchange is not null) writer.WriteString(1341, UnderlyingLegSecurityExchange);
			if (UnderlyingLegSecurityDesc is not null) writer.WriteString(1392, UnderlyingLegSecurityDesc);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingLegSymbol = view.GetString(1330);
			UnderlyingLegSymbolSfx = view.GetString(1331);
			UnderlyingLegSecurityID = view.GetString(1332);
			UnderlyingLegSecurityIDSource = view.GetString(1333);
			if (view.GetView("UnderlyingLegSecurityAltIDGrp") is IMessageView viewUnderlyingLegSecurityAltIDGrp)
			{
				UnderlyingLegSecurityAltIDGrp = new();
				((IFixParser)UnderlyingLegSecurityAltIDGrp).Parse(viewUnderlyingLegSecurityAltIDGrp);
			}
			UnderlyingLegCFICode = view.GetString(1344);
			UnderlyingLegSecurityType = view.GetString(1337);
			UnderlyingLegSecuritySubType = view.GetString(1338);
			UnderlyingLegMaturityMonthYear = view.GetMonthYear(1339);
			UnderlyingLegMaturityDate = view.GetDateOnly(1345);
			UnderlyingLegMaturityTime = view.GetString(1405);
			UnderlyingLegStrikePrice = view.GetDouble(1340);
			UnderlyingLegOptAttribute = view.GetString(1391);
			UnderlyingLegPutOrCall = view.GetInt32(1343);
			UnderlyingLegSecurityExchange = view.GetString(1341);
			UnderlyingLegSecurityDesc = view.GetString(1392);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingLegSymbol":
				{
					value = UnderlyingLegSymbol;
					break;
				}
				case "UnderlyingLegSymbolSfx":
				{
					value = UnderlyingLegSymbolSfx;
					break;
				}
				case "UnderlyingLegSecurityID":
				{
					value = UnderlyingLegSecurityID;
					break;
				}
				case "UnderlyingLegSecurityIDSource":
				{
					value = UnderlyingLegSecurityIDSource;
					break;
				}
				case "UnderlyingLegSecurityAltIDGrp":
				{
					value = UnderlyingLegSecurityAltIDGrp;
					break;
				}
				case "UnderlyingLegCFICode":
				{
					value = UnderlyingLegCFICode;
					break;
				}
				case "UnderlyingLegSecurityType":
				{
					value = UnderlyingLegSecurityType;
					break;
				}
				case "UnderlyingLegSecuritySubType":
				{
					value = UnderlyingLegSecuritySubType;
					break;
				}
				case "UnderlyingLegMaturityMonthYear":
				{
					value = UnderlyingLegMaturityMonthYear;
					break;
				}
				case "UnderlyingLegMaturityDate":
				{
					value = UnderlyingLegMaturityDate;
					break;
				}
				case "UnderlyingLegMaturityTime":
				{
					value = UnderlyingLegMaturityTime;
					break;
				}
				case "UnderlyingLegStrikePrice":
				{
					value = UnderlyingLegStrikePrice;
					break;
				}
				case "UnderlyingLegOptAttribute":
				{
					value = UnderlyingLegOptAttribute;
					break;
				}
				case "UnderlyingLegPutOrCall":
				{
					value = UnderlyingLegPutOrCall;
					break;
				}
				case "UnderlyingLegSecurityExchange":
				{
					value = UnderlyingLegSecurityExchange;
					break;
				}
				case "UnderlyingLegSecurityDesc":
				{
					value = UnderlyingLegSecurityDesc;
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
			UnderlyingLegSymbol = null;
			UnderlyingLegSymbolSfx = null;
			UnderlyingLegSecurityID = null;
			UnderlyingLegSecurityIDSource = null;
			((IFixReset?)UnderlyingLegSecurityAltIDGrp)?.Reset();
			UnderlyingLegCFICode = null;
			UnderlyingLegSecurityType = null;
			UnderlyingLegSecuritySubType = null;
			UnderlyingLegMaturityMonthYear = null;
			UnderlyingLegMaturityDate = null;
			UnderlyingLegMaturityTime = null;
			UnderlyingLegStrikePrice = null;
			UnderlyingLegOptAttribute = null;
			UnderlyingLegPutOrCall = null;
			UnderlyingLegSecurityExchange = null;
			UnderlyingLegSecurityDesc = null;
		}
	}
}
