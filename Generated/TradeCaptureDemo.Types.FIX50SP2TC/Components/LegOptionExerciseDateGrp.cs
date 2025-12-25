using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseDateGrp : IFixComponent
	{
		public sealed partial class NoLegOptionExerciseDates : IFixGroup
		{
			[TagDetails(Tag = 41513, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegOptionExerciseDate {get; set;}
			
			[TagDetails(Tag = 41514, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegOptionExerciseDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegOptionExerciseDate is not null) writer.WriteLocalDateOnly(41513, LegOptionExerciseDate.Value);
				if (LegOptionExerciseDateType is not null) writer.WriteWholeNumber(41514, LegOptionExerciseDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegOptionExerciseDate = view.GetDateOnly(41513);
				LegOptionExerciseDateType = view.GetInt32(41514);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegOptionExerciseDate":
					{
						value = LegOptionExerciseDate;
						break;
					}
					case "LegOptionExerciseDateType":
					{
						value = LegOptionExerciseDateType;
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
				LegOptionExerciseDate = null;
				LegOptionExerciseDateType = null;
			}
		}
		[Group(NoOfTag = 41512, Offset = 0, Required = false)]
		public NoLegOptionExerciseDates[]? LegOptionExerciseDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseDates is not null && LegOptionExerciseDates.Length != 0)
			{
				writer.WriteWholeNumber(41512, LegOptionExerciseDates.Length);
				for (int i = 0; i < LegOptionExerciseDates.Length; i++)
				{
					((IFixEncoder)LegOptionExerciseDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegOptionExerciseDates") is IMessageView viewNoLegOptionExerciseDates)
			{
				var count = viewNoLegOptionExerciseDates.GroupCount();
				LegOptionExerciseDates = new NoLegOptionExerciseDates[count];
				for (int i = 0; i < count; i++)
				{
					LegOptionExerciseDates[i] = new();
					((IFixParser)LegOptionExerciseDates[i]).Parse(viewNoLegOptionExerciseDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegOptionExerciseDates":
				{
					value = LegOptionExerciseDates;
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
			LegOptionExerciseDates = null;
		}
	}
}
