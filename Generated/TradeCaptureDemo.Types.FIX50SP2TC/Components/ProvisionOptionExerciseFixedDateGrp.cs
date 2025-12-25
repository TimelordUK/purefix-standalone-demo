using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionExerciseFixedDateGrp : IFixComponent
	{
		public sealed partial class NoProvisionOptionExerciseFixedDates : IFixGroup
		{
			[TagDetails(Tag = 40143, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? ProvisionOptionExerciseFixedDate {get; set;}
			
			[TagDetails(Tag = 40144, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ProvisionOptionExerciseFixedDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionOptionExerciseFixedDate is not null) writer.WriteLocalDateOnly(40143, ProvisionOptionExerciseFixedDate.Value);
				if (ProvisionOptionExerciseFixedDateType is not null) writer.WriteWholeNumber(40144, ProvisionOptionExerciseFixedDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionOptionExerciseFixedDate = view.GetDateOnly(40143);
				ProvisionOptionExerciseFixedDateType = view.GetInt32(40144);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionOptionExerciseFixedDate":
					{
						value = ProvisionOptionExerciseFixedDate;
						break;
					}
					case "ProvisionOptionExerciseFixedDateType":
					{
						value = ProvisionOptionExerciseFixedDateType;
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
				ProvisionOptionExerciseFixedDate = null;
				ProvisionOptionExerciseFixedDateType = null;
			}
		}
		[Group(NoOfTag = 40142, Offset = 0, Required = false)]
		public NoProvisionOptionExerciseFixedDates[]? ProvisionOptionExerciseFixedDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionExerciseFixedDates is not null && ProvisionOptionExerciseFixedDates.Length != 0)
			{
				writer.WriteWholeNumber(40142, ProvisionOptionExerciseFixedDates.Length);
				for (int i = 0; i < ProvisionOptionExerciseFixedDates.Length; i++)
				{
					((IFixEncoder)ProvisionOptionExerciseFixedDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionOptionExerciseFixedDates") is IMessageView viewNoProvisionOptionExerciseFixedDates)
			{
				var count = viewNoProvisionOptionExerciseFixedDates.GroupCount();
				ProvisionOptionExerciseFixedDates = new NoProvisionOptionExerciseFixedDates[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionOptionExerciseFixedDates[i] = new();
					((IFixParser)ProvisionOptionExerciseFixedDates[i]).Parse(viewNoProvisionOptionExerciseFixedDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionOptionExerciseFixedDates":
				{
					value = ProvisionOptionExerciseFixedDates;
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
			ProvisionOptionExerciseFixedDates = null;
		}
	}
}
