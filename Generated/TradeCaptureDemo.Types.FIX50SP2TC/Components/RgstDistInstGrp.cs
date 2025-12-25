using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RgstDistInstGrp : IFixComponent
	{
		public sealed partial class NoDistribInsts : IFixGroup
		{
			[TagDetails(Tag = 477, Type = TagType.Int, Offset = 0, Required = false)]
			public int? DistribPaymentMethod {get; set;}
			
			[TagDetails(Tag = 512, Type = TagType.Float, Offset = 1, Required = false)]
			public double? DistribPercentage {get; set;}
			
			[TagDetails(Tag = 478, Type = TagType.String, Offset = 2, Required = false)]
			public string? CashDistribCurr {get; set;}
			
			[TagDetails(Tag = 498, Type = TagType.String, Offset = 3, Required = false)]
			public string? CashDistribAgentName {get; set;}
			
			[TagDetails(Tag = 499, Type = TagType.String, Offset = 4, Required = false)]
			public string? CashDistribAgentCode {get; set;}
			
			[TagDetails(Tag = 500, Type = TagType.String, Offset = 5, Required = false)]
			public string? CashDistribAgentAcctNumber {get; set;}
			
			[TagDetails(Tag = 501, Type = TagType.String, Offset = 6, Required = false)]
			public string? CashDistribPayRef {get; set;}
			
			[TagDetails(Tag = 502, Type = TagType.String, Offset = 7, Required = false)]
			public string? CashDistribAgentAcctName {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (DistribPaymentMethod is not null) writer.WriteWholeNumber(477, DistribPaymentMethod.Value);
				if (DistribPercentage is not null) writer.WriteNumber(512, DistribPercentage.Value);
				if (CashDistribCurr is not null) writer.WriteString(478, CashDistribCurr);
				if (CashDistribAgentName is not null) writer.WriteString(498, CashDistribAgentName);
				if (CashDistribAgentCode is not null) writer.WriteString(499, CashDistribAgentCode);
				if (CashDistribAgentAcctNumber is not null) writer.WriteString(500, CashDistribAgentAcctNumber);
				if (CashDistribPayRef is not null) writer.WriteString(501, CashDistribPayRef);
				if (CashDistribAgentAcctName is not null) writer.WriteString(502, CashDistribAgentAcctName);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				DistribPaymentMethod = view.GetInt32(477);
				DistribPercentage = view.GetDouble(512);
				CashDistribCurr = view.GetString(478);
				CashDistribAgentName = view.GetString(498);
				CashDistribAgentCode = view.GetString(499);
				CashDistribAgentAcctNumber = view.GetString(500);
				CashDistribPayRef = view.GetString(501);
				CashDistribAgentAcctName = view.GetString(502);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "DistribPaymentMethod":
					{
						value = DistribPaymentMethod;
						break;
					}
					case "DistribPercentage":
					{
						value = DistribPercentage;
						break;
					}
					case "CashDistribCurr":
					{
						value = CashDistribCurr;
						break;
					}
					case "CashDistribAgentName":
					{
						value = CashDistribAgentName;
						break;
					}
					case "CashDistribAgentCode":
					{
						value = CashDistribAgentCode;
						break;
					}
					case "CashDistribAgentAcctNumber":
					{
						value = CashDistribAgentAcctNumber;
						break;
					}
					case "CashDistribPayRef":
					{
						value = CashDistribPayRef;
						break;
					}
					case "CashDistribAgentAcctName":
					{
						value = CashDistribAgentAcctName;
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
				DistribPaymentMethod = null;
				DistribPercentage = null;
				CashDistribCurr = null;
				CashDistribAgentName = null;
				CashDistribAgentCode = null;
				CashDistribAgentAcctNumber = null;
				CashDistribPayRef = null;
				CashDistribAgentAcctName = null;
			}
		}
		[Group(NoOfTag = 510, Offset = 0, Required = false)]
		public NoDistribInsts[]? DistribInsts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DistribInsts is not null && DistribInsts.Length != 0)
			{
				writer.WriteWholeNumber(510, DistribInsts.Length);
				for (int i = 0; i < DistribInsts.Length; i++)
				{
					((IFixEncoder)DistribInsts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoDistribInsts") is IMessageView viewNoDistribInsts)
			{
				var count = viewNoDistribInsts.GroupCount();
				DistribInsts = new NoDistribInsts[count];
				for (int i = 0; i < count; i++)
				{
					DistribInsts[i] = new();
					((IFixParser)DistribInsts[i]).Parse(viewNoDistribInsts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoDistribInsts":
				{
					value = DistribInsts;
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
			DistribInsts = null;
		}
	}
}
