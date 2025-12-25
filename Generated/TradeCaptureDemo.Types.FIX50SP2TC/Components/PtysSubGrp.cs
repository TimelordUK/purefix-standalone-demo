using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PtysSubGrp : IFixComponent
	{
		public sealed partial class NoPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 523, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartySubID {get; set;}
			
			[TagDetails(Tag = 803, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartySubID is not null) writer.WriteString(523, PartySubID);
				if (PartySubIDType is not null) writer.WriteWholeNumber(803, PartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartySubID = view.GetString(523);
				PartySubIDType = view.GetInt32(803);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartySubID":
					{
						value = PartySubID;
						break;
					}
					case "PartySubIDType":
					{
						value = PartySubIDType;
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
				PartySubID = null;
				PartySubIDType = null;
			}
		}
		[Group(NoOfTag = 802, Offset = 0, Required = false)]
		public NoPartySubIDs[]? PartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartySubIDs is not null && PartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(802, PartySubIDs.Length);
				for (int i = 0; i < PartySubIDs.Length; i++)
				{
					((IFixEncoder)PartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartySubIDs") is IMessageView viewNoPartySubIDs)
			{
				var count = viewNoPartySubIDs.GroupCount();
				PartySubIDs = new NoPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					PartySubIDs[i] = new();
					((IFixParser)PartySubIDs[i]).Parse(viewNoPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartySubIDs":
				{
					value = PartySubIDs;
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
			PartySubIDs = null;
		}
	}
}
