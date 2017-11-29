using BioCare.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using BioCare.View.PopUpPages;
using Rg.Plugins.Popup.Services;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {

        public MasterPage(Page Pageref)
        {

            try
            {
                InitializeComponent();

                List<MasterPageItem> fullmenuList = new List<MasterPageItem>();

                fullmenuList.Add(new MasterPageItem("My Dashboard", "dashboard.png", typeof(DashBoardPage)));
                fullmenuList.Add(new MasterPageItem("My Profile", "profile.png", typeof(ProfilePage)));
                fullmenuList.Add(new MasterPageItem("Bookings", "booking.png", typeof(TabbedPage2)));
                fullmenuList.Add(new MasterPageItem("Calendar", "calendar.png", typeof(CalendarPage)));
                fullmenuList.Add(new MasterPageItem("Contact Us", "contact.png", typeof(ContactPage)));
                fullmenuList.Add(new MasterPageItem("Logout", "logout.png", typeof(LogoutPage)));

                navigateDrawerList.ItemsSource = fullmenuList;
                Page Ref = Pageref;
                Detail = new NavigationPage(Ref) /*{ BarBackgroundColor = Color.FromHex("#0E197C") }*/;

                this.IsPresented = false;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }



        private async Task OnMenuItemTappedAsync(object sender, ItemTappedEventArgs ea)
        {

            MasterPageItem masterItemObj = (MasterPageItem)ea.Item;

            string name = masterItemObj.Title;

            //if (name == "Bookings")
            //{
            //    App.Current.MainPage = new MasterPage(new BookingTappedPage("tab1"));
                
            //    IsPresented = false;
            //}

            //else 
            
            if (name == "Logout")

            {
                var alertResult = new LogoutAlert();
                await PopupNavigation.PushAsync(alertResult);
                //var alertResult = await DisplayAlert("Logout", "Are You Sure", "No", "Yes");
                //if (!alertResult)
                //{

                //    App.Current.MainPage = new NavigationPage(new MainPage());

                //}

                //else
                //{
                //    App.Current.MainPage = new MasterPage(new DashBoardPage());
                //}

            }

            else
            {
                Type page = masterItemObj.TargetType;
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));

                IsPresented = false;
            }

        }

        //int _tapCount = 0;
        //private void ViewCell_Tapped(object sender, EventArgs e)
        //{
        //    ViewCell obj1 = (ViewCell)sender;
        //    ViewCell obj2 = (ViewCell)sender;

        //    _tapCount += 1;
        //    if (_tapCount > 1)
        //    {
        //     //   _tapCount = 0;
        //        obj1.View.BackgroundColor = Color.White;
        //        obj2.View.BackgroundColor = Color.DarkGray;
        //        return;
        //    }            
        //    obj1.View.BackgroundColor = Color.DarkGray;
        //    /*Color.FromHex("#0E197C");*/
        //}

    }
}