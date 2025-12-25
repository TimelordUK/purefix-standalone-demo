using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeInstrument : IFixComponent
	{
		[TagDetails(Tag = 1214, Type = TagType.String, Offset = 0, Required = false)]
		public string? DerivativeSymbol {get; set;}
		
		[TagDetails(Tag = 1215, Type = TagType.String, Offset = 1, Required = false)]
		public string? DerivativeSymbolSfx {get; set;}
		
		[TagDetails(Tag = 1216, Type = TagType.String, Offset = 2, Required = false)]
		public string? DerivativeSecurityID {get; set;}
		
		[TagDetails(Tag = 1217, Type = TagType.String, Offset = 3, Required = false)]
		public string? DerivativeSecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public DerivativeSecurityAltIDGrp? DerivativeSecurityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 1246, Type = TagType.Int, Offset = 5, Required = false)]
		public int? DerivativeProduct {get; set;}
		
		[TagDetails(Tag = 1228, Type = TagType.String, Offset = 6, Required = false)]
		public string? DerivativeProductComplex {get; set;}
		
		[TagDetails(Tag = 1243, Type = TagType.Boolean, Offset = 7, Required = false)]
		public bool? DerivFlexProductEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 1247, Type = TagType.String, Offset = 8, Required = false)]
		public string? DerivativeSecurityGroup {get; set;}
		
		[TagDetails(Tag = 1248, Type = TagType.String, Offset = 9, Required = false)]
		public string? DerivativeCFICode {get; set;}
		
		[TagDetails(Tag = 2892, Type = TagType.String, Offset = 10, Required = false)]
		public string? DerivativeUPICode {get; set;}
		
		[TagDetails(Tag = 1249, Type = TagType.String, Offset = 11, Required = false)]
		public string? DerivativeSecurityType {get; set;}
		
		[TagDetails(Tag = 1250, Type = TagType.String, Offset = 12, Required = false)]
		public string? DerivativeSecuritySubType {get; set;}
		
		[TagDetails(Tag = 1251, Type = TagType.MonthYear, Offset = 13, Required = false)]
		public MonthYear? DerivativeMaturityMonthYear {get; set;}
		
		[TagDetails(Tag = 1252, Type = TagType.LocalDate, Offset = 14, Required = false)]
		public DateOnly? DerivativeMaturityDate {get; set;}
		
		[TagDetails(Tag = 1253, Type = TagType.String, Offset = 15, Required = false)]
		public string? DerivativeMaturityTime {get; set;}
		
		[TagDetails(Tag = 1254, Type = TagType.String, Offset = 16, Required = false)]
		public string? DerivativeSettleOnOpenFlag {get; set;}
		
		[TagDetails(Tag = 1255, Type = TagType.String, Offset = 17, Required = false)]
		public string? DerivativeInstrmtAssignmentMethod {get; set;}
		
		[TagDetails(Tag = 1256, Type = TagType.String, Offset = 18, Required = false)]
		public string? DerivativeSecurityStatus {get; set;}
		
		[TagDetails(Tag = 1276, Type = TagType.LocalDate, Offset = 19, Required = false)]
		public DateOnly? DerivativeIssueDate {get; set;}
		
		[TagDetails(Tag = 1257, Type = TagType.String, Offset = 20, Required = false)]
		public string? DerivativeInstrRegistry {get; set;}
		
		[TagDetails(Tag = 1258, Type = TagType.String, Offset = 21, Required = false)]
		public string? DerivativeCountryOfIssue {get; set;}
		
		[TagDetails(Tag = 1259, Type = TagType.String, Offset = 22, Required = false)]
		public string? DerivativeStateOrProvinceOfIssue {get; set;}
		
		[TagDetails(Tag = 1260, Type = TagType.String, Offset = 23, Required = false)]
		public string? DerivativeLocaleOfIssue {get; set;}
		
		[TagDetails(Tag = 1261, Type = TagType.Float, Offset = 24, Required = false)]
		public double? DerivativeStrikePrice {get; set;}
		
		[TagDetails(Tag = 1262, Type = TagType.String, Offset = 25, Required = false)]
		public string? DerivativeStrikeCurrency {get; set;}
		
		[TagDetails(Tag = 2912, Type = TagType.String, Offset = 26, Required = false)]
		public string? DerivativeStrikeCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1263, Type = TagType.Float, Offset = 27, Required = false)]
		public double? DerivativeStrikeMultiplier {get; set;}
		
		[TagDetails(Tag = 1264, Type = TagType.Float, Offset = 28, Required = false)]
		public double? DerivativeStrikeValue {get; set;}
		
		[TagDetails(Tag = 1265, Type = TagType.String, Offset = 29, Required = false)]
		public string? DerivativeOptAttribute {get; set;}
		
		[TagDetails(Tag = 1266, Type = TagType.Float, Offset = 30, Required = false)]
		public double? DerivativeContractMultiplier {get; set;}
		
		[TagDetails(Tag = 1438, Type = TagType.Int, Offset = 31, Required = false)]
		public int? DerivativeContractMultiplierUnit {get; set;}
		
		[TagDetails(Tag = 1442, Type = TagType.Int, Offset = 32, Required = false)]
		public int? DerivativeFlowScheduleType {get; set;}
		
		[TagDetails(Tag = 1267, Type = TagType.Float, Offset = 33, Required = false)]
		public double? DerivativeMinPriceIncrement {get; set;}
		
		[TagDetails(Tag = 1268, Type = TagType.Float, Offset = 34, Required = false)]
		public double? DerivativeMinPriceIncrementAmount {get; set;}
		
		[TagDetails(Tag = 1269, Type = TagType.String, Offset = 35, Required = false)]
		public string? DerivativeUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1270, Type = TagType.Float, Offset = 36, Required = false)]
		public double? DerivativeUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1722, Type = TagType.String, Offset = 37, Required = false)]
		public string? DerivativeUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2913, Type = TagType.String, Offset = 38, Required = false)]
		public string? DerivativeUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1315, Type = TagType.String, Offset = 39, Required = false)]
		public string? DerivativePriceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 1316, Type = TagType.Float, Offset = 40, Required = false)]
		public double? DerivativePriceUnitOfMeasureQty {get; set;}
		
		[TagDetails(Tag = 1723, Type = TagType.String, Offset = 41, Required = false)]
		public string? DerivativePriceUnitOfMeasureCurrency {get; set;}
		
		[TagDetails(Tag = 2914, Type = TagType.String, Offset = 42, Required = false)]
		public string? DerivativePriceUnitOfMeasureCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1317, Type = TagType.String, Offset = 43, Required = false)]
		public string? DerivativeSettlMethod {get; set;}
		
		[TagDetails(Tag = 1318, Type = TagType.String, Offset = 44, Required = false)]
		public string? DerivativePriceQuoteMethod {get; set;}
		
		[TagDetails(Tag = 1319, Type = TagType.String, Offset = 45, Required = false)]
		public string? DerivativeValuationMethod {get; set;}
		
		[TagDetails(Tag = 1576, Type = TagType.String, Offset = 46, Required = false)]
		public string? DerivativePriceQuoteCurrency {get; set;}
		
		[TagDetails(Tag = 2915, Type = TagType.String, Offset = 47, Required = false)]
		public string? DerivativePriceQuoteCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 1320, Type = TagType.Int, Offset = 48, Required = false)]
		public int? DerivativeListMethod {get; set;}
		
		[TagDetails(Tag = 1321, Type = TagType.Float, Offset = 49, Required = false)]
		public double? DerivativeCapPrice {get; set;}
		
		[TagDetails(Tag = 1322, Type = TagType.Float, Offset = 50, Required = false)]
		public double? DerivativeFloorPrice {get; set;}
		
		[TagDetails(Tag = 1323, Type = TagType.Int, Offset = 51, Required = false)]
		public int? DerivativePutOrCall {get; set;}
		
		[TagDetails(Tag = 2684, Type = TagType.Int, Offset = 52, Required = false)]
		public int? DerivativeInTheMoneyCondition {get; set;}
		
		[TagDetails(Tag = 2688, Type = TagType.Boolean, Offset = 53, Required = false)]
		public bool? DerivativeContraryInstructionEligibilityIndicator {get; set;}
		
		[TagDetails(Tag = 1299, Type = TagType.Int, Offset = 54, Required = false)]
		public int? DerivativeExerciseStyle {get; set;}
		
		[TagDetails(Tag = 1225, Type = TagType.Float, Offset = 55, Required = false)]
		public double? DerivativeOptPayAmount {get; set;}
		
		[TagDetails(Tag = 1271, Type = TagType.String, Offset = 56, Required = false)]
		public string? DerivativeTimeUnit {get; set;}
		
		[TagDetails(Tag = 1272, Type = TagType.String, Offset = 57, Required = false)]
		public string? DerivativeSecurityExchange {get; set;}
		
		[TagDetails(Tag = 1273, Type = TagType.Int, Offset = 58, Required = false)]
		public int? DerivativePositionLimit {get; set;}
		
		[TagDetails(Tag = 1274, Type = TagType.Int, Offset = 59, Required = false)]
		public int? DerivativeNTPositionLimit {get; set;}
		
		[TagDetails(Tag = 1275, Type = TagType.String, Offset = 60, Required = false)]
		public string? DerivativeIssuer {get; set;}
		
		[TagDetails(Tag = 1277, Type = TagType.Length, Offset = 61, Required = false)]
		public int? DerivativeEncodedIssuerLen {get; set;}
		
		[TagDetails(Tag = 1278, Type = TagType.RawData, Offset = 62, Required = false)]
		public byte[]? DerivativeEncodedIssuer {get; set;}
		
		[TagDetails(Tag = 1279, Type = TagType.String, Offset = 63, Required = false)]
		public string? DerivativeSecurityDesc {get; set;}
		
		[TagDetails(Tag = 1280, Type = TagType.Length, Offset = 64, Required = false)]
		public int? DerivativeEncodedSecurityDescLen {get; set;}
		
		[TagDetails(Tag = 1281, Type = TagType.RawData, Offset = 65, Required = false)]
		public byte[]? DerivativeEncodedSecurityDesc {get; set;}
		
		[Component(Offset = 66, Required = false)]
		public DerivativeSecurityXML? DerivativeSecurityXML {get; set;}
		
		[TagDetails(Tag = 1285, Type = TagType.MonthYear, Offset = 67, Required = false)]
		public MonthYear? DerivativeContractSettlMonth {get; set;}
		
		[Component(Offset = 68, Required = false)]
		public DerivativeEventsGrp? DerivativeEventsGrp {get; set;}
		
		[Component(Offset = 69, Required = false)]
		public DerivativeInstrumentParties? DerivativeInstrumentParties {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeSymbol is not null) writer.WriteString(1214, DerivativeSymbol);
			if (DerivativeSymbolSfx is not null) writer.WriteString(1215, DerivativeSymbolSfx);
			if (DerivativeSecurityID is not null) writer.WriteString(1216, DerivativeSecurityID);
			if (DerivativeSecurityIDSource is not null) writer.WriteString(1217, DerivativeSecurityIDSource);
			if (DerivativeSecurityAltIDGrp is not null) ((IFixEncoder)DerivativeSecurityAltIDGrp).Encode(writer);
			if (DerivativeProduct is not null) writer.WriteWholeNumber(1246, DerivativeProduct.Value);
			if (DerivativeProductComplex is not null) writer.WriteString(1228, DerivativeProductComplex);
			if (DerivFlexProductEligibilityIndicator is not null) writer.WriteBoolean(1243, DerivFlexProductEligibilityIndicator.Value);
			if (DerivativeSecurityGroup is not null) writer.WriteString(1247, DerivativeSecurityGroup);
			if (DerivativeCFICode is not null) writer.WriteString(1248, DerivativeCFICode);
			if (DerivativeUPICode is not null) writer.WriteString(2892, DerivativeUPICode);
			if (DerivativeSecurityType is not null) writer.WriteString(1249, DerivativeSecurityType);
			if (DerivativeSecuritySubType is not null) writer.WriteString(1250, DerivativeSecuritySubType);
			if (DerivativeMaturityMonthYear is not null) writer.WriteMonthYear(1251, DerivativeMaturityMonthYear.Value);
			if (DerivativeMaturityDate is not null) writer.WriteLocalDateOnly(1252, DerivativeMaturityDate.Value);
			if (DerivativeMaturityTime is not null) writer.WriteString(1253, DerivativeMaturityTime);
			if (DerivativeSettleOnOpenFlag is not null) writer.WriteString(1254, DerivativeSettleOnOpenFlag);
			if (DerivativeInstrmtAssignmentMethod is not null) writer.WriteString(1255, DerivativeInstrmtAssignmentMethod);
			if (DerivativeSecurityStatus is not null) writer.WriteString(1256, DerivativeSecurityStatus);
			if (DerivativeIssueDate is not null) writer.WriteLocalDateOnly(1276, DerivativeIssueDate.Value);
			if (DerivativeInstrRegistry is not null) writer.WriteString(1257, DerivativeInstrRegistry);
			if (DerivativeCountryOfIssue is not null) writer.WriteString(1258, DerivativeCountryOfIssue);
			if (DerivativeStateOrProvinceOfIssue is not null) writer.WriteString(1259, DerivativeStateOrProvinceOfIssue);
			if (DerivativeLocaleOfIssue is not null) writer.WriteString(1260, DerivativeLocaleOfIssue);
			if (DerivativeStrikePrice is not null) writer.WriteNumber(1261, DerivativeStrikePrice.Value);
			if (DerivativeStrikeCurrency is not null) writer.WriteString(1262, DerivativeStrikeCurrency);
			if (DerivativeStrikeCurrencyCodeSource is not null) writer.WriteString(2912, DerivativeStrikeCurrencyCodeSource);
			if (DerivativeStrikeMultiplier is not null) writer.WriteNumber(1263, DerivativeStrikeMultiplier.Value);
			if (DerivativeStrikeValue is not null) writer.WriteNumber(1264, DerivativeStrikeValue.Value);
			if (DerivativeOptAttribute is not null) writer.WriteString(1265, DerivativeOptAttribute);
			if (DerivativeContractMultiplier is not null) writer.WriteNumber(1266, DerivativeContractMultiplier.Value);
			if (DerivativeContractMultiplierUnit is not null) writer.WriteWholeNumber(1438, DerivativeContractMultiplierUnit.Value);
			if (DerivativeFlowScheduleType is not null) writer.WriteWholeNumber(1442, DerivativeFlowScheduleType.Value);
			if (DerivativeMinPriceIncrement is not null) writer.WriteNumber(1267, DerivativeMinPriceIncrement.Value);
			if (DerivativeMinPriceIncrementAmount is not null) writer.WriteNumber(1268, DerivativeMinPriceIncrementAmount.Value);
			if (DerivativeUnitOfMeasure is not null) writer.WriteString(1269, DerivativeUnitOfMeasure);
			if (DerivativeUnitOfMeasureQty is not null) writer.WriteNumber(1270, DerivativeUnitOfMeasureQty.Value);
			if (DerivativeUnitOfMeasureCurrency is not null) writer.WriteString(1722, DerivativeUnitOfMeasureCurrency);
			if (DerivativeUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2913, DerivativeUnitOfMeasureCurrencyCodeSource);
			if (DerivativePriceUnitOfMeasure is not null) writer.WriteString(1315, DerivativePriceUnitOfMeasure);
			if (DerivativePriceUnitOfMeasureQty is not null) writer.WriteNumber(1316, DerivativePriceUnitOfMeasureQty.Value);
			if (DerivativePriceUnitOfMeasureCurrency is not null) writer.WriteString(1723, DerivativePriceUnitOfMeasureCurrency);
			if (DerivativePriceUnitOfMeasureCurrencyCodeSource is not null) writer.WriteString(2914, DerivativePriceUnitOfMeasureCurrencyCodeSource);
			if (DerivativeSettlMethod is not null) writer.WriteString(1317, DerivativeSettlMethod);
			if (DerivativePriceQuoteMethod is not null) writer.WriteString(1318, DerivativePriceQuoteMethod);
			if (DerivativeValuationMethod is not null) writer.WriteString(1319, DerivativeValuationMethod);
			if (DerivativePriceQuoteCurrency is not null) writer.WriteString(1576, DerivativePriceQuoteCurrency);
			if (DerivativePriceQuoteCurrencyCodeSource is not null) writer.WriteString(2915, DerivativePriceQuoteCurrencyCodeSource);
			if (DerivativeListMethod is not null) writer.WriteWholeNumber(1320, DerivativeListMethod.Value);
			if (DerivativeCapPrice is not null) writer.WriteNumber(1321, DerivativeCapPrice.Value);
			if (DerivativeFloorPrice is not null) writer.WriteNumber(1322, DerivativeFloorPrice.Value);
			if (DerivativePutOrCall is not null) writer.WriteWholeNumber(1323, DerivativePutOrCall.Value);
			if (DerivativeInTheMoneyCondition is not null) writer.WriteWholeNumber(2684, DerivativeInTheMoneyCondition.Value);
			if (DerivativeContraryInstructionEligibilityIndicator is not null) writer.WriteBoolean(2688, DerivativeContraryInstructionEligibilityIndicator.Value);
			if (DerivativeExerciseStyle is not null) writer.WriteWholeNumber(1299, DerivativeExerciseStyle.Value);
			if (DerivativeOptPayAmount is not null) writer.WriteNumber(1225, DerivativeOptPayAmount.Value);
			if (DerivativeTimeUnit is not null) writer.WriteString(1271, DerivativeTimeUnit);
			if (DerivativeSecurityExchange is not null) writer.WriteString(1272, DerivativeSecurityExchange);
			if (DerivativePositionLimit is not null) writer.WriteWholeNumber(1273, DerivativePositionLimit.Value);
			if (DerivativeNTPositionLimit is not null) writer.WriteWholeNumber(1274, DerivativeNTPositionLimit.Value);
			if (DerivativeIssuer is not null) writer.WriteString(1275, DerivativeIssuer);
			if (DerivativeEncodedIssuerLen is not null) writer.WriteWholeNumber(1277, DerivativeEncodedIssuerLen.Value);
			if (DerivativeEncodedIssuer is not null) writer.WriteBuffer(1278, DerivativeEncodedIssuer);
			if (DerivativeSecurityDesc is not null) writer.WriteString(1279, DerivativeSecurityDesc);
			if (DerivativeEncodedSecurityDescLen is not null) writer.WriteWholeNumber(1280, DerivativeEncodedSecurityDescLen.Value);
			if (DerivativeEncodedSecurityDesc is not null) writer.WriteBuffer(1281, DerivativeEncodedSecurityDesc);
			if (DerivativeSecurityXML is not null) ((IFixEncoder)DerivativeSecurityXML).Encode(writer);
			if (DerivativeContractSettlMonth is not null) writer.WriteMonthYear(1285, DerivativeContractSettlMonth.Value);
			if (DerivativeEventsGrp is not null) ((IFixEncoder)DerivativeEventsGrp).Encode(writer);
			if (DerivativeInstrumentParties is not null) ((IFixEncoder)DerivativeInstrumentParties).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DerivativeSymbol = view.GetString(1214);
			DerivativeSymbolSfx = view.GetString(1215);
			DerivativeSecurityID = view.GetString(1216);
			DerivativeSecurityIDSource = view.GetString(1217);
			if (view.GetView("DerivativeSecurityAltIDGrp") is IMessageView viewDerivativeSecurityAltIDGrp)
			{
				DerivativeSecurityAltIDGrp = new();
				((IFixParser)DerivativeSecurityAltIDGrp).Parse(viewDerivativeSecurityAltIDGrp);
			}
			DerivativeProduct = view.GetInt32(1246);
			DerivativeProductComplex = view.GetString(1228);
			DerivFlexProductEligibilityIndicator = view.GetBool(1243);
			DerivativeSecurityGroup = view.GetString(1247);
			DerivativeCFICode = view.GetString(1248);
			DerivativeUPICode = view.GetString(2892);
			DerivativeSecurityType = view.GetString(1249);
			DerivativeSecuritySubType = view.GetString(1250);
			DerivativeMaturityMonthYear = view.GetMonthYear(1251);
			DerivativeMaturityDate = view.GetDateOnly(1252);
			DerivativeMaturityTime = view.GetString(1253);
			DerivativeSettleOnOpenFlag = view.GetString(1254);
			DerivativeInstrmtAssignmentMethod = view.GetString(1255);
			DerivativeSecurityStatus = view.GetString(1256);
			DerivativeIssueDate = view.GetDateOnly(1276);
			DerivativeInstrRegistry = view.GetString(1257);
			DerivativeCountryOfIssue = view.GetString(1258);
			DerivativeStateOrProvinceOfIssue = view.GetString(1259);
			DerivativeLocaleOfIssue = view.GetString(1260);
			DerivativeStrikePrice = view.GetDouble(1261);
			DerivativeStrikeCurrency = view.GetString(1262);
			DerivativeStrikeCurrencyCodeSource = view.GetString(2912);
			DerivativeStrikeMultiplier = view.GetDouble(1263);
			DerivativeStrikeValue = view.GetDouble(1264);
			DerivativeOptAttribute = view.GetString(1265);
			DerivativeContractMultiplier = view.GetDouble(1266);
			DerivativeContractMultiplierUnit = view.GetInt32(1438);
			DerivativeFlowScheduleType = view.GetInt32(1442);
			DerivativeMinPriceIncrement = view.GetDouble(1267);
			DerivativeMinPriceIncrementAmount = view.GetDouble(1268);
			DerivativeUnitOfMeasure = view.GetString(1269);
			DerivativeUnitOfMeasureQty = view.GetDouble(1270);
			DerivativeUnitOfMeasureCurrency = view.GetString(1722);
			DerivativeUnitOfMeasureCurrencyCodeSource = view.GetString(2913);
			DerivativePriceUnitOfMeasure = view.GetString(1315);
			DerivativePriceUnitOfMeasureQty = view.GetDouble(1316);
			DerivativePriceUnitOfMeasureCurrency = view.GetString(1723);
			DerivativePriceUnitOfMeasureCurrencyCodeSource = view.GetString(2914);
			DerivativeSettlMethod = view.GetString(1317);
			DerivativePriceQuoteMethod = view.GetString(1318);
			DerivativeValuationMethod = view.GetString(1319);
			DerivativePriceQuoteCurrency = view.GetString(1576);
			DerivativePriceQuoteCurrencyCodeSource = view.GetString(2915);
			DerivativeListMethod = view.GetInt32(1320);
			DerivativeCapPrice = view.GetDouble(1321);
			DerivativeFloorPrice = view.GetDouble(1322);
			DerivativePutOrCall = view.GetInt32(1323);
			DerivativeInTheMoneyCondition = view.GetInt32(2684);
			DerivativeContraryInstructionEligibilityIndicator = view.GetBool(2688);
			DerivativeExerciseStyle = view.GetInt32(1299);
			DerivativeOptPayAmount = view.GetDouble(1225);
			DerivativeTimeUnit = view.GetString(1271);
			DerivativeSecurityExchange = view.GetString(1272);
			DerivativePositionLimit = view.GetInt32(1273);
			DerivativeNTPositionLimit = view.GetInt32(1274);
			DerivativeIssuer = view.GetString(1275);
			DerivativeEncodedIssuerLen = view.GetInt32(1277);
			DerivativeEncodedIssuer = view.GetByteArray(1278);
			DerivativeSecurityDesc = view.GetString(1279);
			DerivativeEncodedSecurityDescLen = view.GetInt32(1280);
			DerivativeEncodedSecurityDesc = view.GetByteArray(1281);
			if (view.GetView("DerivativeSecurityXML") is IMessageView viewDerivativeSecurityXML)
			{
				DerivativeSecurityXML = new();
				((IFixParser)DerivativeSecurityXML).Parse(viewDerivativeSecurityXML);
			}
			DerivativeContractSettlMonth = view.GetMonthYear(1285);
			if (view.GetView("DerivativeEventsGrp") is IMessageView viewDerivativeEventsGrp)
			{
				DerivativeEventsGrp = new();
				((IFixParser)DerivativeEventsGrp).Parse(viewDerivativeEventsGrp);
			}
			if (view.GetView("DerivativeInstrumentParties") is IMessageView viewDerivativeInstrumentParties)
			{
				DerivativeInstrumentParties = new();
				((IFixParser)DerivativeInstrumentParties).Parse(viewDerivativeInstrumentParties);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DerivativeSymbol":
				{
					value = DerivativeSymbol;
					break;
				}
				case "DerivativeSymbolSfx":
				{
					value = DerivativeSymbolSfx;
					break;
				}
				case "DerivativeSecurityID":
				{
					value = DerivativeSecurityID;
					break;
				}
				case "DerivativeSecurityIDSource":
				{
					value = DerivativeSecurityIDSource;
					break;
				}
				case "DerivativeSecurityAltIDGrp":
				{
					value = DerivativeSecurityAltIDGrp;
					break;
				}
				case "DerivativeProduct":
				{
					value = DerivativeProduct;
					break;
				}
				case "DerivativeProductComplex":
				{
					value = DerivativeProductComplex;
					break;
				}
				case "DerivFlexProductEligibilityIndicator":
				{
					value = DerivFlexProductEligibilityIndicator;
					break;
				}
				case "DerivativeSecurityGroup":
				{
					value = DerivativeSecurityGroup;
					break;
				}
				case "DerivativeCFICode":
				{
					value = DerivativeCFICode;
					break;
				}
				case "DerivativeUPICode":
				{
					value = DerivativeUPICode;
					break;
				}
				case "DerivativeSecurityType":
				{
					value = DerivativeSecurityType;
					break;
				}
				case "DerivativeSecuritySubType":
				{
					value = DerivativeSecuritySubType;
					break;
				}
				case "DerivativeMaturityMonthYear":
				{
					value = DerivativeMaturityMonthYear;
					break;
				}
				case "DerivativeMaturityDate":
				{
					value = DerivativeMaturityDate;
					break;
				}
				case "DerivativeMaturityTime":
				{
					value = DerivativeMaturityTime;
					break;
				}
				case "DerivativeSettleOnOpenFlag":
				{
					value = DerivativeSettleOnOpenFlag;
					break;
				}
				case "DerivativeInstrmtAssignmentMethod":
				{
					value = DerivativeInstrmtAssignmentMethod;
					break;
				}
				case "DerivativeSecurityStatus":
				{
					value = DerivativeSecurityStatus;
					break;
				}
				case "DerivativeIssueDate":
				{
					value = DerivativeIssueDate;
					break;
				}
				case "DerivativeInstrRegistry":
				{
					value = DerivativeInstrRegistry;
					break;
				}
				case "DerivativeCountryOfIssue":
				{
					value = DerivativeCountryOfIssue;
					break;
				}
				case "DerivativeStateOrProvinceOfIssue":
				{
					value = DerivativeStateOrProvinceOfIssue;
					break;
				}
				case "DerivativeLocaleOfIssue":
				{
					value = DerivativeLocaleOfIssue;
					break;
				}
				case "DerivativeStrikePrice":
				{
					value = DerivativeStrikePrice;
					break;
				}
				case "DerivativeStrikeCurrency":
				{
					value = DerivativeStrikeCurrency;
					break;
				}
				case "DerivativeStrikeCurrencyCodeSource":
				{
					value = DerivativeStrikeCurrencyCodeSource;
					break;
				}
				case "DerivativeStrikeMultiplier":
				{
					value = DerivativeStrikeMultiplier;
					break;
				}
				case "DerivativeStrikeValue":
				{
					value = DerivativeStrikeValue;
					break;
				}
				case "DerivativeOptAttribute":
				{
					value = DerivativeOptAttribute;
					break;
				}
				case "DerivativeContractMultiplier":
				{
					value = DerivativeContractMultiplier;
					break;
				}
				case "DerivativeContractMultiplierUnit":
				{
					value = DerivativeContractMultiplierUnit;
					break;
				}
				case "DerivativeFlowScheduleType":
				{
					value = DerivativeFlowScheduleType;
					break;
				}
				case "DerivativeMinPriceIncrement":
				{
					value = DerivativeMinPriceIncrement;
					break;
				}
				case "DerivativeMinPriceIncrementAmount":
				{
					value = DerivativeMinPriceIncrementAmount;
					break;
				}
				case "DerivativeUnitOfMeasure":
				{
					value = DerivativeUnitOfMeasure;
					break;
				}
				case "DerivativeUnitOfMeasureQty":
				{
					value = DerivativeUnitOfMeasureQty;
					break;
				}
				case "DerivativeUnitOfMeasureCurrency":
				{
					value = DerivativeUnitOfMeasureCurrency;
					break;
				}
				case "DerivativeUnitOfMeasureCurrencyCodeSource":
				{
					value = DerivativeUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "DerivativePriceUnitOfMeasure":
				{
					value = DerivativePriceUnitOfMeasure;
					break;
				}
				case "DerivativePriceUnitOfMeasureQty":
				{
					value = DerivativePriceUnitOfMeasureQty;
					break;
				}
				case "DerivativePriceUnitOfMeasureCurrency":
				{
					value = DerivativePriceUnitOfMeasureCurrency;
					break;
				}
				case "DerivativePriceUnitOfMeasureCurrencyCodeSource":
				{
					value = DerivativePriceUnitOfMeasureCurrencyCodeSource;
					break;
				}
				case "DerivativeSettlMethod":
				{
					value = DerivativeSettlMethod;
					break;
				}
				case "DerivativePriceQuoteMethod":
				{
					value = DerivativePriceQuoteMethod;
					break;
				}
				case "DerivativeValuationMethod":
				{
					value = DerivativeValuationMethod;
					break;
				}
				case "DerivativePriceQuoteCurrency":
				{
					value = DerivativePriceQuoteCurrency;
					break;
				}
				case "DerivativePriceQuoteCurrencyCodeSource":
				{
					value = DerivativePriceQuoteCurrencyCodeSource;
					break;
				}
				case "DerivativeListMethod":
				{
					value = DerivativeListMethod;
					break;
				}
				case "DerivativeCapPrice":
				{
					value = DerivativeCapPrice;
					break;
				}
				case "DerivativeFloorPrice":
				{
					value = DerivativeFloorPrice;
					break;
				}
				case "DerivativePutOrCall":
				{
					value = DerivativePutOrCall;
					break;
				}
				case "DerivativeInTheMoneyCondition":
				{
					value = DerivativeInTheMoneyCondition;
					break;
				}
				case "DerivativeContraryInstructionEligibilityIndicator":
				{
					value = DerivativeContraryInstructionEligibilityIndicator;
					break;
				}
				case "DerivativeExerciseStyle":
				{
					value = DerivativeExerciseStyle;
					break;
				}
				case "DerivativeOptPayAmount":
				{
					value = DerivativeOptPayAmount;
					break;
				}
				case "DerivativeTimeUnit":
				{
					value = DerivativeTimeUnit;
					break;
				}
				case "DerivativeSecurityExchange":
				{
					value = DerivativeSecurityExchange;
					break;
				}
				case "DerivativePositionLimit":
				{
					value = DerivativePositionLimit;
					break;
				}
				case "DerivativeNTPositionLimit":
				{
					value = DerivativeNTPositionLimit;
					break;
				}
				case "DerivativeIssuer":
				{
					value = DerivativeIssuer;
					break;
				}
				case "DerivativeEncodedIssuerLen":
				{
					value = DerivativeEncodedIssuerLen;
					break;
				}
				case "DerivativeEncodedIssuer":
				{
					value = DerivativeEncodedIssuer;
					break;
				}
				case "DerivativeSecurityDesc":
				{
					value = DerivativeSecurityDesc;
					break;
				}
				case "DerivativeEncodedSecurityDescLen":
				{
					value = DerivativeEncodedSecurityDescLen;
					break;
				}
				case "DerivativeEncodedSecurityDesc":
				{
					value = DerivativeEncodedSecurityDesc;
					break;
				}
				case "DerivativeSecurityXML":
				{
					value = DerivativeSecurityXML;
					break;
				}
				case "DerivativeContractSettlMonth":
				{
					value = DerivativeContractSettlMonth;
					break;
				}
				case "DerivativeEventsGrp":
				{
					value = DerivativeEventsGrp;
					break;
				}
				case "DerivativeInstrumentParties":
				{
					value = DerivativeInstrumentParties;
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
			DerivativeSymbol = null;
			DerivativeSymbolSfx = null;
			DerivativeSecurityID = null;
			DerivativeSecurityIDSource = null;
			((IFixReset?)DerivativeSecurityAltIDGrp)?.Reset();
			DerivativeProduct = null;
			DerivativeProductComplex = null;
			DerivFlexProductEligibilityIndicator = null;
			DerivativeSecurityGroup = null;
			DerivativeCFICode = null;
			DerivativeUPICode = null;
			DerivativeSecurityType = null;
			DerivativeSecuritySubType = null;
			DerivativeMaturityMonthYear = null;
			DerivativeMaturityDate = null;
			DerivativeMaturityTime = null;
			DerivativeSettleOnOpenFlag = null;
			DerivativeInstrmtAssignmentMethod = null;
			DerivativeSecurityStatus = null;
			DerivativeIssueDate = null;
			DerivativeInstrRegistry = null;
			DerivativeCountryOfIssue = null;
			DerivativeStateOrProvinceOfIssue = null;
			DerivativeLocaleOfIssue = null;
			DerivativeStrikePrice = null;
			DerivativeStrikeCurrency = null;
			DerivativeStrikeCurrencyCodeSource = null;
			DerivativeStrikeMultiplier = null;
			DerivativeStrikeValue = null;
			DerivativeOptAttribute = null;
			DerivativeContractMultiplier = null;
			DerivativeContractMultiplierUnit = null;
			DerivativeFlowScheduleType = null;
			DerivativeMinPriceIncrement = null;
			DerivativeMinPriceIncrementAmount = null;
			DerivativeUnitOfMeasure = null;
			DerivativeUnitOfMeasureQty = null;
			DerivativeUnitOfMeasureCurrency = null;
			DerivativeUnitOfMeasureCurrencyCodeSource = null;
			DerivativePriceUnitOfMeasure = null;
			DerivativePriceUnitOfMeasureQty = null;
			DerivativePriceUnitOfMeasureCurrency = null;
			DerivativePriceUnitOfMeasureCurrencyCodeSource = null;
			DerivativeSettlMethod = null;
			DerivativePriceQuoteMethod = null;
			DerivativeValuationMethod = null;
			DerivativePriceQuoteCurrency = null;
			DerivativePriceQuoteCurrencyCodeSource = null;
			DerivativeListMethod = null;
			DerivativeCapPrice = null;
			DerivativeFloorPrice = null;
			DerivativePutOrCall = null;
			DerivativeInTheMoneyCondition = null;
			DerivativeContraryInstructionEligibilityIndicator = null;
			DerivativeExerciseStyle = null;
			DerivativeOptPayAmount = null;
			DerivativeTimeUnit = null;
			DerivativeSecurityExchange = null;
			DerivativePositionLimit = null;
			DerivativeNTPositionLimit = null;
			DerivativeIssuer = null;
			DerivativeEncodedIssuerLen = null;
			DerivativeEncodedIssuer = null;
			DerivativeSecurityDesc = null;
			DerivativeEncodedSecurityDescLen = null;
			DerivativeEncodedSecurityDesc = null;
			((IFixReset?)DerivativeSecurityXML)?.Reset();
			DerivativeContractSettlMonth = null;
			((IFixReset?)DerivativeEventsGrp)?.Reset();
			((IFixReset?)DerivativeInstrumentParties)?.Reset();
		}
	}
}
