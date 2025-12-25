using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryStream : IFixComponent
	{
		[TagDetails(Tag = 41429, Type = TagType.Int, Offset = 0, Required = false)]
		public int? LegDeliveryStreamType {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public LegDeliveryStreamCommoditySourceGrp? LegDeliveryStreamCommoditySourceGrp {get; set;}
		
		[TagDetails(Tag = 41430, Type = TagType.String, Offset = 2, Required = false)]
		public string? LegDeliveryStreamPipeline {get; set;}
		
		[TagDetails(Tag = 41431, Type = TagType.String, Offset = 3, Required = false)]
		public string? LegDeliveryStreamEntryPoint {get; set;}
		
		[TagDetails(Tag = 41432, Type = TagType.String, Offset = 4, Required = false)]
		public string? LegDeliveryStreamWithdrawalPoint {get; set;}
		
		[TagDetails(Tag = 41433, Type = TagType.String, Offset = 5, Required = false)]
		public string? LegDeliveryStreamDeliveryPoint {get; set;}
		
		[TagDetails(Tag = 42194, Type = TagType.Int, Offset = 6, Required = false)]
		public int? LegDeliveryStreamDeliveryPointSource {get; set;}
		
		[TagDetails(Tag = 42195, Type = TagType.String, Offset = 7, Required = false)]
		public string? LegDeliveryStreamDeliveryPointDesc {get; set;}
		
		[TagDetails(Tag = 41434, Type = TagType.Int, Offset = 8, Required = false)]
		public int? LegDeliveryStreamDeliveryRestriction {get; set;}
		
		[TagDetails(Tag = 41435, Type = TagType.String, Offset = 9, Required = false)]
		public string? LegDeliveryStreamDeliveryContingency {get; set;}
		
		[TagDetails(Tag = 41436, Type = TagType.Int, Offset = 10, Required = false)]
		public int? LegDeliveryStreamDeliveryContingentPartySide {get; set;}
		
		[TagDetails(Tag = 41437, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? LegDeliveryStreamDeliverAtSourceIndicator {get; set;}
		
		[TagDetails(Tag = 41438, Type = TagType.String, Offset = 12, Required = false)]
		public string? LegDeliveryStreamRiskApportionment {get; set;}
		
		[TagDetails(Tag = 41219, Type = TagType.String, Offset = 13, Required = false)]
		public string? LegDeliveryStreamRiskApportionmentSource {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public LegDeliveryStreamCycleGrp? LegDeliveryStreamCycleGrp {get; set;}
		
		[TagDetails(Tag = 41439, Type = TagType.String, Offset = 15, Required = false)]
		public string? LegDeliveryStreamTitleTransferLocation {get; set;}
		
		[TagDetails(Tag = 41440, Type = TagType.Int, Offset = 16, Required = false)]
		public int? LegDeliveryStreamTitleTransferCondition {get; set;}
		
		[TagDetails(Tag = 41441, Type = TagType.String, Offset = 17, Required = false)]
		public string? LegDeliveryStreamImporterOfRecord {get; set;}
		
		[TagDetails(Tag = 41442, Type = TagType.Float, Offset = 18, Required = false)]
		public double? LegDeliveryStreamNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41443, Type = TagType.Float, Offset = 19, Required = false)]
		public double? LegDeliveryStreamPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41444, Type = TagType.String, Offset = 20, Required = false)]
		public string? LegDeliveryStreamToleranceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41445, Type = TagType.Int, Offset = 21, Required = false)]
		public int? LegDeliveryStreamToleranceType {get; set;}
		
		[TagDetails(Tag = 41446, Type = TagType.Int, Offset = 22, Required = false)]
		public int? LegDeliveryStreamToleranceOptionSide {get; set;}
		
		[TagDetails(Tag = 41447, Type = TagType.Float, Offset = 23, Required = false)]
		public double? LegDeliveryStreamTotalPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41448, Type = TagType.Float, Offset = 24, Required = false)]
		public double? LegDeliveryStreamTotalNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41449, Type = TagType.Float, Offset = 25, Required = false)]
		public double? LegDeliveryStreamNotionalConversionFactor {get; set;}
		
		[TagDetails(Tag = 41450, Type = TagType.String, Offset = 26, Required = false)]
		public string? LegDeliveryStreamTransportEquipment {get; set;}
		
		[TagDetails(Tag = 41451, Type = TagType.Int, Offset = 27, Required = false)]
		public int? LegDeliveryStreamElectingPartySide {get; set;}
		
		[TagDetails(Tag = 43095, Type = TagType.String, Offset = 28, Required = false)]
		public string? LegDeliveryStreamRouteOrCharter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliveryStreamType is not null) writer.WriteWholeNumber(41429, LegDeliveryStreamType.Value);
			if (LegDeliveryStreamCommoditySourceGrp is not null) ((IFixEncoder)LegDeliveryStreamCommoditySourceGrp).Encode(writer);
			if (LegDeliveryStreamPipeline is not null) writer.WriteString(41430, LegDeliveryStreamPipeline);
			if (LegDeliveryStreamEntryPoint is not null) writer.WriteString(41431, LegDeliveryStreamEntryPoint);
			if (LegDeliveryStreamWithdrawalPoint is not null) writer.WriteString(41432, LegDeliveryStreamWithdrawalPoint);
			if (LegDeliveryStreamDeliveryPoint is not null) writer.WriteString(41433, LegDeliveryStreamDeliveryPoint);
			if (LegDeliveryStreamDeliveryPointSource is not null) writer.WriteWholeNumber(42194, LegDeliveryStreamDeliveryPointSource.Value);
			if (LegDeliveryStreamDeliveryPointDesc is not null) writer.WriteString(42195, LegDeliveryStreamDeliveryPointDesc);
			if (LegDeliveryStreamDeliveryRestriction is not null) writer.WriteWholeNumber(41434, LegDeliveryStreamDeliveryRestriction.Value);
			if (LegDeliveryStreamDeliveryContingency is not null) writer.WriteString(41435, LegDeliveryStreamDeliveryContingency);
			if (LegDeliveryStreamDeliveryContingentPartySide is not null) writer.WriteWholeNumber(41436, LegDeliveryStreamDeliveryContingentPartySide.Value);
			if (LegDeliveryStreamDeliverAtSourceIndicator is not null) writer.WriteBoolean(41437, LegDeliveryStreamDeliverAtSourceIndicator.Value);
			if (LegDeliveryStreamRiskApportionment is not null) writer.WriteString(41438, LegDeliveryStreamRiskApportionment);
			if (LegDeliveryStreamRiskApportionmentSource is not null) writer.WriteString(41219, LegDeliveryStreamRiskApportionmentSource);
			if (LegDeliveryStreamCycleGrp is not null) ((IFixEncoder)LegDeliveryStreamCycleGrp).Encode(writer);
			if (LegDeliveryStreamTitleTransferLocation is not null) writer.WriteString(41439, LegDeliveryStreamTitleTransferLocation);
			if (LegDeliveryStreamTitleTransferCondition is not null) writer.WriteWholeNumber(41440, LegDeliveryStreamTitleTransferCondition.Value);
			if (LegDeliveryStreamImporterOfRecord is not null) writer.WriteString(41441, LegDeliveryStreamImporterOfRecord);
			if (LegDeliveryStreamNegativeTolerance is not null) writer.WriteNumber(41442, LegDeliveryStreamNegativeTolerance.Value);
			if (LegDeliveryStreamPositiveTolerance is not null) writer.WriteNumber(41443, LegDeliveryStreamPositiveTolerance.Value);
			if (LegDeliveryStreamToleranceUnitOfMeasure is not null) writer.WriteString(41444, LegDeliveryStreamToleranceUnitOfMeasure);
			if (LegDeliveryStreamToleranceType is not null) writer.WriteWholeNumber(41445, LegDeliveryStreamToleranceType.Value);
			if (LegDeliveryStreamToleranceOptionSide is not null) writer.WriteWholeNumber(41446, LegDeliveryStreamToleranceOptionSide.Value);
			if (LegDeliveryStreamTotalPositiveTolerance is not null) writer.WriteNumber(41447, LegDeliveryStreamTotalPositiveTolerance.Value);
			if (LegDeliveryStreamTotalNegativeTolerance is not null) writer.WriteNumber(41448, LegDeliveryStreamTotalNegativeTolerance.Value);
			if (LegDeliveryStreamNotionalConversionFactor is not null) writer.WriteNumber(41449, LegDeliveryStreamNotionalConversionFactor.Value);
			if (LegDeliveryStreamTransportEquipment is not null) writer.WriteString(41450, LegDeliveryStreamTransportEquipment);
			if (LegDeliveryStreamElectingPartySide is not null) writer.WriteWholeNumber(41451, LegDeliveryStreamElectingPartySide.Value);
			if (LegDeliveryStreamRouteOrCharter is not null) writer.WriteString(43095, LegDeliveryStreamRouteOrCharter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			LegDeliveryStreamType = view.GetInt32(41429);
			if (view.GetView("LegDeliveryStreamCommoditySourceGrp") is IMessageView viewLegDeliveryStreamCommoditySourceGrp)
			{
				LegDeliveryStreamCommoditySourceGrp = new();
				((IFixParser)LegDeliveryStreamCommoditySourceGrp).Parse(viewLegDeliveryStreamCommoditySourceGrp);
			}
			LegDeliveryStreamPipeline = view.GetString(41430);
			LegDeliveryStreamEntryPoint = view.GetString(41431);
			LegDeliveryStreamWithdrawalPoint = view.GetString(41432);
			LegDeliveryStreamDeliveryPoint = view.GetString(41433);
			LegDeliveryStreamDeliveryPointSource = view.GetInt32(42194);
			LegDeliveryStreamDeliveryPointDesc = view.GetString(42195);
			LegDeliveryStreamDeliveryRestriction = view.GetInt32(41434);
			LegDeliveryStreamDeliveryContingency = view.GetString(41435);
			LegDeliveryStreamDeliveryContingentPartySide = view.GetInt32(41436);
			LegDeliveryStreamDeliverAtSourceIndicator = view.GetBool(41437);
			LegDeliveryStreamRiskApportionment = view.GetString(41438);
			LegDeliveryStreamRiskApportionmentSource = view.GetString(41219);
			if (view.GetView("LegDeliveryStreamCycleGrp") is IMessageView viewLegDeliveryStreamCycleGrp)
			{
				LegDeliveryStreamCycleGrp = new();
				((IFixParser)LegDeliveryStreamCycleGrp).Parse(viewLegDeliveryStreamCycleGrp);
			}
			LegDeliveryStreamTitleTransferLocation = view.GetString(41439);
			LegDeliveryStreamTitleTransferCondition = view.GetInt32(41440);
			LegDeliveryStreamImporterOfRecord = view.GetString(41441);
			LegDeliveryStreamNegativeTolerance = view.GetDouble(41442);
			LegDeliveryStreamPositiveTolerance = view.GetDouble(41443);
			LegDeliveryStreamToleranceUnitOfMeasure = view.GetString(41444);
			LegDeliveryStreamToleranceType = view.GetInt32(41445);
			LegDeliveryStreamToleranceOptionSide = view.GetInt32(41446);
			LegDeliveryStreamTotalPositiveTolerance = view.GetDouble(41447);
			LegDeliveryStreamTotalNegativeTolerance = view.GetDouble(41448);
			LegDeliveryStreamNotionalConversionFactor = view.GetDouble(41449);
			LegDeliveryStreamTransportEquipment = view.GetString(41450);
			LegDeliveryStreamElectingPartySide = view.GetInt32(41451);
			LegDeliveryStreamRouteOrCharter = view.GetString(43095);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "LegDeliveryStreamType":
				{
					value = LegDeliveryStreamType;
					break;
				}
				case "LegDeliveryStreamCommoditySourceGrp":
				{
					value = LegDeliveryStreamCommoditySourceGrp;
					break;
				}
				case "LegDeliveryStreamPipeline":
				{
					value = LegDeliveryStreamPipeline;
					break;
				}
				case "LegDeliveryStreamEntryPoint":
				{
					value = LegDeliveryStreamEntryPoint;
					break;
				}
				case "LegDeliveryStreamWithdrawalPoint":
				{
					value = LegDeliveryStreamWithdrawalPoint;
					break;
				}
				case "LegDeliveryStreamDeliveryPoint":
				{
					value = LegDeliveryStreamDeliveryPoint;
					break;
				}
				case "LegDeliveryStreamDeliveryPointSource":
				{
					value = LegDeliveryStreamDeliveryPointSource;
					break;
				}
				case "LegDeliveryStreamDeliveryPointDesc":
				{
					value = LegDeliveryStreamDeliveryPointDesc;
					break;
				}
				case "LegDeliveryStreamDeliveryRestriction":
				{
					value = LegDeliveryStreamDeliveryRestriction;
					break;
				}
				case "LegDeliveryStreamDeliveryContingency":
				{
					value = LegDeliveryStreamDeliveryContingency;
					break;
				}
				case "LegDeliveryStreamDeliveryContingentPartySide":
				{
					value = LegDeliveryStreamDeliveryContingentPartySide;
					break;
				}
				case "LegDeliveryStreamDeliverAtSourceIndicator":
				{
					value = LegDeliveryStreamDeliverAtSourceIndicator;
					break;
				}
				case "LegDeliveryStreamRiskApportionment":
				{
					value = LegDeliveryStreamRiskApportionment;
					break;
				}
				case "LegDeliveryStreamRiskApportionmentSource":
				{
					value = LegDeliveryStreamRiskApportionmentSource;
					break;
				}
				case "LegDeliveryStreamCycleGrp":
				{
					value = LegDeliveryStreamCycleGrp;
					break;
				}
				case "LegDeliveryStreamTitleTransferLocation":
				{
					value = LegDeliveryStreamTitleTransferLocation;
					break;
				}
				case "LegDeliveryStreamTitleTransferCondition":
				{
					value = LegDeliveryStreamTitleTransferCondition;
					break;
				}
				case "LegDeliveryStreamImporterOfRecord":
				{
					value = LegDeliveryStreamImporterOfRecord;
					break;
				}
				case "LegDeliveryStreamNegativeTolerance":
				{
					value = LegDeliveryStreamNegativeTolerance;
					break;
				}
				case "LegDeliveryStreamPositiveTolerance":
				{
					value = LegDeliveryStreamPositiveTolerance;
					break;
				}
				case "LegDeliveryStreamToleranceUnitOfMeasure":
				{
					value = LegDeliveryStreamToleranceUnitOfMeasure;
					break;
				}
				case "LegDeliveryStreamToleranceType":
				{
					value = LegDeliveryStreamToleranceType;
					break;
				}
				case "LegDeliveryStreamToleranceOptionSide":
				{
					value = LegDeliveryStreamToleranceOptionSide;
					break;
				}
				case "LegDeliveryStreamTotalPositiveTolerance":
				{
					value = LegDeliveryStreamTotalPositiveTolerance;
					break;
				}
				case "LegDeliveryStreamTotalNegativeTolerance":
				{
					value = LegDeliveryStreamTotalNegativeTolerance;
					break;
				}
				case "LegDeliveryStreamNotionalConversionFactor":
				{
					value = LegDeliveryStreamNotionalConversionFactor;
					break;
				}
				case "LegDeliveryStreamTransportEquipment":
				{
					value = LegDeliveryStreamTransportEquipment;
					break;
				}
				case "LegDeliveryStreamElectingPartySide":
				{
					value = LegDeliveryStreamElectingPartySide;
					break;
				}
				case "LegDeliveryStreamRouteOrCharter":
				{
					value = LegDeliveryStreamRouteOrCharter;
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
			LegDeliveryStreamType = null;
			((IFixReset?)LegDeliveryStreamCommoditySourceGrp)?.Reset();
			LegDeliveryStreamPipeline = null;
			LegDeliveryStreamEntryPoint = null;
			LegDeliveryStreamWithdrawalPoint = null;
			LegDeliveryStreamDeliveryPoint = null;
			LegDeliveryStreamDeliveryPointSource = null;
			LegDeliveryStreamDeliveryPointDesc = null;
			LegDeliveryStreamDeliveryRestriction = null;
			LegDeliveryStreamDeliveryContingency = null;
			LegDeliveryStreamDeliveryContingentPartySide = null;
			LegDeliveryStreamDeliverAtSourceIndicator = null;
			LegDeliveryStreamRiskApportionment = null;
			LegDeliveryStreamRiskApportionmentSource = null;
			((IFixReset?)LegDeliveryStreamCycleGrp)?.Reset();
			LegDeliveryStreamTitleTransferLocation = null;
			LegDeliveryStreamTitleTransferCondition = null;
			LegDeliveryStreamImporterOfRecord = null;
			LegDeliveryStreamNegativeTolerance = null;
			LegDeliveryStreamPositiveTolerance = null;
			LegDeliveryStreamToleranceUnitOfMeasure = null;
			LegDeliveryStreamToleranceType = null;
			LegDeliveryStreamToleranceOptionSide = null;
			LegDeliveryStreamTotalPositiveTolerance = null;
			LegDeliveryStreamTotalNegativeTolerance = null;
			LegDeliveryStreamNotionalConversionFactor = null;
			LegDeliveryStreamTransportEquipment = null;
			LegDeliveryStreamElectingPartySide = null;
			LegDeliveryStreamRouteOrCharter = null;
		}
	}
}
