using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class InstrumentParties : IFixComponent
	{
		public sealed partial class NoInstrumentParties : IFixGroup
		{
			[TagDetails(Tag = 1019, Type = TagType.String, Offset = 0, Required = false)]
			public string? InstrumentPartyID {get; set;}
			
			[TagDetails(Tag = 1050, Type = TagType.String, Offset = 1, Required = false)]
			public string? InstrumentPartyIDSource {get; set;}
			
			[TagDetails(Tag = 1051, Type = TagType.Int, Offset = 2, Required = false)]
			public int? InstrumentPartyRole {get; set;}
			
			[TagDetails(Tag = 2378, Type = TagType.Int, Offset = 3, Required = false)]
			public int? InstrumentPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public InstrumentPtysSubGrp? InstrumentPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (InstrumentPartyID is not null) writer.WriteString(1019, InstrumentPartyID);
				if (InstrumentPartyIDSource is not null) writer.WriteString(1050, InstrumentPartyIDSource);
				if (InstrumentPartyRole is not null) writer.WriteWholeNumber(1051, InstrumentPartyRole.Value);
				if (InstrumentPartyRoleQualifier is not null) writer.WriteWholeNumber(2378, InstrumentPartyRoleQualifier.Value);
				if (InstrumentPtysSubGrp is not null) ((IFixEncoder)InstrumentPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				InstrumentPartyID = view.GetString(1019);
				InstrumentPartyIDSource = view.GetString(1050);
				InstrumentPartyRole = view.GetInt32(1051);
				InstrumentPartyRoleQualifier = view.GetInt32(2378);
				if (view.GetView("InstrumentPtysSubGrp") is IMessageView viewInstrumentPtysSubGrp)
				{
					InstrumentPtysSubGrp = new();
					((IFixParser)InstrumentPtysSubGrp).Parse(viewInstrumentPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "InstrumentPartyID":
					{
						value = InstrumentPartyID;
						break;
					}
					case "InstrumentPartyIDSource":
					{
						value = InstrumentPartyIDSource;
						break;
					}
					case "InstrumentPartyRole":
					{
						value = InstrumentPartyRole;
						break;
					}
					case "InstrumentPartyRoleQualifier":
					{
						value = InstrumentPartyRoleQualifier;
						break;
					}
					case "InstrumentPtysSubGrp":
					{
						value = InstrumentPtysSubGrp;
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
				InstrumentPartyID = null;
				InstrumentPartyIDSource = null;
				InstrumentPartyRole = null;
				InstrumentPartyRoleQualifier = null;
				((IFixReset?)InstrumentPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1018, Offset = 0, Required = false)]
		public NoInstrumentParties[]? InstrumentPartiesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (InstrumentPartiesItems is not null && InstrumentPartiesItems.Length != 0)
			{
				writer.WriteWholeNumber(1018, InstrumentPartiesItems.Length);
				for (int i = 0; i < InstrumentPartiesItems.Length; i++)
				{
					((IFixEncoder)InstrumentPartiesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoInstrumentParties") is IMessageView viewNoInstrumentParties)
			{
				var count = viewNoInstrumentParties.GroupCount();
				InstrumentPartiesItems = new NoInstrumentParties[count];
				for (int i = 0; i < count; i++)
				{
					InstrumentPartiesItems[i] = new();
					((IFixParser)InstrumentPartiesItems[i]).Parse(viewNoInstrumentParties.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoInstrumentParties":
				{
					value = InstrumentPartiesItems;
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
			InstrumentPartiesItems = null;
		}
	}
}
