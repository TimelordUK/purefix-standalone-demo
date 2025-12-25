using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrmtMatchSideGrp : IFixComponent
	{
		public sealed partial class NoInstrmtMatchSides : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public InstrmtLegGrp? InstrmtLegGrp {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public UndInstrmtGrp? UndInstrmtGrp {get; set;}
			
			[TagDetails(Tag = 1891, Type = TagType.String, Offset = 3, Required = false)]
			public string? TrdMatchSubID {get; set;}
			
			[TagDetails(Tag = 53, Type = TagType.Float, Offset = 4, Required = false)]
			public double? Quantity {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 5, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 6, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 7, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 8, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 854, Type = TagType.Int, Offset = 9, Required = false)]
			public int? QtyType {get; set;}
			
			[TagDetails(Tag = 32, Type = TagType.Float, Offset = 10, Required = false)]
			public double? LastQty {get; set;}
			
			[TagDetails(Tag = 423, Type = TagType.Int, Offset = 11, Required = false)]
			public int? PriceType {get; set;}
			
			[TagDetails(Tag = 31, Type = TagType.Float, Offset = 12, Required = false)]
			public double? LastPx {get; set;}
			
			[TagDetails(Tag = 30, Type = TagType.String, Offset = 13, Required = false)]
			public string? LastMkt {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public TrdMatchSideGrp? TrdMatchSideGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
				if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
				if (TrdMatchSubID is not null) writer.WriteString(1891, TrdMatchSubID);
				if (Quantity is not null) writer.WriteNumber(53, Quantity.Value);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (QtyType is not null) writer.WriteWholeNumber(854, QtyType.Value);
				if (LastQty is not null) writer.WriteNumber(32, LastQty.Value);
				if (PriceType is not null) writer.WriteWholeNumber(423, PriceType.Value);
				if (LastPx is not null) writer.WriteNumber(31, LastPx.Value);
				if (LastMkt is not null) writer.WriteString(30, LastMkt);
				if (TrdMatchSideGrp is not null) ((IFixEncoder)TrdMatchSideGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
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
				if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
				{
					UndInstrmtGrp = new();
					((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
				}
				TrdMatchSubID = view.GetString(1891);
				Quantity = view.GetDouble(53);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				QtyType = view.GetInt32(854);
				LastQty = view.GetDouble(32);
				PriceType = view.GetInt32(423);
				LastPx = view.GetDouble(31);
				LastMkt = view.GetString(30);
				if (view.GetView("TrdMatchSideGrp") is IMessageView viewTrdMatchSideGrp)
				{
					TrdMatchSideGrp = new();
					((IFixParser)TrdMatchSideGrp).Parse(viewTrdMatchSideGrp);
				}
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
					case "InstrmtLegGrp":
					{
						value = InstrmtLegGrp;
						break;
					}
					case "UndInstrmtGrp":
					{
						value = UndInstrmtGrp;
						break;
					}
					case "TrdMatchSubID":
					{
						value = TrdMatchSubID;
						break;
					}
					case "Quantity":
					{
						value = Quantity;
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
					case "SettlCurrency":
					{
						value = SettlCurrency;
						break;
					}
					case "SettlCurrencyCodeSource":
					{
						value = SettlCurrencyCodeSource;
						break;
					}
					case "QtyType":
					{
						value = QtyType;
						break;
					}
					case "LastQty":
					{
						value = LastQty;
						break;
					}
					case "PriceType":
					{
						value = PriceType;
						break;
					}
					case "LastPx":
					{
						value = LastPx;
						break;
					}
					case "LastMkt":
					{
						value = LastMkt;
						break;
					}
					case "TrdMatchSideGrp":
					{
						value = TrdMatchSideGrp;
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
				((IFixReset?)InstrmtLegGrp)?.Reset();
				((IFixReset?)UndInstrmtGrp)?.Reset();
				TrdMatchSubID = null;
				Quantity = null;
				Currency = null;
				CurrencyCodeSource = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				QtyType = null;
				LastQty = null;
				PriceType = null;
				LastPx = null;
				LastMkt = null;
				((IFixReset?)TrdMatchSideGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1889, Offset = 0, Required = false)]
		public NoInstrmtMatchSides[]? InstrmtMatchSides {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrmtMatchSides is not null && InstrmtMatchSides.Length != 0)
			{
				writer.WriteWholeNumber(1889, InstrmtMatchSides.Length);
				for (int i = 0; i < InstrmtMatchSides.Length; i++)
				{
					((IFixEncoder)InstrmtMatchSides[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrmtMatchSides") is IMessageView viewNoInstrmtMatchSides)
			{
				var count = viewNoInstrmtMatchSides.GroupCount();
				InstrmtMatchSides = new NoInstrmtMatchSides[count];
				for (int i = 0; i < count; i++)
				{
					InstrmtMatchSides[i] = new();
					((IFixParser)InstrmtMatchSides[i]).Parse(viewNoInstrmtMatchSides.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrmtMatchSides":
				{
					value = InstrmtMatchSides;
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
			InstrmtMatchSides = null;
		}
	}
}
