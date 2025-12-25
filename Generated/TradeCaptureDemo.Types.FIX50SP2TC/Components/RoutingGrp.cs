using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RoutingGrp : IFixComponent
	{
		public sealed partial class NoRoutingIDs : IFixGroup
		{
			[TagDetails(Tag = 216, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RoutingType {get; set;}
			
			[TagDetails(Tag = 217, Type = TagType.String, Offset = 1, Required = false)]
			public string? RoutingID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RoutingType is not null) writer.WriteWholeNumber(216, RoutingType.Value);
				if (RoutingID is not null) writer.WriteString(217, RoutingID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RoutingType = view.GetInt32(216);
				RoutingID = view.GetString(217);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RoutingType":
					{
						value = RoutingType;
						break;
					}
					case "RoutingID":
					{
						value = RoutingID;
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
				RoutingType = null;
				RoutingID = null;
			}
		}
		[Group(NoOfTag = 215, Offset = 0, Required = false)]
		public NoRoutingIDs[]? RoutingIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RoutingIDs is not null && RoutingIDs.Length != 0)
			{
				writer.WriteWholeNumber(215, RoutingIDs.Length);
				for (int i = 0; i < RoutingIDs.Length; i++)
				{
					((IFixEncoder)RoutingIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRoutingIDs") is IMessageView viewNoRoutingIDs)
			{
				var count = viewNoRoutingIDs.GroupCount();
				RoutingIDs = new NoRoutingIDs[count];
				for (int i = 0; i < count; i++)
				{
					RoutingIDs[i] = new();
					((IFixParser)RoutingIDs[i]).Parse(viewNoRoutingIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRoutingIDs":
				{
					value = RoutingIDs;
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
			RoutingIDs = null;
		}
	}
}
