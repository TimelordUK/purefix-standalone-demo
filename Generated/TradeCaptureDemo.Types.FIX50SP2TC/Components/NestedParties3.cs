using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NestedParties3 : IFixComponent
	{
		public sealed partial class NoNested3PartyIDs : IFixGroup
		{
			[TagDetails(Tag = 949, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested3PartyID {get; set;}
			
			[TagDetails(Tag = 950, Type = TagType.String, Offset = 1, Required = false)]
			public string? Nested3PartyIDSource {get; set;}
			
			[TagDetails(Tag = 951, Type = TagType.Int, Offset = 2, Required = false)]
			public int? Nested3PartyRole {get; set;}
			
			[TagDetails(Tag = 2382, Type = TagType.Int, Offset = 3, Required = false)]
			public int? Nested3PartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public NstdPtys3SubGrp? NstdPtys3SubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested3PartyID is not null) writer.WriteString(949, Nested3PartyID);
				if (Nested3PartyIDSource is not null) writer.WriteString(950, Nested3PartyIDSource);
				if (Nested3PartyRole is not null) writer.WriteWholeNumber(951, Nested3PartyRole.Value);
				if (Nested3PartyRoleQualifier is not null) writer.WriteWholeNumber(2382, Nested3PartyRoleQualifier.Value);
				if (NstdPtys3SubGrp is not null) ((IFixEncoder)NstdPtys3SubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested3PartyID = view.GetString(949);
				Nested3PartyIDSource = view.GetString(950);
				Nested3PartyRole = view.GetInt32(951);
				Nested3PartyRoleQualifier = view.GetInt32(2382);
				if (view.GetView("NstdPtys3SubGrp") is IMessageView viewNstdPtys3SubGrp)
				{
					NstdPtys3SubGrp = new();
					((IFixParser)NstdPtys3SubGrp).Parse(viewNstdPtys3SubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested3PartyID":
					{
						value = Nested3PartyID;
						break;
					}
					case "Nested3PartyIDSource":
					{
						value = Nested3PartyIDSource;
						break;
					}
					case "Nested3PartyRole":
					{
						value = Nested3PartyRole;
						break;
					}
					case "Nested3PartyRoleQualifier":
					{
						value = Nested3PartyRoleQualifier;
						break;
					}
					case "NstdPtys3SubGrp":
					{
						value = NstdPtys3SubGrp;
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
				Nested3PartyID = null;
				Nested3PartyIDSource = null;
				Nested3PartyRole = null;
				Nested3PartyRoleQualifier = null;
				((IFixReset?)NstdPtys3SubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 948, Offset = 0, Required = false)]
		public NoNested3PartyIDs[]? Nested3PartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested3PartyIDs is not null && Nested3PartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(948, Nested3PartyIDs.Length);
				for (int i = 0; i < Nested3PartyIDs.Length; i++)
				{
					((IFixEncoder)Nested3PartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested3PartyIDs") is IMessageView viewNoNested3PartyIDs)
			{
				var count = viewNoNested3PartyIDs.GroupCount();
				Nested3PartyIDs = new NoNested3PartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested3PartyIDs[i] = new();
					((IFixParser)Nested3PartyIDs[i]).Parse(viewNoNested3PartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested3PartyIDs":
				{
					value = Nested3PartyIDs;
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
			Nested3PartyIDs = null;
		}
	}
}
