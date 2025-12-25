using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MarginReqmtInqQualGrp : IFixComponent
	{
		public sealed partial class NoMarginReqmtInqQualifier : IFixGroup
		{
			[TagDetails(Tag = 1637, Type = TagType.Int, Offset = 0, Required = false)]
			public int? MarginReqmtInqQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MarginReqmtInqQualifier is not null) writer.WriteWholeNumber(1637, MarginReqmtInqQualifier.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MarginReqmtInqQualifier = view.GetInt32(1637);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MarginReqmtInqQualifier":
					{
						value = MarginReqmtInqQualifier;
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
				MarginReqmtInqQualifier = null;
			}
		}
		[Group(NoOfTag = 1636, Offset = 0, Required = false)]
		public NoMarginReqmtInqQualifier[]? MarginReqmtInqQualifier {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MarginReqmtInqQualifier is not null && MarginReqmtInqQualifier.Length != 0)
			{
				writer.WriteWholeNumber(1636, MarginReqmtInqQualifier.Length);
				for (int i = 0; i < MarginReqmtInqQualifier.Length; i++)
				{
					((IFixEncoder)MarginReqmtInqQualifier[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMarginReqmtInqQualifier") is IMessageView viewNoMarginReqmtInqQualifier)
			{
				var count = viewNoMarginReqmtInqQualifier.GroupCount();
				MarginReqmtInqQualifier = new NoMarginReqmtInqQualifier[count];
				for (int i = 0; i < count; i++)
				{
					MarginReqmtInqQualifier[i] = new();
					((IFixParser)MarginReqmtInqQualifier[i]).Parse(viewNoMarginReqmtInqQualifier.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMarginReqmtInqQualifier":
				{
					value = MarginReqmtInqQualifier;
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
			MarginReqmtInqQualifier = null;
		}
	}
}
