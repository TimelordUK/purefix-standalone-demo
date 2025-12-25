using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40477, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionOptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionOptionExerciseBusinessCenter is not null) writer.WriteString(40477, LegProvisionOptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionOptionExerciseBusinessCenter = view.GetString(40477);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionOptionExerciseBusinessCenter":
					{
						value = LegProvisionOptionExerciseBusinessCenter;
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
				LegProvisionOptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40936, Offset = 0, Required = false)]
		public NoLegProvisionOptionExerciseBusinessCenters[]? LegProvisionOptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionExerciseBusinessCenters is not null && LegProvisionOptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40936, LegProvisionOptionExerciseBusinessCenters.Length);
				for (int i = 0; i < LegProvisionOptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionOptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionOptionExerciseBusinessCenters") is IMessageView viewNoLegProvisionOptionExerciseBusinessCenters)
			{
				var count = viewNoLegProvisionOptionExerciseBusinessCenters.GroupCount();
				LegProvisionOptionExerciseBusinessCenters = new NoLegProvisionOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionOptionExerciseBusinessCenters[i] = new();
					((IFixParser)LegProvisionOptionExerciseBusinessCenters[i]).Parse(viewNoLegProvisionOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionOptionExerciseBusinessCenters":
				{
					value = LegProvisionOptionExerciseBusinessCenters;
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
			LegProvisionOptionExerciseBusinessCenters = null;
		}
	}
}
