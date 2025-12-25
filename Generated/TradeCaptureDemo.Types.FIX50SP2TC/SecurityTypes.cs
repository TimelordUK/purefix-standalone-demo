using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("w", FixVersion.FIX50SP2)]
	public sealed partial class SecurityTypes : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 320, Type = TagType.String, Offset = 2, Required = true)]
		public string? SecurityReqID {get; set;}
		
		[TagDetails(Tag = 322, Type = TagType.String, Offset = 3, Required = true)]
		public string? SecurityResponseID {get; set;}
		
		[TagDetails(Tag = 323, Type = TagType.Int, Offset = 4, Required = true)]
		public int? SecurityResponseType {get; set;}
		
		[TagDetails(Tag = 557, Type = TagType.Int, Offset = 5, Required = false)]
		public int? TotNoSecurityTypes {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 6, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public SecTypesGrp? SecTypesGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 8, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 9, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 10, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 1301, Type = TagType.String, Offset = 11, Required = false)]
		public string? MarketID {get; set;}
		
		[TagDetails(Tag = 1300, Type = TagType.String, Offset = 12, Required = false)]
		public string? MarketSegmentID {get; set;}
		
		[TagDetails(Tag = 336, Type = TagType.String, Offset = 13, Required = false)]
		public string? TradingSessionID {get; set;}
		
		[TagDetails(Tag = 625, Type = TagType.String, Offset = 14, Required = false)]
		public string? TradingSessionSubID {get; set;}
		
		[TagDetails(Tag = 263, Type = TagType.String, Offset = 15, Required = false)]
		public string? SubscriptionRequestType {get; set;}
		
		[Component(Offset = 16, Required = true)]
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (SecurityReqID is not null) writer.WriteString(320, SecurityReqID);
			if (SecurityResponseID is not null) writer.WriteString(322, SecurityResponseID);
			if (SecurityResponseType is not null) writer.WriteWholeNumber(323, SecurityResponseType.Value);
			if (TotNoSecurityTypes is not null) writer.WriteWholeNumber(557, TotNoSecurityTypes.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (SecTypesGrp is not null) ((IFixEncoder)SecTypesGrp).Encode(writer);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (MarketID is not null) writer.WriteString(1301, MarketID);
			if (MarketSegmentID is not null) writer.WriteString(1300, MarketSegmentID);
			if (TradingSessionID is not null) writer.WriteString(336, TradingSessionID);
			if (TradingSessionSubID is not null) writer.WriteString(625, TradingSessionSubID);
			if (SubscriptionRequestType is not null) writer.WriteString(263, SubscriptionRequestType);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			SecurityReqID = view.GetString(320);
			SecurityResponseID = view.GetString(322);
			SecurityResponseType = view.GetInt32(323);
			TotNoSecurityTypes = view.GetInt32(557);
			LastFragment = view.GetBool(893);
			if (view.GetView("SecTypesGrp") is IMessageView viewSecTypesGrp)
			{
				SecTypesGrp = new();
				((IFixParser)SecTypesGrp).Parse(viewSecTypesGrp);
			}
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			MarketID = view.GetString(1301);
			MarketSegmentID = view.GetString(1300);
			TradingSessionID = view.GetString(336);
			TradingSessionSubID = view.GetString(625);
			SubscriptionRequestType = view.GetString(263);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "SecurityReqID":
				{
					value = SecurityReqID;
					break;
				}
				case "SecurityResponseID":
				{
					value = SecurityResponseID;
					break;
				}
				case "SecurityResponseType":
				{
					value = SecurityResponseType;
					break;
				}
				case "TotNoSecurityTypes":
				{
					value = TotNoSecurityTypes;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "SecTypesGrp":
				{
					value = SecTypesGrp;
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
				case "MarketID":
				{
					value = MarketID;
					break;
				}
				case "MarketSegmentID":
				{
					value = MarketSegmentID;
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
				case "SubscriptionRequestType":
				{
					value = SubscriptionRequestType;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			SecurityReqID = null;
			SecurityResponseID = null;
			SecurityResponseType = null;
			TotNoSecurityTypes = null;
			LastFragment = null;
			((IFixReset?)SecTypesGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			MarketID = null;
			MarketSegmentID = null;
			TradingSessionID = null;
			TradingSessionSubID = null;
			SubscriptionRequestType = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
