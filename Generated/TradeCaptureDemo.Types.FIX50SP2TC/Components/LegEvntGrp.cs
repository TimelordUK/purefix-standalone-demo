using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegEvntGrp : IFixComponent
	{
		public sealed partial class NoLegEvents : IFixGroup
		{
			[TagDetails(Tag = 2060, Type = TagType.Int, Offset = 0, Required = false)]
			public int? LegEventType {get; set;}
			
			[TagDetails(Tag = 2061, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? LegEventDate {get; set;}
			
			[TagDetails(Tag = 2062, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? LegEventTime {get; set;}
			
			[TagDetails(Tag = 2063, Type = TagType.String, Offset = 3, Required = false)]
			public string? LegEventTimeUnit {get; set;}
			
			[TagDetails(Tag = 2064, Type = TagType.Int, Offset = 4, Required = false)]
			public int? LegEventTimePeriod {get; set;}
			
			[TagDetails(Tag = 2341, Type = TagType.MonthYear, Offset = 5, Required = false)]
			public MonthYear? LegEventMonthYear {get; set;}
			
			[TagDetails(Tag = 2065, Type = TagType.Float, Offset = 6, Required = false)]
			public double? LegEventPx {get; set;}
			
			[TagDetails(Tag = 2066, Type = TagType.String, Offset = 7, Required = false)]
			public string? LegEventText {get; set;}
			
			[TagDetails(Tag = 2074, Type = TagType.Length, Offset = 8, Required = false)]
			public int? EncodedLegEventTextLen {get; set;}
			
			[TagDetails(Tag = 2075, Type = TagType.RawData, Offset = 9, Required = false)]
			public byte[]? EncodedLegEventText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegEventType is not null) writer.WriteWholeNumber(2060, LegEventType.Value);
				if (LegEventDate is not null) writer.WriteLocalDateOnly(2061, LegEventDate.Value);
				if (LegEventTime is not null) writer.WriteUtcTimeStamp(2062, LegEventTime.Value);
				if (LegEventTimeUnit is not null) writer.WriteString(2063, LegEventTimeUnit);
				if (LegEventTimePeriod is not null) writer.WriteWholeNumber(2064, LegEventTimePeriod.Value);
				if (LegEventMonthYear is not null) writer.WriteMonthYear(2341, LegEventMonthYear.Value);
				if (LegEventPx is not null) writer.WriteNumber(2065, LegEventPx.Value);
				if (LegEventText is not null) writer.WriteString(2066, LegEventText);
				if (EncodedLegEventTextLen is not null) writer.WriteWholeNumber(2074, EncodedLegEventTextLen.Value);
				if (EncodedLegEventText is not null) writer.WriteBuffer(2075, EncodedLegEventText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegEventType = view.GetInt32(2060);
				LegEventDate = view.GetDateOnly(2061);
				LegEventTime = view.GetDateTime(2062);
				LegEventTimeUnit = view.GetString(2063);
				LegEventTimePeriod = view.GetInt32(2064);
				LegEventMonthYear = view.GetMonthYear(2341);
				LegEventPx = view.GetDouble(2065);
				LegEventText = view.GetString(2066);
				EncodedLegEventTextLen = view.GetInt32(2074);
				EncodedLegEventText = view.GetByteArray(2075);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegEventType":
					{
						value = LegEventType;
						break;
					}
					case "LegEventDate":
					{
						value = LegEventDate;
						break;
					}
					case "LegEventTime":
					{
						value = LegEventTime;
						break;
					}
					case "LegEventTimeUnit":
					{
						value = LegEventTimeUnit;
						break;
					}
					case "LegEventTimePeriod":
					{
						value = LegEventTimePeriod;
						break;
					}
					case "LegEventMonthYear":
					{
						value = LegEventMonthYear;
						break;
					}
					case "LegEventPx":
					{
						value = LegEventPx;
						break;
					}
					case "LegEventText":
					{
						value = LegEventText;
						break;
					}
					case "EncodedLegEventTextLen":
					{
						value = EncodedLegEventTextLen;
						break;
					}
					case "EncodedLegEventText":
					{
						value = EncodedLegEventText;
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
				LegEventType = null;
				LegEventDate = null;
				LegEventTime = null;
				LegEventTimeUnit = null;
				LegEventTimePeriod = null;
				LegEventMonthYear = null;
				LegEventPx = null;
				LegEventText = null;
				EncodedLegEventTextLen = null;
				EncodedLegEventText = null;
			}
		}
		[Group(NoOfTag = 2059, Offset = 0, Required = false)]
		public NoLegEvents[]? LegEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegEvents is not null && LegEvents.Length != 0)
			{
				writer.WriteWholeNumber(2059, LegEvents.Length);
				for (int i = 0; i < LegEvents.Length; i++)
				{
					((IFixEncoder)LegEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegEvents") is IMessageView viewNoLegEvents)
			{
				var count = viewNoLegEvents.GroupCount();
				LegEvents = new NoLegEvents[count];
				for (int i = 0; i < count; i++)
				{
					LegEvents[i] = new();
					((IFixParser)LegEvents[i]).Parse(viewNoLegEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegEvents":
				{
					value = LegEvents;
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
			LegEvents = null;
		}
	}
}
