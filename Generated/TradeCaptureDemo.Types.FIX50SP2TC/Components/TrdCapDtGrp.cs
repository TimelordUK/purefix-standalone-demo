using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class TrdCapDtGrp : IFixComponent
	{
		public sealed partial class NoDates : IFixGroup
		{
			[TagDetails(Tag = 75, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? TradeDate {get; set;}
			
			[TagDetails(Tag = 779, Type = TagType.UtcTimestamp, Offset = 1, Required = false)]
			public DateTime? LastUpdateTime {get; set;}
			
			[TagDetails(Tag = 60, Type = TagType.UtcTimestamp, Offset = 2, Required = false)]
			public DateTime? TransactTime {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (TradeDate is not null) writer.WriteLocalDateOnly(75, TradeDate.Value);
				if (LastUpdateTime is not null) writer.WriteUtcTimeStamp(779, LastUpdateTime.Value);
				if (TransactTime is not null) writer.WriteUtcTimeStamp(60, TransactTime.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				TradeDate = view.GetDateOnly(75);
				LastUpdateTime = view.GetDateTime(779);
				TransactTime = view.GetDateTime(60);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "TradeDate":
					{
						value = TradeDate;
						break;
					}
					case "LastUpdateTime":
					{
						value = LastUpdateTime;
						break;
					}
					case "TransactTime":
					{
						value = TransactTime;
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
				TradeDate = null;
				LastUpdateTime = null;
				TransactTime = null;
			}
		}
		[Group(NoOfTag = 580, Offset = 0, Required = false)]
		public NoDates[]? Dates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Dates is not null && Dates.Length != 0)
			{
				writer.WriteWholeNumber(580, Dates.Length);
				for (int i = 0; i < Dates.Length; i++)
				{
					((IFixEncoder)Dates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDates") is IMessageView viewNoDates)
			{
				var count = viewNoDates.GroupCount();
				Dates = new NoDates[count];
				for (int i = 0; i < count; i++)
				{
					Dates[i] = new();
					((IFixParser)Dates[i]).Parse(viewNoDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDates":
				{
					value = Dates;
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
			Dates = null;
		}
	}
}
