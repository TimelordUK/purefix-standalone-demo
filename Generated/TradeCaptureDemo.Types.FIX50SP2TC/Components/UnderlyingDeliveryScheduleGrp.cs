using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDeliveryScheduleGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDeliverySchedules : IFixGroup
		{
			[TagDetails(Tag = 41757, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingDeliveryScheduleType {get; set;}
			
			[TagDetails(Tag = 41758, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingDeliveryScheduleXID {get; set;}
			
			[TagDetails(Tag = 41759, Type = TagType.Float, Offset = 2, Required = false)]
			public double? UnderlyingDeliveryScheduleNotional {get; set;}
			
			[TagDetails(Tag = 41760, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingDeliveryScheduleNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41761, Type = TagType.Int, Offset = 4, Required = false)]
			public int? UnderlyingDeliveryScheduleNotionalCommodityFrequency {get; set;}
			
			[TagDetails(Tag = 41762, Type = TagType.Float, Offset = 5, Required = false)]
			public double? UnderlyingDeliveryScheduleNegativeTolerance {get; set;}
			
			[TagDetails(Tag = 41763, Type = TagType.Float, Offset = 6, Required = false)]
			public double? UnderlyingDeliverySchedulePositiveTolerance {get; set;}
			
			[TagDetails(Tag = 41764, Type = TagType.String, Offset = 7, Required = false)]
			public string? UnderlyingDeliveryScheduleToleranceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41765, Type = TagType.Int, Offset = 8, Required = false)]
			public int? UnderlyingDeliveryScheduleToleranceType {get; set;}
			
			[TagDetails(Tag = 41766, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingDeliveryScheduleSettlCountry {get; set;}
			
			[TagDetails(Tag = 41767, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingDeliveryScheduleSettlTimeZone {get; set;}
			
			[TagDetails(Tag = 41768, Type = TagType.Int, Offset = 11, Required = false)]
			public int? UnderlyingDeliveryScheduleSettlFlowType {get; set;}
			
			[TagDetails(Tag = 41769, Type = TagType.Int, Offset = 12, Required = false)]
			public int? UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public UnderlyingDeliveryScheduleSettlDayGrp? UnderlyingDeliveryScheduleSettlDayGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDeliveryScheduleType is not null) writer.WriteWholeNumber(41757, UnderlyingDeliveryScheduleType.Value);
				if (UnderlyingDeliveryScheduleXID is not null) writer.WriteString(41758, UnderlyingDeliveryScheduleXID);
				if (UnderlyingDeliveryScheduleNotional is not null) writer.WriteNumber(41759, UnderlyingDeliveryScheduleNotional.Value);
				if (UnderlyingDeliveryScheduleNotionalUnitOfMeasure is not null) writer.WriteString(41760, UnderlyingDeliveryScheduleNotionalUnitOfMeasure);
				if (UnderlyingDeliveryScheduleNotionalCommodityFrequency is not null) writer.WriteWholeNumber(41761, UnderlyingDeliveryScheduleNotionalCommodityFrequency.Value);
				if (UnderlyingDeliveryScheduleNegativeTolerance is not null) writer.WriteNumber(41762, UnderlyingDeliveryScheduleNegativeTolerance.Value);
				if (UnderlyingDeliverySchedulePositiveTolerance is not null) writer.WriteNumber(41763, UnderlyingDeliverySchedulePositiveTolerance.Value);
				if (UnderlyingDeliveryScheduleToleranceUnitOfMeasure is not null) writer.WriteString(41764, UnderlyingDeliveryScheduleToleranceUnitOfMeasure);
				if (UnderlyingDeliveryScheduleToleranceType is not null) writer.WriteWholeNumber(41765, UnderlyingDeliveryScheduleToleranceType.Value);
				if (UnderlyingDeliveryScheduleSettlCountry is not null) writer.WriteString(41766, UnderlyingDeliveryScheduleSettlCountry);
				if (UnderlyingDeliveryScheduleSettlTimeZone is not null) writer.WriteString(41767, UnderlyingDeliveryScheduleSettlTimeZone);
				if (UnderlyingDeliveryScheduleSettlFlowType is not null) writer.WriteWholeNumber(41768, UnderlyingDeliveryScheduleSettlFlowType.Value);
				if (UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(41769, UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction.Value);
				if (UnderlyingDeliveryScheduleSettlDayGrp is not null) ((IFixEncoder)UnderlyingDeliveryScheduleSettlDayGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDeliveryScheduleType = view.GetInt32(41757);
				UnderlyingDeliveryScheduleXID = view.GetString(41758);
				UnderlyingDeliveryScheduleNotional = view.GetDouble(41759);
				UnderlyingDeliveryScheduleNotionalUnitOfMeasure = view.GetString(41760);
				UnderlyingDeliveryScheduleNotionalCommodityFrequency = view.GetInt32(41761);
				UnderlyingDeliveryScheduleNegativeTolerance = view.GetDouble(41762);
				UnderlyingDeliverySchedulePositiveTolerance = view.GetDouble(41763);
				UnderlyingDeliveryScheduleToleranceUnitOfMeasure = view.GetString(41764);
				UnderlyingDeliveryScheduleToleranceType = view.GetInt32(41765);
				UnderlyingDeliveryScheduleSettlCountry = view.GetString(41766);
				UnderlyingDeliveryScheduleSettlTimeZone = view.GetString(41767);
				UnderlyingDeliveryScheduleSettlFlowType = view.GetInt32(41768);
				UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction = view.GetInt32(41769);
				if (view.GetView("UnderlyingDeliveryScheduleSettlDayGrp") is IMessageView viewUnderlyingDeliveryScheduleSettlDayGrp)
				{
					UnderlyingDeliveryScheduleSettlDayGrp = new();
					((IFixParser)UnderlyingDeliveryScheduleSettlDayGrp).Parse(viewUnderlyingDeliveryScheduleSettlDayGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDeliveryScheduleType":
					{
						value = UnderlyingDeliveryScheduleType;
						break;
					}
					case "UnderlyingDeliveryScheduleXID":
					{
						value = UnderlyingDeliveryScheduleXID;
						break;
					}
					case "UnderlyingDeliveryScheduleNotional":
					{
						value = UnderlyingDeliveryScheduleNotional;
						break;
					}
					case "UnderlyingDeliveryScheduleNotionalUnitOfMeasure":
					{
						value = UnderlyingDeliveryScheduleNotionalUnitOfMeasure;
						break;
					}
					case "UnderlyingDeliveryScheduleNotionalCommodityFrequency":
					{
						value = UnderlyingDeliveryScheduleNotionalCommodityFrequency;
						break;
					}
					case "UnderlyingDeliveryScheduleNegativeTolerance":
					{
						value = UnderlyingDeliveryScheduleNegativeTolerance;
						break;
					}
					case "UnderlyingDeliverySchedulePositiveTolerance":
					{
						value = UnderlyingDeliverySchedulePositiveTolerance;
						break;
					}
					case "UnderlyingDeliveryScheduleToleranceUnitOfMeasure":
					{
						value = UnderlyingDeliveryScheduleToleranceUnitOfMeasure;
						break;
					}
					case "UnderlyingDeliveryScheduleToleranceType":
					{
						value = UnderlyingDeliveryScheduleToleranceType;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlCountry":
					{
						value = UnderlyingDeliveryScheduleSettlCountry;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlTimeZone":
					{
						value = UnderlyingDeliveryScheduleSettlTimeZone;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlFlowType":
					{
						value = UnderlyingDeliveryScheduleSettlFlowType;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction":
					{
						value = UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction;
						break;
					}
					case "UnderlyingDeliveryScheduleSettlDayGrp":
					{
						value = UnderlyingDeliveryScheduleSettlDayGrp;
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
				UnderlyingDeliveryScheduleType = null;
				UnderlyingDeliveryScheduleXID = null;
				UnderlyingDeliveryScheduleNotional = null;
				UnderlyingDeliveryScheduleNotionalUnitOfMeasure = null;
				UnderlyingDeliveryScheduleNotionalCommodityFrequency = null;
				UnderlyingDeliveryScheduleNegativeTolerance = null;
				UnderlyingDeliverySchedulePositiveTolerance = null;
				UnderlyingDeliveryScheduleToleranceUnitOfMeasure = null;
				UnderlyingDeliveryScheduleToleranceType = null;
				UnderlyingDeliveryScheduleSettlCountry = null;
				UnderlyingDeliveryScheduleSettlTimeZone = null;
				UnderlyingDeliveryScheduleSettlFlowType = null;
				UnderlyingDeliveryScheduleSettlHolidaysProcessingInstruction = null;
				((IFixReset?)UnderlyingDeliveryScheduleSettlDayGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41756, Offset = 0, Required = false)]
		public NoUnderlyingDeliverySchedules[]? UnderlyingDeliverySchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDeliverySchedules is not null && UnderlyingDeliverySchedules.Length != 0)
			{
				writer.WriteWholeNumber(41756, UnderlyingDeliverySchedules.Length);
				for (int i = 0; i < UnderlyingDeliverySchedules.Length; i++)
				{
					((IFixEncoder)UnderlyingDeliverySchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDeliverySchedules") is IMessageView viewNoUnderlyingDeliverySchedules)
			{
				var count = viewNoUnderlyingDeliverySchedules.GroupCount();
				UnderlyingDeliverySchedules = new NoUnderlyingDeliverySchedules[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDeliverySchedules[i] = new();
					((IFixParser)UnderlyingDeliverySchedules[i]).Parse(viewNoUnderlyingDeliverySchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDeliverySchedules":
				{
					value = UnderlyingDeliverySchedules;
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
			UnderlyingDeliverySchedules = null;
		}
	}
}
