using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class ThrottleMsgTypeGrp : IFixComponent
	{
		public sealed partial class NoThrottleMsgType : IFixGroup
		{
			[TagDetails(Tag = 1619, Type = TagType.String, Offset = 0, Required = false)]
			public string? ThrottleMsgType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (ThrottleMsgType is not null) writer.WriteString(1619, ThrottleMsgType);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				ThrottleMsgType = view.GetString(1619);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "ThrottleMsgType":
					{
						value = ThrottleMsgType;
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
				ThrottleMsgType = null;
			}
		}
		[Group(NoOfTag = 1618, Offset = 0, Required = false)]
		public NoThrottleMsgType[]? ThrottleMsgType {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (ThrottleMsgType is not null && ThrottleMsgType.Length != 0)
			{
				writer.WriteWholeNumber(1618, ThrottleMsgType.Length);
				for (int i = 0; i < ThrottleMsgType.Length; i++)
				{
					((IFixEncoder)ThrottleMsgType[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoThrottleMsgType") is IMessageView viewNoThrottleMsgType)
			{
				var count = viewNoThrottleMsgType.GroupCount();
				ThrottleMsgType = new NoThrottleMsgType[count];
				for (int i = 0; i < count; i++)
				{
					ThrottleMsgType[i] = new();
					((IFixParser)ThrottleMsgType[i]).Parse(viewNoThrottleMsgType.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoThrottleMsgType":
				{
					value = ThrottleMsgType;
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
			ThrottleMsgType = null;
		}
	}
}
