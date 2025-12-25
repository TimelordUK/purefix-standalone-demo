using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CU", FixVersion.FIX50SP2)]
	public sealed partial class PartyEntitlementsRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1770, Type = TagType.String, Offset = 1, Required = false)]
		public string? EntitlementRequestID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 2, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public RequestedPartyRoleGrp? RequestedPartyRoleGrp {get; set;}
		
		[TagDetails(Tag = 1883, Type = TagType.Int, Offset = 6, Required = false)]
		public int? EntitlementStatus {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public EntitlementTypeGrp? EntitlementTypeGrp {get; set;}
		
		[TagDetails(Tag = 1784, Type = TagType.String, Offset = 8, Required = false)]
		public string? EntitlementPlatform {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public InstrumentScopeGrp? InstrumentScopeGrp {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public MarketSegmentScopeGrp? MarketSegmentScopeGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 11, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 12, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 13, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 14, Required = true)]
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
			if (EntitlementRequestID is not null) writer.WriteString(1770, EntitlementRequestID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RequestedPartyRoleGrp is not null) ((IFixEncoder)RequestedPartyRoleGrp).Encode(writer);
			if (EntitlementStatus is not null) writer.WriteWholeNumber(1883, EntitlementStatus.Value);
			if (EntitlementTypeGrp is not null) ((IFixEncoder)EntitlementTypeGrp).Encode(writer);
			if (EntitlementPlatform is not null) writer.WriteString(1784, EntitlementPlatform);
			if (InstrumentScopeGrp is not null) ((IFixEncoder)InstrumentScopeGrp).Encode(writer);
			if (MarketSegmentScopeGrp is not null) ((IFixEncoder)MarketSegmentScopeGrp).Encode(writer);
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
			EntitlementRequestID = view.GetString(1770);
			SubscriptionRequestType = view.GetString(263);
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
			EntitlementStatus = view.GetInt32(1883);
			if (view.GetView("EntitlementTypeGrp") is IMessageView viewEntitlementTypeGrp)
			{
				EntitlementTypeGrp = new();
				((IFixParser)EntitlementTypeGrp).Parse(viewEntitlementTypeGrp);
			}
			EntitlementPlatform = view.GetString(1784);
			if (view.GetView("InstrumentScopeGrp") is IMessageView viewInstrumentScopeGrp)
			{
				InstrumentScopeGrp = new();
				((IFixParser)InstrumentScopeGrp).Parse(viewInstrumentScopeGrp);
			}
			if (view.GetView("MarketSegmentScopeGrp") is IMessageView viewMarketSegmentScopeGrp)
			{
				MarketSegmentScopeGrp = new();
				((IFixParser)MarketSegmentScopeGrp).Parse(viewMarketSegmentScopeGrp);
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
				case "EntitlementRequestID":
				{
					value = EntitlementRequestID;
					break;
				}
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
				case "EntitlementStatus":
				{
					value = EntitlementStatus;
					break;
				}
				case "EntitlementTypeGrp":
				{
					value = EntitlementTypeGrp;
					break;
				}
				case "EntitlementPlatform":
				{
					value = EntitlementPlatform;
					break;
				}
				case "InstrumentScopeGrp":
				{
					value = InstrumentScopeGrp;
					break;
				}
				case "MarketSegmentScopeGrp":
				{
					value = MarketSegmentScopeGrp;
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
			EntitlementRequestID = null;
			SubscriptionRequestType = null;
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RequestedPartyRoleGrp)?.Reset();
			EntitlementStatus = null;
			((IFixReset?)EntitlementTypeGrp)?.Reset();
			EntitlementPlatform = null;
			((IFixReset?)InstrumentScopeGrp)?.Reset();
			((IFixReset?)MarketSegmentScopeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
