using BioCare.Model;
using BioCare.View.Wizard;
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
	public partial class NotificationPage : ContentPage
	{
		public NotificationPage ()
		{
            InitializeComponent();
            List<NotificationModel> data2 = NotificationController.InstanceCreation().GetNotificationsData();

            NotificationsList.ItemsSource = data2;
        }

        int _tapCount = 0;
        private void NotificationsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            _tapCount += 1;
            if (_tapCount > 1)
            {
                _tapCount = 0;
                NotificationsList.SelectedItem = Color.White;
                return;
            }
            Navigation.PushAsync(new NotificationsPageSelected(e.Item as NotificationModel));
        }

        private void ViewCellNotifications_Tapped(object sender, EventArgs e)
        {
            ViewCell obj = (ViewCell)sender;
            obj.View.BackgroundColor = Color.White;
        }
    }
}