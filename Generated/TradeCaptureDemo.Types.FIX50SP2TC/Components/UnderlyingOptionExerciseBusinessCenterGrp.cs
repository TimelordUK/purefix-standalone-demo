using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41821, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingOptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingOptionExerciseBusinessCenter is not null) writer.WriteString(41821, UnderlyingOptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingOptionExerciseBusinessCenter = view.GetString(41821);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingOptionExerciseBusinessCenter":
					{
						value = UnderlyingOptionExerciseBusinessCenter;
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
				UnderlyingOptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41820, Offset = 0, Required = false)]
		public NoUnderlyingOptionExerciseBusinessCenters[]? UnderlyingOptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseBusinessCenters is not null && UnderlyingOptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41820, UnderlyingOptionExerciseBusinessCenters.Length);
				for (int i = 0; i < UnderlyingOptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingOptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingOptionExerciseBusinessCenters") is IMessageView viewNoUnderlyingOptionExerciseBusinessCenters)
			{
				var count = viewNoUnderlyingOptionExerciseBusinessCenters.GroupCount();
				UnderlyingOptionExerciseBusinessCenters = new NoUnderlyingOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingOptionExerciseBusinessCenters[i] = new();
					((IFixParser)UnderlyingOptionExerciseBusinessCenters[i]).Parse(viewNoUnderlyingOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingOptionExerciseBusinessCenters":
				{
					value = UnderlyingOptionExerciseBusinessCenters;
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
			UnderlyingOptionExerciseBusinessCenters = null;
		}
	}
}
