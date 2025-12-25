using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class BidCompReqGrp : IFixComponent
	{
		public sealed partial class NoBidComponents : IFixGroup
		{
			[TagDetails(Tag = 66, Type = TagType.String, Offset = 0, Required = false)]
			public string? ListID {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 1, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 2, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 3, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 430, Type = TagType.Int, Offset = 4, Required = false)]
			public int? NetGrossInd {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 5, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 6, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 1, Type = TagType.String, Offset = 7, Required = false)]
			public string? Account {get; set;}
			
			[TagDetails(Tag = 660, Type = TagType.Int, Offset = 8, Required = false)]
			public int? AcctIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ListID is not null) writer.WriteString(66, ListID);
				if (Side is not null) writer.WriteString(54, Side);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (NetGrossInd is not null) writer.WriteWholeNumber(430, NetGrossInd.Value);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (Account is not null) writer.WriteString(1, Account);
				if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ListID = view.GetString(66);
				Side = view.GetString(54);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				NetGrossInd = view.GetInt32(430);
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				Account = view.GetString(1);
				AcctIDSource = view.GetInt32(660);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ListID":
					{
						value = ListID;
						break;
					}
					case "Side":
					{
						value = Side;
						break;
					}
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
					case "NetGrossInd":
					{
						value = NetGrossInd;
						break;
					}
					case "SettlType":
					{
						value = SettlType;
						break;
					}
					case "SettlDate":
					{
						value = SettlDate;
						break;
					}
					case "Account":
					{
						value = Account;
						break;
					}
					case "AcctIDSource":
					{
						value = AcctIDSource;
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
				ListID = null;
				Side = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				NetGrossInd = null;
				SettlType = null;
				SettlDate = null;
				Account = null;
				AcctIDSource = null;
			}
		}
		[Group(NoOfTag = 420, Offset = 0, Required = false)]
		public NoBidComponents[]? BidComponents {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (BidComponents is not null && BidComponents.Length != 0)
			{
				writer.WriteWholeNumber(420, BidComponents.Length);
				for (int i = 0; i < BidComponents.Length; i++)
				{
					((IFixEncoder)BidComponents[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoBidComponents") is IMessageView viewNoBidComponents)
			{
				var count = viewNoBidComponents.GroupCount();
				BidComponents = new NoBidComponents[count];
				for (int i = 0; i < count; i++)
				{
					BidComponents[i] = new();
					((IFixParser)BidComponents[i]).Parse(viewNoBidComponents.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoBidComponents":
				{
					value = BidComponents;
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
			BidComponents = null;
		}
	}
}
