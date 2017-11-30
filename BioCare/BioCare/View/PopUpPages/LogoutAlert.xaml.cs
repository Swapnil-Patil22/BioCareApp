using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioCare.View.SubMenu;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace BioCare.View.PopUpPages
{
    public partial class LogoutAlert : PopupPage
    {
        public LogoutAlert()
        {
            InitializeComponent();
        }

       async void NoButton_Clicked(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            closebtn.IsEnabled = false;
            yesbtn.IsEnabled = false;
            nobtn.IsEnabled = false;
            //await Navigation.PopAllPopupAsync();
            App.Current.MainPage = new MasterPage(new DashBoardPage());
        }

        async void YesButton_Clicked(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            closebtn.IsEnabled = false;
            yesbtn.IsEnabled = false;
            nobtn.IsEnabled = false;
            //await Navigation.PopAllPopupAsync();
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

        async void CloseButton_Tapped(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            closebtn.IsEnabled = false;
            yesbtn.IsEnabled = false;
            nobtn.IsEnabled = false;
            //CloseAllPopup();
        }

        private async void CloseAllPopup()
        {
            await Navigation.PopAllPopupAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        // Method for animation child in PopupPage
        // Invoced after custom animation end
        protected override Task OnAppearingAnimationEnd()
        {
            return Content.FadeTo(1);
        }

        // Method for animation child in PopupPage
        // Invoked before custom animation begin
        protected override Task OnDisappearingAnimationBegin()
        {
            return Content.FadeTo(1);
        }

        protected override bool OnBackButtonPressed()
        {
            // Prevent hide popup
            return base.OnBackButtonPressed();
            //return true;
        }

        // Invoced when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Return default value - CloseWhenBackgroundIsClicked
            //return base.OnBackgroundClicked();
            return false;
        }
    }
}
