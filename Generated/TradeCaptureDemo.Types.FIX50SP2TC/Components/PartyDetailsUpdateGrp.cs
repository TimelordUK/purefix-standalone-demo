using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailsUpdateGrp : IFixComponent
	{
		public sealed partial class NoPartyUpdates : IFixGroup
		{
			[TagDetails(Tag = 1324, Type = TagType.String, Offset = 0, Required = false)]
			public string? ListUpdateAction {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ListUpdateAction is not null) writer.WriteString(1324, ListUpdateAction);
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ListUpdateAction = view.GetString(1324);
				if (view.GetView("PartyDetailGrp") is IMessageView viewPartyDetailGrp)
				{
					PartyDetailGrp = new();
					((IFixParser)PartyDetailGrp).Parse(viewPartyDetailGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ListUpdateAction":
					{
						value = ListUpdateAction;
						break;
					}
					case "PartyDetailGrp":
					{
						value = PartyDetailGrp;
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
				ListUpdateAction = null;
				((IFixReset?)PartyDetailGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1676, Offset = 0, Required = false)]
		public NoPartyUpdates[]? PartyUpdates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyUpdates is not null && PartyUpdates.Length != 0)
			{
				writer.WriteWholeNumber(1676, PartyUpdates.Length);
				for (int i = 0; i < PartyUpdates.Length; i++)
				{
					((IFixEncoder)PartyUpdates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyUpdates") is IMessageView viewNoPartyUpdates)
			{
				var count = viewNoPartyUpdates.GroupCount();
				PartyUpdates = new NoPartyUpdates[count];
				for (int i = 0; i < count; i++)
				{
					PartyUpdates[i] = new();
					((IFixParser)PartyUpdates[i]).Parse(viewNoPartyUpdates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyUpdates":
				{
					value = PartyUpdates;
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
			PartyUpdates = null;
		}
	}
}
