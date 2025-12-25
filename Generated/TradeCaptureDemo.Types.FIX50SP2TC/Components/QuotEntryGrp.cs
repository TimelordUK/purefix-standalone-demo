using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class QuotEntryGrp : IFixComponent
	{
		public sealed partial class NoQuoteEntries : IFixGroup
		{
			[TagDetails(Tag = 299, Type = TagType.String, Offset = 0, Required = true)]
			public string? QuoteEntryID {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public InstrmtLegGrp? InstrmtLegGrp {get; set;}
			
			[TagDetails(Tag = 132, Type = TagType.Float, Offset = 3, Required = false)]
			public double? BidPx {get; set;}
			
			[TagDetails(Tag = 133, Type = TagType.Float, Offset = 4, Required = false)]
			public double? OfferPx {get; set;}
			
			[TagDetails(Tag = 1749, Type = TagType.Float, Offset = 5, Required = false)]
			public double? TotalBidSize {get; set;}
			
			[TagDetails(Tag = 1750, Type = TagType.Float, Offset = 6, Required = false)]
			public double? TotalOfferSize {get; set;}
			
			[TagDetails(Tag = 134, Type = TagType.Float, Offset = 7, Required = false)]
			public double? BidSize {get; set;}
			
			[TagDetails(Tag = 135, Type = TagType.Float, Offset = 8, Required = false)]
			public double? OfferSize {get; set;}
			
			[TagDetails(Tag = 62, Type = TagType.UtcTimestamp, Offset = 9, Required = false)]
			public DateTime? ValidUntilTime {get; set;}
			
			[TagDetails(Tag = 188, Type = TagType.Float, Offset = 10, Required = false)]
			public double? BidSpotRate {get; set;}
			
			[TagDetails(Tag = 190, Type = TagType.Float, Offset = 11, Required = false)]
			public double? OfferSpotRate {get; set;}
			
			[TagDetails(Tag = 189, Type = TagType.Float, Offset = 12, Required = false)]
			public double? BidForwardPoints {get; set;}
			
			[TagDetails(Tag = 191, Type = TagType.Float, Offset = 13, Required = false)]
			public double? OfferForwardPoints {get; set;}
			
			[TagDetails(Tag = 631, Type = TagType.Float, Offset = 14, Required = false)]
			public double? MidPx {get; set;}
			
			[TagDetails(Tag = 632, Type = TagType.Float, Offset = 15, Required = false)]
			public double? BidYield {get; set;}
			
			[TagDetails(Tag = 633, Type = TagType.Float, Offset = 16, Required = false)]
			public double? MidYield {get; set;}
			
			[TagDetails(Tag = 634, Type = TagType.Float, Offset = 17, Required = false)]
			public double? OfferYield {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 18, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 19, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 20, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 21, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 22, Required = false)]
			public string? OrdType {get; set;}
			
			[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 23, Required = false)]
			public DateOnly? SettlDate2 {get; set;}
			
			[TagDetails(Tag = 192, Type = TagType.Float, Offset = 24, Required = false)]
			public double? OrderQty2 {get; set;}
			
			[TagDetails(Tag = 642, Type = TagType.Float, Offset = 25, Required = false)]
			public double? BidForwardPoints2 {get; set;}
			
			[TagDetails(Tag = 643, Type = TagType.Float, Offset = 26, Required = false)]
			public double? OfferForwardPoints2 {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 27, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 28, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 775, Type = TagType.Int, Offset = 29, Required = false)]
			public int? BookingType {get; set;}
			
			[TagDetails(Tag = 528, Type = TagType.String, Offset = 30, Required = false)]
			public string? OrderCapacity {get; set;}
			
			[TagDetails(Tag = 529, Type = TagType.String, Offset = 31, Required = false)]
			public string? OrderRestrictions {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (QuoteEntryID is not null) writer.WriteString(299, QuoteEntryID);
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
				if (BidPx is not null) writer.WriteNumber(132, BidPx.Value);
				if (OfferPx is not null) writer.WriteNumber(133, OfferPx.Value);
				if (TotalBidSize is not null) writer.WriteNumber(1749, TotalBidSize.Value);
				if (TotalOfferSize is not null) writer.WriteNumber(1750, TotalOfferSize.Value);
				if (BidSize is not null) writer.WriteNumber(134, BidSize.Value);
				if (OfferSize is not null) writer.WriteNumber(135, OfferSize.Value);
				if (ValidUntilTime is not null) writer.WriteUtcTimeStamp(62, ValidUntilTime.Value);
				if (BidSpotRate is not null) writer.WriteNumber(188, BidSpotRate.Value);
				if (OfferSpotRate is not null) writer.WriteNumber(190, OfferSpotRate.Value);
				if (BidForwardPoints is not null) writer.WriteNumber(189, BidForwardPoints.Value);
				if (OfferForwardPoints is not null) writer.WriteNumber(191, OfferForwardPoints.Value);
				if (MidPx is not null) writer.WriteNumber(631, MidPx.Value);
				if (BidYield is not null) writer.WriteNumber(632, BidYield.Value);
				if (MidYield is not null) writer.WriteNumber(633, MidYield.Value);
				if (OfferYield is not null) writer.WriteNumber(634, OfferYield.Value);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (OrdType is not null) writer.WriteString(40, OrdType);
				if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
				if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
				if (BidForwardPoints2 is not null) writer.WriteNumber(642, BidForwardPoints2.Value);
				if (OfferForwardPoints2 is not null) writer.WriteNumber(643, OfferForwardPoints2.Value);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (BookingType is not null) writer.WriteWholeNumber(775, BookingType.Value);
				if (OrderCapacity is not null) writer.WriteString(528, OrderCapacity);
				if (OrderRestrictions is not null) writer.WriteString(529, OrderRestrictions);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				QuoteEntryID = view.GetString(299);
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
				if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
				{
					InstrmtLegGrp = new();
					((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
				}
				BidPx = view.GetDouble(132);
				OfferPx = view.GetDouble(133);
				TotalBidSize = view.GetDouble(1749);
				TotalOfferSize = view.GetDouble(1750);
				BidSize = view.GetDouble(134);
				OfferSize = view.GetDouble(135);
				ValidUntilTime = view.GetDateTime(62);
				BidSpotRate = view.GetDouble(188);
				OfferSpotRate = view.GetDouble(190);
				BidForwardPoints = view.GetDouble(189);
				OfferForwardPoints = view.GetDouble(191);
				MidPx = view.GetDouble(631);
				BidYield = view.GetDouble(632);
				MidYield = view.GetDouble(633);
				OfferYield = view.GetDouble(634);
				TransactTime = view.GetDateTime(60);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				SettlDate = view.GetDateOnly(64);
				OrdType = view.GetString(40);
				SettlDate2 = view.GetDateOnly(193);
				OrderQty2 = view.GetDouble(192);
				BidForwardPoints2 = view.GetDouble(642);
				OfferForwardPoints2 = view.GetDouble(643);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				BookingType = view.GetInt32(775);
				OrderCapacity = view.GetString(528);
				OrderRestrictions = view.GetString(529);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "QuoteEntryID":
					{
						value = QuoteEntryID;
						break;
					}
					case "Instrument":
					{
						value = Instrument;
						break;
					}
					case "InstrmtLegGrp":
					{
						value = InstrmtLegGrp;
						break;
					}
					case "BidPx":
					{
						value = BidPx;
						break;
					}
					case "OfferPx":
					{
						value = OfferPx;
						break;
					}
					case "TotalBidSize":
					{
						value = TotalBidSize;
						break;
					}
					case "TotalOfferSize":
					{
						value = TotalOfferSize;
						break;
					}
					case "BidSize":
					{
						value = BidSize;
						break;
					}
					case "OfferSize":
					{
						value = OfferSize;
						break;
					}
					case "ValidUntilTime":
					{
						value = ValidUntilTime;
						break;
					}
					case "BidSpotRate":
					{
						value = BidSpotRate;
						break;
					}
					case "OfferSpotRate":
					{
						value = OfferSpotRate;
						break;
					}
					case "BidForwardPoints":
					{
						value = BidForwardPoints;
						break;
					}
					case "OfferForwardPoints":
					{
						value = OfferForwardPoints;
						break;
					}
					case "MidPx":
					{
						value = MidPx;
						break;
					}
					case "BidYield":
					{
						value = BidYield;
						break;
					}
					case "MidYield":
					{
						value = MidYield;
						break;
					}
					case "OfferYield":
					{
						value = OfferYield;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
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
					case "SettlDate":
					{
						value = SettlDate;
						break;
					}
					case "OrdType":
					{
						value = OrdType;
						break;
					}
					case "SettlDate2":
					{
						value = SettlDate2;
						break;
					}
					case "OrderQty2":
					{
						value = OrderQty2;
						break;
					}
					case "BidForwardPoints2":
					{
						value = BidForwardPoints2;
						break;
					}
					case "OfferForwardPoints2":
					{
						value = OfferForwardPoints2;
						break;
					}
					case "Currency":
					{
						value = Currency;
						break;
					}
					case "CurrencyCodeSource":
					{
						value = CurrencyCodeSource;
						break;
					}
					case "BookingType":
					{
						value = BookingType;
						break;
					}
					case "OrderCapacity":
					{
						value = OrderCapacity;
						break;
					}
					case "OrderRestrictions":
					{
						value = OrderRestrictions;
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
				QuoteEntryID = null;
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)InstrmtLegGrp)?.Reset();
				BidPx = null;
				OfferPx = null;
				TotalBidSize = null;
				TotalOfferSize = null;
				BidSize = null;
				OfferSize = null;
				ValidUntilTime = null;
				BidSpotRate = null;
				OfferSpotRate = null;
				BidForwardPoints = null;
				OfferForwardPoints = null;
				MidPx = null;
				BidYield = null;
				MidYield = null;
				OfferYield = null;
				TransactTime = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				SettlDate = null;
				OrdType = null;
				SettlDate2 = null;
				OrderQty2 = null;
				BidForwardPoints2 = null;
				OfferForwardPoints2 = null;
				Currency = null;
				CurrencyCodeSource = null;
				BookingType = null;
				OrderCapacity = null;
				OrderRestrictions = null;
			}
		}
		[Group(NoOfTag = 295, Offset = 0, Required = false)]
		public NoQuoteEntries[]? QuoteEntries {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (QuoteEntries is not null && QuoteEntries.Length != 0)
			{
				writer.WriteWholeNumber(295, QuoteEntries.Length);
				for (int i = 0; i < QuoteEntries.Length; i++)
				{
					((IFixEncoder)QuoteEntries[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoQuoteEntries") is IMessageView viewNoQuoteEntries)
			{
				var count = viewNoQuoteEntries.GroupCount();
				QuoteEntries = new NoQuoteEntries[count];
				for (int i = 0; i < count; i++)
				{
					QuoteEntries[i] = new();
					((IFixParser)QuoteEntries[i]).Parse(viewNoQuoteEntries.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoQuoteEntries":
				{
					value = QuoteEntries;
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
			QuoteEntries = null;
		}
	}
}
