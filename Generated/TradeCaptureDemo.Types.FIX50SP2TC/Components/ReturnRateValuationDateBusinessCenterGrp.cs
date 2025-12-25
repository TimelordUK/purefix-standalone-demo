using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRateValuationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoReturnRateValuationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42771, Type = TagType.String, Offset = 0, Required = false)]
			public string? ReturnRateValuationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRateValuationDateBusinessCenter is not null) writer.WriteString(42771, ReturnRateValuationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRateValuationDateBusinessCenter = view.GetString(42771);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRateValuationDateBusinessCenter":
					{
						value = ReturnRateValuationDateBusinessCenter;
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
				ReturnRateValuationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42770, Offset = 0, Required = false)]
		public NoReturnRateValuationDateBusinessCenters[]? ReturnRateValuationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRateValuationDateBusinessCenters is not null && ReturnRateValuationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42770, ReturnRateValuationDateBusinessCenters.Length);
				for (int i = 0; i < ReturnRateValuationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ReturnRateValuationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRateValuationDateBusinessCenters") is IMessageView viewNoReturnRateValuationDateBusinessCenters)
			{
				var count = viewNoReturnRateValuationDateBusinessCenters.GroupCount();
				ReturnRateValuationDateBusinessCenters = new NoReturnRateValuationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRateValuationDateBusinessCenters[i] = new();
					((IFixParser)ReturnRateValuationDateBusinessCenters[i]).Parse(viewNoReturnRateValuationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRateValuationDateBusinessCenters":
				{
					value = ReturnRateValuationDateBusinessCenters;
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
			ReturnRateValuationDateBusinessCenters = null;
		}
	}
}
