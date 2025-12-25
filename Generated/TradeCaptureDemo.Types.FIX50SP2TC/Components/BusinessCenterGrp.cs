using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class BusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 40471, Type = TagType.String, Offset = 0, Required = false)]
			public string? BusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (BusinessCenter is not null) writer.WriteString(40471, BusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				BusinessCenter = view.GetString(40471);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "BusinessCenter":
					{
						value = BusinessCenter;
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
				BusinessCenter = null;
			}
		}
		[Group(NoOfTag = 40278, Offset = 0, Required = false)]
		public NoBusinessCenters[]? BusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (BusinessCenters is not null && BusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(40278, BusinessCenters.Length);
				for (int i = 0; i < BusinessCenters.Length; i++)
				{
					((IFixEncoder)BusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoBusinessCenters") is IMessageView viewNoBusinessCenters)
			{
				var count = viewNoBusinessCenters.GroupCount();
				BusinessCenters = new NoBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					BusinessCenters[i] = new();
					((IFixParser)BusinessCenters[i]).Parse(viewNoBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoBusinessCenters":
				{
					value = BusinessCenters;
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
			BusinessCenters = null;
		}
	}
}
