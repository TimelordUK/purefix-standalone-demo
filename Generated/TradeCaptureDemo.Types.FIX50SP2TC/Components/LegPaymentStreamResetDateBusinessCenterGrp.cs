using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStreamResetDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStreamResetDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40305, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStreamResetDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStreamResetDateBusinessCenter is not null) writer.WriteString(40305, LegPaymentStreamResetDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStreamResetDateBusinessCenter = view.GetString(40305);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStreamResetDateBusinessCenter":
					{
						value = LegPaymentStreamResetDateBusinessCenter;
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
				LegPaymentStreamResetDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40931, Offset = 0, Required = false)]
		public NoLegPaymentStreamResetDateBusinessCenters[]? LegPaymentStreamResetDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStreamResetDateBusinessCenters is not null && LegPaymentStreamResetDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40931, LegPaymentStreamResetDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStreamResetDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStreamResetDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStreamResetDateBusinessCenters") is IMessageView viewNoLegPaymentStreamResetDateBusinessCenters)
			{
				var count = viewNoLegPaymentStreamResetDateBusinessCenters.GroupCount();
				LegPaymentStreamResetDateBusinessCenters = new NoLegPaymentStreamResetDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStreamResetDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStreamResetDateBusinessCenters[i]).Parse(viewNoLegPaymentStreamResetDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStreamResetDateBusinessCenters":
				{
					value = LegPaymentStreamResetDateBusinessCenters;
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
			LegPaymentStreamResetDateBusinessCenters = null;
		}
	}
}
