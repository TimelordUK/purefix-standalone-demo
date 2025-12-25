using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ReturnRateValuationDateGrp : IFixComponent
	{
		public sealed partial class NoReturnRateValuationDates : IFixGroup
		{
			[TagDetails(Tag = 42773, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? ReturnRateValuationDate {get; set;}
			
			[TagDetails(Tag = 42774, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ReturnRateValuationDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ReturnRateValuationDate is not null) writer.WriteLocalDateOnly(42773, ReturnRateValuationDate.Value);
				if (ReturnRateValuationDateType is not null) writer.WriteWholeNumber(42774, ReturnRateValuationDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ReturnRateValuationDate = view.GetDateOnly(42773);
				ReturnRateValuationDateType = view.GetInt32(42774);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ReturnRateValuationDate":
					{
						value = ReturnRateValuationDate;
						break;
					}
					case "ReturnRateValuationDateType":
					{
						value = ReturnRateValuationDateType;
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
				ReturnRateValuationDate = null;
				ReturnRateValuationDateType = null;
			}
		}
		[Group(NoOfTag = 42772, Offset = 0, Required = false)]
		public NoReturnRateValuationDates[]? ReturnRateValuationDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ReturnRateValuationDates is not null && ReturnRateValuationDates.Length != 0)
			{
				writer.WriteWholeNumber(42772, ReturnRateValuationDates.Length);
				for (int i = 0; i < ReturnRateValuationDates.Length; i++)
				{
					((IFixEncoder)ReturnRateValuationDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoReturnRateValuationDates") is IMessageView viewNoReturnRateValuationDates)
			{
				var count = viewNoReturnRateValuationDates.GroupCount();
				ReturnRateValuationDates = new NoReturnRateValuationDates[count];
				for (int i = 0; i < count; i++)
				{
					ReturnRateValuationDates[i] = new();
					((IFixParser)ReturnRateValuationDates[i]).Parse(viewNoReturnRateValuationDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoReturnRateValuationDates":
				{
					value = ReturnRateValuationDates;
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
			ReturnRateValuationDates = null;
		}
	}
}
