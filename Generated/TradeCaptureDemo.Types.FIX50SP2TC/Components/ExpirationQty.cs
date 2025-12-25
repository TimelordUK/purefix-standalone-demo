using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ExpirationQty : IFixComponent
	{
		public sealed partial class NoExpiration : IFixGroup
		{
			[TagDetails(Tag = 982, Type = TagType.Int, Offset = 0, Required = false)]
			public int? ExpirationQtyType {get; set;}
			
			[TagDetails(Tag = 983, Type = TagType.Float, Offset = 1, Required = false)]
			public double? ExpQty {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ExpirationQtyType is not null) writer.WriteWholeNumber(982, ExpirationQtyType.Value);
				if (ExpQty is not null) writer.WriteNumber(983, ExpQty.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ExpirationQtyType = view.GetInt32(982);
				ExpQty = view.GetDouble(983);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ExpirationQtyType":
					{
						value = ExpirationQtyType;
						break;
					}
					case "ExpQty":
					{
						value = ExpQty;
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
				ExpirationQtyType = null;
				ExpQty = null;
			}
		}
		[Group(NoOfTag = 981, Offset = 0, Required = false)]
		public NoExpiration[]? Expiration {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Expiration is not null && Expiration.Length != 0)
			{
				writer.WriteWholeNumber(981, Expiration.Length);
				for (int i = 0; i < Expiration.Length; i++)
				{
					((IFixEncoder)Expiration[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoExpiration") is IMessageView viewNoExpiration)
			{
				var count = viewNoExpiration.GroupCount();
				Expiration = new NoExpiration[count];
				for (int i = 0; i < count; i++)
				{
					Expiration[i] = new();
					((IFixParser)Expiration[i]).Parse(viewNoExpiration.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoExpiration":
				{
					value = Expiration;
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
			Expiration = null;
		}
	}
}
