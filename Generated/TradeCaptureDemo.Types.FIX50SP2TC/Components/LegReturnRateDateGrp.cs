using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegReturnRateDateGrp : IFixComponent
	{
		public sealed partial class NoLegReturnRateDates : IFixGroup
		{
			[TagDetails(Tag = 42509, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegReturnRateDateMode {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public LegReturnRateValuationDateGrp? LegReturnRateValuationDateGrp {get; set;}
			
			[TagDetails(Tag = 42510, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegReturnRateValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42511, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegReturnRateValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42512, Type = TagType.String, Offset = 4, Required = false)]
			public string? LegReturnRateValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42513, Type = TagType.Int, Offset = 5, Required = false)]
			public int? LegReturnRateValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42514, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? LegReturnRateValuationStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42515, Type = TagType.Int, Offset = 7, Required = false)]
			public int? LegReturnRateValuationStartDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42516, Type = TagType.Int, Offset = 8, Required = false)]
			public int? LegReturnRateValuationStartDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42517, Type = TagType.String, Offset = 9, Required = false)]
			public string? LegReturnRateValuationStartDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42518, Type = TagType.Int, Offset = 10, Required = false)]
			public int? LegReturnRateValuationStartDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42519, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? LegReturnRateValuationStartDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42520, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? LegReturnRateValuationEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 42521, Type = TagType.Int, Offset = 13, Required = false)]
			public int? LegReturnRateValuationEndDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 42522, Type = TagType.Int, Offset = 14, Required = false)]
			public int? LegReturnRateValuationEndDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 42523, Type = TagType.String, Offset = 15, Required = false)]
			public string? LegReturnRateValuationEndDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 42524, Type = TagType.Int, Offset = 16, Required = false)]
			public int? LegReturnRateValuationEndDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 42525, Type = TagType.LocalDate, Offset = 17, Required = false)]
			public DateOnly? LegReturnRateValuationEndDateAdjusted {get; set;}
			
			[TagDetails(Tag = 42526, Type = TagType.Int, Offset = 18, Required = false)]
			public int? LegReturnRateValuationFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 42527, Type = TagType.String, Offset = 19, Required = false)]
			public string? LegReturnRateValuationFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 42528, Type = TagType.String, Offset = 20, Required = false)]
			public string? LegReturnRateValuationFrequencyRollConvention {get; set;}
			
			[TagDetails(Tag = 42529, Type = TagType.Int, Offset = 21, Required = false)]
			public int? LegReturnRateValuationDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public LegReturnRateValuationDateBusinessCenterGrp? LegReturnRateValuationDateBusinessCenterGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegReturnRateDateMode is not null) writer.WriteWholeNumber(42509, LegReturnRateDateMode.Value);
				if (LegReturnRateValuationDateGrp is not null) ((IFixEncoder)LegReturnRateValuationDateGrp).Encode(writer);
				if (LegReturnRateValuationDateRelativeTo is not null) writer.WriteWholeNumber(42510, LegReturnRateValuationDateRelativeTo.Value);
				if (LegReturnRateValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(42511, LegReturnRateValuationDateOffsetPeriod.Value);
				if (LegReturnRateValuationDateOffsetUnit is not null) writer.WriteString(42512, LegReturnRateValuationDateOffsetUnit);
				if (LegReturnRateValuationDateOffsetDayType is not null) writer.WriteWholeNumber(42513, LegReturnRateValuationDateOffsetDayType.Value);
				if (LegReturnRateValuationStartDateUnadjusted is not null) writer.WriteLocalDateOnly(42514, LegReturnRateValuationStartDateUnadjusted.Value);
				if (LegReturnRateValuationStartDateRelativeTo is not null) writer.WriteWholeNumber(42515, LegReturnRateValuationStartDateRelativeTo.Value);
				if (LegReturnRateValuationStartDateOffsetPeriod is not null) writer.WriteWholeNumber(42516, LegReturnRateValuationStartDateOffsetPeriod.Value);
				if (LegReturnRateValuationStartDateOffsetUnit is not null) writer.WriteString(42517, LegReturnRateValuationStartDateOffsetUnit);
				if (LegReturnRateValuationStartDateOffsetDayType is not null) writer.WriteWholeNumber(42518, LegReturnRateValuationStartDateOffsetDayType.Value);
				if (LegReturnRateValuationStartDateAdjusted is not null) writer.WriteLocalDateOnly(42519, LegReturnRateValuationStartDateAdjusted.Value);
				if (LegReturnRateValuationEndDateUnadjusted is not null) writer.WriteLocalDateOnly(42520, LegReturnRateValuationEndDateUnadjusted.Value);
				if (LegReturnRateValuationEndDateRelativeTo is not null) writer.WriteWholeNumber(42521, LegReturnRateValuationEndDateRelativeTo.Value);
				if (LegReturnRateValuationEndDateOffsetPeriod is not null) writer.WriteWholeNumber(42522, LegReturnRateValuationEndDateOffsetPeriod.Value);
				if (LegReturnRateValuationEndDateOffsetUnit is not null) writer.WriteString(42523, LegReturnRateValuationEndDateOffsetUnit);
				if (LegReturnRateValuationEndDateOffsetDayType is not null) writer.WriteWholeNumber(42524, LegReturnRateValuationEndDateOffsetDayType.Value);
				if (LegReturnRateValuationEndDateAdjusted is not null) writer.WriteLocalDateOnly(42525, LegReturnRateValuationEndDateAdjusted.Value);
				if (LegReturnRateValuationFrequencyPeriod is not null) writer.WriteWholeNumber(42526, LegReturnRateValuationFrequencyPeriod.Value);
				if (LegReturnRateValuationFrequencyUnit is not null) writer.WriteString(42527, LegReturnRateValuationFrequencyUnit);
				if (LegReturnRateValuationFrequencyRollConvention is not null) writer.WriteString(42528, LegReturnRateValuationFrequencyRollConvention);
				if (LegReturnRateValuationDateBusinessDayConvention is not null) writer.WriteWholeNumber(42529, LegReturnRateValuationDateBusinessDayConvention.Value);
				if (LegReturnRateValuationDateBusinessCenterGrp is not null) ((IFixEncoder)LegReturnRateValuationDateBusinessCenterGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegReturnRateDateMode = view.GetInt32(42509);
				if (view.GetView("LegReturnRateValuationDateGrp") is IMessageView viewLegReturnRateValuationDateGrp)
				{
					LegReturnRateValuationDateGrp = new();
					((IFixParser)LegReturnRateValuationDateGrp).Parse(viewLegReturnRateValuationDateGrp);
				}
				LegReturnRateValuationDateRelativeTo = view.GetInt32(42510);
				LegReturnRateValuationDateOffsetPeriod = view.GetInt32(42511);
				LegReturnRateValuationDateOffsetUnit = view.GetString(42512);
				LegReturnRateValuationDateOffsetDayType = view.GetInt32(42513);
				LegReturnRateValuationStartDateUnadjusted = view.GetDateOnly(42514);
				LegReturnRateValuationStartDateRelativeTo = view.GetInt32(42515);
				LegReturnRateValuationStartDateOffsetPeriod = view.GetInt32(42516);
				LegReturnRateValuationStartDateOffsetUnit = view.GetString(42517);
				LegReturnRateValuationStartDateOffsetDayType = view.GetInt32(42518);
				LegReturnRateValuationStartDateAdjusted = view.GetDateOnly(42519);
				LegReturnRateValuationEndDateUnadjusted = view.GetDateOnly(42520);
				LegReturnRateValuationEndDateRelativeTo = view.GetInt32(42521);
				LegReturnRateValuationEndDateOffsetPeriod = view.GetInt32(42522);
				LegReturnRateValuationEndDateOffsetUnit = view.GetString(42523);
				LegReturnRateValuationEndDateOffsetDayType = view.GetInt32(42524);
				LegReturnRateValuationEndDateAdjusted = view.GetDateOnly(42525);
				LegReturnRateValuationFrequencyPeriod = view.GetInt32(42526);
				LegReturnRateValuationFrequencyUnit = view.GetString(42527);
				LegReturnRateValuationFrequencyRollConvention = view.GetString(42528);
				LegReturnRateValuationDateBusinessDayConvention = view.GetInt32(42529);
				if (view.GetView("LegReturnRateValuationDateBusinessCenterGrp") is IMessageView viewLegReturnRateValuationDateBusinessCenterGrp)
				{
					LegReturnRateValuationDateBusinessCenterGrp = new();
					((IFixParser)LegReturnRateValuationDateBusinessCenterGrp).Parse(viewLegReturnRateValuationDateBusinessCenterGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegReturnRateDateMode":
					{
						value = LegReturnRateDateMode;
						break;
					}
					case "LegReturnRateValuationDateGrp":
					{
						value = LegReturnRateValuationDateGrp;
						break;
					}
					case "LegReturnRateValuationDateRelativeTo":
					{
						value = LegReturnRateValuationDateRelativeTo;
						break;
					}
					case "LegReturnRateValuationDateOffsetPeriod":
					{
						value = LegReturnRateValuationDateOffsetPeriod;
						break;
					}
					case "LegReturnRateValuationDateOffsetUnit":
					{
						value = LegReturnRateValuationDateOffsetUnit;
						break;
					}
					case "LegReturnRateValuationDateOffsetDayType":
					{
						value = LegReturnRateValuationDateOffsetDayType;
						break;
					}
					case "LegReturnRateValuationStartDateUnadjusted":
					{
						value = LegReturnRateValuationStartDateUnadjusted;
						break;
					}
					case "LegReturnRateValuationStartDateRelativeTo":
					{
						value = LegReturnRateValuationStartDateRelativeTo;
						break;
					}
					case "LegReturnRateValuationStartDateOffsetPeriod":
					{
						value = LegReturnRateValuationStartDateOffsetPeriod;
						break;
					}
					case "LegReturnRateValuationStartDateOffsetUnit":
					{
						value = LegReturnRateValuationStartDateOffsetUnit;
						break;
					}
					case "LegReturnRateValuationStartDateOffsetDayType":
					{
						value = LegReturnRateValuationStartDateOffsetDayType;
						break;
					}
					case "LegReturnRateValuationStartDateAdjusted":
					{
						value = LegReturnRateValuationStartDateAdjusted;
						break;
					}
					case "LegReturnRateValuationEndDateUnadjusted":
					{
						value = LegReturnRateValuationEndDateUnadjusted;
						break;
					}
					case "LegReturnRateValuationEndDateRelativeTo":
					{
						value = LegReturnRateValuationEndDateRelativeTo;
						break;
					}
					case "LegReturnRateValuationEndDateOffsetPeriod":
					{
						value = LegReturnRateValuationEndDateOffsetPeriod;
						break;
					}
					case "LegReturnRateValuationEndDateOffsetUnit":
					{
						value = LegReturnRateValuationEndDateOffsetUnit;
						break;
					}
					case "LegReturnRateValuationEndDateOffsetDayType":
					{
						value = LegReturnRateValuationEndDateOffsetDayType;
						break;
					}
					case "LegReturnRateValuationEndDateAdjusted":
					{
						value = LegReturnRateValuationEndDateAdjusted;
						break;
					}
					case "LegReturnRateValuationFrequencyPeriod":
					{
						value = LegReturnRateValuationFrequencyPeriod;
						break;
					}
					case "LegReturnRateValuationFrequencyUnit":
					{
						value = LegReturnRateValuationFrequencyUnit;
						break;
					}
					case "LegReturnRateValuationFrequencyRollConvention":
					{
						value = LegReturnRateValuationFrequencyRollConvention;
						break;
					}
					case "LegReturnRateValuationDateBusinessDayConvention":
					{
						value = LegReturnRateValuationDateBusinessDayConvention;
						break;
					}
					case "LegReturnRateValuationDateBusinessCenterGrp":
					{
						value = LegReturnRateValuationDateBusinessCenterGrp;
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
				LegReturnRateDateMode = null;
				((IFixReset?)LegReturnRateValuationDateGrp)?.Reset();
				LegReturnRateValuationDateRelativeTo = null;
				LegReturnRateValuationDateOffsetPeriod = null;
				LegReturnRateValuationDateOffsetUnit = null;
				LegReturnRateValuationDateOffsetDayType = null;
				LegReturnRateValuationStartDateUnadjusted = null;
				LegReturnRateValuationStartDateRelativeTo = null;
				LegReturnRateValuationStartDateOffsetPeriod = null;
				LegReturnRateValuationStartDateOffsetUnit = null;
				LegReturnRateValuationStartDateOffsetDayType = null;
				LegReturnRateValuationStartDateAdjusted = null;
				LegReturnRateValuationEndDateUnadjusted = null;
				LegReturnRateValuationEndDateRelativeTo = null;
				LegReturnRateValuationEndDateOffsetPeriod = null;
				LegReturnRateValuationEndDateOffsetUnit = null;
				LegReturnRateValuationEndDateOffsetDayType = null;
				LegReturnRateValuationEndDateAdjusted = null;
				LegReturnRateValuationFrequencyPeriod = null;
				LegReturnRateValuationFrequencyUnit = null;
				LegReturnRateValuationFrequencyRollConvention = null;
				LegReturnRateValuationDateBusinessDayConvention = null;
				((IFixReset?)LegReturnRateValuationDateBusinessCenterGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 42508, Offset = 0, Required = false)]
		public NoLegReturnRateDates[]? LegReturnRateDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegReturnRateDates is not null && LegReturnRateDates.Length != 0)
			{
				writer.WriteWholeNumber(42508, LegReturnRateDates.Length);
				for (int i = 0; i < LegReturnRateDates.Length; i++)
				{
					((IFixEncoder)LegReturnRateDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegReturnRateDates") is IMessageView viewNoLegReturnRateDates)
			{
				var count = viewNoLegReturnRateDates.GroupCount();
				LegReturnRateDates = new NoLegReturnRateDates[count];
				for (int i = 0; i < count; i++)
				{
					LegReturnRateDates[i] = new();
					((IFixParser)LegReturnRateDates[i]).Parse(viewNoLegReturnRateDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegReturnRateDates":
				{
					value = LegReturnRateDates;
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
			LegReturnRateDates = null;
		}
	}
}
