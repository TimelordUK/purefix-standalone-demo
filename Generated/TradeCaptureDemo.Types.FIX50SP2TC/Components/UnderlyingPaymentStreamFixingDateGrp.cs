using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFixingDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamFixingDates : IFixGroup
		{
			[TagDetails(Tag = 42956, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingPaymentStreamFixingDate {get; set;}
			
			[TagDetails(Tag = 42957, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStreamFixingDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamFixingDate is not null) writer.WriteLocalDateOnly(42956, UnderlyingPaymentStreamFixingDate.Value);
				if (UnderlyingPaymentStreamFixingDateType is not null) writer.WriteWholeNumber(42957, UnderlyingPaymentStreamFixingDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamFixingDate = view.GetDateOnly(42956);
				UnderlyingPaymentStreamFixingDateType = view.GetInt32(42957);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamFixingDate":
					{
						value = UnderlyingPaymentStreamFixingDate;
						break;
					}
					case "UnderlyingPaymentStreamFixingDateType":
					{
						value = UnderlyingPaymentStreamFixingDateType;
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
				UnderlyingPaymentStreamFixingDate = null;
				UnderlyingPaymentStreamFixingDateType = null;
			}
		}
		[Group(NoOfTag = 42955, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamFixingDates[]? UnderlyingPaymentStreamFixingDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFixingDates is not null && UnderlyingPaymentStreamFixingDates.Length != 0)
			{
				writer.WriteWholeNumber(42955, UnderlyingPaymentStreamFixingDates.Length);
				for (int i = 0; i < UnderlyingPaymentStreamFixingDates.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamFixingDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamFixingDates") is IMessageView viewNoUnderlyingPaymentStreamFixingDates)
			{
				var count = viewNoUnderlyingPaymentStreamFixingDates.GroupCount();
				UnderlyingPaymentStreamFixingDates = new NoUnderlyingPaymentStreamFixingDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamFixingDates[i] = new();
					((IFixParser)UnderlyingPaymentStreamFixingDates[i]).Parse(viewNoUnderlyingPaymentStreamFixingDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamFixingDates":
				{
					value = UnderlyingPaymentStreamFixingDates;
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
			UnderlyingPaymentStreamFixingDates = null;
		}
	}
}
