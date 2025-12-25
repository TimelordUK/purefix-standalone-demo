using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UnderlyingAmount : IFixComponent
	{
		public sealed partial class NoUnderlyingAmounts : IFixGroup
		{
			[TagDetails(Tag = 985, Type = TagType.Float, Offset = 0, Required = false)]
			public double? UnderlyingPayAmount {get; set;}
			
			[TagDetails(Tag = 986, Type = TagType.Float, Offset = 1, Required = false)]
			public double? UnderlyingCollectAmount {get; set;}
			
			[TagDetails(Tag = 987, Type = TagType.LocalDate, Offset = 2, Required = false)]
			public DateOnly? UnderlyingSettlementDate {get; set;}
			
			[TagDetails(Tag = 988, Type = TagType.String, Offset = 3, Required = false)]
			public string? UnderlyingSettlementStatus {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (UnderlyingPayAmount is not null) writer.WriteNumber(985, UnderlyingPayAmount.Value);
				if (UnderlyingCollectAmount is not null) writer.WriteNumber(986, UnderlyingCollectAmount.Value);
				if (UnderlyingSettlementDate is not null) writer.WriteLocalDateOnly(987, UnderlyingSettlementDate.Value);
				if (UnderlyingSettlementStatus is not null) writer.WriteString(988, UnderlyingSettlementStatus);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				UnderlyingPayAmount = view.GetDouble(985);
				UnderlyingCollectAmount = view.GetDouble(986);
				UnderlyingSettlementDate = view.GetDateOnly(987);
				UnderlyingSettlementStatus = view.GetString(988);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "UnderlyingPayAmount":
					{
						value = UnderlyingPayAmount;
						break;
					}
					case "UnderlyingCollectAmount":
					{
						value = UnderlyingCollectAmount;
						break;
					}
					case "UnderlyingSettlementDate":
					{
						value = UnderlyingSettlementDate;
						break;
					}
					case "UnderlyingSettlementStatus":
					{
						value = UnderlyingSettlementStatus;
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
				UnderlyingPayAmount = null;
				UnderlyingCollectAmount = null;
				UnderlyingSettlementDate = null;
				UnderlyingSettlementStatus = null;
			}
		}
		[Group(NoOfTag = 984, Offset = 0, Required = false)]
		public NoUnderlyingAmounts[]? UnderlyingAmounts {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (UnderlyingAmounts is not null && UnderlyingAmounts.Length != 0)
			{
				writer.WriteWholeNumber(984, UnderlyingAmounts.Length);
				for (int i = 0; i < UnderlyingAmounts.Length; i++)
				{
					((IFixEncoder)UnderlyingAmounts[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUnderlyingAmounts") is IMessageView viewNoUnderlyingAmounts)
			{
				var count = viewNoUnderlyingAmounts.GroupCount();
				UnderlyingAmounts = new NoUnderlyingAmounts[count];
				for (int i = 0; i < count; i++)
				{
					UnderlyingAmounts[i] = new();
					((IFixParser)UnderlyingAmounts[i]).Parse(viewNoUnderlyingAmounts.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUnderlyingAmounts":
				{
					value = UnderlyingAmounts;
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
			UnderlyingAmounts = null;
		}
	}
}
