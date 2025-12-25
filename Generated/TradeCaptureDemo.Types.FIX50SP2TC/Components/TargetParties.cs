using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TargetParties : IFixComponent
	{
		public sealed partial class NoTargetPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 1462, Type = TagType.String, Offset = 0, Required = false)]
			public string? TargetPartyID {get; set;}
			
			[TagDetails(Tag = 1463, Type = TagType.String, Offset = 1, Required = false)]
			public string? TargetPartyIDSource {get; set;}
			
			[TagDetails(Tag = 1464, Type = TagType.Int, Offset = 2, Required = false)]
			public int? TargetPartyRole {get; set;}
			
			[TagDetails(Tag = 1818, Type = TagType.Int, Offset = 3, Required = false)]
			public int? TargetPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public TargetPtysSubGrp? TargetPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TargetPartyID is not null) writer.WriteString(1462, TargetPartyID);
				if (TargetPartyIDSource is not null) writer.WriteString(1463, TargetPartyIDSource);
				if (TargetPartyRole is not null) writer.WriteWholeNumber(1464, TargetPartyRole.Value);
				if (TargetPartyRoleQualifier is not null) writer.WriteWholeNumber(1818, TargetPartyRoleQualifier.Value);
				if (TargetPtysSubGrp is not null) ((IFixEncoder)TargetPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TargetPartyID = view.GetString(1462);
				TargetPartyIDSource = view.GetString(1463);
				TargetPartyRole = view.GetInt32(1464);
				TargetPartyRoleQualifier = view.GetInt32(1818);
				if (view.GetView("TargetPtysSubGrp") is IMessageView viewTargetPtysSubGrp)
				{
					TargetPtysSubGrp = new();
					((IFixParser)TargetPtysSubGrp).Parse(viewTargetPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TargetPartyID":
					{
						value = TargetPartyID;
						break;
					}
					case "TargetPartyIDSource":
					{
						value = TargetPartyIDSource;
						break;
					}
					case "TargetPartyRole":
					{
						value = TargetPartyRole;
						break;
					}
					case "TargetPartyRoleQualifier":
					{
						value = TargetPartyRoleQualifier;
						break;
					}
					case "TargetPtysSubGrp":
					{
						value = TargetPtysSubGrp;
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
				TargetPartyID = null;
				TargetPartyIDSource = null;
				TargetPartyRole = null;
				TargetPartyRoleQualifier = null;
				((IFixReset?)TargetPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1461, Offset = 0, Required = false)]
		public NoTargetPartyIDs[]? TargetPartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (TargetPartyIDs is not null && TargetPartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(1461, TargetPartyIDs.Length);
				for (int i = 0; i < TargetPartyIDs.Length; i++)
				{
					((IFixEncoder)TargetPartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoTargetPartyIDs") is IMessageView viewNoTargetPartyIDs)
			{
				var count = viewNoTargetPartyIDs.GroupCount();
				TargetPartyIDs = new NoTargetPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					TargetPartyIDs[i] = new();
					((IFixParser)TargetPartyIDs[i]).Parse(viewNoTargetPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoTargetPartyIDs":
				{
					value = TargetPartyIDs;
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
			TargetPartyIDs = null;
		}
	}
}
