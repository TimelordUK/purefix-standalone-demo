using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseExpirationDateGrp : IFixComponent
	{
		public sealed partial class NoLegOptionExerciseExpirationDates : IFixGroup
		{
			[TagDetails(Tag = 41528, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegOptionExerciseExpirationDate {get; set;}
			
			[TagDetails(Tag = 41529, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegOptionExerciseExpirationDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegOptionExerciseExpirationDate is not null) writer.WriteLocalDateOnly(41528, LegOptionExerciseExpirationDate.Value);
				if (LegOptionExerciseExpirationDateType is not null) writer.WriteWholeNumber(41529, LegOptionExerciseExpirationDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegOptionExerciseExpirationDate = view.GetDateOnly(41528);
				LegOptionExerciseExpirationDateType = view.GetInt32(41529);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegOptionExerciseExpirationDate":
					{
						value = LegOptionExerciseExpirationDate;
						break;
					}
					case "LegOptionExerciseExpirationDateType":
					{
						value = LegOptionExerciseExpirationDateType;
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
				LegOptionExerciseExpirationDate = null;
				LegOptionExerciseExpirationDateType = null;
			}
		}
		[Group(NoOfTag = 41527, Offset = 0, Required = false)]
		public NoLegOptionExerciseExpirationDates[]? LegOptionExerciseExpirationDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseExpirationDates is not null && LegOptionExerciseExpirationDates.Length != 0)
			{
				writer.WriteWholeNumber(41527, LegOptionExerciseExpirationDates.Length);
				for (int i = 0; i < LegOptionExerciseExpirationDates.Length; i++)
				{
					((IFixEncoder)LegOptionExerciseExpirationDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegOptionExerciseExpirationDates") is IMessageView viewNoLegOptionExerciseExpirationDates)
			{
				var count = viewNoLegOptionExerciseExpirationDates.GroupCount();
				LegOptionExerciseExpirationDates = new NoLegOptionExerciseExpirationDates[count];
				for (int i = 0; i < count; i++)
				{
					LegOptionExerciseExpirationDates[i] = new();
					((IFixParser)LegOptionExerciseExpirationDates[i]).Parse(viewNoLegOptionExerciseExpirationDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegOptionExerciseExpirationDates":
				{
					value = LegOptionExerciseExpirationDates;
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
			LegOptionExerciseExpirationDates = null;
		}
	}
}
