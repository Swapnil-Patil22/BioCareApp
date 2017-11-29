using BioCare.View;
using BioCare.View.SubMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BioCare
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

        }
        async void HomeSignIn_OnClicked(object sender, EventArgs e)
        {
            try
            { 
                Page Pageref = new SignInPage();
                App.Current.MainPage = new NavigationPage(Pageref);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Warning" + ex.Message);
            }
        }

        //async void RegisterPage_OnClicked(object sender, EventArgs e)
        //{          
        //    App.Current.MainPage = new NavigationPage(new RegisterPage());
        //}
    }
}
