using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class SettlInstGrp : IFixComponent
	{
		public sealed partial class NoSettlInst : IFixGroup
		{
			[TagDetails(Tag = 162, Type = TagType.String, Offset = 0, Required = false)]
			public string? SettlInstID {get; set;}
			
			[TagDetails(Tag = 163, Type = TagType.String, Offset = 1, Required = false)]
			public string? SettlInstTransType {get; set;}
			
			[TagDetails(Tag = 214, Type = TagType.String, Offset = 2, Required = false)]
			public string? SettlInstRefID {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public Parties? Parties {get; set;}
			
			[TagDetails(Tag = 54, Type = TagType.String, Offset = 4, Required = false)]
			public string? Side {get; set;}
			
			[TagDetails(Tag = 460, Type = TagType.Int, Offset = 5, Required = false)]
			public int? Product {get; set;}
			
			[TagDetails(Tag = 167, Type = TagType.String, Offset = 6, Required = false)]
			public string? SecurityType {get; set;}
			
			[TagDetails(Tag = 461, Type = TagType.String, Offset = 7, Required = false)]
			public string? CFICode {get; set;}
			
			[TagDetails(Tag = 2891, Type = TagType.String, Offset = 8, Required = false)]
			public string? UPICode {get; set;}
			
			[TagDetails(Tag = 120, Type = TagType.String, Offset = 9, Required = false)]
			public string? SettlCurrency {get; set;}
			
			[TagDetails(Tag = 2899, Type = TagType.String, Offset = 10, Required = false)]
			public string? SettlCurrencyCodeSource {get; set;}
			
			[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 11, Required = false)]
			public DateTime? EffectiveTime {get; set;}
			
			[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 12, Required = false)]
			public DateTime? ExpireTime {get; set;}
			
			[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 13, Required = false)]
			public DateTime? LastUpdateTime {get; set;}
			
			[Component(Offset = 14, Required = false)]
			public SettlInstructionsData? SettlInstructionsData {get; set;}
			
			[TagDetails(Tag = 492, Type = TagType.Int, Offset = 15, Required = false)]
			public int? PaymentMethod {get; set;}
			
			[TagDetails(Tag = 476, Type = TagType.String, Offset = 16, Required = false)]
			public string? PaymentRef {get; set;}
			
			[TagDetails(Tag = 488, Type = TagType.String, Offset = 17, Required = false)]
			public string? CardHolderName {get; set;}
			
			[TagDetails(Tag = 489, Type = TagType.String, Offset = 18, Required = false)]
			public string? CardNumber {get; set;}
			
			[TagDetails(Tag = 503, Type = TagType.LocalDate, Offset = 19, Required = false)]
			public DateOnly? CardStartDate {get; set;}
			
			[TagDetails(Tag = 490, Type = TagType.LocalDate, Offset = 20, Required = false)]
			public DateOnly? CardExpDate {get; set;}
			
			[TagDetails(Tag = 491, Type = TagType.String, Offset = 21, Required = false)]
			public string? CardIssNum {get; set;}
			
			[TagDetails(Tag = 504, Type = TagType.LocalDate, Offset = 22, Required = false)]
			public DateOnly? PaymentDate {get; set;}
			
			[TagDetails(Tag = 505, Type = TagType.String, Offset = 23, Required = false)]
			public string? PaymentRemitterID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (SettlInstID is not null) writer.WriteString(162, SettlInstID);
				if (SettlInstTransType is not null) writer.WriteString(163, SettlInstTransType);
				if (SettlInstRefID is not null) writer.WriteString(214, SettlInstRefID);
				if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
				if (Side is not null) writer.WriteString(54, Side);
				if (Product is not null) writer.WriteWholeNumber(460, Product.Value);
				if (SecurityType is not null) writer.WriteString(167, SecurityType);
				if (CFICode is not null) writer.WriteString(461, CFICode);
				if (UPICode is not null) writer.WriteString(2891, UPICode);
				if (SettlCurrency is not null) writer.WriteString(120, SettlCurrency);
				if (SettlCurrencyCodeSource is not null) writer.WriteString(2899, SettlCurrencyCodeSource);
				if (EffectiveTime is not null) writer.WriteUtcTimeStamp(168, EffectiveTime.Value);
				if (ExpireTime is not null) writer.WriteUtcTimeStamp(126, ExpireTime.Value);
				if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
				if (SettlInstructionsData is not null) ((IFixEncoder)SettlInstructionsData).Encode(writer);
				if (PaymentMethod is not null) writer.WriteWholeNumber(492, PaymentMethod.Value);
				if (PaymentRef is not null) writer.WriteString(476, PaymentRef);
				if (CardHolderName is not null) writer.WriteString(488, CardHolderName);
				if (CardNumber is not null) writer.WriteString(489, CardNumber);
				if (CardStartDate is not null) writer.WriteLocalDateOnly(503, CardStartDate.Value);
				if (CardExpDate is not null) writer.WriteLocalDateOnly(490, CardExpDate.Value);
				if (CardIssNum is not null) writer.WriteString(491, CardIssNum);
				if (PaymentDate is not null) writer.WriteLocalDateOnly(504, PaymentDate.Value);
				if (PaymentRemitterID is not null) writer.WriteString(505, PaymentRemitterID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				SettlInstID = view.GetString(162);
				SettlInstTransType = view.GetString(163);
				SettlInstRefID = view.GetString(214);
				if (view.GetView("Parties") is IMessageView viewParties)
				{
					Parties = new();
					((IFixParser)Parties).Parse(viewParties);
				}
				Side = view.GetString(54);
				Product = view.GetInt32(460);
				SecurityType = view.GetString(167);
				CFICode = view.GetString(461);
				UPICode = view.GetString(2891);
				SettlCurrency = view.GetString(120);
				SettlCurrencyCodeSource = view.GetString(2899);
				EffectiveTime = view.GetDateTime(168);
				ExpireTime = view.GetDateTime(126);
				LastUpdateTime = view.GetDateTime(779);
				if (view.GetView("SettlInstructionsData") is IMessageView viewSettlInstructionsData)
				{
					SettlInstructionsData = new();
					((IFixParser)SettlInstructionsData).Parse(viewSettlInstructionsData);
				}
				PaymentMethod = view.GetInt32(492);
				PaymentRef = view.GetString(476);
				CardHolderName = view.GetString(488);
				CardNumber = view.GetString(489);
				CardStartDate = view.GetDateOnly(503);
				CardExpDate = view.GetDateOnly(490);
				CardIssNum = view.GetString(491);
				PaymentDate = view.GetDateOnly(504);
				PaymentRemitterID = view.GetString(505);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "SettlInstID":
					{
						value = SettlInstID;
						break;
					}
					case "SettlInstTransType":
					{
						value = SettlInstTransType;
						break;
					}
					case "SettlInstRefID":
					{
						value = SettlInstRefID;
						break;
					}
					case "Parties":
					{
						value = Parties;
						break;
					}
					case "Side":
					{
						value = Side;
						break;
					}
					case "Product":
					{
						value = Product;
						break;
					}
					case "SecurityType":
					{
						value = SecurityType;
						break;
					}
					case "CFICode":
					{
						value = CFICode;
						break;
					}
					case "UPICode":
					{
						value = UPICode;
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
					case "SettlInstructionsData":
					{
						value = SettlInstructionsData;
						break;
					}
					case "PaymentMethod":
					{
						value = PaymentMethod;
						break;
					}
					case "PaymentRef":
					{
						value = PaymentRef;
						break;
					}
					case "CardHolderName":
					{
						value = CardHolderName;
						break;
					}
					case "CardNumber":
					{
						value = CardNumber;
						break;
					}
					case "CardStartDate":
					{
						value = CardStartDate;
						break;
					}
					case "CardExpDate":
					{
						value = CardExpDate;
						break;
					}
					case "CardIssNum":
					{
						value = CardIssNum;
						break;
					}
					case "PaymentDate":
					{
						value = PaymentDate;
						break;
					}
					case "PaymentRemitterID":
					{
						value = PaymentRemitterID;
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
				SettlInstID = null;
				SettlInstTransType = null;
				SettlInstRefID = null;
				((IFixReset?)Parties)?.Reset();
				Side = null;
				Product = null;
				SecurityType = null;
				CFICode = null;
				UPICode = null;
				SettlCurrency = null;
				SettlCurrencyCodeSource = null;
				EffectiveTime = null;
				ExpireTime = null;
				LastUpdateTime = null;
				((IFixReset?)SettlInstructionsData)?.Reset();
				PaymentMethod = null;
				PaymentRef = null;
				CardHolderName = null;
				CardNumber = null;
				CardStartDate = null;
				CardExpDate = null;
				CardIssNum = null;
				PaymentDate = null;
				PaymentRemitterID = null;
			}
		}
		[Group(NoOfTag = 778, Offset = 0, Required = false)]
		public NoSettlInst[]? SettlInst {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SettlInst is not null && SettlInst.Length != 0)
			{
				writer.WriteWholeNumber(778, SettlInst.Length);
				for (int i = 0; i < SettlInst.Length; i++)
				{
					((IFixEncoder)SettlInst[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoSettlInst") is IMessageView viewNoSettlInst)
			{
				var count = viewNoSettlInst.GroupCount();
				SettlInst = new NoSettlInst[count];
				for (int i = 0; i < count; i++)
				{
					SettlInst[i] = new();
					((IFixParser)SettlInst[i]).Parse(viewNoSettlInst.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoSettlInst":
				{
					value = SettlInst;
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
			SettlInst = null;
		}
	}
}
