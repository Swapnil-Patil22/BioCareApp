using BioCare.View.SubMenu;
using BioCare.View.Wizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignInPage : ContentPage
	{
		public SignInPage ()
		{
            

            try
            {
                NavigationPage.SetHasNavigationBar(this, false);
                InitializeComponent();
            }

            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);

            }

        }

        private void TapGestureRecognizer_Forgot_Password(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordWizard());
        }

        private void DashboadPage_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterPage(new DashBoardPage());

        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            Navigation.PushAsync(new MainPage());
            return true;
        }

        //async void SignInAction(object sender, EventArgs e)
        //{

        //    App.Current.MainPage = new NavigationPage(new RegisterPage());
        //}
    }
}