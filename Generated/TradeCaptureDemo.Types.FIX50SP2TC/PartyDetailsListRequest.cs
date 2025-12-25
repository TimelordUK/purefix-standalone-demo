using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CF", FixVersion.FIX50SP2)]
	public sealed partial class PartyDetailsListRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1505, Type = TagType.String, Offset = 1, Required = true)]
		public string? PartyDetailsListRequestID {get; set;}
		
		[Component(Offset = 2, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public RequestedPartyRoleGrp? RequestedPartyRoleGrp {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public PartyRelationshipGrp? PartyRelationshipGrp {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 6, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 7, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 8, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 9, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 10, Required = true)]
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
			if (PartyDetailsListRequestID is not null) writer.WriteString(1505, PartyDetailsListRequestID);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RequestedPartyRoleGrp is not null) ((IFixEncoder)RequestedPartyRoleGrp).Encode(writer);
			if (PartyRelationshipGrp is not null) ((IFixEncoder)PartyRelationshipGrp).Encode(writer);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
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
			PartyDetailsListRequestID = view.GetString(1505);
			if (view.GetView("RequestingPartyGrp") is IMessageView viewRequestingPartyGrp)
			{
				RequestingPartyGrp = new();
				((IFixParser)RequestingPartyGrp).Parse(viewRequestingPartyGrp);
			}
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("RequestedPartyRoleGrp") is IMessageView viewRequestedPartyRoleGrp)
			{
				RequestedPartyRoleGrp = new();
				((IFixParser)RequestedPartyRoleGrp).Parse(viewRequestedPartyRoleGrp);
			}
			if (view.GetView("PartyRelationshipGrp") is IMessageView viewPartyRelationshipGrp)
			{
				PartyRelationshipGrp = new();
				((IFixParser)PartyRelationshipGrp).Parse(viewPartyRelationshipGrp);
			}
			SubscriptionRequestType = view.GetString(263);
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
				case "PartyDetailsListRequestID":
				{
					value = PartyDetailsListRequestID;
					break;
				}
				case "RequestingPartyGrp":
				{
					value = RequestingPartyGrp;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "RequestedPartyRoleGrp":
				{
					value = RequestedPartyRoleGrp;
					break;
				}
				case "PartyRelationshipGrp":
				{
					value = PartyRelationshipGrp;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
			PartyDetailsListRequestID = null;
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RequestedPartyRoleGrp)?.Reset();
			((IFixReset?)PartyRelationshipGrp)?.Reset();
			SubscriptionRequestType = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
