using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentStreamInitialFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoPaymentStreamInitialFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40769, Type = TagType.String, Offset = 0, Required = false)]
			public string? PaymentStreamInitialFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentStreamInitialFixingDateBusinessCenter is not null) writer.WriteString(40769, PaymentStreamInitialFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentStreamInitialFixingDateBusinessCenter = view.GetString(40769);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentStreamInitialFixingDateBusinessCenter":
					{
						value = PaymentStreamInitialFixingDateBusinessCenter;
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
				PaymentStreamInitialFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40949, Offset = 0, Required = false)]
		public NoPaymentStreamInitialFixingDateBusinessCenters[]? PaymentStreamInitialFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentStreamInitialFixingDateBusinessCenters is not null && PaymentStreamInitialFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40949, PaymentStreamInitialFixingDateBusinessCenters.Length);
				for (int i = 0; i < PaymentStreamInitialFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)PaymentStreamInitialFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentStreamInitialFixingDateBusinessCenters") is IMessageView viewNoPaymentStreamInitialFixingDateBusinessCenters)
			{
				var count = viewNoPaymentStreamInitialFixingDateBusinessCenters.GroupCount();
				PaymentStreamInitialFixingDateBusinessCenters = new NoPaymentStreamInitialFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					PaymentStreamInitialFixingDateBusinessCenters[i] = new();
					((IFixParser)PaymentStreamInitialFixingDateBusinessCenters[i]).Parse(viewNoPaymentStreamInitialFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentStreamInitialFixingDateBusinessCenters":
				{
					value = PaymentStreamInitialFixingDateBusinessCenters;
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
			PaymentStreamInitialFixingDateBusinessCenters = null;
		}
	}
}
