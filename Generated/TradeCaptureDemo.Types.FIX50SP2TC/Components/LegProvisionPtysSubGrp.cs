using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class LegProvisionPtysSubGrp : IFixComponent
	{
		public sealed partial class NoLegProvisionPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 40538, Type = TagType.String, Offset = 0, Required = false)]
			public string? LegProvisionPartySubID {get; set;}
			
			[TagDetails(Tag = 40539, Type = TagType.Int, Offset = 1, Required = false)]
			public int? LegProvisionPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (LegProvisionPartySubID is not null) writer.WriteString(40538, LegProvisionPartySubID);
				if (LegProvisionPartySubIDType is not null) writer.WriteWholeNumber(40539, LegProvisionPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				LegProvisionPartySubID = view.GetString(40538);
				LegProvisionPartySubIDType = view.GetInt32(40539);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "LegProvisionPartySubID":
					{
						value = LegProvisionPartySubID;
						break;
					}
					case "LegProvisionPartySubIDType":
					{
						value = LegProvisionPartySubIDType;
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
				LegProvisionPartySubID = null;
				LegProvisionPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 40537, Offset = 0, Required = false)]
		public NoLegProvisionPartySubIDs[]? LegProvisionPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (LegProvisionPartySubIDs is not null && LegProvisionPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(40537, LegProvisionPartySubIDs.Length);
				for (int i = 0; i < LegProvisionPartySubIDs.Length; i++)
				{
					((IFixEncoder)LegProvisionPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoLegProvisionPartySubIDs") is IMessageView viewNoLegProvisionPartySubIDs)
			{
				var count = viewNoLegProvisionPartySubIDs.GroupCount();
				LegProvisionPartySubIDs = new NoLegProvisionPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					LegProvisionPartySubIDs[i] = new();
					((IFixParser)LegProvisionPartySubIDs[i]).Parse(viewNoLegProvisionPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoLegProvisionPartySubIDs":
				{
					value = LegProvisionPartySubIDs;
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
			LegProvisionPartySubIDs = null;
		}
	}
}
