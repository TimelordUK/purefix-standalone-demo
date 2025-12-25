using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingPaymentStreamPaymentDateGrp : IFixComponent
	{
		public sealed partial class NoUnderlyingPaymentStreamPaymentDates : IFixGroup
		{
			[TagDetails(Tag = 41938, Type = TagType.LocalDate, Offset = 0, Required = false)]
			public DateOnly? UnderlyingPaymentStreamPaymentDate {get; set;}
			
			[TagDetails(Tag = 41939, Type = TagType.Int, Offset = 1, Required = false)]
			public int? UnderlyingPaymentStreamPaymentDateType {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPaymentStreamPaymentDate is not null) writer.WriteLocalDateOnly(41938, UnderlyingPaymentStreamPaymentDate.Value);
				if (UnderlyingPaymentStreamPaymentDateType is not null) writer.WriteWholeNumber(41939, UnderlyingPaymentStreamPaymentDateType.Value);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPaymentStreamPaymentDate = view.GetDateOnly(41938);
				UnderlyingPaymentStreamPaymentDateType = view.GetInt32(41939);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPaymentStreamPaymentDate":
					{
						value = UnderlyingPaymentStreamPaymentDate;
						break;
					}
					case "UnderlyingPaymentStreamPaymentDateType":
					{
						value = UnderlyingPaymentStreamPaymentDateType;
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
				UnderlyingPaymentStreamPaymentDate = null;
				UnderlyingPaymentStreamPaymentDateType = null;
			}
		}
		[Group(NoOfTag = 41937, Offset = 0, Required = false)]
		public NoUnderlyingPaymentStreamPaymentDates[]? UnderlyingPaymentStreamPaymentDates {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingPaymentStreamPaymentDates is not null && UnderlyingPaymentStreamPaymentDates.Length != 0)
			{
				writer.WriteWholeNumber(41937, UnderlyingPaymentStreamPaymentDates.Length);
				for (int i = 0; i < UnderlyingPaymentStreamPaymentDates.Length; i++)
				{
					((IFixEncoder)UnderlyingPaymentStreamPaymentDates[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingPaymentStreamPaymentDates") is IMessageView viewNoUnderlyingPaymentStreamPaymentDates)
			{
				var count = viewNoUnderlyingPaymentStreamPaymentDates.GroupCount();
				UnderlyingPaymentStreamPaymentDates = new NoUnderlyingPaymentStreamPaymentDates[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingPaymentStreamPaymentDates[i] = new();
					((IFixParser)UnderlyingPaymentStreamPaymentDates[i]).Parse(viewNoUnderlyingPaymentStreamPaymentDates.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingPaymentStreamPaymentDates":
				{
					value = UnderlyingPaymentStreamPaymentDates;
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
			UnderlyingPaymentStreamPaymentDates = null;
		}
	}
}
