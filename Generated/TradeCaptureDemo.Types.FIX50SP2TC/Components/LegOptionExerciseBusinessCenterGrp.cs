using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41492, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegOptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegOptionExerciseBusinessCenter is not null) writer.WriteString(41492, LegOptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegOptionExerciseBusinessCenter = view.GetString(41492);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegOptionExerciseBusinessCenter":
					{
						value = LegOptionExerciseBusinessCenter;
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
				LegOptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41491, Offset = 0, Required = false)]
		public NoLegOptionExerciseBusinessCenters[]? LegOptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseBusinessCenters is not null && LegOptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41491, LegOptionExerciseBusinessCenters.Length);
				for (int i = 0; i < LegOptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegOptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegOptionExerciseBusinessCenters") is IMessageView viewNoLegOptionExerciseBusinessCenters)
			{
				var count = viewNoLegOptionExerciseBusinessCenters.GroupCount();
				LegOptionExerciseBusinessCenters = new NoLegOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegOptionExerciseBusinessCenters[i] = new();
					((IFixParser)LegOptionExerciseBusinessCenters[i]).Parse(viewNoLegOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegOptionExerciseBusinessCenters":
				{
					value = LegOptionExerciseBusinessCenters;
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
			LegOptionExerciseBusinessCenters = null;
		}
	}
}
