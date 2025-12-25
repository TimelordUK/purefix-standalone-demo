using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class PaymentScheduleRateSourceGrp : IFixComponent
	{
		public sealed partial class NoPaymentScheduleRateSources : IFixGroup
		{
			[TagDetails(Tag = 40869, Type = TagType.Int, Offset = 0, Required = false)]
			public int? PaymentScheduleRateSource {get; set;}
			
			[TagDetails(Tag = 40870, Type = TagType.Int, Offset = 1, Required = false)]
			public int? PaymentScheduleRateSourceType {get; set;}
			
			[TagDetails(Tag = 40871, Type = TagType.String, Offset = 2, Required = false)]
			public string? PaymentScheduleReferencePage {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (PaymentScheduleRateSource is not null) writer.WriteWholeNumber(40869, PaymentScheduleRateSource.Value);
				if (PaymentScheduleRateSourceType is not null) writer.WriteWholeNumber(40870, PaymentScheduleRateSourceType.Value);
				if (PaymentScheduleReferencePage is not null) writer.WriteString(40871, PaymentScheduleReferencePage);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				PaymentScheduleRateSource = view.GetInt32(40869);
				PaymentScheduleRateSourceType = view.GetInt32(40870);
				PaymentScheduleReferencePage = view.GetString(40871);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "PaymentScheduleRateSource":
					{
						value = PaymentScheduleRateSource;
						break;
					}
					case "PaymentScheduleRateSourceType":
					{
						value = PaymentScheduleRateSourceType;
						break;
					}
					case "PaymentScheduleReferencePage":
					{
						value = PaymentScheduleReferencePage;
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
				PaymentScheduleRateSource = null;
				PaymentScheduleRateSourceType = null;
				PaymentScheduleReferencePage = null;
			}
		}
		[Group(NoOfTag = 40868, Offset = 0, Required = false)]
		public NoPaymentScheduleRateSources[]? PaymentScheduleRateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (PaymentScheduleRateSources is not null && PaymentScheduleRateSources.Length != 0)
			{
				writer.WriteWholeNumber(40868, PaymentScheduleRateSources.Length);
				for (int i = 0; i < PaymentScheduleRateSources.Length; i++)
				{
					((IFixEncoder)PaymentScheduleRateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoPaymentScheduleRateSources") is IMessageView viewNoPaymentScheduleRateSources)
			{
				var count = viewNoPaymentScheduleRateSources.GroupCount();
				PaymentScheduleRateSources = new NoPaymentScheduleRateSources[count];
				for (int i = 0; i < count; i++)
				{
					PaymentScheduleRateSources[i] = new();
					((IFixParser)PaymentScheduleRateSources[i]).Parse(viewNoPaymentScheduleRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoPaymentScheduleRateSources":
				{
					value = PaymentScheduleRateSources;
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
			PaymentScheduleRateSources = null;
		}
	}
}
