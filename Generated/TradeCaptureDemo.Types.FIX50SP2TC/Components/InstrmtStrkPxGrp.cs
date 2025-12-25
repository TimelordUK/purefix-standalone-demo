using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrmtStrkPxGrp : IFixComponent
	{
		public sealed partial class NoStrikes : IFixGroup
		{
			[Component(Offset = 0, Required = true)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[TagDetails(Tag = 140, Type = TagType.Float, Offset = 2, Required = false)]
			public double? PrevClosePx {get; set;}
			
			[TagDetails(Tag = 11, Type = TagType.String, Offset = 3, Required = false)]
			public string? ClOrdID {get; set;}
			
			[TagDetails(Tag = 526, Type = TagType.String, Offset = 4, Required = false)]
			public string? SecondaryClOrdID {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 5, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 44, Type = TagType.Float, Offset = 6, Required = false)]
			public double? Price {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 7, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 8, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 58, Type = TagType.String, Offset = 9, Required = false)]
			public string? Text {get; set;}
			
			[TagDetails(Tag = 354, Type = TagType.Length, Offset = 10, Required = false)]
			public int? EncodedTextLen {get; set;}
			
			[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 11, Required = false)]
			public byte[]? EncodedText {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (PrevClosePx is not null) writer.WriteNumber(140, PrevClosePx.Value);
				if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
				if (SecondaryClOrdID is not null) writer.WriteString(526, SecondaryClOrdID);
				if (Side is not null) writer.WriteString(54, Side);
				if (Price is not null) writer.WriteNumber(44, Price.Value);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (Text is not null) writer.WriteString(58, Text);
				if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
				if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
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
				PrevClosePx = view.GetDouble(140);
				ClOrdID = view.GetString(11);
				SecondaryClOrdID = view.GetString(526);
				Side = view.GetString(54);
				Price = view.GetDouble(44);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				Text = view.GetString(58);
				EncodedTextLen = view.GetInt32(354);
				EncodedText = view.GetByteArray(355);
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
					case "ClOrdID":
					{
						value = ClOrdID;
						break;
					}
					case "SecondaryClOrdID":
					{
						value = SecondaryClOrdID;
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
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				PrevClosePx = null;
				ClOrdID = null;
				SecondaryClOrdID = null;
				Side = null;
				Price = null;
				Currency = null;
				CurrencyCodeSource = null;
				Text = null;
				EncodedTextLen = null;
				EncodedText = null;
			}
		}
		[Group(NoOfTag = 428, Offset = 0, Required = false)]
		public NoStrikes[]? Strikes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Strikes is not null && Strikes.Length != 0)
			{
				writer.WriteWholeNumber(428, Strikes.Length);
				for (int i = 0; i < Strikes.Length; i++)
				{
					((IFixEncoder)Strikes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStrikes") is IMessageView viewNoStrikes)
			{
				var count = viewNoStrikes.GroupCount();
				Strikes = new NoStrikes[count];
				for (int i = 0; i < count; i++)
				{
					Strikes[i] = new();
					((IFixParser)Strikes[i]).Parse(viewNoStrikes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStrikes":
				{
					value = Strikes;
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
			Strikes = null;
		}
	}
}
