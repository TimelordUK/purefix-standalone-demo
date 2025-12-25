using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdgSesGrp : IFixComponent
	{
		public sealed partial class NoTradingSessions : IFixGroup
		{
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 0, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 1, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TradingSessionID":
					{
						value = TradingSessionID;
						break;
					}
					case "TradingSessionSubID":
					{
						value = TradingSessionSubID;
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
				TradingSessionID = null;
				TradingSessionSubID = null;
			}
		}
		[Group(NoOfTag = 386, Offset = 0, Required = false)]
		public NoTradingSessions[]? TradingSessions {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TradingSessions is not null && TradingSessions.Length != 0)
			{
				writer.WriteWholeNumber(386, TradingSessions.Length);
				for (int i = 0; i < TradingSessions.Length; i++)
				{
					((IFixEncoder)TradingSessions[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTradingSessions") is IMessageView viewNoTradingSessions)
			{
				var count = viewNoTradingSessions.GroupCount();
				TradingSessions = new NoTradingSessions[count];
				for (int i = 0; i < count; i++)
				{
					TradingSessions[i] = new();
					((IFixParser)TradingSessions[i]).Parse(viewNoTradingSessions.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTradingSessions":
				{
					value = TradingSessions;
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
			TradingSessions = null;
		}
	}
}
