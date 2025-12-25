using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41117, Type = TagType.String, Offset = 0, Required = false)]
			public string? OptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OptionExerciseBusinessCenter is not null) writer.WriteString(41117, OptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OptionExerciseBusinessCenter = view.GetString(41117);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OptionExerciseBusinessCenter":
					{
						value = OptionExerciseBusinessCenter;
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
				OptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41116, Offset = 0, Required = false)]
		public NoOptionExerciseBusinessCenters[]? OptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseBusinessCenters is not null && OptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41116, OptionExerciseBusinessCenters.Length);
				for (int i = 0; i < OptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)OptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOptionExerciseBusinessCenters") is IMessageView viewNoOptionExerciseBusinessCenters)
			{
				var count = viewNoOptionExerciseBusinessCenters.GroupCount();
				OptionExerciseBusinessCenters = new NoOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					OptionExerciseBusinessCenters[i] = new();
					((IFixParser)OptionExerciseBusinessCenters[i]).Parse(viewNoOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOptionExerciseBusinessCenters":
				{
					value = OptionExerciseBusinessCenters;
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
			OptionExerciseBusinessCenters = null;
		}
	}
}
