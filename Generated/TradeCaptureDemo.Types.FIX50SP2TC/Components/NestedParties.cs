using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NestedParties : IFixComponent
	{
		public sealed partial class NoNestedPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 524, Type = TagType.String, Offset = 0, Required = false)]
			public string? NestedPartyID {get; set;}
			
			[TagDetails(Tag = 525, Type = TagType.String, Offset = 1, Required = false)]
			public string? NestedPartyIDSource {get; set;}
			
			[TagDetails(Tag = 538, Type = TagType.Int, Offset = 2, Required = false)]
			public int? NestedPartyRole {get; set;}
			
			[TagDetails(Tag = 2384, Type = TagType.Int, Offset = 3, Required = false)]
			public int? NestedPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public NstdPtysSubGrp? NstdPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NestedPartyID is not null) writer.WriteString(524, NestedPartyID);
				if (NestedPartyIDSource is not null) writer.WriteString(525, NestedPartyIDSource);
				if (NestedPartyRole is not null) writer.WriteWholeNumber(538, NestedPartyRole.Value);
				if (NestedPartyRoleQualifier is not null) writer.WriteWholeNumber(2384, NestedPartyRoleQualifier.Value);
				if (NstdPtysSubGrp is not null) ((IFixEncoder)NstdPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NestedPartyID = view.GetString(524);
				NestedPartyIDSource = view.GetString(525);
				NestedPartyRole = view.GetInt32(538);
				NestedPartyRoleQualifier = view.GetInt32(2384);
				if (view.GetView("NstdPtysSubGrp") is IMessageView viewNstdPtysSubGrp)
				{
					NstdPtysSubGrp = new();
					((IFixParser)NstdPtysSubGrp).Parse(viewNstdPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NestedPartyID":
					{
						value = NestedPartyID;
						break;
					}
					case "NestedPartyIDSource":
					{
						value = NestedPartyIDSource;
						break;
					}
					case "NestedPartyRole":
					{
						value = NestedPartyRole;
						break;
					}
					case "NestedPartyRoleQualifier":
					{
						value = NestedPartyRoleQualifier;
						break;
					}
					case "NstdPtysSubGrp":
					{
						value = NstdPtysSubGrp;
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
				NestedPartyID = null;
				NestedPartyIDSource = null;
				NestedPartyRole = null;
				NestedPartyRoleQualifier = null;
				((IFixReset?)NstdPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 539, Offset = 0, Required = false)]
		public NoNestedPartyIDs[]? NestedPartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (NestedPartyIDs is not null && NestedPartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(539, NestedPartyIDs.Length);
				for (int i = 0; i < NestedPartyIDs.Length; i++)
				{
					((IFixEncoder)NestedPartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNestedPartyIDs") is IMessageView viewNoNestedPartyIDs)
			{
				var count = viewNoNestedPartyIDs.GroupCount();
				NestedPartyIDs = new NoNestedPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					NestedPartyIDs[i] = new();
					((IFixParser)NestedPartyIDs[i]).Parse(viewNoNestedPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNestedPartyIDs":
				{
					value = NestedPartyIDs;
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
			NestedPartyIDs = null;
		}
	}
}
