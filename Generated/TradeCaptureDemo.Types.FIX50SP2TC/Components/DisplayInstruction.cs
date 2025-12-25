using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class DisplayInstruction : IFixComponent
	{
		[TagDetails(Tag = 1138, Type = TagType.Float, Offset = 0, Required = false)]
		public double? DisplayQty {get; set;}
		
		[TagDetails(Tag = 1082, Type = TagType.Float, Offset = 1, Required = false)]
		public double? SecondaryDisplayQty {get; set;}
		
		[TagDetails(Tag = 1608, Type = TagType.Float, Offset = 2, Required = false)]
		public double? InitialDisplayQty {get; set;}
		
		[TagDetails(Tag = 2828, Type = TagType.Float, Offset = 3, Required = false)]
		public double? CurrentDisplayPrice {get; set;}
		
		[TagDetails(Tag = 1083, Type = TagType.String, Offset = 4, Required = false)]
		public string? DisplayWhen {get; set;}
		
		[TagDetails(Tag = 1084, Type = TagType.String, Offset = 5, Required = false)]
		public string? DisplayMethod {get; set;}
		
		[TagDetails(Tag = 1085, Type = TagType.Float, Offset = 6, Required = false)]
		public double? DisplayLowQty {get; set;}
		
		[TagDetails(Tag = 1086, Type = TagType.Float, Offset = 7, Required = false)]
		public double? DisplayHighQty {get; set;}
		
		[TagDetails(Tag = 1087, Type = TagType.Float, Offset = 8, Required = false)]
		public double? DisplayMinIncr {get; set;}
		
		[TagDetails(Tag = 1088, Type = TagType.Float, Offset = 9, Required = false)]
		public double? RefreshQty {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (DisplayQty is not null) writer.WriteNumber(1138, DisplayQty.Value);
			if (SecondaryDisplayQty is not null) writer.WriteNumber(1082, SecondaryDisplayQty.Value);
			if (InitialDisplayQty is not null) writer.WriteNumber(1608, InitialDisplayQty.Value);
			if (CurrentDisplayPrice is not null) writer.WriteNumber(2828, CurrentDisplayPrice.Value);
			if (DisplayWhen is not null) writer.WriteString(1083, DisplayWhen);
			if (DisplayMethod is not null) writer.WriteString(1084, DisplayMethod);
			if (DisplayLowQty is not null) writer.WriteNumber(1085, DisplayLowQty.Value);
			if (DisplayHighQty is not null) writer.WriteNumber(1086, DisplayHighQty.Value);
			if (DisplayMinIncr is not null) writer.WriteNumber(1087, DisplayMinIncr.Value);
			if (RefreshQty is not null) writer.WriteNumber(1088, RefreshQty.Value);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			DisplayQty = view.GetDouble(1138);
			SecondaryDisplayQty = view.GetDouble(1082);
			InitialDisplayQty = view.GetDouble(1608);
			CurrentDisplayPrice = view.GetDouble(2828);
			DisplayWhen = view.GetString(1083);
			DisplayMethod = view.GetString(1084);
			DisplayLowQty = view.GetDouble(1085);
			DisplayHighQty = view.GetDouble(1086);
			DisplayMinIncr = view.GetDouble(1087);
			RefreshQty = view.GetDouble(1088);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "DisplayQty":
				{
					value = DisplayQty;
					break;
				}
				case "SecondaryDisplayQty":
				{
					value = SecondaryDisplayQty;
					break;
				}
				case "InitialDisplayQty":
				{
					value = InitialDisplayQty;
					break;
				}
				case "CurrentDisplayPrice":
				{
					value = CurrentDisplayPrice;
					break;
				}
				case "DisplayWhen":
				{
					value = DisplayWhen;
					break;
				}
				case "DisplayMethod":
				{
					value = DisplayMethod;
					break;
				}
				case "DisplayLowQty":
				{
					value = DisplayLowQty;
					break;
				}
				case "DisplayHighQty":
				{
					value = DisplayHighQty;
					break;
				}
				case "DisplayMinIncr":
				{
					value = DisplayMinIncr;
					break;
				}
				case "RefreshQty":
				{
					value = RefreshQty;
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
			DisplayQty = null;
			SecondaryDisplayQty = null;
			InitialDisplayQty = null;
			CurrentDisplayPrice = null;
			DisplayWhen = null;
			DisplayMethod = null;
			DisplayLowQty = null;
			DisplayHighQty = null;
			DisplayMinIncr = null;
			RefreshQty = null;
		}
	}
}
