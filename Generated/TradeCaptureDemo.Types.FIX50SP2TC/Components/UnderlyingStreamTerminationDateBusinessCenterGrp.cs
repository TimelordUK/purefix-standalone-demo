using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamTerminationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamTerminationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40550, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamTerminationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamTerminationDateBusinessCenter is not null) writer.WriteString(40550, UnderlyingStreamTerminationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamTerminationDateBusinessCenter = view.GetString(40550);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamTerminationDateBusinessCenter":
					{
						value = UnderlyingStreamTerminationDateBusinessCenter;
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
				UnderlyingStreamTerminationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40976, Offset = 0, Required = false)]
		public NoUnderlyingStreamTerminationDateBusinessCenters[]? UnderlyingStreamTerminationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamTerminationDateBusinessCenters is not null && UnderlyingStreamTerminationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40976, UnderlyingStreamTerminationDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingStreamTerminationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamTerminationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamTerminationDateBusinessCenters") is IMessageView viewNoUnderlyingStreamTerminationDateBusinessCenters)
			{
				var count = viewNoUnderlyingStreamTerminationDateBusinessCenters.GroupCount();
				UnderlyingStreamTerminationDateBusinessCenters = new NoUnderlyingStreamTerminationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamTerminationDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingStreamTerminationDateBusinessCenters[i]).Parse(viewNoUnderlyingStreamTerminationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamTerminationDateBusinessCenters":
				{
					value = UnderlyingStreamTerminationDateBusinessCenters;
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
			UnderlyingStreamTerminationDateBusinessCenters = null;
		}
	}
}
