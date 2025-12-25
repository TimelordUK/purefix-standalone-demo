using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedPartyDetailGrp : IFixComponent
	{
		public sealed partial class NoRelatedPartyDetailID : IFixGroup
		{
			[TagDetails(Tag = 1563, Type = TagType.String, Offset = 0, Required = false)]
			public string? RelatedPartyDetailID {get; set;}
			
			[TagDetails(Tag = 1564, Type = TagType.String, Offset = 1, Required = false)]
			public string? RelatedPartyDetailIDSource {get; set;}
			
			[TagDetails(Tag = 1565, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RelatedPartyDetailRole {get; set;}
			
			[TagDetails(Tag = 1675, Type = TagType.Int, Offset = 3, Required = false)]
			public int? RelatedPartyDetailRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public RelatedPartyDetailSubGrp? RelatedPartyDetailSubGrp {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public RelatedPartyDetailAltIDGrp? RelatedPartyDetailAltIDGrp {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public PartyRelationshipGrp? PartyRelationshipGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedPartyDetailID is not null) writer.WriteString(1563, RelatedPartyDetailID);
				if (RelatedPartyDetailIDSource is not null) writer.WriteString(1564, RelatedPartyDetailIDSource);
				if (RelatedPartyDetailRole is not null) writer.WriteWholeNumber(1565, RelatedPartyDetailRole.Value);
				if (RelatedPartyDetailRoleQualifier is not null) writer.WriteWholeNumber(1675, RelatedPartyDetailRoleQualifier.Value);
				if (RelatedPartyDetailSubGrp is not null) ((IFixEncoder)RelatedPartyDetailSubGrp).Encode(writer);
				if (RelatedPartyDetailAltIDGrp is not null) ((IFixEncoder)RelatedPartyDetailAltIDGrp).Encode(writer);
				if (PartyRelationshipGrp is not null) ((IFixEncoder)PartyRelationshipGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedPartyDetailID = view.GetString(1563);
				RelatedPartyDetailIDSource = view.GetString(1564);
				RelatedPartyDetailRole = view.GetInt32(1565);
				RelatedPartyDetailRoleQualifier = view.GetInt32(1675);
				if (view.GetView("RelatedPartyDetailSubGrp") is IMessageView viewRelatedPartyDetailSubGrp)
				{
					RelatedPartyDetailSubGrp = new();
					((IFixParser)RelatedPartyDetailSubGrp).Parse(viewRelatedPartyDetailSubGrp);
				}
				if (view.GetView("RelatedPartyDetailAltIDGrp") is IMessageView viewRelatedPartyDetailAltIDGrp)
				{
					RelatedPartyDetailAltIDGrp = new();
					((IFixParser)RelatedPartyDetailAltIDGrp).Parse(viewRelatedPartyDetailAltIDGrp);
				}
				if (view.GetView("PartyRelationshipGrp") is IMessageView viewPartyRelationshipGrp)
				{
					PartyRelationshipGrp = new();
					((IFixParser)PartyRelationshipGrp).Parse(viewPartyRelationshipGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedPartyDetailID":
					{
						value = RelatedPartyDetailID;
						break;
					}
					case "RelatedPartyDetailIDSource":
					{
						value = RelatedPartyDetailIDSource;
						break;
					}
					case "RelatedPartyDetailRole":
					{
						value = RelatedPartyDetailRole;
						break;
					}
					case "RelatedPartyDetailRoleQualifier":
					{
						value = RelatedPartyDetailRoleQualifier;
						break;
					}
					case "RelatedPartyDetailSubGrp":
					{
						value = RelatedPartyDetailSubGrp;
						break;
					}
					case "RelatedPartyDetailAltIDGrp":
					{
						value = RelatedPartyDetailAltIDGrp;
						break;
					}
					case "PartyRelationshipGrp":
					{
						value = PartyRelationshipGrp;
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
				RelatedPartyDetailID = null;
				RelatedPartyDetailIDSource = null;
				RelatedPartyDetailRole = null;
				RelatedPartyDetailRoleQualifier = null;
				((IFixReset?)RelatedPartyDetailSubGrp)?.Reset();
				((IFixReset?)RelatedPartyDetailAltIDGrp)?.Reset();
				((IFixReset?)PartyRelationshipGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1562, Offset = 0, Required = false)]
		public NoRelatedPartyDetailID[]? RelatedPartyDetailID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedPartyDetailID is not null && RelatedPartyDetailID.Length != 0)
			{
				writer.WriteWholeNumber(1562, RelatedPartyDetailID.Length);
				for (int i = 0; i < RelatedPartyDetailID.Length; i++)
				{
					((IFixEncoder)RelatedPartyDetailID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedPartyDetailID") is IMessageView viewNoRelatedPartyDetailID)
			{
				var count = viewNoRelatedPartyDetailID.GroupCount();
				RelatedPartyDetailID = new NoRelatedPartyDetailID[count];
				for (int i = 0; i < count; i++)
				{
					RelatedPartyDetailID[i] = new();
					((IFixParser)RelatedPartyDetailID[i]).Parse(viewNoRelatedPartyDetailID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedPartyDetailID":
				{
					value = RelatedPartyDetailID;
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
			RelatedPartyDetailID = null;
		}
	}
}
