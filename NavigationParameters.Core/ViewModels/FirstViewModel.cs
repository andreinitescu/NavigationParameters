using Cirrious.MvvmCross.ViewModels;

namespace NavigationParameters.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

		public IMvxCommand ShowNextViewCommand { get { return new MvxCommand (() => this.ShowViewModel<SecondViewModel> ()); } }
    }
}
