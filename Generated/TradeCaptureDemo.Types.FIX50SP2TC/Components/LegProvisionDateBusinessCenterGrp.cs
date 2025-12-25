using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40452, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionDateBusinessCenter is not null) writer.WriteString(40452, LegProvisionDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionDateBusinessCenter = view.GetString(40452);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionDateBusinessCenter":
					{
						value = LegProvisionDateBusinessCenter;
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
				LegProvisionDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40939, Offset = 0, Required = false)]
		public NoLegProvisionDateBusinessCenters[]? LegProvisionDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionDateBusinessCenters is not null && LegProvisionDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40939, LegProvisionDateBusinessCenters.Length);
				for (int i = 0; i < LegProvisionDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionDateBusinessCenters") is IMessageView viewNoLegProvisionDateBusinessCenters)
			{
				var count = viewNoLegProvisionDateBusinessCenters.GroupCount();
				LegProvisionDateBusinessCenters = new NoLegProvisionDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionDateBusinessCenters[i] = new();
					((IFixParser)LegProvisionDateBusinessCenters[i]).Parse(viewNoLegProvisionDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionDateBusinessCenters":
				{
					value = LegProvisionDateBusinessCenters;
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
			LegProvisionDateBusinessCenters = null;
		}
	}
}
