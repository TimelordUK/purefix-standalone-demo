using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDeliveryScheduleGrp : IFixComponent
	{
		public sealed partial class NoLegDeliverySchedules : IFixGroup
		{
			[TagDetails(Tag = 41409, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegDeliveryScheduleType {get; set;}
			
			[TagDetails(Tag = 41410, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegDeliveryScheduleXID {get; set;}
			
			[TagDetails(Tag = 41411, Type = TagType.Float, Offset = 2, Required = false)]
			public double? LegDeliveryScheduleNotional {get; set;}
			
			[TagDetails(Tag = 41412, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegDeliveryScheduleNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41413, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LegDeliveryScheduleNotionalCommodityFrequency {get; set;}
			
			[TagDetails(Tag = 41414, Type = TagType.Float, Offset = 5, Required = false)]
			public double? LegDeliveryScheduleNegativeTolerance {get; set;}
			
			[TagDetails(Tag = 41415, Type = TagType.Float, Offset = 6, Required = false)]
			public double? LegDeliverySchedulePositiveTolerance {get; set;}
			
			[TagDetails(Tag = 41416, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegDeliveryScheduleToleranceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41417, Type = TagType.Int, Offset = 8, Required = false)]
			public int? LegDeliveryScheduleToleranceType {get; set;}
			
			[TagDetails(Tag = 41418, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegDeliveryScheduleSettlCountry {get; set;}
			
			[TagDetails(Tag = 41419, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegDeliveryScheduleSettlTimeZone {get; set;}
			
			[TagDetails(Tag = 41420, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegDeliveryScheduleSettlFlowType {get; set;}
			
			[TagDetails(Tag = 41421, Type = TagType.Int, Offset = 12, Required = false)]
			public int? LegDeliveryScheduleSettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public LegDeliveryScheduleSettlDayGrp? LegDeliveryScheduleSettlDayGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDeliveryScheduleType is not null) writer.WriteWholeNumber(41409, LegDeliveryScheduleType.Value);
				if (LegDeliveryScheduleXID is not null) writer.WriteString(41410, LegDeliveryScheduleXID);
				if (LegDeliveryScheduleNotional is not null) writer.WriteNumber(41411, LegDeliveryScheduleNotional.Value);
				if (LegDeliveryScheduleNotionalUnitOfMeasure is not null) writer.WriteString(41412, LegDeliveryScheduleNotionalUnitOfMeasure);
				if (LegDeliveryScheduleNotionalCommodityFrequency is not null) writer.WriteWholeNumber(41413, LegDeliveryScheduleNotionalCommodityFrequency.Value);
				if (LegDeliveryScheduleNegativeTolerance is not null) writer.WriteNumber(41414, LegDeliveryScheduleNegativeTolerance.Value);
				if (LegDeliverySchedulePositiveTolerance is not null) writer.WriteNumber(41415, LegDeliverySchedulePositiveTolerance.Value);
				if (LegDeliveryScheduleToleranceUnitOfMeasure is not null) writer.WriteString(41416, LegDeliveryScheduleToleranceUnitOfMeasure);
				if (LegDeliveryScheduleToleranceType is not null) writer.WriteWholeNumber(41417, LegDeliveryScheduleToleranceType.Value);
				if (LegDeliveryScheduleSettlCountry is not null) writer.WriteString(41418, LegDeliveryScheduleSettlCountry);
				if (LegDeliveryScheduleSettlTimeZone is not null) writer.WriteString(41419, LegDeliveryScheduleSettlTimeZone);
				if (LegDeliveryScheduleSettlFlowType is not null) writer.WriteWholeNumber(41420, LegDeliveryScheduleSettlFlowType.Value);
				if (LegDeliveryScheduleSettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(41421, LegDeliveryScheduleSettlHolidaysProcessingInstruction.Value);
				if (LegDeliveryScheduleSettlDayGrp is not null) ((IFixEncoder)LegDeliveryScheduleSettlDayGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDeliveryScheduleType = view.GetInt32(41409);
				LegDeliveryScheduleXID = view.GetString(41410);
				LegDeliveryScheduleNotional = view.GetDouble(41411);
				LegDeliveryScheduleNotionalUnitOfMeasure = view.GetString(41412);
				LegDeliveryScheduleNotionalCommodityFrequency = view.GetInt32(41413);
				LegDeliveryScheduleNegativeTolerance = view.GetDouble(41414);
				LegDeliverySchedulePositiveTolerance = view.GetDouble(41415);
				LegDeliveryScheduleToleranceUnitOfMeasure = view.GetString(41416);
				LegDeliveryScheduleToleranceType = view.GetInt32(41417);
				LegDeliveryScheduleSettlCountry = view.GetString(41418);
				LegDeliveryScheduleSettlTimeZone = view.GetString(41419);
				LegDeliveryScheduleSettlFlowType = view.GetInt32(41420);
				LegDeliveryScheduleSettlHolidaysProcessingInstruction = view.GetInt32(41421);
				if (view.GetView("LegDeliveryScheduleSettlDayGrp") is IMessageView viewLegDeliveryScheduleSettlDayGrp)
				{
					LegDeliveryScheduleSettlDayGrp = new();
					((IFixParser)LegDeliveryScheduleSettlDayGrp).Parse(viewLegDeliveryScheduleSettlDayGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDeliveryScheduleType":
					{
						value = LegDeliveryScheduleType;
						break;
					}
					case "LegDeliveryScheduleXID":
					{
						value = LegDeliveryScheduleXID;
						break;
					}
					case "LegDeliveryScheduleNotional":
					{
						value = LegDeliveryScheduleNotional;
						break;
					}
					case "LegDeliveryScheduleNotionalUnitOfMeasure":
					{
						value = LegDeliveryScheduleNotionalUnitOfMeasure;
						break;
					}
					case "LegDeliveryScheduleNotionalCommodityFrequency":
					{
						value = LegDeliveryScheduleNotionalCommodityFrequency;
						break;
					}
					case "LegDeliveryScheduleNegativeTolerance":
					{
						value = LegDeliveryScheduleNegativeTolerance;
						break;
					}
					case "LegDeliverySchedulePositiveTolerance":
					{
						value = LegDeliverySchedulePositiveTolerance;
						break;
					}
					case "LegDeliveryScheduleToleranceUnitOfMeasure":
					{
						value = LegDeliveryScheduleToleranceUnitOfMeasure;
						break;
					}
					case "LegDeliveryScheduleToleranceType":
					{
						value = LegDeliveryScheduleToleranceType;
						break;
					}
					case "LegDeliveryScheduleSettlCountry":
					{
						value = LegDeliveryScheduleSettlCountry;
						break;
					}
					case "LegDeliveryScheduleSettlTimeZone":
					{
						value = LegDeliveryScheduleSettlTimeZone;
						break;
					}
					case "LegDeliveryScheduleSettlFlowType":
					{
						value = LegDeliveryScheduleSettlFlowType;
						break;
					}
					case "LegDeliveryScheduleSettlHolidaysProcessingInstruction":
					{
						value = LegDeliveryScheduleSettlHolidaysProcessingInstruction;
						break;
					}
					case "LegDeliveryScheduleSettlDayGrp":
					{
						value = LegDeliveryScheduleSettlDayGrp;
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
				LegDeliveryScheduleType = null;
				LegDeliveryScheduleXID = null;
				LegDeliveryScheduleNotional = null;
				LegDeliveryScheduleNotionalUnitOfMeasure = null;
				LegDeliveryScheduleNotionalCommodityFrequency = null;
				LegDeliveryScheduleNegativeTolerance = null;
				LegDeliverySchedulePositiveTolerance = null;
				LegDeliveryScheduleToleranceUnitOfMeasure = null;
				LegDeliveryScheduleToleranceType = null;
				LegDeliveryScheduleSettlCountry = null;
				LegDeliveryScheduleSettlTimeZone = null;
				LegDeliveryScheduleSettlFlowType = null;
				LegDeliveryScheduleSettlHolidaysProcessingInstruction = null;
				((IFixReset?)LegDeliveryScheduleSettlDayGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41408, Offset = 0, Required = false)]
		public NoLegDeliverySchedules[]? LegDeliverySchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDeliverySchedules is not null && LegDeliverySchedules.Length != 0)
			{
				writer.WriteWholeNumber(41408, LegDeliverySchedules.Length);
				for (int i = 0; i < LegDeliverySchedules.Length; i++)
				{
					((IFixEncoder)LegDeliverySchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDeliverySchedules") is IMessageView viewNoLegDeliverySchedules)
			{
				var count = viewNoLegDeliverySchedules.GroupCount();
				LegDeliverySchedules = new NoLegDeliverySchedules[count];
				for (int i = 0; i < count; i++)
				{
					LegDeliverySchedules[i] = new();
					((IFixParser)LegDeliverySchedules[i]).Parse(viewNoLegDeliverySchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDeliverySchedules":
				{
					value = LegDeliverySchedules;
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
			LegDeliverySchedules = null;
		}
	}
}
