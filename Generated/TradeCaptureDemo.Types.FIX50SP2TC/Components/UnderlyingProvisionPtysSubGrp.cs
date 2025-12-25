using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingProvisionPtysSubGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingProvisionPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 42178, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingProvisionPartySubID {get; set;}
			
			[TagDetails(Tag = 42179, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingProvisionPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingProvisionPartySubID is not null) writer.WriteString(42178, UnderlyingProvisionPartySubID);
				if (UnderlyingProvisionPartySubIDType is not null) writer.WriteWholeNumber(42179, UnderlyingProvisionPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingProvisionPartySubID = view.GetString(42178);
				UnderlyingProvisionPartySubIDType = view.GetInt32(42179);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingProvisionPartySubID":
					{
						value = UnderlyingProvisionPartySubID;
						break;
					}
					case "UnderlyingProvisionPartySubIDType":
					{
						value = UnderlyingProvisionPartySubIDType;
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
				UnderlyingProvisionPartySubID = null;
				UnderlyingProvisionPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 42177, Offset = 0, Required = false)]
		public NoUnderlyingProvisionPartySubIDs[]? UnderlyingProvisionPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingProvisionPartySubIDs is not null && UnderlyingProvisionPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(42177, UnderlyingProvisionPartySubIDs.Length);
				for (int i = 0; i < UnderlyingProvisionPartySubIDs.Length; i++)
				{
					((IFixEncoder)UnderlyingProvisionPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingProvisionPartySubIDs") is IMessageView viewNoUnderlyingProvisionPartySubIDs)
			{
				var count = viewNoUnderlyingProvisionPartySubIDs.GroupCount();
				UnderlyingProvisionPartySubIDs = new NoUnderlyingProvisionPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingProvisionPartySubIDs[i] = new();
					((IFixParser)UnderlyingProvisionPartySubIDs[i]).Parse(viewNoUnderlyingProvisionPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingProvisionPartySubIDs":
				{
					value = UnderlyingProvisionPartySubIDs;
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
			UnderlyingProvisionPartySubIDs = null;
		}
	}
}
