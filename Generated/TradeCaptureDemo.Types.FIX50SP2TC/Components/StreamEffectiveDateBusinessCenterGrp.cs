using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StreamEffectiveDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoStreamEffectiveDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40909, Type = TagType.String, Offset = 0, Required = false)]
			public string? StreamEffectiveDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (StreamEffectiveDateBusinessCenter is not null) writer.WriteString(40909, StreamEffectiveDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				StreamEffectiveDateBusinessCenter = view.GetString(40909);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "StreamEffectiveDateBusinessCenter":
					{
						value = StreamEffectiveDateBusinessCenter;
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
				StreamEffectiveDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40960, Offset = 0, Required = false)]
		public NoStreamEffectiveDateBusinessCenters[]? StreamEffectiveDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StreamEffectiveDateBusinessCenters is not null && StreamEffectiveDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40960, StreamEffectiveDateBusinessCenters.Length);
				for (int i = 0; i < StreamEffectiveDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)StreamEffectiveDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoStreamEffectiveDateBusinessCenters") is IMessageView viewNoStreamEffectiveDateBusinessCenters)
			{
				var count = viewNoStreamEffectiveDateBusinessCenters.GroupCount();
				StreamEffectiveDateBusinessCenters = new NoStreamEffectiveDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					StreamEffectiveDateBusinessCenters[i] = new();
					((IFixParser)StreamEffectiveDateBusinessCenters[i]).Parse(viewNoStreamEffectiveDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoStreamEffectiveDateBusinessCenters":
				{
					value = StreamEffectiveDateBusinessCenters;
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
			StreamEffectiveDateBusinessCenters = null;
		}
	}
}
