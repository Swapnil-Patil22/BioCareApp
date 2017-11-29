using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioCare.View.Wizard;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage
    {
       private BookingWizard bookingWizard;

        public DashBoardPage()
        {
          
            InitializeComponent();
        }

        //public DashBoardPage(BookingWizard bookingWizard)
        //{
        //    this.bookingWizard = bookingWizard;
        //}

        private void CompletedBookings_OnTapped(object sender, EventArgs e)
        {

           Navigation.PushAsync(new BookingTappedPage("tab1"));

          
        }

        private void PendingBookings_OnTapped(object sender, EventArgs e)
        {

            Navigation.PushAsync(new BookingTappedPage("tab2"));

        }

        private void RemindersPage_OnTapped(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new ReminderPage());

        }

        private void NotificationPage_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationPage());

        }

     
    }
}