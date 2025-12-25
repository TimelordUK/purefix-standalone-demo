using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionOptionRelevantUnderlyingDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionOptionRelevantUnderlyingDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40510, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionOptionRelevantUnderlyingDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionOptionRelevantUnderlyingDateBusinessCenter is not null) writer.WriteString(40510, LegProvisionOptionRelevantUnderlyingDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionOptionRelevantUnderlyingDateBusinessCenter = view.GetString(40510);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionOptionRelevantUnderlyingDateBusinessCenter":
					{
						value = LegProvisionOptionRelevantUnderlyingDateBusinessCenter;
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
				LegProvisionOptionRelevantUnderlyingDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40938, Offset = 0, Required = false)]
		public NoLegProvisionOptionRelevantUnderlyingDateBusinessCenters[]? LegProvisionOptionRelevantUnderlyingDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionOptionRelevantUnderlyingDateBusinessCenters is not null && LegProvisionOptionRelevantUnderlyingDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40938, LegProvisionOptionRelevantUnderlyingDateBusinessCenters.Length);
				for (int i = 0; i < LegProvisionOptionRelevantUnderlyingDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)LegProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionOptionRelevantUnderlyingDateBusinessCenters") is IMessageView viewNoLegProvisionOptionRelevantUnderlyingDateBusinessCenters)
			{
				var count = viewNoLegProvisionOptionRelevantUnderlyingDateBusinessCenters.GroupCount();
				LegProvisionOptionRelevantUnderlyingDateBusinessCenters = new NoLegProvisionOptionRelevantUnderlyingDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionOptionRelevantUnderlyingDateBusinessCenters[i] = new();
					((IFixParser)LegProvisionOptionRelevantUnderlyingDateBusinessCenters[i]).Parse(viewNoLegProvisionOptionRelevantUnderlyingDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionOptionRelevantUnderlyingDateBusinessCenters":
				{
					value = LegProvisionOptionRelevantUnderlyingDateBusinessCenters;
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
			LegProvisionOptionRelevantUnderlyingDateBusinessCenters = null;
		}
	}
}
