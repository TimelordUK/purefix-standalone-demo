using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdCollGrp : IFixComponent
	{
		public sealed partial class NoTrades : IFixGroup
		{
			[TagDetails(Tag = 571, Type = TagType.String, Offset = 0, Required = false)]
			public string? TradeReportID {get; set;}
			
			[TagDetails(Tag = 818, Type = TagType.String, Offset = 1, Required = false)]
			public string? SecondaryTradeReportID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradeReportID is not null) writer.WriteString(571, TradeReportID);
				if (SecondaryTradeReportID is not null) writer.WriteString(818, SecondaryTradeReportID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradeReportID = view.GetString(571);
				SecondaryTradeReportID = view.GetString(818);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TradeReportID":
					{
						value = TradeReportID;
						break;
					}
					case "SecondaryTradeReportID":
					{
						value = SecondaryTradeReportID;
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
				TradeReportID = null;
				SecondaryTradeReportID = null;
			}
		}
		[Group(NoOfTag = 897, Offset = 0, Required = false)]
		public NoTrades[]? Trades {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Trades is not null && Trades.Length != 0)
			{
				writer.WriteWholeNumber(897, Trades.Length);
				for (int i = 0; i < Trades.Length; i++)
				{
					((IFixEncoder)Trades[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTrades") is IMessageView viewNoTrades)
			{
				var count = viewNoTrades.GroupCount();
				Trades = new NoTrades[count];
				for (int i = 0; i < count; i++)
				{
					Trades[i] = new();
					((IFixParser)Trades[i]).Parse(viewNoTrades.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTrades":
				{
					value = Trades;
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
			Trades = null;
		}
	}
}
