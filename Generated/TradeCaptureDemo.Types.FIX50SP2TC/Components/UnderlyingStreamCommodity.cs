using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommodity : IFixComponent
	{
		[TagDetails(Tag = 41964, Type = TagType.String, Offset = 0, Required = false)]
		public string? UnderlyingStreamCommodityBase {get; set;}
		
		[TagDetails(Tag = 41965, Type = TagType.String, Offset = 1, Required = false)]
		public string? UnderlyingStreamCommodityType {get; set;}
		
		[TagDetails(Tag = 41966, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingStreamCommoditySecurityID {get; set;}
		
		[TagDetails(Tag = 41967, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingStreamCommoditySecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public UnderlyingStreamCommodityAltIDGrp? UnderlyingStreamCommodityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 41968, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingStreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 41969, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedUnderlyingStreamCommodityDescLen {get; set;}
		
		[TagDetails(Tag = 41970, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedUnderlyingStreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 42589, Type = TagType.String, Offset = 8, Required = false)]
		public string? UnderlyingStreamCommodityDeliveryPricingRegion {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UnderlyingStreamAssetAttributeGrp? UnderlyingStreamAssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 41971, Type = TagType.String, Offset = 10, Required = false)]
		public string? UnderlyingStreamCommodityUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41972, Type = TagType.String, Offset = 11, Required = false)]
		public string? UnderlyingStreamCommodityCurrency {get; set;}
		
		[TagDetails(Tag = 41973, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingStreamCommodityExchange {get; set;}
		
		[TagDetails(Tag = 41974, Type = TagType.Int, Offset = 13, Required = false)]
		public int? UnderlyingStreamCommodityRateSource {get; set;}
		
		[TagDetails(Tag = 41975, Type = TagType.String, Offset = 14, Required = false)]
		public string? UnderlyingStreamCommodityRateReferencePage {get; set;}
		
		[TagDetails(Tag = 41976, Type = TagType.String, Offset = 15, Required = false)]
		public string? UnderlyingStreamCommodityRateReferencePageHeading {get; set;}
		
		[TagDetails(Tag = 41977, Type = TagType.String, Offset = 16, Required = false)]
		public string? UnderlyingStreamDataProvider {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public UnderlyingStreamCommodityDataSourceGrp? UnderlyingStreamCommodityDataSourceGrp {get; set;}
		
		[TagDetails(Tag = 41978, Type = TagType.String, Offset = 18, Required = false)]
		public string? UnderlyingStreamCommodityPricingType {get; set;}
		
		[TagDetails(Tag = 41979, Type = TagType.Int, Offset = 19, Required = false)]
		public int? UnderlyingStreamCommodityNearbySettlDayPeriod {get; set;}
		
		[TagDetails(Tag = 41980, Type = TagType.String, Offset = 20, Required = false)]
		public string? UnderlyingStreamCommodityNearbySettlDayUnit {get; set;}
		
		[TagDetails(Tag = 41981, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? UnderlyingStreamCommoditySettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41982, Type = TagType.Int, Offset = 22, Required = false)]
		public int? UnderlyingStreamCommoditySettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public UnderlyingStreamCommoditySettlBusinessCenterGrp? UnderlyingStreamCommoditySettlBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41983, Type = TagType.LocalDate, Offset = 24, Required = false)]
		public DateOnly? UnderlyingStreamCommoditySettlDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41984, Type = TagType.Int, Offset = 25, Required = false)]
		public int? UnderlyingStreamCommoditySettlMonth {get; set;}
		
		[TagDetails(Tag = 41985, Type = TagType.Int, Offset = 26, Required = false)]
		public int? UnderlyingStreamCommoditySettlDateRollPeriod {get; set;}
		
		[TagDetails(Tag = 41986, Type = TagType.String, Offset = 27, Required = false)]
		public string? UnderlyingStreamCommoditySettlDateRollUnit {get; set;}
		
		[TagDetails(Tag = 41987, Type = TagType.Int, Offset = 28, Required = false)]
		public int? UnderlyingStreamCommoditySettlDayType {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public UnderlyingStreamCommoditySettlPeriodGrp? UnderlyingStreamCommoditySettlPeriodGrp {get; set;}
		
		[TagDetails(Tag = 41988, Type = TagType.String, Offset = 30, Required = false)]
		public string? UnderlyingStreamCommodityXID {get; set;}
		
		[TagDetails(Tag = 41989, Type = TagType.String, Offset = 31, Required = false)]
		public string? UnderlyingStreamCommodityXIDRef {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommodityBase is not null) writer.WriteString(41964, UnderlyingStreamCommodityBase);
			if (UnderlyingStreamCommodityType is not null) writer.WriteString(41965, UnderlyingStreamCommodityType);
			if (UnderlyingStreamCommoditySecurityID is not null) writer.WriteString(41966, UnderlyingStreamCommoditySecurityID);
			if (UnderlyingStreamCommoditySecurityIDSource is not null) writer.WriteString(41967, UnderlyingStreamCommoditySecurityIDSource);
			if (UnderlyingStreamCommodityAltIDGrp is not null) ((IFixEncoder)UnderlyingStreamCommodityAltIDGrp).Encode(writer);
			if (UnderlyingStreamCommodityDesc is not null) writer.WriteString(41968, UnderlyingStreamCommodityDesc);
			if (EncodedUnderlyingStreamCommodityDescLen is not null) writer.WriteWholeNumber(41969, EncodedUnderlyingStreamCommodityDescLen.Value);
			if (EncodedUnderlyingStreamCommodityDesc is not null) writer.WriteBuffer(41970, EncodedUnderlyingStreamCommodityDesc);
			if (UnderlyingStreamCommodityDeliveryPricingRegion is not null) writer.WriteString(42589, UnderlyingStreamCommodityDeliveryPricingRegion);
			if (UnderlyingStreamAssetAttributeGrp is not null) ((IFixEncoder)UnderlyingStreamAssetAttributeGrp).Encode(writer);
			if (UnderlyingStreamCommodityUnitOfMeasure is not null) writer.WriteString(41971, UnderlyingStreamCommodityUnitOfMeasure);
			if (UnderlyingStreamCommodityCurrency is not null) writer.WriteString(41972, UnderlyingStreamCommodityCurrency);
			if (UnderlyingStreamCommodityExchange is not null) writer.WriteString(41973, UnderlyingStreamCommodityExchange);
			if (UnderlyingStreamCommodityRateSource is not null) writer.WriteWholeNumber(41974, UnderlyingStreamCommodityRateSource.Value);
			if (UnderlyingStreamCommodityRateReferencePage is not null) writer.WriteString(41975, UnderlyingStreamCommodityRateReferencePage);
			if (UnderlyingStreamCommodityRateReferencePageHeading is not null) writer.WriteString(41976, UnderlyingStreamCommodityRateReferencePageHeading);
			if (UnderlyingStreamDataProvider is not null) writer.WriteString(41977, UnderlyingStreamDataProvider);
			if (UnderlyingStreamCommodityDataSourceGrp is not null) ((IFixEncoder)UnderlyingStreamCommodityDataSourceGrp).Encode(writer);
			if (UnderlyingStreamCommodityPricingType is not null) writer.WriteString(41978, UnderlyingStreamCommodityPricingType);
			if (UnderlyingStreamCommodityNearbySettlDayPeriod is not null) writer.WriteWholeNumber(41979, UnderlyingStreamCommodityNearbySettlDayPeriod.Value);
			if (UnderlyingStreamCommodityNearbySettlDayUnit is not null) writer.WriteString(41980, UnderlyingStreamCommodityNearbySettlDayUnit);
			if (UnderlyingStreamCommoditySettlDateUnadjusted is not null) writer.WriteLocalDateOnly(41981, UnderlyingStreamCommoditySettlDateUnadjusted.Value);
			if (UnderlyingStreamCommoditySettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(41982, UnderlyingStreamCommoditySettlDateBusinessDayConvention.Value);
			if (UnderlyingStreamCommoditySettlBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingStreamCommoditySettlBusinessCenterGrp).Encode(writer);
			if (UnderlyingStreamCommoditySettlDateAdjusted is not null) writer.WriteLocalDateOnly(41983, UnderlyingStreamCommoditySettlDateAdjusted.Value);
			if (UnderlyingStreamCommoditySettlMonth is not null) writer.WriteWholeNumber(41984, UnderlyingStreamCommoditySettlMonth.Value);
			if (UnderlyingStreamCommoditySettlDateRollPeriod is not null) writer.WriteWholeNumber(41985, UnderlyingStreamCommoditySettlDateRollPeriod.Value);
			if (UnderlyingStreamCommoditySettlDateRollUnit is not null) writer.WriteString(41986, UnderlyingStreamCommoditySettlDateRollUnit);
			if (UnderlyingStreamCommoditySettlDayType is not null) writer.WriteWholeNumber(41987, UnderlyingStreamCommoditySettlDayType.Value);
			if (UnderlyingStreamCommoditySettlPeriodGrp is not null) ((IFixEncoder)UnderlyingStreamCommoditySettlPeriodGrp).Encode(writer);
			if (UnderlyingStreamCommodityXID is not null) writer.WriteString(41988, UnderlyingStreamCommodityXID);
			if (UnderlyingStreamCommodityXIDRef is not null) writer.WriteString(41989, UnderlyingStreamCommodityXIDRef);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingStreamCommodityBase = view.GetString(41964);
			UnderlyingStreamCommodityType = view.GetString(41965);
			UnderlyingStreamCommoditySecurityID = view.GetString(41966);
			UnderlyingStreamCommoditySecurityIDSource = view.GetString(41967);
			if (view.GetView("UnderlyingStreamCommodityAltIDGrp") is IMessageView viewUnderlyingStreamCommodityAltIDGrp)
			{
				UnderlyingStreamCommodityAltIDGrp = new();
				((IFixParser)UnderlyingStreamCommodityAltIDGrp).Parse(viewUnderlyingStreamCommodityAltIDGrp);
			}
			UnderlyingStreamCommodityDesc = view.GetString(41968);
			EncodedUnderlyingStreamCommodityDescLen = view.GetInt32(41969);
			EncodedUnderlyingStreamCommodityDesc = view.GetByteArray(41970);
			UnderlyingStreamCommodityDeliveryPricingRegion = view.GetString(42589);
			if (view.GetView("UnderlyingStreamAssetAttributeGrp") is IMessageView viewUnderlyingStreamAssetAttributeGrp)
			{
				UnderlyingStreamAssetAttributeGrp = new();
				((IFixParser)UnderlyingStreamAssetAttributeGrp).Parse(viewUnderlyingStreamAssetAttributeGrp);
			}
			UnderlyingStreamCommodityUnitOfMeasure = view.GetString(41971);
			UnderlyingStreamCommodityCurrency = view.GetString(41972);
			UnderlyingStreamCommodityExchange = view.GetString(41973);
			UnderlyingStreamCommodityRateSource = view.GetInt32(41974);
			UnderlyingStreamCommodityRateReferencePage = view.GetString(41975);
			UnderlyingStreamCommodityRateReferencePageHeading = view.GetString(41976);
			UnderlyingStreamDataProvider = view.GetString(41977);
			if (view.GetView("UnderlyingStreamCommodityDataSourceGrp") is IMessageView viewUnderlyingStreamCommodityDataSourceGrp)
			{
				UnderlyingStreamCommodityDataSourceGrp = new();
				((IFixParser)UnderlyingStreamCommodityDataSourceGrp).Parse(viewUnderlyingStreamCommodityDataSourceGrp);
			}
			UnderlyingStreamCommodityPricingType = view.GetString(41978);
			UnderlyingStreamCommodityNearbySettlDayPeriod = view.GetInt32(41979);
			UnderlyingStreamCommodityNearbySettlDayUnit = view.GetString(41980);
			UnderlyingStreamCommoditySettlDateUnadjusted = view.GetDateOnly(41981);
			UnderlyingStreamCommoditySettlDateBusinessDayConvention = view.GetInt32(41982);
			if (view.GetView("UnderlyingStreamCommoditySettlBusinessCenterGrp") is IMessageView viewUnderlyingStreamCommoditySettlBusinessCenterGrp)
			{
				UnderlyingStreamCommoditySettlBusinessCenterGrp = new();
				((IFixParser)UnderlyingStreamCommoditySettlBusinessCenterGrp).Parse(viewUnderlyingStreamCommoditySettlBusinessCenterGrp);
			}
			UnderlyingStreamCommoditySettlDateAdjusted = view.GetDateOnly(41983);
			UnderlyingStreamCommoditySettlMonth = view.GetInt32(41984);
			UnderlyingStreamCommoditySettlDateRollPeriod = view.GetInt32(41985);
			UnderlyingStreamCommoditySettlDateRollUnit = view.GetString(41986);
			UnderlyingStreamCommoditySettlDayType = view.GetInt32(41987);
			if (view.GetView("UnderlyingStreamCommoditySettlPeriodGrp") is IMessageView viewUnderlyingStreamCommoditySettlPeriodGrp)
			{
				UnderlyingStreamCommoditySettlPeriodGrp = new();
				((IFixParser)UnderlyingStreamCommoditySettlPeriodGrp).Parse(viewUnderlyingStreamCommoditySettlPeriodGrp);
			}
			UnderlyingStreamCommodityXID = view.GetString(41988);
			UnderlyingStreamCommodityXIDRef = view.GetString(41989);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingStreamCommodityBase":
				{
					value = UnderlyingStreamCommodityBase;
					break;
				}
				case "UnderlyingStreamCommodityType":
				{
					value = UnderlyingStreamCommodityType;
					break;
				}
				case "UnderlyingStreamCommoditySecurityID":
				{
					value = UnderlyingStreamCommoditySecurityID;
					break;
				}
				case "UnderlyingStreamCommoditySecurityIDSource":
				{
					value = UnderlyingStreamCommoditySecurityIDSource;
					break;
				}
				case "UnderlyingStreamCommodityAltIDGrp":
				{
					value = UnderlyingStreamCommodityAltIDGrp;
					break;
				}
				case "UnderlyingStreamCommodityDesc":
				{
					value = UnderlyingStreamCommodityDesc;
					break;
				}
				case "EncodedUnderlyingStreamCommodityDescLen":
				{
					value = EncodedUnderlyingStreamCommodityDescLen;
					break;
				}
				case "EncodedUnderlyingStreamCommodityDesc":
				{
					value = EncodedUnderlyingStreamCommodityDesc;
					break;
				}
				case "UnderlyingStreamCommodityDeliveryPricingRegion":
				{
					value = UnderlyingStreamCommodityDeliveryPricingRegion;
					break;
				}
				case "UnderlyingStreamAssetAttributeGrp":
				{
					value = UnderlyingStreamAssetAttributeGrp;
					break;
				}
				case "UnderlyingStreamCommodityUnitOfMeasure":
				{
					value = UnderlyingStreamCommodityUnitOfMeasure;
					break;
				}
				case "UnderlyingStreamCommodityCurrency":
				{
					value = UnderlyingStreamCommodityCurrency;
					break;
				}
				case "UnderlyingStreamCommodityExchange":
				{
					value = UnderlyingStreamCommodityExchange;
					break;
				}
				case "UnderlyingStreamCommodityRateSource":
				{
					value = UnderlyingStreamCommodityRateSource;
					break;
				}
				case "UnderlyingStreamCommodityRateReferencePage":
				{
					value = UnderlyingStreamCommodityRateReferencePage;
					break;
				}
				case "UnderlyingStreamCommodityRateReferencePageHeading":
				{
					value = UnderlyingStreamCommodityRateReferencePageHeading;
					break;
				}
				case "UnderlyingStreamDataProvider":
				{
					value = UnderlyingStreamDataProvider;
					break;
				}
				case "UnderlyingStreamCommodityDataSourceGrp":
				{
					value = UnderlyingStreamCommodityDataSourceGrp;
					break;
				}
				case "UnderlyingStreamCommodityPricingType":
				{
					value = UnderlyingStreamCommodityPricingType;
					break;
				}
				case "UnderlyingStreamCommodityNearbySettlDayPeriod":
				{
					value = UnderlyingStreamCommodityNearbySettlDayPeriod;
					break;
				}
				case "UnderlyingStreamCommodityNearbySettlDayUnit":
				{
					value = UnderlyingStreamCommodityNearbySettlDayUnit;
					break;
				}
				case "UnderlyingStreamCommoditySettlDateUnadjusted":
				{
					value = UnderlyingStreamCommoditySettlDateUnadjusted;
					break;
				}
				case "UnderlyingStreamCommoditySettlDateBusinessDayConvention":
				{
					value = UnderlyingStreamCommoditySettlDateBusinessDayConvention;
					break;
				}
				case "UnderlyingStreamCommoditySettlBusinessCenterGrp":
				{
					value = UnderlyingStreamCommoditySettlBusinessCenterGrp;
					break;
				}
				case "UnderlyingStreamCommoditySettlDateAdjusted":
				{
					value = UnderlyingStreamCommoditySettlDateAdjusted;
					break;
				}
				case "UnderlyingStreamCommoditySettlMonth":
				{
					value = UnderlyingStreamCommoditySettlMonth;
					break;
				}
				case "UnderlyingStreamCommoditySettlDateRollPeriod":
				{
					value = UnderlyingStreamCommoditySettlDateRollPeriod;
					break;
				}
				case "UnderlyingStreamCommoditySettlDateRollUnit":
				{
					value = UnderlyingStreamCommoditySettlDateRollUnit;
					break;
				}
				case "UnderlyingStreamCommoditySettlDayType":
				{
					value = UnderlyingStreamCommoditySettlDayType;
					break;
				}
				case "UnderlyingStreamCommoditySettlPeriodGrp":
				{
					value = UnderlyingStreamCommoditySettlPeriodGrp;
					break;
				}
				case "UnderlyingStreamCommodityXID":
				{
					value = UnderlyingStreamCommodityXID;
					break;
				}
				case "UnderlyingStreamCommodityXIDRef":
				{
					value = UnderlyingStreamCommodityXIDRef;
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
			UnderlyingStreamCommodityBase = null;
			UnderlyingStreamCommodityType = null;
			UnderlyingStreamCommoditySecurityID = null;
			UnderlyingStreamCommoditySecurityIDSource = null;
			((IFixReset?)UnderlyingStreamCommodityAltIDGrp)?.Reset();
			UnderlyingStreamCommodityDesc = null;
			EncodedUnderlyingStreamCommodityDescLen = null;
			EncodedUnderlyingStreamCommodityDesc = null;
			UnderlyingStreamCommodityDeliveryPricingRegion = null;
			((IFixReset?)UnderlyingStreamAssetAttributeGrp)?.Reset();
			UnderlyingStreamCommodityUnitOfMeasure = null;
			UnderlyingStreamCommodityCurrency = null;
			UnderlyingStreamCommodityExchange = null;
			UnderlyingStreamCommodityRateSource = null;
			UnderlyingStreamCommodityRateReferencePage = null;
			UnderlyingStreamCommodityRateReferencePageHeading = null;
			UnderlyingStreamDataProvider = null;
			((IFixReset?)UnderlyingStreamCommodityDataSourceGrp)?.Reset();
			UnderlyingStreamCommodityPricingType = null;
			UnderlyingStreamCommodityNearbySettlDayPeriod = null;
			UnderlyingStreamCommodityNearbySettlDayUnit = null;
			UnderlyingStreamCommoditySettlDateUnadjusted = null;
			UnderlyingStreamCommoditySettlDateBusinessDayConvention = null;
			((IFixReset?)UnderlyingStreamCommoditySettlBusinessCenterGrp)?.Reset();
			UnderlyingStreamCommoditySettlDateAdjusted = null;
			UnderlyingStreamCommoditySettlMonth = null;
			UnderlyingStreamCommoditySettlDateRollPeriod = null;
			UnderlyingStreamCommoditySettlDateRollUnit = null;
			UnderlyingStreamCommoditySettlDayType = null;
			((IFixReset?)UnderlyingStreamCommoditySettlPeriodGrp)?.Reset();
			UnderlyingStreamCommodityXID = null;
			UnderlyingStreamCommodityXIDRef = null;
		}
	}
}
