using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RequestingPartyGrp : IFixComponent
	{
		public sealed partial class NoRequestingPartyIDs : IFixGroup
		{
			[TagDetails(Tag = 1658, Type = TagType.String, Offset = 0, Required = false)]
			public string? RequestingPartyID {get; set;}
			
			[TagDetails(Tag = 1659, Type = TagType.String, Offset = 1, Required = false)]
			public string? RequestingPartyIDSource {get; set;}
			
			[TagDetails(Tag = 1660, Type = TagType.Int, Offset = 2, Required = false)]
			public int? RequestingPartyRole {get; set;}
			
			[TagDetails(Tag = 2338, Type = TagType.Int, Offset = 3, Required = false)]
			public int? RequestingPartyRoleQualifier {get; set;}
			
			[Component(Offset = 4, Required = false)]
			public RequestingPartySubGrp? RequestingPartySubGrp {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RequestingPartyID is not null) writer.WriteString(1658, RequestingPartyID);
				if (RequestingPartyIDSource is not null) writer.WriteString(1659, RequestingPartyIDSource);
				if (RequestingPartyRole is not null) writer.WriteWholeNumber(1660, RequestingPartyRole.Value);
				if (RequestingPartyRoleQualifier is not null) writer.WriteWholeNumber(2338, RequestingPartyRoleQualifier.Value);
				if (RequestingPartySubGrp is not null) ((IFixEncoder)RequestingPartySubGrp).Encode(writer);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RequestingPartyID = view.GetString(1658);
				RequestingPartyIDSource = view.GetString(1659);
				RequestingPartyRole = view.GetInt32(1660);
				RequestingPartyRoleQualifier = view.GetInt32(2338);
				if (view.GetView("RequestingPartySubGrp") is IMessageView viewRequestingPartySubGrp)
				{
					RequestingPartySubGrp = new();
					((IFixParser)RequestingPartySubGrp).Parse(viewRequestingPartySubGrp);
				}
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RequestingPartyID":
					{
						value = RequestingPartyID;
						break;
					}
					case "RequestingPartyIDSource":
					{
						value = RequestingPartyIDSource;
						break;
					}
					case "RequestingPartyRole":
					{
						value = RequestingPartyRole;
						break;
					}
					case "RequestingPartyRoleQualifier":
					{
						value = RequestingPartyRoleQualifier;
						break;
					}
					case "RequestingPartySubGrp":
					{
						value = RequestingPartySubGrp;
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
				RequestingPartyID = null;
				RequestingPartyIDSource = null;
				RequestingPartyRole = null;
				RequestingPartyRoleQualifier = null;
				((IFixReset?)RequestingPartySubGrp)?.Reset();
			}
		}
		[Group(NoOfTag = 1657, Offset = 0, Required = false)]
		public NoRequestingPartyIDs[]? RequestingPartyIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RequestingPartyIDs is not null && RequestingPartyIDs.Length != 0)
			{
				writer.WriteWholeNumber(1657, RequestingPartyIDs.Length);
				for (int i = 0; i < RequestingPartyIDs.Length; i++)
				{
					((IFixEncoder)RequestingPartyIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRequestingPartyIDs") is IMessageView viewNoRequestingPartyIDs)
			{
				var count = viewNoRequestingPartyIDs.GroupCount();
				RequestingPartyIDs = new NoRequestingPartyIDs[count];
				for (int i = 0; i < count; i++)
				{
					RequestingPartyIDs[i] = new();
					((IFixParser)RequestingPartyIDs[i]).Parse(viewNoRequestingPartyIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRequestingPartyIDs":
				{
					value = RequestingPartyIDs;
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
			RequestingPartyIDs = null;
		}
	}
}
