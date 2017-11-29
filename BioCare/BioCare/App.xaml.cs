using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BioCare
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //  App.Current.MainPage = new NavigationPage(new MainPage());
            MainPage = new BioCare.MainPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
