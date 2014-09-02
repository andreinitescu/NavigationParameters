using System;
using Android.Content;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using NavigationParameters.Core;

namespace NavigationParameters.Droid
{
	public class MvxAndroidViewsContainerEx : MvxAndroidViewsContainer
	{
		public MvxAndroidViewsContainerEx (Context applicationContext) : base(applicationContext)
		{
		}

		protected override void AdjustIntentForPresentation (Intent intent, MvxViewModelRequest request)
		{
			var navFlags = MvxViewNavigationParameters.GetNavigationFlags (request.PresentationValues);
			if(navFlags > 0)
			{
				if ((navFlags & MvxViewNavigationFlags.ClearBackStack) == MvxViewNavigationFlags.ClearBackStack) {
					intent.AddFlags (ActivityFlags.ClearTask);
				}

				if ((navFlags & MvxViewNavigationFlags.NoHistory) == MvxViewNavigationFlags.NoHistory) {
					intent.AddFlags (ActivityFlags.NoHistory);
				}
			}

			base.AdjustIntentForPresentation (intent, request);
		}
	}
}

