using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPhysicalSettlDeliverableObligationGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPhysicalSettlDeliverableObligations : IFixGroup
		{
			[TagDetails(Tag = 42066, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPhysicalSettlDeliverableObligationType {get; set;}
			
			[TagDetails(Tag = 42067, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingPhysicalSettlDeliverableObligationValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPhysicalSettlDeliverableObligationType is not null) writer.WriteString(42066, UnderlyingPhysicalSettlDeliverableObligationType);
				if (UnderlyingPhysicalSettlDeliverableObligationValue is not null) writer.WriteString(42067, UnderlyingPhysicalSettlDeliverableObligationValue);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPhysicalSettlDeliverableObligationType = view.GetString(42066);
				UnderlyingPhysicalSettlDeliverableObligationValue = view.GetString(42067);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPhysicalSettlDeliverableObligationType":
					{
						value = UnderlyingPhysicalSettlDeliverableObligationType;
						break;
					}
					case "UnderlyingPhysicalSettlDeliverableObligationValue":
					{
						value = UnderlyingPhysicalSettlDeliverableObligationValue;
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
				UnderlyingPhysicalSettlDeliverableObligationType = null;
				UnderlyingPhysicalSettlDeliverableObligationValue = null;
			}
		}
		[Group(NoOfTag = 42065, Offset = 0, Required = false)]
		public NoUnderlyingPhysicalSettlDeliverableObligations[]? UnderlyingPhysicalSettlDeliverableObligations {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPhysicalSettlDeliverableObligations is not null && UnderlyingPhysicalSettlDeliverableObligations.Length != 0)
			{
				writer.WriteWholeNumber(42065, UnderlyingPhysicalSettlDeliverableObligations.Length);
				for (int i = 0; i < UnderlyingPhysicalSettlDeliverableObligations.Length; i++)
				{
					((IFixEncoder)UnderlyingPhysicalSettlDeliverableObligations[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPhysicalSettlDeliverableObligations") is IMessageView viewNoUnderlyingPhysicalSettlDeliverableObligations)
			{
				var count = viewNoUnderlyingPhysicalSettlDeliverableObligations.GroupCount();
				UnderlyingPhysicalSettlDeliverableObligations = new NoUnderlyingPhysicalSettlDeliverableObligations[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPhysicalSettlDeliverableObligations[i] = new();
					((IFixParser)UnderlyingPhysicalSettlDeliverableObligations[i]).Parse(viewNoUnderlyingPhysicalSettlDeliverableObligations.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPhysicalSettlDeliverableObligations":
				{
					value = UnderlyingPhysicalSettlDeliverableObligations;
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
			UnderlyingPhysicalSettlDeliverableObligations = null;
		}
	}
}
