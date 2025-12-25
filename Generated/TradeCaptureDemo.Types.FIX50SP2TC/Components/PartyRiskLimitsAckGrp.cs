using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyRiskLimitsAckGrp : IFixComponent
	{
		public sealed partial class NoPartyRiskLimits : IFixGroup
		{
			[TagDetails(Tag = 1324, Type = TagType.String, Offset = 0, Required = false)]
			public string? ListUpdateAction {get; set;}
			
			[TagDetails(Tag = 1763, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RiskLimitStatus {get; set;}
			
			[TagDetails(Tag = 1764, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RiskLimitResult {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public RiskLimitsGrp? RiskLimitsGrp {get; set;}
			
			[TagDetails(Tag = 1670, Type = TagType.String, Offset = 5, Required = false)]
			public string? RiskLimitID {get; set;}
			
			[TagDetails(Tag = 2339, Type = TagType.Int, Offset = 6, Required = false)]
			public int? RiskLimitCheckModelType {get; set;}
			
			[TagDetails(Tag = 1328, Type = TagType.String, Offset = 7, Required = false)]
			public string? RejectText {get; set;}
			
			[TagDetails(Tag = 1664, Type = TagType.Length, Offset = 8, Required = false)]
			public int? EncodedRejectTextLen {get; set;}
			
			[TagDetails(Tag = 1665, Type = TagType.RawData, Offset = 9, Required = false)]
			public byte[]? EncodedRejectText {get; set;}
			
			[TagDetails(Tag = 2355, Type = TagType.Int, Offset = 10, Required = false)]
			public int? PartyRiskLimitStatus {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ListUpdateAction is not null) writer.WriteString(1324, ListUpdateAction);
				if (RiskLimitStatus is not null) writer.WriteWholeNumber(1763, RiskLimitStatus.Value);
				if (RiskLimitResult is not null) writer.WriteWholeNumber(1764, RiskLimitResult.Value);
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
				if (RiskLimitsGrp is not null) ((IFixEncoder)RiskLimitsGrp).Encode(writer);
				if (RiskLimitID is not null) writer.WriteString(1670, RiskLimitID);
				if (RiskLimitCheckModelType is not null) writer.WriteWholeNumber(2339, RiskLimitCheckModelType.Value);
				if (RejectText is not null) writer.WriteString(1328, RejectText);
				if (EncodedRejectTextLen is not null) writer.WriteWholeNumber(1664, EncodedRejectTextLen.Value);
				if (EncodedRejectText is not null) writer.WriteBuffer(1665, EncodedRejectText);
				if (PartyRiskLimitStatus is not null) writer.WriteWholeNumber(2355, PartyRiskLimitStatus.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ListUpdateAction = view.GetString(1324);
				RiskLimitStatus = view.GetInt32(1763);
				RiskLimitResult = view.GetInt32(1764);
				if (view.GetView("PartyDetailGrp") is IMessageView viewPartyDetailGrp)
				{
					PartyDetailGrp = new();
					((IFixParser)PartyDetailGrp).Parse(viewPartyDetailGrp);
				}
				if (view.GetView("RiskLimitsGrp") is IMessageView viewRiskLimitsGrp)
				{
					RiskLimitsGrp = new();
					((IFixParser)RiskLimitsGrp).Parse(viewRiskLimitsGrp);
				}
				RiskLimitID = view.GetString(1670);
				RiskLimitCheckModelType = view.GetInt32(2339);
				RejectText = view.GetString(1328);
				EncodedRejectTextLen = view.GetInt32(1664);
				EncodedRejectText = view.GetByteArray(1665);
				PartyRiskLimitStatus = view.GetInt32(2355);
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
					case "RiskLimitStatus":
					{
						value = RiskLimitStatus;
						break;
					}
					case "RiskLimitResult":
					{
						value = RiskLimitResult;
						break;
					}
					case "PartyDetailGrp":
					{
						value = PartyDetailGrp;
						break;
					}
					case "RiskLimitsGrp":
					{
						value = RiskLimitsGrp;
						break;
					}
					case "RiskLimitID":
					{
						value = RiskLimitID;
						break;
					}
					case "RiskLimitCheckModelType":
					{
						value = RiskLimitCheckModelType;
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
					case "PartyRiskLimitStatus":
					{
						value = PartyRiskLimitStatus;
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
				RiskLimitStatus = null;
				RiskLimitResult = null;
				((IFixReset?)PartyDetailGrp)?.Reset();
				((IFixReset?)RiskLimitsGrp)?.Reset();
				RiskLimitID = null;
				RiskLimitCheckModelType = null;
				RejectText = null;
				EncodedRejectTextLen = null;
				EncodedRejectText = null;
				PartyRiskLimitStatus = null;
			}
		}
		[Group(NoOfTag = 1677, Offset = 0, Required = false)]
		public NoPartyRiskLimits[]? PartyRiskLimits {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PartyRiskLimits is not null && PartyRiskLimits.Length != 0)
			{
				writer.WriteWholeNumber(1677, PartyRiskLimits.Length);
				for (int i = 0; i < PartyRiskLimits.Length; i++)
				{
					((IFixEncoder)PartyRiskLimits[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPartyRiskLimits") is IMessageView viewNoPartyRiskLimits)
			{
				var count = viewNoPartyRiskLimits.GroupCount();
				PartyRiskLimits = new NoPartyRiskLimits[count];
				for (int i = 0; i < count; i++)
				{
					PartyRiskLimits[i] = new();
					((IFixParser)PartyRiskLimits[i]).Parse(viewNoPartyRiskLimits.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPartyRiskLimits":
				{
					value = PartyRiskLimits;
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
			PartyRiskLimits = null;
		}
	}
}
