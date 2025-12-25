using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DL", FixVersion.FIX50SP2)]
	public sealed partial class PositionTransferInstruction : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2436, Type = TagType.String, Offset = 1, Required = true)]
		public string? TransferInstructionID {get; set;}
		
		[TagDetails(Tag = 2437, Type = TagType.String, Offset = 2, Required = false)]
		public string? TransferID {get; set;}
		
		[TagDetails(Tag = 2439, Type = TagType.Int, Offset = 3, Required = false)]
		public int? TransferTransType {get; set;}
		
		[TagDetails(Tag = 2440, Type = TagType.Int, Offset = 4, Required = false)]
		public int? TransferType {get; set;}
		
		[TagDetails(Tag = 2441, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TransferScope {get; set;}
		
		[Component(Offset = 6, Required = true)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 7, Required = true)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 8, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 9, Required = false)]
		public DateOnly? TradeDate {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 10, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 11, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 12, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 13, Required = false)]
		public PositionQty? PositionQty {get; set;}
		
		[TagDetails(Tag = 1596, Type = TagType.Float, Offset = 14, Required = false)]
		public double? ClearingTradePrice {get; set;}
		
		[TagDetails(Tag = 15, Type = TagType.String, Offset = 15, Required = false)]
		public string? Currency {get; set;}
		
		[TagDetails(Tag = 2897, Type = TagType.String, Offset = 16, Required = false)]
		public string? CurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 423, Type = TagType.Int, Offset = 17, Required = false)]
		public int? PriceType {get; set;}
		
		[Component(Offset = 18, Required = false)]
		public PositionAmountData? PositionAmountData {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 19, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 20, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 21, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 22, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (TransferInstructionID is not null) writer.WriteString(2436, TransferInstructionID);
			if (TransferID is not null) writer.WriteString(2437, TransferID);
			if (TransferTransType is not null) writer.WriteWholeNumber(2439, TransferTransType.Value);
			if (TransferType is not null) writer.WriteWholeNumber(2440, TransferType.Value);
			if (TransferScope is not null) writer.WriteWholeNumber(2441, TransferScope.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (PositionQty is not null) ((IFixEncoder)PositionQty).Encode(writer);
			if (ClearingTradePrice is not null) writer.WriteNumber(1596, ClearingTradePrice.Value);
			if (Currency is not null) writer.WriteString(15, Currency);
			if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
			if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
			if (PositionAmountData is not null) ((IFixEncoder)PositionAmountData).Encode(writer);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			TransferInstructionID = view.GetString(2436);
			TransferID = view.GetString(2437);
			TransferTransType = view.GetInt32(2439);
			TransferType = view.GetInt32(2440);
			TransferScope = view.GetInt32(2441);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("TargetParties") is IMessageView viewTargetParties)
			{
				TargetParties = new();
				((IFixParser)TargetParties).Parse(viewTargetParties);
			}
			ClearingBusinessDate = view.GetDateOnly(715);
			TradeDate = view.GetDateOnly(75);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("PositionQty") is IMessageView viewPositionQty)
			{
				PositionQty = new();
				((IFixParser)PositionQty).Parse(viewPositionQty);
			}
			ClearingTradePrice = view.GetDouble(1596);
			Currency = view.GetString(15);
			CurrencyCodeSource = view.GetString(2897);
			PriceType = view.GetInt32(423);
			if (view.GetView("PositionAmountData") is IMessageView viewPositionAmountData)
			{
				PositionAmountData = new();
				((IFixParser)PositionAmountData).Parse(viewPositionAmountData);
			}
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "TransferInstructionID":
				{
					value = TransferInstructionID;
					break;
				}
				case "TransferID":
				{
					value = TransferID;
					break;
				}
				case "TransferTransType":
				{
					value = TransferTransType;
					break;
				}
				case "TransferType":
				{
					value = TransferType;
					break;
				}
				case "TransferScope":
				{
					value = TransferScope;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "TargetParties":
				{
					value = TargetParties;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "TradeDate":
				{
					value = TradeDate;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "PositionQty":
				{
					value = PositionQty;
					break;
				}
				case "ClearingTradePrice":
				{
					value = ClearingTradePrice;
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
				case "PriceType":
				{
					value = PriceType;
					break;
				}
				case "PositionAmountData":
				{
					value = PositionAmountData;
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
				case "StandardTrailer":
				{
					value = StandardTrailer;
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
			((IFixReset?)StandardHeader)?.Reset();
			TransferInstructionID = null;
			TransferID = null;
			TransferTransType = null;
			TransferType = null;
			TransferScope = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			ClearingBusinessDate = null;
			TradeDate = null;
			TransactTime = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)PositionQty)?.Reset();
			ClearingTradePrice = null;
			Currency = null;
			CurrencyCodeSource = null;
			PriceType = null;
			((IFixReset?)PositionAmountData)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
