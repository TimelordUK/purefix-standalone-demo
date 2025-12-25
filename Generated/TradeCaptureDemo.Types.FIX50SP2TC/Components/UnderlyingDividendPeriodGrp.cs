using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendPeriodGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDividendPeriods : IFixGroup
		{
			[TagDetails(Tag = 42863, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingDividendPeriodSequence {get; set;}
			
			[TagDetails(Tag = 42864, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? UnderlyingDividendPeriodStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42865, Type = TagType.LocalDate, Offset = 2, Required = false)]
			public DateOnly? UnderlyingDividendPeriodEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42866, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingDividendPeriodUnderlierRefID {get; set;}
			
			[TagDetails(Tag = 42867, Type = TagType.Float, Offset = 4, Required = false)]
			public double? UnderlyingDividendPeriodStrikePrice {get; set;}
			
			[TagDetails(Tag = 42868, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnderlyingDividendPeriodBusinessDayConvention {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public UnderlyingDividendPeriodBusinessCenterGrp? UnderlyingDividendPeriodBusinessCenterGrp {get; set;}
			
			[TagDetails(Tag = 42869, Type = TagType.LocalDate, Offset = 7, Required = false)]
			public DateOnly? UnderlyingDividendPeriodValuationDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42870, Type = TagType.Int, Offset = 8, Required = false)]
			public int? UnderlyingDividendPeriodValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42871, Type = TagType.Int, Offset = 9, Required = false)]
			public int? UnderlyingDividendPeriodValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42872, Type = TagType.String, Offset = 10, Required = false)]
			public string? UnderlyingDividendPeriodValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42873, Type = TagType.Int, Offset = 11, Required = false)]
			public int? UnderlyingDividendPeriodValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42874, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? UnderlyingDividendPeriodValuationDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42875, Type = TagType.LocalDate, Offset = 13, Required = false)]
			public DateOnly? UnderlyingDividendPeriodPaymentDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42876, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingDividendPeriodPaymentDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42877, Type = TagType.Int, Offset = 15, Required = false)]
			public int? UnderlyingDividendPeriodPaymentDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42878, Type = TagType.String, Offset = 16, Required = false)]
			public string? UnderlyingDividendPeriodPaymentDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42879, Type = TagType.Int, Offset = 17, Required = false)]
			public int? UnderlyingDividendPeriodPaymentDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42880, Type = TagType.LocalDate, Offset = 18, Required = false)]
			public DateOnly? UnderlyingDividendPeriodPaymentDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42881, Type = TagType.String, Offset = 19, Required = false)]
			public string? UnderlyingDividendPeriodXID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDividendPeriodSequence is not null) writer.WriteWholeNumber(42863, UnderlyingDividendPeriodSequence.Value);
				if (UnderlyingDividendPeriodStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42864, UnderlyingDividendPeriodStartDateUnadjusted.Value);
				if (UnderlyingDividendPeriodEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42865, UnderlyingDividendPeriodEndDateUnadjusted.Value);
				if (UnderlyingDividendPeriodUnderlierRefID is not null) writer.WriteString(42866, UnderlyingDividendPeriodUnderlierRefID);
				if (UnderlyingDividendPeriodStrikePrice is not null) writer.WriteNumber(42867, UnderlyingDividendPeriodStrikePrice.Value);
				if (UnderlyingDividendPeriodBusinessDayConvention is not null) writer.WriteWholeNumber(42868, UnderlyingDividendPeriodBusinessDayConvention.Value);
				if (UnderlyingDividendPeriodBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingDividendPeriodBusinessCenterGrp).Encode(writer);
				if (UnderlyingDividendPeriodValuationDateUnadjusted is not null) writer.WriteLocalDateOnly(42869, UnderlyingDividendPeriodValuationDateUnadjusted.Value);
				if (UnderlyingDividendPeriodValuationDateRelativeTo is not null) writer.WriteWholeNumber(42870, UnderlyingDividendPeriodValuationDateRelativeTo.Value);
				if (UnderlyingDividendPeriodValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(42871, UnderlyingDividendPeriodValuationDateOffsetPeriod.Value);
				if (UnderlyingDividendPeriodValuationDateOffsetUnit is not null) writer.WriteString(42872, UnderlyingDividendPeriodValuationDateOffsetUnit);
				if (UnderlyingDividendPeriodValuationDateOffsetDayType is not null) writer.WriteWholeNumber(42873, UnderlyingDividendPeriodValuationDateOffsetDayType.Value);
				if (UnderlyingDividendPeriodValuationDateAdjusted is not null) writer.WriteLocalDateOnly(42874, UnderlyingDividendPeriodValuationDateAdjusted.Value);
				if (UnderlyingDividendPeriodPaymentDateUnadjusted is not null) writer.WriteLocalDateOnly(42875, UnderlyingDividendPeriodPaymentDateUnadjusted.Value);
				if (UnderlyingDividendPeriodPaymentDateRelativeTo is not null) writer.WriteWholeNumber(42876, UnderlyingDividendPeriodPaymentDateRelativeTo.Value);
				if (UnderlyingDividendPeriodPaymentDateOffsetPeriod is not null) writer.WriteWholeNumber(42877, UnderlyingDividendPeriodPaymentDateOffsetPeriod.Value);
				if (UnderlyingDividendPeriodPaymentDateOffsetUnit is not null) writer.WriteString(42878, UnderlyingDividendPeriodPaymentDateOffsetUnit);
				if (UnderlyingDividendPeriodPaymentDateOffsetDayType is not null) writer.WriteWholeNumber(42879, UnderlyingDividendPeriodPaymentDateOffsetDayType.Value);
				if (UnderlyingDividendPeriodPaymentDateAdjusted is not null) writer.WriteLocalDateOnly(42880, UnderlyingDividendPeriodPaymentDateAdjusted.Value);
				if (UnderlyingDividendPeriodXID is not null) writer.WriteString(42881, UnderlyingDividendPeriodXID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDividendPeriodSequence = view.GetInt32(42863);
				UnderlyingDividendPeriodStartDateUnadjusted = view.GetDateOnly(42864);
				UnderlyingDividendPeriodEndDateUnadjusted = view.GetDateOnly(42865);
				UnderlyingDividendPeriodUnderlierRefID = view.GetString(42866);
				UnderlyingDividendPeriodStrikePrice = view.GetDouble(42867);
				UnderlyingDividendPeriodBusinessDayConvention = view.GetInt32(42868);
				if (view.GetView("UnderlyingDividendPeriodBusinessCenterGrp") is IMessageView viewUnderlyingDividendPeriodBusinessCenterGrp)
				{
					UnderlyingDividendPeriodBusinessCenterGrp = new();
					((IFixParser)UnderlyingDividendPeriodBusinessCenterGrp).Parse(viewUnderlyingDividendPeriodBusinessCenterGrp);
				}
				UnderlyingDividendPeriodValuationDateUnadjusted = view.GetDateOnly(42869);
				UnderlyingDividendPeriodValuationDateRelativeTo = view.GetInt32(42870);
				UnderlyingDividendPeriodValuationDateOffsetPeriod = view.GetInt32(42871);
				UnderlyingDividendPeriodValuationDateOffsetUnit = view.GetString(42872);
				UnderlyingDividendPeriodValuationDateOffsetDayType = view.GetInt32(42873);
				UnderlyingDividendPeriodValuationDateAdjusted = view.GetDateOnly(42874);
				UnderlyingDividendPeriodPaymentDateUnadjusted = view.GetDateOnly(42875);
				UnderlyingDividendPeriodPaymentDateRelativeTo = view.GetInt32(42876);
				UnderlyingDividendPeriodPaymentDateOffsetPeriod = view.GetInt32(42877);
				UnderlyingDividendPeriodPaymentDateOffsetUnit = view.GetString(42878);
				UnderlyingDividendPeriodPaymentDateOffsetDayType = view.GetInt32(42879);
				UnderlyingDividendPeriodPaymentDateAdjusted = view.GetDateOnly(42880);
				UnderlyingDividendPeriodXID = view.GetString(42881);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDividendPeriodSequence":
					{
						value = UnderlyingDividendPeriodSequence;
						break;
					}
					case "UnderlyingDividendPeriodStartDateUnadjusted":
					{
						value = UnderlyingDividendPeriodStartDateUnadjusted;
						break;
					}
					case "UnderlyingDividendPeriodEndDateUnadjusted":
					{
						value = UnderlyingDividendPeriodEndDateUnadjusted;
						break;
					}
					case "UnderlyingDividendPeriodUnderlierRefID":
					{
						value = UnderlyingDividendPeriodUnderlierRefID;
						break;
					}
					case "UnderlyingDividendPeriodStrikePrice":
					{
						value = UnderlyingDividendPeriodStrikePrice;
						break;
					}
					case "UnderlyingDividendPeriodBusinessDayConvention":
					{
						value = UnderlyingDividendPeriodBusinessDayConvention;
						break;
					}
					case "UnderlyingDividendPeriodBusinessCenterGrp":
					{
						value = UnderlyingDividendPeriodBusinessCenterGrp;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateUnadjusted":
					{
						value = UnderlyingDividendPeriodValuationDateUnadjusted;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateRelativeTo":
					{
						value = UnderlyingDividendPeriodValuationDateRelativeTo;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateOffsetPeriod":
					{
						value = UnderlyingDividendPeriodValuationDateOffsetPeriod;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateOffsetUnit":
					{
						value = UnderlyingDividendPeriodValuationDateOffsetUnit;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateOffsetDayType":
					{
						value = UnderlyingDividendPeriodValuationDateOffsetDayType;
						break;
					}
					case "UnderlyingDividendPeriodValuationDateAdjusted":
					{
						value = UnderlyingDividendPeriodValuationDateAdjusted;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateUnadjusted":
					{
						value = UnderlyingDividendPeriodPaymentDateUnadjusted;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateRelativeTo":
					{
						value = UnderlyingDividendPeriodPaymentDateRelativeTo;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateOffsetPeriod":
					{
						value = UnderlyingDividendPeriodPaymentDateOffsetPeriod;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateOffsetUnit":
					{
						value = UnderlyingDividendPeriodPaymentDateOffsetUnit;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateOffsetDayType":
					{
						value = UnderlyingDividendPeriodPaymentDateOffsetDayType;
						break;
					}
					case "UnderlyingDividendPeriodPaymentDateAdjusted":
					{
						value = UnderlyingDividendPeriodPaymentDateAdjusted;
						break;
					}
					case "UnderlyingDividendPeriodXID":
					{
						value = UnderlyingDividendPeriodXID;
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
				UnderlyingDividendPeriodSequence = null;
				UnderlyingDividendPeriodStartDateUnadjusted = null;
				UnderlyingDividendPeriodEndDateUnadjusted = null;
				UnderlyingDividendPeriodUnderlierRefID = null;
				UnderlyingDividendPeriodStrikePrice = null;
				UnderlyingDividendPeriodBusinessDayConvention = null;
				((IFixReset?)UnderlyingDividendPeriodBusinessCenterGrp)?.Reset();
				UnderlyingDividendPeriodValuationDateUnadjusted = null;
				UnderlyingDividendPeriodValuationDateRelativeTo = null;
				UnderlyingDividendPeriodValuationDateOffsetPeriod = null;
				UnderlyingDividendPeriodValuationDateOffsetUnit = null;
				UnderlyingDividendPeriodValuationDateOffsetDayType = null;
				UnderlyingDividendPeriodValuationDateAdjusted = null;
				UnderlyingDividendPeriodPaymentDateUnadjusted = null;
				UnderlyingDividendPeriodPaymentDateRelativeTo = null;
				UnderlyingDividendPeriodPaymentDateOffsetPeriod = null;
				UnderlyingDividendPeriodPaymentDateOffsetUnit = null;
				UnderlyingDividendPeriodPaymentDateOffsetDayType = null;
				UnderlyingDividendPeriodPaymentDateAdjusted = null;
				UnderlyingDividendPeriodXID = null;
			}
		}
		[Group(NoOfTag = 42862, Offset = 0, Required = false)]
		public NoUnderlyingDividendPeriods[]? UnderlyingDividendPeriods {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendPeriods is not null && UnderlyingDividendPeriods.Length != 0)
			{
				writer.WriteWholeNumber(42862, UnderlyingDividendPeriods.Length);
				for (int i = 0; i < UnderlyingDividendPeriods.Length; i++)
				{
					((IFixEncoder)UnderlyingDividendPeriods[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDividendPeriods") is IMessageView viewNoUnderlyingDividendPeriods)
			{
				var count = viewNoUnderlyingDividendPeriods.GroupCount();
				UnderlyingDividendPeriods = new NoUnderlyingDividendPeriods[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDividendPeriods[i] = new();
					((IFixParser)UnderlyingDividendPeriods[i]).Parse(viewNoUnderlyingDividendPeriods.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDividendPeriods":
				{
					value = UnderlyingDividendPeriods;
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
			UnderlyingDividendPeriods = null;
		}
	}
}
