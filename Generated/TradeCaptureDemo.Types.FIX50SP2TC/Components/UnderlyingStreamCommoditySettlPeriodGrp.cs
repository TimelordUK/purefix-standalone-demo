using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommoditySettlPeriodGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCommoditySettlPeriods : IFixGroup
		{
			[TagDetails(Tag = 42003, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamCommoditySettlCountry {get; set;}
			
			[TagDetails(Tag = 42004, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingStreamCommoditySettlTimeZone {get; set;}
			
			[TagDetails(Tag = 42005, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingStreamCommoditySettlFlowType {get; set;}
			
			[TagDetails(Tag = 42006, Type = TagType.Float, Offset = 3, Required = false)]
			public double? UnderlyingStreamCommoditySettlPeriodNotional {get; set;}
			
			[TagDetails(Tag = 42007, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 42008, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnderlyingStreamCommoditySettlPeriodFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 42009, Type = TagType.String, Offset = 6, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 42010, Type = TagType.Float, Offset = 7, Required = false)]
			public double? UnderlyingStreamCommoditySettlPeriodPrice {get; set;}
			
			[TagDetails(Tag = 42011, Type = TagType.String, Offset = 8, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure {get; set;}
			
			[TagDetails(Tag = 42012, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodPriceCurrency {get; set;}
			
			[TagDetails(Tag = 42013, Type = TagType.Int, Offset = 10, Required = false)]
			public int? UnderlyingStreamCommoditySettlHolidaysProcessingInstruction {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public UnderlyingStreamCommoditySettlDayGrp? UnderlyingStreamCommoditySettlDayGrp {get; set;}
			
			[TagDetails(Tag = 42014, Type = TagType.String, Offset = 12, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodXID {get; set;}
			
			[TagDetails(Tag = 42015, Type = TagType.String, Offset = 13, Required = false)]
			public string? UnderlyingStreamCommoditySettlPeriodXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCommoditySettlCountry is not null) writer.WriteString(42003, UnderlyingStreamCommoditySettlCountry);
				if (UnderlyingStreamCommoditySettlTimeZone is not null) writer.WriteString(42004, UnderlyingStreamCommoditySettlTimeZone);
				if (UnderlyingStreamCommoditySettlFlowType is not null) writer.WriteWholeNumber(42005, UnderlyingStreamCommoditySettlFlowType.Value);
				if (UnderlyingStreamCommoditySettlPeriodNotional is not null) writer.WriteNumber(42006, UnderlyingStreamCommoditySettlPeriodNotional.Value);
				if (UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure is not null) writer.WriteString(42007, UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure);
				if (UnderlyingStreamCommoditySettlPeriodFrequencyPeriod is not null) writer.WriteWholeNumber(42008, UnderlyingStreamCommoditySettlPeriodFrequencyPeriod.Value);
				if (UnderlyingStreamCommoditySettlPeriodFrequencyUnit is not null) writer.WriteString(42009, UnderlyingStreamCommoditySettlPeriodFrequencyUnit);
				if (UnderlyingStreamCommoditySettlPeriodPrice is not null) writer.WriteNumber(42010, UnderlyingStreamCommoditySettlPeriodPrice.Value);
				if (UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure is not null) writer.WriteString(42011, UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure);
				if (UnderlyingStreamCommoditySettlPeriodPriceCurrency is not null) writer.WriteString(42012, UnderlyingStreamCommoditySettlPeriodPriceCurrency);
				if (UnderlyingStreamCommoditySettlHolidaysProcessingInstruction is not null) writer.WriteWholeNumber(42013, UnderlyingStreamCommoditySettlHolidaysProcessingInstruction.Value);
				if (UnderlyingStreamCommoditySettlDayGrp is not null) ((IFixEncoder)UnderlyingStreamCommoditySettlDayGrp).Encode(writer);
				if (UnderlyingStreamCommoditySettlPeriodXID is not null) writer.WriteString(42014, UnderlyingStreamCommoditySettlPeriodXID);
				if (UnderlyingStreamCommoditySettlPeriodXIDRef is not null) writer.WriteString(42015, UnderlyingStreamCommoditySettlPeriodXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCommoditySettlCountry = view.GetString(42003);
				UnderlyingStreamCommoditySettlTimeZone = view.GetString(42004);
				UnderlyingStreamCommoditySettlFlowType = view.GetInt32(42005);
				UnderlyingStreamCommoditySettlPeriodNotional = view.GetDouble(42006);
				UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure = view.GetString(42007);
				UnderlyingStreamCommoditySettlPeriodFrequencyPeriod = view.GetInt32(42008);
				UnderlyingStreamCommoditySettlPeriodFrequencyUnit = view.GetString(42009);
				UnderlyingStreamCommoditySettlPeriodPrice = view.GetDouble(42010);
				UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure = view.GetString(42011);
				UnderlyingStreamCommoditySettlPeriodPriceCurrency = view.GetString(42012);
				UnderlyingStreamCommoditySettlHolidaysProcessingInstruction = view.GetInt32(42013);
				if (view.GetView("UnderlyingStreamCommoditySettlDayGrp") is IMessageView viewUnderlyingStreamCommoditySettlDayGrp)
				{
					UnderlyingStreamCommoditySettlDayGrp = new();
					((IFixParser)UnderlyingStreamCommoditySettlDayGrp).Parse(viewUnderlyingStreamCommoditySettlDayGrp);
				}
				UnderlyingStreamCommoditySettlPeriodXID = view.GetString(42014);
				UnderlyingStreamCommoditySettlPeriodXIDRef = view.GetString(42015);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCommoditySettlCountry":
					{
						value = UnderlyingStreamCommoditySettlCountry;
						break;
					}
					case "UnderlyingStreamCommoditySettlTimeZone":
					{
						value = UnderlyingStreamCommoditySettlTimeZone;
						break;
					}
					case "UnderlyingStreamCommoditySettlFlowType":
					{
						value = UnderlyingStreamCommoditySettlFlowType;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodNotional":
					{
						value = UnderlyingStreamCommoditySettlPeriodNotional;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure":
					{
						value = UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodFrequencyPeriod":
					{
						value = UnderlyingStreamCommoditySettlPeriodFrequencyPeriod;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodFrequencyUnit":
					{
						value = UnderlyingStreamCommoditySettlPeriodFrequencyUnit;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodPrice":
					{
						value = UnderlyingStreamCommoditySettlPeriodPrice;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure":
					{
						value = UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodPriceCurrency":
					{
						value = UnderlyingStreamCommoditySettlPeriodPriceCurrency;
						break;
					}
					case "UnderlyingStreamCommoditySettlHolidaysProcessingInstruction":
					{
						value = UnderlyingStreamCommoditySettlHolidaysProcessingInstruction;
						break;
					}
					case "UnderlyingStreamCommoditySettlDayGrp":
					{
						value = UnderlyingStreamCommoditySettlDayGrp;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodXID":
					{
						value = UnderlyingStreamCommoditySettlPeriodXID;
						break;
					}
					case "UnderlyingStreamCommoditySettlPeriodXIDRef":
					{
						value = UnderlyingStreamCommoditySettlPeriodXIDRef;
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
				UnderlyingStreamCommoditySettlCountry = null;
				UnderlyingStreamCommoditySettlTimeZone = null;
				UnderlyingStreamCommoditySettlFlowType = null;
				UnderlyingStreamCommoditySettlPeriodNotional = null;
				UnderlyingStreamCommoditySettlPeriodNotionalUnitOfMeasure = null;
				UnderlyingStreamCommoditySettlPeriodFrequencyPeriod = null;
				UnderlyingStreamCommoditySettlPeriodFrequencyUnit = null;
				UnderlyingStreamCommoditySettlPeriodPrice = null;
				UnderlyingStreamCommoditySettlPeriodPriceUnitOfMeasure = null;
				UnderlyingStreamCommoditySettlPeriodPriceCurrency = null;
				UnderlyingStreamCommoditySettlHolidaysProcessingInstruction = null;
				((IFixReset?)UnderlyingStreamCommoditySettlDayGrp)?.Reset();
				UnderlyingStreamCommoditySettlPeriodXID = null;
				UnderlyingStreamCommoditySettlPeriodXIDRef = null;
			}
		}
		[Group(NoOfTag = 42002, Offset = 0, Required = false)]
		public NoUnderlyingStreamCommoditySettlPeriods[]? UnderlyingStreamCommoditySettlPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommoditySettlPeriods is not null && UnderlyingStreamCommoditySettlPeriods.Length != 0)
			{
				writer.WriteWholeNumber(42002, UnderlyingStreamCommoditySettlPeriods.Length);
				for (int i = 0; i < UnderlyingStreamCommoditySettlPeriods.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCommoditySettlPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCommoditySettlPeriods") is IMessageView viewNoUnderlyingStreamCommoditySettlPeriods)
			{
				var count = viewNoUnderlyingStreamCommoditySettlPeriods.GroupCount();
				UnderlyingStreamCommoditySettlPeriods = new NoUnderlyingStreamCommoditySettlPeriods[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCommoditySettlPeriods[i] = new();
					((IFixParser)UnderlyingStreamCommoditySettlPeriods[i]).Parse(viewNoUnderlyingStreamCommoditySettlPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCommoditySettlPeriods":
				{
					value = UnderlyingStreamCommoditySettlPeriods;
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
			UnderlyingStreamCommoditySettlPeriods = null;
		}
	}
}
