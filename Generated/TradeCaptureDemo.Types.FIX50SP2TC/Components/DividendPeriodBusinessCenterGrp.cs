using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendPeriodBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoDividendPeriodBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42295, Type = TagType.String, Offset = 0, Required = false)]
			public string? DividendPeriodBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DividendPeriodBusinessCenter is not null) writer.WriteString(42295, DividendPeriodBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DividendPeriodBusinessCenter = view.GetString(42295);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DividendPeriodBusinessCenter":
					{
						value = DividendPeriodBusinessCenter;
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
				DividendPeriodBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42294, Offset = 0, Required = false)]
		public NoDividendPeriodBusinessCenters[]? DividendPeriodBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendPeriodBusinessCenters is not null && DividendPeriodBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42294, DividendPeriodBusinessCenters.Length);
				for (int i = 0; i < DividendPeriodBusinessCenters.Length; i++)
				{
					((IFixEncoder)DividendPeriodBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDividendPeriodBusinessCenters") is IMessageView viewNoDividendPeriodBusinessCenters)
			{
				var count = viewNoDividendPeriodBusinessCenters.GroupCount();
				DividendPeriodBusinessCenters = new NoDividendPeriodBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					DividendPeriodBusinessCenters[i] = new();
					((IFixParser)DividendPeriodBusinessCenters[i]).Parse(viewNoDividendPeriodBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDividendPeriodBusinessCenters":
				{
					value = DividendPeriodBusinessCenters;
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
			DividendPeriodBusinessCenters = null;
		}
	}
}
