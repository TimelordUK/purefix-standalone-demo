using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentSettlGrp : IFixComponent
	{
		public sealed partial class NoPaymentSettls : IFixGroup
		{
			[TagDetails(Tag = 40231, Type = TagType.Float, Offset = 0, Required = false)]
			public double? PaymentSettlAmount {get; set;}
			
			[TagDetails(Tag = 40232, Type = TagType.String, Offset = 1, Required = false)]
			public string? PaymentSettlCurrency {get; set;}
			
			[Component(Offset = 2, Required = false)]
			public PaymentSettlParties? PaymentSettlParties {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentSettlAmount is not null) writer.WriteNumber(40231, PaymentSettlAmount.Value);
				if (PaymentSettlCurrency is not null) writer.WriteString(40232, PaymentSettlCurrency);
				if (PaymentSettlParties is not null) ((IFixEncoder)PaymentSettlParties).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentSettlAmount = view.GetDouble(40231);
				PaymentSettlCurrency = view.GetString(40232);
				if (view.GetView("PaymentSettlParties") is IMessageView viewPaymentSettlParties)
				{
					PaymentSettlParties = new();
					((IFixParser)PaymentSettlParties).Parse(viewPaymentSettlParties);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentSettlAmount":
					{
						value = PaymentSettlAmount;
						break;
					}
					case "PaymentSettlCurrency":
					{
						value = PaymentSettlCurrency;
						break;
					}
					case "PaymentSettlParties":
					{
						value = PaymentSettlParties;
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
				PaymentSettlAmount = null;
				PaymentSettlCurrency = null;
				((IFixReset?)PaymentSettlParties)?.Reset();
			}
		}
		[Group(NoOfTag = 40230, Offset = 0, Required = false)]
		public NoPaymentSettls[]? PaymentSettls {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentSettls is not null && PaymentSettls.Length != 0)
			{
				writer.WriteWholeNumber(40230, PaymentSettls.Length);
				for (int i = 0; i < PaymentSettls.Length; i++)
				{
					((IFixEncoder)PaymentSettls[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentSettls") is IMessageView viewNoPaymentSettls)
			{
				var count = viewNoPaymentSettls.GroupCount();
				PaymentSettls = new NoPaymentSettls[count];
				for (int i = 0; i < count; i++)
				{
					PaymentSettls[i] = new();
					((IFixParser)PaymentSettls[i]).Parse(viewNoPaymentSettls.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentSettls":
				{
					value = PaymentSettls;
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
			PaymentSettls = null;
		}
	}
}
