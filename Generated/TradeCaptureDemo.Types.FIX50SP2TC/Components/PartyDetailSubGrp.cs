using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailSubGrp : IFixComponent
	{
		public sealed partial class NoPartyDetailSubIDs : IFixGroup
		{
			[TagDetails(Tag = 1695, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartyDetailSubID {get; set;}
			
			[TagDetails(Tag = 1696, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PartyDetailSubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyDetailSubID is not null) writer.WriteString(1695, PartyDetailSubID);
				if (PartyDetailSubIDType is not null) writer.WriteWholeNumber(1696, PartyDetailSubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyDetailSubID = view.GetString(1695);
				PartyDetailSubIDType = view.GetInt32(1696);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyDetailSubID":
					{
						value = PartyDetailSubID;
						break;
					}
					case "PartyDetailSubIDType":
					{
						value = PartyDetailSubIDType;
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
				PartyDetailSubID = null;
				PartyDetailSubIDType = null;
			}
		}
		[Group(NoOfTag = 1694, Offset = 0, Required = false)]
		public NoPartyDetailSubIDs[]? PartyDetailSubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyDetailSubIDs is not null && PartyDetailSubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1694, PartyDetailSubIDs.Length);
				for (int i = 0; i < PartyDetailSubIDs.Length; i++)
				{
					((IFixEncoder)PartyDetailSubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyDetailSubIDs") is IMessageView viewNoPartyDetailSubIDs)
			{
				var count = viewNoPartyDetailSubIDs.GroupCount();
				PartyDetailSubIDs = new NoPartyDetailSubIDs[count];
				for (int i = 0; i < count; i++)
				{
					PartyDetailSubIDs[i] = new();
					((IFixParser)PartyDetailSubIDs[i]).Parse(viewNoPartyDetailSubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyDetailSubIDs":
				{
					value = PartyDetailSubIDs;
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
			PartyDetailSubIDs = null;
		}
	}
}
