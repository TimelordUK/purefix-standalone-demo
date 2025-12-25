using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RequestedPartyRoleGrp : IFixComponent
	{
		public sealed partial class NoRequestedPartyRoles : IFixGroup
		{
			[TagDetails(Tag = 1509, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RequestedPartyRole {get; set;}
			
			[TagDetails(Tag = 2386, Type = TagType.Int, Offset = 1, Required = false)]
			public int? RequestedPartyRoleQualifier {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RequestedPartyRole is not null) writer.WriteWholeNumber(1509, RequestedPartyRole.Value);
				if (RequestedPartyRoleQualifier is not null) writer.WriteWholeNumber(2386, RequestedPartyRoleQualifier.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RequestedPartyRole = view.GetInt32(1509);
				RequestedPartyRoleQualifier = view.GetInt32(2386);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RequestedPartyRole":
					{
						value = RequestedPartyRole;
						break;
					}
					case "RequestedPartyRoleQualifier":
					{
						value = RequestedPartyRoleQualifier;
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
				RequestedPartyRole = null;
				RequestedPartyRoleQualifier = null;
			}
		}
		[Group(NoOfTag = 1508, Offset = 0, Required = false)]
		public NoRequestedPartyRoles[]? RequestedPartyRoles {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RequestedPartyRoles is not null && RequestedPartyRoles.Length != 0)
			{
				writer.WriteWholeNumber(1508, RequestedPartyRoles.Length);
				for (int i = 0; i < RequestedPartyRoles.Length; i++)
				{
					((IFixEncoder)RequestedPartyRoles[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRequestedPartyRoles") is IMessageView viewNoRequestedPartyRoles)
			{
				var count = viewNoRequestedPartyRoles.GroupCount();
				RequestedPartyRoles = new NoRequestedPartyRoles[count];
				for (int i = 0; i < count; i++)
				{
					RequestedPartyRoles[i] = new();
					((IFixParser)RequestedPartyRoles[i]).Parse(viewNoRequestedPartyRoles.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRequestedPartyRoles":
				{
					value = RequestedPartyRoles;
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
			RequestedPartyRoles = null;
		}
	}
}
