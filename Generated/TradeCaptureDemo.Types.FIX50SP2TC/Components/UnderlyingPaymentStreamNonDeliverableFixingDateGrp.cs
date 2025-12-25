using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamNonDeliverableFixingDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingNonDeliverableFixingDates : IFixGroup
		{
			[TagDetails(Tag = 40657, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingNonDeliverableFixingDate {get; set;}
			
			[TagDetails(Tag = 40658, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingNonDeliverableFixingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingNonDeliverableFixingDate is not null) writer.WriteLocalDateOnly(40657, UnderlyingNonDeliverableFixingDate.Value);
				if (UnderlyingNonDeliverableFixingDateType is not null) writer.WriteWholeNumber(40658, UnderlyingNonDeliverableFixingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingNonDeliverableFixingDate = view.GetDateOnly(40657);
				UnderlyingNonDeliverableFixingDateType = view.GetInt32(40658);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingNonDeliverableFixingDate":
					{
						value = UnderlyingNonDeliverableFixingDate;
						break;
					}
					case "UnderlyingNonDeliverableFixingDateType":
					{
						value = UnderlyingNonDeliverableFixingDateType;
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
				UnderlyingNonDeliverableFixingDate = null;
				UnderlyingNonDeliverableFixingDateType = null;
			}
		}
		[Group(NoOfTag = 40656, Offset = 0, Required = false)]
		public NoUnderlyingNonDeliverableFixingDates[]? UnderlyingNonDeliverableFixingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingNonDeliverableFixingDates is not null && UnderlyingNonDeliverableFixingDates.Length != 0)
			{
				writer.WriteWholeNumber(40656, UnderlyingNonDeliverableFixingDates.Length);
				for (int i = 0; i < UnderlyingNonDeliverableFixingDates.Length; i++)
				{
					((IFixEncoder)UnderlyingNonDeliverableFixingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingNonDeliverableFixingDates") is IMessageView viewNoUnderlyingNonDeliverableFixingDates)
			{
				var count = viewNoUnderlyingNonDeliverableFixingDates.GroupCount();
				UnderlyingNonDeliverableFixingDates = new NoUnderlyingNonDeliverableFixingDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingNonDeliverableFixingDates[i] = new();
					((IFixParser)UnderlyingNonDeliverableFixingDates[i]).Parse(viewNoUnderlyingNonDeliverableFixingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingNonDeliverableFixingDates":
				{
					value = UnderlyingNonDeliverableFixingDates;
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
			UnderlyingNonDeliverableFixingDates = null;
		}
	}
}
