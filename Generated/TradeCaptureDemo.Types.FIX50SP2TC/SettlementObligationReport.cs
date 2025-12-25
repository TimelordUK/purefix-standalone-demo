using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BQ", FixVersion.FIX50SP2)]
	public sealed partial class SettlementObligationReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 2, Required = false)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[TagDetails(Tag = 1153, Type = TagType.Int, Offset = 3, Required = false)]
		public int? SettlementCycleNo {get; set;}
		
		[TagDetails(Tag = 1160, Type = TagType.String, Offset = 4, Required = true)]
		public string? SettlObligMsgID {get; set;}
		
		[TagDetails(Tag = 1159, Type = TagType.Int, Offset = 5, Required = true)]
		public int? SettlObligMode {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 6, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 7, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 8, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 9, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[Component(Offset = 10, Required = true)]
		public SettlObligationInstructions? SettlObligationInstructions {get; set;}
		
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (SettlementCycleNo is not null) writer.WriteWholeNumber(1153, SettlementCycleNo.Value);
			if (SettlObligMsgID is not null) writer.WriteString(1160, SettlObligMsgID);
			if (SettlObligMode is not null) writer.WriteWholeNumber(1159, SettlObligMode.Value);
			if (Text is not null) writer.WriteString(58, Text);
			if (EncodedTextLen is not null) writer.WriteWholeNumber(354, EncodedTextLen.Value);
			if (EncodedText is not null) writer.WriteBuffer(355, EncodedText);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (SettlObligationInstructions is not null) ((IFixEncoder)SettlObligationInstructions).Encode(writer);
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
			ClearingBusinessDate = view.GetDateOnly(715);
			SettlementCycleNo = view.GetInt32(1153);
			SettlObligMsgID = view.GetString(1160);
			SettlObligMode = view.GetInt32(1159);
			Text = view.GetString(58);
			EncodedTextLen = view.GetInt32(354);
			EncodedText = view.GetByteArray(355);
			TransactTime = view.GetDateTime(60);
			if (view.GetView("SettlObligationInstructions") is IMessageView viewSettlObligationInstructions)
			{
				SettlObligationInstructions = new();
				((IFixParser)SettlObligationInstructions).Parse(viewSettlObligationInstructions);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "SettlementCycleNo":
				{
					value = SettlementCycleNo;
					break;
				}
				case "SettlObligMsgID":
				{
					value = SettlObligMsgID;
					break;
				}
				case "SettlObligMode":
				{
					value = SettlObligMode;
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
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "SettlObligationInstructions":
				{
					value = SettlObligationInstructions;
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
			ClearingBusinessDate = null;
			SettlementCycleNo = null;
			SettlObligMsgID = null;
			SettlObligMode = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			TransactTime = null;
			((IFixReset?)SettlObligationInstructions)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
