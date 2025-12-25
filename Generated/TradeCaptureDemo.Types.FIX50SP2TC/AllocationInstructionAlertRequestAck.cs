using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("DV", FixVersion.FIX50SP2)]
	public sealed partial class AllocationInstructionAlertRequestAck : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 2758, Type = TagType.String, Offset = 1, Required = true)]
		public string? AllocRequestID {get; set;}
		
		[TagDetails(Tag = 2768, Type = TagType.Int, Offset = 2, Required = true)]
		public int? AllocRequestStatus {get; set;}
		
		[TagDetails(Tag = 1328, Type = TagType.String, Offset = 3, Required = false)]
		public string? RejectText {get; set;}
		
		[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 4, Required = false)]
		public int? EncodedRejectTextLen {get; set;}
		
		[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 5, Required = false)]
		public byte[]? EncodedRejectText {get; set;}
		
		[Component(Offset = 6, Required = true)]
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
			if (AllocRequestID is not null) writer.WriteString(2758, AllocRequestID);
			if (AllocRequestStatus is not null) writer.WriteWholeNumber(2768, AllocRequestStatus.Value);
			if (RejectText is not null) writer.WriteString(1328, RejectText);
			if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
			if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
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
			AllocRequestID = view.GetString(2758);
			AllocRequestStatus = view.GetInt32(2768);
			RejectText = view.GetString(1328);
			EncodedRejectTextLen = view.GetInt32(1664);
			EncodedRejectText = view.GetByteArray(1665);
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
				case "AllocRequestID":
				{
					value = AllocRequestID;
					break;
				}
				case "AllocRequestStatus":
				{
					value = AllocRequestStatus;
					break;
				}
				case "RejectText":
				{
					value = RejectText;
					break;
				}
				case "EncodedRejectTextLen":
				{
					value = EncodedRejectTextLen;
					break;
				}
				case "EncodedRejectText":
				{
					value = EncodedRejectText;
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
			AllocRequestID = null;
			AllocRequestStatus = null;
			RejectText = null;
			EncodedRejectTextLen = null;
			EncodedRejectText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
