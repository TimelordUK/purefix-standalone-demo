using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamResetDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamResetDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40594, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStreamResetDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamResetDateBusinessCenter is not null) writer.WriteString(40594, UnderlyingPaymentStreamResetDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamResetDateBusinessCenter = view.GetString(40594);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamResetDateBusinessCenter":
					{
						value = UnderlyingPaymentStreamResetDateBusinessCenter;
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
				UnderlyingPaymentStreamResetDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40970, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamResetDateBusinessCenters[]? UnderlyingPaymentStreamResetDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamResetDateBusinessCenters is not null && UnderlyingPaymentStreamResetDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40970, UnderlyingPaymentStreamResetDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStreamResetDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamResetDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamResetDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStreamResetDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStreamResetDateBusinessCenters.GroupCount();
				UnderlyingPaymentStreamResetDateBusinessCenters = new NoUnderlyingPaymentStreamResetDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamResetDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStreamResetDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStreamResetDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamResetDateBusinessCenters":
				{
					value = UnderlyingPaymentStreamResetDateBusinessCenters;
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
			UnderlyingPaymentStreamResetDateBusinessCenters = null;
		}
	}
}
