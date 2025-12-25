using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingDividendFXTriggerDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingDividendFXTriggerDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42854, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingDividendFXTriggerDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingDividendFXTriggerDateBusinessCenter is not null) writer.WriteString(42854, UnderlyingDividendFXTriggerDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingDividendFXTriggerDateBusinessCenter = view.GetString(42854);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingDividendFXTriggerDateBusinessCenter":
					{
						value = UnderlyingDividendFXTriggerDateBusinessCenter;
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
				UnderlyingDividendFXTriggerDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42853, Offset = 0, Required = false)]
		public NoUnderlyingDividendFXTriggerDateBusinessCenters[]? UnderlyingDividendFXTriggerDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingDividendFXTriggerDateBusinessCenters is not null && UnderlyingDividendFXTriggerDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42853, UnderlyingDividendFXTriggerDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingDividendFXTriggerDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingDividendFXTriggerDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingDividendFXTriggerDateBusinessCenters") is IMessageView viewNoUnderlyingDividendFXTriggerDateBusinessCenters)
			{
				var count = viewNoUnderlyingDividendFXTriggerDateBusinessCenters.GroupCount();
				UnderlyingDividendFXTriggerDateBusinessCenters = new NoUnderlyingDividendFXTriggerDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingDividendFXTriggerDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingDividendFXTriggerDateBusinessCenters[i]).Parse(viewNoUnderlyingDividendFXTriggerDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingDividendFXTriggerDateBusinessCenters":
				{
					value = UnderlyingDividendFXTriggerDateBusinessCenters;
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
			UnderlyingDividendFXTriggerDateBusinessCenters = null;
		}
	}
}
