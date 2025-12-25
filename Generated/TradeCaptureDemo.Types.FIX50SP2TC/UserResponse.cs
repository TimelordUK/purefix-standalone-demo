using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	[MessageType("BF", FixVersion.FIX50SP2)]
	public sealed partial class UserResponse : IFixMessage
	{
		[Component(Offset = 0, Required = true)]
		public StandardHeader? StandardHeader {get; set;}
		
		[TagDetails(Tag = 923, Type = TagType.String, Offset = 1, Required = true)]
		public string? UserRequestID {get; set;}
		
		[TagDetails(Tag = 553, Type = TagType.String, Offset = 2, Required = true)]
		public string? Username {get; set;}
		
		[TagDetails(Tag = 926, Type = TagType.Int, Offset = 3, Required = false)]
		public int? UserStatus {get; set;}
		
		[Component(Offset = 4, Required = false)]
		public ThrottleParamsGrp? ThrottleParamsGrp {get; set;}
		
		[TagDetails(Tag = 927, Type = TagType.String, Offset = 5, Required = false)]
		public string? UserStatusText {get; set;}
		
		[Component(Offset = 6, Required = true)]
		public StandardTrailer? StandardTrailer {get; set;}
		
		
		IStandardHeader? IFixMessage.StandardHeader => StandardHeader;
		
		IStandardTrailer? IFixMessage.StandardTrailer => StandardTrailer;
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return (!config.CheckStandardHeader || (StandardHeader is not null && ((IFixValidator)StandardHeader).IsValid(in config))) && (!config.CheckStandardTrailer || (StandardTrailer is not null && ((IFixValidator)StandardTrailer).IsValid(in config)));
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (StandardHeader is not null) ((IFixEncoder)StandardHeader).Encode(writer);
			if (UserRequestID is not null) writer.WriteString(923, UserRequestID);
			if (Username is not null) writer.WriteString(553, Username);
			if (UserStatus is not null) writer.WriteWholeNumber(926, UserStatus.Value);
			if (ThrottleParamsGrp is not null) ((IFixEncoder)ThrottleParamsGrp).Encode(writer);
			if (UserStatusText is not null) writer.WriteString(927, UserStatusText);
			if (StandardTrailer is not null) ((IFixEncoder)StandardTrailer).Encode(writer);
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("StandardHeader") is IMessageView viewStandardHeader)
			{
				StandardHeader = new();
				((IFixParser)StandardHeader).Parse(viewStandardHeader);
			}
			UserRequestID = view.GetString(923);
			Username = view.GetString(553);
			UserStatus = view.GetInt32(926);
			if (view.GetView("ThrottleParamsGrp") is IMessageView viewThrottleParamsGrp)
			{
				ThrottleParamsGrp = new();
				((IFixParser)ThrottleParamsGrp).Parse(viewThrottleParamsGrp);
			}
			UserStatusText = view.GetString(927);
			if (view.GetView("StandardTrailer") is IMessageView viewStandardTrailer)
			{
				StandardTrailer = new();
				((IFixParser)StandardTrailer).Parse(viewStandardTrailer);
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "StandardHeader":
				{
					value = StandardHeader;
					break;
				}
				case "UserRequestID":
				{
					value = UserRequestID;
					break;
				}
				case "Username":
				{
					value = Username;
					break;
				}
				case "UserStatus":
				{
					value = UserStatus;
					break;
				}
				case "ThrottleParamsGrp":
				{
					value = ThrottleParamsGrp;
					break;
				}
				case "UserStatusText":
				{
					value = UserStatusText;
					break;
				}
				case "StandardTrailer":
				{
					value = StandardTrailer;
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
			((IFixReset?)StandardHeader)?.Reset();
			UserRequestID = null;
			Username = null;
			UserStatus = null;
			((IFixReset?)ThrottleParamsGrp)?.Reset();
			UserStatusText = null;
			((IFixReset?)StandardTrailer)?.Reset();
		}
	}
}
