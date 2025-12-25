using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPricingDayGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamPricingDays : IFixGroup
		{
			[TagDetails(Tag = 41945, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingPaymentStreamPricingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41946, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStreamPricingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamPricingDayOfWeek is not null) writer.WriteWholeNumber(41945, UnderlyingPaymentStreamPricingDayOfWeek.Value);
				if (UnderlyingPaymentStreamPricingDayNumber is not null) writer.WriteWholeNumber(41946, UnderlyingPaymentStreamPricingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamPricingDayOfWeek = view.GetInt32(41945);
				UnderlyingPaymentStreamPricingDayNumber = view.GetInt32(41946);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamPricingDayOfWeek":
					{
						value = UnderlyingPaymentStreamPricingDayOfWeek;
						break;
					}
					case "UnderlyingPaymentStreamPricingDayNumber":
					{
						value = UnderlyingPaymentStreamPricingDayNumber;
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
				UnderlyingPaymentStreamPricingDayOfWeek = null;
				UnderlyingPaymentStreamPricingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41944, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamPricingDays[]? UnderlyingPaymentStreamPricingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPricingDays is not null && UnderlyingPaymentStreamPricingDays.Length != 0)
			{
				writer.WriteWholeNumber(41944, UnderlyingPaymentStreamPricingDays.Length);
				for (int i = 0; i < UnderlyingPaymentStreamPricingDays.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamPricingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamPricingDays") is IMessageView viewNoUnderlyingPaymentStreamPricingDays)
			{
				var count = viewNoUnderlyingPaymentStreamPricingDays.GroupCount();
				UnderlyingPaymentStreamPricingDays = new NoUnderlyingPaymentStreamPricingDays[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamPricingDays[i] = new();
					((IFixParser)UnderlyingPaymentStreamPricingDays[i]).Parse(viewNoUnderlyingPaymentStreamPricingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamPricingDays":
				{
					value = UnderlyingPaymentStreamPricingDays;
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
			UnderlyingPaymentStreamPricingDays = null;
		}
	}
}
