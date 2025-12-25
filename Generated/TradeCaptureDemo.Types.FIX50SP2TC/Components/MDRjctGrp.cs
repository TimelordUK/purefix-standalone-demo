using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class MDRjctGrp : IFixComponent
	{
		public sealed partial class NoAltMDSource : IFixGroup
		{
			[TagDetails(Tag = 817, Type = TagType.String, Offset = 0, Required = false)]
			public string? AltMDSourceID {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (AltMDSourceID is not null) writer.WriteString(817, AltMDSourceID);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				AltMDSourceID = view.GetString(817);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "AltMDSourceID":
					{
						value = AltMDSourceID;
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
				AltMDSourceID = null;
			}
		}
		[Group(NoOfTag = 816, Offset = 0, Required = false)]
		public NoAltMDSource[]? AltMDSource {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (AltMDSource is not null && AltMDSource.Length != 0)
			{
				writer.WriteWholeNumber(816, AltMDSource.Length);
				for (int i = 0; i < AltMDSource.Length; i++)
				{
					((IFixEncoder)AltMDSource[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoAltMDSource") is IMessageView viewNoAltMDSource)
			{
				var count = viewNoAltMDSource.GroupCount();
				AltMDSource = new NoAltMDSource[count];
				for (int i = 0; i < count; i++)
				{
					AltMDSource[i] = new();
					((IFixParser)AltMDSource[i]).Parse(viewNoAltMDSource.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoAltMDSource":
				{
					value = AltMDSource;
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
			AltMDSource = null;
		}
	}
}
