using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MiscFeesGrp : IFixComponent
	{
		public sealed partial class NoMiscFees : IFixGroup
		{
			[TagDetails(Tag = 137, Type = TagType.Float, Offset = 0, Required = false)]
			public double? MiscFeeAmt {get; set;}
			
			[TagDetails(Tag = 138, Type = TagType.String, Offset = 1, Required = false)]
			public string? MiscFeeCurr {get; set;}
			
			[TagDetails(Tag = 139, Type = TagType.String, Offset = 2, Required = false)]
			public string? MiscFeeType {get; set;}
			
			[TagDetails(Tag = 2712, Type = TagType.Int, Offset = 3, Required = false)]
			public int? MiscFeeQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public MiscFeesSubGrp? MiscFeesSubGrp {get; set;}
			
			[TagDetails(Tag = 891, Type = TagType.Int, Offset = 5, Required = false)]
			public int? MiscFeeBasis {get; set;}
			
			[TagDetails(Tag = 2216, Type = TagType.Float, Offset = 6, Required = false)]
			public double? MiscFeeRate {get; set;}
			
			[TagDetails(Tag = 2217, Type = TagType.Float, Offset = 7, Required = false)]
			public double? MiscFeeAmountDue {get; set;}
			
			[TagDetails(Tag = 2713, Type = TagType.String, Offset = 8, Required = false)]
			public string? MiscFeeDesc {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (MiscFeeAmt is not null) writer.WriteNumber(137, MiscFeeAmt.Value);
				if (MiscFeeCurr is not null) writer.WriteString(138, MiscFeeCurr);
				if (MiscFeeType is not null) writer.WriteString(139, MiscFeeType);
				if (MiscFeeQualifier is not null) writer.WriteWholeNumber(2712, MiscFeeQualifier.Value);
				if (MiscFeesSubGrp is not null) ((IFixEncoder)MiscFeesSubGrp).Encode(writer);
				if (MiscFeeBasis is not null) writer.WriteWholeNumber(891, MiscFeeBasis.Value);
				if (MiscFeeRate is not null) writer.WriteNumber(2216, MiscFeeRate.Value);
				if (MiscFeeAmountDue is not null) writer.WriteNumber(2217, MiscFeeAmountDue.Value);
				if (MiscFeeDesc is not null) writer.WriteString(2713, MiscFeeDesc);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				MiscFeeAmt = view.GetDouble(137);
				MiscFeeCurr = view.GetString(138);
				MiscFeeType = view.GetString(139);
				MiscFeeQualifier = view.GetInt32(2712);
				if (view.GetView("MiscFeesSubGrp") is IMessageView viewMiscFeesSubGrp)
				{
					MiscFeesSubGrp = new();
					((IFixParser)MiscFeesSubGrp).Parse(viewMiscFeesSubGrp);
				}
				MiscFeeBasis = view.GetInt32(891);
				MiscFeeRate = view.GetDouble(2216);
				MiscFeeAmountDue = view.GetDouble(2217);
				MiscFeeDesc = view.GetString(2713);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "MiscFeeAmt":
					{
						value = MiscFeeAmt;
						break;
					}
					case "MiscFeeCurr":
					{
						value = MiscFeeCurr;
						break;
					}
					case "MiscFeeType":
					{
						value = MiscFeeType;
						break;
					}
					case "MiscFeeQualifier":
					{
						value = MiscFeeQualifier;
						break;
					}
					case "MiscFeesSubGrp":
					{
						value = MiscFeesSubGrp;
						break;
					}
					case "MiscFeeBasis":
					{
						value = MiscFeeBasis;
						break;
					}
					case "MiscFeeRate":
					{
						value = MiscFeeRate;
						break;
					}
					case "MiscFeeAmountDue":
					{
						value = MiscFeeAmountDue;
						break;
					}
					case "MiscFeeDesc":
					{
						value = MiscFeeDesc;
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
				MiscFeeAmt = null;
				MiscFeeCurr = null;
				MiscFeeType = null;
				MiscFeeQualifier = null;
				((IFixReset?)MiscFeesSubGrp)?.Reset();
				MiscFeeBasis = null;
				MiscFeeRate = null;
				MiscFeeAmountDue = null;
				MiscFeeDesc = null;
			}
		}
		[Group(NoOfTag = 136, Offset = 0, Required = false)]
		public NoMiscFees[]? MiscFees {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (MiscFees is not null && MiscFees.Length != 0)
			{
				writer.WriteWholeNumber(136, MiscFees.Length);
				for (int i = 0; i < MiscFees.Length; i++)
				{
					((IFixEncoder)MiscFees[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoMiscFees") is IMessageView viewNoMiscFees)
			{
				var count = viewNoMiscFees.GroupCount();
				MiscFees = new NoMiscFees[count];
				for (int i = 0; i < count; i++)
				{
					MiscFees[i] = new();
					((IFixParser)MiscFees[i]).Parse(viewNoMiscFees.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoMiscFees":
				{
					value = MiscFees;
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
			MiscFees = null;
		}
	}
}
