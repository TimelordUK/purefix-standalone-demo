using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyRelationshipGrp : IFixComponent
	{
		public sealed partial class NoPartyRelationships : IFixGroup
		{
			[TagDetails(Tag = 1515, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PartyRelationship {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyRelationship is not null) writer.WriteWholeNumber(1515, PartyRelationship.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PartyRelationship = view.GetInt32(1515);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PartyRelationship":
					{
						value = PartyRelationship;
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
				PartyRelationship = null;
			}
		}
		[Group(NoOfTag = 1514, Offset = 0, Required = false)]
		public NoPartyRelationships[]? PartyRelationships {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyRelationships is not null && PartyRelationships.Length != 0)
			{
				writer.WriteWholeNumber(1514, PartyRelationships.Length);
				for (int i = 0; i < PartyRelationships.Length; i++)
				{
					((IFixEncoder)PartyRelationships[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyRelationships") is IMessageView viewNoPartyRelationships)
			{
				var count = viewNoPartyRelationships.GroupCount();
				PartyRelationships = new NoPartyRelationships[count];
				for (int i = 0; i < count; i++)
				{
					PartyRelationships[i] = new();
					((IFixParser)PartyRelationships[i]).Parse(viewNoPartyRelationships.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyRelationships":
				{
					value = PartyRelationships;
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
			PartyRelationships = null;
		}
	}
}
