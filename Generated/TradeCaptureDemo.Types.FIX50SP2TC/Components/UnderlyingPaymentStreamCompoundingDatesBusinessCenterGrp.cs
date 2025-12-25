using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingDatesBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamCompoundingDatesBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42916, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamCompoundingDatesBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamCompoundingDatesBusinessCenter is not null) writer.WriteString(42916, UnderlyingPaymentStreamCompoundingDatesBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamCompoundingDatesBusinessCenter = view.GetString(42916);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamCompoundingDatesBusinessCenter":
					{
						value = UnderlyingPaymentStreamCompoundingDatesBusinessCenter;
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
				UnderlyingPaymentStreamCompoundingDatesBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42915, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamCompoundingDatesBusinessCenters[]? UnderlyingPaymentStreamCompoundingDatesBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingDatesBusinessCenters is not null && UnderlyingPaymentStreamCompoundingDatesBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42915, UnderlyingPaymentStreamCompoundingDatesBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamCompoundingDatesBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamCompoundingDatesBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamCompoundingDatesBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamCompoundingDatesBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamCompoundingDatesBusinessCenters.GroupCount();
				UnderlyingPaymentStreamCompoundingDatesBusinessCenters = new NoUnderlyingPaymentStreamCompoundingDatesBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamCompoundingDatesBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamCompoundingDatesBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamCompoundingDatesBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamCompoundingDatesBusinessCenters":
				{
					value = UnderlyingPaymentStreamCompoundingDatesBusinessCenters;
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
			UnderlyingPaymentStreamCompoundingDatesBusinessCenters = null;
		}
	}
}
