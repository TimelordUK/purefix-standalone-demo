using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailGrp : IFixComponent
	{
		public sealed partial class NoPartyDetails : IFixGroup
		{
			[TagDetails(Tag = 1691, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartyDetailID {get; set;}
			
			[TagDetails(Tag = 1692, Type = TagType.String, Offset = 1, Required = false)]
			public string? PartyDetailIDSource {get; set;}
			
			[TagDetails(Tag = 1693, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PartyDetailRole {get; set;}
			
			[TagDetails(Tag = 1674, Type = TagType.Int, Offset = 3, Required = false)]
			public int? PartyDetailRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public PartyDetailSubGrp? PartyDetailSubGrp {get; set;}
			
			[Component(Offset = 5, Required = false)]
			public PartyDetailAltIDGrp? PartyDetailAltIDGrp {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public RelatedPartyDetailGrp? RelatedPartyDetailGrp {get; set;}
			
			[TagDetails(Tag = 1672, Type = TagType.Int, Offset = 7, Required = false)]
			public int? PartyDetailStatus {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyDetailID is not null) writer.WriteString(1691, PartyDetailID);
				if (PartyDetailIDSource is not null) writer.WriteString(1692, PartyDetailIDSource);
				if (PartyDetailRole is not null) writer.WriteWholeNumber(1693, PartyDetailRole.Value);
				if (PartyDetailRoleQualifier is not null) writer.WriteWholeNumber(1674, PartyDetailRoleQualifier.Value);
				if (PartyDetailSubGrp is not null) ((IFixEncoder)PartyDetailSubGrp).Encode(writer);
				if (PartyDetailAltIDGrp is not null) ((IFixEncoder)PartyDetailAltIDGrp).Encode(writer);
				if (RelatedPartyDetailGrp is not null) ((IFixEncoder)RelatedPartyDetailGrp).Encode(writer);
				if (PartyDetailStatus is not null) writer.WriteWholeNumber(1672, PartyDetailStatus.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyDetailID = view.GetString(1691);
				PartyDetailIDSource = view.GetString(1692);
				PartyDetailRole = view.GetInt32(1693);
				PartyDetailRoleQualifier = view.GetInt32(1674);
				if (view.GetView("PartyDetailSubGrp") is IMessageView viewPartyDetailSubGrp)
				{
					PartyDetailSubGrp = new();
					((IFixParser)PartyDetailSubGrp).Parse(viewPartyDetailSubGrp);
				}
				if (view.GetView("PartyDetailAltIDGrp") is IMessageView viewPartyDetailAltIDGrp)
				{
					PartyDetailAltIDGrp = new();
					((IFixParser)PartyDetailAltIDGrp).Parse(viewPartyDetailAltIDGrp);
				}
				if (view.GetView("RelatedPartyDetailGrp") is IMessageView viewRelatedPartyDetailGrp)
				{
					RelatedPartyDetailGrp = new();
					((IFixParser)RelatedPartyDetailGrp).Parse(viewRelatedPartyDetailGrp);
				}
				PartyDetailStatus = view.GetInt32(1672);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyDetailID":
					{
						value = PartyDetailID;
						break;
					}
					case "PartyDetailIDSource":
					{
						value = PartyDetailIDSource;
						break;
					}
					case "PartyDetailRole":
					{
						value = PartyDetailRole;
						break;
					}
					case "PartyDetailRoleQualifier":
					{
						value = PartyDetailRoleQualifier;
						break;
					}
					case "PartyDetailSubGrp":
					{
						value = PartyDetailSubGrp;
						break;
					}
					case "PartyDetailAltIDGrp":
					{
						value = PartyDetailAltIDGrp;
						break;
					}
					case "RelatedPartyDetailGrp":
					{
						value = RelatedPartyDetailGrp;
						break;
					}
					case "PartyDetailStatus":
					{
						value = PartyDetailStatus;
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
				PartyDetailID = null;
				PartyDetailIDSource = null;
				PartyDetailRole = null;
				PartyDetailRoleQualifier = null;
				((IFixReset?)PartyDetailSubGrp)?.Reset();
				((IFixReset?)PartyDetailAltIDGrp)?.Reset();
				((IFixReset?)RelatedPartyDetailGrp)?.Reset();
				PartyDetailStatus = null;
			}
		}
		[Group(NoOfTag = 1671, Offset = 0, Required = false)]
		public NoPartyDetails[]? PartyDetails {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyDetails is not null && PartyDetails.Length != 0)
			{
				writer.WriteWholeNumber(1671, PartyDetails.Length);
				for (int i = 0; i < PartyDetails.Length; i++)
				{
					((IFixEncoder)PartyDetails[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyDetails") is IMessageView viewNoPartyDetails)
			{
				var count = viewNoPartyDetails.GroupCount();
				PartyDetails = new NoPartyDetails[count];
				for (int i = 0; i < count; i++)
				{
					PartyDetails[i] = new();
					((IFixParser)PartyDetails[i]).Parse(viewNoPartyDetails.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyDetails":
				{
					value = PartyDetails;
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
			PartyDetails = null;
		}
	}
}
