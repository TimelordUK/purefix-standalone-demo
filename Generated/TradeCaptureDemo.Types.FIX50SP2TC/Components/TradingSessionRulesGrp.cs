using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TradingSessionRulesGrp : IFixComponent
	{
		public sealed partial class NoTradingSessionRules : IFixGroup
		{
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 0, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 1, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public TradingSessionRules? TradingSessionRules {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (TradingSessionRules is not null) ((IFixEncoder)TradingSessionRules).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				if (view.GetView("TradingSessionRules") is IMessageView viewTradingSessionRules)
				{
					TradingSessionRules = new();
					((IFixParser)TradingSessionRules).Parse(viewTradingSessionRules);
				}
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
					case "TradingSessionRules":
					{
						value = TradingSessionRules;
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
				((IFixReset?)TradingSessionRules)?.Reset();
			}
		}
		[Group(NoOfTag = 1309, Offset = 0, Required = false)]
		public NoTradingSessionRules[]? TradingSessionRules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TradingSessionRules is not null && TradingSessionRules.Length != 0)
			{
				writer.WriteWholeNumber(1309, TradingSessionRules.Length);
				for (int i = 0; i < TradingSessionRules.Length; i++)
				{
					((IFixEncoder)TradingSessionRules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTradingSessionRules") is IMessageView viewNoTradingSessionRules)
			{
				var count = viewNoTradingSessionRules.GroupCount();
				TradingSessionRules = new NoTradingSessionRules[count];
				for (int i = 0; i < count; i++)
				{
					TradingSessionRules[i] = new();
					((IFixParser)TradingSessionRules[i]).Parse(viewNoTradingSessionRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTradingSessionRules":
				{
					value = TradingSessionRules;
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
			TradingSessionRules = null;
		}
	}
}
