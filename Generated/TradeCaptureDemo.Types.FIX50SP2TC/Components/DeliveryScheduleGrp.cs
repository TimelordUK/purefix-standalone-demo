using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DeliveryScheduleGrp : IFixComponent
	{
		public sealed partial class NoDeliverySchedules : IFixGroup
		{
			[TagDetails(Tag = 41038, Type = TagType.Int, Offset = 0, Required = false)]
			public int? DeliveryScheduleType {get; set;}
			
			[TagDetails(Tag = 41039, Type = TagType.String, Offset = 1, Required = false)]
			public string? DeliveryScheduleXID {get; set;}
			
			[TagDetails(Tag = 41040, Type = TagType.Float, Offset = 2, Required = false)]
			public double? DeliveryScheduleNotional {get; set;}
			
			[TagDetails(Tag = 41041, Type = TagType.String, Offset = 3, Required = false)]
			public string? DeliveryScheduleNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41042, Type = TagType.Int, Offset = 4, Required = false)]
			public int? DeliveryScheduleNotionalCommodityFrequency {get; set;}
			
			[TagDetails(Tag = 41043, Type = TagType.Float, Offset = 5, Required = false)]
			public double? DeliveryScheduleNegativeTolerance {get; set;}
			
			[TagDetails(Tag = 41044, Type = TagType.Float, Offset = 6, Required = false)]
			public double? DeliverySchedulePositiveTolerance {get; set;}
			
			[TagDetails(Tag = 41045, Type = TagType.String, Offset = 7, Required = false)]
			public string? DeliveryScheduleToleranceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41046, Type = TagType.Int, Offset = 8, Required = false)]
			public int? DeliveryScheduleToleranceType {get; set;}
			
			[TagDetails(Tag = 41047, Type = TagType.String, Offset = 9, Required = false)]
			public string? DeliveryScheduleSettlCountry {get; set;}
			
			[TagDetails(Tag = 41048, Type = TagType.String, Offset = 10, Required = false)]
			public string? DeliveryScheduleSettlTimeZone {get; set;}
			
			[TagDetails(Tag = 41049, Type = TagType.Int, Offset = 11, Required = false)]
			public int? DeliveryScheduleSettlFlowType {get; set;}
			
			[TagDetails(Tag = 41050, Type = TagType.Int, Offset = 12, Required = false)]
			public int? DeliveryScheduleSettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public DeliveryScheduleSettlDayGrp? DeliveryScheduleSettlDayGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DeliveryScheduleType is not null) writer.WriteWholeNumber(41038, DeliveryScheduleType.Value);
				if (DeliveryScheduleXID is not null) writer.WriteString(41039, DeliveryScheduleXID);
				if (DeliveryScheduleNotional is not null) writer.WriteNumber(41040, DeliveryScheduleNotional.Value);
				if (DeliveryScheduleNotionalUnitOfMeasure is not null) writer.WriteString(41041, DeliveryScheduleNotionalUnitOfMeasure);
				if (DeliveryScheduleNotionalCommodityFrequency is not null) writer.WriteWholeNumber(41042, DeliveryScheduleNotionalCommodityFrequency.Value);
				if (DeliveryScheduleNegativeTolerance is not null) writer.WriteNumber(41043, DeliveryScheduleNegativeTolerance.Value);
				if (DeliverySchedulePositiveTolerance is not null) writer.WriteNumber(41044, DeliverySchedulePositiveTolerance.Value);
				if (DeliveryScheduleToleranceUnitOfMeasure is not null) writer.WriteString(41045, DeliveryScheduleToleranceUnitOfMeasure);
				if (DeliveryScheduleToleranceType is not null) writer.WriteWholeNumber(41046, DeliveryScheduleToleranceType.Value);
				if (DeliveryScheduleSettlCountry is not null) writer.WriteString(41047, DeliveryScheduleSettlCountry);
				if (DeliveryScheduleSettlTimeZone is not null) writer.WriteString(41048, DeliveryScheduleSettlTimeZone);
				if (DeliveryScheduleSettlFlowType is not null) writer.WriteWholeNumber(41049, DeliveryScheduleSettlFlowType.Value);
				if (DeliveryScheduleSettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(41050, DeliveryScheduleSettlHolidaysProcessingInstruction.Value);
				if (DeliveryScheduleSettlDayGrp is not null) ((IFixEncoder)DeliveryScheduleSettlDayGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DeliveryScheduleType = view.GetInt32(41038);
				DeliveryScheduleXID = view.GetString(41039);
				DeliveryScheduleNotional = view.GetDouble(41040);
				DeliveryScheduleNotionalUnitOfMeasure = view.GetString(41041);
				DeliveryScheduleNotionalCommodityFrequency = view.GetInt32(41042);
				DeliveryScheduleNegativeTolerance = view.GetDouble(41043);
				DeliverySchedulePositiveTolerance = view.GetDouble(41044);
				DeliveryScheduleToleranceUnitOfMeasure = view.GetString(41045);
				DeliveryScheduleToleranceType = view.GetInt32(41046);
				DeliveryScheduleSettlCountry = view.GetString(41047);
				DeliveryScheduleSettlTimeZone = view.GetString(41048);
				DeliveryScheduleSettlFlowType = view.GetInt32(41049);
				DeliveryScheduleSettlHolidaysProcessingInstruction = view.GetInt32(41050);
				if (view.GetView("DeliveryScheduleSettlDayGrp") is IMessageView viewDeliveryScheduleSettlDayGrp)
				{
					DeliveryScheduleSettlDayGrp = new();
					((IFixParser)DeliveryScheduleSettlDayGrp).Parse(viewDeliveryScheduleSettlDayGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DeliveryScheduleType":
					{
						value = DeliveryScheduleType;
						break;
					}
					case "DeliveryScheduleXID":
					{
						value = DeliveryScheduleXID;
						break;
					}
					case "DeliveryScheduleNotional":
					{
						value = DeliveryScheduleNotional;
						break;
					}
					case "DeliveryScheduleNotionalUnitOfMeasure":
					{
						value = DeliveryScheduleNotionalUnitOfMeasure;
						break;
					}
					case "DeliveryScheduleNotionalCommodityFrequency":
					{
						value = DeliveryScheduleNotionalCommodityFrequency;
						break;
					}
					case "DeliveryScheduleNegativeTolerance":
					{
						value = DeliveryScheduleNegativeTolerance;
						break;
					}
					case "DeliverySchedulePositiveTolerance":
					{
						value = DeliverySchedulePositiveTolerance;
						break;
					}
					case "DeliveryScheduleToleranceUnitOfMeasure":
					{
						value = DeliveryScheduleToleranceUnitOfMeasure;
						break;
					}
					case "DeliveryScheduleToleranceType":
					{
						value = DeliveryScheduleToleranceType;
						break;
					}
					case "DeliveryScheduleSettlCountry":
					{
						value = DeliveryScheduleSettlCountry;
						break;
					}
					case "DeliveryScheduleSettlTimeZone":
					{
						value = DeliveryScheduleSettlTimeZone;
						break;
					}
					case "DeliveryScheduleSettlFlowType":
					{
						value = DeliveryScheduleSettlFlowType;
						break;
					}
					case "DeliveryScheduleSettlHolidaysProcessingInstruction":
					{
						value = DeliveryScheduleSettlHolidaysProcessingInstruction;
						break;
					}
					case "DeliveryScheduleSettlDayGrp":
					{
						value = DeliveryScheduleSettlDayGrp;
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
				DeliveryScheduleType = null;
				DeliveryScheduleXID = null;
				DeliveryScheduleNotional = null;
				DeliveryScheduleNotionalUnitOfMeasure = null;
				DeliveryScheduleNotionalCommodityFrequency = null;
				DeliveryScheduleNegativeTolerance = null;
				DeliverySchedulePositiveTolerance = null;
				DeliveryScheduleToleranceUnitOfMeasure = null;
				DeliveryScheduleToleranceType = null;
				DeliveryScheduleSettlCountry = null;
				DeliveryScheduleSettlTimeZone = null;
				DeliveryScheduleSettlFlowType = null;
				DeliveryScheduleSettlHolidaysProcessingInstruction = null;
				((IFixReset?)DeliveryScheduleSettlDayGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 41037, Offset = 0, Required = false)]
		public NoDeliverySchedules[]? DeliverySchedules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DeliverySchedules is not null && DeliverySchedules.Length != 0)
			{
				writer.WriteWholeNumber(41037, DeliverySchedules.Length);
				for (int i = 0; i < DeliverySchedules.Length; i++)
				{
					((IFixEncoder)DeliverySchedules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDeliverySchedules") is IMessageView viewNoDeliverySchedules)
			{
				var count = viewNoDeliverySchedules.GroupCount();
				DeliverySchedules = new NoDeliverySchedules[count];
				for (int i = 0; i < count; i++)
				{
					DeliverySchedules[i] = new();
					((IFixParser)DeliverySchedules[i]).Parse(viewNoDeliverySchedules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDeliverySchedules":
				{
					value = DeliverySchedules;
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
			DeliverySchedules = null;
		}
	}
}
