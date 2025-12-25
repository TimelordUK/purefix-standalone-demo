using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDividendPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42883, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDividendPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDividendPeriodBusinessCenter is not null) writer.WriteString(42883, UnderlyingDividendPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDividendPeriodBusinessCenter = view.GetString(42883);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDividendPeriodBusinessCenter":
					{
						value = UnderlyingDividendPeriodBusinessCenter;
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
				UnderlyingDividendPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42882, Offset = 0, Required = false)]
		public NoUnderlyingDividendPeriodBusinessCenters[]? UnderlyingDividendPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendPeriodBusinessCenters is not null && UnderlyingDividendPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42882, UnderlyingDividendPeriodBusinessCenters.Length);
				for (int i = 0; i < UnderlyingDividendPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingDividendPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDividendPeriodBusinessCenters") is IMessageView viewNoUnderlyingDividendPeriodBusinessCenters)
			{
				var count = viewNoUnderlyingDividendPeriodBusinessCenters.GroupCount();
				UnderlyingDividendPeriodBusinessCenters = new NoUnderlyingDividendPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDividendPeriodBusinessCenters[i] = new();
					((IFixParser)UnderlyingDividendPeriodBusinessCenters[i]).Parse(viewNoUnderlyingDividendPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDividendPeriodBusinessCenters":
				{
					value = UnderlyingDividendPeriodBusinessCenters;
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
			UnderlyingDividendPeriodBusinessCenters = null;
		}
	}
}
