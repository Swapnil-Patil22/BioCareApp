using BioCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BioCare.View.Wizard;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PendingBookingPage : ContentPage
    {
        public PendingBookingPage()
        {
            InitializeComponent();
            List<BookingModel> data = Controller.InstanceCreation().GetBookingData();

            pendingBookingList.ItemsSource = data;


        }


        int _tapCount = 0;
        private void pendingBook_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new BookingWizard());
            // Navigation.PushAsync(new BookingWizard());
            _tapCount += 1;
            if (_tapCount > 1)
            {
                _tapCount = 0;
                pendingBookingList.SelectedItem = Color.White;
                return;
            }
            Navigation.PushAsync(new PendingPageSelectedList(e.Item as BookingModel));
        }

        private void ViewCellPending_Tapped(object sender, EventArgs e)
        {
            ViewCell obj = (ViewCell)sender;
            obj.View.BackgroundColor = Color.White;
        }
    }

}