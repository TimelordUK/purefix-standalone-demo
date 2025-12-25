using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class Parties : IFixComponent
	{
		public sealed partial class NoPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 448, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartyID {get; set;}
			
			[TagDetails(Tag = 447, Type = TagType.String, Offset = 1, Required = false)]
			public string? PartyIDSource {get; set;}
			
			[TagDetails(Tag = 452, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PartyRole {get; set;}
			
			[TagDetails(Tag = 2376, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public PtysSubGrp? PtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyID is not null) writer.WriteString(448, PartyID);
				if (PartyIDSource is not null) writer.WriteString(447, PartyIDSource);
				if (PartyRole is not null) writer.WriteWholeNumber(452, PartyRole.Value);
				if (PartyRoleQualifier is not null) writer.WriteWholeNumber(2376, PartyRoleQualifier.Value);
				if (PtysSubGrp is not null) ((IFixEncoder)PtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyID = view.GetString(448);
				PartyIDSource = view.GetString(447);
				PartyRole = view.GetInt32(452);
				PartyRoleQualifier = view.GetInt32(2376);
				if (view.GetView("PtysSubGrp") is IMessageView viewPtysSubGrp)
				{
					PtysSubGrp = new();
					((IFixParser)PtysSubGrp).Parse(viewPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyID":
					{
						value = PartyID;
						break;
					}
					case "PartyIDSource":
					{
						value = PartyIDSource;
						break;
					}
					case "PartyRole":
					{
						value = PartyRole;
						break;
					}
					case "PartyRoleQualifier":
					{
						value = PartyRoleQualifier;
						break;
					}
					case "PtysSubGrp":
					{
						value = PtysSubGrp;
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
				PartyID = null;
				PartyIDSource = null;
				PartyRole = null;
				PartyRoleQualifier = null;
				((IFixReset?)PtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 453, Offset = 0, Required = false)]
		public NoPartyIDs[]? PartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyIDs is not null && PartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(453, PartyIDs.Length);
				for (int i = 0; i < PartyIDs.Length; i++)
				{
					((IFixEncoder)PartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyIDs") is IMessageView viewNoPartyIDs)
			{
				var count = viewNoPartyIDs.GroupCount();
				PartyIDs = new NoPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					PartyIDs[i] = new();
					((IFixParser)PartyIDs[i]).Parse(viewNoPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyIDs":
				{
					value = PartyIDs;
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
			PartyIDs = null;
		}
	}
}
