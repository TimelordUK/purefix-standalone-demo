using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendPaymentGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDividendPayments : IFixGroup
		{
			[TagDetails(Tag = 42856, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingDividendPaymentDate {get; set;}
			
			[TagDetails(Tag = 42857, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingDividendPaymentAmount {get; set;}
			
			[TagDetails(Tag = 42858, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingDividendPaymentCurrency {get; set;}
			
			[TagDetails(Tag = 42859, Type = TagType.Float, Offset = 3, Required = false)]
			public double? UnderlyingDividendAccruedInterest {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDividendPaymentDate is not null) writer.WriteLocalDateOnly(42856, UnderlyingDividendPaymentDate.Value);
				if (UnderlyingDividendPaymentAmount is not null) writer.WriteNumber(42857, UnderlyingDividendPaymentAmount.Value);
				if (UnderlyingDividendPaymentCurrency is not null) writer.WriteString(42858, UnderlyingDividendPaymentCurrency);
				if (UnderlyingDividendAccruedInterest is not null) writer.WriteNumber(42859, UnderlyingDividendAccruedInterest.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDividendPaymentDate = view.GetDateOnly(42856);
				UnderlyingDividendPaymentAmount = view.GetDouble(42857);
				UnderlyingDividendPaymentCurrency = view.GetString(42858);
				UnderlyingDividendAccruedInterest = view.GetDouble(42859);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDividendPaymentDate":
					{
						value = UnderlyingDividendPaymentDate;
						break;
					}
					case "UnderlyingDividendPaymentAmount":
					{
						value = UnderlyingDividendPaymentAmount;
						break;
					}
					case "UnderlyingDividendPaymentCurrency":
					{
						value = UnderlyingDividendPaymentCurrency;
						break;
					}
					case "UnderlyingDividendAccruedInterest":
					{
						value = UnderlyingDividendAccruedInterest;
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
				UnderlyingDividendPaymentDate = null;
				UnderlyingDividendPaymentAmount = null;
				UnderlyingDividendPaymentCurrency = null;
				UnderlyingDividendAccruedInterest = null;
			}
		}
		[Group(NoOfTag = 42855, Offset = 0, Required = false)]
		public NoUnderlyingDividendPayments[]? UnderlyingDividendPayments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendPayments is not null && UnderlyingDividendPayments.Length != 0)
			{
				writer.WriteWholeNumber(42855, UnderlyingDividendPayments.Length);
				for (int i = 0; i < UnderlyingDividendPayments.Length; i++)
				{
					((IFixEncoder)UnderlyingDividendPayments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDividendPayments") is IMessageView viewNoUnderlyingDividendPayments)
			{
				var count = viewNoUnderlyingDividendPayments.GroupCount();
				UnderlyingDividendPayments = new NoUnderlyingDividendPayments[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDividendPayments[i] = new();
					((IFixParser)UnderlyingDividendPayments[i]).Parse(viewNoUnderlyingDividendPayments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDividendPayments":
				{
					value = UnderlyingDividendPayments;
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
			UnderlyingDividendPayments = null;
		}
	}
}
