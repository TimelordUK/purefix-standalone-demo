using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailAltIDGrp : IFixComponent
	{
		public sealed partial class NoPartyDetailAltID : IFixGroup
		{
			[TagDetails(Tag = 1517, Type = TagType.String, Offset = 0, Required = false)]
			public string? PartyDetailAltID {get; set;}
			
			[TagDetails(Tag = 1518, Type = TagType.String, Offset = 1, Required = false)]
			public string? PartyDetailAltIDSource {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public PartyDetailAltSubGrp? PartyDetailAltSubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyDetailAltID is not null) writer.WriteString(1517, PartyDetailAltID);
				if (PartyDetailAltIDSource is not null) writer.WriteString(1518, PartyDetailAltIDSource);
				if (PartyDetailAltSubGrp is not null) ((IFixEncoder)PartyDetailAltSubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyDetailAltID = view.GetString(1517);
				PartyDetailAltIDSource = view.GetString(1518);
				if (view.GetView("PartyDetailAltSubGrp") is IMessageView viewPartyDetailAltSubGrp)
				{
					PartyDetailAltSubGrp = new();
					((IFixParser)PartyDetailAltSubGrp).Parse(viewPartyDetailAltSubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyDetailAltID":
					{
						value = PartyDetailAltID;
						break;
					}
					case "PartyDetailAltIDSource":
					{
						value = PartyDetailAltIDSource;
						break;
					}
					case "PartyDetailAltSubGrp":
					{
						value = PartyDetailAltSubGrp;
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
				PartyDetailAltID = null;
				PartyDetailAltIDSource = null;
				((IFixReset?)PartyDetailAltSubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1516, Offset = 0, Required = false)]
		public NoPartyDetailAltID[]? PartyDetailAltID {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyDetailAltID is not null && PartyDetailAltID.Length != 0)
			{
				writer.WriteWholeNumber(1516, PartyDetailAltID.Length);
				for (int i = 0; i < PartyDetailAltID.Length; i++)
				{
					((IFixEncoder)PartyDetailAltID[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyDetailAltID") is IMessageView viewNoPartyDetailAltID)
			{
				var count = viewNoPartyDetailAltID.GroupCount();
				PartyDetailAltID = new NoPartyDetailAltID[count];
				for (int i = 0; i < count; i++)
				{
					PartyDetailAltID[i] = new();
					((IFixParser)PartyDetailAltID[i]).Parse(viewNoPartyDetailAltID.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyDetailAltID":
				{
					value = PartyDetailAltID;
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
			PartyDetailAltID = null;
		}
	}
}
