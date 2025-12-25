using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPaymentDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamPaymentDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40582, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamPaymentDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamPaymentDateBusinessCenter is not null) writer.WriteString(40582, UnderlyingPaymentStreamPaymentDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamPaymentDateBusinessCenter = view.GetString(40582);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamPaymentDateBusinessCenter":
					{
						value = UnderlyingPaymentStreamPaymentDateBusinessCenter;
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
				UnderlyingPaymentStreamPaymentDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40969, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamPaymentDateBusinessCenters[]? UnderlyingPaymentStreamPaymentDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPaymentDateBusinessCenters is not null && UnderlyingPaymentStreamPaymentDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40969, UnderlyingPaymentStreamPaymentDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamPaymentDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamPaymentDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamPaymentDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamPaymentDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamPaymentDateBusinessCenters.GroupCount();
				UnderlyingPaymentStreamPaymentDateBusinessCenters = new NoUnderlyingPaymentStreamPaymentDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamPaymentDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamPaymentDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamPaymentDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamPaymentDateBusinessCenters":
				{
					value = UnderlyingPaymentStreamPaymentDateBusinessCenters;
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
			UnderlyingPaymentStreamPaymentDateBusinessCenters = null;
		}
	}
}
