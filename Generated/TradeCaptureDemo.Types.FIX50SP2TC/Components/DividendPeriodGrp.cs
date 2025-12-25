using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendPeriodGrp : IFixComponent
	{
		public sealed partial class NoDividendPeriods : IFixGroup
		{
			[TagDetails(Tag = 42275, Type = TagType.Int, Offset = 0, Required = false)]
			public int? DividendPeriodSequence {get; set;}
			
			[TagDetails(Tag = 42276, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? DividendPeriodStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42277, Type = TagType.LocalDate, Offset = 2, Required = false)]
			public DateOnly? DividendPeriodEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42278, Type = TagType.String, Offset = 3, Required = false)]
			public string? DividendPeriodUnderlierRefID {get; set;}
			
			[TagDetails(Tag = 42279, Type = TagType.Float, Offset = 4, Required = false)]
			public double? DividendPeriodStrikePrice {get; set;}
			
			[TagDetails(Tag = 42280, Type = TagType.Int, Offset = 5, Required = false)]
			public int? DividendPeriodBusinessDayConvention {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public DividendPeriodBusinessCenterGrp? DividendPeriodBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 42281, Type = TagType.LocalDate, Offset = 7, Required = false)]
			public DateOnly? DividendPeriodValuationDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42282, Type = TagType.Int, Offset = 8, Required = false)]
			public int? DividendPeriodValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42283, Type = TagType.Int, Offset = 9, Required = false)]
			public int? DividendPeriodValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42284, Type = TagType.String, Offset = 10, Required = false)]
			public string? DividendPeriodValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42285, Type = TagType.Int, Offset = 11, Required = false)]
			public int? DividendPeriodValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42286, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? DividendPeriodValuationDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42287, Type = TagType.LocalDate, Offset = 13, Required = false)]
			public DateOnly? DividendPeriodPaymentDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42288, Type = TagType.Int, Offset = 14, Required = false)]
			public int? DividendPeriodPaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42289, Type = TagType.Int, Offset = 15, Required = false)]
			public int? DividendPeriodPaymentDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42290, Type = TagType.String, Offset = 16, Required = false)]
			public string? DividendPeriodPaymentDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42291, Type = TagType.Int, Offset = 17, Required = false)]
			public int? DividendPeriodPaymentDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42292, Type = TagType.LocalDate, Offset = 18, Required = false)]
			public DateOnly? DividendPeriodPaymentDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42293, Type = TagType.String, Offset = 19, Required = false)]
			public string? DividendPeriodXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DividendPeriodSequence is not null) writer.WriteWholeNumber(42275, DividendPeriodSequence.Value);
				if (DividendPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42276, DividendPeriodStartDateUnadjusted.Value);
				if (DividendPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42277, DividendPeriodEndDateUnadjusted.Value);
				if (DividendPeriodUnderlierRefID is not null) writer.WriteString(42278, DividendPeriodUnderlierRefID);
				if (DividendPeriodStrikePrice is not null) writer.WriteNumber(42279, DividendPeriodStrikePrice.Value);
				if (DividendPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(42280, DividendPeriodBusinessDayConvention.Value);
				if (DividendPeriodBusinessCenterGrp is not null) ((IFixEncoder)DividendPeriodBusinessCenterGrp).Encode(writer);
				if (DividendPeriodValuationDateUnadjusted is not null) writer.WriteLocalDateOnly(42281, DividendPeriodValuationDateUnadjusted.Value);
				if (DividendPeriodValuationDateRelativeTo is not null) writer.WriteWholeNumber(42282, DividendPeriodValuationDateRelativeTo.Value);
				if (DividendPeriodValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(42283, DividendPeriodValuationDateOffsetPeriod.Value);
				if (DividendPeriodValuationDateOffsetUnit is not null) writer.WriteString(42284, DividendPeriodValuationDateOffsetUnit);
				if (DividendPeriodValuationDateOffsetDayType is not null) writer.WriteWholeNumber(42285, DividendPeriodValuationDateOffsetDayType.Value);
				if (DividendPeriodValuationDateAdjusted is not null) writer.WriteLocalDateOnly(42286, DividendPeriodValuationDateAdjusted.Value);
				if (DividendPeriodPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42287, DividendPeriodPaymentDateUnadjusted.Value);
				if (DividendPeriodPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42288, DividendPeriodPaymentDateRelativeTo.Value);
				if (DividendPeriodPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42289, DividendPeriodPaymentDateOffsetPeriod.Value);
				if (DividendPeriodPaymentDateOffsetUnit is not null) writer.WriteString(42290, DividendPeriodPaymentDateOffsetUnit);
				if (DividendPeriodPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42291, DividendPeriodPaymentDateOffsetDayType.Value);
				if (DividendPeriodPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42292, DividendPeriodPaymentDateAdjusted.Value);
				if (DividendPeriodXID is not null) writer.WriteString(42293, DividendPeriodXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DividendPeriodSequence = view.GetInt32(42275);
				DividendPeriodStartDateUnadjusted = view.GetDateOnly(42276);
				DividendPeriodEndDateUnadjusted = view.GetDateOnly(42277);
				DividendPeriodUnderlierRefID = view.GetString(42278);
				DividendPeriodStrikePrice = view.GetDouble(42279);
				DividendPeriodBusinessDayConvention = view.GetInt32(42280);
				if (view.GetView("DividendPeriodBusinessCenterGrp") is IMessageView viewDividendPeriodBusinessCenterGrp)
				{
					DividendPeriodBusinessCenterGrp = new();
					((IFixParser)DividendPeriodBusinessCenterGrp).Parse(viewDividendPeriodBusinessCenterGrp);
				}
				DividendPeriodValuationDateUnadjusted = view.GetDateOnly(42281);
				DividendPeriodValuationDateRelativeTo = view.GetInt32(42282);
				DividendPeriodValuationDateOffsetPeriod = view.GetInt32(42283);
				DividendPeriodValuationDateOffsetUnit = view.GetString(42284);
				DividendPeriodValuationDateOffsetDayType = view.GetInt32(42285);
				DividendPeriodValuationDateAdjusted = view.GetDateOnly(42286);
				DividendPeriodPaymentDateUnadjusted = view.GetDateOnly(42287);
				DividendPeriodPaymentDateRelativeTo = view.GetInt32(42288);
				DividendPeriodPaymentDateOffsetPeriod = view.GetInt32(42289);
				DividendPeriodPaymentDateOffsetUnit = view.GetString(42290);
				DividendPeriodPaymentDateOffsetDayType = view.GetInt32(42291);
				DividendPeriodPaymentDateAdjusted = view.GetDateOnly(42292);
				DividendPeriodXID = view.GetString(42293);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DividendPeriodSequence":
					{
						value = DividendPeriodSequence;
						break;
					}
					case "DividendPeriodStartDateUnadjusted":
					{
						value = DividendPeriodStartDateUnadjusted;
						break;
					}
					case "DividendPeriodEndDateUnadjusted":
					{
						value = DividendPeriodEndDateUnadjusted;
						break;
					}
					case "DividendPeriodUnderlierRefID":
					{
						value = DividendPeriodUnderlierRefID;
						break;
					}
					case "DividendPeriodStrikePrice":
					{
						value = DividendPeriodStrikePrice;
						break;
					}
					case "DividendPeriodBusinessDayConvention":
					{
						value = DividendPeriodBusinessDayConvention;
						break;
					}
					case "DividendPeriodBusinessCenterGrp":
					{
						value = DividendPeriodBusinessCenterGrp;
						break;
					}
					case "DividendPeriodValuationDateUnadjusted":
					{
						value = DividendPeriodValuationDateUnadjusted;
						break;
					}
					case "DividendPeriodValuationDateRelativeTo":
					{
						value = DividendPeriodValuationDateRelativeTo;
						break;
					}
					case "DividendPeriodValuationDateOffsetPeriod":
					{
						value = DividendPeriodValuationDateOffsetPeriod;
						break;
					}
					case "DividendPeriodValuationDateOffsetUnit":
					{
						value = DividendPeriodValuationDateOffsetUnit;
						break;
					}
					case "DividendPeriodValuationDateOffsetDayType":
					{
						value = DividendPeriodValuationDateOffsetDayType;
						break;
					}
					case "DividendPeriodValuationDateAdjusted":
					{
						value = DividendPeriodValuationDateAdjusted;
						break;
					}
					case "DividendPeriodPaymentDateUnadjusted":
					{
						value = DividendPeriodPaymentDateUnadjusted;
						break;
					}
					case "DividendPeriodPaymentDateRelativeTo":
					{
						value = DividendPeriodPaymentDateRelativeTo;
						break;
					}
					case "DividendPeriodPaymentDateOffsetPeriod":
					{
						value = DividendPeriodPaymentDateOffsetPeriod;
						break;
					}
					case "DividendPeriodPaymentDateOffsetUnit":
					{
						value = DividendPeriodPaymentDateOffsetUnit;
						break;
					}
					case "DividendPeriodPaymentDateOffsetDayType":
					{
						value = DividendPeriodPaymentDateOffsetDayType;
						break;
					}
					case "DividendPeriodPaymentDateAdjusted":
					{
						value = DividendPeriodPaymentDateAdjusted;
						break;
					}
					case "DividendPeriodXID":
					{
						value = DividendPeriodXID;
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
				DividendPeriodSequence = null;
				DividendPeriodStartDateUnadjusted = null;
				DividendPeriodEndDateUnadjusted = null;
				DividendPeriodUnderlierRefID = null;
				DividendPeriodStrikePrice = null;
				DividendPeriodBusinessDayConvention = null;
				((IFixReset?)DividendPeriodBusinessCenterGrp)?.Reset();
				DividendPeriodValuationDateUnadjusted = null;
				DividendPeriodValuationDateRelativeTo = null;
				DividendPeriodValuationDateOffsetPeriod = null;
				DividendPeriodValuationDateOffsetUnit = null;
				DividendPeriodValuationDateOffsetDayType = null;
				DividendPeriodValuationDateAdjusted = null;
				DividendPeriodPaymentDateUnadjusted = null;
				DividendPeriodPaymentDateRelativeTo = null;
				DividendPeriodPaymentDateOffsetPeriod = null;
				DividendPeriodPaymentDateOffsetUnit = null;
				DividendPeriodPaymentDateOffsetDayType = null;
				DividendPeriodPaymentDateAdjusted = null;
				DividendPeriodXID = null;
			}
		}
		[Group(NoOfTag = 42274, Offset = 0, Required = false)]
		public NoDividendPeriods[]? DividendPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendPeriods is not null && DividendPeriods.Length != 0)
			{
				writer.WriteWholeNumber(42274, DividendPeriods.Length);
				for (int i = 0; i < DividendPeriods.Length; i++)
				{
					((IFixEncoder)DividendPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDividendPeriods") is IMessageView viewNoDividendPeriods)
			{
				var count = viewNoDividendPeriods.GroupCount();
				DividendPeriods = new NoDividendPeriods[count];
				for (int i = 0; i < count; i++)
				{
					DividendPeriods[i] = new();
					((IFixParser)DividendPeriods[i]).Parse(viewNoDividendPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDividendPeriods":
				{
					value = DividendPeriods;
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
			DividendPeriods = null;
		}
	}
}
