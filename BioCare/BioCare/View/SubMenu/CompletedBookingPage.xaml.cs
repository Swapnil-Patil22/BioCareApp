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
	public partial class CompletedBookingPage : ContentPage
	{
 

        public CompletedBookingPage ()
		{
           
            InitializeComponent ();
            List<BookingModel> data = Controller.InstanceCreation().GetBookingData();

            completeBookingList.ItemsSource = data;

            completeBookingList.ItemTapped += CompleteBookingList_ItemTapped;

        }

        int _tapCount = 0;
        private void CompleteBookingList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            _tapCount += 1;
            if (_tapCount > 1)
            {
                _tapCount = 0;
                completeBookingList.SelectedItem = Color.White;
                return;
            }
            completeBookingList.SelectedItem = Color.White;
            

            Navigation.PushAsync(new CompletePageSelectedList(e.Item as BookingModel));
        }

        //private void completeBook_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    // App.Current.MainPage = new NavigationPage(new BookingWizard());
        //    // Navigation.PushAsync(new BookingWizard());

            

        //}

        //private void ViewCellComplete_Tapped(object sender, EventArgs e)
        //{
           
        //    ViewCell obj = (ViewCell)sender;
        //    obj.View.BackgroundColor = Color.White;
        //}
    }
}