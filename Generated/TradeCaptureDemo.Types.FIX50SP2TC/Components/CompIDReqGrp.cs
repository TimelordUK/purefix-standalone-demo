using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class CompIDReqGrp : IFixComponent
	{
		public sealed partial class NoCompIDs : IFixGroup
		{
			[TagDetails(Tag = 930, Type = TagType.String, Offset = 0, Required = false)]
			public string? RefCompID {get; set;}
			
			[TagDetails(Tag = 931, Type = TagType.String, Offset = 1, Required = false)]
			public string? RefSubID {get; set;}
			
			[TagDetails(Tag = 283, Type = TagType.String, Offset = 2, Required = false)]
			public string? LocationID {get; set;}
			
			[TagDetails(Tag = 284, Type = TagType.String, Offset = 3, Required = false)]
			public string? DeskID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RefCompID is not null) writer.WriteString(930, RefCompID);
				if (RefSubID is not null) writer.WriteString(931, RefSubID);
				if (LocationID is not null) writer.WriteString(283, LocationID);
				if (DeskID is not null) writer.WriteString(284, DeskID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RefCompID = view.GetString(930);
				RefSubID = view.GetString(931);
				LocationID = view.GetString(283);
				DeskID = view.GetString(284);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RefCompID":
					{
						value = RefCompID;
						break;
					}
					case "RefSubID":
					{
						value = RefSubID;
						break;
					}
					case "LocationID":
					{
						value = LocationID;
						break;
					}
					case "DeskID":
					{
						value = DeskID;
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
				RefCompID = null;
				RefSubID = null;
				LocationID = null;
				DeskID = null;
			}
		}
		[Group(NoOfTag = 936, Offset = 0, Required = false)]
		public NoCompIDs[]? CompIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (CompIDs is not null && CompIDs.Length != 0)
			{
				writer.WriteWholeNumber(936, CompIDs.Length);
				for (int i = 0; i < CompIDs.Length; i++)
				{
					((IFixEncoder)CompIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoCompIDs") is IMessageView viewNoCompIDs)
			{
				var count = viewNoCompIDs.GroupCount();
				CompIDs = new NoCompIDs[count];
				for (int i = 0; i < count; i++)
				{
					CompIDs[i] = new();
					((IFixParser)CompIDs[i]).Parse(viewNoCompIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoCompIDs":
				{
					value = CompIDs;
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
			CompIDs = null;
		}
	}
}
