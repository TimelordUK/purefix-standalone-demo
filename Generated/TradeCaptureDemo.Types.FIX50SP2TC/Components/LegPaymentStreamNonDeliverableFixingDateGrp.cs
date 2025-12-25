using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamNonDeliverableFixingDateGrp : IFixComponent
	{
		public sealed partial class NoLegNonDeliverableFixingDates : IFixGroup
		{
			[TagDetails(Tag = 40368, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegNonDeliverableFixingDate {get; set;}
			
			[TagDetails(Tag = 40369, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegNonDeliverableFixingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegNonDeliverableFixingDate is not null) writer.WriteLocalDateOnly(40368, LegNonDeliverableFixingDate.Value);
				if (LegNonDeliverableFixingDateType is not null) writer.WriteWholeNumber(40369, LegNonDeliverableFixingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegNonDeliverableFixingDate = view.GetDateOnly(40368);
				LegNonDeliverableFixingDateType = view.GetInt32(40369);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegNonDeliverableFixingDate":
					{
						value = LegNonDeliverableFixingDate;
						break;
					}
					case "LegNonDeliverableFixingDateType":
					{
						value = LegNonDeliverableFixingDateType;
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
				LegNonDeliverableFixingDate = null;
				LegNonDeliverableFixingDateType = null;
			}
		}
		[Group(NoOfTag = 40367, Offset = 0, Required = false)]
		public NoLegNonDeliverableFixingDates[]? LegNonDeliverableFixingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegNonDeliverableFixingDates is not null && LegNonDeliverableFixingDates.Length != 0)
			{
				writer.WriteWholeNumber(40367, LegNonDeliverableFixingDates.Length);
				for (int i = 0; i < LegNonDeliverableFixingDates.Length; i++)
				{
					((IFixEncoder)LegNonDeliverableFixingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegNonDeliverableFixingDates") is IMessageView viewNoLegNonDeliverableFixingDates)
			{
				var count = viewNoLegNonDeliverableFixingDates.GroupCount();
				LegNonDeliverableFixingDates = new NoLegNonDeliverableFixingDates[count];
				for (int i = 0; i < count; i++)
				{
					LegNonDeliverableFixingDates[i] = new();
					((IFixParser)LegNonDeliverableFixingDates[i]).Parse(viewNoLegNonDeliverableFixingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegNonDeliverableFixingDates":
				{
					value = LegNonDeliverableFixingDates;
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
			LegNonDeliverableFixingDates = null;
		}
	}
}
