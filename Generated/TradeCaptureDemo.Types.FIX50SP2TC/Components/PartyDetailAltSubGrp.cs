using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailAltSubGrp : IFixComponent
	{
		public sealed partial class NoPartyDetailAltSubIDs : IFixGroup
		{
			[TagDetails(Tag = 1520, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartyDetailAltSubID {get; set;}
			
			[TagDetails(Tag = 1521, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PartyDetailAltSubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyDetailAltSubID is not null) writer.WriteString(1520, PartyDetailAltSubID);
				if (PartyDetailAltSubIDType is not null) writer.WriteWholeNumber(1521, PartyDetailAltSubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyDetailAltSubID = view.GetString(1520);
				PartyDetailAltSubIDType = view.GetInt32(1521);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyDetailAltSubID":
					{
						value = PartyDetailAltSubID;
						break;
					}
					case "PartyDetailAltSubIDType":
					{
						value = PartyDetailAltSubIDType;
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
				PartyDetailAltSubID = null;
				PartyDetailAltSubIDType = null;
			}
		}
		[Group(NoOfTag = 1519, Offset = 0, Required = false)]
		public NoPartyDetailAltSubIDs[]? PartyDetailAltSubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyDetailAltSubIDs is not null && PartyDetailAltSubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1519, PartyDetailAltSubIDs.Length);
				for (int i = 0; i < PartyDetailAltSubIDs.Length; i++)
				{
					((IFixEncoder)PartyDetailAltSubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyDetailAltSubIDs") is IMessageView viewNoPartyDetailAltSubIDs)
			{
				var count = viewNoPartyDetailAltSubIDs.GroupCount();
				PartyDetailAltSubIDs = new NoPartyDetailAltSubIDs[count];
				for (int i = 0; i < count; i++)
				{
					PartyDetailAltSubIDs[i] = new();
					((IFixParser)PartyDetailAltSubIDs[i]).Parse(viewNoPartyDetailAltSubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyDetailAltSubIDs":
				{
					value = PartyDetailAltSubIDs;
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
			PartyDetailAltSubIDs = null;
		}
	}
}
