using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ProvisionPtysSubGrp : IFixComponent
	{
		public sealed partial class NoProvisionPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 40179, Type = TagType.String, Offset = 0, Required = false)]
			public string? ProvisionPartySubID {get; set;}
			
			[TagDetails(Tag = 40180, Type = TagType.Int, Offset = 1, Required = false)]
			public int? ProvisionPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ProvisionPartySubID is not null) writer.WriteString(40179, ProvisionPartySubID);
				if (ProvisionPartySubIDType is not null) writer.WriteWholeNumber(40180, ProvisionPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ProvisionPartySubID = view.GetString(40179);
				ProvisionPartySubIDType = view.GetInt32(40180);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ProvisionPartySubID":
					{
						value = ProvisionPartySubID;
						break;
					}
					case "ProvisionPartySubIDType":
					{
						value = ProvisionPartySubIDType;
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
				ProvisionPartySubID = null;
				ProvisionPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 40178, Offset = 0, Required = false)]
		public NoProvisionPartySubIDs[]? ProvisionPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ProvisionPartySubIDs is not null && ProvisionPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(40178, ProvisionPartySubIDs.Length);
				for (int i = 0; i < ProvisionPartySubIDs.Length; i++)
				{
					((IFixEncoder)ProvisionPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoProvisionPartySubIDs") is IMessageView viewNoProvisionPartySubIDs)
			{
				var count = viewNoProvisionPartySubIDs.GroupCount();
				ProvisionPartySubIDs = new NoProvisionPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					ProvisionPartySubIDs[i] = new();
					((IFixParser)ProvisionPartySubIDs[i]).Parse(viewNoProvisionPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoProvisionPartySubIDs":
				{
					value = ProvisionPartySubIDs;
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
			ProvisionPartySubIDs = null;
		}
	}
}
