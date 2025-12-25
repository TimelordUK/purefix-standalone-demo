using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedPartyDetailSubGrp : IFixComponent
	{
		public sealed partial class NoRelatedPartyDetailSubIDs : IFixGroup
		{
			[TagDetails(Tag = 1567, Type = TagType.String, Offset = 0, Required = false)]
			public string? RelatedPartyDetailSubID {get; set;}
			
			[TagDetails(Tag = 1568, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RelatedPartyDetailSubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedPartyDetailSubID is not null) writer.WriteString(1567, RelatedPartyDetailSubID);
				if (RelatedPartyDetailSubIDType is not null) writer.WriteWholeNumber(1568, RelatedPartyDetailSubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedPartyDetailSubID = view.GetString(1567);
				RelatedPartyDetailSubIDType = view.GetInt32(1568);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedPartyDetailSubID":
					{
						value = RelatedPartyDetailSubID;
						break;
					}
					case "RelatedPartyDetailSubIDType":
					{
						value = RelatedPartyDetailSubIDType;
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
				RelatedPartyDetailSubID = null;
				RelatedPartyDetailSubIDType = null;
			}
		}
		[Group(NoOfTag = 1566, Offset = 0, Required = false)]
		public NoRelatedPartyDetailSubIDs[]? RelatedPartyDetailSubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedPartyDetailSubIDs is not null && RelatedPartyDetailSubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1566, RelatedPartyDetailSubIDs.Length);
				for (int i = 0; i < RelatedPartyDetailSubIDs.Length; i++)
				{
					((IFixEncoder)RelatedPartyDetailSubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedPartyDetailSubIDs") is IMessageView viewNoRelatedPartyDetailSubIDs)
			{
				var count = viewNoRelatedPartyDetailSubIDs.GroupCount();
				RelatedPartyDetailSubIDs = new NoRelatedPartyDetailSubIDs[count];
				for (int i = 0; i < count; i++)
				{
					RelatedPartyDetailSubIDs[i] = new();
					((IFixParser)RelatedPartyDetailSubIDs[i]).Parse(viewNoRelatedPartyDetailSubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedPartyDetailSubIDs":
				{
					value = RelatedPartyDetailSubIDs;
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
			RelatedPartyDetailSubIDs = null;
		}
	}
}
