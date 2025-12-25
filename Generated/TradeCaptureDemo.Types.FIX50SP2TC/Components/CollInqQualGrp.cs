using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CollInqQualGrp : IFixComponent
	{
		public sealed partial class NoCollInquiryQualifier : IFixGroup
		{
			[TagDetails(Tag = 896, Type = TagType.Int, Offset = 0, Required = false)]
			public int? CollInquiryQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CollInquiryQualifier is not null) writer.WriteWholeNumber(896, CollInquiryQualifier.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CollInquiryQualifier = view.GetInt32(896);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CollInquiryQualifier":
					{
						value = CollInquiryQualifier;
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
				CollInquiryQualifier = null;
			}
		}
		[Group(NoOfTag = 938, Offset = 0, Required = false)]
		public NoCollInquiryQualifier[]? CollInquiryQualifier {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CollInquiryQualifier is not null && CollInquiryQualifier.Length != 0)
			{
				writer.WriteWholeNumber(938, CollInquiryQualifier.Length);
				for (int i = 0; i < CollInquiryQualifier.Length; i++)
				{
					((IFixEncoder)CollInquiryQualifier[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCollInquiryQualifier") is IMessageView viewNoCollInquiryQualifier)
			{
				var count = viewNoCollInquiryQualifier.GroupCount();
				CollInquiryQualifier = new NoCollInquiryQualifier[count];
				for (int i = 0; i < count; i++)
				{
					CollInquiryQualifier[i] = new();
					((IFixParser)CollInquiryQualifier[i]).Parse(viewNoCollInquiryQualifier.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCollInquiryQualifier":
				{
					value = CollInquiryQualifier;
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
			CollInquiryQualifier = null;
		}
	}
}
