using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionCashSettlPaymentFixedDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionCashSettlPaymentDates : IFixGroup
		{
			[TagDetails(Tag = 42100, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingProvisionCashSettlPaymentDate {get; set;}
			
			[TagDetails(Tag = 42101, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingProvisionCashSettlPaymentDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionCashSettlPaymentDate is not null) writer.WriteLocalDateOnly(42100, UnderlyingProvisionCashSettlPaymentDate.Value);
				if (UnderlyingProvisionCashSettlPaymentDateType is not null) writer.WriteWholeNumber(42101, UnderlyingProvisionCashSettlPaymentDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionCashSettlPaymentDate = view.GetDateOnly(42100);
				UnderlyingProvisionCashSettlPaymentDateType = view.GetInt32(42101);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionCashSettlPaymentDate":
					{
						value = UnderlyingProvisionCashSettlPaymentDate;
						break;
					}
					case "UnderlyingProvisionCashSettlPaymentDateType":
					{
						value = UnderlyingProvisionCashSettlPaymentDateType;
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
				UnderlyingProvisionCashSettlPaymentDate = null;
				UnderlyingProvisionCashSettlPaymentDateType = null;
			}
		}
		[Group(NoOfTag = 42099, Offset = 0, Required = false)]
		public NoUnderlyingProvisionCashSettlPaymentDates[]? UnderlyingProvisionCashSettlPaymentDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionCashSettlPaymentDates is not null && UnderlyingProvisionCashSettlPaymentDates.Length != 0)
			{
				writer.WriteWholeNumber(42099, UnderlyingProvisionCashSettlPaymentDates.Length);
				for (int i = 0; i < UnderlyingProvisionCashSettlPaymentDates.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionCashSettlPaymentDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionCashSettlPaymentDates") is IMessageView viewNoUnderlyingProvisionCashSettlPaymentDates)
			{
				var count = viewNoUnderlyingProvisionCashSettlPaymentDates.GroupCount();
				UnderlyingProvisionCashSettlPaymentDates = new NoUnderlyingProvisionCashSettlPaymentDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionCashSettlPaymentDates[i] = new();
					((IFixParser)UnderlyingProvisionCashSettlPaymentDates[i]).Parse(viewNoUnderlyingProvisionCashSettlPaymentDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionCashSettlPaymentDates":
				{
					value = UnderlyingProvisionCashSettlPaymentDates;
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
			UnderlyingProvisionCashSettlPaymentDates = null;
		}
	}
}
