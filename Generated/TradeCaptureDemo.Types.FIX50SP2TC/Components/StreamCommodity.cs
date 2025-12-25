using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommodity : IFixComponent
	{
		[TagDetails(Tag = 41251, Type = TagType.String, Offset = 0, Required = false)]
		public string? StreamCommodityBase {get; set;}
		
		[TagDetails(Tag = 41252, Type = TagType.String, Offset = 1, Required = false)]
		public string? StreamCommodityType {get; set;}
		
		[TagDetails(Tag = 41253, Type = TagType.String, Offset = 2, Required = false)]
		public string? StreamCommoditySecurityID {get; set;}
		
		[TagDetails(Tag = 41254, Type = TagType.String, Offset = 3, Required = false)]
		public string? StreamCommoditySecurityIDSource {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public StreamCommodityAltIDGrp? StreamCommodityAltIDGrp {get; set;}
		
		[TagDetails(Tag = 41255, Type = TagType.String, Offset = 5, Required = false)]
		public string? StreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 41256, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedStreamCommodityDescLen {get; set;}
		
		[TagDetails(Tag = 41257, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedStreamCommodityDesc {get; set;}
		
		[TagDetails(Tag = 42587, Type = TagType.String, Offset = 8, Required = false)]
		public string? StreamCommodityDeliveryPricingRegion {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public StreamAssetAttributeGrp? StreamAssetAttributeGrp {get; set;}
		
		[TagDetails(Tag = 41258, Type = TagType.String, Offset = 10, Required = false)]
		public string? StreamCommodityUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41259, Type = TagType.String, Offset = 11, Required = false)]
		public string? StreamCommodityCurrency {get; set;}
		
		[TagDetails(Tag = 41260, Type = TagType.String, Offset = 12, Required = false)]
		public string? StreamCommodityExchange {get; set;}
		
		[TagDetails(Tag = 41261, Type = TagType.Int, Offset = 13, Required = false)]
		public int? StreamCommodityRateSource {get; set;}
		
		[TagDetails(Tag = 41262, Type = TagType.String, Offset = 14, Required = false)]
		public string? StreamCommodityRateReferencePage {get; set;}
		
		[TagDetails(Tag = 41263, Type = TagType.String, Offset = 15, Required = false)]
		public string? StreamCommodityRateReferencePageHeading {get; set;}
		
		[TagDetails(Tag = 41264, Type = TagType.String, Offset = 16, Required = false)]
		public string? StreamDataProvider {get; set;}
		
		[Component(Offset = 17, Required = false)]
		public StreamCommodityDataSourceGrp? StreamCommodityDataSourceGrp {get; set;}
		
		[TagDetails(Tag = 41265, Type = TagType.String, Offset = 18, Required = false)]
		public string? StreamCommodityPricingType {get; set;}
		
		[TagDetails(Tag = 41266, Type = TagType.Int, Offset = 19, Required = false)]
		public int? StreamCommodityNearbySettlDayPeriod {get; set;}
		
		[TagDetails(Tag = 41267, Type = TagType.String, Offset = 20, Required = false)]
		public string? StreamCommodityNearbySettlDayUnit {get; set;}
		
		[TagDetails(Tag = 41268, Type = TagType.LocalDate, Offset = 21, Required = false)]
		public DateOnly? StreamCommoditySettlDateUnadjusted {get; set;}
		
		[TagDetails(Tag = 41269, Type = TagType.Int, Offset = 22, Required = false)]
		public int? StreamCommoditySettlDateBusinessDayConvention {get; set;}
		
		[Component(Offset = 23, Required = false)]
		public StreamCommoditySettlBusinessCenterGrp? StreamCommoditySettlBusinessCenterGrp {get; set;}
		
		[TagDetails(Tag = 41270, Type = TagType.LocalDate, Offset = 24, Required = false)]
		public DateOnly? StreamCommoditySettlDateAdjusted {get; set;}
		
		[TagDetails(Tag = 41271, Type = TagType.Int, Offset = 25, Required = false)]
		public int? StreamCommoditySettlMonth {get; set;}
		
		[TagDetails(Tag = 41272, Type = TagType.Int, Offset = 26, Required = false)]
		public int? StreamCommoditySettlDateRollPeriod {get; set;}
		
		[TagDetails(Tag = 41273, Type = TagType.String, Offset = 27, Required = false)]
		public string? StreamCommoditySettlDateRollUnit {get; set;}
		
		[TagDetails(Tag = 41274, Type = TagType.Int, Offset = 28, Required = false)]
		public int? StreamCommoditySettlDayType {get; set;}
		
		[Component(Offset = 29, Required = false)]
		public StreamCommoditySettlPeriodGrp? StreamCommoditySettlPeriodGrp {get; set;}
		
		[TagDetails(Tag = 41275, Type = TagType.String, Offset = 30, Required = false)]
		public string? StreamCommodityXID {get; set;}
		
		[TagDetails(Tag = 41276, Type = TagType.String, Offset = 31, Required = false)]
		public string? StreamCommodityXIDRef {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommodityBase is not null) writer.WriteString(41251, StreamCommodityBase);
			if (StreamCommodityType is not null) writer.WriteString(41252, StreamCommodityType);
			if (StreamCommoditySecurityID is not null) writer.WriteString(41253, StreamCommoditySecurityID);
			if (StreamCommoditySecurityIDSource is not null) writer.WriteString(41254, StreamCommoditySecurityIDSource);
			if (StreamCommodityAltIDGrp is not null) ((IFixEncoder)StreamCommodityAltIDGrp).Encode(writer);
			if (StreamCommodityDesc is not null) writer.WriteString(41255, StreamCommodityDesc);
			if (EncodedStreamCommodityDescLen is not null) writer.WriteWholeNumber(41256, EncodedStreamCommodityDescLen.Value);
			if (EncodedStreamCommodityDesc is not null) writer.WriteBuffer(41257, EncodedStreamCommodityDesc);
			if (StreamCommodityDeliveryPricingRegion is not null) writer.WriteString(42587, StreamCommodityDeliveryPricingRegion);
			if (StreamAssetAttributeGrp is not null) ((IFixEncoder)StreamAssetAttributeGrp).Encode(writer);
			if (StreamCommodityUnitOfMeasure is not null) writer.WriteString(41258, StreamCommodityUnitOfMeasure);
			if (StreamCommodityCurrency is not null) writer.WriteString(41259, StreamCommodityCurrency);
			if (StreamCommodityExchange is not null) writer.WriteString(41260, StreamCommodityExchange);
			if (StreamCommodityRateSource is not null) writer.WriteWholeNumber(41261, StreamCommodityRateSource.Value);
			if (StreamCommodityRateReferencePage is not null) writer.WriteString(41262, StreamCommodityRateReferencePage);
			if (StreamCommodityRateReferencePageHeading is not null) writer.WriteString(41263, StreamCommodityRateReferencePageHeading);
			if (StreamDataProvider is not null) writer.WriteString(41264, StreamDataProvider);
			if (StreamCommodityDataSourceGrp is not null) ((IFixEncoder)StreamCommodityDataSourceGrp).Encode(writer);
			if (StreamCommodityPricingType is not null) writer.WriteString(41265, StreamCommodityPricingType);
			if (StreamCommodityNearbySettlDayPeriod is not null) writer.WriteWholeNumber(41266, StreamCommodityNearbySettlDayPeriod.Value);
			if (StreamCommodityNearbySettlDayUnit is not null) writer.WriteString(41267, StreamCommodityNearbySettlDayUnit);
			if (StreamCommoditySettlDateUnadjusted is not null) writer.WriteLocalDateOnly(41268, StreamCommoditySettlDateUnadjusted.Value);
			if (StreamCommoditySettlDateBusinessDayConvention is not null) writer.WriteWholeNumber(41269, StreamCommoditySettlDateBusinessDayConvention.Value);
			if (StreamCommoditySettlBusinessCenterGrp is not null) ((IFixEncoder)StreamCommoditySettlBusinessCenterGrp).Encode(writer);
			if (StreamCommoditySettlDateAdjusted is not null) writer.WriteLocalDateOnly(41270, StreamCommoditySettlDateAdjusted.Value);
			if (StreamCommoditySettlMonth is not null) writer.WriteWholeNumber(41271, StreamCommoditySettlMonth.Value);
			if (StreamCommoditySettlDateRollPeriod is not null) writer.WriteWholeNumber(41272, StreamCommoditySettlDateRollPeriod.Value);
			if (StreamCommoditySettlDateRollUnit is not null) writer.WriteString(41273, StreamCommoditySettlDateRollUnit);
			if (StreamCommoditySettlDayType is not null) writer.WriteWholeNumber(41274, StreamCommoditySettlDayType.Value);
			if (StreamCommoditySettlPeriodGrp is not null) ((IFixEncoder)StreamCommoditySettlPeriodGrp).Encode(writer);
			if (StreamCommodityXID is not null) writer.WriteString(41275, StreamCommodityXID);
			if (StreamCommodityXIDRef is not null) writer.WriteString(41276, StreamCommodityXIDRef);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			StreamCommodityBase = view.GetString(41251);
			StreamCommodityType = view.GetString(41252);
			StreamCommoditySecurityID = view.GetString(41253);
			StreamCommoditySecurityIDSource = view.GetString(41254);
			if (view.GetView("StreamCommodityAltIDGrp") is IMessageView viewStreamCommodityAltIDGrp)
			{
				StreamCommodityAltIDGrp = new();
				((IFixParser)StreamCommodityAltIDGrp).Parse(viewStreamCommodityAltIDGrp);
			}
			StreamCommodityDesc = view.GetString(41255);
			EncodedStreamCommodityDescLen = view.GetInt32(41256);
			EncodedStreamCommodityDesc = view.GetByteArray(41257);
			StreamCommodityDeliveryPricingRegion = view.GetString(42587);
			if (view.GetView("StreamAssetAttributeGrp") is IMessageView viewStreamAssetAttributeGrp)
			{
				StreamAssetAttributeGrp = new();
				((IFixParser)StreamAssetAttributeGrp).Parse(viewStreamAssetAttributeGrp);
			}
			StreamCommodityUnitOfMeasure = view.GetString(41258);
			StreamCommodityCurrency = view.GetString(41259);
			StreamCommodityExchange = view.GetString(41260);
			StreamCommodityRateSource = view.GetInt32(41261);
			StreamCommodityRateReferencePage = view.GetString(41262);
			StreamCommodityRateReferencePageHeading = view.GetString(41263);
			StreamDataProvider = view.GetString(41264);
			if (view.GetView("StreamCommodityDataSourceGrp") is IMessageView viewStreamCommodityDataSourceGrp)
			{
				StreamCommodityDataSourceGrp = new();
				((IFixParser)StreamCommodityDataSourceGrp).Parse(viewStreamCommodityDataSourceGrp);
			}
			StreamCommodityPricingType = view.GetString(41265);
			StreamCommodityNearbySettlDayPeriod = view.GetInt32(41266);
			StreamCommodityNearbySettlDayUnit = view.GetString(41267);
			StreamCommoditySettlDateUnadjusted = view.GetDateOnly(41268);
			StreamCommoditySettlDateBusinessDayConvention = view.GetInt32(41269);
			if (view.GetView("StreamCommoditySettlBusinessCenterGrp") is IMessageView viewStreamCommoditySettlBusinessCenterGrp)
			{
				StreamCommoditySettlBusinessCenterGrp = new();
				((IFixParser)StreamCommoditySettlBusinessCenterGrp).Parse(viewStreamCommoditySettlBusinessCenterGrp);
			}
			StreamCommoditySettlDateAdjusted = view.GetDateOnly(41270);
			StreamCommoditySettlMonth = view.GetInt32(41271);
			StreamCommoditySettlDateRollPeriod = view.GetInt32(41272);
			StreamCommoditySettlDateRollUnit = view.GetString(41273);
			StreamCommoditySettlDayType = view.GetInt32(41274);
			if (view.GetView("StreamCommoditySettlPeriodGrp") is IMessageView viewStreamCommoditySettlPeriodGrp)
			{
				StreamCommoditySettlPeriodGrp = new();
				((IFixParser)StreamCommoditySettlPeriodGrp).Parse(viewStreamCommoditySettlPeriodGrp);
			}
			StreamCommodityXID = view.GetString(41275);
			StreamCommodityXIDRef = view.GetString(41276);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StreamCommodityBase":
				{
					value = StreamCommodityBase;
					break;
				}
				case "StreamCommodityType":
				{
					value = StreamCommodityType;
					break;
				}
				case "StreamCommoditySecurityID":
				{
					value = StreamCommoditySecurityID;
					break;
				}
				case "StreamCommoditySecurityIDSource":
				{
					value = StreamCommoditySecurityIDSource;
					break;
				}
				case "StreamCommodityAltIDGrp":
				{
					value = StreamCommodityAltIDGrp;
					break;
				}
				case "StreamCommodityDesc":
				{
					value = StreamCommodityDesc;
					break;
				}
				case "EncodedStreamCommodityDescLen":
				{
					value = EncodedStreamCommodityDescLen;
					break;
				}
				case "EncodedStreamCommodityDesc":
				{
					value = EncodedStreamCommodityDesc;
					break;
				}
				case "StreamCommodityDeliveryPricingRegion":
				{
					value = StreamCommodityDeliveryPricingRegion;
					break;
				}
				case "StreamAssetAttributeGrp":
				{
					value = StreamAssetAttributeGrp;
					break;
				}
				case "StreamCommodityUnitOfMeasure":
				{
					value = StreamCommodityUnitOfMeasure;
					break;
				}
				case "StreamCommodityCurrency":
				{
					value = StreamCommodityCurrency;
					break;
				}
				case "StreamCommodityExchange":
				{
					value = StreamCommodityExchange;
					break;
				}
				case "StreamCommodityRateSource":
				{
					value = StreamCommodityRateSource;
					break;
				}
				case "StreamCommodityRateReferencePage":
				{
					value = StreamCommodityRateReferencePage;
					break;
				}
				case "StreamCommodityRateReferencePageHeading":
				{
					value = StreamCommodityRateReferencePageHeading;
					break;
				}
				case "StreamDataProvider":
				{
					value = StreamDataProvider;
					break;
				}
				case "StreamCommodityDataSourceGrp":
				{
					value = StreamCommodityDataSourceGrp;
					break;
				}
				case "StreamCommodityPricingType":
				{
					value = StreamCommodityPricingType;
					break;
				}
				case "StreamCommodityNearbySettlDayPeriod":
				{
					value = StreamCommodityNearbySettlDayPeriod;
					break;
				}
				case "StreamCommodityNearbySettlDayUnit":
				{
					value = StreamCommodityNearbySettlDayUnit;
					break;
				}
				case "StreamCommoditySettlDateUnadjusted":
				{
					value = StreamCommoditySettlDateUnadjusted;
					break;
				}
				case "StreamCommoditySettlDateBusinessDayConvention":
				{
					value = StreamCommoditySettlDateBusinessDayConvention;
					break;
				}
				case "StreamCommoditySettlBusinessCenterGrp":
				{
					value = StreamCommoditySettlBusinessCenterGrp;
					break;
				}
				case "StreamCommoditySettlDateAdjusted":
				{
					value = StreamCommoditySettlDateAdjusted;
					break;
				}
				case "StreamCommoditySettlMonth":
				{
					value = StreamCommoditySettlMonth;
					break;
				}
				case "StreamCommoditySettlDateRollPeriod":
				{
					value = StreamCommoditySettlDateRollPeriod;
					break;
				}
				case "StreamCommoditySettlDateRollUnit":
				{
					value = StreamCommoditySettlDateRollUnit;
					break;
				}
				case "StreamCommoditySettlDayType":
				{
					value = StreamCommoditySettlDayType;
					break;
				}
				case "StreamCommoditySettlPeriodGrp":
				{
					value = StreamCommoditySettlPeriodGrp;
					break;
				}
				case "StreamCommodityXID":
				{
					value = StreamCommodityXID;
					break;
				}
				case "StreamCommodityXIDRef":
				{
					value = StreamCommodityXIDRef;
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
			StreamCommodityBase = null;
			StreamCommodityType = null;
			StreamCommoditySecurityID = null;
			StreamCommoditySecurityIDSource = null;
			((IFixReset?)StreamCommodityAltIDGrp)?.Reset();
			StreamCommodityDesc = null;
			EncodedStreamCommodityDescLen = null;
			EncodedStreamCommodityDesc = null;
			StreamCommodityDeliveryPricingRegion = null;
			((IFixReset?)StreamAssetAttributeGrp)?.Reset();
			StreamCommodityUnitOfMeasure = null;
			StreamCommodityCurrency = null;
			StreamCommodityExchange = null;
			StreamCommodityRateSource = null;
			StreamCommodityRateReferencePage = null;
			StreamCommodityRateReferencePageHeading = null;
			StreamDataProvider = null;
			((IFixReset?)StreamCommodityDataSourceGrp)?.Reset();
			StreamCommodityPricingType = null;
			StreamCommodityNearbySettlDayPeriod = null;
			StreamCommodityNearbySettlDayUnit = null;
			StreamCommoditySettlDateUnadjusted = null;
			StreamCommoditySettlDateBusinessDayConvention = null;
			((IFixReset?)StreamCommoditySettlBusinessCenterGrp)?.Reset();
			StreamCommoditySettlDateAdjusted = null;
			StreamCommoditySettlMonth = null;
			StreamCommoditySettlDateRollPeriod = null;
			StreamCommoditySettlDateRollUnit = null;
			StreamCommoditySettlDayType = null;
			((IFixReset?)StreamCommoditySettlPeriodGrp)?.Reset();
			StreamCommodityXID = null;
			StreamCommodityXIDRef = null;
		}
	}
}
