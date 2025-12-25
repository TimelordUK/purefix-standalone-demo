using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AveragePriceDetail : IFixComponent
	{
		[TagDetails(Tag = 2763, Type = TagType.Int, Offset = 0, Required = false)]
		public int? AveragePriceType {get; set;}
		
		[TagDetails(Tag = 2764, Type = TagType.UtcTimestamp, Offset = 1, Required = false)]
		public DateTime? AveragePriceStartTime {get; set;}
		
		[TagDetails(Tag = 2765, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
		public DateTime? AveragePriceEndTime {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AveragePriceType is not null) writer.WriteWholeNumber(2763, AveragePriceType.Value);
			if (AveragePriceStartTime is not null) writer.WriteUtcTimeStamp(2764, AveragePriceStartTime.Value);
			if (AveragePriceEndTime is not null) writer.WriteUtcTimeStamp(2765, AveragePriceEndTime.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			AveragePriceType = view.GetInt32(2763);
			AveragePriceStartTime = view.GetDateTime(2764);
			AveragePriceEndTime = view.GetDateTime(2765);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "AveragePriceType":
				{
					value = AveragePriceType;
					break;
				}
				case "AveragePriceStartTime":
				{
					value = AveragePriceStartTime;
					break;
				}
				case "AveragePriceEndTime":
				{
					value = AveragePriceEndTime;
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
			AveragePriceType = null;
			AveragePriceStartTime = null;
			AveragePriceEndTime = null;
		}
	}
}
