using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegDividendPeriodGrp : IFixComponent
	{
		public sealed partial class NoLegDividendPeriods : IFixGroup
		{
			[TagDetails(Tag = 42367, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegDividendPeriodSequence {get; set;}
			
			[TagDetails(Tag = 42368, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? LegDividendPeriodStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42369, Type = TagType.LocalDate, Offset = 2, Required = false)]
			public DateOnly? LegDividendPeriodEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42370, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegDividendPeriodUnderlierRefID {get; set;}
			
			[TagDetails(Tag = 42371, Type = TagType.Float, Offset = 4, Required = false)]
			public double? LegDividendPeriodStrikePrice {get; set;}
			
			[TagDetails(Tag = 42372, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegDividendPeriodBusinessDayConvention {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public LegDividendPeriodBusinessCenterGrp? LegDividendPeriodBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 42373, Type = TagType.LocalDate, Offset = 7, Required = false)]
			public DateOnly? LegDividendPeriodValuationDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42374, Type = TagType.Int, Offset = 8, Required = false)]
			public int? LegDividendPeriodValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42375, Type = TagType.Int, Offset = 9, Required = false)]
			public int? LegDividendPeriodValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42376, Type = TagType.String, Offset = 10, Required = false)]
			public string? LegDividendPeriodValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42377, Type = TagType.Int, Offset = 11, Required = false)]
			public int? LegDividendPeriodValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42378, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? LegDividendPeriodValuationDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42379, Type = TagType.LocalDate, Offset = 13, Required = false)]
			public DateOnly? LegDividendPeriodPaymentDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42380, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegDividendPeriodPaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42381, Type = TagType.Int, Offset = 15, Required = false)]
			public int? LegDividendPeriodPaymentDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42382, Type = TagType.String, Offset = 16, Required = false)]
			public string? LegDividendPeriodPaymentDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42383, Type = TagType.Int, Offset = 17, Required = false)]
			public int? LegDividendPeriodPaymentDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42384, Type = TagType.LocalDate, Offset = 18, Required = false)]
			public DateOnly? LegDividendPeriodPaymentDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42385, Type = TagType.String, Offset = 19, Required = false)]
			public string? LegDividendPeriodXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegDividendPeriodSequence is not null) writer.WriteWholeNumber(42367, LegDividendPeriodSequence.Value);
				if (LegDividendPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42368, LegDividendPeriodStartDateUnadjusted.Value);
				if (LegDividendPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42369, LegDividendPeriodEndDateUnadjusted.Value);
				if (LegDividendPeriodUnderlierRefID is not null) writer.WriteString(42370, LegDividendPeriodUnderlierRefID);
				if (LegDividendPeriodStrikePrice is not null) writer.WriteNumber(42371, LegDividendPeriodStrikePrice.Value);
				if (LegDividendPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(42372, LegDividendPeriodBusinessDayConvention.Value);
				if (LegDividendPeriodBusinessCenterGrp is not null) ((IFixEncoder)LegDividendPeriodBusinessCenterGrp).Encode(writer);
				if (LegDividendPeriodValuationDateUnadjusted is not null) writer.WriteLocalDateOnly(42373, LegDividendPeriodValuationDateUnadjusted.Value);
				if (LegDividendPeriodValuationDateRelativeTo is not null) writer.WriteWholeNumber(42374, LegDividendPeriodValuationDateRelativeTo.Value);
				if (LegDividendPeriodValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(42375, LegDividendPeriodValuationDateOffsetPeriod.Value);
				if (LegDividendPeriodValuationDateOffsetUnit is not null) writer.WriteString(42376, LegDividendPeriodValuationDateOffsetUnit);
				if (LegDividendPeriodValuationDateOffsetDayType is not null) writer.WriteWholeNumber(42377, LegDividendPeriodValuationDateOffsetDayType.Value);
				if (LegDividendPeriodValuationDateAdjusted is not null) writer.WriteLocalDateOnly(42378, LegDividendPeriodValuationDateAdjusted.Value);
				if (LegDividendPeriodPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42379, LegDividendPeriodPaymentDateUnadjusted.Value);
				if (LegDividendPeriodPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42380, LegDividendPeriodPaymentDateRelativeTo.Value);
				if (LegDividendPeriodPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42381, LegDividendPeriodPaymentDateOffsetPeriod.Value);
				if (LegDividendPeriodPaymentDateOffsetUnit is not null) writer.WriteString(42382, LegDividendPeriodPaymentDateOffsetUnit);
				if (LegDividendPeriodPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42383, LegDividendPeriodPaymentDateOffsetDayType.Value);
				if (LegDividendPeriodPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42384, LegDividendPeriodPaymentDateAdjusted.Value);
				if (LegDividendPeriodXID is not null) writer.WriteString(42385, LegDividendPeriodXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegDividendPeriodSequence = view.GetInt32(42367);
				LegDividendPeriodStartDateUnadjusted = view.GetDateOnly(42368);
				LegDividendPeriodEndDateUnadjusted = view.GetDateOnly(42369);
				LegDividendPeriodUnderlierRefID = view.GetString(42370);
				LegDividendPeriodStrikePrice = view.GetDouble(42371);
				LegDividendPeriodBusinessDayConvention = view.GetInt32(42372);
				if (view.GetView("LegDividendPeriodBusinessCenterGrp") is IMessageView viewLegDividendPeriodBusinessCenterGrp)
				{
					LegDividendPeriodBusinessCenterGrp = new();
					((IFixParser)LegDividendPeriodBusinessCenterGrp).Parse(viewLegDividendPeriodBusinessCenterGrp);
				}
				LegDividendPeriodValuationDateUnadjusted = view.GetDateOnly(42373);
				LegDividendPeriodValuationDateRelativeTo = view.GetInt32(42374);
				LegDividendPeriodValuationDateOffsetPeriod = view.GetInt32(42375);
				LegDividendPeriodValuationDateOffsetUnit = view.GetString(42376);
				LegDividendPeriodValuationDateOffsetDayType = view.GetInt32(42377);
				LegDividendPeriodValuationDateAdjusted = view.GetDateOnly(42378);
				LegDividendPeriodPaymentDateUnadjusted = view.GetDateOnly(42379);
				LegDividendPeriodPaymentDateRelativeTo = view.GetInt32(42380);
				LegDividendPeriodPaymentDateOffsetPeriod = view.GetInt32(42381);
				LegDividendPeriodPaymentDateOffsetUnit = view.GetString(42382);
				LegDividendPeriodPaymentDateOffsetDayType = view.GetInt32(42383);
				LegDividendPeriodPaymentDateAdjusted = view.GetDateOnly(42384);
				LegDividendPeriodXID = view.GetString(42385);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegDividendPeriodSequence":
					{
						value = LegDividendPeriodSequence;
						break;
					}
					case "LegDividendPeriodStartDateUnadjusted":
					{
						value = LegDividendPeriodStartDateUnadjusted;
						break;
					}
					case "LegDividendPeriodEndDateUnadjusted":
					{
						value = LegDividendPeriodEndDateUnadjusted;
						break;
					}
					case "LegDividendPeriodUnderlierRefID":
					{
						value = LegDividendPeriodUnderlierRefID;
						break;
					}
					case "LegDividendPeriodStrikePrice":
					{
						value = LegDividendPeriodStrikePrice;
						break;
					}
					case "LegDividendPeriodBusinessDayConvention":
					{
						value = LegDividendPeriodBusinessDayConvention;
						break;
					}
					case "LegDividendPeriodBusinessCenterGrp":
					{
						value = LegDividendPeriodBusinessCenterGrp;
						break;
					}
					case "LegDividendPeriodValuationDateUnadjusted":
					{
						value = LegDividendPeriodValuationDateUnadjusted;
						break;
					}
					case "LegDividendPeriodValuationDateRelativeTo":
					{
						value = LegDividendPeriodValuationDateRelativeTo;
						break;
					}
					case "LegDividendPeriodValuationDateOffsetPeriod":
					{
						value = LegDividendPeriodValuationDateOffsetPeriod;
						break;
					}
					case "LegDividendPeriodValuationDateOffsetUnit":
					{
						value = LegDividendPeriodValuationDateOffsetUnit;
						break;
					}
					case "LegDividendPeriodValuationDateOffsetDayType":
					{
						value = LegDividendPeriodValuationDateOffsetDayType;
						break;
					}
					case "LegDividendPeriodValuationDateAdjusted":
					{
						value = LegDividendPeriodValuationDateAdjusted;
						break;
					}
					case "LegDividendPeriodPaymentDateUnadjusted":
					{
						value = LegDividendPeriodPaymentDateUnadjusted;
						break;
					}
					case "LegDividendPeriodPaymentDateRelativeTo":
					{
						value = LegDividendPeriodPaymentDateRelativeTo;
						break;
					}
					case "LegDividendPeriodPaymentDateOffsetPeriod":
					{
						value = LegDividendPeriodPaymentDateOffsetPeriod;
						break;
					}
					case "LegDividendPeriodPaymentDateOffsetUnit":
					{
						value = LegDividendPeriodPaymentDateOffsetUnit;
						break;
					}
					case "LegDividendPeriodPaymentDateOffsetDayType":
					{
						value = LegDividendPeriodPaymentDateOffsetDayType;
						break;
					}
					case "LegDividendPeriodPaymentDateAdjusted":
					{
						value = LegDividendPeriodPaymentDateAdjusted;
						break;
					}
					case "LegDividendPeriodXID":
					{
						value = LegDividendPeriodXID;
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
				LegDividendPeriodSequence = null;
				LegDividendPeriodStartDateUnadjusted = null;
				LegDividendPeriodEndDateUnadjusted = null;
				LegDividendPeriodUnderlierRefID = null;
				LegDividendPeriodStrikePrice = null;
				LegDividendPeriodBusinessDayConvention = null;
				((IFixReset?)LegDividendPeriodBusinessCenterGrp)?.Reset();
				LegDividendPeriodValuationDateUnadjusted = null;
				LegDividendPeriodValuationDateRelativeTo = null;
				LegDividendPeriodValuationDateOffsetPeriod = null;
				LegDividendPeriodValuationDateOffsetUnit = null;
				LegDividendPeriodValuationDateOffsetDayType = null;
				LegDividendPeriodValuationDateAdjusted = null;
				LegDividendPeriodPaymentDateUnadjusted = null;
				LegDividendPeriodPaymentDateRelativeTo = null;
				LegDividendPeriodPaymentDateOffsetPeriod = null;
				LegDividendPeriodPaymentDateOffsetUnit = null;
				LegDividendPeriodPaymentDateOffsetDayType = null;
				LegDividendPeriodPaymentDateAdjusted = null;
				LegDividendPeriodXID = null;
			}
		}
		[Group(NoOfTag = 42366, Offset = 0, Required = false)]
		public NoLegDividendPeriods[]? LegDividendPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegDividendPeriods is not null && LegDividendPeriods.Length != 0)
			{
				writer.WriteWholeNumber(42366, LegDividendPeriods.Length);
				for (int i = 0; i < LegDividendPeriods.Length; i++)
				{
					((IFixEncoder)LegDividendPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegDividendPeriods") is IMessageView viewNoLegDividendPeriods)
			{
				var count = viewNoLegDividendPeriods.GroupCount();
				LegDividendPeriods = new NoLegDividendPeriods[count];
				for (int i = 0; i < count; i++)
				{
					LegDividendPeriods[i] = new();
					((IFixParser)LegDividendPeriods[i]).Parse(viewNoLegDividendPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegDividendPeriods":
				{
					value = LegDividendPeriods;
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
			LegDividendPeriods = null;
		}
	}
}
