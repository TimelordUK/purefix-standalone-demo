using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NstdPtys4SubGrp : IFixComponent
	{
		public sealed partial class NoNested4PartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 1412, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested4PartySubID {get; set;}
			
			[TagDetails(Tag = 1411, Type = TagType.Int, Offset = 1, Required = false)]
			public int? Nested4PartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested4PartySubID is not null) writer.WriteString(1412, Nested4PartySubID);
				if (Nested4PartySubIDType is not null) writer.WriteWholeNumber(1411, Nested4PartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested4PartySubID = view.GetString(1412);
				Nested4PartySubIDType = view.GetInt32(1411);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested4PartySubID":
					{
						value = Nested4PartySubID;
						break;
					}
					case "Nested4PartySubIDType":
					{
						value = Nested4PartySubIDType;
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
				Nested4PartySubID = null;
				Nested4PartySubIDType = null;
			}
		}
		[Group(NoOfTag = 1413, Offset = 0, Required = false)]
		public NoNested4PartySubIDs[]? Nested4PartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested4PartySubIDs is not null && Nested4PartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1413, Nested4PartySubIDs.Length);
				for (int i = 0; i < Nested4PartySubIDs.Length; i++)
				{
					((IFixEncoder)Nested4PartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested4PartySubIDs") is IMessageView viewNoNested4PartySubIDs)
			{
				var count = viewNoNested4PartySubIDs.GroupCount();
				Nested4PartySubIDs = new NoNested4PartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested4PartySubIDs[i] = new();
					((IFixParser)Nested4PartySubIDs[i]).Parse(viewNoNested4PartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested4PartySubIDs":
				{
					value = Nested4PartySubIDs;
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
			Nested4PartySubIDs = null;
		}
	}
}
