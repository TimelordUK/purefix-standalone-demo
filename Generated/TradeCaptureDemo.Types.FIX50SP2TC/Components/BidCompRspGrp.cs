using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class BidCompRspGrp : IFixComponent
	{
		public sealed partial class NoBidComponents : IFixGroup
		{
			[Component(Offset = 0, Required = true)]
			public CommissionData? CommissionData {get; set;}
			
			[TagDetails(Tag = 66, Type = TagType.String, Offset = 1, Required = false)]
			public string? ListID {get; set;}
			
			[TagDetails(Tag = 421, Type = TagType.String, Offset = 2, Required = false)]
			public string? Country {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 3, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 44, Type = TagType.Float, Offset = 4, Required = false)]
			public double? Price {get; set;}
			
			[TagDetails(Tag = 423, Type = TagType.Int, Offset = 5, Required = false)]
			public int? PriceType {get; set;}
			
			[TagDetails(Tag = 406, Type = TagType.Float, Offset = 6, Required = false)]
			public double? FairValue {get; set;}
			
			[TagDetails(Tag = 430, Type = TagType.Int, Offset = 7, Required = false)]
			public int? NetGrossInd {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 8, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 9, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 10, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 11, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 12, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 13, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 14, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CommissionData is not null) ((IFixEncoder)CommissionData).Encode(writer);
				if (ListID is not null) writer.WriteString(66, ListID);
				if (Country is not null) writer.WriteString(421, Country);
				if (Side is not null) writer.WriteString(54, Side);
				if (Price is not null) writer.WriteNumber(44, Price.Value);
				if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
				if (FairValue is not null) writer.WriteNumber(406, FairValue.Value);
				if (NetGrossInd is not null) writer.WriteWholeNumber(430, NetGrossInd.Value);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("CommissionData") is IMessageView viewCommissionData)
				{
					CommissionData = new();
					((IFixParser)CommissionData).Parse(viewCommissionData);
				}
				ListID = view.GetString(66);
				Country = view.GetString(421);
				Side = view.GetString(54);
				Price = view.GetDouble(44);
				PriceType = view.GetInt32(423);
				FairValue = view.GetDouble(406);
				NetGrossInd = view.GetInt32(430);
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CommissionData":
					{
						value = CommissionData;
						break;
					}
					case "ListID":
					{
						value = ListID;
						break;
					}
					case "Country":
					{
						value = Country;
						break;
					}
					case "Side":
					{
						value = Side;
						break;
					}
					case "Price":
					{
						value = Price;
						break;
					}
					case "PriceType":
					{
						value = PriceType;
						break;
					}
					case "FairValue":
					{
						value = FairValue;
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
					case "Text":
					{
						value = Text;
						break;
					}
					case "EncodedTextLen":
					{
						value = EncodedTextLen;
						break;
					}
					case "EncodedText":
					{
						value = EncodedText;
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
				((IFixReset?)CommissionData)?.Reset();
				ListID = null;
				Country = null;
				Side = null;
				Price = null;
				PriceType = null;
				FairValue = null;
				NetGrossInd = null;
				SettlType = null;
				SettlDate = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
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
