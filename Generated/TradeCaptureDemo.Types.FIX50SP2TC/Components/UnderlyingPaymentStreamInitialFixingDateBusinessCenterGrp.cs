using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamInitialFixingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamInitialFixingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40600, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamInitialFixingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamInitialFixingDateBusinessCenter is not null) writer.WriteString(40600, UnderlyingPaymentStreamInitialFixingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamInitialFixingDateBusinessCenter = view.GetString(40600);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamInitialFixingDateBusinessCenter":
					{
						value = UnderlyingPaymentStreamInitialFixingDateBusinessCenter;
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
				UnderlyingPaymentStreamInitialFixingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40971, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamInitialFixingDateBusinessCenters[]? UnderlyingPaymentStreamInitialFixingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamInitialFixingDateBusinessCenters is not null && UnderlyingPaymentStreamInitialFixingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40971, UnderlyingPaymentStreamInitialFixingDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamInitialFixingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamInitialFixingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamInitialFixingDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamInitialFixingDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamInitialFixingDateBusinessCenters.GroupCount();
				UnderlyingPaymentStreamInitialFixingDateBusinessCenters = new NoUnderlyingPaymentStreamInitialFixingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamInitialFixingDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamInitialFixingDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamInitialFixingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamInitialFixingDateBusinessCenters":
				{
					value = UnderlyingPaymentStreamInitialFixingDateBusinessCenters;
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
			UnderlyingPaymentStreamInitialFixingDateBusinessCenters = null;
		}
	}
}
