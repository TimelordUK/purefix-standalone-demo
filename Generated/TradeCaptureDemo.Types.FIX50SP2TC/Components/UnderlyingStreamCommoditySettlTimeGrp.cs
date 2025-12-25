using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommoditySettlTimeGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCommoditySettlTimes : IFixGroup
		{
			[TagDetails(Tag = 42000, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamCommoditySettlStart {get; set;}
			
			[TagDetails(Tag = 42001, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingStreamCommoditySettlEnd {get; set;}
			
			[TagDetails(Tag = 41936, Type = TagType.Int, Offset = 2, Required = false)]
			public int? UnderlyingStreamCommoditySettlTimeType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCommoditySettlStart is not null) writer.WriteString(42000, UnderlyingStreamCommoditySettlStart);
				if (UnderlyingStreamCommoditySettlEnd is not null) writer.WriteString(42001, UnderlyingStreamCommoditySettlEnd);
				if (UnderlyingStreamCommoditySettlTimeType is not null) writer.WriteWholeNumber(41936, UnderlyingStreamCommoditySettlTimeType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCommoditySettlStart = view.GetString(42000);
				UnderlyingStreamCommoditySettlEnd = view.GetString(42001);
				UnderlyingStreamCommoditySettlTimeType = view.GetInt32(41936);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCommoditySettlStart":
					{
						value = UnderlyingStreamCommoditySettlStart;
						break;
					}
					case "UnderlyingStreamCommoditySettlEnd":
					{
						value = UnderlyingStreamCommoditySettlEnd;
						break;
					}
					case "UnderlyingStreamCommoditySettlTimeType":
					{
						value = UnderlyingStreamCommoditySettlTimeType;
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
				UnderlyingStreamCommoditySettlStart = null;
				UnderlyingStreamCommoditySettlEnd = null;
				UnderlyingStreamCommoditySettlTimeType = null;
			}
		}
		[Group(NoOfTag = 41999, Offset = 0, Required = false)]
		public NoUnderlyingStreamCommoditySettlTimes[]? UnderlyingStreamCommoditySettlTimes {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommoditySettlTimes is not null && UnderlyingStreamCommoditySettlTimes.Length != 0)
			{
				writer.WriteWholeNumber(41999, UnderlyingStreamCommoditySettlTimes.Length);
				for (int i = 0; i < UnderlyingStreamCommoditySettlTimes.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCommoditySettlTimes[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCommoditySettlTimes") is IMessageView viewNoUnderlyingStreamCommoditySettlTimes)
			{
				var count = viewNoUnderlyingStreamCommoditySettlTimes.GroupCount();
				UnderlyingStreamCommoditySettlTimes = new NoUnderlyingStreamCommoditySettlTimes[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCommoditySettlTimes[i] = new();
					((IFixParser)UnderlyingStreamCommoditySettlTimes[i]).Parse(viewNoUnderlyingStreamCommoditySettlTimes.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCommoditySettlTimes":
				{
					value = UnderlyingStreamCommoditySettlTimes;
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
			UnderlyingStreamCommoditySettlTimes = null;
		}
	}
}
