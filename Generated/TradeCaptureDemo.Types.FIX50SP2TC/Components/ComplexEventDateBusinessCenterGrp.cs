using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ComplexEventDateBusinessCenterGrp : IFixComponent
	{
		public sealed partial class NoComplexEventDateBusinessCenters : IFixGroup
		{
			[TagDetails(Tag = 41019, Type = TagType.String, Offset = 0, Required = false)]
			public string? ComplexEventDateBusinessCenter {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ComplexEventDateBusinessCenter is not null) writer.WriteString(41019, ComplexEventDateBusinessCenter);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ComplexEventDateBusinessCenter = view.GetString(41019);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ComplexEventDateBusinessCenter":
					{
						value = ComplexEventDateBusinessCenter;
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
				ComplexEventDateBusinessCenter = null;
			}
		}
		[Group(NoOfTag = 41018, Offset = 0, Required = false)]
		public NoComplexEventDateBusinessCenters[]? ComplexEventDateBusinessCenters {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ComplexEventDateBusinessCenters is not null && ComplexEventDateBusinessCenters.Length != 0)
			{
				writer.WriteWholeNumber(41018, ComplexEventDateBusinessCenters.Length);
				for (int i = 0; i < ComplexEventDateBusinessCenters.Length; i++)
				{
					((IFixEncoder)ComplexEventDateBusinessCenters[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoComplexEventDateBusinessCenters") is IMessageView viewNoComplexEventDateBusinessCenters)
			{
				var count = viewNoComplexEventDateBusinessCenters.GroupCount();
				ComplexEventDateBusinessCenters = new NoComplexEventDateBusinessCenters[count];
				for (int i = 0; i < count; i++)
				{
					ComplexEventDateBusinessCenters[i] = new();
					((IFixParser)ComplexEventDateBusinessCenters[i]).Parse(viewNoComplexEventDateBusinessCenters.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoComplexEventDateBusinessCenters":
				{
					value = ComplexEventDateBusinessCenters;
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
			ComplexEventDateBusinessCenters = null;
		}
	}
}
