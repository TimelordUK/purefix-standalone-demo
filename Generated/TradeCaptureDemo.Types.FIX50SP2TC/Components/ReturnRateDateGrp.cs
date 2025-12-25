using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRateDateGrp : IFixComponent
	{
		public sealed partial class NoReturnRateDates : IFixGroup
		{
			[TagDetails(Tag = 42710, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ReturnRateDateMode {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public ReturnRateValuationDateGrp? ReturnRateValuationDateGrp {get; set;}
			
			[TagDetails(Tag = 42711, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ReturnRateValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42712, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ReturnRateValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42713, Type = TagType.String, Offset = 4, Required = false)]
			public string? ReturnRateValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42714, Type = TagType.Int, Offset = 5, Required = false)]
			public int? ReturnRateValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42715, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? ReturnRateValuationStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42716, Type = TagType.Int, Offset = 7, Required = false)]
			public int? ReturnRateValuationStartDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42717, Type = TagType.Int, Offset = 8, Required = false)]
			public int? ReturnRateValuationStartDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42718, Type = TagType.String, Offset = 9, Required = false)]
			public string? ReturnRateValuationStartDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42719, Type = TagType.Int, Offset = 10, Required = false)]
			public int? ReturnRateValuationStartDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42720, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? ReturnRateValuationStartDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42721, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? ReturnRateValuationEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42722, Type = TagType.Int, Offset = 13, Required = false)]
			public int? ReturnRateValuationEndDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42723, Type = TagType.Int, Offset = 14, Required = false)]
			public int? ReturnRateValuationEndDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42724, Type = TagType.String, Offset = 15, Required = false)]
			public string? ReturnRateValuationEndDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42725, Type = TagType.Int, Offset = 16, Required = false)]
			public int? ReturnRateValuationEndDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42726, Type = TagType.LocalDate, Offset = 17, Required = false)]
			public DateOnly? ReturnRateValuationEndDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42727, Type = TagType.Int, Offset = 18, Required = false)]
			public int? ReturnRateValuationFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 42728, Type = TagType.String, Offset = 19, Required = false)]
			public string? ReturnRateValuationFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 42729, Type = TagType.String, Offset = 20, Required = false)]
			public string? ReturnRateValuationFrequencyRollConvention {get; set;}
			
			[TagDetails(Tag = 42730, Type = TagType.Int, Offset = 21, Required = false)]
			public int? ReturnRateValuationDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public ReturnRateValuationDateBusinessCenterGrp? ReturnRateValuationDateBusinessCenterGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRateDateMode is not null) writer.WriteWholeNumber(42710, ReturnRateDateMode.Value);
				if (ReturnRateValuationDateGrp is not null) ((IFixEncoder)ReturnRateValuationDateGrp).Encode(writer);
				if (ReturnRateValuationDateRelativeTo is not null) writer.WriteWholeNumber(42711, ReturnRateValuationDateRelativeTo.Value);
				if (ReturnRateValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(42712, ReturnRateValuationDateOffsetPeriod.Value);
				if (ReturnRateValuationDateOffsetUnit is not null) writer.WriteString(42713, ReturnRateValuationDateOffsetUnit);
				if (ReturnRateValuationDateOffsetDayType is not null) writer.WriteWholeNumber(42714, ReturnRateValuationDateOffsetDayType.Value);
				if (ReturnRateValuationStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42715, ReturnRateValuationStartDateUnadjusted.Value);
				if (ReturnRateValuationStartDateRelativeTo is not null) writer.WriteWholeNumber(42716, ReturnRateValuationStartDateRelativeTo.Value);
				if (ReturnRateValuationStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42717, ReturnRateValuationStartDateOffsetPeriod.Value);
				if (ReturnRateValuationStartDateOffsetUnit is not null) writer.WriteString(42718, ReturnRateValuationStartDateOffsetUnit);
				if (ReturnRateValuationStartDateOffsetDayType is not null) writer.WriteWholeNumber(42719, ReturnRateValuationStartDateOffsetDayType.Value);
				if (ReturnRateValuationStartDateAdjusted is not null) writer.WriteLocalDateOnly(42720, ReturnRateValuationStartDateAdjusted.Value);
				if (ReturnRateValuationEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42721, ReturnRateValuationEndDateUnadjusted.Value);
				if (ReturnRateValuationEndDateRelativeTo is not null) writer.WriteWholeNumber(42722, ReturnRateValuationEndDateRelativeTo.Value);
				if (ReturnRateValuationEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42723, ReturnRateValuationEndDateOffsetPeriod.Value);
				if (ReturnRateValuationEndDateOffsetUnit is not null) writer.WriteString(42724, ReturnRateValuationEndDateOffsetUnit);
				if (ReturnRateValuationEndDateOffsetDayType is not null) writer.WriteWholeNumber(42725, ReturnRateValuationEndDateOffsetDayType.Value);
				if (ReturnRateValuationEndDateAdjusted is not null) writer.WriteLocalDateOnly(42726, ReturnRateValuationEndDateAdjusted.Value);
				if (ReturnRateValuationFrequencyPeriod is not null) writer.WriteWholeNumber(42727, ReturnRateValuationFrequencyPeriod.Value);
				if (ReturnRateValuationFrequencyUnit is not null) writer.WriteString(42728, ReturnRateValuationFrequencyUnit);
				if (ReturnRateValuationFrequencyRollConvention is not null) writer.WriteString(42729, ReturnRateValuationFrequencyRollConvention);
				if (ReturnRateValuationDateBusinessDayConvention is not null) writer.WriteWholeNumber(42730, ReturnRateValuationDateBusinessDayConvention.Value);
				if (ReturnRateValuationDateBusinessCenterGrp is not null) ((IFixEncoder)ReturnRateValuationDateBusinessCenterGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRateDateMode = view.GetInt32(42710);
				if (view.GetView("ReturnRateValuationDateGrp") is IMessageView viewReturnRateValuationDateGrp)
				{
					ReturnRateValuationDateGrp = new();
					((IFixParser)ReturnRateValuationDateGrp).Parse(viewReturnRateValuationDateGrp);
				}
				ReturnRateValuationDateRelativeTo = view.GetInt32(42711);
				ReturnRateValuationDateOffsetPeriod = view.GetInt32(42712);
				ReturnRateValuationDateOffsetUnit = view.GetString(42713);
				ReturnRateValuationDateOffsetDayType = view.GetInt32(42714);
				ReturnRateValuationStartDateUnadjusted = view.GetDateOnly(42715);
				ReturnRateValuationStartDateRelativeTo = view.GetInt32(42716);
				ReturnRateValuationStartDateOffsetPeriod = view.GetInt32(42717);
				ReturnRateValuationStartDateOffsetUnit = view.GetString(42718);
				ReturnRateValuationStartDateOffsetDayType = view.GetInt32(42719);
				ReturnRateValuationStartDateAdjusted = view.GetDateOnly(42720);
				ReturnRateValuationEndDateUnadjusted = view.GetDateOnly(42721);
				ReturnRateValuationEndDateRelativeTo = view.GetInt32(42722);
				ReturnRateValuationEndDateOffsetPeriod = view.GetInt32(42723);
				ReturnRateValuationEndDateOffsetUnit = view.GetString(42724);
				ReturnRateValuationEndDateOffsetDayType = view.GetInt32(42725);
				ReturnRateValuationEndDateAdjusted = view.GetDateOnly(42726);
				ReturnRateValuationFrequencyPeriod = view.GetInt32(42727);
				ReturnRateValuationFrequencyUnit = view.GetString(42728);
				ReturnRateValuationFrequencyRollConvention = view.GetString(42729);
				ReturnRateValuationDateBusinessDayConvention = view.GetInt32(42730);
				if (view.GetView("ReturnRateValuationDateBusinessCenterGrp") is IMessageView viewReturnRateValuationDateBusinessCenterGrp)
				{
					ReturnRateValuationDateBusinessCenterGrp = new();
					((IFixParser)ReturnRateValuationDateBusinessCenterGrp).Parse(viewReturnRateValuationDateBusinessCenterGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRateDateMode":
					{
						value = ReturnRateDateMode;
						break;
					}
					case "ReturnRateValuationDateGrp":
					{
						value = ReturnRateValuationDateGrp;
						break;
					}
					case "ReturnRateValuationDateRelativeTo":
					{
						value = ReturnRateValuationDateRelativeTo;
						break;
					}
					case "ReturnRateValuationDateOffsetPeriod":
					{
						value = ReturnRateValuationDateOffsetPeriod;
						break;
					}
					case "ReturnRateValuationDateOffsetUnit":
					{
						value = ReturnRateValuationDateOffsetUnit;
						break;
					}
					case "ReturnRateValuationDateOffsetDayType":
					{
						value = ReturnRateValuationDateOffsetDayType;
						break;
					}
					case "ReturnRateValuationStartDateUnadjusted":
					{
						value = ReturnRateValuationStartDateUnadjusted;
						break;
					}
					case "ReturnRateValuationStartDateRelativeTo":
					{
						value = ReturnRateValuationStartDateRelativeTo;
						break;
					}
					case "ReturnRateValuationStartDateOffsetPeriod":
					{
						value = ReturnRateValuationStartDateOffsetPeriod;
						break;
					}
					case "ReturnRateValuationStartDateOffsetUnit":
					{
						value = ReturnRateValuationStartDateOffsetUnit;
						break;
					}
					case "ReturnRateValuationStartDateOffsetDayType":
					{
						value = ReturnRateValuationStartDateOffsetDayType;
						break;
					}
					case "ReturnRateValuationStartDateAdjusted":
					{
						value = ReturnRateValuationStartDateAdjusted;
						break;
					}
					case "ReturnRateValuationEndDateUnadjusted":
					{
						value = ReturnRateValuationEndDateUnadjusted;
						break;
					}
					case "ReturnRateValuationEndDateRelativeTo":
					{
						value = ReturnRateValuationEndDateRelativeTo;
						break;
					}
					case "ReturnRateValuationEndDateOffsetPeriod":
					{
						value = ReturnRateValuationEndDateOffsetPeriod;
						break;
					}
					case "ReturnRateValuationEndDateOffsetUnit":
					{
						value = ReturnRateValuationEndDateOffsetUnit;
						break;
					}
					case "ReturnRateValuationEndDateOffsetDayType":
					{
						value = ReturnRateValuationEndDateOffsetDayType;
						break;
					}
					case "ReturnRateValuationEndDateAdjusted":
					{
						value = ReturnRateValuationEndDateAdjusted;
						break;
					}
					case "ReturnRateValuationFrequencyPeriod":
					{
						value = ReturnRateValuationFrequencyPeriod;
						break;
					}
					case "ReturnRateValuationFrequencyUnit":
					{
						value = ReturnRateValuationFrequencyUnit;
						break;
					}
					case "ReturnRateValuationFrequencyRollConvention":
					{
						value = ReturnRateValuationFrequencyRollConvention;
						break;
					}
					case "ReturnRateValuationDateBusinessDayConvention":
					{
						value = ReturnRateValuationDateBusinessDayConvention;
						break;
					}
					case "ReturnRateValuationDateBusinessCenterGrp":
					{
						value = ReturnRateValuationDateBusinessCenterGrp;
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
				ReturnRateDateMode = null;
				((IFixReset?)ReturnRateValuationDateGrp)?.Reset();
				ReturnRateValuationDateRelativeTo = null;
				ReturnRateValuationDateOffsetPeriod = null;
				ReturnRateValuationDateOffsetUnit = null;
				ReturnRateValuationDateOffsetDayType = null;
				ReturnRateValuationStartDateUnadjusted = null;
				ReturnRateValuationStartDateRelativeTo = null;
				ReturnRateValuationStartDateOffsetPeriod = null;
				ReturnRateValuationStartDateOffsetUnit = null;
				ReturnRateValuationStartDateOffsetDayType = null;
				ReturnRateValuationStartDateAdjusted = null;
				ReturnRateValuationEndDateUnadjusted = null;
				ReturnRateValuationEndDateRelativeTo = null;
				ReturnRateValuationEndDateOffsetPeriod = null;
				ReturnRateValuationEndDateOffsetUnit = null;
				ReturnRateValuationEndDateOffsetDayType = null;
				ReturnRateValuationEndDateAdjusted = null;
				ReturnRateValuationFrequencyPeriod = null;
				ReturnRateValuationFrequencyUnit = null;
				ReturnRateValuationFrequencyRollConvention = null;
				ReturnRateValuationDateBusinessDayConvention = null;
				((IFixReset?)ReturnRateValuationDateBusinessCenterGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 42709, Offset = 0, Required = false)]
		public NoReturnRateDates[]? ReturnRateDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRateDates is not null && ReturnRateDates.Length != 0)
			{
				writer.WriteWholeNumber(42709, ReturnRateDates.Length);
				for (int i = 0; i < ReturnRateDates.Length; i++)
				{
					((IFixEncoder)ReturnRateDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRateDates") is IMessageView viewNoReturnRateDates)
			{
				var count = viewNoReturnRateDates.GroupCount();
				ReturnRateDates = new NoReturnRateDates[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRateDates[i] = new();
					((IFixParser)ReturnRateDates[i]).Parse(viewNoReturnRateDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRateDates":
				{
					value = ReturnRateDates;
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
			ReturnRateDates = null;
		}
	}
}
