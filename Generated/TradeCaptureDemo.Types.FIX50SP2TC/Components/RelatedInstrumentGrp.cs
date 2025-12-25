using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class RelatedInstrumentGrp : IFixComponent
	{
		public sealed partial class NoRelatedInstruments : IFixGroup
		{
			[TagDetails(Tag = 1648, Type = TagType.Int, Offset = 0, Required = false)]
			public int? RelatedInstrumentType {get; set;}
			
			[TagDetails(Tag = 1649, Type = TagType.String, Offset = 1, Required = false)]
			public string? RelatedSymbol {get; set;}
			
			[TagDetails(Tag = 1650, Type = TagType.String, Offset = 2, Required = false)]
			public string? RelatedSecurityID {get; set;}
			
			[TagDetails(Tag = 1651, Type = TagType.String, Offset = 3, Required = false)]
			public string? RelatedSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 1652, Type = TagType.String, Offset = 4, Required = false)]
			public string? RelatedSecurityType {get; set;}
			
			[TagDetails(Tag = 1653, Type = TagType.MonthYear, Offset = 5, Required = false)]
			public MonthYear? RelatedMaturityMonthYear {get; set;}
			
			[TagDetails(Tag = 2413, Type = TagType.String, Offset = 6, Required = false)]
			public string? RelatedToSecurityID {get; set;}
			
			[TagDetails(Tag = 2414, Type = TagType.String, Offset = 7, Required = false)]
			public string? RelatedToSecurityIDSource {get; set;}
			
			[TagDetails(Tag = 2415, Type = TagType.String, Offset = 8, Required = false)]
			public string? RelatedToStreamXIDRef {get; set;}
			
			[TagDetails(Tag = 2417, Type = TagType.String, Offset = 9, Required = false)]
			public string? RelatedToDividendPeriodXIDRef {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (RelatedInstrumentType is not null) writer.WriteWholeNumber(1648, RelatedInstrumentType.Value);
				if (RelatedSymbol is not null) writer.WriteString(1649, RelatedSymbol);
				if (RelatedSecurityID is not null) writer.WriteString(1650, RelatedSecurityID);
				if (RelatedSecurityIDSource is not null) writer.WriteString(1651, RelatedSecurityIDSource);
				if (RelatedSecurityType is not null) writer.WriteString(1652, RelatedSecurityType);
				if (RelatedMaturityMonthYear is not null) writer.WriteMonthYear(1653, RelatedMaturityMonthYear.Value);
				if (RelatedToSecurityID is not null) writer.WriteString(2413, RelatedToSecurityID);
				if (RelatedToSecurityIDSource is not null) writer.WriteString(2414, RelatedToSecurityIDSource);
				if (RelatedToStreamXIDRef is not null) writer.WriteString(2415, RelatedToStreamXIDRef);
				if (RelatedToDividendPeriodXIDRef is not null) writer.WriteString(2417, RelatedToDividendPeriodXIDRef);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				RelatedInstrumentType = view.GetInt32(1648);
				RelatedSymbol = view.GetString(1649);
				RelatedSecurityID = view.GetString(1650);
				RelatedSecurityIDSource = view.GetString(1651);
				RelatedSecurityType = view.GetString(1652);
				RelatedMaturityMonthYear = view.GetMonthYear(1653);
				RelatedToSecurityID = view.GetString(2413);
				RelatedToSecurityIDSource = view.GetString(2414);
				RelatedToStreamXIDRef = view.GetString(2415);
				RelatedToDividendPeriodXIDRef = view.GetString(2417);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "RelatedInstrumentType":
					{
						value = RelatedInstrumentType;
						break;
					}
					case "RelatedSymbol":
					{
						value = RelatedSymbol;
						break;
					}
					case "RelatedSecurityID":
					{
						value = RelatedSecurityID;
						break;
					}
					case "RelatedSecurityIDSource":
					{
						value = RelatedSecurityIDSource;
						break;
					}
					case "RelatedSecurityType":
					{
						value = RelatedSecurityType;
						break;
					}
					case "RelatedMaturityMonthYear":
					{
						value = RelatedMaturityMonthYear;
						break;
					}
					case "RelatedToSecurityID":
					{
						value = RelatedToSecurityID;
						break;
					}
					case "RelatedToSecurityIDSource":
					{
						value = RelatedToSecurityIDSource;
						break;
					}
					case "RelatedToStreamXIDRef":
					{
						value = RelatedToStreamXIDRef;
						break;
					}
					case "RelatedToDividendPeriodXIDRef":
					{
						value = RelatedToDividendPeriodXIDRef;
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
				RelatedInstrumentType = null;
				RelatedSymbol = null;
				RelatedSecurityID = null;
				RelatedSecurityIDSource = null;
				RelatedSecurityType = null;
				RelatedMaturityMonthYear = null;
				RelatedToSecurityID = null;
				RelatedToSecurityIDSource = null;
				RelatedToStreamXIDRef = null;
				RelatedToDividendPeriodXIDRef = null;
			}
		}
		[Group(NoOfTag = 1647, Offset = 0, Required = false)]
		public NoRelatedInstruments[]? RelatedInstruments {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (RelatedInstruments is not null && RelatedInstruments.Length != 0)
			{
				writer.WriteWholeNumber(1647, RelatedInstruments.Length);
				for (int i = 0; i < RelatedInstruments.Length; i++)
				{
					((IFixEncoder)RelatedInstruments[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoRelatedInstruments") is IMessageView viewNoRelatedInstruments)
			{
				var count = viewNoRelatedInstruments.GroupCount();
				RelatedInstruments = new NoRelatedInstruments[count];
				for (int i = 0; i < count; i++)
				{
					RelatedInstruments[i] = new();
					((IFixParser)RelatedInstruments[i]).Parse(viewNoRelatedInstruments.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoRelatedInstruments":
				{
					value = RelatedInstruments;
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
			RelatedInstruments = null;
		}
	}
}
