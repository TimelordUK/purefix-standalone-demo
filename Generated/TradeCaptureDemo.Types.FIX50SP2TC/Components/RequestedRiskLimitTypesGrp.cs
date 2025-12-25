using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RequestedRiskLimitTypesGrp : IFixComponent
	{
		public sealed partial class NoRequestedRiskLimitType : IFixGroup
		{
			[TagDetails(Tag = 1530, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RiskLimitType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RiskLimitType is not null) writer.WriteWholeNumber(1530, RiskLimitType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RiskLimitType = view.GetInt32(1530);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RiskLimitType":
					{
						value = RiskLimitType;
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
				RiskLimitType = null;
			}
		}
		[Group(NoOfTag = 1668, Offset = 0, Required = false)]
		public NoRequestedRiskLimitType[]? RequestedRiskLimitType {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RequestedRiskLimitType is not null && RequestedRiskLimitType.Length != 0)
			{
				writer.WriteWholeNumber(1668, RequestedRiskLimitType.Length);
				for (int i = 0; i < RequestedRiskLimitType.Length; i++)
				{
					((IFixEncoder)RequestedRiskLimitType[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRequestedRiskLimitType") is IMessageView viewNoRequestedRiskLimitType)
			{
				var count = viewNoRequestedRiskLimitType.GroupCount();
				RequestedRiskLimitType = new NoRequestedRiskLimitType[count];
				for (int i = 0; i < count; i++)
				{
					RequestedRiskLimitType[i] = new();
					((IFixParser)RequestedRiskLimitType[i]).Parse(viewNoRequestedRiskLimitType.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRequestedRiskLimitType":
				{
					value = RequestedRiskLimitType;
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
			RequestedRiskLimitType = null;
		}
	}
}
