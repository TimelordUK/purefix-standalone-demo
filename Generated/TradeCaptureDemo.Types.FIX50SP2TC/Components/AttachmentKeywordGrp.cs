using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AttachmentKeywordGrp : IFixComponent
	{
		public sealed partial class NoAttachmentKeywords : IFixGroup
		{
			[TagDetails(Tag = 2114, Type = TagType.String, Offset = 0, Required = false)]
			public string? AttachmentKeyword {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AttachmentKeyword is not null) writer.WriteString(2114, AttachmentKeyword);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AttachmentKeyword = view.GetString(2114);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AttachmentKeyword":
					{
						value = AttachmentKeyword;
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
				AttachmentKeyword = null;
			}
		}
		[Group(NoOfTag = 2113, Offset = 0, Required = false)]
		public NoAttachmentKeywords[]? AttachmentKeywords {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AttachmentKeywords is not null && AttachmentKeywords.Length != 0)
			{
				writer.WriteWholeNumber(2113, AttachmentKeywords.Length);
				for (int i = 0; i < AttachmentKeywords.Length; i++)
				{
					((IFixEncoder)AttachmentKeywords[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAttachmentKeywords") is IMessageView viewNoAttachmentKeywords)
			{
				var count = viewNoAttachmentKeywords.GroupCount();
				AttachmentKeywords = new NoAttachmentKeywords[count];
				for (int i = 0; i < count; i++)
				{
					AttachmentKeywords[i] = new();
					((IFixParser)AttachmentKeywords[i]).Parse(viewNoAttachmentKeywords.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAttachmentKeywords":
				{
					value = AttachmentKeywords;
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
			AttachmentKeywords = null;
		}
	}
}
