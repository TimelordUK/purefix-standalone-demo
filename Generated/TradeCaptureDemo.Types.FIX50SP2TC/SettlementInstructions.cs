using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("T", FixVersion.FIX50SP2)]
	public sealed partial class SettlementInstructions : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 777, Type = TagType.String, Offset = 1, Required = true)]
		public string? SettlInstMsgID {get; set;}
		
		[TagDetails(Tag = 791, Type = TagType.String, Offset = 2, Required = false)]
		public string? SettlInstReqID {get; set;}
		
		[TagDetails(Tag = 160, Type = TagType.String, Offset = 3, Required = true)]
		public string? SettlInstMode {get; set;}
		
		[TagDetails(Tag = 792, Type = TagType.Int, Offset = 4, Required = false)]
		public int? SettlInstReqRejCode {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 5, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 8, Required = false)]
		public string? ClOrdID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 9, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public SettlInstGrp? SettlInstGrp {get; set;}
		
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
			if (SettlInstMsgID is not null) writer.WriteString(777, SettlInstMsgID);
			if (SettlInstReqID is not null) writer.WriteString(791, SettlInstReqID);
			if (SettlInstMode is not null) writer.WriteString(160, SettlInstMode);
			if (SettlInstReqRejCode is not null) writer.WriteWholeNumber(792, SettlInstReqRejCode.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (SettlInstGrp is not null) ((IFixEncoder)SettlInstGrp).Encode(writer);
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
			SettlInstMsgID = view.GetString(777);
			SettlInstReqID = view.GetString(791);
			SettlInstMode = view.GetString(160);
			SettlInstReqRejCode = view.GetInt32(792);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			ClOrdID = view.GetString(11);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("SettlInstGrp") is IMessageView viewSettlInstGrp)
			{
				SettlInstGrp = new();
				((IFixParser)SettlInstGrp).Parse(viewSettlInstGrp);
			}
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
				case "SettlInstMsgID":
				{
					value = SettlInstMsgID;
					break;
				}
				case "SettlInstReqID":
				{
					value = SettlInstReqID;
					break;
				}
				case "SettlInstMode":
				{
					value = SettlInstMode;
					break;
				}
				case "SettlInstReqRejCode":
				{
					value = SettlInstReqRejCode;
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
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "SettlInstGrp":
				{
					value = SettlInstGrp;
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
			SettlInstMsgID = null;
			SettlInstReqID = null;
			SettlInstMode = null;
			SettlInstReqRejCode = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			ClOrdID = null;
			TransactTime = null;
			((IFixReset?)SettlInstGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
