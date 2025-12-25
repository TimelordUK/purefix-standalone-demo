using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingOptionExerciseDates : IFixGroup
		{
			[TagDetails(Tag = 41842, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingOptionExerciseDate {get; set;}
			
			[TagDetails(Tag = 41843, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingOptionExerciseDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingOptionExerciseDate is not null) writer.WriteLocalDateOnly(41842, UnderlyingOptionExerciseDate.Value);
				if (UnderlyingOptionExerciseDateType is not null) writer.WriteWholeNumber(41843, UnderlyingOptionExerciseDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingOptionExerciseDate = view.GetDateOnly(41842);
				UnderlyingOptionExerciseDateType = view.GetInt32(41843);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingOptionExerciseDate":
					{
						value = UnderlyingOptionExerciseDate;
						break;
					}
					case "UnderlyingOptionExerciseDateType":
					{
						value = UnderlyingOptionExerciseDateType;
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
				UnderlyingOptionExerciseDate = null;
				UnderlyingOptionExerciseDateType = null;
			}
		}
		[Group(NoOfTag = 41841, Offset = 0, Required = false)]
		public NoUnderlyingOptionExerciseDates[]? UnderlyingOptionExerciseDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseDates is not null && UnderlyingOptionExerciseDates.Length != 0)
			{
				writer.WriteWholeNumber(41841, UnderlyingOptionExerciseDates.Length);
				for (int i = 0; i < UnderlyingOptionExerciseDates.Length; i++)
				{
					((IFixEncoder)UnderlyingOptionExerciseDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingOptionExerciseDates") is IMessageView viewNoUnderlyingOptionExerciseDates)
			{
				var count = viewNoUnderlyingOptionExerciseDates.GroupCount();
				UnderlyingOptionExerciseDates = new NoUnderlyingOptionExerciseDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingOptionExerciseDates[i] = new();
					((IFixParser)UnderlyingOptionExerciseDates[i]).Parse(viewNoUnderlyingOptionExerciseDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingOptionExerciseDates":
				{
					value = UnderlyingOptionExerciseDates;
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
			UnderlyingOptionExerciseDates = null;
		}
	}
}
