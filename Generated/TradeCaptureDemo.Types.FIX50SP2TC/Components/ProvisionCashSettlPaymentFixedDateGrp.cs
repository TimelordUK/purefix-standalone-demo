using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionCashSettlPaymentFixedDateGrp : IFixComponent
	{
		public sealed partial class NoProvisionCashSettlPaymentDates : IFixGroup
		{
			[TagDetails(Tag = 40172, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? ProvisionCashSettlPaymentDate {get; set;}
			
			[TagDetails(Tag = 40173, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ProvisionCashSettlPaymentDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionCashSettlPaymentDate is not null) writer.WriteLocalDateOnly(40172, ProvisionCashSettlPaymentDate.Value);
				if (ProvisionCashSettlPaymentDateType is not null) writer.WriteWholeNumber(40173, ProvisionCashSettlPaymentDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionCashSettlPaymentDate = view.GetDateOnly(40172);
				ProvisionCashSettlPaymentDateType = view.GetInt32(40173);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionCashSettlPaymentDate":
					{
						value = ProvisionCashSettlPaymentDate;
						break;
					}
					case "ProvisionCashSettlPaymentDateType":
					{
						value = ProvisionCashSettlPaymentDateType;
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
				ProvisionCashSettlPaymentDate = null;
				ProvisionCashSettlPaymentDateType = null;
			}
		}
		[Group(NoOfTag = 40171, Offset = 0, Required = false)]
		public NoProvisionCashSettlPaymentDates[]? ProvisionCashSettlPaymentDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionCashSettlPaymentDates is not null && ProvisionCashSettlPaymentDates.Length != 0)
			{
				writer.WriteWholeNumber(40171, ProvisionCashSettlPaymentDates.Length);
				for (int i = 0; i < ProvisionCashSettlPaymentDates.Length; i++)
				{
					((IFixEncoder)ProvisionCashSettlPaymentDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionCashSettlPaymentDates") is IMessageView viewNoProvisionCashSettlPaymentDates)
			{
				var count = viewNoProvisionCashSettlPaymentDates.GroupCount();
				ProvisionCashSettlPaymentDates = new NoProvisionCashSettlPaymentDates[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionCashSettlPaymentDates[i] = new();
					((IFixParser)ProvisionCashSettlPaymentDates[i]).Parse(viewNoProvisionCashSettlPaymentDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionCashSettlPaymentDates":
				{
					value = ProvisionCashSettlPaymentDates;
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
			ProvisionCashSettlPaymentDates = null;
		}
	}
}
