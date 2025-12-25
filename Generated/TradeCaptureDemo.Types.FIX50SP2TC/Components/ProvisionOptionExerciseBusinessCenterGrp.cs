using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionOptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoProvisionOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40124, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionOptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionOptionExerciseBusinessCenter is not null) writer.WriteString(40124, ProvisionOptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionOptionExerciseBusinessCenter = view.GetString(40124);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionOptionExerciseBusinessCenter":
					{
						value = ProvisionOptionExerciseBusinessCenter;
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
				ProvisionOptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40954, Offset = 0, Required = false)]
		public NoProvisionOptionExerciseBusinessCenters[]? ProvisionOptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionOptionExerciseBusinessCenters is not null && ProvisionOptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40954, ProvisionOptionExerciseBusinessCenters.Length);
				for (int i = 0; i < ProvisionOptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)ProvisionOptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionOptionExerciseBusinessCenters") is IMessageView viewNoProvisionOptionExerciseBusinessCenters)
			{
				var count = viewNoProvisionOptionExerciseBusinessCenters.GroupCount();
				ProvisionOptionExerciseBusinessCenters = new NoProvisionOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionOptionExerciseBusinessCenters[i] = new();
					((IFixParser)ProvisionOptionExerciseBusinessCenters[i]).Parse(viewNoProvisionOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionOptionExerciseBusinessCenters":
				{
					value = ProvisionOptionExerciseBusinessCenters;
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
			ProvisionOptionExerciseBusinessCenters = null;
		}
	}
}
