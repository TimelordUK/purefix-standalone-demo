using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TargetPtysSubGrp : IFixComponent
	{
		public sealed partial class NoTargetPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 2434, Type = TagType.String, Offset = 0, Required = false)]
			public string? TargetPartySubID {get; set;}
			
			[TagDetails(Tag = 2435, Type = TagType.Int, Offset = 1, Required = false)]
			public int? TargetPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TargetPartySubID is not null) writer.WriteString(2434, TargetPartySubID);
				if (TargetPartySubIDType is not null) writer.WriteWholeNumber(2435, TargetPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TargetPartySubID = view.GetString(2434);
				TargetPartySubIDType = view.GetInt32(2435);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TargetPartySubID":
					{
						value = TargetPartySubID;
						break;
					}
					case "TargetPartySubIDType":
					{
						value = TargetPartySubIDType;
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
				TargetPartySubID = null;
				TargetPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 2433, Offset = 0, Required = false)]
		public NoTargetPartySubIDs[]? TargetPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TargetPartySubIDs is not null && TargetPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(2433, TargetPartySubIDs.Length);
				for (int i = 0; i < TargetPartySubIDs.Length; i++)
				{
					((IFixEncoder)TargetPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTargetPartySubIDs") is IMessageView viewNoTargetPartySubIDs)
			{
				var count = viewNoTargetPartySubIDs.GroupCount();
				TargetPartySubIDs = new NoTargetPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					TargetPartySubIDs[i] = new();
					((IFixParser)TargetPartySubIDs[i]).Parse(viewNoTargetPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTargetPartySubIDs":
				{
					value = TargetPartySubIDs;
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
			TargetPartySubIDs = null;
		}
	}
}
