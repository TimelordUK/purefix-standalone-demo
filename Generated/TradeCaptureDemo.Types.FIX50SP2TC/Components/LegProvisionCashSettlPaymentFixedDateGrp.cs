using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionCashSettlPaymentFixedDateGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionCashSettlPaymentDates : IFixGroup
		{
			[TagDetails(Tag = 40474, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegProvisionCashSettlPaymentDate {get; set;}
			
			[TagDetails(Tag = 40475, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegProvisionCashSettlPaymentDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionCashSettlPaymentDate is not null) writer.WriteLocalDateOnly(40474, LegProvisionCashSettlPaymentDate.Value);
				if (LegProvisionCashSettlPaymentDateType is not null) writer.WriteWholeNumber(40475, LegProvisionCashSettlPaymentDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionCashSettlPaymentDate = view.GetDateOnly(40474);
				LegProvisionCashSettlPaymentDateType = view.GetInt32(40475);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionCashSettlPaymentDate":
					{
						value = LegProvisionCashSettlPaymentDate;
						break;
					}
					case "LegProvisionCashSettlPaymentDateType":
					{
						value = LegProvisionCashSettlPaymentDateType;
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
				LegProvisionCashSettlPaymentDate = null;
				LegProvisionCashSettlPaymentDateType = null;
			}
		}
		[Group(NoOfTag = 40473, Offset = 0, Required = false)]
		public NoLegProvisionCashSettlPaymentDates[]? LegProvisionCashSettlPaymentDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionCashSettlPaymentDates is not null && LegProvisionCashSettlPaymentDates.Length != 0)
			{
				writer.WriteWholeNumber(40473, LegProvisionCashSettlPaymentDates.Length);
				for (int i = 0; i < LegProvisionCashSettlPaymentDates.Length; i++)
				{
					((IFixEncoder)LegProvisionCashSettlPaymentDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionCashSettlPaymentDates") is IMessageView viewNoLegProvisionCashSettlPaymentDates)
			{
				var count = viewNoLegProvisionCashSettlPaymentDates.GroupCount();
				LegProvisionCashSettlPaymentDates = new NoLegProvisionCashSettlPaymentDates[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionCashSettlPaymentDates[i] = new();
					((IFixParser)LegProvisionCashSettlPaymentDates[i]).Parse(viewNoLegProvisionCashSettlPaymentDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionCashSettlPaymentDates":
				{
					value = LegProvisionCashSettlPaymentDates;
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
			LegProvisionCashSettlPaymentDates = null;
		}
	}
}
