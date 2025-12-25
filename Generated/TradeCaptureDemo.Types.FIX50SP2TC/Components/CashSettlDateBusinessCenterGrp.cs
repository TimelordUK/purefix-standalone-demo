using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CashSettlDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoCashSettlDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 42215, Type = TagType.String, Offset = 0, Required = false)]
			public string? CashSettlDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (CashSettlDateBusinessCenter is not null) writer.WriteString(42215, CashSettlDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				CashSettlDateBusinessCenter = view.GetString(42215);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "CashSettlDateBusinessCenter":
					{
						value = CashSettlDateBusinessCenter;
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
				CashSettlDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 42214, Offset = 0, Required = false)]
		public NoCashSettlDateBusinessCenters[]? CashSettlDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CashSettlDateBusinessCenters is not null && CashSettlDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(42214, CashSettlDateBusinessCenters.Length);
				for (int i = 0; i < CashSettlDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)CashSettlDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCashSettlDateBusinessCenters") is IMessageView viewNoCashSettlDateBusinessCenters)
			{
				var count = viewNoCashSettlDateBusinessCenters.GroupCount();
				CashSettlDateBusinessCenters = new NoCashSettlDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					CashSettlDateBusinessCenters[i] = new();
					((IFixParser)CashSettlDateBusinessCenters[i]).Parse(viewNoCashSettlDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCashSettlDateBusinessCenters":
				{
					value = CashSettlDateBusinessCenters;
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
			CashSettlDateBusinessCenters = null;
		}
	}
}
