using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStubEndDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStubEndDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42496, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStubEndDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStubEndDateBusinessCenter is not null) writer.WriteString(42496, LegPaymentStubEndDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStubEndDateBusinessCenter = view.GetString(42496);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStubEndDateBusinessCenter":
					{
						value = LegPaymentStubEndDateBusinessCenter;
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
				LegPaymentStubEndDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42495, Offset = 0, Required = false)]
		public NoLegPaymentStubEndDateBusinessCenters[]? LegPaymentStubEndDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStubEndDateBusinessCenters is not null && LegPaymentStubEndDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42495, LegPaymentStubEndDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStubEndDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStubEndDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStubEndDateBusinessCenters") is IMessageView viewNoLegPaymentStubEndDateBusinessCenters)
			{
				var count = viewNoLegPaymentStubEndDateBusinessCenters.GroupCount();
				LegPaymentStubEndDateBusinessCenters = new NoLegPaymentStubEndDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStubEndDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStubEndDateBusinessCenters[i]).Parse(viewNoLegPaymentStubEndDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStubEndDateBusinessCenters":
				{
					value = LegPaymentStubEndDateBusinessCenters;
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
			LegPaymentStubEndDateBusinessCenters = null;
		}
	}
}
