using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace NavigationParameters.Droid.Views
{
	[Activity(Label = "View for ThirdViewModel")]
    public class ThirdView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}