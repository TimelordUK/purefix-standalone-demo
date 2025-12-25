using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PhysicalSettlDeliverableObligationGrp : IFixComponent
	{
		public sealed partial class NoPhysicalSettlDeliverableObligations : IFixGroup
		{
			[TagDetails(Tag = 40210, Type = TagType.String, Offset = 0, Required = false)]
			public string? PhysicalSettlDeliverableObligationType {get; set;}
			
			[TagDetails(Tag = 40211, Type = TagType.String, Offset = 1, Required = false)]
			public string? PhysicalSettlDeliverableObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PhysicalSettlDeliverableObligationType is not null) writer.WriteString(40210, PhysicalSettlDeliverableObligationType);
				if (PhysicalSettlDeliverableObligationValue is not null) writer.WriteString(40211, PhysicalSettlDeliverableObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PhysicalSettlDeliverableObligationType = view.GetString(40210);
				PhysicalSettlDeliverableObligationValue = view.GetString(40211);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PhysicalSettlDeliverableObligationType":
					{
						value = PhysicalSettlDeliverableObligationType;
						break;
					}
					case "PhysicalSettlDeliverableObligationValue":
					{
						value = PhysicalSettlDeliverableObligationValue;
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
				PhysicalSettlDeliverableObligationType = null;
				PhysicalSettlDeliverableObligationValue = null;
			}
		}
		[Group(NoOfTag = 40209, Offset = 0, Required = false)]
		public NoPhysicalSettlDeliverableObligations[]? PhysicalSettlDeliverableObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PhysicalSettlDeliverableObligations is not null && PhysicalSettlDeliverableObligations.Length != 0)
			{
				writer.WriteWholeNumber(40209, PhysicalSettlDeliverableObligations.Length);
				for (int i = 0; i < PhysicalSettlDeliverableObligations.Length; i++)
				{
					((IFixEncoder)PhysicalSettlDeliverableObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPhysicalSettlDeliverableObligations") is IMessageView viewNoPhysicalSettlDeliverableObligations)
			{
				var count = viewNoPhysicalSettlDeliverableObligations.GroupCount();
				PhysicalSettlDeliverableObligations = new NoPhysicalSettlDeliverableObligations[count];
				for (int i = 0; i < count; i++)
				{
					PhysicalSettlDeliverableObligations[i] = new();
					((IFixParser)PhysicalSettlDeliverableObligations[i]).Parse(viewNoPhysicalSettlDeliverableObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPhysicalSettlDeliverableObligations":
				{
					value = PhysicalSettlDeliverableObligations;
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
			PhysicalSettlDeliverableObligations = null;
		}
	}
}
