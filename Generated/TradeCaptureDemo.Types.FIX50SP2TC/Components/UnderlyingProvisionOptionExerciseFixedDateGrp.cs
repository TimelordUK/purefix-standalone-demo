using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionExerciseFixedDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionOptionExerciseFixedDates : IFixGroup
		{
			[TagDetails(Tag = 42113, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingProvisionOptionExerciseFixedDate {get; set;}
			
			[TagDetails(Tag = 42114, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingProvisionOptionExerciseFixedDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionOptionExerciseFixedDate is not null) writer.WriteLocalDateOnly(42113, UnderlyingProvisionOptionExerciseFixedDate.Value);
				if (UnderlyingProvisionOptionExerciseFixedDateType is not null) writer.WriteWholeNumber(42114, UnderlyingProvisionOptionExerciseFixedDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionOptionExerciseFixedDate = view.GetDateOnly(42113);
				UnderlyingProvisionOptionExerciseFixedDateType = view.GetInt32(42114);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionOptionExerciseFixedDate":
					{
						value = UnderlyingProvisionOptionExerciseFixedDate;
						break;
					}
					case "UnderlyingProvisionOptionExerciseFixedDateType":
					{
						value = UnderlyingProvisionOptionExerciseFixedDateType;
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
				UnderlyingProvisionOptionExerciseFixedDate = null;
				UnderlyingProvisionOptionExerciseFixedDateType = null;
			}
		}
		[Group(NoOfTag = 42112, Offset = 0, Required = false)]
		public NoUnderlyingProvisionOptionExerciseFixedDates[]? UnderlyingProvisionOptionExerciseFixedDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionExerciseFixedDates is not null && UnderlyingProvisionOptionExerciseFixedDates.Length != 0)
			{
				writer.WriteWholeNumber(42112, UnderlyingProvisionOptionExerciseFixedDates.Length);
				for (int i = 0; i < UnderlyingProvisionOptionExerciseFixedDates.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionOptionExerciseFixedDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionOptionExerciseFixedDates") is IMessageView viewNoUnderlyingProvisionOptionExerciseFixedDates)
			{
				var count = viewNoUnderlyingProvisionOptionExerciseFixedDates.GroupCount();
				UnderlyingProvisionOptionExerciseFixedDates = new NoUnderlyingProvisionOptionExerciseFixedDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionOptionExerciseFixedDates[i] = new();
					((IFixParser)UnderlyingProvisionOptionExerciseFixedDates[i]).Parse(viewNoUnderlyingProvisionOptionExerciseFixedDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionOptionExerciseFixedDates":
				{
					value = UnderlyingProvisionOptionExerciseFixedDates;
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
			UnderlyingProvisionOptionExerciseFixedDates = null;
		}
	}
}
