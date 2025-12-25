using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Types.FIX50SP2TC.Components
{
	public sealed partial class UsernameGrp : IFixComponent
	{
		public sealed partial class NoUsernames : IFixGroup
		{
			[TagDetails(Tag = 553, Type = TagType.String, Offset = 0, Required = false)]
			public string? Username {get; set;}
			
			
			bool IFixValidator.IsValid(in FixValidatorConfig config)
			{
				return true;
			}
			
			void IFixEncoder.Encode(IFixWriter writer)
			{
				if (Username is not null) writer.WriteString(553, Username);
			}
			
			void IFixParser.Parse(IMessageView? view)
			{
				if (view is null) return;
				
				Username = view.GetString(553);
			}
			
			bool IFixLookup.TryGetByTag(string name, out object? value)
			{
				value = null;
				switch (name)
				{
					case "Username":
					{
						value = Username;
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
				Username = null;
			}
		}
		[Group(NoOfTag = 809, Offset = 0, Required = false)]
		public NoUsernames[]? Usernames {get; set;}
		
		
		bool IFixValidator.IsValid(in FixValidatorConfig config)
		{
			return true;
		}
		
		void IFixEncoder.Encode(IFixWriter writer)
		{
			if (Usernames is not null && Usernames.Length != 0)
			{
				writer.WriteWholeNumber(809, Usernames.Length);
				for (int i = 0; i < Usernames.Length; i++)
				{
					((IFixEncoder)Usernames[i]).Encode(writer);
				}
			}
		}
		
		void IFixParser.Parse(IMessageView? view)
		{
			if (view is null) return;
			
			if (view.GetView("NoUsernames") is IMessageView viewNoUsernames)
			{
				var count = viewNoUsernames.GroupCount();
				Usernames = new NoUsernames[count];
				for (int i = 0; i < count; i++)
				{
					Usernames[i] = new();
					((IFixParser)Usernames[i]).Parse(viewNoUsernames.GetGroupInstance(i));
				}
			}
		}
		
		bool IFixLookup.TryGetByTag(string name, out object? value)
		{
			value = null;
			switch (name)
			{
				case "NoUsernames":
				{
					value = Usernames;
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
			Usernames = null;
		}
	}
}
