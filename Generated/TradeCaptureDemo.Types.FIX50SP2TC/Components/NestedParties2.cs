using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NestedParties2 : IFixComponent
	{
		public sealed partial class NoNested2PartyIDs : IFixGroup
		{
			[TagDetails(Tag = 757, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested2PartyID {get; set;}
			
			[TagDetails(Tag = 758, Type = TagType.String, Offset = 1, Required = false)]
			public string? Nested2PartyIDSource {get; set;}
			
			[TagDetails(Tag = 759, Type = TagType.Int, Offset = 2, Required = false)]
			public int? Nested2PartyRole {get; set;}
			
			[TagDetails(Tag = 2381, Type = TagType.Int, Offset = 3, Required = false)]
			public int? Nested2PartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public NstdPtys2SubGrp? NstdPtys2SubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested2PartyID is not null) writer.WriteString(757, Nested2PartyID);
				if (Nested2PartyIDSource is not null) writer.WriteString(758, Nested2PartyIDSource);
				if (Nested2PartyRole is not null) writer.WriteWholeNumber(759, Nested2PartyRole.Value);
				if (Nested2PartyRoleQualifier is not null) writer.WriteWholeNumber(2381, Nested2PartyRoleQualifier.Value);
				if (NstdPtys2SubGrp is not null) ((IFixEncoder)NstdPtys2SubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested2PartyID = view.GetString(757);
				Nested2PartyIDSource = view.GetString(758);
				Nested2PartyRole = view.GetInt32(759);
				Nested2PartyRoleQualifier = view.GetInt32(2381);
				if (view.GetView("NstdPtys2SubGrp") is IMessageView viewNstdPtys2SubGrp)
				{
					NstdPtys2SubGrp = new();
					((IFixParser)NstdPtys2SubGrp).Parse(viewNstdPtys2SubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested2PartyID":
					{
						value = Nested2PartyID;
						break;
					}
					case "Nested2PartyIDSource":
					{
						value = Nested2PartyIDSource;
						break;
					}
					case "Nested2PartyRole":
					{
						value = Nested2PartyRole;
						break;
					}
					case "Nested2PartyRoleQualifier":
					{
						value = Nested2PartyRoleQualifier;
						break;
					}
					case "NstdPtys2SubGrp":
					{
						value = NstdPtys2SubGrp;
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
				Nested2PartyID = null;
				Nested2PartyIDSource = null;
				Nested2PartyRole = null;
				Nested2PartyRoleQualifier = null;
				((IFixReset?)NstdPtys2SubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 756, Offset = 0, Required = false)]
		public NoNested2PartyIDs[]? Nested2PartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested2PartyIDs is not null && Nested2PartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(756, Nested2PartyIDs.Length);
				for (int i = 0; i < Nested2PartyIDs.Length; i++)
				{
					((IFixEncoder)Nested2PartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested2PartyIDs") is IMessageView viewNoNested2PartyIDs)
			{
				var count = viewNoNested2PartyIDs.GroupCount();
				Nested2PartyIDs = new NoNested2PartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested2PartyIDs[i] = new();
					((IFixParser)Nested2PartyIDs[i]).Parse(viewNoNested2PartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested2PartyIDs":
				{
					value = Nested2PartyIDs;
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
			Nested2PartyIDs = null;
		}
	}
}
