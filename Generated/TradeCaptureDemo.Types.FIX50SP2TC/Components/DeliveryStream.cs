using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DeliveryStream : IFixComponent
	{
		[TagDetails(Tag = 41058, Type = TagType.Int, Offset = 0, Required = false)]
		public int? DeliveryStreamType {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public DeliveryStreamCommoditySourceGrp? DeliveryStreamCommoditySourceGrp {get; set;}
		
		[TagDetails(Tag = 41059, Type = TagType.String, Offset = 2, Required = false)]
		public string? DeliveryStreamPipeline {get; set;}
		
		[TagDetails(Tag = 41060, Type = TagType.String, Offset = 3, Required = false)]
		public string? DeliveryStreamEntryPoint {get; set;}
		
		[TagDetails(Tag = 41061, Type = TagType.String, Offset = 4, Required = false)]
		public string? DeliveryStreamWithdrawalPoint {get; set;}
		
		[TagDetails(Tag = 41062, Type = TagType.String, Offset = 5, Required = false)]
		public string? DeliveryStreamDeliveryPoint {get; set;}
		
		[TagDetails(Tag = 42192, Type = TagType.Int, Offset = 6, Required = false)]
		public int? DeliveryStreamDeliveryPointSource {get; set;}
		
		[TagDetails(Tag = 42193, Type = TagType.String, Offset = 7, Required = false)]
		public string? DeliveryStreamDeliveryPointDesc {get; set;}
		
		[TagDetails(Tag = 41063, Type = TagType.Int, Offset = 8, Required = false)]
		public int? DeliveryStreamDeliveryRestriction {get; set;}
		
		[TagDetails(Tag = 41064, Type = TagType.String, Offset = 9, Required = false)]
		public string? DeliveryStreamDeliveryContingency {get; set;}
		
		[TagDetails(Tag = 41065, Type = TagType.Int, Offset = 10, Required = false)]
		public int? DeliveryStreamDeliveryContingentPartySide {get; set;}
		
		[TagDetails(Tag = 41066, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? DeliveryStreamDeliverAtSourceIndicator {get; set;}
		
		[TagDetails(Tag = 41067, Type = TagType.String, Offset = 12, Required = false)]
		public string? DeliveryStreamRiskApportionment {get; set;}
		
		[TagDetails(Tag = 41218, Type = TagType.String, Offset = 13, Required = false)]
		public string? DeliveryStreamRiskApportionmentSource {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public DeliveryStreamCycleGrp? DeliveryStreamCycleGrp {get; set;}
		
		[TagDetails(Tag = 41068, Type = TagType.String, Offset = 15, Required = false)]
		public string? DeliveryStreamTitleTransferLocation {get; set;}
		
		[TagDetails(Tag = 41069, Type = TagType.Int, Offset = 16, Required = false)]
		public int? DeliveryStreamTitleTransferCondition {get; set;}
		
		[TagDetails(Tag = 41070, Type = TagType.String, Offset = 17, Required = false)]
		public string? DeliveryStreamImporterOfRecord {get; set;}
		
		[TagDetails(Tag = 41071, Type = TagType.Float, Offset = 18, Required = false)]
		public double? DeliveryStreamNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41072, Type = TagType.Float, Offset = 19, Required = false)]
		public double? DeliveryStreamPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41073, Type = TagType.String, Offset = 20, Required = false)]
		public string? DeliveryStreamToleranceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41074, Type = TagType.Int, Offset = 21, Required = false)]
		public int? DeliveryStreamToleranceType {get; set;}
		
		[TagDetails(Tag = 41075, Type = TagType.Int, Offset = 22, Required = false)]
		public int? DeliveryStreamToleranceOptionSide {get; set;}
		
		[TagDetails(Tag = 41076, Type = TagType.Float, Offset = 23, Required = false)]
		public double? DeliveryStreamTotalPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41077, Type = TagType.Float, Offset = 24, Required = false)]
		public double? DeliveryStreamTotalNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41078, Type = TagType.Float, Offset = 25, Required = false)]
		public double? DeliveryStreamNotionalConversionFactor {get; set;}
		
		[TagDetails(Tag = 41079, Type = TagType.String, Offset = 26, Required = false)]
		public string? DeliveryStreamTransportEquipment {get; set;}
		
		[TagDetails(Tag = 41080, Type = TagType.Int, Offset = 27, Required = false)]
		public int? DeliveryStreamElectingPartySide {get; set;}
		
		[TagDetails(Tag = 43094, Type = TagType.String, Offset = 28, Required = false)]
		public string? DeliveryStreamRouteOrCharter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliveryStreamType is not null) writer.WriteWholeNumber(41058, DeliveryStreamType.Value);
			if (DeliveryStreamCommoditySourceGrp is not null) ((IFixEncoder)DeliveryStreamCommoditySourceGrp).Encode(writer);
			if (DeliveryStreamPipeline is not null) writer.WriteString(41059, DeliveryStreamPipeline);
			if (DeliveryStreamEntryPoint is not null) writer.WriteString(41060, DeliveryStreamEntryPoint);
			if (DeliveryStreamWithdrawalPoint is not null) writer.WriteString(41061, DeliveryStreamWithdrawalPoint);
			if (DeliveryStreamDeliveryPoint is not null) writer.WriteString(41062, DeliveryStreamDeliveryPoint);
			if (DeliveryStreamDeliveryPointSource is not null) writer.WriteWholeNumber(42192, DeliveryStreamDeliveryPointSource.Value);
			if (DeliveryStreamDeliveryPointDesc is not null) writer.WriteString(42193, DeliveryStreamDeliveryPointDesc);
			if (DeliveryStreamDeliveryRestriction is not null) writer.WriteWholeNumber(41063, DeliveryStreamDeliveryRestriction.Value);
			if (DeliveryStreamDeliveryContingency is not null) writer.WriteString(41064, DeliveryStreamDeliveryContingency);
			if (DeliveryStreamDeliveryContingentPartySide is not null) writer.WriteWholeNumber(41065, DeliveryStreamDeliveryContingentPartySide.Value);
			if (DeliveryStreamDeliverAtSourceIndicator is not null) writer.WriteBoolean(41066, DeliveryStreamDeliverAtSourceIndicator.Value);
			if (DeliveryStreamRiskApportionment is not null) writer.WriteString(41067, DeliveryStreamRiskApportionment);
			if (DeliveryStreamRiskApportionmentSource is not null) writer.WriteString(41218, DeliveryStreamRiskApportionmentSource);
			if (DeliveryStreamCycleGrp is not null) ((IFixEncoder)DeliveryStreamCycleGrp).Encode(writer);
			if (DeliveryStreamTitleTransferLocation is not null) writer.WriteString(41068, DeliveryStreamTitleTransferLocation);
			if (DeliveryStreamTitleTransferCondition is not null) writer.WriteWholeNumber(41069, DeliveryStreamTitleTransferCondition.Value);
			if (DeliveryStreamImporterOfRecord is not null) writer.WriteString(41070, DeliveryStreamImporterOfRecord);
			if (DeliveryStreamNegativeTolerance is not null) writer.WriteNumber(41071, DeliveryStreamNegativeTolerance.Value);
			if (DeliveryStreamPositiveTolerance is not null) writer.WriteNumber(41072, DeliveryStreamPositiveTolerance.Value);
			if (DeliveryStreamToleranceUnitOfMeasure is not null) writer.WriteString(41073, DeliveryStreamToleranceUnitOfMeasure);
			if (DeliveryStreamToleranceType is not null) writer.WriteWholeNumber(41074, DeliveryStreamToleranceType.Value);
			if (DeliveryStreamToleranceOptionSide is not null) writer.WriteWholeNumber(41075, DeliveryStreamToleranceOptionSide.Value);
			if (DeliveryStreamTotalPositiveTolerance is not null) writer.WriteNumber(41076, DeliveryStreamTotalPositiveTolerance.Value);
			if (DeliveryStreamTotalNegativeTolerance is not null) writer.WriteNumber(41077, DeliveryStreamTotalNegativeTolerance.Value);
			if (DeliveryStreamNotionalConversionFactor is not null) writer.WriteNumber(41078, DeliveryStreamNotionalConversionFactor.Value);
			if (DeliveryStreamTransportEquipment is not null) writer.WriteString(41079, DeliveryStreamTransportEquipment);
			if (DeliveryStreamElectingPartySide is not null) writer.WriteWholeNumber(41080, DeliveryStreamElectingPartySide.Value);
			if (DeliveryStreamRouteOrCharter is not null) writer.WriteString(43094, DeliveryStreamRouteOrCharter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DeliveryStreamType = view.GetInt32(41058);
			if (view.GetView("DeliveryStreamCommoditySourceGrp") is IMessageView viewDeliveryStreamCommoditySourceGrp)
			{
				DeliveryStreamCommoditySourceGrp = new();
				((IFixParser)DeliveryStreamCommoditySourceGrp).Parse(viewDeliveryStreamCommoditySourceGrp);
			}
			DeliveryStreamPipeline = view.GetString(41059);
			DeliveryStreamEntryPoint = view.GetString(41060);
			DeliveryStreamWithdrawalPoint = view.GetString(41061);
			DeliveryStreamDeliveryPoint = view.GetString(41062);
			DeliveryStreamDeliveryPointSource = view.GetInt32(42192);
			DeliveryStreamDeliveryPointDesc = view.GetString(42193);
			DeliveryStreamDeliveryRestriction = view.GetInt32(41063);
			DeliveryStreamDeliveryContingency = view.GetString(41064);
			DeliveryStreamDeliveryContingentPartySide = view.GetInt32(41065);
			DeliveryStreamDeliverAtSourceIndicator = view.GetBool(41066);
			DeliveryStreamRiskApportionment = view.GetString(41067);
			DeliveryStreamRiskApportionmentSource = view.GetString(41218);
			if (view.GetView("DeliveryStreamCycleGrp") is IMessageView viewDeliveryStreamCycleGrp)
			{
				DeliveryStreamCycleGrp = new();
				((IFixParser)DeliveryStreamCycleGrp).Parse(viewDeliveryStreamCycleGrp);
			}
			DeliveryStreamTitleTransferLocation = view.GetString(41068);
			DeliveryStreamTitleTransferCondition = view.GetInt32(41069);
			DeliveryStreamImporterOfRecord = view.GetString(41070);
			DeliveryStreamNegativeTolerance = view.GetDouble(41071);
			DeliveryStreamPositiveTolerance = view.GetDouble(41072);
			DeliveryStreamToleranceUnitOfMeasure = view.GetString(41073);
			DeliveryStreamToleranceType = view.GetInt32(41074);
			DeliveryStreamToleranceOptionSide = view.GetInt32(41075);
			DeliveryStreamTotalPositiveTolerance = view.GetDouble(41076);
			DeliveryStreamTotalNegativeTolerance = view.GetDouble(41077);
			DeliveryStreamNotionalConversionFactor = view.GetDouble(41078);
			DeliveryStreamTransportEquipment = view.GetString(41079);
			DeliveryStreamElectingPartySide = view.GetInt32(41080);
			DeliveryStreamRouteOrCharter = view.GetString(43094);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DeliveryStreamType":
				{
					value = DeliveryStreamType;
					break;
				}
				case "DeliveryStreamCommoditySourceGrp":
				{
					value = DeliveryStreamCommoditySourceGrp;
					break;
				}
				case "DeliveryStreamPipeline":
				{
					value = DeliveryStreamPipeline;
					break;
				}
				case "DeliveryStreamEntryPoint":
				{
					value = DeliveryStreamEntryPoint;
					break;
				}
				case "DeliveryStreamWithdrawalPoint":
				{
					value = DeliveryStreamWithdrawalPoint;
					break;
				}
				case "DeliveryStreamDeliveryPoint":
				{
					value = DeliveryStreamDeliveryPoint;
					break;
				}
				case "DeliveryStreamDeliveryPointSource":
				{
					value = DeliveryStreamDeliveryPointSource;
					break;
				}
				case "DeliveryStreamDeliveryPointDesc":
				{
					value = DeliveryStreamDeliveryPointDesc;
					break;
				}
				case "DeliveryStreamDeliveryRestriction":
				{
					value = DeliveryStreamDeliveryRestriction;
					break;
				}
				case "DeliveryStreamDeliveryContingency":
				{
					value = DeliveryStreamDeliveryContingency;
					break;
				}
				case "DeliveryStreamDeliveryContingentPartySide":
				{
					value = DeliveryStreamDeliveryContingentPartySide;
					break;
				}
				case "DeliveryStreamDeliverAtSourceIndicator":
				{
					value = DeliveryStreamDeliverAtSourceIndicator;
					break;
				}
				case "DeliveryStreamRiskApportionment":
				{
					value = DeliveryStreamRiskApportionment;
					break;
				}
				case "DeliveryStreamRiskApportionmentSource":
				{
					value = DeliveryStreamRiskApportionmentSource;
					break;
				}
				case "DeliveryStreamCycleGrp":
				{
					value = DeliveryStreamCycleGrp;
					break;
				}
				case "DeliveryStreamTitleTransferLocation":
				{
					value = DeliveryStreamTitleTransferLocation;
					break;
				}
				case "DeliveryStreamTitleTransferCondition":
				{
					value = DeliveryStreamTitleTransferCondition;
					break;
				}
				case "DeliveryStreamImporterOfRecord":
				{
					value = DeliveryStreamImporterOfRecord;
					break;
				}
				case "DeliveryStreamNegativeTolerance":
				{
					value = DeliveryStreamNegativeTolerance;
					break;
				}
				case "DeliveryStreamPositiveTolerance":
				{
					value = DeliveryStreamPositiveTolerance;
					break;
				}
				case "DeliveryStreamToleranceUnitOfMeasure":
				{
					value = DeliveryStreamToleranceUnitOfMeasure;
					break;
				}
				case "DeliveryStreamToleranceType":
				{
					value = DeliveryStreamToleranceType;
					break;
				}
				case "DeliveryStreamToleranceOptionSide":
				{
					value = DeliveryStreamToleranceOptionSide;
					break;
				}
				case "DeliveryStreamTotalPositiveTolerance":
				{
					value = DeliveryStreamTotalPositiveTolerance;
					break;
				}
				case "DeliveryStreamTotalNegativeTolerance":
				{
					value = DeliveryStreamTotalNegativeTolerance;
					break;
				}
				case "DeliveryStreamNotionalConversionFactor":
				{
					value = DeliveryStreamNotionalConversionFactor;
					break;
				}
				case "DeliveryStreamTransportEquipment":
				{
					value = DeliveryStreamTransportEquipment;
					break;
				}
				case "DeliveryStreamElectingPartySide":
				{
					value = DeliveryStreamElectingPartySide;
					break;
				}
				case "DeliveryStreamRouteOrCharter":
				{
					value = DeliveryStreamRouteOrCharter;
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
			DeliveryStreamType = null;
			((IFixReset?)DeliveryStreamCommoditySourceGrp)?.Reset();
			DeliveryStreamPipeline = null;
			DeliveryStreamEntryPoint = null;
			DeliveryStreamWithdrawalPoint = null;
			DeliveryStreamDeliveryPoint = null;
			DeliveryStreamDeliveryPointSource = null;
			DeliveryStreamDeliveryPointDesc = null;
			DeliveryStreamDeliveryRestriction = null;
			DeliveryStreamDeliveryContingency = null;
			DeliveryStreamDeliveryContingentPartySide = null;
			DeliveryStreamDeliverAtSourceIndicator = null;
			DeliveryStreamRiskApportionment = null;
			DeliveryStreamRiskApportionmentSource = null;
			((IFixReset?)DeliveryStreamCycleGrp)?.Reset();
			DeliveryStreamTitleTransferLocation = null;
			DeliveryStreamTitleTransferCondition = null;
			DeliveryStreamImporterOfRecord = null;
			DeliveryStreamNegativeTolerance = null;
			DeliveryStreamPositiveTolerance = null;
			DeliveryStreamToleranceUnitOfMeasure = null;
			DeliveryStreamToleranceType = null;
			DeliveryStreamToleranceOptionSide = null;
			DeliveryStreamTotalPositiveTolerance = null;
			DeliveryStreamTotalNegativeTolerance = null;
			DeliveryStreamNotionalConversionFactor = null;
			DeliveryStreamTransportEquipment = null;
			DeliveryStreamElectingPartySide = null;
			DeliveryStreamRouteOrCharter = null;
		}
	}
}
