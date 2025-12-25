using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegCashSettlDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegCashSettlDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42307, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegCashSettlDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegCashSettlDateBusinessCenter is not null) writer.WriteString(42307, LegCashSettlDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegCashSettlDateBusinessCenter = view.GetString(42307);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegCashSettlDateBusinessCenter":
					{
						value = LegCashSettlDateBusinessCenter;
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
				LegCashSettlDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42306, Offset = 0, Required = false)]
		public NoLegCashSettlDateBusinessCenters[]? LegCashSettlDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegCashSettlDateBusinessCenters is not null && LegCashSettlDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42306, LegCashSettlDateBusinessCenters.Length);
				for (int i = 0; i < LegCashSettlDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegCashSettlDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegCashSettlDateBusinessCenters") is IMessageView viewNoLegCashSettlDateBusinessCenters)
			{
				var count = viewNoLegCashSettlDateBusinessCenters.GroupCount();
				LegCashSettlDateBusinessCenters = new NoLegCashSettlDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegCashSettlDateBusinessCenters[i] = new();
					((IFixParser)LegCashSettlDateBusinessCenters[i]).Parse(viewNoLegCashSettlDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegCashSettlDateBusinessCenters":
				{
					value = LegCashSettlDateBusinessCenters;
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
			LegCashSettlDateBusinessCenters = null;
		}
	}
}
