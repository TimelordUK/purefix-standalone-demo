using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseExpirationDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingOptionExerciseExpirationDates : IFixGroup
		{
			[TagDetails(Tag = 41857, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingOptionExerciseExpirationDate {get; set;}
			
			[TagDetails(Tag = 41858, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingOptionExerciseExpirationDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingOptionExerciseExpirationDate is not null) writer.WriteLocalDateOnly(41857, UnderlyingOptionExerciseExpirationDate.Value);
				if (UnderlyingOptionExerciseExpirationDateType is not null) writer.WriteWholeNumber(41858, UnderlyingOptionExerciseExpirationDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingOptionExerciseExpirationDate = view.GetDateOnly(41857);
				UnderlyingOptionExerciseExpirationDateType = view.GetInt32(41858);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingOptionExerciseExpirationDate":
					{
						value = UnderlyingOptionExerciseExpirationDate;
						break;
					}
					case "UnderlyingOptionExerciseExpirationDateType":
					{
						value = UnderlyingOptionExerciseExpirationDateType;
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
				UnderlyingOptionExerciseExpirationDate = null;
				UnderlyingOptionExerciseExpirationDateType = null;
			}
		}
		[Group(NoOfTag = 41856, Offset = 0, Required = false)]
		public NoUnderlyingOptionExerciseExpirationDates[]? UnderlyingOptionExerciseExpirationDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseExpirationDates is not null && UnderlyingOptionExerciseExpirationDates.Length != 0)
			{
				writer.WriteWholeNumber(41856, UnderlyingOptionExerciseExpirationDates.Length);
				for (int i = 0; i < UnderlyingOptionExerciseExpirationDates.Length; i++)
				{
					((IFixEncoder)UnderlyingOptionExerciseExpirationDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingOptionExerciseExpirationDates") is IMessageView viewNoUnderlyingOptionExerciseExpirationDates)
			{
				var count = viewNoUnderlyingOptionExerciseExpirationDates.GroupCount();
				UnderlyingOptionExerciseExpirationDates = new NoUnderlyingOptionExerciseExpirationDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingOptionExerciseExpirationDates[i] = new();
					((IFixParser)UnderlyingOptionExerciseExpirationDates[i]).Parse(viewNoUnderlyingOptionExerciseExpirationDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingOptionExerciseExpirationDates":
				{
					value = UnderlyingOptionExerciseExpirationDates;
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
			UnderlyingOptionExerciseExpirationDates = null;
		}
	}
}
