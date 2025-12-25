using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegInstrumentParties : IFixComponent
	{
		public sealed partial class NoLegInstrumentParties : IFixGroup
		{
			[TagDetails(Tag = 2255, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegInstrumentPartyID {get; set;}
			
			[TagDetails(Tag = 2256, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegInstrumentPartyIDSource {get; set;}
			
			[TagDetails(Tag = 2257, Type = TagType.Int, Offset = 2, Required = false)]
			public int? LegInstrumentPartyRole {get; set;}
			
			[TagDetails(Tag = 2379, Type = TagType.Int, Offset = 3, Required = false)]
			public int? LegInstrumentPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public LegInstrumentPtysSubGrp? LegInstrumentPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegInstrumentPartyID is not null) writer.WriteString(2255, LegInstrumentPartyID);
				if (LegInstrumentPartyIDSource is not null) writer.WriteString(2256, LegInstrumentPartyIDSource);
				if (LegInstrumentPartyRole is not null) writer.WriteWholeNumber(2257, LegInstrumentPartyRole.Value);
				if (LegInstrumentPartyRoleQualifier is not null) writer.WriteWholeNumber(2379, LegInstrumentPartyRoleQualifier.Value);
				if (LegInstrumentPtysSubGrp is not null) ((IFixEncoder)LegInstrumentPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegInstrumentPartyID = view.GetString(2255);
				LegInstrumentPartyIDSource = view.GetString(2256);
				LegInstrumentPartyRole = view.GetInt32(2257);
				LegInstrumentPartyRoleQualifier = view.GetInt32(2379);
				if (view.GetView("LegInstrumentPtysSubGrp") is IMessageView viewLegInstrumentPtysSubGrp)
				{
					LegInstrumentPtysSubGrp = new();
					((IFixParser)LegInstrumentPtysSubGrp).Parse(viewLegInstrumentPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegInstrumentPartyID":
					{
						value = LegInstrumentPartyID;
						break;
					}
					case "LegInstrumentPartyIDSource":
					{
						value = LegInstrumentPartyIDSource;
						break;
					}
					case "LegInstrumentPartyRole":
					{
						value = LegInstrumentPartyRole;
						break;
					}
					case "LegInstrumentPartyRoleQualifier":
					{
						value = LegInstrumentPartyRoleQualifier;
						break;
					}
					case "LegInstrumentPtysSubGrp":
					{
						value = LegInstrumentPtysSubGrp;
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
				LegInstrumentPartyID = null;
				LegInstrumentPartyIDSource = null;
				LegInstrumentPartyRole = null;
				LegInstrumentPartyRoleQualifier = null;
				((IFixReset?)LegInstrumentPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 2254, Offset = 0, Required = false)]
		public NoLegInstrumentParties[]? LegInstrumentPartiesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegInstrumentPartiesItems is not null && LegInstrumentPartiesItems.Length != 0)
			{
				writer.WriteWholeNumber(2254, LegInstrumentPartiesItems.Length);
				for (int i = 0; i < LegInstrumentPartiesItems.Length; i++)
				{
					((IFixEncoder)LegInstrumentPartiesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegInstrumentParties") is IMessageView viewNoLegInstrumentParties)
			{
				var count = viewNoLegInstrumentParties.GroupCount();
				LegInstrumentPartiesItems = new NoLegInstrumentParties[count];
				for (int i = 0; i < count; i++)
				{
					LegInstrumentPartiesItems[i] = new();
					((IFixParser)LegInstrumentPartiesItems[i]).Parse(viewNoLegInstrumentParties.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegInstrumentParties":
				{
					value = LegInstrumentPartiesItems;
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
			LegInstrumentPartiesItems = null;
		}
	}
}
