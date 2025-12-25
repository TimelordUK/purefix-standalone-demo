using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamCompoundingDateGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamCompoundingDates : IFixGroup
		{
			[TagDetails(Tag = 42406, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegPaymentStreamCompoundingDate {get; set;}
			
			[TagDetails(Tag = 42407, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegPaymentStreamCompoundingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamCompoundingDate is not null) writer.WriteLocalDateOnly(42406, LegPaymentStreamCompoundingDate.Value);
				if (LegPaymentStreamCompoundingDateType is not null) writer.WriteWholeNumber(42407, LegPaymentStreamCompoundingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamCompoundingDate = view.GetDateOnly(42406);
				LegPaymentStreamCompoundingDateType = view.GetInt32(42407);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamCompoundingDate":
					{
						value = LegPaymentStreamCompoundingDate;
						break;
					}
					case "LegPaymentStreamCompoundingDateType":
					{
						value = LegPaymentStreamCompoundingDateType;
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
				LegPaymentStreamCompoundingDate = null;
				LegPaymentStreamCompoundingDateType = null;
			}
		}
		[Group(NoOfTag = 42405, Offset = 0, Required = false)]
		public NoLegPaymentStreamCompoundingDates[]? LegPaymentStreamCompoundingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamCompoundingDates is not null && LegPaymentStreamCompoundingDates.Length != 0)
			{
				writer.WriteWholeNumber(42405, LegPaymentStreamCompoundingDates.Length);
				for (int i = 0; i < LegPaymentStreamCompoundingDates.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamCompoundingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamCompoundingDates") is IMessageView viewNoLegPaymentStreamCompoundingDates)
			{
				var count = viewNoLegPaymentStreamCompoundingDates.GroupCount();
				LegPaymentStreamCompoundingDates = new NoLegPaymentStreamCompoundingDates[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamCompoundingDates[i] = new();
					((IFixParser)LegPaymentStreamCompoundingDates[i]).Parse(viewNoLegPaymentStreamCompoundingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamCompoundingDates":
				{
					value = LegPaymentStreamCompoundingDates;
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
			LegPaymentStreamCompoundingDates = null;
		}
	}
}
