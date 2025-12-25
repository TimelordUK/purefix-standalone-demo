using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AffectedOrdGrp : IFixComponent
	{
		public sealed partial class NoAffectedOrders : IFixGroup
		{
			[TagDetails(Tag = 1824, Type = TagType.String, Offset = 0, Required = false)]
			public string? AffectedOrigClOrdID {get; set;}
			
			[TagDetails(Tag = 535, Type = TagType.String, Offset = 1, Required = false)]
			public string? AffectedOrderID {get; set;}
			
			[TagDetails(Tag = 536, Type = TagType.String, Offset = 2, Required = false)]
			public string? AffectedSecondaryOrderID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AffectedOrigClOrdID is not null) writer.WriteString(1824, AffectedOrigClOrdID);
				if (AffectedOrderID is not null) writer.WriteString(535, AffectedOrderID);
				if (AffectedSecondaryOrderID is not null) writer.WriteString(536, AffectedSecondaryOrderID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AffectedOrigClOrdID = view.GetString(1824);
				AffectedOrderID = view.GetString(535);
				AffectedSecondaryOrderID = view.GetString(536);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AffectedOrigClOrdID":
					{
						value = AffectedOrigClOrdID;
						break;
					}
					case "AffectedOrderID":
					{
						value = AffectedOrderID;
						break;
					}
					case "AffectedSecondaryOrderID":
					{
						value = AffectedSecondaryOrderID;
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
				AffectedOrigClOrdID = null;
				AffectedOrderID = null;
				AffectedSecondaryOrderID = null;
			}
		}
		[Group(NoOfTag = 534, Offset = 0, Required = false)]
		public NoAffectedOrders[]? AffectedOrders {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AffectedOrders is not null && AffectedOrders.Length != 0)
			{
				writer.WriteWholeNumber(534, AffectedOrders.Length);
				for (int i = 0; i < AffectedOrders.Length; i++)
				{
					((IFixEncoder)AffectedOrders[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAffectedOrders") is IMessageView viewNoAffectedOrders)
			{
				var count = viewNoAffectedOrders.GroupCount();
				AffectedOrders = new NoAffectedOrders[count];
				for (int i = 0; i < count; i++)
				{
					AffectedOrders[i] = new();
					((IFixParser)AffectedOrders[i]).Parse(viewNoAffectedOrders.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAffectedOrders":
				{
					value = AffectedOrders;
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
			AffectedOrders = null;
		}
	}
}
