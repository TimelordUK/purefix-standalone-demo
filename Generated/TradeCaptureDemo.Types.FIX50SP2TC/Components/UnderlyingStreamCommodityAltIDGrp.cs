using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingStreamCommodityAltIDGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingStreamCommodityAltIDs : IFixGroup
		{
			[TagDetails(Tag = 41991, Type = TagType.String, Offset = 0, Required = false)]
			public string? UnderlyingStreamCommodityAltID {get; set;}
			
			[TagDetails(Tag = 41992, Type = TagType.String, Offset = 1, Required = false)]
			public string? UnderlyingStreamCommodityAltIDSource {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingStreamCommodityAltID is not null) writer.WriteString(41991, UnderlyingStreamCommodityAltID);
				if (UnderlyingStreamCommodityAltIDSource is not null) writer.WriteString(41992, UnderlyingStreamCommodityAltIDSource);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingStreamCommodityAltID = view.GetString(41991);
				UnderlyingStreamCommodityAltIDSource = view.GetString(41992);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingStreamCommodityAltID":
					{
						value = UnderlyingStreamCommodityAltID;
						break;
					}
					case "UnderlyingStreamCommodityAltIDSource":
					{
						value = UnderlyingStreamCommodityAltIDSource;
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
				UnderlyingStreamCommodityAltID = null;
				UnderlyingStreamCommodityAltIDSource = null;
			}
		}
		[Group(NoOfTag = 41990, Offset = 0, Required = false)]
		public NoUnderlyingStreamCommodityAltIDs[]? UnderlyingStreamCommodityAltIDs {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingStreamCommodityAltIDs is not null && UnderlyingStreamCommodityAltIDs.Length != 0)
			{
				writer.WriteWholeNumber(41990, UnderlyingStreamCommodityAltIDs.Length);
				for (int i = 0; i < UnderlyingStreamCommodityAltIDs.Length; i++)
				{
					((IFixEncoder)UnderlyingStreamCommodityAltIDs[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingStreamCommodityAltIDs") is IMessageView viewNoUnderlyingStreamCommodityAltIDs)
			{
				var count = viewNoUnderlyingStreamCommodityAltIDs.GroupCount();
				UnderlyingStreamCommodityAltIDs = new NoUnderlyingStreamCommodityAltIDs[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingStreamCommodityAltIDs[i] = new();
					((IFixParser)UnderlyingStreamCommodityAltIDs[i]).Parse(viewNoUnderlyingStreamCommodityAltIDs.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingStreamCommodityAltIDs":
				{
					value = UnderlyingStreamCommodityAltIDs;
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
			UnderlyingStreamCommodityAltIDs = null;
		}
	}
}
