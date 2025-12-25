using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentScheduleFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentScheduleFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40690, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentScheduleFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentScheduleFixingDateBusinessCenter is not null) writer.WriteString(40690, UnderlyingPaymentScheduleFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentScheduleFixingDateBusinessCenter = view.GetString(40690);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentScheduleFixingDateBusinessCenter":
					{
						value = UnderlyingPaymentScheduleFixingDateBusinessCenter;
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
				UnderlyingPaymentScheduleFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40966, Offset = 0, Required = false)]
		public NoUnderlyingPaymentScheduleFixingDateBusinessCenters[]? UnderlyingPaymentScheduleFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentScheduleFixingDateBusinessCenters is not null && UnderlyingPaymentScheduleFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40966, UnderlyingPaymentScheduleFixingDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentScheduleFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentScheduleFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentScheduleFixingDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentScheduleFixingDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentScheduleFixingDateBusinessCenters.GroupCount();
				UnderlyingPaymentScheduleFixingDateBusinessCenters = new NoUnderlyingPaymentScheduleFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentScheduleFixingDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentScheduleFixingDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentScheduleFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentScheduleFixingDateBusinessCenters":
				{
					value = UnderlyingPaymentScheduleFixingDateBusinessCenters;
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
			UnderlyingPaymentScheduleFixingDateBusinessCenters = null;
		}
	}
}
