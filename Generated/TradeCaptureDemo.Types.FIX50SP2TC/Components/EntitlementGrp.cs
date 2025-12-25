using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class EntitlementGrp : IFixComponent
	{
		public sealed partial class NoEntitlements : IFixGroup
		{
			[TagDetails(Tag = 1774, Type = TagType.Boolean, Offset = 0, Required = false)]
			public bool? EntitlementIndicator {get; set;}
			
			[TagDetails(Tag = 1775, Type = TagType.Int, Offset = 1, Required = false)]
			public int? EntitlementType {get; set;}
			
			[TagDetails(Tag = 2402, Type = TagType.Int, Offset = 2, Required = false)]
			public int? EntitlementSubType {get; set;}
			
			[Component(Offset = 3, Required = false)]
			public EntitlementAttribGrp? EntitlementAttribGrp {get; set;}
			
			[TagDetails(Tag = 1776, Type = TagType.String, Offset = 4, Required = false)]
			public string? EntitlementID {get; set;}
			
			[TagDetails(Tag = 1784, Type = TagType.String, Offset = 5, Required = false)]
			public string? EntitlementPlatform {get; set;}
			
			[Component(Offset = 6, Required = false)]
			public InstrumentScopeGrp? InstrumentScopeGrp {get; set;}
			
			[Component(Offset = 7, Required = false)]
			public MarketSegmentScopeGrp? MarketSegmentScopeGrp {get; set;}
			
			[TagDetails(Tag = 1782, Type = TagType.LocalDate, Offset = 8, Required = false)]
			public DateOnly? EntitlementStartDate {get; set;}
			
			[TagDetails(Tag = 1783, Type = TagType.LocalDate, Offset = 9, Required = false)]
			public DateOnly? EntitlementEndDate {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (EntitlementIndicator is not null) writer.WriteBoolean(1774, EntitlementIndicator.Value);
				if (EntitlementType is not null) writer.WriteWholeNumber(1775, EntitlementType.Value);
				if (EntitlementSubType is not null) writer.WriteWholeNumber(2402, EntitlementSubType.Value);
				if (EntitlementAttribGrp is not null) ((IFixEncoder)EntitlementAttribGrp).Encode(writer);
				if (EntitlementID is not null) writer.WriteString(1776, EntitlementID);
				if (EntitlementPlatform is not null) writer.WriteString(1784, EntitlementPlatform);
				if (InstrumentScopeGrp is not null) ((IFixEncoder)InstrumentScopeGrp).Encode(writer);
				if (MarketSegmentScopeGrp is not null) ((IFixEncoder)MarketSegmentScopeGrp).Encode(writer);
				if (EntitlementStartDate is not null) writer.WriteLocalDateOnly(1782, EntitlementStartDate.Value);
				if (EntitlementEndDate is not null) writer.WriteLocalDateOnly(1783, EntitlementEndDate.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				EntitlementIndicator = view.GetBool(1774);
				EntitlementType = view.GetInt32(1775);
				EntitlementSubType = view.GetInt32(2402);
				if (view.GetView("EntitlementAttribGrp") is IMessageView viewEntitlementAttribGrp)
				{
					EntitlementAttribGrp = new();
					((IFixParser)EntitlementAttribGrp).Parse(viewEntitlementAttribGrp);
				}
				EntitlementID = view.GetString(1776);
				EntitlementPlatform = view.GetString(1784);
				if (view.GetView("InstrumentScopeGrp") is IMessageView viewInstrumentScopeGrp)
				{
					InstrumentScopeGrp = new();
					((IFixParser)InstrumentScopeGrp).Parse(viewInstrumentScopeGrp);
				}
				if (view.GetView("MarketSegmentScopeGrp") is IMessageView viewMarketSegmentScopeGrp)
				{
					MarketSegmentScopeGrp = new();
					((IFixParser)MarketSegmentScopeGrp).Parse(viewMarketSegmentScopeGrp);
				}
				EntitlementStartDate = view.GetDateOnly(1782);
				EntitlementEndDate = view.GetDateOnly(1783);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "EntitlementIndicator":
					{
						value = EntitlementIndicator;
						break;
					}
					case "EntitlementType":
					{
						value = EntitlementType;
						break;
					}
					case "EntitlementSubType":
					{
						value = EntitlementSubType;
						break;
					}
					case "EntitlementAttribGrp":
					{
						value = EntitlementAttribGrp;
						break;
					}
					case "EntitlementID":
					{
						value = EntitlementID;
						break;
					}
					case "EntitlementPlatform":
					{
						value = EntitlementPlatform;
						break;
					}
					case "InstrumentScopeGrp":
					{
						value = InstrumentScopeGrp;
						break;
					}
					case "MarketSegmentScopeGrp":
					{
						value = MarketSegmentScopeGrp;
						break;
					}
					case "EntitlementStartDate":
					{
						value = EntitlementStartDate;
						break;
					}
					case "EntitlementEndDate":
					{
						value = EntitlementEndDate;
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
				EntitlementIndicator = null;
				EntitlementType = null;
				EntitlementSubType = null;
				((IFixReset?)EntitlementAttribGrp)?.Reset();
				EntitlementID = null;
				EntitlementPlatform = null;
				((IFixReset?)InstrumentScopeGrp)?.Reset();
				((IFixReset?)MarketSegmentScopeGrp)?.Reset();
				EntitlementStartDate = null;
				EntitlementEndDate = null;
			}
		}
		[Group(NoOfTag = 1773, Offset = 0, Required = false)]
		public NoEntitlements[]? Entitlements {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Entitlements is not null && Entitlements.Length != 0)
			{
				writer.WriteWholeNumber(1773, Entitlements.Length);
				for (int i = 0; i < Entitlements.Length; i++)
				{
					((IFixEncoder)Entitlements[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoEntitlements") is IMessageView viewNoEntitlements)
			{
				var count = viewNoEntitlements.GroupCount();
				Entitlements = new NoEntitlements[count];
				for (int i = 0; i < count; i++)
				{
					Entitlements[i] = new();
					((IFixParser)Entitlements[i]).Parse(viewNoEntitlements.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoEntitlements":
				{
					value = Entitlements;
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
			Entitlements = null;
		}
	}
}
