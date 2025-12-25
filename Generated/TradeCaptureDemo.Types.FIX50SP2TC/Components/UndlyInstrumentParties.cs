using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UndlyInstrumentParties : IFixComponent
	{
		public sealed partial class NoUndlyInstrumentParties : IFixGroup
		{
			[TagDetails(Tag = 1059, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingInstrumentPartyID {get; set;}
			
			[TagDetails(Tag = 1060, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingInstrumentPartyIDSource {get; set;}
			
			[TagDetails(Tag = 1061, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingInstrumentPartyRole {get; set;}
			
			[TagDetails(Tag = 2391, Type = TagType.Int, Offset = 3, Required = false)]
			public int? UnderlyingInstrumentPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public UndlyInstrumentPtysSubGrp? UndlyInstrumentPtysSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingInstrumentPartyID is not null) writer.WriteString(1059, UnderlyingInstrumentPartyID);
				if (UnderlyingInstrumentPartyIDSource is not null) writer.WriteString(1060, UnderlyingInstrumentPartyIDSource);
				if (UnderlyingInstrumentPartyRole is not null) writer.WriteWholeNumber(1061, UnderlyingInstrumentPartyRole.Value);
				if (UnderlyingInstrumentPartyRoleQualifier is not null) writer.WriteWholeNumber(2391, UnderlyingInstrumentPartyRoleQualifier.Value);
				if (UndlyInstrumentPtysSubGrp is not null) ((IFixEncoder)UndlyInstrumentPtysSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingInstrumentPartyID = view.GetString(1059);
				UnderlyingInstrumentPartyIDSource = view.GetString(1060);
				UnderlyingInstrumentPartyRole = view.GetInt32(1061);
				UnderlyingInstrumentPartyRoleQualifier = view.GetInt32(2391);
				if (view.GetView("UndlyInstrumentPtysSubGrp") is IMessageView viewUndlyInstrumentPtysSubGrp)
				{
					UndlyInstrumentPtysSubGrp = new();
					((IFixParser)UndlyInstrumentPtysSubGrp).Parse(viewUndlyInstrumentPtysSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingInstrumentPartyID":
					{
						value = UnderlyingInstrumentPartyID;
						break;
					}
					case "UnderlyingInstrumentPartyIDSource":
					{
						value = UnderlyingInstrumentPartyIDSource;
						break;
					}
					case "UnderlyingInstrumentPartyRole":
					{
						value = UnderlyingInstrumentPartyRole;
						break;
					}
					case "UnderlyingInstrumentPartyRoleQualifier":
					{
						value = UnderlyingInstrumentPartyRoleQualifier;
						break;
					}
					case "UndlyInstrumentPtysSubGrp":
					{
						value = UndlyInstrumentPtysSubGrp;
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
				UnderlyingInstrumentPartyID = null;
				UnderlyingInstrumentPartyIDSource = null;
				UnderlyingInstrumentPartyRole = null;
				UnderlyingInstrumentPartyRoleQualifier = null;
				((IFixReset?)UndlyInstrumentPtysSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1058, Offset = 0, Required = false)]
		public NoUndlyInstrumentParties[]? UndlyInstrumentPartiesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UndlyInstrumentPartiesItems is not null && UndlyInstrumentPartiesItems.Length != 0)
			{
				writer.WriteWholeNumber(1058, UndlyInstrumentPartiesItems.Length);
				for (int i = 0; i < UndlyInstrumentPartiesItems.Length; i++)
				{
					((IFixEncoder)UndlyInstrumentPartiesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUndlyInstrumentParties") is IMessageView viewNoUndlyInstrumentParties)
			{
				var count = viewNoUndlyInstrumentParties.GroupCount();
				UndlyInstrumentPartiesItems = new NoUndlyInstrumentParties[count];
				for (int i = 0; i < count; i++)
				{
					UndlyInstrumentPartiesItems[i] = new();
					((IFixParser)UndlyInstrumentPartiesItems[i]).Parse(viewNoUndlyInstrumentParties.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUndlyInstrumentParties":
				{
					value = UndlyInstrumentPartiesItems;
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
			UndlyInstrumentPartiesItems = null;
		}
	}
}
