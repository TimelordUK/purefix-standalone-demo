using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamCommoditySettlPeriodGrp : IFixComponent
	{
		public sealed partial class NoStreamCommoditySettlPeriods : IFixGroup
		{
			[TagDetails(Tag = 41290, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamCommoditySettlCountry {get; set;}
			
			[TagDetails(Tag = 41291, Type = TagType.String, Offset = 1, Required = false)]
			public string? StreamCommoditySettlTimeZone {get; set;}
			
			[TagDetails(Tag = 41292, Type = TagType.Int, Offset = 2, Required = false)]
			public int? StreamCommoditySettlFlowType {get; set;}
			
			[TagDetails(Tag = 41293, Type = TagType.Float, Offset = 3, Required = false)]
			public double? StreamCommoditySettlPeriodNotional {get; set;}
			
			[TagDetails(Tag = 41294, Type = TagType.String, Offset = 4, Required = false)]
			public string? StreamCommoditySettlPeriodNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41295, Type = TagType.Int, Offset = 5, Required = false)]
			public int? StreamCommoditySettlPeriodFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 41296, Type = TagType.String, Offset = 6, Required = false)]
			public string? StreamCommoditySettlPeriodFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 41297, Type = TagType.Float, Offset = 7, Required = false)]
			public double? StreamCommoditySettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 41298, Type = TagType.String, Offset = 8, Required = false)]
			public string? StreamCommoditySettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 41299, Type = TagType.String, Offset = 9, Required = false)]
			public string? StreamCommoditySettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 41300, Type = TagType.Int, Offset = 10, Required = false)]
			public int? StreamCommoditySettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public StreamCommoditySettlDayGrp? StreamCommoditySettlDayGrp {get; set;}
			
			[TagDetails(Tag = 41301, Type = TagType.String, Offset = 12, Required = false)]
			public string? StreamCommoditySettlPeriodXID {get; set;}
			
			[TagDetails(Tag = 41302, Type = TagType.String, Offset = 13, Required = false)]
			public string? StreamCommoditySettlPeriodXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamCommoditySettlCountry is not null) writer.WriteString(41290, StreamCommoditySettlCountry);
				if (StreamCommoditySettlTimeZone is not null) writer.WriteString(41291, StreamCommoditySettlTimeZone);
				if (StreamCommoditySettlFlowType is not null) writer.WriteWholeNumber(41292, StreamCommoditySettlFlowType.Value);
				if (StreamCommoditySettlPeriodNotional is not null) writer.WriteNumber(41293, StreamCommoditySettlPeriodNotional.Value);
				if (StreamCommoditySettlPeriodNotionalUnitOfMeasure is not null) writer.WriteString(41294, StreamCommoditySettlPeriodNotionalUnitOfMeasure);
				if (StreamCommoditySettlPeriodFrequencyPeriod is not null) writer.WriteWholeNumber(41295, StreamCommoditySettlPeriodFrequencyPeriod.Value);
				if (StreamCommoditySettlPeriodFrequencyUnit is not null) writer.WriteString(41296, StreamCommoditySettlPeriodFrequencyUnit);
				if (StreamCommoditySettlPeriodPrice is not null) writer.WriteNumber(41297, StreamCommoditySettlPeriodPrice.Value);
				if (StreamCommoditySettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(41298, StreamCommoditySettlPeriodPriceUnitOfMeasure);
				if (StreamCommoditySettlPeriodPriceCurrency is not null) writer.WriteString(41299, StreamCommoditySettlPeriodPriceCurrency);
				if (StreamCommoditySettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(41300, StreamCommoditySettlHolidaysProcessingInstruction.Value);
				if (StreamCommoditySettlDayGrp is not null) ((IFixEncoder)StreamCommoditySettlDayGrp).Encode(writer);
				if (StreamCommoditySettlPeriodXID is not null) writer.WriteString(41301, StreamCommoditySettlPeriodXID);
				if (StreamCommoditySettlPeriodXIDRef is not null) writer.WriteString(41302, StreamCommoditySettlPeriodXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamCommoditySettlCountry = view.GetString(41290);
				StreamCommoditySettlTimeZone = view.GetString(41291);
				StreamCommoditySettlFlowType = view.GetInt32(41292);
				StreamCommoditySettlPeriodNotional = view.GetDouble(41293);
				StreamCommoditySettlPeriodNotionalUnitOfMeasure = view.GetString(41294);
				StreamCommoditySettlPeriodFrequencyPeriod = view.GetInt32(41295);
				StreamCommoditySettlPeriodFrequencyUnit = view.GetString(41296);
				StreamCommoditySettlPeriodPrice = view.GetDouble(41297);
				StreamCommoditySettlPeriodPriceUnitOfMeasure = view.GetString(41298);
				StreamCommoditySettlPeriodPriceCurrency = view.GetString(41299);
				StreamCommoditySettlHolidaysProcessingInstruction = view.GetInt32(41300);
				if (view.GetView("StreamCommoditySettlDayGrp") is IMessageView viewStreamCommoditySettlDayGrp)
				{
					StreamCommoditySettlDayGrp = new();
					((IFixParser)StreamCommoditySettlDayGrp).Parse(viewStreamCommoditySettlDayGrp);
				}
				StreamCommoditySettlPeriodXID = view.GetString(41301);
				StreamCommoditySettlPeriodXIDRef = view.GetString(41302);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamCommoditySettlCountry":
					{
						value = StreamCommoditySettlCountry;
						break;
					}
					case "StreamCommoditySettlTimeZone":
					{
						value = StreamCommoditySettlTimeZone;
						break;
					}
					case "StreamCommoditySettlFlowType":
					{
						value = StreamCommoditySettlFlowType;
						break;
					}
					case "StreamCommoditySettlPeriodNotional":
					{
						value = StreamCommoditySettlPeriodNotional;
						break;
					}
					case "StreamCommoditySettlPeriodNotionalUnitOfMeasure":
					{
						value = StreamCommoditySettlPeriodNotionalUnitOfMeasure;
						break;
					}
					case "StreamCommoditySettlPeriodFrequencyPeriod":
					{
						value = StreamCommoditySettlPeriodFrequencyPeriod;
						break;
					}
					case "StreamCommoditySettlPeriodFrequencyUnit":
					{
						value = StreamCommoditySettlPeriodFrequencyUnit;
						break;
					}
					case "StreamCommoditySettlPeriodPrice":
					{
						value = StreamCommoditySettlPeriodPrice;
						break;
					}
					case "StreamCommoditySettlPeriodPriceUnitOfMeasure":
					{
						value = StreamCommoditySettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "StreamCommoditySettlPeriodPriceCurrency":
					{
						value = StreamCommoditySettlPeriodPriceCurrency;
						break;
					}
					case "StreamCommoditySettlHolidaysProcessingInstruction":
					{
						value = StreamCommoditySettlHolidaysProcessingInstruction;
						break;
					}
					case "StreamCommoditySettlDayGrp":
					{
						value = StreamCommoditySettlDayGrp;
						break;
					}
					case "StreamCommoditySettlPeriodXID":
					{
						value = StreamCommoditySettlPeriodXID;
						break;
					}
					case "StreamCommoditySettlPeriodXIDRef":
					{
						value = StreamCommoditySettlPeriodXIDRef;
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
				StreamCommoditySettlCountry = null;
				StreamCommoditySettlTimeZone = null;
				StreamCommoditySettlFlowType = null;
				StreamCommoditySettlPeriodNotional = null;
				StreamCommoditySettlPeriodNotionalUnitOfMeasure = null;
				StreamCommoditySettlPeriodFrequencyPeriod = null;
				StreamCommoditySettlPeriodFrequencyUnit = null;
				StreamCommoditySettlPeriodPrice = null;
				StreamCommoditySettlPeriodPriceUnitOfMeasure = null;
				StreamCommoditySettlPeriodPriceCurrency = null;
				StreamCommoditySettlHolidaysProcessingInstruction = null;
				((IFixReset?)StreamCommoditySettlDayGrp)?.Reset();
				StreamCommoditySettlPeriodXID = null;
				StreamCommoditySettlPeriodXIDRef = null;
			}
		}
		[Group(NoOfTag = 41289, Offset = 0, Required = false)]
		public NoStreamCommoditySettlPeriods[]? StreamCommoditySettlPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamCommoditySettlPeriods is not null && StreamCommoditySettlPeriods.Length != 0)
			{
				writer.WriteWholeNumber(41289, StreamCommoditySettlPeriods.Length);
				for (int i = 0; i < StreamCommoditySettlPeriods.Length; i++)
				{
					((IFixEncoder)StreamCommoditySettlPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamCommoditySettlPeriods") is IMessageView viewNoStreamCommoditySettlPeriods)
			{
				var count = viewNoStreamCommoditySettlPeriods.GroupCount();
				StreamCommoditySettlPeriods = new NoStreamCommoditySettlPeriods[count];
				for (int i = 0; i < count; i++)
				{
					StreamCommoditySettlPeriods[i] = new();
					((IFixParser)StreamCommoditySettlPeriods[i]).Parse(viewNoStreamCommoditySettlPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamCommoditySettlPeriods":
				{
					value = StreamCommoditySettlPeriods;
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
			StreamCommoditySettlPeriods = null;
		}
	}
}
