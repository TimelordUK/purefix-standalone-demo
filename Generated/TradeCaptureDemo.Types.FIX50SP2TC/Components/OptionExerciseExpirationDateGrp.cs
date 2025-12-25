using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseExpirationDateGrp : IFixComponent
	{
		public sealed partial class NoOptionExerciseExpirationDates : IFixGroup
		{
			[TagDetails(Tag = 41153, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? OptionExerciseExpirationDate {get; set;}
			
			[TagDetails(Tag = 41154, Type = TagType.Int, Offset = 1, Required = false)]
			public int? OptionExerciseExpirationDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OptionExerciseExpirationDate is not null) writer.WriteLocalDateOnly(41153, OptionExerciseExpirationDate.Value);
				if (OptionExerciseExpirationDateType is not null) writer.WriteWholeNumber(41154, OptionExerciseExpirationDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OptionExerciseExpirationDate = view.GetDateOnly(41153);
				OptionExerciseExpirationDateType = view.GetInt32(41154);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OptionExerciseExpirationDate":
					{
						value = OptionExerciseExpirationDate;
						break;
					}
					case "OptionExerciseExpirationDateType":
					{
						value = OptionExerciseExpirationDateType;
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
				OptionExerciseExpirationDate = null;
				OptionExerciseExpirationDateType = null;
			}
		}
		[Group(NoOfTag = 41152, Offset = 0, Required = false)]
		public NoOptionExerciseExpirationDates[]? OptionExerciseExpirationDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseExpirationDates is not null && OptionExerciseExpirationDates.Length != 0)
			{
				writer.WriteWholeNumber(41152, OptionExerciseExpirationDates.Length);
				for (int i = 0; i < OptionExerciseExpirationDates.Length; i++)
				{
					((IFixEncoder)OptionExerciseExpirationDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOptionExerciseExpirationDates") is IMessageView viewNoOptionExerciseExpirationDates)
			{
				var count = viewNoOptionExerciseExpirationDates.GroupCount();
				OptionExerciseExpirationDates = new NoOptionExerciseExpirationDates[count];
				for (int i = 0; i < count; i++)
				{
					OptionExerciseExpirationDates[i] = new();
					((IFixParser)OptionExerciseExpirationDates[i]).Parse(viewNoOptionExerciseExpirationDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOptionExerciseExpirationDates":
				{
					value = OptionExerciseExpirationDates;
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
			OptionExerciseExpirationDates = null;
		}
	}
}
