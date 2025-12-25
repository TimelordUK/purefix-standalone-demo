using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamFirstPeriodStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamFirstPeriodStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40560, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamFirstPeriodStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamFirstPeriodStartDateBusinessCenter is not null) writer.WriteString(40560, UnderlyingStreamFirstPeriodStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamFirstPeriodStartDateBusinessCenter = view.GetString(40560);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamFirstPeriodStartDateBusinessCenter":
					{
						value = UnderlyingStreamFirstPeriodStartDateBusinessCenter;
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
				UnderlyingStreamFirstPeriodStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40974, Offset = 0, Required = false)]
		public NoUnderlyingStreamFirstPeriodStartDateBusinessCenters[]? UnderlyingStreamFirstPeriodStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamFirstPeriodStartDateBusinessCenters is not null && UnderlyingStreamFirstPeriodStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40974, UnderlyingStreamFirstPeriodStartDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingStreamFirstPeriodStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamFirstPeriodStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamFirstPeriodStartDateBusinessCenters") is IMessageView viewNoUnderlyingStreamFirstPeriodStartDateBusinessCenters)
			{
				var count = viewNoUnderlyingStreamFirstPeriodStartDateBusinessCenters.GroupCount();
				UnderlyingStreamFirstPeriodStartDateBusinessCenters = new NoUnderlyingStreamFirstPeriodStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamFirstPeriodStartDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingStreamFirstPeriodStartDateBusinessCenters[i]).Parse(viewNoUnderlyingStreamFirstPeriodStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamFirstPeriodStartDateBusinessCenters":
				{
					value = UnderlyingStreamFirstPeriodStartDateBusinessCenters;
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
			UnderlyingStreamFirstPeriodStartDateBusinessCenters = null;
		}
	}
}
