using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingCashSettlDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingCashSettlDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42789, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingCashSettlDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingCashSettlDateBusinessCenter is not null) writer.WriteString(42789, UnderlyingCashSettlDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingCashSettlDateBusinessCenter = view.GetString(42789);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingCashSettlDateBusinessCenter":
					{
						value = UnderlyingCashSettlDateBusinessCenter;
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
				UnderlyingCashSettlDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42788, Offset = 0, Required = false)]
		public NoUnderlyingCashSettlDateBusinessCenters[]? UnderlyingCashSettlDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingCashSettlDateBusinessCenters is not null && UnderlyingCashSettlDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42788, UnderlyingCashSettlDateBusinessCenters.Length);
				for (int i = 0; i < UnderlyingCashSettlDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)UnderlyingCashSettlDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingCashSettlDateBusinessCenters") is IMessageView viewNoUnderlyingCashSettlDateBusinessCenters)
			{
				var count = viewNoUnderlyingCashSettlDateBusinessCenters.GroupCount();
				UnderlyingCashSettlDateBusinessCenters = new NoUnderlyingCashSettlDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingCashSettlDateBusinessCenters[i] = new();
					((IFixParser)UnderlyingCashSettlDateBusinessCenters[i]).Parse(viewNoUnderlyingCashSettlDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingCashSettlDateBusinessCenters":
				{
					value = UnderlyingCashSettlDateBusinessCenters;
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
			UnderlyingCashSettlDateBusinessCenters = null;
		}
	}
}
