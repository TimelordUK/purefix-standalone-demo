using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamEffectiveDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamEffectiveDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40059, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamEffectiveDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamEffectiveDateBusinessCenter is not null) writer.WriteString(40059, UnderlyingStreamEffectiveDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamEffectiveDateBusinessCenter = view.GetString(40059);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamEffectiveDateBusinessCenter":
					{
						value = UnderlyingStreamEffectiveDateBusinessCenter;
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
				UnderlyingStreamEffectiveDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40975, Offset = 0, Required = false)]
		public NoUnderlyingStreamEffectiveDateBusinessCenters[]? UnderlyingStreamEffectiveDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamEffectiveDateBusinessCenters is not null && UnderlyingStreamEffectiveDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40975, UnderlyingStreamEffectiveDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingStreamEffectiveDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamEffectiveDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamEffectiveDateBusinessCenters") is IMessageView viewNoUnderlyingStreamEffectiveDateBusinessCenters)
			{
				var count = viewNoUnderlyingStreamEffectiveDateBusinessCenters.GroupCount();
				UnderlyingStreamEffectiveDateBusinessCenters = new NoUnderlyingStreamEffectiveDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamEffectiveDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingStreamEffectiveDateBusinessCenters[i]).Parse(viewNoUnderlyingStreamEffectiveDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamEffectiveDateBusinessCenters":
				{
					value = UnderlyingStreamEffectiveDateBusinessCenters;
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
			UnderlyingStreamEffectiveDateBusinessCenters = null;
		}
	}
}
