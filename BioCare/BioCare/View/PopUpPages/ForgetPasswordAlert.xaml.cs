using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace BioCare.View.PopUpPages
{
    public partial class ForgetPasswordAlert : PopupPage
    {
        public ForgetPasswordAlert()
        {
            InitializeComponent();
        }

        async void Ok_ButtonClicked(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        async void CloseButton_Tapped(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
        }

        private async void CloseAllPopup()
        {
            await Application.Current.MainPage.Navigation.PopAllPopupAsync();
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
            // return true;
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
