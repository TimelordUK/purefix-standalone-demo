using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NstdPtys3SubGrp : IFixComponent
	{
		public sealed partial class NoNested3PartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 953, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested3PartySubID {get; set;}
			
			[TagDetails(Tag = 954, Type = TagType.Int, Offset = 1, Required = false)]
			public int? Nested3PartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested3PartySubID is not null) writer.WriteString(953, Nested3PartySubID);
				if (Nested3PartySubIDType is not null) writer.WriteWholeNumber(954, Nested3PartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested3PartySubID = view.GetString(953);
				Nested3PartySubIDType = view.GetInt32(954);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested3PartySubID":
					{
						value = Nested3PartySubID;
						break;
					}
					case "Nested3PartySubIDType":
					{
						value = Nested3PartySubIDType;
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
				Nested3PartySubID = null;
				Nested3PartySubIDType = null;
			}
		}
		[Group(NoOfTag = 952, Offset = 0, Required = false)]
		public NoNested3PartySubIDs[]? Nested3PartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested3PartySubIDs is not null && Nested3PartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(952, Nested3PartySubIDs.Length);
				for (int i = 0; i < Nested3PartySubIDs.Length; i++)
				{
					((IFixEncoder)Nested3PartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested3PartySubIDs") is IMessageView viewNoNested3PartySubIDs)
			{
				var count = viewNoNested3PartySubIDs.GroupCount();
				Nested3PartySubIDs = new NoNested3PartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested3PartySubIDs[i] = new();
					((IFixParser)Nested3PartySubIDs[i]).Parse(viewNoNested3PartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested3PartySubIDs":
				{
					value = Nested3PartySubIDs;
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
			Nested3PartySubIDs = null;
		}
	}
}
