using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionParties : IFixComponent
	{
		public sealed partial class NoProvisionPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 40175, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionPartyID {get; set;}
			
			[TagDetails(Tag = 40176, Type = TagType.String, Offset = 1, Required = false)]
			public string? ProvisionPartyIDSource {get; set;}
			
			[TagDetails(Tag = 40177, Type = TagType.Int, Offset = 2, Required = false)]
			public int? ProvisionPartyRole {get; set;}
			
			[TagDetails(Tag = 2385, Type = TagType.Int, Offset = 3, Required = false)]
			public int? ProvisionPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public ProvisionPtysSubGrp? ProvisionPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionPartyID is not null) writer.WriteString(40175, ProvisionPartyID);
				if (ProvisionPartyIDSource is not null) writer.WriteString(40176, ProvisionPartyIDSource);
				if (ProvisionPartyRole is not null) writer.WriteWholeNumber(40177, ProvisionPartyRole.Value);
				if (ProvisionPartyRoleQualifier is not null) writer.WriteWholeNumber(2385, ProvisionPartyRoleQualifier.Value);
				if (ProvisionPtysSubGrp is not null) ((IFixEncoder)ProvisionPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionPartyID = view.GetString(40175);
				ProvisionPartyIDSource = view.GetString(40176);
				ProvisionPartyRole = view.GetInt32(40177);
				ProvisionPartyRoleQualifier = view.GetInt32(2385);
				if (view.GetView("ProvisionPtysSubGrp") is IMessageView viewProvisionPtysSubGrp)
				{
					ProvisionPtysSubGrp = new();
					((IFixParser)ProvisionPtysSubGrp).Parse(viewProvisionPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionPartyID":
					{
						value = ProvisionPartyID;
						break;
					}
					case "ProvisionPartyIDSource":
					{
						value = ProvisionPartyIDSource;
						break;
					}
					case "ProvisionPartyRole":
					{
						value = ProvisionPartyRole;
						break;
					}
					case "ProvisionPartyRoleQualifier":
					{
						value = ProvisionPartyRoleQualifier;
						break;
					}
					case "ProvisionPtysSubGrp":
					{
						value = ProvisionPtysSubGrp;
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
				ProvisionPartyID = null;
				ProvisionPartyIDSource = null;
				ProvisionPartyRole = null;
				ProvisionPartyRoleQualifier = null;
				((IFixReset?)ProvisionPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 40174, Offset = 0, Required = false)]
		public NoProvisionPartyIDs[]? ProvisionPartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionPartyIDs is not null && ProvisionPartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(40174, ProvisionPartyIDs.Length);
				for (int i = 0; i < ProvisionPartyIDs.Length; i++)
				{
					((IFixEncoder)ProvisionPartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionPartyIDs") is IMessageView viewNoProvisionPartyIDs)
			{
				var count = viewNoProvisionPartyIDs.GroupCount();
				ProvisionPartyIDs = new NoProvisionPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionPartyIDs[i] = new();
					((IFixParser)ProvisionPartyIDs[i]).Parse(viewNoProvisionPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionPartyIDs":
				{
					value = ProvisionPartyIDs;
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
			ProvisionPartyIDs = null;
		}
	}
}
