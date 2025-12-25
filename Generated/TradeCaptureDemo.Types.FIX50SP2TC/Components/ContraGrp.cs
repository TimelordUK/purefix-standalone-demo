using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ContraGrp : IFixComponent
	{
		public sealed partial class NoContraBrokers : IFixGroup
		{
			[TagDetails(Tag = 375, Type = TagType.String, Offset = 0, Required = false)]
			public string? ContraBroker {get; set;}
			
			[TagDetails(Tag = 337, Type = TagType.String, Offset = 1, Required = false)]
			public string? ContraTrader {get; set;}
			
			[TagDetails(Tag = 437, Type = TagType.Float, Offset = 2, Required = false)]
			public double? ContraTradeQty {get; set;}
			
			[TagDetails(Tag = 438, Type = TagType.UtcTimestamp, Offset = 3, Required = false)]
			public DateTime? ContraTradeTime {get; set;}
			
			[TagDetails(Tag = 655, Type = TagType.String, Offset = 4, Required = false)]
			public string? ContraLegRefID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ContraBroker is not null) writer.WriteString(375, ContraBroker);
				if (ContraTrader is not null) writer.WriteString(337, ContraTrader);
				if (ContraTradeQty is not null) writer.WriteNumber(437, ContraTradeQty.Value);
				if (ContraTradeTime is not null) writer.WriteUtcTimeStamp(438, ContraTradeTime.Value);
				if (ContraLegRefID is not null) writer.WriteString(655, ContraLegRefID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ContraBroker = view.GetString(375);
				ContraTrader = view.GetString(337);
				ContraTradeQty = view.GetDouble(437);
				ContraTradeTime = view.GetDateTime(438);
				ContraLegRefID = view.GetString(655);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ContraBroker":
					{
						value = ContraBroker;
						break;
					}
					case "ContraTrader":
					{
						value = ContraTrader;
						break;
					}
					case "ContraTradeQty":
					{
						value = ContraTradeQty;
						break;
					}
					case "ContraTradeTime":
					{
						value = ContraTradeTime;
						break;
					}
					case "ContraLegRefID":
					{
						value = ContraLegRefID;
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
				ContraBroker = null;
				ContraTrader = null;
				ContraTradeQty = null;
				ContraTradeTime = null;
				ContraLegRefID = null;
			}
		}
		[Group(NoOfTag = 382, Offset = 0, Required = false)]
		public NoContraBrokers[]? ContraBrokers {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ContraBrokers is not null && ContraBrokers.Length != 0)
			{
				writer.WriteWholeNumber(382, ContraBrokers.Length);
				for (int i = 0; i < ContraBrokers.Length; i++)
				{
					((IFixEncoder)ContraBrokers[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoContraBrokers") is IMessageView viewNoContraBrokers)
			{
				var count = viewNoContraBrokers.GroupCount();
				ContraBrokers = new NoContraBrokers[count];
				for (int i = 0; i < count; i++)
				{
					ContraBrokers[i] = new();
					((IFixParser)ContraBrokers[i]).Parse(viewNoContraBrokers.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoContraBrokers":
				{
					value = ContraBrokers;
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
			ContraBrokers = null;
		}
	}
}
