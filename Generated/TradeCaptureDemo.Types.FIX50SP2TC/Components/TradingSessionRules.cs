using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TradingSessionRules : IFixComponent
	{
		[Component(Offset = 0, Required = false)]
		public OrdTypeRules? OrdTypeRules {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public TimeInForceRules? TimeInForceRules {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public ExecInstRules? ExecInstRules {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public AuctionTypeRuleGrp? AuctionTypeRuleGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public MatchRules? MatchRules {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public MarketDataFeedTypes? MarketDataFeedTypes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OrdTypeRules is not null) ((IFixEncoder)OrdTypeRules).Encode(writer);
			if (TimeInForceRules is not null) ((IFixEncoder)TimeInForceRules).Encode(writer);
			if (ExecInstRules is not null) ((IFixEncoder)ExecInstRules).Encode(writer);
			if (AuctionTypeRuleGrp is not null) ((IFixEncoder)AuctionTypeRuleGrp).Encode(writer);
			if (MatchRules is not null) ((IFixEncoder)MatchRules).Encode(writer);
			if (MarketDataFeedTypes is not null) ((IFixEncoder)MarketDataFeedTypes).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("OrdTypeRules") is IMessageView viewOrdTypeRules)
			{
				OrdTypeRules = new();
				((IFixParser)OrdTypeRules).Parse(viewOrdTypeRules);
			}
			if (view.GetView("TimeInForceRules") is IMessageView viewTimeInForceRules)
			{
				TimeInForceRules = new();
				((IFixParser)TimeInForceRules).Parse(viewTimeInForceRules);
			}
			if (view.GetView("ExecInstRules") is IMessageView viewExecInstRules)
			{
				ExecInstRules = new();
				((IFixParser)ExecInstRules).Parse(viewExecInstRules);
			}
			if (view.GetView("AuctionTypeRuleGrp") is IMessageView viewAuctionTypeRuleGrp)
			{
				AuctionTypeRuleGrp = new();
				((IFixParser)AuctionTypeRuleGrp).Parse(viewAuctionTypeRuleGrp);
			}
			if (view.GetView("MatchRules") is IMessageView viewMatchRules)
			{
				MatchRules = new();
				((IFixParser)MatchRules).Parse(viewMatchRules);
			}
			if (view.GetView("MarketDataFeedTypes") is IMessageView viewMarketDataFeedTypes)
			{
				MarketDataFeedTypes = new();
				((IFixParser)MarketDataFeedTypes).Parse(viewMarketDataFeedTypes);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "OrdTypeRules":
				{
					value = OrdTypeRules;
					break;
				}
				case "TimeInForceRules":
				{
					value = TimeInForceRules;
					break;
				}
				case "ExecInstRules":
				{
					value = ExecInstRules;
					break;
				}
				case "AuctionTypeRuleGrp":
				{
					value = AuctionTypeRuleGrp;
					break;
				}
				case "MatchRules":
				{
					value = MatchRules;
					break;
				}
				case "MarketDataFeedTypes":
				{
					value = MarketDataFeedTypes;
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
			((IFixReset?)OrdTypeRules)?.Reset();
			((IFixReset?)TimeInForceRules)?.Reset();
			((IFixReset?)ExecInstRules)?.Reset();
			((IFixReset?)AuctionTypeRuleGrp)?.Reset();
			((IFixReset?)MatchRules)?.Reset();
			((IFixReset?)MarketDataFeedTypes)?.Reset();
		}
	}
}
