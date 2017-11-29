using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingTappedPage : TabbedPage
    {


        //public BookingTappedPage()
        //{
        //    initializecomponent();
        //}

        public BookingTappedPage(string tabs)
        {
         //NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            var navigationPage = new NavigationPage(new CompletedBookingPage());
           // navigationPage.Title = "Completed Booking";

            var navigationPage1 = new NavigationPage(new PendingBookingPage());
            //navigationPage1.Title = "Pending Booking";

            Children.Add(new CompletedBookingPage());
           // Children.Add(navigationPage);

            Children.Add(new PendingBookingPage());
            // Children.Add(navigationPage1);

           // var navigation = new NavigationPage();
        //    navigation.BarBackgroundColor = Color.FromHex("#000000");

            var tabPage = this as TabbedPage;

            if (tabs == "tab1")
            {
                tabPage.CurrentPage = tabPage.Children[0];
            }

            else if (tabs == "tab2")
            {
                tabPage.CurrentPage = tabPage.Children[1];
            }

            else
            {

            }


        }



    }
}