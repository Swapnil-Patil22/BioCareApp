using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioCare.View.SubMenu;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace BioCare.View.PopUpPages
{
    public partial class FeedbackAlert : PopupPage
    {
        public FeedbackAlert()
        {
            InitializeComponent();
        }

        async private void Ok_ButtonClicked(object sender, EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            closebtn.IsEnabled = false;
            okbtn.IsEnabled = false;
            App.Current.MainPage = new MasterPage(new BookingTappedPage("new"));
        }

        async void CloseButton_Tapped(object sender, System.EventArgs e)
        {
            var currentpage = this;
            await Navigation.RemovePopupPageAsync(currentpage);
            closebtn.IsEnabled = false;
            okbtn.IsEnabled = false;
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
