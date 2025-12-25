using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class AuctionTypeRuleGrp : IFixComponent
	{
		public sealed partial class NoAuctionTypeRules : IFixGroup
		{
			[TagDetails(Tag = 1803, Type = TagType.Int, Offset = 0, Required = false)]
			public int? AuctionType {get; set;}
			
			[TagDetails(Tag = 2549, Type = TagType.String, Offset = 1, Required = false)]
			public string? AuctionTypeProductComplex {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AuctionType is not null) writer.WriteWholeNumber(1803, AuctionType.Value);
				if (AuctionTypeProductComplex is not null) writer.WriteString(2549, AuctionTypeProductComplex);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AuctionType = view.GetInt32(1803);
				AuctionTypeProductComplex = view.GetString(2549);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AuctionType":
					{
						value = AuctionType;
						break;
					}
					case "AuctionTypeProductComplex":
					{
						value = AuctionTypeProductComplex;
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
				AuctionType = null;
				AuctionTypeProductComplex = null;
			}
		}
		[Group(NoOfTag = 2548, Offset = 0, Required = false)]
		public NoAuctionTypeRules[]? AuctionTypeRules {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AuctionTypeRules is not null && AuctionTypeRules.Length != 0)
			{
				writer.WriteWholeNumber(2548, AuctionTypeRules.Length);
				for (int i = 0; i < AuctionTypeRules.Length; i++)
				{
					((IFixEncoder)AuctionTypeRules[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAuctionTypeRules") is IMessageView viewNoAuctionTypeRules)
			{
				var count = viewNoAuctionTypeRules.GroupCount();
				AuctionTypeRules = new NoAuctionTypeRules[count];
				for (int i = 0; i < count; i++)
				{
					AuctionTypeRules[i] = new();
					((IFixParser)AuctionTypeRules[i]).Parse(viewNoAuctionTypeRules.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAuctionTypeRules":
				{
					value = AuctionTypeRules;
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
			AuctionTypeRules = null;
		}
	}
}
