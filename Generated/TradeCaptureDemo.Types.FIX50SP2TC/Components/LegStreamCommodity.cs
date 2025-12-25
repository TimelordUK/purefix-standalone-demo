using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommodity : IFixComponent
	{
		[TagDetails(Tag = 41648, Type = TagType.String, Offset = 0, Required = false)]
		public string? LegStreamCommodityBase {get; set;}
		
		[TagDetails(Tag = 41649, Type = TagType.String, Offset = 1, Required = false)]
		public string? LegStreamCommodityType {get; set;}
		
		[TagDetails(Tag = 41650, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegStreamCommoditySecurityID {get; set;}
		
		[TagDetails(Tag = 41651, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegStreamCommoditySecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public LegStreamCommodityAltIDGrp? LegStreamCommodityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 41652, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegStreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 41653, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedLegStreamCommodityDescLen {get; set;}
		
		[TagDetails(Tag = 41654, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedLegStreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 42588, Type = TagType.String, Offset = 8, Required = false)]
		public string? LegStreamCommodityDeliveryPricingRegion {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public LegStreamAssetAttributeGrp? LegStreamAssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 41655, Type = TagType.String, Offset = 10, Required = false)]
		public string? LegStreamCommodityUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41656, Type = TagType.String, Offset = 11, Required = false)]
		public string? LegStreamCommodityCurrency {get; set;}
		
		[TagDetails(Tag = 41657, Type = TagType.String, Offset = 12, Required = false)]
		public string? LegStreamCommodityExchange {get; set;}
		
		[TagDetails(Tag = 41658, Type = TagType.Int, Offset = 13, Required = false)]
		public int? LegStreamCommodityRateSource {get; set;}
		
		[TagDetails(Tag = 41659, Type = TagType.String, Offset = 14, Required = false)]
		public string? LegStreamCommodityRateReferencePage {get; set;}
		
		[TagDetails(Tag = 41660, Type = TagType.String, Offset = 15, Required = false)]
		public string? LegStreamCommodityRateReferencePageHeading {get; set;}
		
		[TagDetails(Tag = 41661, Type = TagType.String, Offset = 16, Required = false)]
		public string? LegStreamDataProvider {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public LegStreamCommodityDataSourceGrp? LegStreamCommodityDataSourceGrp {get; set;}
		
		[TagDetails(Tag = 41662, Type = TagType.String, Offset = 18, Required = false)]
		public string? LegStreamCommodityPricingType {get; set;}
		
		[TagDetails(Tag = 41663, Type = TagType.Int, Offset = 19, Required = false)]
		public int? LegStreamCommodityNearbySettlDayPeriod {get; set;}
		
		[TagDetails(Tag = 41664, Type = TagType.String, Offset = 20, Required = false)]
		public string? LegStreamCommodityNearbySettlDayUnit {get; set;}
		
		[TagDetails(Tag = 41665, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? LegStreamCommoditySettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41666, Type = TagType.Int, Offset = 22, Required = false)]
		public int? LegStreamCommoditySettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public LegStreamCommoditySettlBusinessCenterGrp? LegStreamCommoditySettlBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41667, Type = TagType.LocalDate, Offset = 24, Required = false)]
		public DateOnly? LegStreamCommoditySettlDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41668, Type = TagType.Int, Offset = 25, Required = false)]
		public int? LegStreamCommoditySettlMonth {get; set;}
		
		[TagDetails(Tag = 41669, Type = TagType.Int, Offset = 26, Required = false)]
		public int? LegStreamCommoditySettlDateRollPeriod {get; set;}
		
		[TagDetails(Tag = 41670, Type = TagType.String, Offset = 27, Required = false)]
		public string? LegStreamCommoditySettlDateRollUnit {get; set;}
		
		[TagDetails(Tag = 41671, Type = TagType.Int, Offset = 28, Required = false)]
		public int? LegStreamCommoditySettlDayType {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public LegStreamCommoditySettlPeriodGrp? LegStreamCommoditySettlPeriodGrp {get; set;}
		
		[TagDetails(Tag = 41672, Type = TagType.String, Offset = 30, Required = false)]
		public string? LegStreamCommodityXID {get; set;}
		
		[TagDetails(Tag = 41673, Type = TagType.String, Offset = 31, Required = false)]
		public string? LegStreamCommodityXIDRef {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommodityBase is not null) writer.WriteString(41648, LegStreamCommodityBase);
			if (LegStreamCommodityType is not null) writer.WriteString(41649, LegStreamCommodityType);
			if (LegStreamCommoditySecurityID is not null) writer.WriteString(41650, LegStreamCommoditySecurityID);
			if (LegStreamCommoditySecurityIDSource is not null) writer.WriteString(41651, LegStreamCommoditySecurityIDSource);
			if (LegStreamCommodityAltIDGrp is not null) ((IFixEncoder)LegStreamCommodityAltIDGrp).Encode(writer);
			if (LegStreamCommodityDesc is not null) writer.WriteString(41652, LegStreamCommodityDesc);
			if (EncodedLegStreamCommodityDescLen is not null) writer.WriteWholeNumber(41653, EncodedLegStreamCommodityDescLen.Value);
			if (EncodedLegStreamCommodityDesc is not null) writer.WriteBuffer(41654, EncodedLegStreamCommodityDesc);
			if (LegStreamCommodityDeliveryPricingRegion is not null) writer.WriteString(42588, LegStreamCommodityDeliveryPricingRegion);
			if (LegStreamAssetAttributeGrp is not null) ((IFixEncoder)LegStreamAssetAttributeGrp).Encode(writer);
			if (LegStreamCommodityUnitOfMeasure is not null) writer.WriteString(41655, LegStreamCommodityUnitOfMeasure);
			if (LegStreamCommodityCurrency is not null) writer.WriteString(41656, LegStreamCommodityCurrency);
			if (LegStreamCommodityExchange is not null) writer.WriteString(41657, LegStreamCommodityExchange);
			if (LegStreamCommodityRateSource is not null) writer.WriteWholeNumber(41658, LegStreamCommodityRateSource.Value);
			if (LegStreamCommodityRateReferencePage is not null) writer.WriteString(41659, LegStreamCommodityRateReferencePage);
			if (LegStreamCommodityRateReferencePageHeading is not null) writer.WriteString(41660, LegStreamCommodityRateReferencePageHeading);
			if (LegStreamDataProvider is not null) writer.WriteString(41661, LegStreamDataProvider);
			if (LegStreamCommodityDataSourceGrp is not null) ((IFixEncoder)LegStreamCommodityDataSourceGrp).Encode(writer);
			if (LegStreamCommodityPricingType is not null) writer.WriteString(41662, LegStreamCommodityPricingType);
			if (LegStreamCommodityNearbySettlDayPeriod is not null) writer.WriteWholeNumber(41663, LegStreamCommodityNearbySettlDayPeriod.Value);
			if (LegStreamCommodityNearbySettlDayUnit is not null) writer.WriteString(41664, LegStreamCommodityNearbySettlDayUnit);
			if (LegStreamCommoditySettlDateUnadjusted is not null) writer.WriteLocalDateOnly(41665, LegStreamCommoditySettlDateUnadjusted.Value);
			if (LegStreamCommoditySettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(41666, LegStreamCommoditySettlDateBusinessDayConvention.Value);
			if (LegStreamCommoditySettlBusinessCenterGrp is not null) ((IFixEncoder)LegStreamCommoditySettlBusinessCenterGrp).Encode(writer);
			if (LegStreamCommoditySettlDateAdjusted is not null) writer.WriteLocalDateOnly(41667, LegStreamCommoditySettlDateAdjusted.Value);
			if (LegStreamCommoditySettlMonth is not null) writer.WriteWholeNumber(41668, LegStreamCommoditySettlMonth.Value);
			if (LegStreamCommoditySettlDateRollPeriod is not null) writer.WriteWholeNumber(41669, LegStreamCommoditySettlDateRollPeriod.Value);
			if (LegStreamCommoditySettlDateRollUnit is not null) writer.WriteString(41670, LegStreamCommoditySettlDateRollUnit);
			if (LegStreamCommoditySettlDayType is not null) writer.WriteWholeNumber(41671, LegStreamCommoditySettlDayType.Value);
			if (LegStreamCommoditySettlPeriodGrp is not null) ((IFixEncoder)LegStreamCommoditySettlPeriodGrp).Encode(writer);
			if (LegStreamCommodityXID is not null) writer.WriteString(41672, LegStreamCommodityXID);
			if (LegStreamCommodityXIDRef is not null) writer.WriteString(41673, LegStreamCommodityXIDRef);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegStreamCommodityBase = view.GetString(41648);
			LegStreamCommodityType = view.GetString(41649);
			LegStreamCommoditySecurityID = view.GetString(41650);
			LegStreamCommoditySecurityIDSource = view.GetString(41651);
			if (view.GetView("LegStreamCommodityAltIDGrp") is IMessageView viewLegStreamCommodityAltIDGrp)
			{
				LegStreamCommodityAltIDGrp = new();
				((IFixParser)LegStreamCommodityAltIDGrp).Parse(viewLegStreamCommodityAltIDGrp);
			}
			LegStreamCommodityDesc = view.GetString(41652);
			EncodedLegStreamCommodityDescLen = view.GetInt32(41653);
			EncodedLegStreamCommodityDesc = view.GetByteArray(41654);
			LegStreamCommodityDeliveryPricingRegion = view.GetString(42588);
			if (view.GetView("LegStreamAssetAttributeGrp") is IMessageView viewLegStreamAssetAttributeGrp)
			{
				LegStreamAssetAttributeGrp = new();
				((IFixParser)LegStreamAssetAttributeGrp).Parse(viewLegStreamAssetAttributeGrp);
			}
			LegStreamCommodityUnitOfMeasure = view.GetString(41655);
			LegStreamCommodityCurrency = view.GetString(41656);
			LegStreamCommodityExchange = view.GetString(41657);
			LegStreamCommodityRateSource = view.GetInt32(41658);
			LegStreamCommodityRateReferencePage = view.GetString(41659);
			LegStreamCommodityRateReferencePageHeading = view.GetString(41660);
			LegStreamDataProvider = view.GetString(41661);
			if (view.GetView("LegStreamCommodityDataSourceGrp") is IMessageView viewLegStreamCommodityDataSourceGrp)
			{
				LegStreamCommodityDataSourceGrp = new();
				((IFixParser)LegStreamCommodityDataSourceGrp).Parse(viewLegStreamCommodityDataSourceGrp);
			}
			LegStreamCommodityPricingType = view.GetString(41662);
			LegStreamCommodityNearbySettlDayPeriod = view.GetInt32(41663);
			LegStreamCommodityNearbySettlDayUnit = view.GetString(41664);
			LegStreamCommoditySettlDateUnadjusted = view.GetDateOnly(41665);
			LegStreamCommoditySettlDateBusinessDayConvention = view.GetInt32(41666);
			if (view.GetView("LegStreamCommoditySettlBusinessCenterGrp") is IMessageView viewLegStreamCommoditySettlBusinessCenterGrp)
			{
				LegStreamCommoditySettlBusinessCenterGrp = new();
				((IFixParser)LegStreamCommoditySettlBusinessCenterGrp).Parse(viewLegStreamCommoditySettlBusinessCenterGrp);
			}
			LegStreamCommoditySettlDateAdjusted = view.GetDateOnly(41667);
			LegStreamCommoditySettlMonth = view.GetInt32(41668);
			LegStreamCommoditySettlDateRollPeriod = view.GetInt32(41669);
			LegStreamCommoditySettlDateRollUnit = view.GetString(41670);
			LegStreamCommoditySettlDayType = view.GetInt32(41671);
			if (view.GetView("LegStreamCommoditySettlPeriodGrp") is IMessageView viewLegStreamCommoditySettlPeriodGrp)
			{
				LegStreamCommoditySettlPeriodGrp = new();
				((IFixParser)LegStreamCommoditySettlPeriodGrp).Parse(viewLegStreamCommoditySettlPeriodGrp);
			}
			LegStreamCommodityXID = view.GetString(41672);
			LegStreamCommodityXIDRef = view.GetString(41673);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegStreamCommodityBase":
				{
					value = LegStreamCommodityBase;
					break;
				}
				case "LegStreamCommodityType":
				{
					value = LegStreamCommodityType;
					break;
				}
				case "LegStreamCommoditySecurityID":
				{
					value = LegStreamCommoditySecurityID;
					break;
				}
				case "LegStreamCommoditySecurityIDSource":
				{
					value = LegStreamCommoditySecurityIDSource;
					break;
				}
				case "LegStreamCommodityAltIDGrp":
				{
					value = LegStreamCommodityAltIDGrp;
					break;
				}
				case "LegStreamCommodityDesc":
				{
					value = LegStreamCommodityDesc;
					break;
				}
				case "EncodedLegStreamCommodityDescLen":
				{
					value = EncodedLegStreamCommodityDescLen;
					break;
				}
				case "EncodedLegStreamCommodityDesc":
				{
					value = EncodedLegStreamCommodityDesc;
					break;
				}
				case "LegStreamCommodityDeliveryPricingRegion":
				{
					value = LegStreamCommodityDeliveryPricingRegion;
					break;
				}
				case "LegStreamAssetAttributeGrp":
				{
					value = LegStreamAssetAttributeGrp;
					break;
				}
				case "LegStreamCommodityUnitOfMeasure":
				{
					value = LegStreamCommodityUnitOfMeasure;
					break;
				}
				case "LegStreamCommodityCurrency":
				{
					value = LegStreamCommodityCurrency;
					break;
				}
				case "LegStreamCommodityExchange":
				{
					value = LegStreamCommodityExchange;
					break;
				}
				case "LegStreamCommodityRateSource":
				{
					value = LegStreamCommodityRateSource;
					break;
				}
				case "LegStreamCommodityRateReferencePage":
				{
					value = LegStreamCommodityRateReferencePage;
					break;
				}
				case "LegStreamCommodityRateReferencePageHeading":
				{
					value = LegStreamCommodityRateReferencePageHeading;
					break;
				}
				case "LegStreamDataProvider":
				{
					value = LegStreamDataProvider;
					break;
				}
				case "LegStreamCommodityDataSourceGrp":
				{
					value = LegStreamCommodityDataSourceGrp;
					break;
				}
				case "LegStreamCommodityPricingType":
				{
					value = LegStreamCommodityPricingType;
					break;
				}
				case "LegStreamCommodityNearbySettlDayPeriod":
				{
					value = LegStreamCommodityNearbySettlDayPeriod;
					break;
				}
				case "LegStreamCommodityNearbySettlDayUnit":
				{
					value = LegStreamCommodityNearbySettlDayUnit;
					break;
				}
				case "LegStreamCommoditySettlDateUnadjusted":
				{
					value = LegStreamCommoditySettlDateUnadjusted;
					break;
				}
				case "LegStreamCommoditySettlDateBusinessDayConvention":
				{
					value = LegStreamCommoditySettlDateBusinessDayConvention;
					break;
				}
				case "LegStreamCommoditySettlBusinessCenterGrp":
				{
					value = LegStreamCommoditySettlBusinessCenterGrp;
					break;
				}
				case "LegStreamCommoditySettlDateAdjusted":
				{
					value = LegStreamCommoditySettlDateAdjusted;
					break;
				}
				case "LegStreamCommoditySettlMonth":
				{
					value = LegStreamCommoditySettlMonth;
					break;
				}
				case "LegStreamCommoditySettlDateRollPeriod":
				{
					value = LegStreamCommoditySettlDateRollPeriod;
					break;
				}
				case "LegStreamCommoditySettlDateRollUnit":
				{
					value = LegStreamCommoditySettlDateRollUnit;
					break;
				}
				case "LegStreamCommoditySettlDayType":
				{
					value = LegStreamCommoditySettlDayType;
					break;
				}
				case "LegStreamCommoditySettlPeriodGrp":
				{
					value = LegStreamCommoditySettlPeriodGrp;
					break;
				}
				case "LegStreamCommodityXID":
				{
					value = LegStreamCommodityXID;
					break;
				}
				case "LegStreamCommodityXIDRef":
				{
					value = LegStreamCommodityXIDRef;
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
			LegStreamCommodityBase = null;
			LegStreamCommodityType = null;
			LegStreamCommoditySecurityID = null;
			LegStreamCommoditySecurityIDSource = null;
			((IFixReset?)LegStreamCommodityAltIDGrp)?.Reset();
			LegStreamCommodityDesc = null;
			EncodedLegStreamCommodityDescLen = null;
			EncodedLegStreamCommodityDesc = null;
			LegStreamCommodityDeliveryPricingRegion = null;
			((IFixReset?)LegStreamAssetAttributeGrp)?.Reset();
			LegStreamCommodityUnitOfMeasure = null;
			LegStreamCommodityCurrency = null;
			LegStreamCommodityExchange = null;
			LegStreamCommodityRateSource = null;
			LegStreamCommodityRateReferencePage = null;
			LegStreamCommodityRateReferencePageHeading = null;
			LegStreamDataProvider = null;
			((IFixReset?)LegStreamCommodityDataSourceGrp)?.Reset();
			LegStreamCommodityPricingType = null;
			LegStreamCommodityNearbySettlDayPeriod = null;
			LegStreamCommodityNearbySettlDayUnit = null;
			LegStreamCommoditySettlDateUnadjusted = null;
			LegStreamCommoditySettlDateBusinessDayConvention = null;
			((IFixReset?)LegStreamCommoditySettlBusinessCenterGrp)?.Reset();
			LegStreamCommoditySettlDateAdjusted = null;
			LegStreamCommoditySettlMonth = null;
			LegStreamCommoditySettlDateRollPeriod = null;
			LegStreamCommoditySettlDateRollUnit = null;
			LegStreamCommoditySettlDayType = null;
			((IFixReset?)LegStreamCommoditySettlPeriodGrp)?.Reset();
			LegStreamCommodityXID = null;
			LegStreamCommodityXIDRef = null;
		}
	}
}
