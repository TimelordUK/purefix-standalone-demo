using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("p", FixVersion.FIX50SP2)]
	public sealed partial class RegistrationInstructionsResponse : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 513, Type = TagType.String, Offset = 1, Required = true)]
		public string? RegistID {get; set;}
		
		[TagDetails(Tag = 514, Type = TagType.String, Offset = 2, Required = true)]
		public string? RegistTransType {get; set;}
		
		[TagDetails(Tag = 508, Type = TagType.String, Offset = 3, Required = true)]
		public string? RegistRefID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 4, Required = false)]
		public string? ClOrdID {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public Parties? Parties {get; set;}
		
		[TagDetails(Tag = 1, Type = TagType.String, Offset = 6, Required = false)]
		public string? Account {get; set;}
		
		[TagDetails(Tag = 660, Type = TagType.Int, Offset = 7, Required = false)]
		public int? AcctIDSource {get; set;}
		
		[TagDetails(Tag = 506, Type = TagType.String, Offset = 8, Required = true)]
		public string? RegistStatus {get; set;}
		
		[TagDetails(Tag = 507, Type = TagType.Int, Offset = 9, Required = false)]
		public int? RegistRejReasonCode {get; set;}
		
		[TagDetails(Tag = 496, Type = TagType.String, Offset = 10, Required = false)]
		public string? RegistRejReasonText {get; set;}
		
		[Component(Offset = 11, Required = true)]
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
			if (RegistID is not null) writer.WriteString(513, RegistID);
			if (RegistTransType is not null) writer.WriteString(514, RegistTransType);
			if (RegistRefID is not null) writer.WriteString(508, RegistRefID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (Account is not null) writer.WriteString(1, Account);
			if (AcctIDSource is not null) writer.WriteWholeNumber(660, AcctIDSource.Value);
			if (RegistStatus is not null) writer.WriteString(506, RegistStatus);
			if (RegistRejReasonCode is not null) writer.WriteWholeNumber(507, RegistRejReasonCode.Value);
			if (RegistRejReasonText is not null) writer.WriteString(496, RegistRejReasonText);
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
			RegistID = view.GetString(513);
			RegistTransType = view.GetString(514);
			RegistRefID = view.GetString(508);
			ClOrdID = view.GetString(11);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			Account = view.GetString(1);
			AcctIDSource = view.GetInt32(660);
			RegistStatus = view.GetString(506);
			RegistRejReasonCode = view.GetInt32(507);
			RegistRejReasonText = view.GetString(496);
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
				case "RegistID":
				{
					value = RegistID;
					break;
				}
				case "RegistTransType":
				{
					value = RegistTransType;
					break;
				}
				case "RegistRefID":
				{
					value = RegistRefID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "Parties":
				{
					value = Parties;
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
				case "RegistStatus":
				{
					value = RegistStatus;
					break;
				}
				case "RegistRejReasonCode":
				{
					value = RegistRejReasonCode;
					break;
				}
				case "RegistRejReasonText":
				{
					value = RegistRejReasonText;
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
			RegistID = null;
			RegistTransType = null;
			RegistRefID = null;
			ClOrdID = null;
			((IFixReset?)Parties)?.Reset();
			Account = null;
			AcctIDSource = null;
			RegistStatus = null;
			RegistRejReasonCode = null;
			RegistRejReasonText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
