using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCalculationPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCalculationPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40557, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamCalculationPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCalculationPeriodBusinessCenter is not null) writer.WriteString(40557, UnderlyingStreamCalculationPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCalculationPeriodBusinessCenter = view.GetString(40557);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCalculationPeriodBusinessCenter":
					{
						value = UnderlyingStreamCalculationPeriodBusinessCenter;
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
				UnderlyingStreamCalculationPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40973, Offset = 0, Required = false)]
		public NoUnderlyingStreamCalculationPeriodBusinessCenters[]? UnderlyingStreamCalculationPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCalculationPeriodBusinessCenters is not null && UnderlyingStreamCalculationPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40973, UnderlyingStreamCalculationPeriodBusinessCenters.Length);
				for (int i = 0; i < UnderlyingStreamCalculationPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCalculationPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCalculationPeriodBusinessCenters") is IMessageView viewNoUnderlyingStreamCalculationPeriodBusinessCenters)
			{
				var count = viewNoUnderlyingStreamCalculationPeriodBusinessCenters.GroupCount();
				UnderlyingStreamCalculationPeriodBusinessCenters = new NoUnderlyingStreamCalculationPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCalculationPeriodBusinessCenters[i] = new();
					((IFixParser)UnderlyingStreamCalculationPeriodBusinessCenters[i]).Parse(viewNoUnderlyingStreamCalculationPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCalculationPeriodBusinessCenters":
				{
					value = UnderlyingStreamCalculationPeriodBusinessCenters;
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
			UnderlyingStreamCalculationPeriodBusinessCenters = null;
		}
	}
}
