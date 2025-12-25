using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DerivativeInstrumentParties : IFixComponent
	{
		public sealed partial class NoDerivativeInstrumentParties : IFixGroup
		{
			[TagDetails(Tag = 1293, Type = TagType.String, Offset = 0, Required = false)]
			public string? DerivativeInstrumentPartyID {get; set;}
			
			[TagDetails(Tag = 1294, Type = TagType.String, Offset = 1, Required = false)]
			public string? DerivativeInstrumentPartyIDSource {get; set;}
			
			[TagDetails(Tag = 1295, Type = TagType.Int, Offset = 2, Required = false)]
			public int? DerivativeInstrumentPartyRole {get; set;}
			
			[TagDetails(Tag = 2377, Type = TagType.Int, Offset = 3, Required = false)]
			public int? DerivativeInstrumentPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public DerivativeInstrumentPartySubIDsGrp? DerivativeInstrumentPartySubIDsGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DerivativeInstrumentPartyID is not null) writer.WriteString(1293, DerivativeInstrumentPartyID);
				if (DerivativeInstrumentPartyIDSource is not null) writer.WriteString(1294, DerivativeInstrumentPartyIDSource);
				if (DerivativeInstrumentPartyRole is not null) writer.WriteWholeNumber(1295, DerivativeInstrumentPartyRole.Value);
				if (DerivativeInstrumentPartyRoleQualifier is not null) writer.WriteWholeNumber(2377, DerivativeInstrumentPartyRoleQualifier.Value);
				if (DerivativeInstrumentPartySubIDsGrp is not null) ((IFixEncoder)DerivativeInstrumentPartySubIDsGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DerivativeInstrumentPartyID = view.GetString(1293);
				DerivativeInstrumentPartyIDSource = view.GetString(1294);
				DerivativeInstrumentPartyRole = view.GetInt32(1295);
				DerivativeInstrumentPartyRoleQualifier = view.GetInt32(2377);
				if (view.GetView("DerivativeInstrumentPartySubIDsGrp") is IMessageView viewDerivativeInstrumentPartySubIDsGrp)
				{
					DerivativeInstrumentPartySubIDsGrp = new();
					((IFixParser)DerivativeInstrumentPartySubIDsGrp).Parse(viewDerivativeInstrumentPartySubIDsGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DerivativeInstrumentPartyID":
					{
						value = DerivativeInstrumentPartyID;
						break;
					}
					case "DerivativeInstrumentPartyIDSource":
					{
						value = DerivativeInstrumentPartyIDSource;
						break;
					}
					case "DerivativeInstrumentPartyRole":
					{
						value = DerivativeInstrumentPartyRole;
						break;
					}
					case "DerivativeInstrumentPartyRoleQualifier":
					{
						value = DerivativeInstrumentPartyRoleQualifier;
						break;
					}
					case "DerivativeInstrumentPartySubIDsGrp":
					{
						value = DerivativeInstrumentPartySubIDsGrp;
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
				DerivativeInstrumentPartyID = null;
				DerivativeInstrumentPartyIDSource = null;
				DerivativeInstrumentPartyRole = null;
				DerivativeInstrumentPartyRoleQualifier = null;
				((IFixReset?)DerivativeInstrumentPartySubIDsGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1292, Offset = 0, Required = false)]
		public NoDerivativeInstrumentParties[]? DerivativeInstrumentPartiesItems {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DerivativeInstrumentPartiesItems is not null && DerivativeInstrumentPartiesItems.Length != 0)
			{
				writer.WriteWholeNumber(1292, DerivativeInstrumentPartiesItems.Length);
				for (int i = 0; i < DerivativeInstrumentPartiesItems.Length; i++)
				{
					((IFixEncoder)DerivativeInstrumentPartiesItems[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDerivativeInstrumentParties") is IMessageView viewNoDerivativeInstrumentParties)
			{
				var count = viewNoDerivativeInstrumentParties.GroupCount();
				DerivativeInstrumentPartiesItems = new NoDerivativeInstrumentParties[count];
				for (int i = 0; i < count; i++)
				{
					DerivativeInstrumentPartiesItems[i] = new();
					((IFixParser)DerivativeInstrumentPartiesItems[i]).Parse(viewNoDerivativeInstrumentParties.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDerivativeInstrumentParties":
				{
					value = DerivativeInstrumentPartiesItems;
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
			DerivativeInstrumentPartiesItems = null;
		}
	}
}
