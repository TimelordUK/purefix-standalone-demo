using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPricingDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamPricingDates : IFixGroup
		{
			[TagDetails(Tag = 41942, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingPaymentStreamPricingDate {get; set;}
			
			[TagDetails(Tag = 41943, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStreamPricingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamPricingDate is not null) writer.WriteLocalDateOnly(41942, UnderlyingPaymentStreamPricingDate.Value);
				if (UnderlyingPaymentStreamPricingDateType is not null) writer.WriteWholeNumber(41943, UnderlyingPaymentStreamPricingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamPricingDate = view.GetDateOnly(41942);
				UnderlyingPaymentStreamPricingDateType = view.GetInt32(41943);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamPricingDate":
					{
						value = UnderlyingPaymentStreamPricingDate;
						break;
					}
					case "UnderlyingPaymentStreamPricingDateType":
					{
						value = UnderlyingPaymentStreamPricingDateType;
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
				UnderlyingPaymentStreamPricingDate = null;
				UnderlyingPaymentStreamPricingDateType = null;
			}
		}
		[Group(NoOfTag = 41941, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamPricingDates[]? UnderlyingPaymentStreamPricingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPricingDates is not null && UnderlyingPaymentStreamPricingDates.Length != 0)
			{
				writer.WriteWholeNumber(41941, UnderlyingPaymentStreamPricingDates.Length);
				for (int i = 0; i < UnderlyingPaymentStreamPricingDates.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamPricingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamPricingDates") is IMessageView viewNoUnderlyingPaymentStreamPricingDates)
			{
				var count = viewNoUnderlyingPaymentStreamPricingDates.GroupCount();
				UnderlyingPaymentStreamPricingDates = new NoUnderlyingPaymentStreamPricingDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamPricingDates[i] = new();
					((IFixParser)UnderlyingPaymentStreamPricingDates[i]).Parse(viewNoUnderlyingPaymentStreamPricingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamPricingDates":
				{
					value = UnderlyingPaymentStreamPricingDates;
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
			UnderlyingPaymentStreamPricingDates = null;
		}
	}
}
