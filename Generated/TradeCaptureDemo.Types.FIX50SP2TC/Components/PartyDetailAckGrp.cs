using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyDetailAckGrp : IFixComponent
	{
		public sealed partial class NoPartyUpdates : IFixGroup
		{
			[TagDetails(Tag = 1324, Type = TagType.String, Offset = 0, Required = false)]
			public string? ListUpdateAction {get; set;}
			
			[TagDetails(Tag = 1879, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PartyDetailDefinitionStatus {get; set;}
			
			[TagDetails(Tag = 1880, Type = TagType.Int, Offset = 2, Required = false)]
			public int? PartyDetailDefinitionResult {get; set;}
			
			[TagDetails(Tag = 1328, Type = TagType.String, Offset = 3, Required = false)]
			public string? RejectText {get; set;}
			
			[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 4, Required = false)]
			public int? EncodedRejectTextLen {get; set;}
			
			[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 5, Required = false)]
			public byte[]? EncodedRejectText {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ListUpdateAction is not null) writer.WriteString(1324, ListUpdateAction);
				if (PartyDetailDefinitionStatus is not null) writer.WriteWholeNumber(1879, PartyDetailDefinitionStatus.Value);
				if (PartyDetailDefinitionResult is not null) writer.WriteWholeNumber(1880, PartyDetailDefinitionResult.Value);
				if (RejectText is not null) writer.WriteString(1328, RejectText);
				if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
				if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ListUpdateAction = view.GetString(1324);
				PartyDetailDefinitionStatus = view.GetInt32(1879);
				PartyDetailDefinitionResult = view.GetInt32(1880);
				RejectText = view.GetString(1328);
				EncodedRejectTextLen = view.GetInt32(1664);
				EncodedRejectText = view.GetByteArray(1665);
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
					case "PartyDetailDefinitionStatus":
					{
						value = PartyDetailDefinitionStatus;
						break;
					}
					case "PartyDetailDefinitionResult":
					{
						value = PartyDetailDefinitionResult;
						break;
					}
					case "RejectText":
					{
						value = RejectText;
						break;
					}
					case "EncodedRejectTextLen":
					{
						value = EncodedRejectTextLen;
						break;
					}
					case "EncodedRejectText":
					{
						value = EncodedRejectText;
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
				PartyDetailDefinitionStatus = null;
				PartyDetailDefinitionResult = null;
				RejectText = null;
				EncodedRejectTextLen = null;
				EncodedRejectText = null;
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
