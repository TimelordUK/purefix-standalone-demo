using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DividendFXTriggerDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoDividendFXTriggerDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42273, Type = TagType.String, Offset = 0, Required = false)]
			public string? DividendFXTriggerDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DividendFXTriggerDateBusinessCenter is not null) writer.WriteString(42273, DividendFXTriggerDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DividendFXTriggerDateBusinessCenter = view.GetString(42273);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DividendFXTriggerDateBusinessCenter":
					{
						value = DividendFXTriggerDateBusinessCenter;
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
				DividendFXTriggerDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42272, Offset = 0, Required = false)]
		public NoDividendFXTriggerDateBusinessCenters[]? DividendFXTriggerDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DividendFXTriggerDateBusinessCenters is not null && DividendFXTriggerDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42272, DividendFXTriggerDateBusinessCenters.Length);
				for (int i = 0; i < DividendFXTriggerDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)DividendFXTriggerDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDividendFXTriggerDateBusinessCenters") is IMessageView viewNoDividendFXTriggerDateBusinessCenters)
			{
				var count = viewNoDividendFXTriggerDateBusinessCenters.GroupCount();
				DividendFXTriggerDateBusinessCenters = new NoDividendFXTriggerDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					DividendFXTriggerDateBusinessCenters[i] = new();
					((IFixParser)DividendFXTriggerDateBusinessCenters[i]).Parse(viewNoDividendFXTriggerDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDividendFXTriggerDateBusinessCenters":
				{
					value = DividendFXTriggerDateBusinessCenters;
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
			DividendFXTriggerDateBusinessCenters = null;
		}
	}
}
