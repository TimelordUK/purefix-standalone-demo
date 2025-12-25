using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BO", FixVersion.FIX50SP2)]
	public sealed partial class ContraryIntentionReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[Component(Offset = 1, Required = false)]
		public ApplicationSequenceControl? ApplicationSequenceControl {get; set;}
		
		[TagDetails(Tag = 977, Type = TagType.String, Offset = 2, Required = true)]
		public string? ContIntRptID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 3, Required = false)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 978, Type = TagType.Boolean, Offset = 4, Required = false)]
		public bool? LateIndicator {get; set;}
		
		[TagDetails(Tag = 979, Type = TagType.String, Offset = 5, Required = false)]
		public string? InputSource {get; set;}
		
		[TagDetails(Tag = 715, Type = TagType.LocalDate, Offset = 6, Required = true)]
		public DateOnly? ClearingBusinessDate {get; set;}
		
		[Component(Offset = 7, Required = true)]
		public Parties? Parties {get; set;}
		
		[Component(Offset = 8, Required = true)]
		public ExpirationQty? ExpirationQty {get; set;}
		
		[Component(Offset = 9, Required = true)]
		public Instrument? Instrument {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
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
			if (ApplicationSequenceControl is not null) ((IFixEncoder)ApplicationSequenceControl).Encode(writer);
			if (ContIntRptID is not null) writer.WriteString(977, ContIntRptID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (LateIndicator is not null) writer.WriteBoolean(978, LateIndicator.Value);
			if (InputSource is not null) writer.WriteString(979, InputSource);
			if (ClearingBusinessDate is not null) writer.WriteLocalDateOnly(715, ClearingBusinessDate.Value);
			if (Parties is not null) ((IFixEncoder)Parties).Encode(writer);
			if (ExpirationQty is not null) ((IFixEncoder)ExpirationQty).Encode(writer);
			if (Instrument is not null) ((IFixEncoder)Instrument).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
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
			ContIntRptID = view.GetString(977);
			TransactTime = view.GetDateTime(60);
			LateIndicator = view.GetBool(978);
			InputSource = view.GetString(979);
			ClearingBusinessDate = view.GetDateOnly(715);
			if (view.GetView("Parties") is IMessageView viewParties)
			{
				Parties = new();
				((IFixParser)Parties).Parse(viewParties);
			}
			if (view.GetView("ExpirationQty") is IMessageView viewExpirationQty)
			{
				ExpirationQty = new();
				((IFixParser)ExpirationQty).Parse(viewExpirationQty);
			}
			if (view.GetView("Instrument") is IMessageView viewInstrument)
			{
				Instrument = new();
				((IFixParser)Instrument).Parse(viewInstrument);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
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
				case "ApplicationSequenceControl":
				{
					value = ApplicationSequenceControl;
					break;
				}
				case "ContIntRptID":
				{
					value = ContIntRptID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "LateIndicator":
				{
					value = LateIndicator;
					break;
				}
				case "InputSource":
				{
					value = InputSource;
					break;
				}
				case "ClearingBusinessDate":
				{
					value = ClearingBusinessDate;
					break;
				}
				case "Parties":
				{
					value = Parties;
					break;
				}
				case "ExpirationQty":
				{
					value = ExpirationQty;
					break;
				}
				case "Instrument":
				{
					value = Instrument;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
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
			ContIntRptID = null;
			TransactTime = null;
			LateIndicator = null;
			InputSource = null;
			ClearingBusinessDate = null;
			((IFixReset?)Parties)?.Reset();
			((IFixReset?)ExpirationQty)?.Reset();
			((IFixReset?)Instrument)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
