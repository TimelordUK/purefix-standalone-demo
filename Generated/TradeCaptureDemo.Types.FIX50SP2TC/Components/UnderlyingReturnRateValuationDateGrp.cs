using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingReturnRateValuationDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingReturnRateValuationDates : IFixGroup
		{
			[TagDetails(Tag = 43072, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingReturnRateValuationDate {get; set;}
			
			[TagDetails(Tag = 43073, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingReturnRateValuationDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingReturnRateValuationDate is not null) writer.WriteLocalDateOnly(43072, UnderlyingReturnRateValuationDate.Value);
				if (UnderlyingReturnRateValuationDateType is not null) writer.WriteWholeNumber(43073, UnderlyingReturnRateValuationDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingReturnRateValuationDate = view.GetDateOnly(43072);
				UnderlyingReturnRateValuationDateType = view.GetInt32(43073);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingReturnRateValuationDate":
					{
						value = UnderlyingReturnRateValuationDate;
						break;
					}
					case "UnderlyingReturnRateValuationDateType":
					{
						value = UnderlyingReturnRateValuationDateType;
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
				UnderlyingReturnRateValuationDate = null;
				UnderlyingReturnRateValuationDateType = null;
			}
		}
		[Group(NoOfTag = 43071, Offset = 0, Required = false)]
		public NoUnderlyingReturnRateValuationDates[]? UnderlyingReturnRateValuationDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingReturnRateValuationDates is not null && UnderlyingReturnRateValuationDates.Length != 0)
			{
				writer.WriteWholeNumber(43071, UnderlyingReturnRateValuationDates.Length);
				for (int i = 0; i < UnderlyingReturnRateValuationDates.Length; i++)
				{
					((IFixEncoder)UnderlyingReturnRateValuationDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingReturnRateValuationDates") is IMessageView viewNoUnderlyingReturnRateValuationDates)
			{
				var count = viewNoUnderlyingReturnRateValuationDates.GroupCount();
				UnderlyingReturnRateValuationDates = new NoUnderlyingReturnRateValuationDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingReturnRateValuationDates[i] = new();
					((IFixParser)UnderlyingReturnRateValuationDates[i]).Parse(viewNoUnderlyingReturnRateValuationDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingReturnRateValuationDates":
				{
					value = UnderlyingReturnRateValuationDates;
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
			UnderlyingReturnRateValuationDates = null;
		}
	}
}
