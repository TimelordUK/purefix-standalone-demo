using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("AF", FixVersion.FIX50SP2)]
	public sealed partial class OrderMassStatusRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 584, Type = TagType.String, Offset = 1, Required = true)]
		public string? MassStatusReqID {get; set;}
		
		[TagDetails(Tag = 585, Type = TagType.Int, Offset = 2, Required = true)]
		public int? MassStatusReqType {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public TargetParties? TargetParties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 5, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 6, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 7, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 8, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public UnderlyingInstrument? UnderlyingInstrument {get; set;}
		
		[TagDetails(Tag = 54, Type = TagType.String, Offset = 11, Required = false)]
		public string? Side {get; set;}
		
		[Component(Offset = 12, Required = true)]
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
			if (MassStatusReqID is not null) writer.WriteString(584, MassStatusReqID);
			if (MassStatusReqType is not null) writer.WriteWholeNumber(585, MassStatusReqType.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (TargetParties is not null) ((IFixEncoder)TargetParties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UnderlyingInstrument is not null) ((IFixEncoder)UnderlyingInstrument).Encode(writer);
			if (Side is not null) writer.WriteString(54, Side);
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
			MassStatusReqID = view.GetString(584);
			MassStatusReqType = view.GetInt32(585);
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
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UnderlyingInstrument") is IMessageView viewUnderlyingInstrument)
			{
				UnderlyingInstrument = new();
				((IFixParser)UnderlyingInstrument).Parse(viewUnderlyingInstrument);
			}
			Side = view.GetString(54);
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
				case "MassStatusReqID":
				{
					value = MassStatusReqID;
					break;
				}
				case "MassStatusReqType":
				{
					value = MassStatusReqType;
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
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UnderlyingInstrument":
				{
					value = UnderlyingInstrument;
					break;
				}
				case "Side":
				{
					value = Side;
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
			MassStatusReqID = null;
			MassStatusReqType = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)TargetParties)?.Reset();
			Account = null;
			AcctIDSource = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UnderlyingInstrument)?.Reset();
			Side = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
