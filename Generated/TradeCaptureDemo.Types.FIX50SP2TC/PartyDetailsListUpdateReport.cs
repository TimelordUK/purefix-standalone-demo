using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("CK", FixVersion.FIX50SP2)]
	public sealed partial class PartyDetailsListUpdateReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 1510, Type = TagType.String, Offset = 2, Required = true)]
		public string? PartyDetailsListReportID {get; set;}
		
		[TagDetails(Tag = 1505, Type = TagType.String, Offset = 3, Required = false)]
		public string? PartyDetailsListRequestID {get; set;}
		
		[TagDetails(Tag = 1512, Type = TagType.Int, Offset = 4, Required = false)]
		public int? TotNoParties {get; set;}
		
		[TagDetails(Tag = 893, Type = TagType.Boolean, Offset = 5, Required = false)]
		public bool? LastFragment {get; set;}
		
		[Component(Offset = 6, Required = false)]
		public RequestingPartyGrp? RequestingPartyGrp {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public PartyDetailsUpdateGrp? PartyDetailsUpdateGrp {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 8, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 9, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 10, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 11, Required = false)]
		public byte[]? EncodedText {get; set;}
		
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (PartyDetailsListReportID is not null) writer.WriteString(1510, PartyDetailsListReportID);
			if (PartyDetailsListRequestID is not null) writer.WriteString(1505, PartyDetailsListRequestID);
			if (TotNoParties is not null) writer.WriteWholeNumber(1512, TotNoParties.Value);
			if (LastFragment is not null) writer.WriteBoolean(893, LastFragment.Value);
			if (RequestingPartyGrp is not null) ((IFixEncoder)RequestingPartyGrp).Encode(writer);
			if (PartyDetailsUpdateGrp is not null) ((IFixEncoder)PartyDetailsUpdateGrp).Encode(writer);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
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
			if (view.GetView("ApplicationSequenceControl") is IMessageView viewApplicationSequenceControl)
			{
				ApplicationSequenceControl = new();
				((IFixParser)ApplicationSequenceControl).Parse(viewApplicationSequenceControl);
			}
			PartyDetailsListReportID = view.GetString(1510);
			PartyDetailsListRequestID = view.GetString(1505);
			TotNoParties = view.GetInt32(1512);
			LastFragment = view.GetBool(893);
			if (view.GetView("RequestingPartyGrp") is IMessageView viewRequestingPartyGrp)
			{
				RequestingPartyGrp = new();
				((IFixParser)RequestingPartyGrp).Parse(viewRequestingPartyGrp);
			}
			if (view.GetView("PartyDetailsUpdateGrp") is IMessageView viewPartyDetailsUpdateGrp)
			{
				PartyDetailsUpdateGrp = new();
				((IFixParser)PartyDetailsUpdateGrp).Parse(viewPartyDetailsUpdateGrp);
			}
			TransactTime = view.GetDateTime(60);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "PartyDetailsListReportID":
				{
					value = PartyDetailsListReportID;
					break;
				}
				case "PartyDetailsListRequestID":
				{
					value = PartyDetailsListRequestID;
					break;
				}
				case "TotNoParties":
				{
					value = TotNoParties;
					break;
				}
				case "LastFragment":
				{
					value = LastFragment;
					break;
				}
				case "RequestingPartyGrp":
				{
					value = RequestingPartyGrp;
					break;
				}
				case "PartyDetailsUpdateGrp":
				{
					value = PartyDetailsUpdateGrp;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
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
			((IFixReset?)ApplicationSequenceControl)?.Reset();
			PartyDetailsListReportID = null;
			PartyDetailsListRequestID = null;
			TotNoParties = null;
			LastFragment = null;
			((IFixReset?)RequestingPartyGrp)?.Reset();
			((IFixReset?)PartyDetailsUpdateGrp)?.Reset();
			TransactTime = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
