using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegPaymentStubStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegPaymentStubStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42505, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegPaymentStubStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegPaymentStubStartDateBusinessCenter is not null) writer.WriteString(42505, LegPaymentStubStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegPaymentStubStartDateBusinessCenter = view.GetString(42505);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegPaymentStubStartDateBusinessCenter":
					{
						value = LegPaymentStubStartDateBusinessCenter;
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
				LegPaymentStubStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42504, Offset = 0, Required = false)]
		public NoLegPaymentStubStartDateBusinessCenters[]? LegPaymentStubStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegPaymentStubStartDateBusinessCenters is not null && LegPaymentStubStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42504, LegPaymentStubStartDateBusinessCenters.Length);
				for (int i = 0; i < LegPaymentStubStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegPaymentStubStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegPaymentStubStartDateBusinessCenters") is IMessageView viewNoLegPaymentStubStartDateBusinessCenters)
			{
				var count = viewNoLegPaymentStubStartDateBusinessCenters.GroupCount();
				LegPaymentStubStartDateBusinessCenters = new NoLegPaymentStubStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegPaymentStubStartDateBusinessCenters[i] = new();
					((IFixParser)LegPaymentStubStartDateBusinessCenters[i]).Parse(viewNoLegPaymentStubStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegPaymentStubStartDateBusinessCenters":
				{
					value = LegPaymentStubStartDateBusinessCenters;
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
			LegPaymentStubStartDateBusinessCenters = null;
		}
	}
}
