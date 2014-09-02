using System;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;

namespace NavigationParameters.Core
{
	public static class MvxViewNavigationParameters
	{
		public static MvxBundle Create(MvxViewNavigationFlags flags)
		{
			return new MvxBundle(new Dictionary<string, string>() { {"NavigationFlags", flags.ToString() } });
		}

		public static MvxViewNavigationFlags GetNavigationFlags(IDictionary<string, string> presentationValues)
		{
			MvxViewNavigationFlags flags = 0;
			if (presentationValues != null && presentationValues.ContainsKey ("NavigationFlags")) {
				flags = (MvxViewNavigationFlags)(int.Parse(presentationValues ["NavigationFlags"]));
			}
			return flags;
		}
	}
}

