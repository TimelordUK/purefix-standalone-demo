using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentScheduleRateSourceGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentScheduleRateSources : IFixGroup
		{
			[TagDetails(Tag = 40705, Type = TagType.Int, Offset = 0, Required = false)]
			public int? UnderlyingPaymentScheduleRateSource {get; set;}
			
			[TagDetails(Tag = 40706, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentScheduleRateSourceType {get; set;}
			
			[TagDetails(Tag = 40707, Type = TagType.String, Offset = 2, Required = false)]
			public string? UnderlyingPaymentScheduleReferencePage {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentScheduleRateSource is not null) writer.WriteWholeNumber(40705, UnderlyingPaymentScheduleRateSource.Value);
				if (UnderlyingPaymentScheduleRateSourceType is not null) writer.WriteWholeNumber(40706, UnderlyingPaymentScheduleRateSourceType.Value);
				if (UnderlyingPaymentScheduleReferencePage is not null) writer.WriteString(40707, UnderlyingPaymentScheduleReferencePage);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentScheduleRateSource = view.GetInt32(40705);
				UnderlyingPaymentScheduleRateSourceType = view.GetInt32(40706);
				UnderlyingPaymentScheduleReferencePage = view.GetString(40707);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentScheduleRateSource":
					{
						value = UnderlyingPaymentScheduleRateSource;
						break;
					}
					case "UnderlyingPaymentScheduleRateSourceType":
					{
						value = UnderlyingPaymentScheduleRateSourceType;
						break;
					}
					case "UnderlyingPaymentScheduleReferencePage":
					{
						value = UnderlyingPaymentScheduleReferencePage;
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
				UnderlyingPaymentScheduleRateSource = null;
				UnderlyingPaymentScheduleRateSourceType = null;
				UnderlyingPaymentScheduleReferencePage = null;
			}
		}
		[Group(NoOfTag = 40704, Offset = 0, Required = false)]
		public NoUnderlyingPaymentScheduleRateSources[]? UnderlyingPaymentScheduleRateSources {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentScheduleRateSources is not null && UnderlyingPaymentScheduleRateSources.Length != 0)
			{
				writer.WriteWholeNumber(40704, UnderlyingPaymentScheduleRateSources.Length);
				for (int i = 0; i < UnderlyingPaymentScheduleRateSources.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentScheduleRateSources[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentScheduleRateSources") is IMessageView viewNoUnderlyingPaymentScheduleRateSources)
			{
				var count = viewNoUnderlyingPaymentScheduleRateSources.GroupCount();
				UnderlyingPaymentScheduleRateSources = new NoUnderlyingPaymentScheduleRateSources[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentScheduleRateSources[i] = new();
					((IFixParser)UnderlyingPaymentScheduleRateSources[i]).Parse(viewNoUnderlyingPaymentScheduleRateSources.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentScheduleRateSources":
				{
					value = UnderlyingPaymentScheduleRateSources;
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
			UnderlyingPaymentScheduleRateSources = null;
		}
	}
}
