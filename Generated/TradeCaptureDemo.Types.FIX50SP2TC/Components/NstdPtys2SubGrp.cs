using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NstdPtys2SubGrp : IFixComponent
	{
		public sealed partial class NoNested2PartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 760, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested2PartySubID {get; set;}
			
			[TagDetails(Tag = 807, Type = TagType.Int, Offset = 1, Required = false)]
			public int? Nested2PartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested2PartySubID is not null) writer.WriteString(760, Nested2PartySubID);
				if (Nested2PartySubIDType is not null) writer.WriteWholeNumber(807, Nested2PartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested2PartySubID = view.GetString(760);
				Nested2PartySubIDType = view.GetInt32(807);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested2PartySubID":
					{
						value = Nested2PartySubID;
						break;
					}
					case "Nested2PartySubIDType":
					{
						value = Nested2PartySubIDType;
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
				Nested2PartySubID = null;
				Nested2PartySubIDType = null;
			}
		}
		[Group(NoOfTag = 806, Offset = 0, Required = false)]
		public NoNested2PartySubIDs[]? Nested2PartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested2PartySubIDs is not null && Nested2PartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(806, Nested2PartySubIDs.Length);
				for (int i = 0; i < Nested2PartySubIDs.Length; i++)
				{
					((IFixEncoder)Nested2PartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested2PartySubIDs") is IMessageView viewNoNested2PartySubIDs)
			{
				var count = viewNoNested2PartySubIDs.GroupCount();
				Nested2PartySubIDs = new NoNested2PartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested2PartySubIDs[i] = new();
					((IFixParser)Nested2PartySubIDs[i]).Parse(viewNoNested2PartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested2PartySubIDs":
				{
					value = Nested2PartySubIDs;
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
			Nested2PartySubIDs = null;
		}
	}
}
