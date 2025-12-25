using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingRateSpreadStepGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingRateSpreadSteps : IFixGroup
		{
			[TagDetails(Tag = 43006, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingRateSpreadStepDate {get; set;}
			
			[TagDetails(Tag = 43007, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingRateSpreadStepValue {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingRateSpreadStepDate is not null) writer.WriteLocalDateOnly(43006, UnderlyingRateSpreadStepDate.Value);
				if (UnderlyingRateSpreadStepValue is not null) writer.WriteNumber(43007, UnderlyingRateSpreadStepValue.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingRateSpreadStepDate = view.GetDateOnly(43006);
				UnderlyingRateSpreadStepValue = view.GetDouble(43007);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingRateSpreadStepDate":
					{
						value = UnderlyingRateSpreadStepDate;
						break;
					}
					case "UnderlyingRateSpreadStepValue":
					{
						value = UnderlyingRateSpreadStepValue;
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
				UnderlyingRateSpreadStepDate = null;
				UnderlyingRateSpreadStepValue = null;
			}
		}
		[Group(NoOfTag = 43005, Offset = 0, Required = false)]
		public NoUnderlyingRateSpreadSteps[]? UnderlyingRateSpreadSteps {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingRateSpreadSteps is not null && UnderlyingRateSpreadSteps.Length != 0)
			{
				writer.WriteWholeNumber(43005, UnderlyingRateSpreadSteps.Length);
				for (int i = 0; i < UnderlyingRateSpreadSteps.Length; i++)
				{
					((IFixEncoder)UnderlyingRateSpreadSteps[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingRateSpreadSteps") is IMessageView viewNoUnderlyingRateSpreadSteps)
			{
				var count = viewNoUnderlyingRateSpreadSteps.GroupCount();
				UnderlyingRateSpreadSteps = new NoUnderlyingRateSpreadSteps[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingRateSpreadSteps[i] = new();
					((IFixParser)UnderlyingRateSpreadSteps[i]).Parse(viewNoUnderlyingRateSpreadSteps.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingRateSpreadSteps":
				{
					value = UnderlyingRateSpreadSteps;
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
			UnderlyingRateSpreadSteps = null;
		}
	}
}
