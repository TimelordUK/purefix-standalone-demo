using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentScheduleFixingDayGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentScheduleFixingDays : IFixGroup
		{
			[TagDetails(Tag = 41879, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDayOfWeek {get; set;}
			
			[TagDetails(Tag = 41880, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentScheduleFixingDayNumber {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentScheduleFixingDayOfWeek is not null) writer.WriteWholeNumber(41879, UnderlyingPaymentScheduleFixingDayOfWeek.Value);
				if (UnderlyingPaymentScheduleFixingDayNumber is not null) writer.WriteWholeNumber(41880, UnderlyingPaymentScheduleFixingDayNumber.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentScheduleFixingDayOfWeek = view.GetInt32(41879);
				UnderlyingPaymentScheduleFixingDayNumber = view.GetInt32(41880);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentScheduleFixingDayOfWeek":
					{
						value = UnderlyingPaymentScheduleFixingDayOfWeek;
						break;
					}
					case "UnderlyingPaymentScheduleFixingDayNumber":
					{
						value = UnderlyingPaymentScheduleFixingDayNumber;
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
				UnderlyingPaymentScheduleFixingDayOfWeek = null;
				UnderlyingPaymentScheduleFixingDayNumber = null;
			}
		}
		[Group(NoOfTag = 41878, Offset = 0, Required = false)]
		public NoUnderlyingPaymentScheduleFixingDays[]? UnderlyingPaymentScheduleFixingDays {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentScheduleFixingDays is not null && UnderlyingPaymentScheduleFixingDays.Length != 0)
			{
				writer.WriteWholeNumber(41878, UnderlyingPaymentScheduleFixingDays.Length);
				for (int i = 0; i < UnderlyingPaymentScheduleFixingDays.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentScheduleFixingDays[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentScheduleFixingDays") is IMessageView viewNoUnderlyingPaymentScheduleFixingDays)
			{
				var count = viewNoUnderlyingPaymentScheduleFixingDays.GroupCount();
				UnderlyingPaymentScheduleFixingDays = new NoUnderlyingPaymentScheduleFixingDays[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentScheduleFixingDays[i] = new();
					((IFixParser)UnderlyingPaymentScheduleFixingDays[i]).Parse(viewNoUnderlyingPaymentScheduleFixingDays.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentScheduleFixingDays":
				{
					value = UnderlyingPaymentScheduleFixingDays;
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
			UnderlyingPaymentScheduleFixingDays = null;
		}
	}
}
