using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AttachmentGrp : IFixComponent
	{
		public sealed partial class NoAttachments : IFixGroup
		{
			[TagDetails(Tag = 2105, Type = TagType.String, Offset = 0, Required = false)]
			public string? AttachmentName {get; set;}
			
			[TagDetails(Tag = 2106, Type = TagType.String, Offset = 1, Required = false)]
			public string? AttachmentMediaType {get; set;}
			
			[TagDetails(Tag = 2107, Type = TagType.String, Offset = 2, Required = false)]
			public string? AttachmentClassification {get; set;}
			
			[TagDetails(Tag = 2108, Type = TagType.String, Offset = 3, Required = false)]
			public string? AttachmentExternalURL {get; set;}
			
			[TagDetails(Tag = 2109, Type = TagType.Int, Offset = 4, Required = false)]
			public int? AttachmentEncodingType {get; set;}
			
			[TagDetails(Tag = 2110, Type = TagType.Int, Offset = 5, Required = false)]
			public int? UnencodedAttachmentLen {get; set;}
			
			[TagDetails(Tag = 2111, Type = TagType.Length, Offset = 6, Required = false)]
			public int? EncodedAttachmentLen {get; set;}
			
			[TagDetails(Tag = 2112, Type = TagType.RawData, Offset = 7, Required = false)]
			public byte[]? EncodedAttachment {get; set;}
			
			[Component(Offset = 8, Required = false)]
			public AttachmentKeywordGrp? AttachmentKeywordGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AttachmentName is not null) writer.WriteString(2105, AttachmentName);
				if (AttachmentMediaType is not null) writer.WriteString(2106, AttachmentMediaType);
				if (AttachmentClassification is not null) writer.WriteString(2107, AttachmentClassification);
				if (AttachmentExternalURL is not null) writer.WriteString(2108, AttachmentExternalURL);
				if (AttachmentEncodingType is not null) writer.WriteWholeNumber(2109, AttachmentEncodingType.Value);
				if (UnencodedAttachmentLen is not null) writer.WriteWholeNumber(2110, UnencodedAttachmentLen.Value);
				if (EncodedAttachmentLen is not null) writer.WriteWholeNumber(2111, EncodedAttachmentLen.Value);
				if (EncodedAttachment is not null) writer.WriteBuffer(2112, EncodedAttachment);
				if (AttachmentKeywordGrp is not null) ((IFixEncoder)AttachmentKeywordGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AttachmentName = view.GetString(2105);
				AttachmentMediaType = view.GetString(2106);
				AttachmentClassification = view.GetString(2107);
				AttachmentExternalURL = view.GetString(2108);
				AttachmentEncodingType = view.GetInt32(2109);
				UnencodedAttachmentLen = view.GetInt32(2110);
				EncodedAttachmentLen = view.GetInt32(2111);
				EncodedAttachment = view.GetByteArray(2112);
				if (view.GetView("AttachmentKeywordGrp") is IMessageView viewAttachmentKeywordGrp)
				{
					AttachmentKeywordGrp = new();
					((IFixParser)AttachmentKeywordGrp).Parse(viewAttachmentKeywordGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AttachmentName":
					{
						value = AttachmentName;
						break;
					}
					case "AttachmentMediaType":
					{
						value = AttachmentMediaType;
						break;
					}
					case "AttachmentClassification":
					{
						value = AttachmentClassification;
						break;
					}
					case "AttachmentExternalURL":
					{
						value = AttachmentExternalURL;
						break;
					}
					case "AttachmentEncodingType":
					{
						value = AttachmentEncodingType;
						break;
					}
					case "UnencodedAttachmentLen":
					{
						value = UnencodedAttachmentLen;
						break;
					}
					case "EncodedAttachmentLen":
					{
						value = EncodedAttachmentLen;
						break;
					}
					case "EncodedAttachment":
					{
						value = EncodedAttachment;
						break;
					}
					case "AttachmentKeywordGrp":
					{
						value = AttachmentKeywordGrp;
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
				AttachmentName = null;
				AttachmentMediaType = null;
				AttachmentClassification = null;
				AttachmentExternalURL = null;
				AttachmentEncodingType = null;
				UnencodedAttachmentLen = null;
				EncodedAttachmentLen = null;
				EncodedAttachment = null;
				((IFixReset?)AttachmentKeywordGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 2104, Offset = 0, Required = false)]
		public NoAttachments[]? Attachments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Attachments is not null && Attachments.Length != 0)
			{
				writer.WriteWholeNumber(2104, Attachments.Length);
				for (int i = 0; i < Attachments.Length; i++)
				{
					((IFixEncoder)Attachments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAttachments") is IMessageView viewNoAttachments)
			{
				var count = viewNoAttachments.GroupCount();
				Attachments = new NoAttachments[count];
				for (int i = 0; i < count; i++)
				{
					Attachments[i] = new();
					((IFixParser)Attachments[i]).Parse(viewNoAttachments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAttachments":
				{
					value = Attachments;
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
			Attachments = null;
		}
	}
}
