using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ApplIDRequestGrp : IFixComponent
	{
		public sealed partial class NoApplIDs : IFixGroup
		{
			[TagDetails(Tag = 1355, Type = TagType.String, Offset = 0, Required = false)]
			public string? RefApplID {get; set;}
			
			[TagDetails(Tag = 1433, Type = TagType.String, Offset = 1, Required = false)]
			public string? RefApplReqID {get; set;}
			
			[TagDetails(Tag = 1182, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ApplBegSeqNum {get; set;}
			
			[TagDetails(Tag = 1183, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ApplEndSeqNum {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public NestedParties? NestedParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RefApplID is not null) writer.WriteString(1355, RefApplID);
				if (RefApplReqID is not null) writer.WriteString(1433, RefApplReqID);
				if (ApplBegSeqNum is not null) writer.WriteWholeNumber(1182, ApplBegSeqNum.Value);
				if (ApplEndSeqNum is not null) writer.WriteWholeNumber(1183, ApplEndSeqNum.Value);
				if (NestedParties is not null) ((IFixEncoder)NestedParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RefApplID = view.GetString(1355);
				RefApplReqID = view.GetString(1433);
				ApplBegSeqNum = view.GetInt32(1182);
				ApplEndSeqNum = view.GetInt32(1183);
				if (view.GetView("NestedParties") is IMessageView viewNestedParties)
				{
					NestedParties = new();
					((IFixParser)NestedParties).Parse(viewNestedParties);
				}
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
					case "RefApplReqID":
					{
						value = RefApplReqID;
						break;
					}
					case "ApplBegSeqNum":
					{
						value = ApplBegSeqNum;
						break;
					}
					case "ApplEndSeqNum":
					{
						value = ApplEndSeqNum;
						break;
					}
					case "NestedParties":
					{
						value = NestedParties;
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
				RefApplReqID = null;
				ApplBegSeqNum = null;
				ApplEndSeqNum = null;
				((IFixReset?)NestedParties)?.Reset();
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
