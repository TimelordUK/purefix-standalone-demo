using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryStream : IFixComponent
	{
		[TagDetails(Tag = 41777, Type = TagType.Int, Offset = 0, Required = false)]
		public int? UnderlyingDeliveryStreamType {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public UnderlyingDeliveryStreamCommoditySourceGrp? UnderlyingDeliveryStreamCommoditySourceGrp {get; set;}
		
		[TagDetails(Tag = 41778, Type = TagType.String, Offset = 2, Required = false)]
		public string? UnderlyingDeliveryStreamPipeline {get; set;}
		
		[TagDetails(Tag = 41779, Type = TagType.String, Offset = 3, Required = false)]
		public string? UnderlyingDeliveryStreamEntryPoint {get; set;}
		
		[TagDetails(Tag = 41780, Type = TagType.String, Offset = 4, Required = false)]
		public string? UnderlyingDeliveryStreamWithdrawalPoint {get; set;}
		
		[TagDetails(Tag = 41781, Type = TagType.String, Offset = 5, Required = false)]
		public string? UnderlyingDeliveryStreamDeliveryPoint {get; set;}
		
		[TagDetails(Tag = 42196, Type = TagType.Int, Offset = 6, Required = false)]
		public int? UnderlyingDeliveryStreamDeliveryPointSource {get; set;}
		
		[TagDetails(Tag = 42197, Type = TagType.String, Offset = 7, Required = false)]
		public string? UnderlyingDeliveryStreamDeliveryPointDesc {get; set;}
		
		[TagDetails(Tag = 41782, Type = TagType.Int, Offset = 8, Required = false)]
		public int? UnderlyingDeliveryStreamDeliveryRestriction {get; set;}
		
		[TagDetails(Tag = 41783, Type = TagType.String, Offset = 9, Required = false)]
		public string? UnderlyingDeliveryStreamDeliveryContingency {get; set;}
		
		[TagDetails(Tag = 41784, Type = TagType.Int, Offset = 10, Required = false)]
		public int? UnderlyingDeliveryStreamDeliveryContingentPartySide {get; set;}
		
		[TagDetails(Tag = 41785, Type = TagType.Boolean, Offset = 11, Required = false)]
		public bool? UnderlyingDeliveryStreamDeliverAtSourceIndicator {get; set;}
		
		[TagDetails(Tag = 41786, Type = TagType.String, Offset = 12, Required = false)]
		public string? UnderlyingDeliveryStreamRiskApportionment {get; set;}
		
		[TagDetails(Tag = 41587, Type = TagType.String, Offset = 13, Required = false)]
		public string? UnderlyingDeliveryStreamRiskApportionmentSource {get; set;}
		
		[Component(Offset = 14, Required = false)]
		public UnderlyingDeliveryStreamCycleGrp? UnderlyingDeliveryStreamCycleGrp {get; set;}
		
		[TagDetails(Tag = 41787, Type = TagType.String, Offset = 15, Required = false)]
		public string? UnderlyingDeliveryStreamTitleTransferLocation {get; set;}
		
		[TagDetails(Tag = 41788, Type = TagType.Int, Offset = 16, Required = false)]
		public int? UnderlyingDeliveryStreamTitleTransferCondition {get; set;}
		
		[TagDetails(Tag = 41789, Type = TagType.String, Offset = 17, Required = false)]
		public string? UnderlyingDeliveryStreamImporterOfRecord {get; set;}
		
		[TagDetails(Tag = 41790, Type = TagType.Float, Offset = 18, Required = false)]
		public double? UnderlyingDeliveryStreamNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41791, Type = TagType.Float, Offset = 19, Required = false)]
		public double? UnderlyingDeliveryStreamPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41792, Type = TagType.String, Offset = 20, Required = false)]
		public string? UnderlyingDeliveryStreamToleranceUnitOfMeasure {get; set;}
		
		[TagDetails(Tag = 41793, Type = TagType.Int, Offset = 21, Required = false)]
		public int? UnderlyingDeliveryStreamToleranceType {get; set;}
		
		[TagDetails(Tag = 41794, Type = TagType.Int, Offset = 22, Required = false)]
		public int? UnderlyingDeliveryStreamToleranceOptionSide {get; set;}
		
		[TagDetails(Tag = 41795, Type = TagType.Float, Offset = 23, Required = false)]
		public double? UnderlyingDeliveryStreamTotalPositiveTolerance {get; set;}
		
		[TagDetails(Tag = 41796, Type = TagType.Float, Offset = 24, Required = false)]
		public double? UnderlyingDeliveryStreamTotalNegativeTolerance {get; set;}
		
		[TagDetails(Tag = 41797, Type = TagType.Float, Offset = 25, Required = false)]
		public double? UnderlyingDeliveryStreamNotionalConversionFactor {get; set;}
		
		[TagDetails(Tag = 41798, Type = TagType.String, Offset = 26, Required = false)]
		public string? UnderlyingDeliveryStreamTransportEquipment {get; set;}
		
		[TagDetails(Tag = 41799, Type = TagType.Int, Offset = 27, Required = false)]
		public int? UnderlyingDeliveryStreamElectingPartySide {get; set;}
		
		[TagDetails(Tag = 43096, Type = TagType.String, Offset = 28, Required = false)]
		public string? UnderlyingDeliveryStreamRouteOrCharter {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliveryStreamType is not null) writer.WriteWholeNumber(41777, UnderlyingDeliveryStreamType.Value);
			if (UnderlyingDeliveryStreamCommoditySourceGrp is not null) ((IFixEncoder)UnderlyingDeliveryStreamCommoditySourceGrp).Encode(writer);
			if (UnderlyingDeliveryStreamPipeline is not null) writer.WriteString(41778, UnderlyingDeliveryStreamPipeline);
			if (UnderlyingDeliveryStreamEntryPoint is not null) writer.WriteString(41779, UnderlyingDeliveryStreamEntryPoint);
			if (UnderlyingDeliveryStreamWithdrawalPoint is not null) writer.WriteString(41780, UnderlyingDeliveryStreamWithdrawalPoint);
			if (UnderlyingDeliveryStreamDeliveryPoint is not null) writer.WriteString(41781, UnderlyingDeliveryStreamDeliveryPoint);
			if (UnderlyingDeliveryStreamDeliveryPointSource is not null) writer.WriteWholeNumber(42196, UnderlyingDeliveryStreamDeliveryPointSource.Value);
			if (UnderlyingDeliveryStreamDeliveryPointDesc is not null) writer.WriteString(42197, UnderlyingDeliveryStreamDeliveryPointDesc);
			if (UnderlyingDeliveryStreamDeliveryRestriction is not null) writer.WriteWholeNumber(41782, UnderlyingDeliveryStreamDeliveryRestriction.Value);
			if (UnderlyingDeliveryStreamDeliveryContingency is not null) writer.WriteString(41783, UnderlyingDeliveryStreamDeliveryContingency);
			if (UnderlyingDeliveryStreamDeliveryContingentPartySide is not null) writer.WriteWholeNumber(41784, UnderlyingDeliveryStreamDeliveryContingentPartySide.Value);
			if (UnderlyingDeliveryStreamDeliverAtSourceIndicator is not null) writer.WriteBoolean(41785, UnderlyingDeliveryStreamDeliverAtSourceIndicator.Value);
			if (UnderlyingDeliveryStreamRiskApportionment is not null) writer.WriteString(41786, UnderlyingDeliveryStreamRiskApportionment);
			if (UnderlyingDeliveryStreamRiskApportionmentSource is not null) writer.WriteString(41587, UnderlyingDeliveryStreamRiskApportionmentSource);
			if (UnderlyingDeliveryStreamCycleGrp is not null) ((IFixEncoder)UnderlyingDeliveryStreamCycleGrp).Encode(writer);
			if (UnderlyingDeliveryStreamTitleTransferLocation is not null) writer.WriteString(41787, UnderlyingDeliveryStreamTitleTransferLocation);
			if (UnderlyingDeliveryStreamTitleTransferCondition is not null) writer.WriteWholeNumber(41788, UnderlyingDeliveryStreamTitleTransferCondition.Value);
			if (UnderlyingDeliveryStreamImporterOfRecord is not null) writer.WriteString(41789, UnderlyingDeliveryStreamImporterOfRecord);
			if (UnderlyingDeliveryStreamNegativeTolerance is not null) writer.WriteNumber(41790, UnderlyingDeliveryStreamNegativeTolerance.Value);
			if (UnderlyingDeliveryStreamPositiveTolerance is not null) writer.WriteNumber(41791, UnderlyingDeliveryStreamPositiveTolerance.Value);
			if (UnderlyingDeliveryStreamToleranceUnitOfMeasure is not null) writer.WriteString(41792, UnderlyingDeliveryStreamToleranceUnitOfMeasure);
			if (UnderlyingDeliveryStreamToleranceType is not null) writer.WriteWholeNumber(41793, UnderlyingDeliveryStreamToleranceType.Value);
			if (UnderlyingDeliveryStreamToleranceOptionSide is not null) writer.WriteWholeNumber(41794, UnderlyingDeliveryStreamToleranceOptionSide.Value);
			if (UnderlyingDeliveryStreamTotalPositiveTolerance is not null) writer.WriteNumber(41795, UnderlyingDeliveryStreamTotalPositiveTolerance.Value);
			if (UnderlyingDeliveryStreamTotalNegativeTolerance is not null) writer.WriteNumber(41796, UnderlyingDeliveryStreamTotalNegativeTolerance.Value);
			if (UnderlyingDeliveryStreamNotionalConversionFactor is not null) writer.WriteNumber(41797, UnderlyingDeliveryStreamNotionalConversionFactor.Value);
			if (UnderlyingDeliveryStreamTransportEquipment is not null) writer.WriteString(41798, UnderlyingDeliveryStreamTransportEquipment);
			if (UnderlyingDeliveryStreamElectingPartySide is not null) writer.WriteWholeNumber(41799, UnderlyingDeliveryStreamElectingPartySide.Value);
			if (UnderlyingDeliveryStreamRouteOrCharter is not null) writer.WriteString(43096, UnderlyingDeliveryStreamRouteOrCharter);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			UnderlyingDeliveryStreamType = view.GetInt32(41777);
			if (view.GetView("UnderlyingDeliveryStreamCommoditySourceGrp") is IMessageView viewUnderlyingDeliveryStreamCommoditySourceGrp)
			{
				UnderlyingDeliveryStreamCommoditySourceGrp = new();
				((IFixParser)UnderlyingDeliveryStreamCommoditySourceGrp).Parse(viewUnderlyingDeliveryStreamCommoditySourceGrp);
			}
			UnderlyingDeliveryStreamPipeline = view.GetString(41778);
			UnderlyingDeliveryStreamEntryPoint = view.GetString(41779);
			UnderlyingDeliveryStreamWithdrawalPoint = view.GetString(41780);
			UnderlyingDeliveryStreamDeliveryPoint = view.GetString(41781);
			UnderlyingDeliveryStreamDeliveryPointSource = view.GetInt32(42196);
			UnderlyingDeliveryStreamDeliveryPointDesc = view.GetString(42197);
			UnderlyingDeliveryStreamDeliveryRestriction = view.GetInt32(41782);
			UnderlyingDeliveryStreamDeliveryContingency = view.GetString(41783);
			UnderlyingDeliveryStreamDeliveryContingentPartySide = view.GetInt32(41784);
			UnderlyingDeliveryStreamDeliverAtSourceIndicator = view.GetBool(41785);
			UnderlyingDeliveryStreamRiskApportionment = view.GetString(41786);
			UnderlyingDeliveryStreamRiskApportionmentSource = view.GetString(41587);
			if (view.GetView("UnderlyingDeliveryStreamCycleGrp") is IMessageView viewUnderlyingDeliveryStreamCycleGrp)
			{
				UnderlyingDeliveryStreamCycleGrp = new();
				((IFixParser)UnderlyingDeliveryStreamCycleGrp).Parse(viewUnderlyingDeliveryStreamCycleGrp);
			}
			UnderlyingDeliveryStreamTitleTransferLocation = view.GetString(41787);
			UnderlyingDeliveryStreamTitleTransferCondition = view.GetInt32(41788);
			UnderlyingDeliveryStreamImporterOfRecord = view.GetString(41789);
			UnderlyingDeliveryStreamNegativeTolerance = view.GetDouble(41790);
			UnderlyingDeliveryStreamPositiveTolerance = view.GetDouble(41791);
			UnderlyingDeliveryStreamToleranceUnitOfMeasure = view.GetString(41792);
			UnderlyingDeliveryStreamToleranceType = view.GetInt32(41793);
			UnderlyingDeliveryStreamToleranceOptionSide = view.GetInt32(41794);
			UnderlyingDeliveryStreamTotalPositiveTolerance = view.GetDouble(41795);
			UnderlyingDeliveryStreamTotalNegativeTolerance = view.GetDouble(41796);
			UnderlyingDeliveryStreamNotionalConversionFactor = view.GetDouble(41797);
			UnderlyingDeliveryStreamTransportEquipment = view.GetString(41798);
			UnderlyingDeliveryStreamElectingPartySide = view.GetInt32(41799);
			UnderlyingDeliveryStreamRouteOrCharter = view.GetString(43096);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "UnderlyingDeliveryStreamType":
				{
					value = UnderlyingDeliveryStreamType;
					break;
				}
				case "UnderlyingDeliveryStreamCommoditySourceGrp":
				{
					value = UnderlyingDeliveryStreamCommoditySourceGrp;
					break;
				}
				case "UnderlyingDeliveryStreamPipeline":
				{
					value = UnderlyingDeliveryStreamPipeline;
					break;
				}
				case "UnderlyingDeliveryStreamEntryPoint":
				{
					value = UnderlyingDeliveryStreamEntryPoint;
					break;
				}
				case "UnderlyingDeliveryStreamWithdrawalPoint":
				{
					value = UnderlyingDeliveryStreamWithdrawalPoint;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryPoint":
				{
					value = UnderlyingDeliveryStreamDeliveryPoint;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryPointSource":
				{
					value = UnderlyingDeliveryStreamDeliveryPointSource;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryPointDesc":
				{
					value = UnderlyingDeliveryStreamDeliveryPointDesc;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryRestriction":
				{
					value = UnderlyingDeliveryStreamDeliveryRestriction;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryContingency":
				{
					value = UnderlyingDeliveryStreamDeliveryContingency;
					break;
				}
				case "UnderlyingDeliveryStreamDeliveryContingentPartySide":
				{
					value = UnderlyingDeliveryStreamDeliveryContingentPartySide;
					break;
				}
				case "UnderlyingDeliveryStreamDeliverAtSourceIndicator":
				{
					value = UnderlyingDeliveryStreamDeliverAtSourceIndicator;
					break;
				}
				case "UnderlyingDeliveryStreamRiskApportionment":
				{
					value = UnderlyingDeliveryStreamRiskApportionment;
					break;
				}
				case "UnderlyingDeliveryStreamRiskApportionmentSource":
				{
					value = UnderlyingDeliveryStreamRiskApportionmentSource;
					break;
				}
				case "UnderlyingDeliveryStreamCycleGrp":
				{
					value = UnderlyingDeliveryStreamCycleGrp;
					break;
				}
				case "UnderlyingDeliveryStreamTitleTransferLocation":
				{
					value = UnderlyingDeliveryStreamTitleTransferLocation;
					break;
				}
				case "UnderlyingDeliveryStreamTitleTransferCondition":
				{
					value = UnderlyingDeliveryStreamTitleTransferCondition;
					break;
				}
				case "UnderlyingDeliveryStreamImporterOfRecord":
				{
					value = UnderlyingDeliveryStreamImporterOfRecord;
					break;
				}
				case "UnderlyingDeliveryStreamNegativeTolerance":
				{
					value = UnderlyingDeliveryStreamNegativeTolerance;
					break;
				}
				case "UnderlyingDeliveryStreamPositiveTolerance":
				{
					value = UnderlyingDeliveryStreamPositiveTolerance;
					break;
				}
				case "UnderlyingDeliveryStreamToleranceUnitOfMeasure":
				{
					value = UnderlyingDeliveryStreamToleranceUnitOfMeasure;
					break;
				}
				case "UnderlyingDeliveryStreamToleranceType":
				{
					value = UnderlyingDeliveryStreamToleranceType;
					break;
				}
				case "UnderlyingDeliveryStreamToleranceOptionSide":
				{
					value = UnderlyingDeliveryStreamToleranceOptionSide;
					break;
				}
				case "UnderlyingDeliveryStreamTotalPositiveTolerance":
				{
					value = UnderlyingDeliveryStreamTotalPositiveTolerance;
					break;
				}
				case "UnderlyingDeliveryStreamTotalNegativeTolerance":
				{
					value = UnderlyingDeliveryStreamTotalNegativeTolerance;
					break;
				}
				case "UnderlyingDeliveryStreamNotionalConversionFactor":
				{
					value = UnderlyingDeliveryStreamNotionalConversionFactor;
					break;
				}
				case "UnderlyingDeliveryStreamTransportEquipment":
				{
					value = UnderlyingDeliveryStreamTransportEquipment;
					break;
				}
				case "UnderlyingDeliveryStreamElectingPartySide":
				{
					value = UnderlyingDeliveryStreamElectingPartySide;
					break;
				}
				case "UnderlyingDeliveryStreamRouteOrCharter":
				{
					value = UnderlyingDeliveryStreamRouteOrCharter;
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
			UnderlyingDeliveryStreamType = null;
			((IFixReset?)UnderlyingDeliveryStreamCommoditySourceGrp)?.Reset();
			UnderlyingDeliveryStreamPipeline = null;
			UnderlyingDeliveryStreamEntryPoint = null;
			UnderlyingDeliveryStreamWithdrawalPoint = null;
			UnderlyingDeliveryStreamDeliveryPoint = null;
			UnderlyingDeliveryStreamDeliveryPointSource = null;
			UnderlyingDeliveryStreamDeliveryPointDesc = null;
			UnderlyingDeliveryStreamDeliveryRestriction = null;
			UnderlyingDeliveryStreamDeliveryContingency = null;
			UnderlyingDeliveryStreamDeliveryContingentPartySide = null;
			UnderlyingDeliveryStreamDeliverAtSourceIndicator = null;
			UnderlyingDeliveryStreamRiskApportionment = null;
			UnderlyingDeliveryStreamRiskApportionmentSource = null;
			((IFixReset?)UnderlyingDeliveryStreamCycleGrp)?.Reset();
			UnderlyingDeliveryStreamTitleTransferLocation = null;
			UnderlyingDeliveryStreamTitleTransferCondition = null;
			UnderlyingDeliveryStreamImporterOfRecord = null;
			UnderlyingDeliveryStreamNegativeTolerance = null;
			UnderlyingDeliveryStreamPositiveTolerance = null;
			UnderlyingDeliveryStreamToleranceUnitOfMeasure = null;
			UnderlyingDeliveryStreamToleranceType = null;
			UnderlyingDeliveryStreamToleranceOptionSide = null;
			UnderlyingDeliveryStreamTotalPositiveTolerance = null;
			UnderlyingDeliveryStreamTotalNegativeTolerance = null;
			UnderlyingDeliveryStreamNotionalConversionFactor = null;
			UnderlyingDeliveryStreamTransportEquipment = null;
			UnderlyingDeliveryStreamElectingPartySide = null;
			UnderlyingDeliveryStreamRouteOrCharter = null;
		}
	}
}
