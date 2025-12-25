using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedPartyDetailAltSubGrp : IFixComponent
	{
		public sealed partial class NoRelatedPartyDetailAltSubIDs : IFixGroup
		{
			[TagDetails(Tag = 1573, Type = TagType.String, Offset = 0, Required = false)]
			public string? RelatedPartyDetailAltSubID {get; set;}
			
			[TagDetails(Tag = 1574, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RelatedPartyDetailAltSubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedPartyDetailAltSubID is not null) writer.WriteString(1573, RelatedPartyDetailAltSubID);
				if (RelatedPartyDetailAltSubIDType is not null) writer.WriteWholeNumber(1574, RelatedPartyDetailAltSubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedPartyDetailAltSubID = view.GetString(1573);
				RelatedPartyDetailAltSubIDType = view.GetInt32(1574);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedPartyDetailAltSubID":
					{
						value = RelatedPartyDetailAltSubID;
						break;
					}
					case "RelatedPartyDetailAltSubIDType":
					{
						value = RelatedPartyDetailAltSubIDType;
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
				RelatedPartyDetailAltSubID = null;
				RelatedPartyDetailAltSubIDType = null;
			}
		}
		[Group(NoOfTag = 1572, Offset = 0, Required = false)]
		public NoRelatedPartyDetailAltSubIDs[]? RelatedPartyDetailAltSubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedPartyDetailAltSubIDs is not null && RelatedPartyDetailAltSubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1572, RelatedPartyDetailAltSubIDs.Length);
				for (int i = 0; i < RelatedPartyDetailAltSubIDs.Length; i++)
				{
					((IFixEncoder)RelatedPartyDetailAltSubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedPartyDetailAltSubIDs") is IMessageView viewNoRelatedPartyDetailAltSubIDs)
			{
				var count = viewNoRelatedPartyDetailAltSubIDs.GroupCount();
				RelatedPartyDetailAltSubIDs = new NoRelatedPartyDetailAltSubIDs[count];
				for (int i = 0; i < count; i++)
				{
					RelatedPartyDetailAltSubIDs[i] = new();
					((IFixParser)RelatedPartyDetailAltSubIDs[i]).Parse(viewNoRelatedPartyDetailAltSubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedPartyDetailAltSubIDs":
				{
					value = RelatedPartyDetailAltSubIDs;
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
			RelatedPartyDetailAltSubIDs = null;
		}
	}
}
