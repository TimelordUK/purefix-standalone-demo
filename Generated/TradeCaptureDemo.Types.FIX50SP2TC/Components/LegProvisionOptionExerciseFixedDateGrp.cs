using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionExerciseFixedDateGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionOptionExerciseFixedDates : IFixGroup
		{
			[TagDetails(Tag = 40496, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? LegProvisionOptionExerciseFixedDate {get; set;}
			
			[TagDetails(Tag = 40497, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegProvisionOptionExerciseFixedDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionOptionExerciseFixedDate is not null) writer.WriteLocalDateOnly(40496, LegProvisionOptionExerciseFixedDate.Value);
				if (LegProvisionOptionExerciseFixedDateType is not null) writer.WriteWholeNumber(40497, LegProvisionOptionExerciseFixedDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionOptionExerciseFixedDate = view.GetDateOnly(40496);
				LegProvisionOptionExerciseFixedDateType = view.GetInt32(40497);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionOptionExerciseFixedDate":
					{
						value = LegProvisionOptionExerciseFixedDate;
						break;
					}
					case "LegProvisionOptionExerciseFixedDateType":
					{
						value = LegProvisionOptionExerciseFixedDateType;
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
				LegProvisionOptionExerciseFixedDate = null;
				LegProvisionOptionExerciseFixedDateType = null;
			}
		}
		[Group(NoOfTag = 40495, Offset = 0, Required = false)]
		public NoLegProvisionOptionExerciseFixedDates[]? LegProvisionOptionExerciseFixedDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionExerciseFixedDates is not null && LegProvisionOptionExerciseFixedDates.Length != 0)
			{
				writer.WriteWholeNumber(40495, LegProvisionOptionExerciseFixedDates.Length);
				for (int i = 0; i < LegProvisionOptionExerciseFixedDates.Length; i++)
				{
					((IFixEncoder)LegProvisionOptionExerciseFixedDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionOptionExerciseFixedDates") is IMessageView viewNoLegProvisionOptionExerciseFixedDates)
			{
				var count = viewNoLegProvisionOptionExerciseFixedDates.GroupCount();
				LegProvisionOptionExerciseFixedDates = new NoLegProvisionOptionExerciseFixedDates[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionOptionExerciseFixedDates[i] = new();
					((IFixParser)LegProvisionOptionExerciseFixedDates[i]).Parse(viewNoLegProvisionOptionExerciseFixedDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionOptionExerciseFixedDates":
				{
					value = LegProvisionOptionExerciseFixedDates;
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
			LegProvisionOptionExerciseFixedDates = null;
		}
	}
}
