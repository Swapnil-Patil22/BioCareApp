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
	public partial class ReminderPage : ContentPage
	{
		public ReminderPage ()
		{
			InitializeComponent ();
            List<ReminderModel> data1 = ReminderController.InstanceCreation().GetRemindersData();

            ReminderList.ItemsSource = data1;
        }

        int _tapCount = 0;
        private void ReminderList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            _tapCount += 1;
            if (_tapCount > 1)
            {
                _tapCount = 0;
                ReminderList.SelectedItem = Color.White;
                return;
            }
            Navigation.PushAsync(new ReminderPageSelectedList(e.Item as ReminderModel));
        }

        private void ViewCellReminder_Tapped(object sender, EventArgs e)
        {
            ViewCell obj = (ViewCell)sender;
            obj.View.BackgroundColor = Color.White;
        }

    }
}