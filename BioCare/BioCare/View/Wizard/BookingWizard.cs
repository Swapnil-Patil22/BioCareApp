using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BioCare.View.Wizard
{
  public  class BookingWizard : PopupPage
    {
        public BookingWizard()
        {
            Title = "Task Details";
            BackgroundColor = Color.White;

            Label bookingNoLabelValue = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
               
                Text = "Booking No",
                TextColor = Color.LightGray,
            };

            Label bookingNoSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "BN0001",
                TextColor = Color.Gray,
            };

            Label appointDateTimeLabel = new Label
            {
                
                
                VerticalOptions = LayoutOptions.Center,
                Text = "AppointmentDateTime",
                TextColor = Color.LightGray,
            };

            Label appointDateTimeSampleText = new Label
            {

                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                Text = "9/20/2017 8:30 AM",
                TextColor = Color.Gray,
            };

            Label typeOfServiceLabel = new Label
            {
             
               
                VerticalOptions = LayoutOptions.Center,
                Text = "TypeOfService",
                TextColor = Color.LightGray,
            };

            Label typeOfServiceSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Testing Service",
                TextColor = Color.Gray,
            };

            Label locationLabel = new Label
            {
               
                
                VerticalOptions = LayoutOptions.Center,
                Text = "Location",
                TextColor = Color.LightGray,
            };

            Label locationSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Singapore",
                TextColor = Color.Gray,
            };


            Label statusLabel = new Label
            {
                
                
                VerticalOptions = LayoutOptions.Center,
                Text = "Status",
                TextColor = Color.LightGray,
            };

            Label statusSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Completed",
                TextColor = Color.Gray,
            };


            Label vehicleLabel = new Label
            {
               
                
                VerticalOptions = LayoutOptions.Center,
                Text = "Vehicle",
                TextColor = Color.LightGray,
            };

            Label vehicleSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = " Car",
                TextColor = Color.Gray,
            };


            Label equipmentLabel = new Label
            {
              
            
                VerticalOptions = LayoutOptions.Center,
                Text = "Equipment ",
                TextColor = Color.LightGray,
            };

            Label equipmentSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = " Sample Text",
                TextColor = Color.Gray,
            };


            Label teamNameLabel = new Label
            {
              
               FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                Text = "TeamName ",
                TextColor = Color.LightGray,
            };


            Label teamNameSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Management",
                TextColor = Color.Gray,
            };


            Label teamLeaderLabel = new Label
            {
                
                
                VerticalOptions = LayoutOptions.Center,
                Text = "TeamLeader ",
                TextColor = Color.LightGray,
            };

            Label teamLeaderSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Sang",
                TextColor = Color.Gray,
            };

            Label employeesLabel = new Label
            {
               
               
                VerticalOptions = LayoutOptions.Center,
                Text = "Employees",
                TextColor = Color.LightGray,
            };

            Label employeesSampleText = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                Text = "Sample",
                TextColor = Color.Gray,
            };

            StackLayout stackAllLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(20, 0, 0, 0),
                BackgroundColor = Color.White
            };


            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(bookingNoLabelValue);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(bookingNoSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(appointDateTimeLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(appointDateTimeSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(typeOfServiceLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(typeOfServiceSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(locationLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(locationSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 5, Color = Color.Transparent });
            stackAllLayout.Children.Add(statusLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(statusSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(vehicleLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(vehicleSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(equipmentLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(equipmentSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(teamNameLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(teamNameSampleText);

            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(employeesLabel);
            stackAllLayout.Children.Add(new BoxView { HeightRequest = 2, Color = Color.Transparent });
            stackAllLayout.Children.Add(employeesSampleText);

            var scroll = new ScrollView
           {
                Content = stackAllLayout
            };
            Content = scroll;


        }
    }
}
