using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegStreamCommoditySettlPeriodGrp : IFixComponent
	{
		public sealed partial class NoLegStreamCommoditySettlPeriods : IFixGroup
		{
			[TagDetails(Tag = 41687, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegStreamCommoditySettlCountry {get; set;}
			
			[TagDetails(Tag = 41688, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegStreamCommoditySettlTimeZone {get; set;}
			
			[TagDetails(Tag = 41689, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegStreamCommoditySettlFlowType {get; set;}
			
			[TagDetails(Tag = 41690, Type = TagType.Float, Offset = 3, Required = false)]
			public double? LegStreamCommoditySettlPeriodNotional {get; set;}
			
			[TagDetails(Tag = 41691, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegStreamCommoditySettlPeriodNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41692, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegStreamCommoditySettlPeriodFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41693, Type = TagType.String, Offset = 6, Required = false)]
			public string? LegStreamCommoditySettlPeriodFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41694, Type = TagType.Float, Offset = 7, Required = false)]
			public double? LegStreamCommoditySettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 41695, Type = TagType.String, Offset = 8, Required = false)]
			public string? LegStreamCommoditySettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41696, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegStreamCommoditySettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 41697, Type = TagType.Int, Offset = 10, Required = false)]
			public int? LegStreamCommoditySettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public LegStreamCommoditySettlDayGrp? LegStreamCommoditySettlDayGrp {get; set;}
			
			[TagDetails(Tag = 41698, Type = TagType.String, Offset = 12, Required = false)]
			public string? LegStreamCommoditySettlPeriodXID {get; set;}
			
			[TagDetails(Tag = 41699, Type = TagType.String, Offset = 13, Required = false)]
			public string? LegStreamCommoditySettlPeriodXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegStreamCommoditySettlCountry is not null) writer.WriteString(41687, LegStreamCommoditySettlCountry);
				if (LegStreamCommoditySettlTimeZone is not null) writer.WriteString(41688, LegStreamCommoditySettlTimeZone);
				if (LegStreamCommoditySettlFlowType is not null) writer.WriteWholeNumber(41689, LegStreamCommoditySettlFlowType.Value);
				if (LegStreamCommoditySettlPeriodNotional is not null) writer.WriteNumber(41690, LegStreamCommoditySettlPeriodNotional.Value);
				if (LegStreamCommoditySettlPeriodNotionalUnitOfMeasure is not null) writer.WriteString(41691, LegStreamCommoditySettlPeriodNotionalUnitOfMeasure);
				if (LegStreamCommoditySettlPeriodFrequencyPeriod is not null) writer.WriteWholeNumber(41692, LegStreamCommoditySettlPeriodFrequencyPeriod.Value);
				if (LegStreamCommoditySettlPeriodFrequencyUnit is not null) writer.WriteString(41693, LegStreamCommoditySettlPeriodFrequencyUnit);
				if (LegStreamCommoditySettlPeriodPrice is not null) writer.WriteNumber(41694, LegStreamCommoditySettlPeriodPrice.Value);
				if (LegStreamCommoditySettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(41695, LegStreamCommoditySettlPeriodPriceUnitOfMeasure);
				if (LegStreamCommoditySettlPeriodPriceCurrency is not null) writer.WriteString(41696, LegStreamCommoditySettlPeriodPriceCurrency);
				if (LegStreamCommoditySettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(41697, LegStreamCommoditySettlHolidaysProcessingInstruction.Value);
				if (LegStreamCommoditySettlDayGrp is not null) ((IFixEncoder)LegStreamCommoditySettlDayGrp).Encode(writer);
				if (LegStreamCommoditySettlPeriodXID is not null) writer.WriteString(41698, LegStreamCommoditySettlPeriodXID);
				if (LegStreamCommoditySettlPeriodXIDRef is not null) writer.WriteString(41699, LegStreamCommoditySettlPeriodXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegStreamCommoditySettlCountry = view.GetString(41687);
				LegStreamCommoditySettlTimeZone = view.GetString(41688);
				LegStreamCommoditySettlFlowType = view.GetInt32(41689);
				LegStreamCommoditySettlPeriodNotional = view.GetDouble(41690);
				LegStreamCommoditySettlPeriodNotionalUnitOfMeasure = view.GetString(41691);
				LegStreamCommoditySettlPeriodFrequencyPeriod = view.GetInt32(41692);
				LegStreamCommoditySettlPeriodFrequencyUnit = view.GetString(41693);
				LegStreamCommoditySettlPeriodPrice = view.GetDouble(41694);
				LegStreamCommoditySettlPeriodPriceUnitOfMeasure = view.GetString(41695);
				LegStreamCommoditySettlPeriodPriceCurrency = view.GetString(41696);
				LegStreamCommoditySettlHolidaysProcessingInstruction = view.GetInt32(41697);
				if (view.GetView("LegStreamCommoditySettlDayGrp") is IMessageView viewLegStreamCommoditySettlDayGrp)
				{
					LegStreamCommoditySettlDayGrp = new();
					((IFixParser)LegStreamCommoditySettlDayGrp).Parse(viewLegStreamCommoditySettlDayGrp);
				}
				LegStreamCommoditySettlPeriodXID = view.GetString(41698);
				LegStreamCommoditySettlPeriodXIDRef = view.GetString(41699);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegStreamCommoditySettlCountry":
					{
						value = LegStreamCommoditySettlCountry;
						break;
					}
					case "LegStreamCommoditySettlTimeZone":
					{
						value = LegStreamCommoditySettlTimeZone;
						break;
					}
					case "LegStreamCommoditySettlFlowType":
					{
						value = LegStreamCommoditySettlFlowType;
						break;
					}
					case "LegStreamCommoditySettlPeriodNotional":
					{
						value = LegStreamCommoditySettlPeriodNotional;
						break;
					}
					case "LegStreamCommoditySettlPeriodNotionalUnitOfMeasure":
					{
						value = LegStreamCommoditySettlPeriodNotionalUnitOfMeasure;
						break;
					}
					case "LegStreamCommoditySettlPeriodFrequencyPeriod":
					{
						value = LegStreamCommoditySettlPeriodFrequencyPeriod;
						break;
					}
					case "LegStreamCommoditySettlPeriodFrequencyUnit":
					{
						value = LegStreamCommoditySettlPeriodFrequencyUnit;
						break;
					}
					case "LegStreamCommoditySettlPeriodPrice":
					{
						value = LegStreamCommoditySettlPeriodPrice;
						break;
					}
					case "LegStreamCommoditySettlPeriodPriceUnitOfMeasure":
					{
						value = LegStreamCommoditySettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "LegStreamCommoditySettlPeriodPriceCurrency":
					{
						value = LegStreamCommoditySettlPeriodPriceCurrency;
						break;
					}
					case "LegStreamCommoditySettlHolidaysProcessingInstruction":
					{
						value = LegStreamCommoditySettlHolidaysProcessingInstruction;
						break;
					}
					case "LegStreamCommoditySettlDayGrp":
					{
						value = LegStreamCommoditySettlDayGrp;
						break;
					}
					case "LegStreamCommoditySettlPeriodXID":
					{
						value = LegStreamCommoditySettlPeriodXID;
						break;
					}
					case "LegStreamCommoditySettlPeriodXIDRef":
					{
						value = LegStreamCommoditySettlPeriodXIDRef;
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
				LegStreamCommoditySettlCountry = null;
				LegStreamCommoditySettlTimeZone = null;
				LegStreamCommoditySettlFlowType = null;
				LegStreamCommoditySettlPeriodNotional = null;
				LegStreamCommoditySettlPeriodNotionalUnitOfMeasure = null;
				LegStreamCommoditySettlPeriodFrequencyPeriod = null;
				LegStreamCommoditySettlPeriodFrequencyUnit = null;
				LegStreamCommoditySettlPeriodPrice = null;
				LegStreamCommoditySettlPeriodPriceUnitOfMeasure = null;
				LegStreamCommoditySettlPeriodPriceCurrency = null;
				LegStreamCommoditySettlHolidaysProcessingInstruction = null;
				((IFixReset?)LegStreamCommoditySettlDayGrp)?.Reset();
				LegStreamCommoditySettlPeriodXID = null;
				LegStreamCommoditySettlPeriodXIDRef = null;
			}
		}
		[Group(NoOfTag = 41686, Offset = 0, Required = false)]
		public NoLegStreamCommoditySettlPeriods[]? LegStreamCommoditySettlPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegStreamCommoditySettlPeriods is not null && LegStreamCommoditySettlPeriods.Length != 0)
			{
				writer.WriteWholeNumber(41686, LegStreamCommoditySettlPeriods.Length);
				for (int i = 0; i < LegStreamCommoditySettlPeriods.Length; i++)
				{
					((IFixEncoder)LegStreamCommoditySettlPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegStreamCommoditySettlPeriods") is IMessageView viewNoLegStreamCommoditySettlPeriods)
			{
				var count = viewNoLegStreamCommoditySettlPeriods.GroupCount();
				LegStreamCommoditySettlPeriods = new NoLegStreamCommoditySettlPeriods[count];
				for (int i = 0; i < count; i++)
				{
					LegStreamCommoditySettlPeriods[i] = new();
					((IFixParser)LegStreamCommoditySettlPeriods[i]).Parse(viewNoLegStreamCommoditySettlPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegStreamCommoditySettlPeriods":
				{
					value = LegStreamCommoditySettlPeriods;
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
			LegStreamCommoditySettlPeriods = null;
		}
	}
}
