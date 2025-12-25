using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class NotAffectedOrdGrp : IFixComponent
	{
		public sealed partial class NoNotAffectedOrders : IFixGroup
		{
			[TagDetails(Tag = 1372, Type = TagType.String, Offset = 0, Required = false)]
			public string? NotAffOrigClOrdID {get; set;}
			
			[TagDetails(Tag = 1371, Type = TagType.String, Offset = 1, Required = false)]
			public string? NotAffectedOrderID {get; set;}
			
			[TagDetails(Tag = 1825, Type = TagType.String, Offset = 2, Required = false)]
			public string? NotAffSecondaryOrderID {get; set;}
			
			[TagDetails(Tag = 2677, Type = TagType.Int, Offset = 3, Required = false)]
			public int? NotAffectedReason {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (NotAffOrigClOrdID is not null) writer.WriteString(1372, NotAffOrigClOrdID);
				if (NotAffectedOrderID is not null) writer.WriteString(1371, NotAffectedOrderID);
				if (NotAffSecondaryOrderID is not null) writer.WriteString(1825, NotAffSecondaryOrderID);
				if (NotAffectedReason is not null) writer.WriteWholeNumber(2677, NotAffectedReason.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				NotAffOrigClOrdID = view.GetString(1372);
				NotAffectedOrderID = view.GetString(1371);
				NotAffSecondaryOrderID = view.GetString(1825);
				NotAffectedReason = view.GetInt32(2677);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "NotAffOrigClOrdID":
					{
						value = NotAffOrigClOrdID;
						break;
					}
					case "NotAffectedOrderID":
					{
						value = NotAffectedOrderID;
						break;
					}
					case "NotAffSecondaryOrderID":
					{
						value = NotAffSecondaryOrderID;
						break;
					}
					case "NotAffectedReason":
					{
						value = NotAffectedReason;
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
				NotAffOrigClOrdID = null;
				NotAffectedOrderID = null;
				NotAffSecondaryOrderID = null;
				NotAffectedReason = null;
			}
		}
		[Group(NoOfTag = 1370, Offset = 0, Required = false)]
		public NoNotAffectedOrders[]? NotAffectedOrders {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (NotAffectedOrders is not null && NotAffectedOrders.Length != 0)
			{
				writer.WriteWholeNumber(1370, NotAffectedOrders.Length);
				for (int i = 0; i < NotAffectedOrders.Length; i++)
				{
					((IFixEncoder)NotAffectedOrders[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoNotAffectedOrders") is IMessageView viewNoNotAffectedOrders)
			{
				var count = viewNoNotAffectedOrders.GroupCount();
				NotAffectedOrders = new NoNotAffectedOrders[count];
				for (int i = 0; i < count; i++)
				{
					NotAffectedOrders[i] = new();
					((IFixParser)NotAffectedOrders[i]).Parse(viewNoNotAffectedOrders.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoNotAffectedOrders":
				{
					value = NotAffectedOrders;
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
			NotAffectedOrders = null;
		}
	}
}
