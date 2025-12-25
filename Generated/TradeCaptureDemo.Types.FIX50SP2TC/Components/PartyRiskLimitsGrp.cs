using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PartyRiskLimitsGrp : IFixComponent
	{
		public sealed partial class NoPartyRiskLimits : IFixGroup
		{
			[Component(Offset = 0, Required = false)]
			public PartyDetailGrp? PartyDetailGrp {get; set;}
			
			[Component(Offset = 1, Required = false)]
			public RiskLimitsGrp? RiskLimitsGrp {get; set;}
			
			[TagDetails(Tag = 1670, Type = TagType.String, Offset = 2, Required = false)]
			public string? RiskLimitID {get; set;}
			
			[TagDetails(Tag = 2339, Type = TagType.Int, Offset = 3, Required = false)]
			public int? RiskLimitCheckModelType {get; set;}
			
			[TagDetails(Tag = 2355, Type = TagType.Int, Offset = 4, Required = false)]
			public int? PartyRiskLimitStatus {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PartyDetailGrp is not null) ((IFixEncoder)PartyDetailGrp).Encode(writer);
				if (RiskLimitsGrp is not null) ((IFixEncoder)RiskLimitsGrp).Encode(writer);
				if (RiskLimitID is not null) writer.WriteString(1670, RiskLimitID);
				if (RiskLimitCheckModelType is not null) writer.WriteWholeNumber(2339, RiskLimitCheckModelType.Value);
				if (PartyRiskLimitStatus is not null) writer.WriteWholeNumber(2355, PartyRiskLimitStatus.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
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
				PartyRiskLimitStatus = view.GetInt32(2355);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
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
				((IFixReset?)PartyDetailGrp)?.Reset();
				((IFixReset?)RiskLimitsGrp)?.Reset();
				RiskLimitID = null;
				RiskLimitCheckModelType = null;
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
