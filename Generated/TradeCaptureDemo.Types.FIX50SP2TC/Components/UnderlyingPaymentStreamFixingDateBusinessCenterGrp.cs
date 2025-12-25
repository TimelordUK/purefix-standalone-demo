using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40607, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamFixingDateBusinessCenter is not null) writer.WriteString(40607, UnderlyingPaymentStreamFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamFixingDateBusinessCenter = view.GetString(40607);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamFixingDateBusinessCenter":
					{
						value = UnderlyingPaymentStreamFixingDateBusinessCenter;
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
				UnderlyingPaymentStreamFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40972, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamFixingDateBusinessCenters[]? UnderlyingPaymentStreamFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamFixingDateBusinessCenters is not null && UnderlyingPaymentStreamFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40972, UnderlyingPaymentStreamFixingDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamFixingDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamFixingDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamFixingDateBusinessCenters.GroupCount();
				UnderlyingPaymentStreamFixingDateBusinessCenters = new NoUnderlyingPaymentStreamFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamFixingDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamFixingDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamFixingDateBusinessCenters":
				{
					value = UnderlyingPaymentStreamFixingDateBusinessCenters;
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
			UnderlyingPaymentStreamFixingDateBusinessCenters = null;
		}
	}
}
