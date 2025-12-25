using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BY", FixVersion.FIX50SP2)]
	public sealed partial class ApplicationMessageReport : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 1356, Type = TagType.String, Offset = 1, Required = true)]
		public string? ApplReportID {get; set;}
		
		[TagDetails(Tag = 1346, Type = TagType.String, Offset = 2, Required = false)]
		public string? ApplReqID {get; set;}
		
		[TagDetails(Tag = 1426, Type = TagType.Int, Offset = 3, Required = true)]
		public int? ApplReportType {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public ApplIDReportGrp? ApplIDReportGrp {get; set;}
		
		[TagDetails(Tag = 58, Type = TagType.String, Offset = 5, Required = false)]
		public string? Text {get; set;}
		
		[TagDetails(Tag = 354, Type = TagType.Length, Offset = 6, Required = false)]
		public int? EncodedTextLen {get; set;}
		
		[TagDetails(Tag = 355, Type = TagType.RawData, Offset = 7, Required = false)]
		public byte[]? EncodedText {get; set;}
		
		[Component(Offset = 8, Required = true)]
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
			if (ApplReportID is not null) writer.WriteString(1356, ApplReportID);
			if (ApplReqID is not null) writer.WriteString(1346, ApplReqID);
			if (ApplReportType is not null) writer.WriteWholeNumber(1426, ApplReportType.Value);
			if (ApplIDReportGrp is not null) ((IFixEncoder)ApplIDReportGrp).Encode(writer);
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
			ApplReportID = view.GetString(1356);
			ApplReqID = view.GetString(1346);
			ApplReportType = view.GetInt32(1426);
			if (view.GetView("ApplIDReportGrp") is IMessageView viewApplIDReportGrp)
			{
				ApplIDReportGrp = new();
				((IFixParser)ApplIDReportGrp).Parse(viewApplIDReportGrp);
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
				case "ApplReportID":
				{
					value = ApplReportID;
					break;
				}
				case "ApplReqID":
				{
					value = ApplReqID;
					break;
				}
				case "ApplReportType":
				{
					value = ApplReportType;
					break;
				}
				case "ApplIDReportGrp":
				{
					value = ApplIDReportGrp;
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
			ApplReportID = null;
			ApplReqID = null;
			ApplReportType = null;
			((IFixReset?)ApplIDReportGrp)?.Reset();
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
