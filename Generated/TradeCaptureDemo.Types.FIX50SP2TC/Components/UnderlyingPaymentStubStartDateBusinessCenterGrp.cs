using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStubStartDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStubStartDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 43001, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingPaymentStubStartDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStubStartDateBusinessCenter is not null) writer.WriteString(43001, UnderlyingPaymentStubStartDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStubStartDateBusinessCenter = view.GetString(43001);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStubStartDateBusinessCenter":
					{
						value = UnderlyingPaymentStubStartDateBusinessCenter;
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
				UnderlyingPaymentStubStartDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 43000, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStubStartDateBusinessCenters[]? UnderlyingPaymentStubStartDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStubStartDateBusinessCenters is not null && UnderlyingPaymentStubStartDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(43000, UnderlyingPaymentStubStartDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingPaymentStubStartDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStubStartDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStubStartDateBusinessCenters") is IMessageView viewNoUnderlyingPaymentStubStartDateBusinessCenters)
			{
				var count = viewNoUnderlyingPaymentStubStartDateBusinessCenters.GroupCount();
				UnderlyingPaymentStubStartDateBusinessCenters = new NoUnderlyingPaymentStubStartDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStubStartDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingPaymentStubStartDateBusinessCenters[i]).Parse(viewNoUnderlyingPaymentStubStartDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStubStartDateBusinessCenters":
				{
					value = UnderlyingPaymentStubStartDateBusinessCenters;
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
			UnderlyingPaymentStubStartDateBusinessCenters = null;
		}
	}
}
