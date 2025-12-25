using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionExpirationDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionOptionExpirationDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40500, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionOptionExpirationDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionOptionExpirationDateBusinessCenter is not null) writer.WriteString(40500, LegProvisionOptionExpirationDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionOptionExpirationDateBusinessCenter = view.GetString(40500);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionOptionExpirationDateBusinessCenter":
					{
						value = LegProvisionOptionExpirationDateBusinessCenter;
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
				LegProvisionOptionExpirationDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40937, Offset = 0, Required = false)]
		public NoLegProvisionOptionExpirationDateBusinessCenters[]? LegProvisionOptionExpirationDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionExpirationDateBusinessCenters is not null && LegProvisionOptionExpirationDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40937, LegProvisionOptionExpirationDateBusinessCenters.Length);
				for (int i = 0; i < LegProvisionOptionExpirationDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionOptionExpirationDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionOptionExpirationDateBusinessCenters") is IMessageView viewNoLegProvisionOptionExpirationDateBusinessCenters)
			{
				var count = viewNoLegProvisionOptionExpirationDateBusinessCenters.GroupCount();
				LegProvisionOptionExpirationDateBusinessCenters = new NoLegProvisionOptionExpirationDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionOptionExpirationDateBusinessCenters[i] = new();
					((IFixParser)LegProvisionOptionExpirationDateBusinessCenters[i]).Parse(viewNoLegProvisionOptionExpirationDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionOptionExpirationDateBusinessCenters":
				{
					value = LegProvisionOptionExpirationDateBusinessCenters;
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
			LegProvisionOptionExpirationDateBusinessCenters = null;
		}
	}
}
