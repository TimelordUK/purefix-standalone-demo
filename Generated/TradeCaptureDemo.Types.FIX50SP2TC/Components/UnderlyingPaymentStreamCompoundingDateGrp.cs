using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamCompoundingDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamCompoundingDates : IFixGroup
		{
			[TagDetails(Tag = 42902, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingPaymentStreamCompoundingDate {get; set;}
			
			[TagDetails(Tag = 42903, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStreamCompoundingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamCompoundingDate is not null) writer.WriteLocalDateOnly(42902, UnderlyingPaymentStreamCompoundingDate.Value);
				if (UnderlyingPaymentStreamCompoundingDateType is not null) writer.WriteWholeNumber(42903, UnderlyingPaymentStreamCompoundingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamCompoundingDate = view.GetDateOnly(42902);
				UnderlyingPaymentStreamCompoundingDateType = view.GetInt32(42903);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamCompoundingDate":
					{
						value = UnderlyingPaymentStreamCompoundingDate;
						break;
					}
					case "UnderlyingPaymentStreamCompoundingDateType":
					{
						value = UnderlyingPaymentStreamCompoundingDateType;
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
				UnderlyingPaymentStreamCompoundingDate = null;
				UnderlyingPaymentStreamCompoundingDateType = null;
			}
		}
		[Group(NoOfTag = 42901, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamCompoundingDates[]? UnderlyingPaymentStreamCompoundingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamCompoundingDates is not null && UnderlyingPaymentStreamCompoundingDates.Length != 0)
			{
				writer.WriteWholeNumber(42901, UnderlyingPaymentStreamCompoundingDates.Length);
				for (int i = 0; i < UnderlyingPaymentStreamCompoundingDates.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamCompoundingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamCompoundingDates") is IMessageView viewNoUnderlyingPaymentStreamCompoundingDates)
			{
				var count = viewNoUnderlyingPaymentStreamCompoundingDates.GroupCount();
				UnderlyingPaymentStreamCompoundingDates = new NoUnderlyingPaymentStreamCompoundingDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamCompoundingDates[i] = new();
					((IFixParser)UnderlyingPaymentStreamCompoundingDates[i]).Parse(viewNoUnderlyingPaymentStreamCompoundingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamCompoundingDates":
				{
					value = UnderlyingPaymentStreamCompoundingDates;
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
			UnderlyingPaymentStreamCompoundingDates = null;
		}
	}
}
