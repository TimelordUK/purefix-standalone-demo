using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class QuotReqRjctGrp : IFixComponent
	{
		public sealed partial class NoRelatedSym : IFixGroup
		{
			[Component(Offset = 0, Required = true)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public FinancingDetails? FinancingDetails {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[TagDetails(Tag = 140, Type = TagType.Float, Offset = 3, Required = false)]
			public double? PrevClosePx {get; set;}
			
			[TagDetails(Tag = 303, Type = TagType.Int, Offset = 4, Required = false)]
			public int? QuoteRequestType {get; set;}
			
			[TagDetails(Tag = 537, Type = TagType.Int, Offset = 5, Required = false)]
			public int? QuoteType {get; set;}
			
			[TagDetails(Tag = 336, Type = TagType.String, Offset = 6, Required = false)]
			public string? TradingSessionID {get; set;}
			
			[TagDetails(Tag = 625, Type = TagType.String, Offset = 7, Required = false)]
			public string? TradingSessionSubID {get; set;}
			
			[TagDetails(Tag = 229, Type = TagType.LocalDate, Offset = 8, Required = false)]
			public DateOnly? TradeOriginationDate {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 9, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 854, Type = TagType.Int, Offset = 10, Required = false)]
			public int? QtyType {get; set;}
			
			[Component(Offset = 11, Required = false)]
			public OrderQtyData? OrderQtyData {get; set;}
			
			[TagDetails(Tag = 63, Type = TagType.String, Offset = 12, Required = false)]
			public string? SettlType {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 13, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[TagDetails(Tag = 193, Type = TagType.LocalDate, Offset = 14, Required = false)]
			public DateOnly? SettlDate2 {get; set;}
			
			[TagDetails(Tag = 192, Type = TagType.Float, Offset = 15, Required = false)]
			public double? OrderQty2 {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 16, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 17, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[Component(Offset = 18, Required = false)]
			public Stipulations? Stipulations {get; set;}
			
			[TagDetails(Tag = 1, Type = TagType.String, Offset = 19, Required = false)]
			public string? Account {get; set;}
			
			[TagDetails(Tag = 660, Type = TagType.Int, Offset = 20, Required = false)]
			public int? AcctIDSource {get; set;}
			
			[TagDetails(Tag = 581, Type = TagType.Int, Offset = 21, Required = false)]
			public int? AccountType {get; set;}
			
			[Component(Offset = 22, Required = false)]
			public QuotReqLegsGrp? QuotReqLegsGrp {get; set;}
			
			[Component(Offset = 23, Required = false)]
			public QuotQualGrp? QuotQualGrp {get; set;}
			
			[TagDetails(Tag = 2115, Type = TagType.Int, Offset = 24, Required = false)]
			public int? NegotiationMethod {get; set;}
			
			[TagDetails(Tag = 692, Type = TagType.Int, Offset = 25, Required = false)]
			public int? QuotePriceType {get; set;}
			
			[Component(Offset = 26, Required = false)]
			public PriceQualifierGrp? PriceQualifierGrp {get; set;}
			
			[TagDetails(Tag = 40, Type = TagType.String, Offset = 27, Required = false)]
			public string? OrdType {get; set;}
			
			[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 28, Required = false)]
			public DateTime? ExpireTime {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 29, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			[Component(Offset = 30, Required = false)]
			public SpreadOrBenchmarkCurveData? SpreadOrBenchmarkCurveData {get; set;}
			
			[TagDetails(Tag = 423, Type = TagType.Int, Offset = 31, Required = false)]
			public int? PriceType {get; set;}
			
			[TagDetails(Tag = 44, Type = TagType.Float, Offset = 32, Required = false)]
			public double? Price {get; set;}
			
			[TagDetails(Tag = 640, Type = TagType.Float, Offset = 33, Required = false)]
			public double? Price2 {get; set;}
			
			[Component(Offset = 34, Required = false)]
			public YieldData? YieldData {get; set;}
			
			[Component(Offset = 35, Required = false)]
			public Parties? Parties {get; set;}
			
			[TagDetails(Tag = 443, Type = TagType.UtcTimestamp, Offset = 36, Required = false)]
			public DateTime? StrikeTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (FinancingDetails is not null) ((IFixEncoder)FinancingDetails).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (PrevClosePx is not null) writer.WriteNumber(140, PrevClosePx.Value);
				if (QuoteRequestType is not null) writer.WriteWholeNumber(303, QuoteRequestType.Value);
				if (QuoteType is not null) writer.WriteWholeNumber(537, QuoteType.Value);
				if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
				if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
				if (TradeOriginationDate is not null) writer.WriteLocalDateOnly(229, TradeOriginationDate.Value);
				if (Side is not null) writer.WriteString(54, Side);
				if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
				if (OrderQtyData is not null) ((IFixEncoder)OrderQtyData).Encode(writer);
				if (SettlType is not null) writer.WriteString(63, SettlType);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (SettlDate2 is not null) writer.WriteLocalDateOnly(193, SettlDate2.Value);
				if (OrderQty2 is not null) writer.WriteNumber(192, OrderQty2.Value);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (Stipulations is not null) ((IFixEncoder)Stipulations).Encode(writer);
				if (Account is not null) writer.WriteString(1, Account);
				if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
				if (AccountType is not null) writer.WriteWholeNumber(581, AccountType.Value);
				if (QuotReqLegsGrp is not null) ((IFixEncoder)QuotReqLegsGrp).Encode(writer);
				if (QuotQualGrp is not null) ((IFixEncoder)QuotQualGrp).Encode(writer);
				if (NegotiationMethod is not null) writer.WriteWholeNumber(2115, NegotiationMethod.Value);
				if (QuotePriceType is not null) writer.WriteWholeNumber(692, QuotePriceType.Value);
				if (PriceQualifierGrp is not null) ((IFixEncoder)PriceQualifierGrp).Encode(writer);
				if (OrdType is not null) writer.WriteString(40, OrdType);
				if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
				if (SpreadOrBenchmarkCurveData is not null) ((IFixEncoder)SpreadOrBenchmarkCurveData).Encode(writer);
				if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
				if (Price is not null) writer.WriteNumber(44, Price.Value);
				if (Price2 is not null) writer.WriteNumber(640, Price2.Value);
				if (YieldData is not null) ((IFixEncoder)YieldData).Encode(writer);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (StrikeTime is not null) writer.WriteUtcTimeStamp(443, StrikeTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
				if (view.GetView("FinancingDetails") is IMessageView viewFinancingDetails)
				{
					FinancingDetails = new();
					((IFixParser)FinancingDetails).Parse(viewFinancingDetails);
				}
				if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
				{
					UndInstrmtGrp = new();
					((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
				}
				PrevClosePx = view.GetDouble(140);
				QuoteRequestType = view.GetInt32(303);
				QuoteType = view.GetInt32(537);
				TradingSessionID = view.GetString(336);
				TradingSessionSubID = view.GetString(625);
				TradeOriginationDate = view.GetDateOnly(229);
				Side = view.GetString(54);
				QtyType = view.GetInt32(854);
				if (view.GetView("OrderQtyData") is IMessageView viewOrderQtyData)
				{
					OrderQtyData = new();
					((IFixParser)OrderQtyData).Parse(viewOrderQtyData);
				}
				SettlType = view.GetString(63);
				SettlDate = view.GetDateOnly(64);
				SettlDate2 = view.GetDateOnly(193);
				OrderQty2 = view.GetDouble(192);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				if (view.GetView("Stipulations") is IMessageView viewStipulations)
				{
					Stipulations = new();
					((IFixParser)Stipulations).Parse(viewStipulations);
				}
				Account = view.GetString(1);
				AcctIDSource = view.GetInt32(660);
				AccountType = view.GetInt32(581);
				if (view.GetView("QuotReqLegsGrp") is IMessageView viewQuotReqLegsGrp)
				{
					QuotReqLegsGrp = new();
					((IFixParser)QuotReqLegsGrp).Parse(viewQuotReqLegsGrp);
				}
				if (view.GetView("QuotQualGrp") is IMessageView viewQuotQualGrp)
				{
					QuotQualGrp = new();
					((IFixParser)QuotQualGrp).Parse(viewQuotQualGrp);
				}
				NegotiationMethod = view.GetInt32(2115);
				QuotePriceType = view.GetInt32(692);
				if (view.GetView("PriceQualifierGrp") is IMessageView viewPriceQualifierGrp)
				{
					PriceQualifierGrp = new();
					((IFixParser)PriceQualifierGrp).Parse(viewPriceQualifierGrp);
				}
				OrdType = view.GetString(40);
				ExpireTime = view.GetDateTime(126);
				TransactTime = view.GetDateTime(60);
				if (view.GetView("SpreadOrBenchmarkCurveData") is IMessageView viewSpreadOrBenchmarkCurveData)
				{
					SpreadOrBenchmarkCurveData = new();
					((IFixParser)SpreadOrBenchmarkCurveData).Parse(viewSpreadOrBenchmarkCurveData);
				}
				PriceType = view.GetInt32(423);
				Price = view.GetDouble(44);
				Price2 = view.GetDouble(640);
				if (view.GetView("YieldData") is IMessageView viewYieldData)
				{
					YieldData = new();
					((IFixParser)YieldData).Parse(viewYieldData);
				}
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				StrikeTime = view.GetDateTime(443);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Instrument":
					{
						value = Instrument;
						break;
					}
					case "FinancingDetails":
					{
						value = FinancingDetails;
						break;
					}
					case "UndInstrmtGrp":
					{
						value = UndInstrmtGrp;
						break;
					}
					case "PrevClosePx":
					{
						value = PrevClosePx;
						break;
					}
					case "QuoteRequestType":
					{
						value = QuoteRequestType;
						break;
					}
					case "QuoteType":
					{
						value = QuoteType;
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
					case "TradeOriginationDate":
					{
						value = TradeOriginationDate;
						break;
					}
					case "Side":
					{
						value = Side;
						break;
					}
					case "QtyType":
					{
						value = QtyType;
						break;
					}
					case "OrderQtyData":
					{
						value = OrderQtyData;
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
					case "Stipulations":
					{
						value = Stipulations;
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
					case "AccountType":
					{
						value = AccountType;
						break;
					}
					case "QuotReqLegsGrp":
					{
						value = QuotReqLegsGrp;
						break;
					}
					case "QuotQualGrp":
					{
						value = QuotQualGrp;
						break;
					}
					case "NegotiationMethod":
					{
						value = NegotiationMethod;
						break;
					}
					case "QuotePriceType":
					{
						value = QuotePriceType;
						break;
					}
					case "PriceQualifierGrp":
					{
						value = PriceQualifierGrp;
						break;
					}
					case "OrdType":
					{
						value = OrdType;
						break;
					}
					case "ExpireTime":
					{
						value = ExpireTime;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
						break;
					}
					case "SpreadOrBenchmarkCurveData":
					{
						value = SpreadOrBenchmarkCurveData;
						break;
					}
					case "PriceType":
					{
						value = PriceType;
						break;
					}
					case "Price":
					{
						value = Price;
						break;
					}
					case "Price2":
					{
						value = Price2;
						break;
					}
					case "YieldData":
					{
						value = YieldData;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "StrikeTime":
					{
						value = StrikeTime;
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
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)FinancingDetails)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				PrevClosePx = null;
				QuoteRequestType = null;
				QuoteType = null;
				TradingSessionID = null;
				TradingSessionSubID = null;
				TradeOriginationDate = null;
				Side = null;
				QtyType = null;
				((IFixReset?)OrderQtyData)?.Reset();
				SettlType = null;
				SettlDate = null;
				SettlDate2 = null;
				OrderQty2 = null;
				Currency = null;
				CurrencyCodeSource = null;
				((IFixReset?)Stipulations)?.Reset();
				Account = null;
				AcctIDSource = null;
				AccountType = null;
				((IFixReset?)QuotReqLegsGrp)?.Reset();
				((IFixReset?)QuotQualGrp)?.Reset();
				NegotiationMethod = null;
				QuotePriceType = null;
				((IFixReset?)PriceQualifierGrp)?.Reset();
				OrdType = null;
				ExpireTime = null;
				TransactTime = null;
				((IFixReset?)SpreadOrBenchmarkCurveData)?.Reset();
				PriceType = null;
				Price = null;
				Price2 = null;
				((IFixReset?)YieldData)?.Reset();
				((IFixReset?)Parties)?.Reset();
				StrikeTime = null;
			}
		}
		[Group(NoOfTag = 146, Offset = 0, Required = false)]
		public NoRelatedSym[]? RelatedSym {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedSym is not null && RelatedSym.Length != 0)
			{
				writer.WriteWholeNumber(146, RelatedSym.Length);
				for (int i = 0; i < RelatedSym.Length; i++)
				{
					((IFixEncoder)RelatedSym[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedSym") is IMessageView viewNoRelatedSym)
			{
				var count = viewNoRelatedSym.GroupCount();
				RelatedSym = new NoRelatedSym[count];
				for (int i = 0; i < count; i++)
				{
					RelatedSym[i] = new();
					((IFixParser)RelatedSym[i]).Parse(viewNoRelatedSym.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedSym":
				{
					value = RelatedSym;
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
			RelatedSym = null;
		}
	}
}
