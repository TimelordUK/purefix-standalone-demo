using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ApplIDReportGrp : IFixComponent
	{
		public sealed partial class NoApplIDs : IFixGroup
		{
			[TagDetails(Tag = 1355, Type = TagType.String, Offset = 0, Required = false)]
			public string? RefApplID {get; set;}
			
			[TagDetails(Tag = 1399, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ApplNewSeqNum {get; set;}
			
			[TagDetails(Tag = 1357, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RefApplLastSeqNum {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RefApplID is not null) writer.WriteString(1355, RefApplID);
				if (ApplNewSeqNum is not null) writer.WriteWholeNumber(1399, ApplNewSeqNum.Value);
				if (RefApplLastSeqNum is not null) writer.WriteWholeNumber(1357, RefApplLastSeqNum.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RefApplID = view.GetString(1355);
				ApplNewSeqNum = view.GetInt32(1399);
				RefApplLastSeqNum = view.GetInt32(1357);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RefApplID":
					{
						value = RefApplID;
						break;
					}
					case "ApplNewSeqNum":
					{
						value = ApplNewSeqNum;
						break;
					}
					case "RefApplLastSeqNum":
					{
						value = RefApplLastSeqNum;
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
				RefApplID = null;
				ApplNewSeqNum = null;
				RefApplLastSeqNum = null;
			}
		}
		[Group(NoOfTag = 1351, Offset = 0, Required = false)]
		public NoApplIDs[]? ApplIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ApplIDs is not null && ApplIDs.Length != 0)
			{
				writer.WriteWholeNumber(1351, ApplIDs.Length);
				for (int i = 0; i < ApplIDs.Length; i++)
				{
					((IFixEncoder)ApplIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoApplIDs") is IMessageView viewNoApplIDs)
			{
				var count = viewNoApplIDs.GroupCount();
				ApplIDs = new NoApplIDs[count];
				for (int i = 0; i < count; i++)
				{
					ApplIDs[i] = new();
					((IFixParser)ApplIDs[i]).Parse(viewNoApplIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoApplIDs":
				{
					value = ApplIDs;
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
			ApplIDs = null;
		}
	}
}
