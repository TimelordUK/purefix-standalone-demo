using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BH", FixVersion.FIX50SP2)]
	public sealed partial class ConfirmationRequest : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 859, Type = TagType.String, Offset = 1, Required = true)]
		public string? ConfirmReqID {get; set;}
		
		[TagDetails(Tag = 773, Type = TagType.Int, Offset = 2, Required = true)]
		public int? ConfirmType {get; set;}
		
		[Component(Offset = 3, Required = false)]
		public OrdAllocGrp? OrdAllocGrp {get; set;}
		
		[TagDetails(Tag = 70, Type = TagType.String, Offset = 4, Required = false)]
		public string? AllocID {get; set;}
		
		[TagDetails(Tag = 793, Type = TagType.String, Offset = 5, Required = false)]
		public string? SecondaryAllocID {get; set;}
		
		[TagDetails(Tag = 467, Type = TagType.String, Offset = 6, Required = false)]
		public string? IndividualAllocID {get; set;}
		
		[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 7, Required = true)]
		public DateTime? TransactTime {get; set;}
		
		[TagDetails(Tag = 79, Type = TagType.String, Offset = 8, Required = false)]
		public string? AllocAccount {get; set;}
		
		[TagDetails(Tag = 661, Type = TagType.Int, Offset = 9, Required = false)]
		public int? AllocAcctIDSource {get; set;}
		
		[TagDetails(Tag = 798, Type = TagType.Int, Offset = 10, Required = false)]
		public int? AllocAccountType {get; set;}
		
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
			if (ConfirmReqID is not null) writer.WriteString(859, ConfirmReqID);
			if (ConfirmType is not null) writer.WriteWholeNumber(773, ConfirmType.Value);
			if (OrdAllocGrp is not null) ((IFixEncoder)OrdAllocGrp).Encode(writer);
			if (AllocID is not null) writer.WriteString(70, AllocID);
			if (SecondaryAllocID is not null) writer.WriteString(793, SecondaryAllocID);
			if (IndividualAllocID is not null) writer.WriteString(467, IndividualAllocID);
			if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			if (AllocAccount is not null) writer.WriteString(79, AllocAccount);
			if (AllocAcctIDSource is not null) writer.WriteWholeNumber(661, AllocAcctIDSource.Value);
			if (AllocAccountType is not null) writer.WriteWholeNumber(798, AllocAccountType.Value);
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
			ConfirmReqID = view.GetString(859);
			ConfirmType = view.GetInt32(773);
			if (view.GetView("OrdAllocGrp") is IMessageView viewOrdAllocGrp)
			{
				OrdAllocGrp = new();
				((IFixParser)OrdAllocGrp).Parse(viewOrdAllocGrp);
			}
			AllocID = view.GetString(70);
			SecondaryAllocID = view.GetString(793);
			IndividualAllocID = view.GetString(467);
			TransactTime = view.GetDateTime(60);
			AllocAccount = view.GetString(79);
			AllocAcctIDSource = view.GetInt32(661);
			AllocAccountType = view.GetInt32(798);
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
				case "ConfirmReqID":
				{
					value = ConfirmReqID;
					break;
				}
				case "ConfirmType":
				{
					value = ConfirmType;
					break;
				}
				case "OrdAllocGrp":
				{
					value = OrdAllocGrp;
					break;
				}
				case "AllocID":
				{
					value = AllocID;
					break;
				}
				case "SecondaryAllocID":
				{
					value = SecondaryAllocID;
					break;
				}
				case "IndividualAllocID":
				{
					value = IndividualAllocID;
					break;
				}
				case "TransactTime":
				{
					value = TransactTime;
					break;
				}
				case "AllocAccount":
				{
					value = AllocAccount;
					break;
				}
				case "AllocAcctIDSource":
				{
					value = AllocAcctIDSource;
					break;
				}
				case "AllocAccountType":
				{
					value = AllocAccountType;
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
			ConfirmReqID = null;
			ConfirmType = null;
			((IFixReset?)OrdAllocGrp)?.Reset();
			AllocID = null;
			SecondaryAllocID = null;
			IndividualAllocID = null;
			TransactTime = null;
			AllocAccount = null;
			AllocAcctIDSource = null;
			AllocAccountType = null;
			Text = null;
			EncodedTextLen = null;
			EncodedText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
