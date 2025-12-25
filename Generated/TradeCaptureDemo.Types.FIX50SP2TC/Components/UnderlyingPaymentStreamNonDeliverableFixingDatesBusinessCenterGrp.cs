using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters : IFixGroup
		{
			[TagDetails(Tag = 40650, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter is not null) writer.WriteString(40650, UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter = view.GetString(40650);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter":
					{
						value = UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter;
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
				UnderlyingPaymentStreamNonDeliverableFixingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40968, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters[]? UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters is not null && UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters.Length != 0)
			{
				writer.WriteWholeNumber(40968, UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters") is IMessageView viewNoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters)
			{
				var count = viewNoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters.GroupCount();
				UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters = new NoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters[i]).Parse(viewNoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters":
				{
					value = UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters;
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
			UnderlyingPaymentStreamNonDeliverableFixingDatesBizCenters = null;
		}
	}
}
