using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionOptionExerciseBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionOptionExerciseBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42185, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionOptionExerciseBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionOptionExerciseBusinessCenter is not null) writer.WriteString(42185, UnderlyingProvisionOptionExerciseBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionOptionExerciseBusinessCenter = view.GetString(42185);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionOptionExerciseBusinessCenter":
					{
						value = UnderlyingProvisionOptionExerciseBusinessCenter;
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
				UnderlyingProvisionOptionExerciseBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42184, Offset = 0, Required = false)]
		public NoUnderlyingProvisionOptionExerciseBusinessCenters[]? UnderlyingProvisionOptionExerciseBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionOptionExerciseBusinessCenters is not null && UnderlyingProvisionOptionExerciseBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42184, UnderlyingProvisionOptionExerciseBusinessCenters.Length);
				for (int i = 0; i < UnderlyingProvisionOptionExerciseBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionOptionExerciseBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionOptionExerciseBusinessCenters") is IMessageView viewNoUnderlyingProvisionOptionExerciseBusinessCenters)
			{
				var count = viewNoUnderlyingProvisionOptionExerciseBusinessCenters.GroupCount();
				UnderlyingProvisionOptionExerciseBusinessCenters = new NoUnderlyingProvisionOptionExerciseBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionOptionExerciseBusinessCenters[i] = new();
					((IFixParser)UnderlyingProvisionOptionExerciseBusinessCenters[i]).Parse(viewNoUnderlyingProvisionOptionExerciseBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionOptionExerciseBusinessCenters":
				{
					value = UnderlyingProvisionOptionExerciseBusinessCenters;
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
			UnderlyingProvisionOptionExerciseBusinessCenters = null;
		}
	}
}
