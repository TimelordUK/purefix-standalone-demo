using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class StandardTrailer : IFixComponent, IStandardTrailer
	{
		[TagDetails(Tag = 93, Type = TagType.Length, Offset = 0, Required = false)]
		public int? SignatureLength {get; set;}
		
		[TagDetails(Tag = 89, Type = TagType.RawData, Offset = 1, Required = false)]
		public byte[]? Signature {get; set;}
		
		[TagDetails(Tag = 10, Type = TagType.String, Offset = 2, Required = true)]
		public string? CheckSum {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (SignatureLength is not null) writer.WriteWholeNumber(93, SignatureLength.Value);
			if (Signature is not null) writer.WriteBuffer(89, Signature);
			if (CheckSum is not null) writer.WriteString(10, CheckSum);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			SignatureLength = view.GetInt32(93);
			Signature = view.GetByteArray(89);
			CheckSum = view.GetString(10);
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "SignatureLength":
				{
					value = SignatureLength;
					break;
				}
				case "Signature":
				{
					value = Signature;
					break;
				}
				case "CheckSum":
				{
					value = CheckSum;
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
			SignatureLength = null;
			Signature = null;
			CheckSum = null;
		}
	}
}
