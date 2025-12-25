using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("C", FixVersion.FIX50SP2)]
	public sealed partial class Email : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 164, Type = TagType.String, Offset = 1, Required = true)]
		public string? EmailThreadID {get; set;}
		
		[TagDetails(Tag = 94, Type = TagType.String, Offset = 2, Required = true)]
		public string? EmailType {get; set;}
		
		[TagDetails(Tag = 42, Type = TagType.UtcTimestamp, Offset = 3, Required = false)]
		public DateTime? OrigTime {get; set;}
		
		[TagDetails(Tag = 147, Type = TagType.String, Offset = 4, Required = true)]
		public string? Subject {get; set;}
		
		[TagDetails(Tag = 356, Type = TagType.Length, Offset = 5, Required = false)]
		public int? EncodedSubjectLen {get; set;}
		
		[TagDetails(Tag = 357, Type = TagType.RawData, Offset = 6, Required = false)]
		public byte[]? EncodedSubject {get; set;}
		
		[Component(Offset = 7, Required = false)]
		public RoutingGrp? RoutingGrp {get; set;}
		
		[Component(Offset = 8, Required = false)]
		public InstrmtGrp? InstrmtGrp {get; set;}
		
		[Component(Offset = 9, Required = false)]
		public UndInstrmtGrp? UndInstrmtGrp {get; set;}
		
		[Component(Offset = 10, Required = false)]
		public InstrmtLegGrp? InstrmtLegGrp {get; set;}
		
		[TagDetails(Tag = 37, Type = TagType.String, Offset = 11, Required = false)]
		public string? OrderID {get; set;}
		
		[TagDetails(Tag = 11, Type = TagType.String, Offset = 12, Required = false)]
		public string? ClOrdID {get; set;}
		
		[Component(Offset = 13, Required = true)]
		public LinesOfTextGrp? LinesOfTextGrp {get; set;}
		
		[TagDetails(Tag = 95, Type = TagType.Length, Offset = 14, Required = false)]
		public int? RawDataLength {get; set;}
		
		[TagDetails(Tag = 96, Type = TagType.RawData, Offset = 15, Required = false)]
		public byte[]? RawData {get; set;}
		
		[Component(Offset = 16, Required = false)]
		public AttachmentGrp? AttachmentGrp {get; set;}
		
		[Component(Offset = 17, Required = true)]
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
			if (EmailThreadID is not null) writer.WriteString(164, EmailThreadID);
			if (EmailType is not null) writer.WriteString(94, EmailType);
			if (OrigTime is not null) writer.WriteUtcTimeStamp(42, OrigTime.Value);
			if (Subject is not null) writer.WriteString(147, Subject);
			if (EncodedSubjectLen is not null) writer.WriteWholeNumber(356, EncodedSubjectLen.Value);
			if (EncodedSubject is not null) writer.WriteBuffer(357, EncodedSubject);
			if (RoutingGrp is not null) ((IFixEncoder)RoutingGrp).Encode(writer);
			if (InstrmtGrp is not null) ((IFixEncoder)InstrmtGrp).Encode(writer);
			if (UndInstrmtGrp is not null) ((IFixEncoder)UndInstrmtGrp).Encode(writer);
			if (InstrmtLegGrp is not null) ((IFixEncoder)InstrmtLegGrp).Encode(writer);
			if (OrderID is not null) writer.WriteString(37, OrderID);
			if (ClOrdID is not null) writer.WriteString(11, ClOrdID);
			if (LinesOfTextGrp is not null) ((IFixEncoder)LinesOfTextGrp).Encode(writer);
			if (RawDataLength is not null) writer.WriteWholeNumber(95, RawDataLength.Value);
			if (RawData is not null) writer.WriteBuffer(96, RawData);
			if (AttachmentGrp is not null) ((IFixEncoder)AttachmentGrp).Encode(writer);
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
			EmailThreadID = view.GetString(164);
			EmailType = view.GetString(94);
			OrigTime = view.GetDateTime(42);
			Subject = view.GetString(147);
			EncodedSubjectLen = view.GetInt32(356);
			EncodedSubject = view.GetByteArray(357);
			if (view.GetView("RoutingGrp") is IMessageView viewRoutingGrp)
			{
				RoutingGrp = new();
				((IFixParser)RoutingGrp).Parse(viewRoutingGrp);
			}
			if (view.GetView("InstrmtGrp") is IMessageView viewInstrmtGrp)
			{
				InstrmtGrp = new();
				((IFixParser)InstrmtGrp).Parse(viewInstrmtGrp);
			}
			if (view.GetView("UndInstrmtGrp") is IMessageView viewUndInstrmtGrp)
			{
				UndInstrmtGrp = new();
				((IFixParser)UndInstrmtGrp).Parse(viewUndInstrmtGrp);
			}
			if (view.GetView("InstrmtLegGrp") is IMessageView viewInstrmtLegGrp)
			{
				InstrmtLegGrp = new();
				((IFixParser)InstrmtLegGrp).Parse(viewInstrmtLegGrp);
			}
			OrderID = view.GetString(37);
			ClOrdID = view.GetString(11);
			if (view.GetView("LinesOfTextGrp") is IMessageView viewLinesOfTextGrp)
			{
				LinesOfTextGrp = new();
				((IFixParser)LinesOfTextGrp).Parse(viewLinesOfTextGrp);
			}
			RawDataLength = view.GetInt32(95);
			RawData = view.GetByteArray(96);
			if (view.GetView("AttachmentGrp") is IMessageView viewAttachmentGrp)
			{
				AttachmentGrp = new();
				((IFixParser)AttachmentGrp).Parse(viewAttachmentGrp);
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
				case "EmailThreadID":
				{
					value = EmailThreadID;
					break;
				}
				case "EmailType":
				{
					value = EmailType;
					break;
				}
				case "OrigTime":
				{
					value = OrigTime;
					break;
				}
				case "Subject":
				{
					value = Subject;
					break;
				}
				case "EncodedSubjectLen":
				{
					value = EncodedSubjectLen;
					break;
				}
				case "EncodedSubject":
				{
					value = EncodedSubject;
					break;
				}
				case "RoutingGrp":
				{
					value = RoutingGrp;
					break;
				}
				case "InstrmtGrp":
				{
					value = InstrmtGrp;
					break;
				}
				case "UndInstrmtGrp":
				{
					value = UndInstrmtGrp;
					break;
				}
				case "InstrmtLegGrp":
				{
					value = InstrmtLegGrp;
					break;
				}
				case "OrderID":
				{
					value = OrderID;
					break;
				}
				case "ClOrdID":
				{
					value = ClOrdID;
					break;
				}
				case "LinesOfTextGrp":
				{
					value = LinesOfTextGrp;
					break;
				}
				case "RawDataLength":
				{
					value = RawDataLength;
					break;
				}
				case "RawData":
				{
					value = RawData;
					break;
				}
				case "AttachmentGrp":
				{
					value = AttachmentGrp;
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
			EmailThreadID = null;
			EmailType = null;
			OrigTime = null;
			Subject = null;
			EncodedSubjectLen = null;
			EncodedSubject = null;
			((IFixReset?)RoutingGrp)?.Reset();
			((IFixReset?)InstrmtGrp)?.Reset();
			((IFixReset?)UndInstrmtGrp)?.Reset();
			((IFixReset?)InstrmtLegGrp)?.Reset();
			OrderID = null;
			ClOrdID = null;
			((IFixReset?)LinesOfTextGrp)?.Reset();
			RawDataLength = null;
			RawData = null;
			((IFixReset?)AttachmentGrp)?.Reset();
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
