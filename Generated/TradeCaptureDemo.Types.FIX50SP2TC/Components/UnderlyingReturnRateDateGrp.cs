using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingReturnRateDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingReturnRateDates : IFixGroup
		{
			[TagDetails(Tag = 43009, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingReturnRateDateMode {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public UnderlyingReturnRateValuationDateGrp? UnderlyingReturnRateValuationDateGrp {get; set;}
			
			[TagDetails(Tag = 43010, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingReturnRateValuationDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 43011, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingReturnRateValuationDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 43012, Type = TagType.String, Offset = 4, Required = false)]
			public string? UnderlyingReturnRateValuationDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 43013, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnderlyingReturnRateValuationDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 43014, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? UnderlyingReturnRateValuationStartDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 43015, Type = TagType.Int, Offset = 7, Required = false)]
			public int? UnderlyingReturnRateValuationStartDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 43016, Type = TagType.Int, Offset = 8, Required = false)]
			public int? UnderlyingReturnRateValuationStartDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 43017, Type = TagType.String, Offset = 9, Required = false)]
			public string? UnderlyingReturnRateValuationStartDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 43018, Type = TagType.Int, Offset = 10, Required = false)]
			public int? UnderlyingReturnRateValuationStartDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 43019, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? UnderlyingReturnRateValuationStartDateAdjusted {get; set;}
			
			[TagDetails(Tag = 43020, Type = TagType.LocalDate, Offset = 12, Required = false)]
			public DateOnly? UnderlyingReturnRateValuationEndDateUnadjusted {get; set;}
			
			[TagDetails(Tag = 43021, Type = TagType.Int, Offset = 13, Required = false)]
			public int? UnderlyingReturnRateValuationEndDateRelativeTo {get; set;}
			
			[TagDetails(Tag = 43022, Type = TagType.Int, Offset = 14, Required = false)]
			public int? UnderlyingReturnRateValuationEndDateOffsetPeriod {get; set;}
			
			[TagDetails(Tag = 43023, Type = TagType.String, Offset = 15, Required = false)]
			public string? UnderlyingReturnRateValuationEndDateOffsetUnit {get; set;}
			
			[TagDetails(Tag = 43024, Type = TagType.Int, Offset = 16, Required = false)]
			public int? UnderlyingReturnRateValuationEndDateOffsetDayType {get; set;}
			
			[TagDetails(Tag = 43025, Type = TagType.LocalDate, Offset = 17, Required = false)]
			public DateOnly? UnderlyingReturnRateValuationEndDateAdjusted {get; set;}
			
			[TagDetails(Tag = 43026, Type = TagType.Int, Offset = 18, Required = false)]
			public int? UnderlyingReturnRateValuationFrequencyPeriod {get; set;}
			
			[TagDetails(Tag = 43027, Type = TagType.String, Offset = 19, Required = false)]
			public string? UnderlyingReturnRateValuationFrequencyUnit {get; set;}
			
			[TagDetails(Tag = 43028, Type = TagType.String, Offset = 20, Required = false)]
			public string? UnderlyingReturnRateValuationFrequencyRollConvention {get; set;}
			
			[TagDetails(Tag = 43029, Type = TagType.Int, Offset = 21, Required = false)]
			public int? UnderlyingReturnRateValuationDateBusinessDayConvention {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public UnderlyingReturnRateValuationDateBusinessCenterGrp? UnderlyingReturnRateValuationDateBusinessCenterGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingReturnRateDateMode is not null) writer.WriteWholeNumber(43009, UnderlyingReturnRateDateMode.Value);
				if (UnderlyingReturnRateValuationDateGrp is not null) ((IFixEncoder)UnderlyingReturnRateValuationDateGrp).Encode(writer);
				if (UnderlyingReturnRateValuationDateRelativeTo is not null) writer.WriteWholeNumber(43010, UnderlyingReturnRateValuationDateRelativeTo.Value);
				if (UnderlyingReturnRateValuationDateOffsetPeriod is not null) writer.WriteWholeNumber(43011, UnderlyingReturnRateValuationDateOffsetPeriod.Value);
				if (UnderlyingReturnRateValuationDateOffsetUnit is not null) writer.WriteString(43012, UnderlyingReturnRateValuationDateOffsetUnit);
				if (UnderlyingReturnRateValuationDateOffsetDayType is not null) writer.WriteWholeNumber(43013, UnderlyingReturnRateValuationDateOffsetDayType.Value);
				if (UnderlyingReturnRateValuationStartDateUnadjusted is not null) writer.WriteLocalDateOnly(43014, UnderlyingReturnRateValuationStartDateUnadjusted.Value);
				if (UnderlyingReturnRateValuationStartDateRelativeTo is not null) writer.WriteWholeNumber(43015, UnderlyingReturnRateValuationStartDateRelativeTo.Value);
				if (UnderlyingReturnRateValuationStartDateOffsetPeriod is not null) writer.WriteWholeNumber(43016, UnderlyingReturnRateValuationStartDateOffsetPeriod.Value);
				if (UnderlyingReturnRateValuationStartDateOffsetUnit is not null) writer.WriteString(43017, UnderlyingReturnRateValuationStartDateOffsetUnit);
				if (UnderlyingReturnRateValuationStartDateOffsetDayType is not null) writer.WriteWholeNumber(43018, UnderlyingReturnRateValuationStartDateOffsetDayType.Value);
				if (UnderlyingReturnRateValuationStartDateAdjusted is not null) writer.WriteLocalDateOnly(43019, UnderlyingReturnRateValuationStartDateAdjusted.Value);
				if (UnderlyingReturnRateValuationEndDateUnadjusted is not null) writer.WriteLocalDateOnly(43020, UnderlyingReturnRateValuationEndDateUnadjusted.Value);
				if (UnderlyingReturnRateValuationEndDateRelativeTo is not null) writer.WriteWholeNumber(43021, UnderlyingReturnRateValuationEndDateRelativeTo.Value);
				if (UnderlyingReturnRateValuationEndDateOffsetPeriod is not null) writer.WriteWholeNumber(43022, UnderlyingReturnRateValuationEndDateOffsetPeriod.Value);
				if (UnderlyingReturnRateValuationEndDateOffsetUnit is not null) writer.WriteString(43023, UnderlyingReturnRateValuationEndDateOffsetUnit);
				if (UnderlyingReturnRateValuationEndDateOffsetDayType is not null) writer.WriteWholeNumber(43024, UnderlyingReturnRateValuationEndDateOffsetDayType.Value);
				if (UnderlyingReturnRateValuationEndDateAdjusted is not null) writer.WriteLocalDateOnly(43025, UnderlyingReturnRateValuationEndDateAdjusted.Value);
				if (UnderlyingReturnRateValuationFrequencyPeriod is not null) writer.WriteWholeNumber(43026, UnderlyingReturnRateValuationFrequencyPeriod.Value);
				if (UnderlyingReturnRateValuationFrequencyUnit is not null) writer.WriteString(43027, UnderlyingReturnRateValuationFrequencyUnit);
				if (UnderlyingReturnRateValuationFrequencyRollConvention is not null) writer.WriteString(43028, UnderlyingReturnRateValuationFrequencyRollConvention);
				if (UnderlyingReturnRateValuationDateBusinessDayConvention is not null) writer.WriteWholeNumber(43029, UnderlyingReturnRateValuationDateBusinessDayConvention.Value);
				if (UnderlyingReturnRateValuationDateBusinessCenterGrp is not null) ((IFixEncoder)UnderlyingReturnRateValuationDateBusinessCenterGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingReturnRateDateMode = view.GetInt32(43009);
				if (view.GetView("UnderlyingReturnRateValuationDateGrp") is IMessageView viewUnderlyingReturnRateValuationDateGrp)
				{
					UnderlyingReturnRateValuationDateGrp = new();
					((IFixParser)UnderlyingReturnRateValuationDateGrp).Parse(viewUnderlyingReturnRateValuationDateGrp);
				}
				UnderlyingReturnRateValuationDateRelativeTo = view.GetInt32(43010);
				UnderlyingReturnRateValuationDateOffsetPeriod = view.GetInt32(43011);
				UnderlyingReturnRateValuationDateOffsetUnit = view.GetString(43012);
				UnderlyingReturnRateValuationDateOffsetDayType = view.GetInt32(43013);
				UnderlyingReturnRateValuationStartDateUnadjusted = view.GetDateOnly(43014);
				UnderlyingReturnRateValuationStartDateRelativeTo = view.GetInt32(43015);
				UnderlyingReturnRateValuationStartDateOffsetPeriod = view.GetInt32(43016);
				UnderlyingReturnRateValuationStartDateOffsetUnit = view.GetString(43017);
				UnderlyingReturnRateValuationStartDateOffsetDayType = view.GetInt32(43018);
				UnderlyingReturnRateValuationStartDateAdjusted = view.GetDateOnly(43019);
				UnderlyingReturnRateValuationEndDateUnadjusted = view.GetDateOnly(43020);
				UnderlyingReturnRateValuationEndDateRelativeTo = view.GetInt32(43021);
				UnderlyingReturnRateValuationEndDateOffsetPeriod = view.GetInt32(43022);
				UnderlyingReturnRateValuationEndDateOffsetUnit = view.GetString(43023);
				UnderlyingReturnRateValuationEndDateOffsetDayType = view.GetInt32(43024);
				UnderlyingReturnRateValuationEndDateAdjusted = view.GetDateOnly(43025);
				UnderlyingReturnRateValuationFrequencyPeriod = view.GetInt32(43026);
				UnderlyingReturnRateValuationFrequencyUnit = view.GetString(43027);
				UnderlyingReturnRateValuationFrequencyRollConvention = view.GetString(43028);
				UnderlyingReturnRateValuationDateBusinessDayConvention = view.GetInt32(43029);
				if (view.GetView("UnderlyingReturnRateValuationDateBusinessCenterGrp") is IMessageView viewUnderlyingReturnRateValuationDateBusinessCenterGrp)
				{
					UnderlyingReturnRateValuationDateBusinessCenterGrp = new();
					((IFixParser)UnderlyingReturnRateValuationDateBusinessCenterGrp).Parse(viewUnderlyingReturnRateValuationDateBusinessCenterGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingReturnRateDateMode":
					{
						value = UnderlyingReturnRateDateMode;
						break;
					}
					case "UnderlyingReturnRateValuationDateGrp":
					{
						value = UnderlyingReturnRateValuationDateGrp;
						break;
					}
					case "UnderlyingReturnRateValuationDateRelativeTo":
					{
						value = UnderlyingReturnRateValuationDateRelativeTo;
						break;
					}
					case "UnderlyingReturnRateValuationDateOffsetPeriod":
					{
						value = UnderlyingReturnRateValuationDateOffsetPeriod;
						break;
					}
					case "UnderlyingReturnRateValuationDateOffsetUnit":
					{
						value = UnderlyingReturnRateValuationDateOffsetUnit;
						break;
					}
					case "UnderlyingReturnRateValuationDateOffsetDayType":
					{
						value = UnderlyingReturnRateValuationDateOffsetDayType;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateUnadjusted":
					{
						value = UnderlyingReturnRateValuationStartDateUnadjusted;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateRelativeTo":
					{
						value = UnderlyingReturnRateValuationStartDateRelativeTo;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateOffsetPeriod":
					{
						value = UnderlyingReturnRateValuationStartDateOffsetPeriod;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateOffsetUnit":
					{
						value = UnderlyingReturnRateValuationStartDateOffsetUnit;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateOffsetDayType":
					{
						value = UnderlyingReturnRateValuationStartDateOffsetDayType;
						break;
					}
					case "UnderlyingReturnRateValuationStartDateAdjusted":
					{
						value = UnderlyingReturnRateValuationStartDateAdjusted;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateUnadjusted":
					{
						value = UnderlyingReturnRateValuationEndDateUnadjusted;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateRelativeTo":
					{
						value = UnderlyingReturnRateValuationEndDateRelativeTo;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateOffsetPeriod":
					{
						value = UnderlyingReturnRateValuationEndDateOffsetPeriod;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateOffsetUnit":
					{
						value = UnderlyingReturnRateValuationEndDateOffsetUnit;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateOffsetDayType":
					{
						value = UnderlyingReturnRateValuationEndDateOffsetDayType;
						break;
					}
					case "UnderlyingReturnRateValuationEndDateAdjusted":
					{
						value = UnderlyingReturnRateValuationEndDateAdjusted;
						break;
					}
					case "UnderlyingReturnRateValuationFrequencyPeriod":
					{
						value = UnderlyingReturnRateValuationFrequencyPeriod;
						break;
					}
					case "UnderlyingReturnRateValuationFrequencyUnit":
					{
						value = UnderlyingReturnRateValuationFrequencyUnit;
						break;
					}
					case "UnderlyingReturnRateValuationFrequencyRollConvention":
					{
						value = UnderlyingReturnRateValuationFrequencyRollConvention;
						break;
					}
					case "UnderlyingReturnRateValuationDateBusinessDayConvention":
					{
						value = UnderlyingReturnRateValuationDateBusinessDayConvention;
						break;
					}
					case "UnderlyingReturnRateValuationDateBusinessCenterGrp":
					{
						value = UnderlyingReturnRateValuationDateBusinessCenterGrp;
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
				UnderlyingReturnRateDateMode = null;
				((IFixReset?)UnderlyingReturnRateValuationDateGrp)?.Reset();
				UnderlyingReturnRateValuationDateRelativeTo = null;
				UnderlyingReturnRateValuationDateOffsetPeriod = null;
				UnderlyingReturnRateValuationDateOffsetUnit = null;
				UnderlyingReturnRateValuationDateOffsetDayType = null;
				UnderlyingReturnRateValuationStartDateUnadjusted = null;
				UnderlyingReturnRateValuationStartDateRelativeTo = null;
				UnderlyingReturnRateValuationStartDateOffsetPeriod = null;
				UnderlyingReturnRateValuationStartDateOffsetUnit = null;
				UnderlyingReturnRateValuationStartDateOffsetDayType = null;
				UnderlyingReturnRateValuationStartDateAdjusted = null;
				UnderlyingReturnRateValuationEndDateUnadjusted = null;
				UnderlyingReturnRateValuationEndDateRelativeTo = null;
				UnderlyingReturnRateValuationEndDateOffsetPeriod = null;
				UnderlyingReturnRateValuationEndDateOffsetUnit = null;
				UnderlyingReturnRateValuationEndDateOffsetDayType = null;
				UnderlyingReturnRateValuationEndDateAdjusted = null;
				UnderlyingReturnRateValuationFrequencyPeriod = null;
				UnderlyingReturnRateValuationFrequencyUnit = null;
				UnderlyingReturnRateValuationFrequencyRollConvention = null;
				UnderlyingReturnRateValuationDateBusinessDayConvention = null;
				((IFixReset?)UnderlyingReturnRateValuationDateBusinessCenterGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 43008, Offset = 0, Required = false)]
		public NoUnderlyingReturnRateDates[]? UnderlyingReturnRateDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingReturnRateDates is not null && UnderlyingReturnRateDates.Length != 0)
			{
				writer.WriteWholeNumber(43008, UnderlyingReturnRateDates.Length);
				for (int i = 0; i < UnderlyingReturnRateDates.Length; i++)
				{
					((IFixEncoder)UnderlyingReturnRateDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingReturnRateDates") is IMessageView viewNoUnderlyingReturnRateDates)
			{
				var count = viewNoUnderlyingReturnRateDates.GroupCount();
				UnderlyingReturnRateDates = new NoUnderlyingReturnRateDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingReturnRateDates[i] = new();
					((IFixParser)UnderlyingReturnRateDates[i]).Parse(viewNoUnderlyingReturnRateDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingReturnRateDates":
				{
					value = UnderlyingReturnRateDates;
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
			UnderlyingReturnRateDates = null;
		}
	}
}
