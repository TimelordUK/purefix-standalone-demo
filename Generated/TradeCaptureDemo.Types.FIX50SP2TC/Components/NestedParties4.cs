using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NestedParties4 : IFixComponent
	{
		public sealed partial class NoNested4PartyIDs : IFixGroup
		{
			[TagDetails(Tag = 1415, Type = TagType.String, Offset = 0, Required = false)]
			public string? Nested4PartyID {get; set;}
			
			[TagDetails(Tag = 1416, Type = TagType.String, Offset = 1, Required = false)]
			public string? Nested4PartyIDSource {get; set;}
			
			[TagDetails(Tag = 1417, Type = TagType.Int, Offset = 2, Required = false)]
			public int? Nested4PartyRole {get; set;}
			
			[TagDetails(Tag = 2383, Type = TagType.Int, Offset = 3, Required = false)]
			public int? Nested4PartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public NstdPtys4SubGrp? NstdPtys4SubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Nested4PartyID is not null) writer.WriteString(1415, Nested4PartyID);
				if (Nested4PartyIDSource is not null) writer.WriteString(1416, Nested4PartyIDSource);
				if (Nested4PartyRole is not null) writer.WriteWholeNumber(1417, Nested4PartyRole.Value);
				if (Nested4PartyRoleQualifier is not null) writer.WriteWholeNumber(2383, Nested4PartyRoleQualifier.Value);
				if (NstdPtys4SubGrp is not null) ((IFixEncoder)NstdPtys4SubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Nested4PartyID = view.GetString(1415);
				Nested4PartyIDSource = view.GetString(1416);
				Nested4PartyRole = view.GetInt32(1417);
				Nested4PartyRoleQualifier = view.GetInt32(2383);
				if (view.GetView("NstdPtys4SubGrp") is IMessageView viewNstdPtys4SubGrp)
				{
					NstdPtys4SubGrp = new();
					((IFixParser)NstdPtys4SubGrp).Parse(viewNstdPtys4SubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Nested4PartyID":
					{
						value = Nested4PartyID;
						break;
					}
					case "Nested4PartyIDSource":
					{
						value = Nested4PartyIDSource;
						break;
					}
					case "Nested4PartyRole":
					{
						value = Nested4PartyRole;
						break;
					}
					case "Nested4PartyRoleQualifier":
					{
						value = Nested4PartyRoleQualifier;
						break;
					}
					case "NstdPtys4SubGrp":
					{
						value = NstdPtys4SubGrp;
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
				Nested4PartyID = null;
				Nested4PartyIDSource = null;
				Nested4PartyRole = null;
				Nested4PartyRoleQualifier = null;
				((IFixReset?)NstdPtys4SubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1414, Offset = 0, Required = false)]
		public NoNested4PartyIDs[]? Nested4PartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Nested4PartyIDs is not null && Nested4PartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(1414, Nested4PartyIDs.Length);
				for (int i = 0; i < Nested4PartyIDs.Length; i++)
				{
					((IFixEncoder)Nested4PartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNested4PartyIDs") is IMessageView viewNoNested4PartyIDs)
			{
				var count = viewNoNested4PartyIDs.GroupCount();
				Nested4PartyIDs = new NoNested4PartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					Nested4PartyIDs[i] = new();
					((IFixParser)Nested4PartyIDs[i]).Parse(viewNoNested4PartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNested4PartyIDs":
				{
					value = Nested4PartyIDs;
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
			Nested4PartyIDs = null;
		}
	}
}
