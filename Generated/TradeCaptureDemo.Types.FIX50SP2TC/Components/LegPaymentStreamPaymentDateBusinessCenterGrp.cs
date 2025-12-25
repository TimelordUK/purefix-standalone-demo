using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40293, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamPaymentDateBusinessCenter is not null) writer.WriteString(40293, LegPaymentStreamPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamPaymentDateBusinessCenter = view.GetString(40293);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamPaymentDateBusinessCenter":
					{
						value = LegPaymentStreamPaymentDateBusinessCenter;
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
				LegPaymentStreamPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40930, Offset = 0, Required = false)]
		public NoLegPaymentStreamPaymentDateBusinessCenters[]? LegPaymentStreamPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamPaymentDateBusinessCenters is not null && LegPaymentStreamPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40930, LegPaymentStreamPaymentDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamPaymentDateBusinessCenters") is IMessageView viewNoLegPaymentStreamPaymentDateBusinessCenters)
			{
				var count = viewNoLegPaymentStreamPaymentDateBusinessCenters.GroupCount();
				LegPaymentStreamPaymentDateBusinessCenters = new NoLegPaymentStreamPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamPaymentDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamPaymentDateBusinessCenters[i]).Parse(viewNoLegPaymentStreamPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamPaymentDateBusinessCenters":
				{
					value = LegPaymentStreamPaymentDateBusinessCenters;
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
			LegPaymentStreamPaymentDateBusinessCenters = null;
		}
	}
}
