using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegOptionExerciseExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegOptionExerciseExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41516, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegOptionExerciseExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegOptionExerciseExpirationDateBusinessCenter is not null) writer.WriteString(41516, LegOptionExerciseExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegOptionExerciseExpirationDateBusinessCenter = view.GetString(41516);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegOptionExerciseExpirationDateBusinessCenter":
					{
						value = LegOptionExerciseExpirationDateBusinessCenter;
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
				LegOptionExerciseExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41515, Offset = 0, Required = false)]
		public NoLegOptionExerciseExpirationDateBusinessCenters[]? LegOptionExerciseExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegOptionExerciseExpirationDateBusinessCenters is not null && LegOptionExerciseExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41515, LegOptionExerciseExpirationDateBusinessCenters.Length);
				for (int i = 0; i < LegOptionExerciseExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegOptionExerciseExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegOptionExerciseExpirationDateBusinessCenters") is IMessageView viewNoLegOptionExerciseExpirationDateBusinessCenters)
			{
				var count = viewNoLegOptionExerciseExpirationDateBusinessCenters.GroupCount();
				LegOptionExerciseExpirationDateBusinessCenters = new NoLegOptionExerciseExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegOptionExerciseExpirationDateBusinessCenters[i] = new();
					((IFixParser)LegOptionExerciseExpirationDateBusinessCenters[i]).Parse(viewNoLegOptionExerciseExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegOptionExerciseExpirationDateBusinessCenters":
				{
					value = LegOptionExerciseExpirationDateBusinessCenters;
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
			LegOptionExerciseExpirationDateBusinessCenters = null;
		}
	}
}
