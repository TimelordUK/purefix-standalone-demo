using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingEvntGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingEvents : IFixGroup
		{
			[TagDetails(Tag = 1982, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingEventType {get; set;}
			
			[TagDetails(Tag = 1983, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? UnderlyingEventDate {get; set;}
			
			[TagDetails(Tag = 1984, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? UnderlyingEventTime {get; set;}
			
			[TagDetails(Tag = 1985, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingEventTimeUnit {get; set;}
			
			[TagDetails(Tag = 1986, Type = TagType.Int, Offset = 4, Required = false)]
			public int? UnderlyingEventTimePeriod {get; set;}
			
			[TagDetails(Tag = 2342, Type = TagType.MonthYear, Offset = 5, Required = false)]
			public MonthYear? UnderlyingEventMonthYear {get; set;}
			
			[TagDetails(Tag = 1987, Type = TagType.Float, Offset = 6, Required = false)]
			public double? UnderlyingEventPx {get; set;}
			
			[TagDetails(Tag = 2071, Type = TagType.String, Offset = 7, Required = false)]
			public string? UnderlyingEventText {get; set;}
			
			[TagDetails(Tag = 2072, Type = TagType.Length, Offset = 8, Required = false)]
			public int? EncodedUnderlyingEventTextLen {get; set;}
			
			[TagDetails(Tag = 2073, Type = TagType.RawData, Offset = 9, Required = false)]
			public byte[]? EncodedUnderlyingEventText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingEventType is not null) writer.WriteWholeNumber(1982, UnderlyingEventType.Value);
				if (UnderlyingEventDate is not null) writer.WriteLocalDateOnly(1983, UnderlyingEventDate.Value);
				if (UnderlyingEventTime is not null) writer.WriteUtcTimeStamp(1984, UnderlyingEventTime.Value);
				if (UnderlyingEventTimeUnit is not null) writer.WriteString(1985, UnderlyingEventTimeUnit);
				if (UnderlyingEventTimePeriod is not null) writer.WriteWholeNumber(1986, UnderlyingEventTimePeriod.Value);
				if (UnderlyingEventMonthYear is not null) writer.WriteMonthYear(2342, UnderlyingEventMonthYear.Value);
				if (UnderlyingEventPx is not null) writer.WriteNumber(1987, UnderlyingEventPx.Value);
				if (UnderlyingEventText is not null) writer.WriteString(2071, UnderlyingEventText);
				if (EncodedUnderlyingEventTextLen is not null) writer.WriteWholeNumber(2072, EncodedUnderlyingEventTextLen.Value);
				if (EncodedUnderlyingEventText is not null) writer.WriteBuffer(2073, EncodedUnderlyingEventText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingEventType = view.GetInt32(1982);
				UnderlyingEventDate = view.GetDateOnly(1983);
				UnderlyingEventTime = view.GetDateTime(1984);
				UnderlyingEventTimeUnit = view.GetString(1985);
				UnderlyingEventTimePeriod = view.GetInt32(1986);
				UnderlyingEventMonthYear = view.GetMonthYear(2342);
				UnderlyingEventPx = view.GetDouble(1987);
				UnderlyingEventText = view.GetString(2071);
				EncodedUnderlyingEventTextLen = view.GetInt32(2072);
				EncodedUnderlyingEventText = view.GetByteArray(2073);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingEventType":
					{
						value = UnderlyingEventType;
						break;
					}
					case "UnderlyingEventDate":
					{
						value = UnderlyingEventDate;
						break;
					}
					case "UnderlyingEventTime":
					{
						value = UnderlyingEventTime;
						break;
					}
					case "UnderlyingEventTimeUnit":
					{
						value = UnderlyingEventTimeUnit;
						break;
					}
					case "UnderlyingEventTimePeriod":
					{
						value = UnderlyingEventTimePeriod;
						break;
					}
					case "UnderlyingEventMonthYear":
					{
						value = UnderlyingEventMonthYear;
						break;
					}
					case "UnderlyingEventPx":
					{
						value = UnderlyingEventPx;
						break;
					}
					case "UnderlyingEventText":
					{
						value = UnderlyingEventText;
						break;
					}
					case "EncodedUnderlyingEventTextLen":
					{
						value = EncodedUnderlyingEventTextLen;
						break;
					}
					case "EncodedUnderlyingEventText":
					{
						value = EncodedUnderlyingEventText;
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
				UnderlyingEventType = null;
				UnderlyingEventDate = null;
				UnderlyingEventTime = null;
				UnderlyingEventTimeUnit = null;
				UnderlyingEventTimePeriod = null;
				UnderlyingEventMonthYear = null;
				UnderlyingEventPx = null;
				UnderlyingEventText = null;
				EncodedUnderlyingEventTextLen = null;
				EncodedUnderlyingEventText = null;
			}
		}
		[Group(NoOfTag = 1981, Offset = 0, Required = false)]
		public NoUnderlyingEvents[]? UnderlyingEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingEvents is not null && UnderlyingEvents.Length != 0)
			{
				writer.WriteWholeNumber(1981, UnderlyingEvents.Length);
				for (int i = 0; i < UnderlyingEvents.Length; i++)
				{
					((IFixEncoder)UnderlyingEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingEvents") is IMessageView viewNoUnderlyingEvents)
			{
				var count = viewNoUnderlyingEvents.GroupCount();
				UnderlyingEvents = new NoUnderlyingEvents[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingEvents[i] = new();
					((IFixParser)UnderlyingEvents[i]).Parse(viewNoUnderlyingEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingEvents":
				{
					value = UnderlyingEvents;
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
			UnderlyingEvents = null;
		}
	}
}
