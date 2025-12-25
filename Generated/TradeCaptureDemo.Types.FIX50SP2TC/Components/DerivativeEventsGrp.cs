using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeEventsGrp : IFixComponent
	{
		public sealed partial class NoDerivativeEvents : IFixGroup
		{
			[TagDetails(Tag = 1287, Type = TagType.Int, Offset = 0, Required = false)]
			public int? DerivativeEventType {get; set;}
			
			[TagDetails(Tag = 1288, Type = TagType.LocalDate, Offset = 1, Required = false)]
			public DateOnly? DerivativeEventDate {get; set;}
			
			[TagDetails(Tag = 1289, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? DerivativeEventTime {get; set;}
			
			[TagDetails(Tag = 1290, Type = TagType.Float, Offset = 3, Required = false)]
			public double? DerivativeEventPx {get; set;}
			
			[TagDetails(Tag = 1291, Type = TagType.String, Offset = 4, Required = false)]
			public string? DerivativeEventText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DerivativeEventType is not null) writer.WriteWholeNumber(1287, DerivativeEventType.Value);
				if (DerivativeEventDate is not null) writer.WriteLocalDateOnly(1288, DerivativeEventDate.Value);
				if (DerivativeEventTime is not null) writer.WriteUtcTimeStamp(1289, DerivativeEventTime.Value);
				if (DerivativeEventPx is not null) writer.WriteNumber(1290, DerivativeEventPx.Value);
				if (DerivativeEventText is not null) writer.WriteString(1291, DerivativeEventText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DerivativeEventType = view.GetInt32(1287);
				DerivativeEventDate = view.GetDateOnly(1288);
				DerivativeEventTime = view.GetDateTime(1289);
				DerivativeEventPx = view.GetDouble(1290);
				DerivativeEventText = view.GetString(1291);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DerivativeEventType":
					{
						value = DerivativeEventType;
						break;
					}
					case "DerivativeEventDate":
					{
						value = DerivativeEventDate;
						break;
					}
					case "DerivativeEventTime":
					{
						value = DerivativeEventTime;
						break;
					}
					case "DerivativeEventPx":
					{
						value = DerivativeEventPx;
						break;
					}
					case "DerivativeEventText":
					{
						value = DerivativeEventText;
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
				DerivativeEventType = null;
				DerivativeEventDate = null;
				DerivativeEventTime = null;
				DerivativeEventPx = null;
				DerivativeEventText = null;
			}
		}
		[Group(NoOfTag = 1286, Offset = 0, Required = false)]
		public NoDerivativeEvents[]? DerivativeEvents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeEvents is not null && DerivativeEvents.Length != 0)
			{
				writer.WriteWholeNumber(1286, DerivativeEvents.Length);
				for (int i = 0; i < DerivativeEvents.Length; i++)
				{
					((IFixEncoder)DerivativeEvents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDerivativeEvents") is IMessageView viewNoDerivativeEvents)
			{
				var count = viewNoDerivativeEvents.GroupCount();
				DerivativeEvents = new NoDerivativeEvents[count];
				for (int i = 0; i < count; i++)
				{
					DerivativeEvents[i] = new();
					((IFixParser)DerivativeEvents[i]).Parse(viewNoDerivativeEvents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDerivativeEvents":
				{
					value = DerivativeEvents;
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
			DerivativeEvents = null;
		}
	}
}
