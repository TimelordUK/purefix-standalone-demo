using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlObligationInstructions : IFixComponent
	{
		public sealed partial class NoSettlOblig : IFixGroup
		{
			[TagDetails(Tag = 430, Type = TagType.Int, Offset = 0, Required = false)]
			public int? NetGrossInd {get; set;}
			
			[TagDetails(Tag = 1161, Type = TagType.String, Offset = 1, Required = false)]
			public string? SettlObligID {get; set;}
			
			[TagDetails(Tag = 1162, Type = TagType.String, Offset = 2, Required = false)]
			public string? SettlObligTransType {get; set;}
			
			[TagDetails(Tag = 1163, Type = TagType.String, Offset = 3, Required = false)]
			public string? SettlObligRefID {get; set;}
			
			[TagDetails(Tag = 1157, Type = TagType.Float, Offset = 4, Required = false)]
			public double? CcyAmt {get; set;}
			
			[TagDetails(Tag = 119, Type = TagType.Float, Offset = 5, Required = false)]
			public double? SettlCurrAmt {get; set;}
			
			[TagDetails(Tag = 15, Type = TagType.String, Offset = 6, Required = false)]
			public string? Currency {get; set;}
			
			[TagDetails(Tag = 2897, Type = TagType.String, Offset = 7, Required = false)]
			public string? CurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 8, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 9, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 155, Type = TagType.Float, Offset = 10, Required = false)]
			public double? SettlCurrFxRate {get; set;}
			
			[TagDetails(Tag = 64, Type = TagType.LocalDate, Offset = 11, Required = false)]
			public DateOnly? SettlDate {get; set;}
			
			[Component(Offset = 12, Required = false)]
			public Instrument? Instrument {get; set;}
			
			[Component(Offset = 13, Required = false)]
			public Parties? Parties {get; set;}
			
			[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 14, Required = false)]
			public DateTime? EffectiveTime {get; set;}
			
			[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
			public DateTime? ExpireTime {get; set;}
			
			[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 16, Required = false)]
			public DateTime? LastUpdateTime {get; set;}
			
			[Component(Offset = 17, Required = false)]
			public SettlDetails? SettlDetails {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NetGrossInd is not null) writer.WriteWholeNumber(430, NetGrossInd.Value);
				if (SettlObligID is not null) writer.WriteString(1161, SettlObligID);
				if (SettlObligTransType is not null) writer.WriteString(1162, SettlObligTransType);
				if (SettlObligRefID is not null) writer.WriteString(1163, SettlObligRefID);
				if (CcyAmt is not null) writer.WriteNumber(1157, CcyAmt.Value);
				if (SettlCurrAmt is not null) writer.WriteNumber(119, SettlCurrAmt.Value);
				if (Currency is not null) writer.WriteString(15, Currency);
				if (CurrencyCodeSource is not null) writer.WriteString(2897, CurrencyCodeSource);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (SettlCurrFxRate is not null) writer.WriteNumber(155, SettlCurrFxRate.Value);
				if (SettlDate is not null) writer.WriteLocalDateOnly(64, SettlDate.Value);
				if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
				if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
				if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
				if (SettlDetails is not null) ((IFixEncoder)SettlDetails).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NetGrossInd = view.GetInt32(430);
				SettlObligID = view.GetString(1161);
				SettlObligTransType = view.GetString(1162);
				SettlObligRefID = view.GetString(1163);
				CcyAmt = view.GetDouble(1157);
				SettlCurrAmt = view.GetDouble(119);
				Currency = view.GetString(15);
				CurrencyCodeSource = view.GetString(2897);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				SettlCurrFxRate = view.GetDouble(155);
				SettlDate = view.GetDateOnly(64);
				if (view.GetView("Instrument") is IMessageView viewInstrument)
				{
					Instrument = new();
					((IFixParser)Instrument).Parse(viewInstrument);
				}
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				EffectiveTime = view.GetDateTime(168);
				ExpireTime = view.GetDateTime(126);
				LastUpdateTime = view.GetDateTime(779);
				if (view.GetView("SettlDetails") is IMessageView viewSettlDetails)
				{
					SettlDetails = new();
					((IFixParser)SettlDetails).Parse(viewSettlDetails);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NetGrossInd":
					{
						value = NetGrossInd;
						break;
					}
					case "SettlObligID":
					{
						value = SettlObligID;
						break;
					}
					case "SettlObligTransType":
					{
						value = SettlObligTransType;
						break;
					}
					case "SettlObligRefID":
					{
						value = SettlObligRefID;
						break;
					}
					case "CcyAmt":
					{
						value = CcyAmt;
						break;
					}
					case "SettlCurrAmt":
					{
						value = SettlCurrAmt;
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
					case "SettlCurrFxRate":
					{
						value = SettlCurrFxRate;
						break;
					}
					case "SettlDate":
					{
						value = SettlDate;
						break;
					}
					case "Instrument":
					{
						value = Instrument;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "EffectiveTime":
					{
						value = EffectiveTime;
						break;
					}
					case "ExpireTime":
					{
						value = ExpireTime;
						break;
					}
					case "LastUpdateTime":
					{
						value = LastUpdateTime;
						break;
					}
					case "SettlDetails":
					{
						value = SettlDetails;
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
				NetGrossInd = null;
				SettlObligID = null;
				SettlObligTransType = null;
				SettlObligRefID = null;
				CcyAmt = null;
				SettlCurrAmt = null;
				Currency = null;
				CurrencyCodeSource = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				SettlCurrFxRate = null;
				SettlDate = null;
				((IFixReset?)Instrument)?.Reset();
				((IFixReset?)Parties)?.Reset();
				EffectiveTime = null;
				ExpireTime = null;
				LastUpdateTime = null;
				((IFixReset?)SettlDetails)?.Reset();
			}
		}
		[Group(NoOfTag = 1165, Offset = 0, Required = false)]
		public NoSettlOblig[]? SettlOblig {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlOblig is not null && SettlOblig.Length != 0)
			{
				writer.WriteWholeNumber(1165, SettlOblig.Length);
				for (int i = 0; i < SettlOblig.Length; i++)
				{
					((IFixEncoder)SettlOblig[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSettlOblig") is IMessageView viewNoSettlOblig)
			{
				var count = viewNoSettlOblig.GroupCount();
				SettlOblig = new NoSettlOblig[count];
				for (int i = 0; i < count; i++)
				{
					SettlOblig[i] = new();
					((IFixParser)SettlOblig[i]).Parse(viewNoSettlOblig.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSettlOblig":
				{
					value = SettlOblig;
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
			SettlOblig = null;
		}
	}
}
