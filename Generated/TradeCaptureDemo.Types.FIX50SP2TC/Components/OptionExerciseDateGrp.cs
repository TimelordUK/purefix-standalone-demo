using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseDateGrp : IFixComponent
	{
		public sealed partial class NoOptionExerciseDates : IFixGroup
		{
			[TagDetails(Tag = 41138, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? OptionExerciseDate {get; set;}
			
			[TagDetails(Tag = 41139, Type = TagType.Int, Offset = 1, Required = false)]
			public int? OptionExerciseDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OptionExerciseDate is not null) writer.WriteLocalDateOnly(41138, OptionExerciseDate.Value);
				if (OptionExerciseDateType is not null) writer.WriteWholeNumber(41139, OptionExerciseDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OptionExerciseDate = view.GetDateOnly(41138);
				OptionExerciseDateType = view.GetInt32(41139);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OptionExerciseDate":
					{
						value = OptionExerciseDate;
						break;
					}
					case "OptionExerciseDateType":
					{
						value = OptionExerciseDateType;
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
				OptionExerciseDate = null;
				OptionExerciseDateType = null;
			}
		}
		[Group(NoOfTag = 41137, Offset = 0, Required = false)]
		public NoOptionExerciseDates[]? OptionExerciseDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseDates is not null && OptionExerciseDates.Length != 0)
			{
				writer.WriteWholeNumber(41137, OptionExerciseDates.Length);
				for (int i = 0; i < OptionExerciseDates.Length; i++)
				{
					((IFixEncoder)OptionExerciseDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOptionExerciseDates") is IMessageView viewNoOptionExerciseDates)
			{
				var count = viewNoOptionExerciseDates.GroupCount();
				OptionExerciseDates = new NoOptionExerciseDates[count];
				for (int i = 0; i < count; i++)
				{
					OptionExerciseDates[i] = new();
					((IFixParser)OptionExerciseDates[i]).Parse(viewNoOptionExerciseDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOptionExerciseDates":
				{
					value = OptionExerciseDates;
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
			OptionExerciseDates = null;
		}
	}
}
