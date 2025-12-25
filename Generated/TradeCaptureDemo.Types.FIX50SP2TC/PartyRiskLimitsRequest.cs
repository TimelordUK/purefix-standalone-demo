using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CL", FixVersion.FIX50SP2)]
	public sealed partial class PartyRiskLimitsRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1666, Type = TagType.String, Offset = 1, Required = true)]
		public string? RiskLimitRequestID {get; set;}
		
		[TagDetails(Tag = 1760, Type = TagType.Int, Offset = 2, Required = false)]
		public int? RiskLimitRequestType {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 3, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 5, Required = false)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public RequestedPartyRoleGrp? RequestedPartyRoleGrp {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public RequestedRiskLimitTypesGrp? RequestedRiskLimitTypesGrp {get; set;}
		
		[TagDetails(Tag = 1533, Type = TagType.String, Offset = 8, Required = false)]
		public string? RiskLimitPlatform {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public RiskInstrumentScopeGrp? RiskInstrumentScopeGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 10, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 11, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 12, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 13, Required = true)]
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
			if (RiskLimitRequestID is not null) writer.WriteString(1666, RiskLimitRequestID);
			if (RiskLimitRequestType is not null) writer.WriteWholeNumber(1760, RiskLimitRequestType.Value);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (RequestedPartyRoleGrp is not null) ((IFixEncoder)RequestedPartyRoleGrp).Encode(writer);
			if (RequestedRiskLimitTypesGrp is not null) ((IFixEncoder)RequestedRiskLimitTypesGrp).Encode(writer);
			if (RiskLimitPlatform is not null) writer.WriteString(1533, RiskLimitPlatform);
			if (RiskInstrumentScopeGrp is not null) ((IFixEncoder)RiskInstrumentScopeGrp).Encode(writer);
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
			RiskLimitRequestID = view.GetString(1666);
			RiskLimitRequestType = view.GetInt32(1760);
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
			if (view.GetView("RequestedRiskLimitTypesGrp") is IMessageView viewRequestedRiskLimitTypesGrp)
			{
				RequestedRiskLimitTypesGrp = new();
				((IFixParser)RequestedRiskLimitTypesGrp).Parse(viewRequestedRiskLimitTypesGrp);
			}
			RiskLimitPlatform = view.GetString(1533);
			if (view.GetView("RiskInstrumentScopeGrp") is IMessageView viewRiskInstrumentScopeGrp)
			{
				RiskInstrumentScopeGrp = new();
				((IFixParser)RiskInstrumentScopeGrp).Parse(viewRiskInstrumentScopeGrp);
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
				case "RiskLimitRequestID":
				{
					value = RiskLimitRequestID;
					break;
				}
				case "RiskLimitRequestType":
				{
					value = RiskLimitRequestType;
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
				case "RequestedRiskLimitTypesGrp":
				{
					value = RequestedRiskLimitTypesGrp;
					break;
				}
				case "RiskLimitPlatform":
				{
					value = RiskLimitPlatform;
					break;
				}
				case "RiskInstrumentScopeGrp":
				{
					value = RiskInstrumentScopeGrp;
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
			RiskLimitRequestID = null;
			RiskLimitRequestType = null;
			SubscriptionRequestType = null;
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)RequestedPartyRoleGrp)?.Reset();
			((IFixReset?)RequestedRiskLimitTypesGrp)?.Reset();
			RiskLimitPlatform = null;
			((IFixReset?)RiskInstrumentScopeGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
