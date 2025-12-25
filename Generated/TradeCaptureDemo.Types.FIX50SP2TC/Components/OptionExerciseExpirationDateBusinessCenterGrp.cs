using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class OptionExerciseExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoOptionExerciseExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41141, Type = TagType.String, Offset = 0, Required = false)]
			public string? OptionExerciseExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (OptionExerciseExpirationDateBusinessCenter is not null) writer.WriteString(41141, OptionExerciseExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				OptionExerciseExpirationDateBusinessCenter = view.GetString(41141);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "OptionExerciseExpirationDateBusinessCenter":
					{
						value = OptionExerciseExpirationDateBusinessCenter;
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
				OptionExerciseExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41140, Offset = 0, Required = false)]
		public NoOptionExerciseExpirationDateBusinessCenters[]? OptionExerciseExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (OptionExerciseExpirationDateBusinessCenters is not null && OptionExerciseExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41140, OptionExerciseExpirationDateBusinessCenters.Length);
				for (int i = 0; i < OptionExerciseExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)OptionExerciseExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoOptionExerciseExpirationDateBusinessCenters") is IMessageView viewNoOptionExerciseExpirationDateBusinessCenters)
			{
				var count = viewNoOptionExerciseExpirationDateBusinessCenters.GroupCount();
				OptionExerciseExpirationDateBusinessCenters = new NoOptionExerciseExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					OptionExerciseExpirationDateBusinessCenters[i] = new();
					((IFixParser)OptionExerciseExpirationDateBusinessCenters[i]).Parse(viewNoOptionExerciseExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoOptionExerciseExpirationDateBusinessCenters":
				{
					value = OptionExerciseExpirationDateBusinessCenters;
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
			OptionExerciseExpirationDateBusinessCenters = null;
		}
	}
}
