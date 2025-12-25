using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class Hop : IFixComponent
	{
		public sealed partial class NoHops : IFixGroup
		{
			[TagDetails(Tag = 628, Type = TagType.String, Offset = 0, Required = false)]
			public string? HopCompID {get; set;}
			
			[TagDetails(Tag = 629, Type = TagType.UtcTimestamp, Offset = 1, Required = false)]
			public DateTime? HopSendingTime {get; set;}
			
			[TagDetails(Tag = 630, Type = TagType.Int, Offset = 2, Required = false)]
			public int? HopRefID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (HopCompID is not null) writer.WriteString(628, HopCompID);
				if (HopSendingTime is not null) writer.WriteUtcTimeStamp(629, HopSendingTime.Value);
				if (HopRefID is not null) writer.WriteWholeNumber(630, HopRefID.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				HopCompID = view.GetString(628);
				HopSendingTime = view.GetDateTime(629);
				HopRefID = view.GetInt32(630);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "HopCompID":
					{
						value = HopCompID;
						break;
					}
					case "HopSendingTime":
					{
						value = HopSendingTime;
						break;
					}
					case "HopRefID":
					{
						value = HopRefID;
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
				HopCompID = null;
				HopSendingTime = null;
				HopRefID = null;
			}
		}
		[Group(NoOfTag = 627, Offset = 0, Required = false)]
		public NoHops[]? Hops {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Hops is not null && Hops.Length != 0)
			{
				writer.WriteWholeNumber(627, Hops.Length);
				for (int i = 0; i < Hops.Length; i++)
				{
					((IFixEncoder)Hops[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoHops") is IMessageView viewNoHops)
			{
				var count = viewNoHops.GroupCount();
				Hops = new NoHops[count];
				for (int i = 0; i < count; i++)
				{
					Hops[i] = new();
					((IFixParser)Hops[i]).Parse(viewNoHops.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoHops":
				{
					value = Hops;
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
			Hops = null;
		}
	}
}
