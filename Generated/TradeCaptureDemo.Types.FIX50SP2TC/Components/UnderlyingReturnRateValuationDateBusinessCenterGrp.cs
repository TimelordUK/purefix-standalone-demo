using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingReturnRateValuationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingReturnRateValuationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 43070, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingReturnRateValuationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingReturnRateValuationDateBusinessCenter is not null) writer.WriteString(43070, UnderlyingReturnRateValuationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingReturnRateValuationDateBusinessCenter = view.GetString(43070);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingReturnRateValuationDateBusinessCenter":
					{
						value = UnderlyingReturnRateValuationDateBusinessCenter;
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
				UnderlyingReturnRateValuationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 43069, Offset = 0, Required = false)]
		public NoUnderlyingReturnRateValuationDateBusinessCenters[]? UnderlyingReturnRateValuationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingReturnRateValuationDateBusinessCenters is not null && UnderlyingReturnRateValuationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(43069, UnderlyingReturnRateValuationDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingReturnRateValuationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingReturnRateValuationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingReturnRateValuationDateBusinessCenters") is IMessageView viewNoUnderlyingReturnRateValuationDateBusinessCenters)
			{
				var count = viewNoUnderlyingReturnRateValuationDateBusinessCenters.GroupCount();
				UnderlyingReturnRateValuationDateBusinessCenters = new NoUnderlyingReturnRateValuationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingReturnRateValuationDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingReturnRateValuationDateBusinessCenters[i]).Parse(viewNoUnderlyingReturnRateValuationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingReturnRateValuationDateBusinessCenters":
				{
					value = UnderlyingReturnRateValuationDateBusinessCenters;
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
			UnderlyingReturnRateValuationDateBusinessCenters = null;
		}
	}
}
