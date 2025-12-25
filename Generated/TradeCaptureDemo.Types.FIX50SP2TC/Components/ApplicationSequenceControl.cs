using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ApplicationSequenceControl : IFixComponent
	{
		[TagDetails(Tag = 1180, Type = TagType.String, Offset = 0, Required = false)]
		public string? ApplID {get; set;}
		
		[TagDetails(Tag = 1181, Type = TagType.Int, Offset = 1, Required = false)]
		public int? ApplSeqNum {get; set;}
		
		[TagDetails(Tag = 1350, Type = TagType.Int, Offset = 2, Required = false)]
		public int? ApplLastSeqNum {get; set;}
		
		[TagDetails(Tag = 1352, Type = TagType.Boolean, Offset = 3, Required = false)]
		public bool? ApplResendFlag {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ApplID is not null) writer.WriteString(1180, ApplID);
			if (ApplSeqNum is not null) writer.WriteWholeNumber(1181, ApplSeqNum.Value);
			if (ApplLastSeqNum is not null) writer.WriteWholeNumber(1350, ApplLastSeqNum.Value);
			if (ApplResendFlag is not null) writer.WriteBoolean(1352, ApplResendFlag.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			ApplID = view.GetString(1180);
			ApplSeqNum = view.GetInt32(1181);
			ApplLastSeqNum = view.GetInt32(1350);
			ApplResendFlag = view.GetBool(1352);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "ApplID":
				{
					value = ApplID;
					break;
				}
				case "ApplSeqNum":
				{
					value = ApplSeqNum;
					break;
				}
				case "ApplLastSeqNum":
				{
					value = ApplLastSeqNum;
					break;
				}
				case "ApplResendFlag":
				{
					value = ApplResendFlag;
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
			ApplID = null;
			ApplSeqNum = null;
			ApplLastSeqNum = null;
			ApplResendFlag = null;
		}
	}
}
