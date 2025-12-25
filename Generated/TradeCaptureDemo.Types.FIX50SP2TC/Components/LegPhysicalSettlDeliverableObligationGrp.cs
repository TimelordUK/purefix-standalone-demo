using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPhysicalSettlDeliverableObligationGrp : IFixComponent
	{
		public sealed partial class NoLegPhysicalSettlDeliverableObligations : IFixGroup
		{
			[TagDetails(Tag = 41605, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPhysicalSettlDeliverableObligationType {get; set;}
			
			[TagDetails(Tag = 41606, Type = TagType.String, Offset = 1, Required = false)]
			public string? LegPhysicalSettlDeliverableObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPhysicalSettlDeliverableObligationType is not null) writer.WriteString(41605, LegPhysicalSettlDeliverableObligationType);
				if (LegPhysicalSettlDeliverableObligationValue is not null) writer.WriteString(41606, LegPhysicalSettlDeliverableObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPhysicalSettlDeliverableObligationType = view.GetString(41605);
				LegPhysicalSettlDeliverableObligationValue = view.GetString(41606);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPhysicalSettlDeliverableObligationType":
					{
						value = LegPhysicalSettlDeliverableObligationType;
						break;
					}
					case "LegPhysicalSettlDeliverableObligationValue":
					{
						value = LegPhysicalSettlDeliverableObligationValue;
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
				LegPhysicalSettlDeliverableObligationType = null;
				LegPhysicalSettlDeliverableObligationValue = null;
			}
		}
		[Group(NoOfTag = 41604, Offset = 0, Required = false)]
		public NoLegPhysicalSettlDeliverableObligations[]? LegPhysicalSettlDeliverableObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPhysicalSettlDeliverableObligations is not null && LegPhysicalSettlDeliverableObligations.Length != 0)
			{
				writer.WriteWholeNumber(41604, LegPhysicalSettlDeliverableObligations.Length);
				for (int i = 0; i < LegPhysicalSettlDeliverableObligations.Length; i++)
				{
					((IFixEncoder)LegPhysicalSettlDeliverableObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPhysicalSettlDeliverableObligations") is IMessageView viewNoLegPhysicalSettlDeliverableObligations)
			{
				var count = viewNoLegPhysicalSettlDeliverableObligations.GroupCount();
				LegPhysicalSettlDeliverableObligations = new NoLegPhysicalSettlDeliverableObligations[count];
				for (int i = 0; i < count; i++)
				{
					LegPhysicalSettlDeliverableObligations[i] = new();
					((IFixParser)LegPhysicalSettlDeliverableObligations[i]).Parse(viewNoLegPhysicalSettlDeliverableObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPhysicalSettlDeliverableObligations":
				{
					value = LegPhysicalSettlDeliverableObligations;
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
			LegPhysicalSettlDeliverableObligations = null;
		}
	}
}
