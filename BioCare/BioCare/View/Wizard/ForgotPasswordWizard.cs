using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BioCare.View.PopUpPages;
using Rg.Plugins.Popup.Services;

namespace BioCare.View.Wizard
{
    class ForgotPasswordWizard : ContentPage
    {
        public ForgotPasswordWizard()
        {
            Title = "Forgot Password";
            BackgroundColor = Color.White;


            var secimage = new Image

            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100

            };

            secimage.Source = ImageSource.FromFile("security.png");


            Label subjectLabel = new Label
            {
                Margin = 20,
                Text = "Please provide your Email address below and we will send your password shortly",
                TextColor = Color.Gray,
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                XAlign = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };


            var mailimage = new Image

            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 20,
                HeightRequest = 20

            };

            mailimage.Source = ImageSource.FromFile("mail.png");

            Entry subjectEntry = new Entry
            {
                // HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Gray,
                Placeholder = "Enter Your Email                                    ",
                Text = "",
            };

            StackLayout mailLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = 20,
            };
            mailLayout.Children.Add(mailimage);
            mailLayout.Children.Add(subjectEntry);






            Button forgotbutton = new Button
            {
                Text = "Send",
                BackgroundColor = Color.FromHex("#0E197C"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 150,


            };
            forgotbutton.Clicked += Forgotbutton_Clicked;

            StackLayout stackAllLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(20, 0, 20, 0)
            };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.White,
                Spacing = 0,
                Padding = 5,
                Children = {

                        new BoxView{ HeightRequest=10},
                        secimage,
                         new BoxView{ HeightRequest=10},
                        subjectLabel,
                        new BoxView{HeightRequest = 5 },
                        mailLayout,
                        new BoxView{ HeightRequest=20},
                        forgotbutton,

                            }
            };



        }

        async void Forgotbutton_Clicked(object sender, EventArgs e)
        {
            var alertResult = new ForgetPasswordAlert();

            await PopupNavigation.PushAsync(alertResult);


            //var alertResult = await DisplayAlert("Alert", "Password successfully sent to Email", null, "OK");
            //if (!alertResult)
            //{
            //    App.Current.MainPage = new NavigationPage(new SignInPage());
            //}

        }

        private void BtnsubmitAction(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
