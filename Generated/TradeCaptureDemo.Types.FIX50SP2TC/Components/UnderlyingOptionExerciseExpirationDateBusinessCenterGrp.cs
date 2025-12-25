using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingOptionExerciseExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingOptionExerciseExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41845, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingOptionExerciseExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingOptionExerciseExpirationDateBusinessCenter is not null) writer.WriteString(41845, UnderlyingOptionExerciseExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingOptionExerciseExpirationDateBusinessCenter = view.GetString(41845);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingOptionExerciseExpirationDateBusinessCenter":
					{
						value = UnderlyingOptionExerciseExpirationDateBusinessCenter;
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
				UnderlyingOptionExerciseExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41844, Offset = 0, Required = false)]
		public NoUnderlyingOptionExerciseExpirationDateBusinessCenters[]? UnderlyingOptionExerciseExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingOptionExerciseExpirationDateBusinessCenters is not null && UnderlyingOptionExerciseExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41844, UnderlyingOptionExerciseExpirationDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingOptionExerciseExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingOptionExerciseExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingOptionExerciseExpirationDateBusinessCenters") is IMessageView viewNoUnderlyingOptionExerciseExpirationDateBusinessCenters)
			{
				var count = viewNoUnderlyingOptionExerciseExpirationDateBusinessCenters.GroupCount();
				UnderlyingOptionExerciseExpirationDateBusinessCenters = new NoUnderlyingOptionExerciseExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingOptionExerciseExpirationDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingOptionExerciseExpirationDateBusinessCenters[i]).Parse(viewNoUnderlyingOptionExerciseExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingOptionExerciseExpirationDateBusinessCenters":
				{
					value = UnderlyingOptionExerciseExpirationDateBusinessCenters;
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
			UnderlyingOptionExerciseExpirationDateBusinessCenters = null;
		}
	}
}
