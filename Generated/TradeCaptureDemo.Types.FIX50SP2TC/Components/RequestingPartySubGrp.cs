using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RequestingPartySubGrp : IFixComponent
	{
		public sealed partial class NoRequestingPartySubIDs : IFixGroup
		{
			[TagDetails(Tag = 1662, Type = TagType.String, Offset = 0, Required = false)]
			public string? RequestingPartySubID {get; set;}
			
			[TagDetails(Tag = 1663, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RequestingPartySubIDType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RequestingPartySubID is not null) writer.WriteString(1662, RequestingPartySubID);
				if (RequestingPartySubIDType is not null) writer.WriteWholeNumber(1663, RequestingPartySubIDType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RequestingPartySubID = view.GetString(1662);
				RequestingPartySubIDType = view.GetInt32(1663);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RequestingPartySubID":
					{
						value = RequestingPartySubID;
						break;
					}
					case "RequestingPartySubIDType":
					{
						value = RequestingPartySubIDType;
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
				RequestingPartySubID = null;
				RequestingPartySubIDType = null;
			}
		}
		[Group(NoOfTag = 1661, Offset = 0, Required = false)]
		public NoRequestingPartySubIDs[]? RequestingPartySubIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RequestingPartySubIDs is not null && RequestingPartySubIDs.Length != 0)
			{
				writer.WriteWholeNumber(1661, RequestingPartySubIDs.Length);
				for (int i = 0; i < RequestingPartySubIDs.Length; i++)
				{
					((IFixEncoder)RequestingPartySubIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRequestingPartySubIDs") is IMessageView viewNoRequestingPartySubIDs)
			{
				var count = viewNoRequestingPartySubIDs.GroupCount();
				RequestingPartySubIDs = new NoRequestingPartySubIDs[count];
				for (int i = 0; i < count; i++)
				{
					RequestingPartySubIDs[i] = new();
					((IFixParser)RequestingPartySubIDs[i]).Parse(viewNoRequestingPartySubIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRequestingPartySubIDs":
				{
					value = RequestingPartySubIDs;
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
			RequestingPartySubIDs = null;
		}
	}
}
