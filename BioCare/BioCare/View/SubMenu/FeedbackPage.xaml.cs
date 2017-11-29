using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioCare.View.PopUpPages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FeedbackPage : ContentPage
	{
		public FeedbackPage ()
		{
			InitializeComponent ();
		}

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (Feedbackeditor.Text == "")
            {
                Remarkplaceholder.IsVisible = true;
            }
            else
            {
                Remarkplaceholder.IsVisible = false;
            }
                
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterPage(new BookingTappedPage("new"));
        }

        private async Task BtnFeedSubmit_ClickedAsync(object sender, EventArgs e)
        {
            var alertResult = new FeedbackAlert();
            await PopupNavigation.PushAsync(alertResult);

            //var alertResult = await DisplayAlert("Feedback Confirmation", "Your feedback has been successfully submitted", null, "OK");
            //if (!alertResult)
            //{
            //    App.Current.MainPage = new MasterPage(new BookingTappedPage("new"));
            //  //  await Navigation.PushAsync(new BookingTappedPage("new"));

            //}
        }

      
    }
}