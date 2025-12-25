using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStubEndDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStubEndDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42992, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStubEndDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStubEndDateBusinessCenter is not null) writer.WriteString(42992, UnderlyingPaymentStubEndDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStubEndDateBusinessCenter = view.GetString(42992);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStubEndDateBusinessCenter":
					{
						value = UnderlyingPaymentStubEndDateBusinessCenter;
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
				UnderlyingPaymentStubEndDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42991, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStubEndDateBusinessCenters[]? UnderlyingPaymentStubEndDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStubEndDateBusinessCenters is not null && UnderlyingPaymentStubEndDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42991, UnderlyingPaymentStubEndDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStubEndDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStubEndDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStubEndDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStubEndDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStubEndDateBusinessCenters.GroupCount();
				UnderlyingPaymentStubEndDateBusinessCenters = new NoUnderlyingPaymentStubEndDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStubEndDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStubEndDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStubEndDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStubEndDateBusinessCenters":
				{
					value = UnderlyingPaymentStubEndDateBusinessCenters;
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
			UnderlyingPaymentStubEndDateBusinessCenters = null;
		}
	}
}
