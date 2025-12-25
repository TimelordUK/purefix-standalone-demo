using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AV", FixVersion.FIX50SP2)]
	public sealed partial class SettlementInstructionRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 791, Type = TagType.String, Offset = 1, Required = true)]
		public string? SettlInstReqID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 2, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 79, Type = TagType.String, Offset = 4, Required = false)]
		public string? AllocAccount {get; set;}
		
		[TagDetails(Tag = 661, Type = TagType.Int, Offset = 5, Required = false)]
		public int? AllocAcctIDSource {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 6, Required = false)]
		public string? Side {get; set;}
		
		[TagDetails(Tag = 460, Type = TagType.Int, Offset = 7, Required = false)]
		public int? Product {get; set;}
		
		[TagDetails(Tag = 167, Type = TagType.String, Offset = 8, Required = false)]
		public string? SecurityType {get; set;}
		
		[TagDetails(Tag = 461, Type = TagType.String, Offset = 9, Required = false)]
		public string? CFICode {get; set;}
		
		[TagDetails(Tag = 2891, Type = TagType.String, Offset = 10, Required = false)]
		public string? UPICode {get; set;}
		
		[TagDetails(Tag = 120, Type = TagType.String, Offset = 11, Required = false)]
		public string? SettlCurrency {get; set;}
		
		[TagDetails(Tag = 2899, Type = TagType.String, Offset = 12, Required = false)]
		public string? SettlCurrencyCodeSource {get; set;}
		
		[TagDetails(Tag = 168, Type = TagType.UtcTimestamp, Offset = 13, Required = false)]
		public DateTime? EffectiveTime {get; set;}
		
		[TagDetails(Tag = 126, Type = TagType.UtcTimestamp, Offset = 14, Required = false)]
		public DateTime? ExpireTime {get; set;}
		
		[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 15, Required = false)]
		public DateTime? LastUpdateTime {get; set;}
		
		[TagDetails(Tag = 169, Type = TagType.Int, Offset = 16, Required = false)]
		public int? StandInstDbType {get; set;}
		
		[TagDetails(Tag = 170, Type = TagType.String, Offset = 17, Required = false)]
		public string? StandInstDbName {get; set;}
		
		[TagDetails(Tag = 171, Type = TagType.String, Offset = 18, Required = false)]
		public string? StandInstDbID {get; set;}
		
		[Component(Offset = 19, Required = true)]
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
			if (SettlInstReqID is not null) writer.WriteString(791, SettlInstReqID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
			if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
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
			if (StandInstDbType is not null) writer.WriteWholeNumber(169, StandInstDbType.Value);
			if (StandInstDbName is not null) writer.WriteString(170, StandInstDbName);
			if (StandInstDbID is not null) writer.WriteString(171, StandInstDbID);
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
			SettlInstReqID = view.GetString(791);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			AllocAccount = view.GetString(79);
			AllocAcctIDSource = view.GetInt32(661);
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
			StandInstDbType = view.GetInt32(169);
			StandInstDbName = view.GetString(170);
			StandInstDbID = view.GetString(171);
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
				case "SettlInstReqID":
				{
					value = SettlInstReqID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "AllocAccount":
				{
					value = AllocAccount;
					break;
				}
				case "AllocAcctIDSource":
				{
					value = AllocAcctIDSource;
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
				case "StandInstDbType":
				{
					value = StandInstDbType;
					break;
				}
				case "StandInstDbName":
				{
					value = StandInstDbName;
					break;
				}
				case "StandInstDbID":
				{
					value = StandInstDbID;
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
			SettlInstReqID = null;
			TransactTime = null;
			((IFixReset?)Parties)?.Reset();
			AllocAccount = null;
			AllocAcctIDSource = null;
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
			StandInstDbType = null;
			StandInstDbName = null;
			StandInstDbID = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
