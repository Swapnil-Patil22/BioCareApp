using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

        private void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }




        async void RegisterComplete_OnClicked(object sender, EventArgs e)
        {
           

            var alertResult = await DisplayAlert("Alert", "Register Completed", null, "OK");
            if (!alertResult)
            {
                App.Current.MainPage = new NavigationPage(new SignInPage());
            }

        }


        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            Navigation.PushAsync(new MainPage());
            return true;
        }

    }
}