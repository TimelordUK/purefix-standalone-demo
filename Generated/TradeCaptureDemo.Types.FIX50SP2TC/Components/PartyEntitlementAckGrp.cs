using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyEntitlementAckGrp : IFixComponent
	{
		public sealed partial class NoPartyEntitlements : IFixGroup
		{
			[TagDetails(Tag = 1324, Type = TagType.String, Offset = 0, Required = false)]
			public string? ListUpdateAction {get; set;}
			
			[TagDetails(Tag = 1883, Type = TagType.Int, Offset = 1, Required = false)]
			public int? EntitlementStatus {get; set;}
			
			[TagDetails(Tag = 1884, Type = TagType.Int, Offset = 2, Required = false)]
			public int? EntitlementResult {get; set;}
			
			[TagDetails(Tag = 1328, Type = TagType.String, Offset = 3, Required = false)]
			public string? RejectText {get; set;}
			
			[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 4, Required = false)]
			public int? EncodedRejectTextLen {get; set;}
			
			[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 5, Required = false)]
			public byte[]? EncodedRejectText {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public EntitlementGrp? EntitlementGrp {get; set;}
			
			[TagDetails(Tag = 1885, Type = TagType.String, Offset = 8, Required = false)]
			public string? EntitlementRefID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ListUpdateAction is not null) writer.WriteString(1324, ListUpdateAction);
				if (EntitlementStatus is not null) writer.WriteWholeNumber(1883, EntitlementStatus.Value);
				if (EntitlementResult is not null) writer.WriteWholeNumber(1884, EntitlementResult.Value);
				if (RejectText is not null) writer.WriteString(1328, RejectText);
				if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
				if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
				if (EntitlementGrp is not null) ((IFixEncoder)EntitlementGrp).Encode(writer);
				if (EntitlementRefID is not null) writer.WriteString(1885, EntitlementRefID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ListUpdateAction = view.GetString(1324);
				EntitlementStatus = view.GetInt32(1883);
				EntitlementResult = view.GetInt32(1884);
				RejectText = view.GetString(1328);
				EncodedRejectTextLen = view.GetInt32(1664);
				EncodedRejectText = view.GetByteArray(1665);
				if (view.GetView("PartyDetailGrp") is IMessageView viewPartyDetailGrp)
				{
					PartyDetailGrp = new();
					((IFixParser)PartyDetailGrp).Parse(viewPartyDetailGrp);
				}
				if (view.GetView("EntitlementGrp") is IMessageView viewEntitlementGrp)
				{
					EntitlementGrp = new();
					((IFixParser)EntitlementGrp).Parse(viewEntitlementGrp);
				}
				EntitlementRefID = view.GetString(1885);
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
					case "EntitlementStatus":
					{
						value = EntitlementStatus;
						break;
					}
					case "EntitlementResult":
					{
						value = EntitlementResult;
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
					case "EntitlementGrp":
					{
						value = EntitlementGrp;
						break;
					}
					case "EntitlementRefID":
					{
						value = EntitlementRefID;
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
				EntitlementStatus = null;
				EntitlementResult = null;
				RejectText = null;
				EncodedRejectTextLen = null;
				EncodedRejectText = null;
				((IFixReset?)PartyDetailGrp)?.Reset();
				((IFixReset?)EntitlementGrp)?.Reset();
				EntitlementRefID = null;
			}
		}
		[Group(NoOfTag = 1772, Offset = 0, Required = false)]
		public NoPartyEntitlements[]? PartyEntitlements {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyEntitlements is not null && PartyEntitlements.Length != 0)
			{
				writer.WriteWholeNumber(1772, PartyEntitlements.Length);
				for (int i = 0; i < PartyEntitlements.Length; i++)
				{
					((IFixEncoder)PartyEntitlements[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyEntitlements") is IMessageView viewNoPartyEntitlements)
			{
				var count = viewNoPartyEntitlements.GroupCount();
				PartyEntitlements = new NoPartyEntitlements[count];
				for (int i = 0; i < count; i++)
				{
					PartyEntitlements[i] = new();
					((IFixParser)PartyEntitlements[i]).Parse(viewNoPartyEntitlements.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyEntitlements":
				{
					value = PartyEntitlements;
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
			PartyEntitlements = null;
		}
	}
}
